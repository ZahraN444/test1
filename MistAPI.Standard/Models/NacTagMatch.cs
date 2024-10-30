// <copyright file="NacTagMatch.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using APIMatic.Core.Utilities.Converters;
using MistAPI.Standard;
using MistAPI.Standard.Utilities;
using Newtonsoft.Json;

namespace MistAPI.Standard.Models
{
    /// <summary>
    /// NacTagMatch.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum NacTagMatch
    {
        /// <summary>
        /// CertCn.
        /// </summary>
        [EnumMember(Value = "cert_cn")]
        CertCn,

        /// <summary>
        /// CertIssuer.
        /// </summary>
        [EnumMember(Value = "cert_issuer")]
        CertIssuer,

        /// <summary>
        /// CertSan.
        /// </summary>
        [EnumMember(Value = "cert_san")]
        CertSan,

        /// <summary>
        /// CertSerial.
        /// </summary>
        [EnumMember(Value = "cert_serial")]
        CertSerial,

        /// <summary>
        /// CertSub.
        /// </summary>
        [EnumMember(Value = "cert_sub")]
        CertSub,

        /// <summary>
        /// ClientMac.
        /// </summary>
        [EnumMember(Value = "client_mac")]
        ClientMac,

        /// <summary>
        /// IdpRole.
        /// </summary>
        [EnumMember(Value = "idp_role")]
        IdpRole,

        /// <summary>
        /// MdmStatus.
        /// </summary>
        [EnumMember(Value = "mdm_status")]
        MdmStatus,

        /// <summary>
        /// RadiusGroup.
        /// </summary>
        [EnumMember(Value = "radius_group")]
        RadiusGroup,

        /// <summary>
        /// Realm.
        /// </summary>
        [EnumMember(Value = "realm")]
        Realm,

        /// <summary>
        /// Ssid.
        /// </summary>
        [EnumMember(Value = "ssid")]
        Ssid,

        /// <summary>
        /// UserName.
        /// </summary>
        [EnumMember(Value = "user_name")]
        UserName,

        /// <summary>
        /// UsermacLabel.
        /// </summary>
        [EnumMember(Value = "usermac_label")]
        UsermacLabel
    }
}