// <copyright file="NacPortalSsoRoleMatching.cs" company="APIMatic">
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
    /// NacPortalSsoRoleMatching.
    /// </summary>
    public class NacPortalSsoRoleMatching
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NacPortalSsoRoleMatching"/> class.
        /// </summary>
        public NacPortalSsoRoleMatching()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NacPortalSsoRoleMatching"/> class.
        /// </summary>
        /// <param name="assigned">assigned.</param>
        /// <param name="match">match.</param>
        public NacPortalSsoRoleMatching(
            string assigned = null,
            string match = null)
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

            return $"NacPortalSsoRoleMatching : ({string.Join(", ", toStringOutput)})";
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
            return obj is NacPortalSsoRoleMatching other &&                ((this.Assigned == null && other.Assigned == null) || (this.Assigned?.Equals(other.Assigned) == true)) &&
                ((this.Match == null && other.Match == null) || (this.Match?.Equals(other.Match) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Assigned = {(this.Assigned == null ? "null" : this.Assigned)}");
            toStringOutput.Add($"this.Match = {(this.Match == null ? "null" : this.Match)}");
        }
    }
}