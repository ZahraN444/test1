// <copyright file="ResponseSsoFailureSearchItem.cs" company="APIMatic">
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
    /// ResponseSsoFailureSearchItem.
    /// </summary>
    public class ResponseSsoFailureSearchItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSsoFailureSearchItem"/> class.
        /// </summary>
        public ResponseSsoFailureSearchItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSsoFailureSearchItem"/> class.
        /// </summary>
        /// <param name="detail">detail.</param>
        /// <param name="samlAssertionXml">saml_assertion_xml.</param>
        /// <param name="timestamp">timestamp.</param>
        public ResponseSsoFailureSearchItem(
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

            return $"ResponseSsoFailureSearchItem : ({string.Join(", ", toStringOutput)})";
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
            return obj is ResponseSsoFailureSearchItem other &&                ((this.Detail == null && other.Detail == null) || (this.Detail?.Equals(other.Detail) == true)) &&
                ((this.SamlAssertionXml == null && other.SamlAssertionXml == null) || (this.SamlAssertionXml?.Equals(other.SamlAssertionXml) == true)) &&
                this.Timestamp.Equals(other.Timestamp);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Detail = {(this.Detail == null ? "null" : this.Detail)}");
            toStringOutput.Add($"this.SamlAssertionXml = {(this.SamlAssertionXml == null ? "null" : this.SamlAssertionXml)}");
            toStringOutput.Add($"this.Timestamp = {this.Timestamp}");
        }
    }
}