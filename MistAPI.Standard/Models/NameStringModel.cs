// <copyright file="NameStringModel.cs" company="APIMatic">
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
    /// NameStringModel.
    /// </summary>
    public class NameStringModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NameStringModel"/> class.
        /// </summary>
        public NameStringModel()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NameStringModel"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        public NameStringModel(
            string name = "")
        {
            this.Name = name;
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"NameStringModel : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is NameStringModel other &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
        }
    }
}