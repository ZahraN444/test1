// <copyright file="MistAPIClient.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using APIMatic.Core;
using APIMatic.Core.Authentication;
using APIMatic.Core.Utilities.Logger.Configuration;
using MistAPI.Standard.Authentication;
using MistAPI.Standard.Controllers;
using MistAPI.Standard.Http.Client;
using MistAPI.Standard.Logging;
using MistAPI.Standard.Utilities;

namespace MistAPI.Standard
{
    /// <summary>
    /// The gateway for the SDK. This class acts as a factory for Controller and
    /// holds the configuration of the SDK.
    /// </summary>
    public sealed class MistAPIClient : IConfiguration
    {
        // A map of environments and their corresponding servers/baseurls
        private static readonly Dictionary<Environment, Dictionary<Enum, string>> EnvironmentsMap =
            new Dictionary<Environment, Dictionary<Enum, string>>
        {
            {
                Environment.Production, new Dictionary<Enum, string>
                {
                    { Server.Default, "http://example.com" },
                }
            },
        };

        private readonly GlobalConfiguration globalConfiguration;
        private SdkLoggingConfiguration sdkLoggingConfiguration;
        private const string userAgent = "Use placeholders: DotNet 2.99.9 {os-info}";
        private readonly HttpCallback httpCallback;
        private readonly Lazy<OrgsNACTagsController> orgsNACTags;
        private readonly Lazy<OrgsNACPortalsController> orgsNACPortals;

        private MistAPIClient(
            Environment environment,
            ApiTokenModel apiTokenModel,
            BasicAuthModel basicAuthModel,
            CsrfTokenModel csrfTokenModel,
            HttpCallback httpCallback,
            IHttpClientConfiguration httpClientConfiguration,
            SdkLoggingConfiguration sdkLoggingConfiguration)
        {
            this.Environment = environment;
            this.httpCallback = httpCallback;
            this.HttpClientConfiguration = httpClientConfiguration;
            this.sdkLoggingConfiguration = sdkLoggingConfiguration;
            ApiTokenModel = apiTokenModel;
            var apiTokenManager = new ApiTokenManager(apiTokenModel);
            BasicAuthModel = basicAuthModel;
            var basicAuthManager = new BasicAuthManager(basicAuthModel);
            CsrfTokenModel = csrfTokenModel;
            var csrfTokenManager = new CsrfTokenManager(csrfTokenModel);
            globalConfiguration = new GlobalConfiguration.Builder()
                .AuthManagers(new Dictionary<string, AuthManager> {
                    {"apiToken", apiTokenManager},
                    {"basicAuth", basicAuthManager},
                    {"csrfToken", csrfTokenManager},
                })
                .ApiCallback(httpCallback)
                .HttpConfiguration(httpClientConfiguration)
                .ServerUrls(EnvironmentsMap[environment], Server.Default)
                .LoggingConfig(sdkLoggingConfiguration)
                .UserAgent(userAgent)
                .Build();

            ApiTokenCredentials = apiTokenManager;
            BasicAuthCredentials = basicAuthManager;
            CsrfTokenCredentials = csrfTokenManager;

            this.orgsNACTags = new Lazy<OrgsNACTagsController>(
                () => new OrgsNACTagsController(globalConfiguration));
            this.orgsNACPortals = new Lazy<OrgsNACPortalsController>(
                () => new OrgsNACPortalsController(globalConfiguration));
        }

        /// <summary>
        /// Gets OrgsNACTagsController controller.
        /// </summary>
        public OrgsNACTagsController OrgsNACTagsController => this.orgsNACTags.Value;

        /// <summary>
        /// Gets OrgsNACPortalsController controller.
        /// </summary>
        public OrgsNACPortalsController OrgsNACPortalsController => this.orgsNACPortals.Value;

        /// <summary>
        /// Gets the configuration of the Http Client associated with this client.
        /// </summary>
        public IHttpClientConfiguration HttpClientConfiguration { get; }

        /// <summary>
        /// Gets Environment.
        /// Current API environment.
        /// </summary>
        public Environment Environment { get; }

        /// <summary>
        /// Gets http callback.
        /// </summary>
        public HttpCallback HttpCallback => this.httpCallback;

        /// <summary>
        /// Gets the credentials to use with ApiToken.
        /// </summary>
        public IApiTokenCredentials ApiTokenCredentials { get; private set; }

        /// <summary>
        /// Gets the credentials model to use with ApiToken.
        /// </summary>
        public ApiTokenModel ApiTokenModel { get; private set; }

        /// <summary>
        /// Gets the credentials to use with BasicAuth.
        /// </summary>
        public IBasicAuthCredentials BasicAuthCredentials { get; private set; }

        /// <summary>
        /// Gets the credentials model to use with BasicAuth.
        /// </summary>
        public BasicAuthModel BasicAuthModel { get; private set; }

        /// <summary>
        /// Gets the credentials to use with CsrfToken.
        /// </summary>
        public ICsrfTokenCredentials CsrfTokenCredentials { get; private set; }

        /// <summary>
        /// Gets the credentials model to use with CsrfToken.
        /// </summary>
        public CsrfTokenModel CsrfTokenModel { get; private set; }

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends
        /// it with template parameters.
        /// </summary>
        /// <param name="alias">Default value:DEFAULT.</param>
        /// <returns>Returns the baseurl.</returns>
        public string GetBaseUri(Server alias = Server.Default)
        {
            return globalConfiguration.ServerUrl(alias);
        }

        /// <summary>
        /// Creates an object of the MistAPIClient using the values provided for the builder.
        /// </summary>
        /// <returns>Builder.</returns>
        public Builder ToBuilder()
        {
            Builder builder = new Builder()
                .Environment(this.Environment)
                .HttpCallback(httpCallback)
                .LoggingConfig(sdkLoggingConfiguration)
                .HttpClientConfig(config => config.Build());

            if (ApiTokenModel != null)
            {
                builder.ApiTokenCredentials(ApiTokenModel.ToBuilder().Build());
            }

            if (BasicAuthModel != null)
            {
                builder.BasicAuthCredentials(BasicAuthModel.ToBuilder().Build());
            }

            if (CsrfTokenModel != null)
            {
                builder.CsrfTokenCredentials(CsrfTokenModel.ToBuilder().Build());
            }

            return builder;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return
                $"Environment = {this.Environment}, " +
                $"HttpClientConfiguration = {this.HttpClientConfiguration}, ";
        }

        /// <summary>
        /// Creates the client using builder.
        /// </summary>
        /// <returns> MistAPIClient.</returns>
        internal static MistAPIClient CreateFromEnvironment()
        {
            var builder = new Builder();

            string environment = System.Environment.GetEnvironmentVariable("MIST_API_STANDARD_ENVIRONMENT");
            string authorization = System.Environment.GetEnvironmentVariable("MIST_API_STANDARD_AUTHORIZATION");
            string username = System.Environment.GetEnvironmentVariable("MIST_API_STANDARD_USERNAME");
            string password = System.Environment.GetEnvironmentVariable("MIST_API_STANDARD_PASSWORD");
            string xCSRFToken = System.Environment.GetEnvironmentVariable("MIST_API_STANDARD_X_CSRF_TOKEN");

            if (environment != null)
            {
                builder.Environment(ApiHelper.JsonDeserialize<Environment>($"\"{environment}\""));
            }

            if (authorization != null)
            {
                builder.ApiTokenCredentials(new ApiTokenModel
                .Builder(authorization)
                .Build());
            }

            if (username != null && password != null)
            {
                builder.BasicAuthCredentials(new BasicAuthModel
                .Builder(username, password)
                .Build());
            }

            if (xCSRFToken != null)
            {
                builder.CsrfTokenCredentials(new CsrfTokenModel
                .Builder(xCSRFToken)
                .Build());
            }

            return builder.Build();
        }

        /// <summary>
        /// Builder class.
        /// </summary>
        public class Builder
        {
            private Environment environment = MistAPI.Standard.Environment.Production;
            private ApiTokenModel apiTokenModel = new ApiTokenModel();
            private BasicAuthModel basicAuthModel = new BasicAuthModel();
            private CsrfTokenModel csrfTokenModel = new CsrfTokenModel();
            private HttpClientConfiguration.Builder httpClientConfig = new HttpClientConfiguration.Builder();
            private HttpCallback httpCallback;
            private SdkLoggingConfiguration sdkLoggingConfiguration;

            /// <summary>
            /// Sets credentials for ApiToken.
            /// </summary>
            /// <param name="apiTokenModel">ApiTokenModel.</param>
            /// <returns>Builder.</returns>
            public Builder ApiTokenCredentials(ApiTokenModel apiTokenModel)
            {
                if (apiTokenModel is null)
                {
                    throw new ArgumentNullException(nameof(apiTokenModel));
                }

                this.apiTokenModel = apiTokenModel;
                return this;
            }

            /// <summary>
            /// Sets credentials for BasicAuth.
            /// </summary>
            /// <param name="basicAuthModel">BasicAuthModel.</param>
            /// <returns>Builder.</returns>
            public Builder BasicAuthCredentials(BasicAuthModel basicAuthModel)
            {
                if (basicAuthModel is null)
                {
                    throw new ArgumentNullException(nameof(basicAuthModel));
                }

                this.basicAuthModel = basicAuthModel;
                return this;
            }

            /// <summary>
            /// Sets credentials for CsrfToken.
            /// </summary>
            /// <param name="csrfTokenModel">CsrfTokenModel.</param>
            /// <returns>Builder.</returns>
            public Builder CsrfTokenCredentials(CsrfTokenModel csrfTokenModel)
            {
                if (csrfTokenModel is null)
                {
                    throw new ArgumentNullException(nameof(csrfTokenModel));
                }

                this.csrfTokenModel = csrfTokenModel;
                return this;
            }

            /// <summary>
            /// Sets Environment.
            /// </summary>
            /// <param name="environment"> Environment. </param>
            /// <returns> Builder. </returns>
            public Builder Environment(Environment environment)
            {
                this.environment = environment;
                return this;
            }

            /// <summary>
            /// Sets HttpClientConfig.
            /// </summary>
            /// <param name="action"> Action. </param>
            /// <returns>Builder.</returns>
            public Builder HttpClientConfig(Action<HttpClientConfiguration.Builder> action)
            {
                if (action is null)
                {
                    throw new ArgumentNullException(nameof(action));
                }

                action(this.httpClientConfig);
                return this;
            }

            /// <summary>
            /// Sets the default logging configuration, using the Console logger.
            /// </summary>
            /// <returns>Builder.</returns>
            public Builder LoggingConfig()
            {
                this.sdkLoggingConfiguration = SdkLoggingConfiguration.Console();
                return this;
            }

            /// <summary>
            /// Sets the logging configuration using the provided <paramref name="action"/>.
            /// </summary>
            /// <param name="action">The action to perform on the logging configuration builder.</param>
            /// <returns>Builder.</returns>
            /// <exception cref="ArgumentNullException">Thrown when <paramref name="action"/> is null.</exception>
            public Builder LoggingConfig(Action<LogBuilder> action)
            {
                if (action is null) throw new ArgumentNullException(nameof(action));
                var logBuilder =
                    LogBuilder.CreateFromConfig(sdkLoggingConfiguration ?? SdkLoggingConfiguration.Console());
                action(logBuilder);
                this.sdkLoggingConfiguration = logBuilder.Build();
                return this;
            }

            internal Builder LoggingConfig(SdkLoggingConfiguration configuration)
            {
                sdkLoggingConfiguration = configuration;
                return this;
            }



            /// <summary>
            /// Sets the HttpCallback for the Builder.
            /// </summary>
            /// <param name="httpCallback"> http callback. </param>
            /// <returns>Builder.</returns>
            public Builder HttpCallback(HttpCallback httpCallback)
            {
                this.httpCallback = httpCallback;
                return this;
            }

            /// <summary>
            /// Creates an object of the MistAPIClient using the values provided for the builder.
            /// </summary>
            /// <returns>MistAPIClient.</returns>
            public MistAPIClient Build()
            {
                if (apiTokenModel.Authorization == null)
                {
                    apiTokenModel = null;
                }
                if (basicAuthModel.Username == null || basicAuthModel.Password == null)
                {
                    basicAuthModel = null;
                }
                if (csrfTokenModel.XCSRFToken == null)
                {
                    csrfTokenModel = null;
                }
                return new MistAPIClient(
                    environment,
                    apiTokenModel,
                    basicAuthModel,
                    csrfTokenModel,
                    httpCallback,
                    httpClientConfig.Build(),
                    sdkLoggingConfiguration);
            }
        }
    }
}
