// <copyright file="NacCrlFileModel.cs" company="APIMatic">
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
    /// NacCrlFileModel.
    /// </summary>
    public class NacCrlFileModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NacCrlFileModel"/> class.
        /// </summary>
        public NacCrlFileModel()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NacCrlFileModel"/> class.
        /// </summary>
        /// <param name="createdTime">created_time.</param>
        /// <param name="id">id.</param>
        /// <param name="modifiedTime">modified_time.</param>
        /// <param name="name">name.</param>
        /// <param name="url">url.</param>
        public NacCrlFileModel(
            double? createdTime = null,
            string id = "",
            double? modifiedTime = null,
            string name = "",
            string url = "")
        {
            this.CreatedTime = createdTime;
            this.Id = id;
            this.ModifiedTime = modifiedTime;
            this.Name = name;
            this.Url = url;
        }

        /// <summary>
        /// Time at which the file was first uploaded, in epoch
        /// </summary>
        [JsonProperty("created_time", NullValueHandling = NullValueHandling.Ignore)]
        public double? CreatedTime { get; set; }

        /// <summary>
        /// ID for file upload, used to identify file even for deletion
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Time at which the file was last updated, in epoch
        /// </summary>
        [JsonProperty("modified_time", NullValueHandling = NullValueHandling.Ignore)]
        public double? ModifiedTime { get; set; }

        /// <summary>
        /// Name for the .crl file issuer if set
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Download URL for the .crl file
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"NacCrlFileModel : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is NacCrlFileModel other &&
                (this.CreatedTime == null && other.CreatedTime == null ||
                 this.CreatedTime?.Equals(other.CreatedTime) == true) &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.ModifiedTime == null && other.ModifiedTime == null ||
                 this.ModifiedTime?.Equals(other.ModifiedTime) == true) &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.Url == null && other.Url == null ||
                 this.Url?.Equals(other.Url) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"CreatedTime = {(this.CreatedTime == null ? "null" : this.CreatedTime.ToString())}");
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
            toStringOutput.Add($"ModifiedTime = {(this.ModifiedTime == null ? "null" : this.ModifiedTime.ToString())}");
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"Url = {this.Url ?? "null"}");
        }
    }
}