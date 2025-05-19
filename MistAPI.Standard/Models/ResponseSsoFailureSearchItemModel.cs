// <copyright file="ResponseSsoFailureSearchItemModel.cs" company="APIMatic">
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
    /// ResponseSsoFailureSearchItemModel.
    /// </summary>
    public class ResponseSsoFailureSearchItemModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSsoFailureSearchItemModel"/> class.
        /// </summary>
        public ResponseSsoFailureSearchItemModel()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSsoFailureSearchItemModel"/> class.
        /// </summary>
        /// <param name="detail">detail.</param>
        /// <param name="samlAssertionXml">saml_assertion_xml.</param>
        /// <param name="timestamp">timestamp.</param>
        public ResponseSsoFailureSearchItemModel(
            string detail,
            string samlAssertionXml,
            double timestamp)
        {
            this.Detail = detail;
            this.SamlAssertionXml = samlAssertionXml;
            this.Timestamp = timestamp;
        }

        /// <summary>
        /// Gets or sets Detail.
        /// </summary>
        [JsonProperty("detail")]
        public string Detail { get; set; }

        /// <summary>
        /// Gets or sets SamlAssertionXml.
        /// </summary>
        [JsonProperty("saml_assertion_xml")]
        public string SamlAssertionXml { get; set; }

        /// <summary>
        /// Gets or sets Timestamp.
        /// </summary>
        [JsonProperty("timestamp")]
        public double Timestamp { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ResponseSsoFailureSearchItemModel : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ResponseSsoFailureSearchItemModel other &&
                (this.Detail == null && other.Detail == null ||
                 this.Detail?.Equals(other.Detail) == true) &&
                (this.SamlAssertionXml == null && other.SamlAssertionXml == null ||
                 this.SamlAssertionXml?.Equals(other.SamlAssertionXml) == true) &&
                (this.Timestamp.Equals(other.Timestamp));
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Detail = {this.Detail ?? "null"}");
            toStringOutput.Add($"SamlAssertionXml = {this.SamlAssertionXml ?? "null"}");
            toStringOutput.Add($"Timestamp = {this.Timestamp}");
        }
    }
}