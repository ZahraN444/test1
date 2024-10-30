// <copyright file="CsrfTokenManager.cs" company="APIMatic">
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
    /// CsrfTokenManager Class.
    /// </summary>
    internal class CsrfTokenManager : AuthManager, ICsrfTokenCredentials
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CsrfTokenManager"/> class.
        /// </summary>
        /// <param name="csrfToken">CsrfToken.</param>
        public CsrfTokenManager(CsrfTokenModel csrfTokenModel)
        {
            XCSRFToken = csrfTokenModel?.XCSRFToken;
            Parameters(paramBuilder => paramBuilder
                .Header(header => header.Setup("X-CSRFToken", XCSRFToken).Required())
            );
        }

        /// <summary>
        /// Gets string value for xCSRFToken.
        /// </summary>
        public string XCSRFToken { get; }

        /// <summary>
        /// Check if credentials match.
        /// </summary>
        /// <param name="xCSRFToken"> The string value for credentials.</param>
        /// <returns> True if credentials matched.</returns>
        public bool Equals(string xCSRFToken)
        {
            return xCSRFToken.Equals(this.XCSRFToken);
        }
    }

    public sealed class CsrfTokenModel
    {
        internal CsrfTokenModel()
        {
        }

        internal string XCSRFToken { get; set; }

        /// <summary>
        /// Creates an object of the CsrfTokenModel using the values provided for the builder.
        /// </summary>
        /// <returns>Builder.</returns>
        public Builder ToBuilder()
        {
            return new Builder(XCSRFToken);
        }

        /// <summary>
        /// Builder class for CsrfTokenModel.
        /// </summary>
        public class Builder
        {
            private string xCSRFToken;

            public Builder(string xCSRFToken)
            {
                this.xCSRFToken = xCSRFToken ?? throw new ArgumentNullException(nameof(xCSRFToken));
            }

            /// <summary>
            /// Sets XCSRFToken.
            /// </summary>
            /// <param name="xCSRFToken">XCSRFToken.</param>
            /// <returns>Builder.</returns>
            public Builder XCSRFToken(string xCSRFToken)
            {
                this.xCSRFToken = xCSRFToken ?? throw new ArgumentNullException(nameof(xCSRFToken));
                return this;
            }


            /// <summary>
            /// Creates an object of the CsrfTokenModel using the values provided for the builder.
            /// </summary>
            /// <returns>CsrfTokenModel.</returns>
            public CsrfTokenModel Build()
            {
                return new CsrfTokenModel()
                {
                    XCSRFToken = this.xCSRFToken
                };
            }
        }
    }
    
}