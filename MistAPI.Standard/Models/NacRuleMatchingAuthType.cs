// <copyright file="NacRuleMatchingAuthType.cs" company="APIMatic">
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
    /// NacRuleMatchingAuthType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum NacRuleMatchingAuthType
    {
        /// <summary>
        /// Cert.
        /// </summary>
        [EnumMember(Value = "cert")]
        Cert,

        /// <summary>
        /// Deviceauth.
        /// </summary>
        [EnumMember(Value = "device-auth")]
        Deviceauth,

        /// <summary>
        /// Eapteap.
        /// </summary>
        [EnumMember(Value = "eap-teap")]
        Eapteap,

        /// <summary>
        /// Eaptls.
        /// </summary>
        [EnumMember(Value = "eap-tls")]
        Eaptls,

        /// <summary>
        /// Eapttls.
        /// </summary>
        [EnumMember(Value = "eap-ttls")]
        Eapttls,

        /// <summary>
        /// Idp.
        /// </summary>
        [EnumMember(Value = "idp")]
        Idp,

        /// <summary>
        /// Mab.
        /// </summary>
        [EnumMember(Value = "mab")]
        Mab,

        /// <summary>
        /// Peaptls.
        /// </summary>
        [EnumMember(Value = "peap-tls")]
        Peaptls,

        /// <summary>
        /// Psk.
        /// </summary>
        [EnumMember(Value = "psk")]
        Psk
    }
}