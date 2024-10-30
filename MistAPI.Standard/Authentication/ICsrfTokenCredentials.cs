// <copyright file="ICsrfTokenCredentials.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;

namespace MistAPI.Standard.Authentication
{
    /// <summary>
    /// Authentication configuration interface for CsrfToken.
    /// </summary>
    public interface ICsrfTokenCredentials
    {
        /// <summary>
        /// Gets string value for xCSRFToken.
        /// </summary>
        string XCSRFToken { get; }

        /// <summary>
        ///  Returns true if credentials matched.
        /// </summary>
        /// <param name="xCSRFToken"> The string value for credentials.</param>
        /// <returns>True if credentials matched.</returns>
        bool Equals(string xCSRFToken);
    }
}