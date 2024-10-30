// <copyright file="NacRuleMatchingPortType.cs" company="APIMatic">
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
    /// NacRuleMatchingPortType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum NacRuleMatchingPortType
    {
        /// <summary>
        /// Wired.
        /// </summary>
        [EnumMember(Value = "wired")]
        Wired,

        /// <summary>
        /// Wireless.
        /// </summary>
        [EnumMember(Value = "wireless")]
        Wireless
    }
}