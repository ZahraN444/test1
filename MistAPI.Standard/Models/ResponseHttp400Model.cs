// <copyright file="ResponseHttp400Model.cs" company="APIMatic">
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
    /// ResponseHttp400Model.
    /// </summary>
    public class ResponseHttp400Model
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseHttp400Model"/> class.
        /// </summary>
        public ResponseHttp400Model()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseHttp400Model"/> class.
        /// </summary>
        /// <param name="detail">detail.</param>
        public ResponseHttp400Model(
            string detail = "")
        {
            this.Detail = detail;
        }

        /// <summary>
        /// Gets or sets Detail.
        /// </summary>
        [JsonProperty("detail", NullValueHandling = NullValueHandling.Ignore)]
        public string Detail { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ResponseHttp400Model : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ResponseHttp400Model other &&
                (this.Detail == null && other.Detail == null ||
                 this.Detail?.Equals(other.Detail) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Detail = {this.Detail ?? "null"}");
        }
    }
}