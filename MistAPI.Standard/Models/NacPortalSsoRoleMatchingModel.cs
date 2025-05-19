// <copyright file="NacPortalSsoRoleMatchingModel.cs" company="APIMatic">
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
    /// NacPortalSsoRoleMatchingModel.
    /// </summary>
    public class NacPortalSsoRoleMatchingModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NacPortalSsoRoleMatchingModel"/> class.
        /// </summary>
        public NacPortalSsoRoleMatchingModel()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NacPortalSsoRoleMatchingModel"/> class.
        /// </summary>
        /// <param name="assigned">assigned.</param>
        /// <param name="match">match.</param>
        public NacPortalSsoRoleMatchingModel(
            string assigned = "",
            string match = "")
        {
            this.Assigned = assigned;
            this.Match = match;
        }

        /// <summary>
        /// Gets or sets Assigned.
        /// </summary>
        [JsonProperty("assigned", NullValueHandling = NullValueHandling.Ignore)]
        public string Assigned { get; set; }

        /// <summary>
        /// Gets or sets Match.
        /// </summary>
        [JsonProperty("match", NullValueHandling = NullValueHandling.Ignore)]
        public string Match { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"NacPortalSsoRoleMatchingModel : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is NacPortalSsoRoleMatchingModel other &&
                (this.Assigned == null && other.Assigned == null ||
                 this.Assigned?.Equals(other.Assigned) == true) &&
                (this.Match == null && other.Match == null ||
                 this.Match?.Equals(other.Match) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Assigned = {this.Assigned ?? "null"}");
            toStringOutput.Add($"Match = {this.Match ?? "null"}");
        }
    }
}