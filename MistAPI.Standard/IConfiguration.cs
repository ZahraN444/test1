// <copyright file="IConfiguration.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Net;
using MistAPI.Standard.Authentication;
using MistAPI.Standard.Models;

namespace MistAPI.Standard
{
    /// <summary>
    /// IConfiguration.
    /// </summary>
    public interface IConfiguration
    {
        /// <summary>
        /// Gets Current API environment.
        /// </summary>
        Environment Environment { get; }

        /// <summary>
        /// Gets the credentials to use with ApiToken.
        /// </summary>
        IApiTokenCredentials ApiTokenCredentials { get; }

        /// <summary>
        /// Gets the credentials model to use with ApiToken.
        /// </summary>
        ApiTokenModel ApiTokenModel { get; }

        /// <summary>
        /// Gets the credentials to use with BasicAuth.
        /// </summary>
        IBasicAuthCredentials BasicAuthCredentials { get; }

        /// <summary>
        /// Gets the credentials model to use with BasicAuth.
        /// </summary>
        BasicAuthModel BasicAuthModel { get; }

        /// <summary>
        /// Gets the credentials to use with CsrfToken.
        /// </summary>
        ICsrfTokenCredentials CsrfTokenCredentials { get; }

        /// <summary>
        /// Gets the credentials model to use with CsrfToken.
        /// </summary>
        CsrfTokenModel CsrfTokenModel { get; }

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends it with template parameters.
        /// </summary>
        /// <param name="alias">Default value:DEFAULT.</param>
        /// <returns>Returns the baseurl.</returns>
        string GetBaseUri(Server alias = Server.Default);
    }
}