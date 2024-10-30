// <copyright file="OrgsNACTagsController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using APIMatic.Core;
using APIMatic.Core.Types;
using APIMatic.Core.Utilities;
using APIMatic.Core.Utilities.Date.Xml;
using MistAPI.Standard;
using MistAPI.Standard.Exceptions;
using MistAPI.Standard.Http.Client;
using MistAPI.Standard.Http.Response;
using MistAPI.Standard.Utilities;
using Newtonsoft.Json.Converters;
using System.Net.Http;

namespace MistAPI.Standard.Controllers
{
    /// <summary>
    /// OrgsNACTagsController.
    /// </summary>
    public class OrgsNACTagsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsNACTagsController"/> class.
        /// </summary>
        internal OrgsNACTagsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Get List of Org NAC Tags.
        /// </summary>
        /// <param name="orgId">Required parameter: Example: .</param>
        /// <param name="type">Optional parameter: Type of NAC Tag.</param>
        /// <param name="name">Optional parameter: Name of NAC Tag.</param>
        /// <param name="match">Optional parameter: Type of NAC Tag.</param>
        /// <param name="page">Optional parameter: Example: 1.</param>
        /// <param name="limit">Optional parameter: Example: 100.</param>
        /// <returns>Returns the ApiResponse of List&lt;Models.NacTag&gt; response from the API call.</returns>
        public ApiResponse<List<Models.NacTag>> ListOrgNacTags(
                Guid orgId,
                string type = null,
                string name = null,
                string match = null,
                int? page = 1,
                int? limit = 100)
            => CoreHelper.RunTask(ListOrgNacTagsAsync(orgId, type, name, match, page, limit));

        /// <summary>
        /// Get List of Org NAC Tags.
        /// </summary>
        /// <param name="orgId">Required parameter: Example: .</param>
        /// <param name="type">Optional parameter: Type of NAC Tag.</param>
        /// <param name="name">Optional parameter: Name of NAC Tag.</param>
        /// <param name="match">Optional parameter: Type of NAC Tag.</param>
        /// <param name="page">Optional parameter: Example: 1.</param>
        /// <param name="limit">Optional parameter: Example: 100.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List&lt;Models.NacTag&gt; response from the API call.</returns>
        public async Task<ApiResponse<List<Models.NacTag>>> ListOrgNacTagsAsync(
                Guid orgId,
                string type = null,
                string name = null,
                string match = null,
                int? page = 1,
                int? limit = 100,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.NacTag>>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/api/v1/orgs/{org_id}/nactags")
                  .WithOrAuth(_orAuth => _orAuth
                      .Add("apiToken")
                      .Add("basicAuth")
                      .AddAndGroup(_andAuth1 => _andAuth1
                          .Add("basicAuth")
                          .Add("csrfToken")
                      )
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("org_id", orgId))
                      .Query(_query => _query.Setup("type", type))
                      .Query(_query => _query.Setup("name", name))
                      .Query(_query => _query.Setup("match", match))
                      .Query(_query => _query.Setup("page", page ?? 1))
                      .Query(_query => _query.Setup("limit", limit ?? 100))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Syntax", (_reason, _context) => new ApiV1OrgsNactags400ErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new ApiV1OrgsNactags401ErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Permission Denied", (_reason, _context) => new ApiV1OrgsNactags403ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not found. The API endpoint doesnâ€™t exist or resource doesnâ€™ t exist", (_reason, _context) => new ResponseHttp404Exception(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too Many Request. The API Token used for the request reached the 5000 API Calls per hour threshold", (_reason, _context) => new ApiV1OrgsNactags429ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create Org NAC Tag.
        /// </summary>
        /// <param name="orgId">Required parameter: Example: .</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.NacTag response from the API call.</returns>
        public ApiResponse<Models.NacTag> CreateOrgNacTag(
                Guid orgId,
                Models.NacTag body = null)
            => CoreHelper.RunTask(CreateOrgNacTagAsync(orgId, body));

        /// <summary>
        /// Create Org NAC Tag.
        /// </summary>
        /// <param name="orgId">Required parameter: Example: .</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.NacTag response from the API call.</returns>
        public async Task<ApiResponse<Models.NacTag>> CreateOrgNacTagAsync(
                Guid orgId,
                Models.NacTag body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.NacTag>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/api/v1/orgs/{org_id}/nactags")
                  .WithOrAuth(_orAuth => _orAuth
                      .Add("apiToken")
                      .Add("basicAuth")
                      .AddAndGroup(_andAuth1 => _andAuth1
                          .Add("basicAuth")
                          .Add("csrfToken")
                      )
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("org_id", orgId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Syntax", (_reason, _context) => new ApiV1OrgsNactags400ErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new ApiV1OrgsNactags401ErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Permission Denied", (_reason, _context) => new ApiV1OrgsNactags403ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not found. The API endpoint doesnâ€™t exist or resource doesnâ€™ t exist", (_reason, _context) => new ResponseHttp404Exception(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too Many Request. The API Token used for the request reached the 5000 API Calls per hour threshold", (_reason, _context) => new ApiV1OrgsNactags429ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Delete Org NAC Tag.
        /// </summary>
        /// <param name="orgId">Required parameter: Example: .</param>
        /// <param name="nactagId">Required parameter: Example: .</param>
        public void DeleteOrgNacTag(
                Guid orgId,
                Guid nactagId)
            => CoreHelper.RunVoidTask(DeleteOrgNacTagAsync(orgId, nactagId));

        /// <summary>
        /// Delete Org NAC Tag.
        /// </summary>
        /// <param name="orgId">Required parameter: Example: .</param>
        /// <param name="nactagId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeleteOrgNacTagAsync(
                Guid orgId,
                Guid nactagId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/api/v1/orgs/{org_id}/nactags/{nactag_id}")
                  .WithOrAuth(_orAuth => _orAuth
                      .Add("apiToken")
                      .Add("basicAuth")
                      .AddAndGroup(_andAuth1 => _andAuth1
                          .Add("basicAuth")
                          .Add("csrfToken")
                      )
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("org_id", orgId))
                      .Template(_template => _template.Setup("nactag_id", nactagId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Syntax", (_reason, _context) => new ApiV1OrgsNactags400ErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new ApiV1OrgsNactags401ErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Permission Denied", (_reason, _context) => new ApiV1OrgsNactags403ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not found. The API endpoint doesnâ€™t exist or resource doesnâ€™ t exist", (_reason, _context) => new ResponseHttp404Exception(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too Many Request. The API Token used for the request reached the 5000 API Calls per hour threshold", (_reason, _context) => new ApiV1OrgsNactags429ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Get Org NAC Tag.
        /// </summary>
        /// <param name="orgId">Required parameter: Example: .</param>
        /// <param name="nactagId">Required parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.NacTag response from the API call.</returns>
        public ApiResponse<Models.NacTag> GetOrgNacTag(
                Guid orgId,
                Guid nactagId)
            => CoreHelper.RunTask(GetOrgNacTagAsync(orgId, nactagId));

        /// <summary>
        /// Get Org NAC Tag.
        /// </summary>
        /// <param name="orgId">Required parameter: Example: .</param>
        /// <param name="nactagId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.NacTag response from the API call.</returns>
        public async Task<ApiResponse<Models.NacTag>> GetOrgNacTagAsync(
                Guid orgId,
                Guid nactagId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.NacTag>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/api/v1/orgs/{org_id}/nactags/{nactag_id}")
                  .WithOrAuth(_orAuth => _orAuth
                      .Add("apiToken")
                      .Add("basicAuth")
                      .AddAndGroup(_andAuth1 => _andAuth1
                          .Add("basicAuth")
                          .Add("csrfToken")
                      )
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("org_id", orgId))
                      .Template(_template => _template.Setup("nactag_id", nactagId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Syntax", (_reason, _context) => new ApiV1OrgsNactags400ErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new ApiV1OrgsNactags401ErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Permission Denied", (_reason, _context) => new ApiV1OrgsNactags403ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not found. The API endpoint doesnâ€™t exist or resource doesnâ€™ t exist", (_reason, _context) => new ResponseHttp404Exception(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too Many Request. The API Token used for the request reached the 5000 API Calls per hour threshold", (_reason, _context) => new ApiV1OrgsNactags429ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Update Org NAC Tag.
        /// </summary>
        /// <param name="orgId">Required parameter: Example: .</param>
        /// <param name="nactagId">Required parameter: Example: .</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.NacTag response from the API call.</returns>
        public ApiResponse<Models.NacTag> UpdateOrgNacTag(
                Guid orgId,
                Guid nactagId,
                Models.NacTag body = null)
            => CoreHelper.RunTask(UpdateOrgNacTagAsync(orgId, nactagId, body));

        /// <summary>
        /// Update Org NAC Tag.
        /// </summary>
        /// <param name="orgId">Required parameter: Example: .</param>
        /// <param name="nactagId">Required parameter: Example: .</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.NacTag response from the API call.</returns>
        public async Task<ApiResponse<Models.NacTag>> UpdateOrgNacTagAsync(
                Guid orgId,
                Guid nactagId,
                Models.NacTag body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.NacTag>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/api/v1/orgs/{org_id}/nactags/{nactag_id}")
                  .WithOrAuth(_orAuth => _orAuth
                      .Add("apiToken")
                      .Add("basicAuth")
                      .AddAndGroup(_andAuth1 => _andAuth1
                          .Add("basicAuth")
                          .Add("csrfToken")
                      )
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("org_id", orgId))
                      .Template(_template => _template.Setup("nactag_id", nactagId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Syntax", (_reason, _context) => new ApiV1OrgsNactags400ErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new ApiV1OrgsNactags401ErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Permission Denied", (_reason, _context) => new ApiV1OrgsNactags403ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not found. The API endpoint doesnâ€™t exist or resource doesnâ€™ t exist", (_reason, _context) => new ResponseHttp404Exception(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too Many Request. The API Token used for the request reached the 5000 API Calls per hour threshold", (_reason, _context) => new ApiV1OrgsNactags429ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}