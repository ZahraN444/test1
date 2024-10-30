// <copyright file="NacTagType.cs" company="APIMatic">
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
    /// NacTagType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum NacTagType
    {
        /// <summary>
        /// EgressVlanNames.
        /// </summary>
        [EnumMember(Value = "egress_vlan_names")]
        EgressVlanNames,

        /// <summary>
        /// GbpTag.
        /// </summary>
        [EnumMember(Value = "gbp_tag")]
        GbpTag,

        /// <summary>
        /// Match.
        /// </summary>
        [EnumMember(Value = "match")]
        Match,

        /// <summary>
        /// RadiusAttrs.
        /// </summary>
        [EnumMember(Value = "radius_attrs")]
        RadiusAttrs,

        /// <summary>
        /// RadiusGroup.
        /// </summary>
        [EnumMember(Value = "radius_group")]
        RadiusGroup,

        /// <summary>
        /// RadiusVendorAttrs.
        /// </summary>
        [EnumMember(Value = "radius_vendor_attrs")]
        RadiusVendorAttrs,

        /// <summary>
        /// SessionTimeout.
        /// </summary>
        [EnumMember(Value = "session_timeout")]
        SessionTimeout,

        /// <summary>
        /// UsernameAttr.
        /// </summary>
        [EnumMember(Value = "username_attr")]
        UsernameAttr,

        /// <summary>
        /// Vlan.
        /// </summary>
        [EnumMember(Value = "vlan")]
        Vlan
    }
}