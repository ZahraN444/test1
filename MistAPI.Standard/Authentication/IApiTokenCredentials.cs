// <copyright file="IApiTokenCredentials.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;

namespace MistAPI.Standard.Authentication
{
    /// <summary>
    /// Authentication configuration interface for ApiToken.
    /// </summary>
    public interface IApiTokenCredentials
    {
        /// <summary>
        /// Gets string value for authorization.
        /// </summary>
        string Authorization { get; }

        /// <summary>
        ///  Returns true if credentials matched.
        /// </summary>
        /// <param name="authorization"> The string value for credentials.</param>
        /// <returns>True if credentials matched.</returns>
        bool Equals(string authorization);
    }
}