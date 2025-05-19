// <copyright file="NetworkInternetAccessModel.cs" company="APIMatic">
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
    /// NetworkInternetAccessModel.
    /// </summary>
    public class NetworkInternetAccessModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkInternetAccessModel"/> class.
        /// </summary>
        public NetworkInternetAccessModel()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkInternetAccessModel"/> class.
        /// </summary>
        /// <param name="createSimpleServicePolicy">create_simple_service_policy.</param>
        /// <param name="destinationNat">destination_nat.</param>
        /// <param name="enabled">enabled.</param>
        /// <param name="restricted">restricted.</param>
        /// <param name="staticNat">static_nat.</param>
        public NetworkInternetAccessModel(
            bool? createSimpleServicePolicy = false,
            Dictionary<string, Models.NetworkDestinationNatPropertyModel> destinationNat = null,
            bool? enabled = false,
            bool? restricted = false,
            Dictionary<string, Models.NetworkStaticNatPropertyModel> staticNat = null)
        {
            this.CreateSimpleServicePolicy = createSimpleServicePolicy;
            this.DestinationNat = destinationNat;
            this.Enabled = enabled;
            this.Restricted = restricted;
            this.StaticNat = staticNat;
        }

        /// <summary>
        /// Gets or sets CreateSimpleServicePolicy.
        /// </summary>
        [JsonProperty("create_simple_service_policy", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CreateSimpleServicePolicy { get; set; }

        /// <summary>
        /// Property key may be an IP/Port (i.e. "63.16.0.3:443"), or a port (i.e. ":2222")
        /// </summary>
        [JsonProperty("destination_nat", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Models.NetworkDestinationNatPropertyModel> DestinationNat { get; set; }

        /// <summary>
        /// Gets or sets Enabled.
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// by default, all access is allowed, to only allow certain traffic, make `restricted`=`true` and define service_policies
        /// </summary>
        [JsonProperty("restricted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Restricted { get; set; }

        /// <summary>
        /// Property key may be an IP Address (i.e. "172.16.0.1"), and IP Address and Port (i.e. "172.16.0.1:8443") or a CIDR (i.e. "172.16.0.12/20")
        /// </summary>
        [JsonProperty("static_nat", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Models.NetworkStaticNatPropertyModel> StaticNat { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"NetworkInternetAccessModel : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is NetworkInternetAccessModel other &&
                (this.CreateSimpleServicePolicy == null && other.CreateSimpleServicePolicy == null ||
                 this.CreateSimpleServicePolicy?.Equals(other.CreateSimpleServicePolicy) == true) &&
                (this.DestinationNat == null && other.DestinationNat == null ||
                 this.DestinationNat?.Equals(other.DestinationNat) == true) &&
                (this.Enabled == null && other.Enabled == null ||
                 this.Enabled?.Equals(other.Enabled) == true) &&
                (this.Restricted == null && other.Restricted == null ||
                 this.Restricted?.Equals(other.Restricted) == true) &&
                (this.StaticNat == null && other.StaticNat == null ||
                 this.StaticNat?.Equals(other.StaticNat) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"CreateSimpleServicePolicy = {(this.CreateSimpleServicePolicy == null ? "null" : this.CreateSimpleServicePolicy.ToString())}");
            toStringOutput.Add($"DestinationNat = {(this.DestinationNat == null ? "null" : this.DestinationNat.ToString())}");
            toStringOutput.Add($"Enabled = {(this.Enabled == null ? "null" : this.Enabled.ToString())}");
            toStringOutput.Add($"Restricted = {(this.Restricted == null ? "null" : this.Restricted.ToString())}");
            toStringOutput.Add($"StaticNat = {(this.StaticNat == null ? "null" : this.StaticNat.ToString())}");
        }
    }
}