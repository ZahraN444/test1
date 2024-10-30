// <copyright file="NetworkStaticNatProperty.cs" company="APIMatic">
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
    /// NetworkStaticNatProperty.
    /// </summary>
    public class NetworkStaticNatProperty
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkStaticNatProperty"/> class.
        /// </summary>
        public NetworkStaticNatProperty()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkStaticNatProperty"/> class.
        /// </summary>
        /// <param name="internalIp">internal_ip.</param>
        /// <param name="name">name.</param>
        /// <param name="wanName">wan_name.</param>
        public NetworkStaticNatProperty(
            string internalIp = null,
            string name = null,
            string wanName = null)
        {
            this.InternalIp = internalIp;
            this.Name = name;
            this.WanName = wanName;
        }

        /// <summary>
        /// Gets or sets InternalIp.
        /// </summary>
        [JsonProperty("internal_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string InternalIp { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// If not set, we configure the nat policies against all WAN ports for simplicity
        /// </summary>
        [JsonProperty("wan_name", NullValueHandling = NullValueHandling.Ignore)]
        public string WanName { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"NetworkStaticNatProperty : ({string.Join(", ", toStringOutput)})";
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
            return obj is NetworkStaticNatProperty other &&                ((this.InternalIp == null && other.InternalIp == null) || (this.InternalIp?.Equals(other.InternalIp) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.WanName == null && other.WanName == null) || (this.WanName?.Equals(other.WanName) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.InternalIp = {(this.InternalIp == null ? "null" : this.InternalIp)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.WanName = {(this.WanName == null ? "null" : this.WanName)}");
        }
    }
}