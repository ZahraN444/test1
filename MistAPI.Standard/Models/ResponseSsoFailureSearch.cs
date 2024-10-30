// <copyright file="ResponseSsoFailureSearch.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIMatic.Core.Utilities.Converters;
using MistAPI.Standard;
using MistAPI.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MistAPI.Standard.Models
{
    /// <summary>
    /// ResponseSsoFailureSearch.
    /// </summary>
    public class ResponseSsoFailureSearch
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSsoFailureSearch"/> class.
        /// </summary>
        public ResponseSsoFailureSearch()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSsoFailureSearch"/> class.
        /// </summary>
        /// <param name="results">results.</param>
        public ResponseSsoFailureSearch(
            List<Models.ResponseSsoFailureSearchItem> results)
        {
            this.Results = results;
        }

        /// <summary>
        /// Gets or sets Results.
        /// </summary>
        [JsonProperty("results")]
        public List<Models.ResponseSsoFailureSearchItem> Results { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ResponseSsoFailureSearch : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is ResponseSsoFailureSearch other &&                ((this.Results == null && other.Results == null) || (this.Results?.Equals(other.Results) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Results = {(this.Results == null ? "null" : $"[{string.Join(", ", this.Results)} ]")}");
        }
    }
}