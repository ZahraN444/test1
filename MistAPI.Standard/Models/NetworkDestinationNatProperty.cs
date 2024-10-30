// <copyright file="NetworkDestinationNatProperty.cs" company="APIMatic">
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
    /// NetworkDestinationNatProperty.
    /// </summary>
    public class NetworkDestinationNatProperty
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkDestinationNatProperty"/> class.
        /// </summary>
        public NetworkDestinationNatProperty()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkDestinationNatProperty"/> class.
        /// </summary>
        /// <param name="internalIp">internal_ip.</param>
        /// <param name="name">name.</param>
        /// <param name="port">port.</param>
        public NetworkDestinationNatProperty(
            string internalIp = null,
            string name = null,
            int? port = null)
        {
            this.InternalIp = internalIp;
            this.Name = name;
            this.Port = port;
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
        /// Gets or sets Port.
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public int? Port { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"NetworkDestinationNatProperty : ({string.Join(", ", toStringOutput)})";
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
            return obj is NetworkDestinationNatProperty other &&                ((this.InternalIp == null && other.InternalIp == null) || (this.InternalIp?.Equals(other.InternalIp) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Port == null && other.Port == null) || (this.Port?.Equals(other.Port) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.InternalIp = {(this.InternalIp == null ? "null" : this.InternalIp)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Port = {(this.Port == null ? "null" : this.Port.ToString())}");
        }
    }
}