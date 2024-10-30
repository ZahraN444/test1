// <copyright file="NacTagUsernameAttrEnum.cs" company="APIMatic">
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
    /// NacTagUsernameAttrEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum NacTagUsernameAttrEnum
    {
        /// <summary>
        /// Automatic.
        /// </summary>
        [EnumMember(Value = "automatic")]
        Automatic,

        /// <summary>
        /// Cn.
        /// </summary>
        [EnumMember(Value = "cn")]
        Cn,

        /// <summary>
        /// Upn.
        /// </summary>
        [EnumMember(Value = "upn")]
        Upn,

        /// <summary>
        /// Email.
        /// </summary>
        [EnumMember(Value = "email")]
        Email,

        /// <summary>
        /// Dns.
        /// </summary>
        [EnumMember(Value = "dns")]
        Dns
    }
}