// <copyright file="NacPortalTemplate.cs" company="APIMatic">
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
    /// NacPortalTemplate.
    /// </summary>
    public class NacPortalTemplate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NacPortalTemplate"/> class.
        /// </summary>
        public NacPortalTemplate()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NacPortalTemplate"/> class.
        /// </summary>
        /// <param name="alignment">alignment.</param>
        /// <param name="color">color.</param>
        /// <param name="logo">logo.</param>
        /// <param name="poweredBy">poweredBy.</param>
        public NacPortalTemplate(
            Models.Alignment? alignment = null,
            string color = "#1074bc",
            string logo = null,
            bool? poweredBy = false)
        {
            this.Alignment = alignment;
            this.Color = color;
            this.Logo = logo;
            this.PoweredBy = poweredBy;
        }

        /// <summary>
        /// Gets or sets Alignment.
        /// </summary>
        [JsonProperty("alignment", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Alignment? Alignment { get; set; }

        /// <summary>
        /// Gets or sets Color.
        /// </summary>
        [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
        public string Color { get; set; }

        /// <summary>
        /// custom logo custom logo with â€œdata:image/png;base64,â€ format. default null, uses Juniper Mist Logo.
        /// </summary>
        [JsonProperty("logo", NullValueHandling = NullValueHandling.Ignore)]
        public string Logo { get; set; }

        /// <summary>
        /// whether to hide â€œPowered by Juniper Mistâ€ and email footers
        /// </summary>
        [JsonProperty("poweredBy", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PoweredBy { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"NacPortalTemplate : ({string.Join(", ", toStringOutput)})";
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
            return obj is NacPortalTemplate other &&                ((this.Alignment == null && other.Alignment == null) || (this.Alignment?.Equals(other.Alignment) == true)) &&
                ((this.Color == null && other.Color == null) || (this.Color?.Equals(other.Color) == true)) &&
                ((this.Logo == null && other.Logo == null) || (this.Logo?.Equals(other.Logo) == true)) &&
                ((this.PoweredBy == null && other.PoweredBy == null) || (this.PoweredBy?.Equals(other.PoweredBy) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Alignment = {(this.Alignment == null ? "null" : this.Alignment.ToString())}");
            toStringOutput.Add($"this.Color = {(this.Color == null ? "null" : this.Color)}");
            toStringOutput.Add($"this.Logo = {(this.Logo == null ? "null" : this.Logo)}");
            toStringOutput.Add($"this.PoweredBy = {(this.PoweredBy == null ? "null" : this.PoweredBy.ToString())}");
        }
    }
}