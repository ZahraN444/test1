// <copyright file="Alignment.cs" company="APIMatic">
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
    /// Alignment.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Alignment
    {
        /// <summary>
        /// MarvisClient.
        /// </summary>
        [EnumMember(Value = "marvis_client")]
        MarvisClient,

        /// <summary>
        /// Guest.
        /// </summary>
        [EnumMember(Value = "guest")]
        Guest
    }
}