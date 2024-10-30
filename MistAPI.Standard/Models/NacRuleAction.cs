// <copyright file="NacRuleAction.cs" company="APIMatic">
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
    /// NacRuleAction.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum NacRuleAction
    {
        /// <summary>
        /// Allow.
        /// </summary>
        [EnumMember(Value = "allow")]
        Allow,

        /// <summary>
        /// Block.
        /// </summary>
        [EnumMember(Value = "block")]
        Block
    }
}