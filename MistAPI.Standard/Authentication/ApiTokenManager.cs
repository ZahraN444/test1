// <copyright file="ApiTokenManager.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MistAPI.Standard.Http.Request;
using APIMatic.Core.Authentication;

namespace MistAPI.Standard.Authentication
{
    /// <summary>
    /// ApiTokenManager Class.
    /// </summary>
    internal class ApiTokenManager : AuthManager, IApiTokenCredentials
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiTokenManager"/> class.
        /// </summary>
        /// <param name="apiToken">ApiToken.</param>
        public ApiTokenManager(ApiTokenModel apiTokenModel)
        {
            Authorization = apiTokenModel?.Authorization;
            Parameters(paramBuilder => paramBuilder
                .Header(header => header.Setup("Authorization", Authorization).Required())
            );
        }

        /// <summary>
        /// Gets string value for authorization.
        /// </summary>
        public string Authorization { get; }

        /// <summary>
        /// Check if credentials match.
        /// </summary>
        /// <param name="authorization"> The string value for credentials.</param>
        /// <returns> True if credentials matched.</returns>
        public bool Equals(string authorization)
        {
            return authorization.Equals(this.Authorization);
        }
    }

    public sealed class ApiTokenModel
    {
        internal ApiTokenModel()
        {
        }

        internal string Authorization { get; set; }

        /// <summary>
        /// Creates an object of the ApiTokenModel using the values provided for the builder.
        /// </summary>
        /// <returns>Builder.</returns>
        public Builder ToBuilder()
        {
            return new Builder(Authorization);
        }

        /// <summary>
        /// Builder class for ApiTokenModel.
        /// </summary>
        public class Builder
        {
            private string authorization;

            public Builder(string authorization)
            {
                this.authorization = authorization ?? throw new ArgumentNullException(nameof(authorization));
            }

            /// <summary>
            /// Sets Authorization.
            /// </summary>
            /// <param name="authorization">Authorization.</param>
            /// <returns>Builder.</returns>
            public Builder Authorization(string authorization)
            {
                this.authorization = authorization ?? throw new ArgumentNullException(nameof(authorization));
                return this;
            }


            /// <summary>
            /// Creates an object of the ApiTokenModel using the values provided for the builder.
            /// </summary>
            /// <returns>ApiTokenModel.</returns>
            public ApiTokenModel Build()
            {
                return new ApiTokenModel()
                {
                    Authorization = this.authorization
                };
            }
        }
    }
    
}