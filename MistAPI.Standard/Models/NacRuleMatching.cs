// <copyright file="NacRuleMatching.cs" company="APIMatic">
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
    /// NacRuleMatching.
    /// </summary>
    public class NacRuleMatching
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NacRuleMatching"/> class.
        /// </summary>
        public NacRuleMatching()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NacRuleMatching"/> class.
        /// </summary>
        /// <param name="authType">auth_type.</param>
        /// <param name="nactags">nactags.</param>
        /// <param name="portTypes">port_types.</param>
        /// <param name="siteIds">site_ids.</param>
        /// <param name="sitegroupIds">sitegroup_ids.</param>
        /// <param name="vendor">vendor.</param>
        public NacRuleMatching(
            Models.NacRuleMatchingAuthType? authType = null,
            List<string> nactags = null,
            List<Models.NacRuleMatchingPortType> portTypes = null,
            List<Guid> siteIds = null,
            List<Guid> sitegroupIds = null,
            List<string> vendor = null)
        {
            this.AuthType = authType;
            this.Nactags = nactags;
            this.PortTypes = portTypes;
            this.SiteIds = siteIds;
            this.SitegroupIds = sitegroupIds;
            this.Vendor = vendor;
        }

        /// <summary>
        /// Gets or sets AuthType.
        /// </summary>
        [JsonProperty("auth_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.NacRuleMatchingAuthType? AuthType { get; set; }

        /// <summary>
        /// Gets or sets Nactags.
        /// </summary>
        [JsonProperty("nactags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Nactags { get; set; }

        /// <summary>
        /// Gets or sets PortTypes.
        /// </summary>
        [JsonProperty("port_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.NacRuleMatchingPortType> PortTypes { get; set; }

        /// <summary>
        /// list of site ids to match
        /// </summary>
        [JsonProperty("site_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<Guid> SiteIds { get; set; }

        /// <summary>
        /// list of sitegroup ids to match
        /// </summary>
        [JsonProperty("sitegroup_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<Guid> SitegroupIds { get; set; }

        /// <summary>
        /// list of vendors to match
        /// </summary>
        [JsonProperty("vendor", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Vendor { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"NacRuleMatching : ({string.Join(", ", toStringOutput)})";
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
            return obj is NacRuleMatching other &&                ((this.AuthType == null && other.AuthType == null) || (this.AuthType?.Equals(other.AuthType) == true)) &&
                ((this.Nactags == null && other.Nactags == null) || (this.Nactags?.Equals(other.Nactags) == true)) &&
                ((this.PortTypes == null && other.PortTypes == null) || (this.PortTypes?.Equals(other.PortTypes) == true)) &&
                ((this.SiteIds == null && other.SiteIds == null) || (this.SiteIds?.Equals(other.SiteIds) == true)) &&
                ((this.SitegroupIds == null && other.SitegroupIds == null) || (this.SitegroupIds?.Equals(other.SitegroupIds) == true)) &&
                ((this.Vendor == null && other.Vendor == null) || (this.Vendor?.Equals(other.Vendor) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AuthType = {(this.AuthType == null ? "null" : this.AuthType.ToString())}");
            toStringOutput.Add($"this.Nactags = {(this.Nactags == null ? "null" : $"[{string.Join(", ", this.Nactags)} ]")}");
            toStringOutput.Add($"this.PortTypes = {(this.PortTypes == null ? "null" : $"[{string.Join(", ", this.PortTypes)} ]")}");
            toStringOutput.Add($"this.SiteIds = {(this.SiteIds == null ? "null" : $"[{string.Join(", ", this.SiteIds)} ]")}");
            toStringOutput.Add($"this.SitegroupIds = {(this.SitegroupIds == null ? "null" : $"[{string.Join(", ", this.SitegroupIds)} ]")}");
            toStringOutput.Add($"this.Vendor = {(this.Vendor == null ? "null" : $"[{string.Join(", ", this.Vendor)} ]")}");
        }
    }
}