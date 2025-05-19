// <copyright file="ResponseSsoFailureSearchModel.cs" company="APIMatic">
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
    /// ResponseSsoFailureSearchModel.
    /// </summary>
    public class ResponseSsoFailureSearchModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSsoFailureSearchModel"/> class.
        /// </summary>
        public ResponseSsoFailureSearchModel()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSsoFailureSearchModel"/> class.
        /// </summary>
        /// <param name="results">results.</param>
        public ResponseSsoFailureSearchModel(
            List<Models.ResponseSsoFailureSearchItemModel> results)
        {
            this.Results = results;
        }

        /// <summary>
        /// Gets or sets Results.
        /// </summary>
        [JsonProperty("results")]
        public List<Models.ResponseSsoFailureSearchItemModel> Results { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ResponseSsoFailureSearchModel : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ResponseSsoFailureSearchModel other &&
                (this.Results == null && other.Results == null ||
                 this.Results?.Equals(other.Results) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Results = {(this.Results == null ? "null" : $"[{string.Join(", ", this.Results)} ]")}");
        }
    }
}