// <copyright file="NacPortal.cs" company="APIMatic">
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
    /// NacPortal.
    /// </summary>
    public class NacPortal
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NacPortal"/> class.
        /// </summary>
        public NacPortal()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NacPortal"/> class.
        /// </summary>
        /// <param name="accessType">access_type.</param>
        /// <param name="bgImageUrl">bg_image_url.</param>
        /// <param name="certExpireTime">cert_expire_time.</param>
        /// <param name="enableTelemetry">enable_telemetry.</param>
        /// <param name="expiryNotificationTime">expiry_notification_time.</param>
        /// <param name="guestPortalConfig">guest_portal_config.</param>
        /// <param name="name">name.</param>
        /// <param name="notifyExpiry">notify_expiry.</param>
        /// <param name="ssid">ssid.</param>
        /// <param name="sso">sso.</param>
        /// <param name="templateUrl">template_url.</param>
        /// <param name="thumbnailUrl">thumbnail_url.</param>
        /// <param name="tos">tos.</param>
        /// <param name="type">type.</param>
        public NacPortal(
            Models.NacPortalAccessTypeEnum? accessType = null,
            string bgImageUrl = null,
            int? certExpireTime = null,
            bool? enableTelemetry = null,
            int? expiryNotificationTime = null,
            Models.NacPortalSso guestPortalConfig = null,
            string name = null,
            bool? notifyExpiry = null,
            string ssid = null,
            Models.NacPortalSso sso = null,
            string templateUrl = null,
            string thumbnailUrl = null,
            string tos = null,
            Models.NacPortalTypeEnum? type = null)
        {
            this.AccessType = accessType;
            this.BgImageUrl = bgImageUrl;
            this.CertExpireTime = certExpireTime;
            this.EnableTelemetry = enableTelemetry;
            this.ExpiryNotificationTime = expiryNotificationTime;
            this.GuestPortalConfig = guestPortalConfig;
            this.Name = name;
            this.NotifyExpiry = notifyExpiry;
            this.Ssid = ssid;
            this.Sso = sso;
            this.TemplateUrl = templateUrl;
            this.ThumbnailUrl = thumbnailUrl;
            this.Tos = tos;
            this.Type = type;
        }

        /// <summary>
        /// Gets or sets AccessType.
        /// </summary>
        [JsonProperty("access_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.NacPortalAccessTypeEnum? AccessType { get; set; }

        /// <summary>
        /// background image
        /// </summary>
        [JsonProperty("bg_image_url", NullValueHandling = NullValueHandling.Ignore)]
        public string BgImageUrl { get; set; }

        /// <summary>
        /// in days
        /// </summary>
        [JsonProperty("cert_expire_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? CertExpireTime { get; set; }

        /// <summary>
        /// model, version, fingering, events (connecting, disconnect, roaming), which ap
        /// </summary>
        [JsonProperty("enable_telemetry", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableTelemetry { get; set; }

        /// <summary>
        /// in days
        /// </summary>
        [JsonProperty("expiry_notification_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExpiryNotificationTime { get; set; }

        /// <summary>
        /// Gets or sets GuestPortalConfig.
        /// </summary>
        [JsonProperty("guest_portal_config", NullValueHandling = NullValueHandling.Ignore)]
        public Models.NacPortalSso GuestPortalConfig { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// phase 2
        /// </summary>
        [JsonProperty("notify_expiry", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NotifyExpiry { get; set; }

        /// <summary>
        /// Gets or sets Ssid.
        /// </summary>
        [JsonProperty("ssid", NullValueHandling = NullValueHandling.Ignore)]
        public string Ssid { get; set; }

        /// <summary>
        /// Gets or sets Sso.
        /// </summary>
        [JsonProperty("sso", NullValueHandling = NullValueHandling.Ignore)]
        public Models.NacPortalSso Sso { get; set; }

        /// <summary>
        /// Gets or sets TemplateUrl.
        /// </summary>
        [JsonProperty("template_url", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateUrl { get; set; }

        /// <summary>
        /// Gets or sets ThumbnailUrl.
        /// </summary>
        [JsonProperty("thumbnail_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ThumbnailUrl { get; set; }

        /// <summary>
        /// Gets or sets Tos.
        /// </summary>
        [JsonProperty("tos", NullValueHandling = NullValueHandling.Ignore)]
        public string Tos { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.NacPortalTypeEnum? Type { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"NacPortal : ({string.Join(", ", toStringOutput)})";
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
            return obj is NacPortal other &&                ((this.AccessType == null && other.AccessType == null) || (this.AccessType?.Equals(other.AccessType) == true)) &&
                ((this.BgImageUrl == null && other.BgImageUrl == null) || (this.BgImageUrl?.Equals(other.BgImageUrl) == true)) &&
                ((this.CertExpireTime == null && other.CertExpireTime == null) || (this.CertExpireTime?.Equals(other.CertExpireTime) == true)) &&
                ((this.EnableTelemetry == null && other.EnableTelemetry == null) || (this.EnableTelemetry?.Equals(other.EnableTelemetry) == true)) &&
                ((this.ExpiryNotificationTime == null && other.ExpiryNotificationTime == null) || (this.ExpiryNotificationTime?.Equals(other.ExpiryNotificationTime) == true)) &&
                ((this.GuestPortalConfig == null && other.GuestPortalConfig == null) || (this.GuestPortalConfig?.Equals(other.GuestPortalConfig) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.NotifyExpiry == null && other.NotifyExpiry == null) || (this.NotifyExpiry?.Equals(other.NotifyExpiry) == true)) &&
                ((this.Ssid == null && other.Ssid == null) || (this.Ssid?.Equals(other.Ssid) == true)) &&
                ((this.Sso == null && other.Sso == null) || (this.Sso?.Equals(other.Sso) == true)) &&
                ((this.TemplateUrl == null && other.TemplateUrl == null) || (this.TemplateUrl?.Equals(other.TemplateUrl) == true)) &&
                ((this.ThumbnailUrl == null && other.ThumbnailUrl == null) || (this.ThumbnailUrl?.Equals(other.ThumbnailUrl) == true)) &&
                ((this.Tos == null && other.Tos == null) || (this.Tos?.Equals(other.Tos) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccessType = {(this.AccessType == null ? "null" : this.AccessType.ToString())}");
            toStringOutput.Add($"this.BgImageUrl = {(this.BgImageUrl == null ? "null" : this.BgImageUrl)}");
            toStringOutput.Add($"this.CertExpireTime = {(this.CertExpireTime == null ? "null" : this.CertExpireTime.ToString())}");
            toStringOutput.Add($"this.EnableTelemetry = {(this.EnableTelemetry == null ? "null" : this.EnableTelemetry.ToString())}");
            toStringOutput.Add($"this.ExpiryNotificationTime = {(this.ExpiryNotificationTime == null ? "null" : this.ExpiryNotificationTime.ToString())}");
            toStringOutput.Add($"this.GuestPortalConfig = {(this.GuestPortalConfig == null ? "null" : this.GuestPortalConfig.ToString())}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.NotifyExpiry = {(this.NotifyExpiry == null ? "null" : this.NotifyExpiry.ToString())}");
            toStringOutput.Add($"this.Ssid = {(this.Ssid == null ? "null" : this.Ssid)}");
            toStringOutput.Add($"this.Sso = {(this.Sso == null ? "null" : this.Sso.ToString())}");
            toStringOutput.Add($"this.TemplateUrl = {(this.TemplateUrl == null ? "null" : this.TemplateUrl)}");
            toStringOutput.Add($"this.ThumbnailUrl = {(this.ThumbnailUrl == null ? "null" : this.ThumbnailUrl)}");
            toStringOutput.Add($"this.Tos = {(this.Tos == null ? "null" : this.Tos)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type.ToString())}");
        }
    }
}