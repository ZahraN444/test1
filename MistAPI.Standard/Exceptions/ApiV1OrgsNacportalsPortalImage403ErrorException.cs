// <copyright file="ApiV1OrgsNacportalsPortalImage403ErrorException.cs" company="APIMatic">
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
using MistAPI.Standard.Http.Client;
using MistAPI.Standard.Models;
using MistAPI.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MistAPI.Standard.Exceptions
{
    /// <summary>
    /// ApiV1OrgsNacportalsPortalImage403ErrorException.
    /// </summary>
    public class ApiV1OrgsNacportalsPortalImage403ErrorException : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiV1OrgsNacportalsPortalImage403ErrorException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public ApiV1OrgsNacportalsPortalImage403ErrorException(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// Gets or sets Detail.
        /// </summary>
        [JsonProperty("detail", NullValueHandling = NullValueHandling.Ignore)]
        public string Detail { get; set; }
    }
}