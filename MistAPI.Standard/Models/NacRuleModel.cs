// <copyright file="NacRuleModel.cs" company="APIMatic">
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
    /// NacRuleModel.
    /// </summary>
    public class NacRuleModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NacRuleModel"/> class.
        /// </summary>
        public NacRuleModel()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NacRuleModel"/> class.
        /// </summary>
        /// <param name="action">action.</param>
        /// <param name="name">name.</param>
        /// <param name="applyTags">apply_tags.</param>
        /// <param name="createdTime">created_time.</param>
        /// <param name="enabled">enabled.</param>
        /// <param name="id">id.</param>
        /// <param name="matching">matching.</param>
        /// <param name="modifiedTime">modified_time.</param>
        /// <param name="notMatching">not_matching.</param>
        /// <param name="order">order.</param>
        /// <param name="orgId">org_id.</param>
        public NacRuleModel(
            Models.NacRuleAction action,
            string name,
            List<string> applyTags = null,
            double? createdTime = null,
            bool? enabled = true,
            Guid? id = null,
            Models.NacRuleMatchingModel matching = null,
            double? modifiedTime = null,
            Models.NacRuleMatchingModel notMatching = null,
            int? order = null,
            Guid? orgId = null)
        {
            this.Action = action;
            this.ApplyTags = applyTags;
            this.CreatedTime = createdTime;
            this.Enabled = enabled;
            this.Id = id;
            this.Matching = matching;
            this.ModifiedTime = modifiedTime;
            this.Name = name;
            this.NotMatching = notMatching;
            this.Order = order;
            this.OrgId = orgId;
        }

        /// <summary>
        /// Gets or sets Action.
        /// </summary>
        [JsonProperty("action")]
        public Models.NacRuleAction Action { get; set; }

        /// <summary>
        /// all optional, this goes into Access-Accept
        /// </summary>
        [JsonProperty("apply_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ApplyTags { get; set; }

        /// <summary>
        /// Gets or sets CreatedTime.
        /// </summary>
        [JsonProperty("created_time", NullValueHandling = NullValueHandling.Ignore)]
        public double? CreatedTime { get; set; }

        /// <summary>
        /// enabled or not
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Gets or sets Matching.
        /// </summary>
        [JsonProperty("matching", NullValueHandling = NullValueHandling.Ignore)]
        public Models.NacRuleMatchingModel Matching { get; set; }

        /// <summary>
        /// Gets or sets ModifiedTime.
        /// </summary>
        [JsonProperty("modified_time", NullValueHandling = NullValueHandling.Ignore)]
        public double? ModifiedTime { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets NotMatching.
        /// </summary>
        [JsonProperty("not_matching", NullValueHandling = NullValueHandling.Ignore)]
        public Models.NacRuleMatchingModel NotMatching { get; set; }

        /// <summary>
        /// the order of the rule, lower value implies higher priority
        /// </summary>
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public int? Order { get; set; }

        /// <summary>
        /// Gets or sets OrgId.
        /// </summary>
        [JsonProperty("org_id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? OrgId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"NacRuleModel : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is NacRuleModel other &&
                (this.Action.Equals(other.Action)) &&
                (this.ApplyTags == null && other.ApplyTags == null ||
                 this.ApplyTags?.Equals(other.ApplyTags) == true) &&
                (this.CreatedTime == null && other.CreatedTime == null ||
                 this.CreatedTime?.Equals(other.CreatedTime) == true) &&
                (this.Enabled == null && other.Enabled == null ||
                 this.Enabled?.Equals(other.Enabled) == true) &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.Matching == null && other.Matching == null ||
                 this.Matching?.Equals(other.Matching) == true) &&
                (this.ModifiedTime == null && other.ModifiedTime == null ||
                 this.ModifiedTime?.Equals(other.ModifiedTime) == true) &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.NotMatching == null && other.NotMatching == null ||
                 this.NotMatching?.Equals(other.NotMatching) == true) &&
                (this.Order == null && other.Order == null ||
                 this.Order?.Equals(other.Order) == true) &&
                (this.OrgId == null && other.OrgId == null ||
                 this.OrgId?.Equals(other.OrgId) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Action = {this.Action}");
            toStringOutput.Add($"ApplyTags = {(this.ApplyTags == null ? "null" : $"[{string.Join(", ", this.ApplyTags)} ]")}");
            toStringOutput.Add($"CreatedTime = {(this.CreatedTime == null ? "null" : this.CreatedTime.ToString())}");
            toStringOutput.Add($"Enabled = {(this.Enabled == null ? "null" : this.Enabled.ToString())}");
            toStringOutput.Add($"Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"Matching = {(this.Matching == null ? "null" : this.Matching.ToString())}");
            toStringOutput.Add($"ModifiedTime = {(this.ModifiedTime == null ? "null" : this.ModifiedTime.ToString())}");
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"NotMatching = {(this.NotMatching == null ? "null" : this.NotMatching.ToString())}");
            toStringOutput.Add($"Order = {(this.Order == null ? "null" : this.Order.ToString())}");
            toStringOutput.Add($"OrgId = {(this.OrgId == null ? "null" : this.OrgId.ToString())}");
        }
    }
}