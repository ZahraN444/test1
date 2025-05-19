// <copyright file="OrgsNACPortalsController.cs" company="APIMatic">
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
    /// OrgsNACPortalsController.
    /// </summary>
    public class OrgsNACPortalsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsNACPortalsController"/> class.
        /// </summary>
        internal OrgsNACPortalsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// List Org NAC Portals.
        /// </summary>
        /// <param name="orgId">Required parameter: Example: .</param>
        /// <param name="page">Optional parameter: Example: 1.</param>
        /// <param name="limit">Optional parameter: Example: 100.</param>
        /// <returns>Returns the ApiResponse of List&lt;Models.NacPortalModel&gt; response from the API call.</returns>
        public ApiResponse<List<Models.NacPortalModel>> ListOrgNacPortals(
                Guid orgId,
                int? page = 1,
                int? limit = 100)
            => CoreHelper.RunTask(ListOrgNacPortalsAsync(orgId, page, limit));

        /// <summary>
        /// List Org NAC Portals.
        /// </summary>
        /// <param name="orgId">Required parameter: Example: .</param>
        /// <param name="page">Optional parameter: Example: 1.</param>
        /// <param name="limit">Optional parameter: Example: 100.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List&lt;Models.NacPortalModel&gt; response from the API call.</returns>
        public async Task<ApiResponse<List<Models.NacPortalModel>>> ListOrgNacPortalsAsync(
                Guid orgId,
                int? page = 1,
                int? limit = 100,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.NacPortalModel>>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/api/v1/orgs/{org_id}/nacportals")
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
                      .Query(_query => _query.Setup("page", page ?? 1))
                      .Query(_query => _query.Setup("limit", limit ?? 100))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Syntax", (_reason, _context) => new ApiV1OrgsNacportals400ErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new ApiV1OrgsNacportals401ErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Permission Denied", (_reason, _context) => new ApiV1OrgsNacportals403ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not found. The API endpoint doesnâ€™t exist or resource doesnâ€™ t exist", (_reason, _context) => new ResponseHttp404Exception(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too Many Request. The API Token used for the request reached the 5000 API Calls per hour threshold", (_reason, _context) => new ApiV1OrgsNacportals429ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create Org NAC Portal.
        /// </summary>
        /// <param name="orgId">Required parameter: Example: .</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.NacPortalModel response from the API call.</returns>
        public ApiResponse<Models.NacPortalModel> CreateOrgNacPortal(
                Guid orgId,
                Models.NacPortalModel body = null)
            => CoreHelper.RunTask(CreateOrgNacPortalAsync(orgId, body));

        /// <summary>
        /// Create Org NAC Portal.
        /// </summary>
        /// <param name="orgId">Required parameter: Example: .</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.NacPortalModel response from the API call.</returns>
        public async Task<ApiResponse<Models.NacPortalModel>> CreateOrgNacPortalAsync(
                Guid orgId,
                Models.NacPortalModel body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.NacPortalModel>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/api/v1/orgs/{org_id}/nacportals")
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
                  .ErrorCase("400", CreateErrorCase("Bad Syntax", (_reason, _context) => new ApiV1OrgsNacportals400ErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new ApiV1OrgsNacportals401ErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Permission Denied", (_reason, _context) => new ApiV1OrgsNacportals403ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not found. The API endpoint doesnâ€™t exist or resource doesnâ€™ t exist", (_reason, _context) => new ResponseHttp404Exception(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too Many Request. The API Token used for the request reached the 5000 API Calls per hour threshold", (_reason, _context) => new ApiV1OrgsNacportals429ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Delete Org NAC Portal.
        /// </summary>
        /// <param name="orgId">Required parameter: Example: .</param>
        /// <param name="nacportalId">Required parameter: Example: .</param>
        public void DeleteOrgNacPortal(
                Guid orgId,
                Guid nacportalId)
            => CoreHelper.RunVoidTask(DeleteOrgNacPortalAsync(orgId, nacportalId));

        /// <summary>
        /// Delete Org NAC Portal.
        /// </summary>
        /// <param name="orgId">Required parameter: Example: .</param>
        /// <param name="nacportalId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeleteOrgNacPortalAsync(
                Guid orgId,
                Guid nacportalId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/api/v1/orgs/{org_id}/nacportals/{nacportal_id}")
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
                      .Template(_template => _template.Setup("nacportal_id", nacportalId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Syntax", (_reason, _context) => new ApiV1OrgsNacportals400ErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new ApiV1OrgsNacportals401ErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Permission Denied", (_reason, _context) => new ApiV1OrgsNacportals403ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not found. The API endpoint doesnâ€™t exist or resource doesnâ€™ t exist", (_reason, _context) => new ResponseHttp404Exception(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too Many Request. The API Token used for the request reached the 5000 API Calls per hour threshold", (_reason, _context) => new ApiV1OrgsNacportals429ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Get Org NAC Portal.
        /// </summary>
        /// <param name="orgId">Required parameter: Example: .</param>
        /// <param name="nacportalId">Required parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.NacPortalModel response from the API call.</returns>
        public ApiResponse<Models.NacPortalModel> GetOrgNacPortal(
                Guid orgId,
                Guid nacportalId)
            => CoreHelper.RunTask(GetOrgNacPortalAsync(orgId, nacportalId));

        /// <summary>
        /// Get Org NAC Portal.
        /// </summary>
        /// <param name="orgId">Required parameter: Example: .</param>
        /// <param name="nacportalId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.NacPortalModel response from the API call.</returns>
        public async Task<ApiResponse<Models.NacPortalModel>> GetOrgNacPortalAsync(
                Guid orgId,
                Guid nacportalId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.NacPortalModel>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/api/v1/orgs/{org_id}/nacportals/{nacportal_id}")
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
                      .Template(_template => _template.Setup("nacportal_id", nacportalId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Syntax", (_reason, _context) => new ApiV1OrgsNacportals400ErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new ApiV1OrgsNacportals401ErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Permission Denied", (_reason, _context) => new ApiV1OrgsNacportals403ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not found. The API endpoint doesnâ€™t exist or resource doesnâ€™ t exist", (_reason, _context) => new ResponseHttp404Exception(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too Many Request. The API Token used for the request reached the 5000 API Calls per hour threshold", (_reason, _context) => new ApiV1OrgsNacportals429ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Update Org NAC Portal.
        /// </summary>
        /// <param name="orgId">Required parameter: Example: .</param>
        /// <param name="nacportalId">Required parameter: Example: .</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.NacPortalModel response from the API call.</returns>
        public ApiResponse<Models.NacPortalModel> UpdateOrgNacPortal(
                Guid orgId,
                Guid nacportalId,
                Models.NacPortalModel body = null)
            => CoreHelper.RunTask(UpdateOrgNacPortalAsync(orgId, nacportalId, body));

        /// <summary>
        /// Update Org NAC Portal.
        /// </summary>
        /// <param name="orgId">Required parameter: Example: .</param>
        /// <param name="nacportalId">Required parameter: Example: .</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.NacPortalModel response from the API call.</returns>
        public async Task<ApiResponse<Models.NacPortalModel>> UpdateOrgNacPortalAsync(
                Guid orgId,
                Guid nacportalId,
                Models.NacPortalModel body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.NacPortalModel>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/api/v1/orgs/{org_id}/nacportals/{nacportal_id}")
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
                      .Template(_template => _template.Setup("nacportal_id", nacportalId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Syntax", (_reason, _context) => new ApiV1OrgsNacportals400ErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new ApiV1OrgsNacportals401ErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Permission Denied", (_reason, _context) => new ApiV1OrgsNacportals403ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not found. The API endpoint doesnâ€™t exist or resource doesnâ€™ t exist", (_reason, _context) => new ResponseHttp404Exception(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too Many Request. The API Token used for the request reached the 5000 API Calls per hour threshold", (_reason, _context) => new ApiV1OrgsNacportals429ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Get List of Org NAC Portal SSO Latest Failures.
        /// </summary>
        /// <param name="orgId">Required parameter: Example: .</param>
        /// <param name="nacportalId">Required parameter: Example: .</param>
        /// <param name="page">Optional parameter: Example: 1.</param>
        /// <param name="limit">Optional parameter: Example: 100.</param>
        /// <param name="start">Optional parameter: start datetime, can be epoch or relative time like -1d, -1w; -1d if not specified.</param>
        /// <param name="end">Optional parameter: end datetime, can be epoch or relative time like -1d, -2h; now if not specified.</param>
        /// <param name="duration">Optional parameter: duration like 7d, 2w.</param>
        /// <returns>Returns the ApiResponse of Models.ResponseSsoFailureSearchModel response from the API call.</returns>
        public ApiResponse<Models.ResponseSsoFailureSearchModel> ListOrgNacPortalSsoLatestFailures(
                Guid orgId,
                Guid nacportalId,
                int? page = 1,
                int? limit = 100,
                int? start = null,
                int? end = null,
                string duration = "1d")
            => CoreHelper.RunTask(ListOrgNacPortalSsoLatestFailuresAsync(orgId, nacportalId, page, limit, start, end, duration));

        /// <summary>
        /// Get List of Org NAC Portal SSO Latest Failures.
        /// </summary>
        /// <param name="orgId">Required parameter: Example: .</param>
        /// <param name="nacportalId">Required parameter: Example: .</param>
        /// <param name="page">Optional parameter: Example: 1.</param>
        /// <param name="limit">Optional parameter: Example: 100.</param>
        /// <param name="start">Optional parameter: start datetime, can be epoch or relative time like -1d, -1w; -1d if not specified.</param>
        /// <param name="end">Optional parameter: end datetime, can be epoch or relative time like -1d, -2h; now if not specified.</param>
        /// <param name="duration">Optional parameter: duration like 7d, 2w.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ResponseSsoFailureSearchModel response from the API call.</returns>
        public async Task<ApiResponse<Models.ResponseSsoFailureSearchModel>> ListOrgNacPortalSsoLatestFailuresAsync(
                Guid orgId,
                Guid nacportalId,
                int? page = 1,
                int? limit = 100,
                int? start = null,
                int? end = null,
                string duration = "1d",
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ResponseSsoFailureSearchModel>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/api/v1/orgs/{org_id}/nacportals/{nacportal_id}/failures")
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
                      .Template(_template => _template.Setup("nacportal_id", nacportalId))
                      .Query(_query => _query.Setup("page", page ?? 1))
                      .Query(_query => _query.Setup("limit", limit ?? 100))
                      .Query(_query => _query.Setup("start", start))
                      .Query(_query => _query.Setup("end", end))
                      .Query(_query => _query.Setup("duration", duration ?? "1d"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Syntax", (_reason, _context) => new ApiV1OrgsNacportalsFailures400ErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new ApiV1OrgsNacportalsFailures401ErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Permission Denied", (_reason, _context) => new ApiV1OrgsNacportalsFailures403ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not found. The API endpoint doesnâ€™t exist or resource doesnâ€™ t exist", (_reason, _context) => new ResponseHttp404Exception(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too Many Request. The API Token used for the request reached the 5000 API Calls per hour threshold", (_reason, _context) => new ApiV1OrgsNacportalsFailures429ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Delete background image for NAC Portal.
        /// If image is not uploaded or is deleted, NAC Portal will use default image.
        /// </summary>
        /// <param name="orgId">Required parameter: Example: .</param>
        /// <param name="nacportalId">Required parameter: Example: .</param>
        public void DeleteOrgNacPortalImage(
                Guid orgId,
                Guid nacportalId)
            => CoreHelper.RunVoidTask(DeleteOrgNacPortalImageAsync(orgId, nacportalId));

        /// <summary>
        /// Delete background image for NAC Portal.
        /// If image is not uploaded or is deleted, NAC Portal will use default image.
        /// </summary>
        /// <param name="orgId">Required parameter: Example: .</param>
        /// <param name="nacportalId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeleteOrgNacPortalImageAsync(
                Guid orgId,
                Guid nacportalId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/api/v1/orgs/{org_id}/nacportals/{nacportal_id}/portal_image")
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
                      .Template(_template => _template.Setup("nacportal_id", nacportalId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Syntax", (_reason, _context) => new ApiV1OrgsNacportalsPortalImage400ErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new ApiV1OrgsNacportalsPortalImage401ErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Permission Denied", (_reason, _context) => new ApiV1OrgsNacportalsPortalImage403ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not found. The API endpoint doesnâ€™t exist or resource doesnâ€™ t exist", (_reason, _context) => new ResponseHttp404Exception(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too Many Request. The API Token used for the request reached the 5000 API Calls per hour threshold", (_reason, _context) => new ApiV1OrgsNacportalsPortalImage429ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Upload background image for NAC Portal.
        /// </summary>
        /// <param name="orgId">Required parameter: Example: .</param>
        /// <param name="nacportalId">Required parameter: Example: .</param>
        /// <param name="file">Optional parameter: Binary file.</param>
        /// <param name="json">Optional parameter: JSON string describing the upload.</param>
        public void UploadOrgNacPortalImage(
                Guid orgId,
                Guid nacportalId,
                FileStreamInfo file = null,
                string json = null)
            => CoreHelper.RunVoidTask(UploadOrgNacPortalImageAsync(orgId, nacportalId, file, json));

        /// <summary>
        /// Upload background image for NAC Portal.
        /// </summary>
        /// <param name="orgId">Required parameter: Example: .</param>
        /// <param name="nacportalId">Required parameter: Example: .</param>
        /// <param name="file">Optional parameter: Binary file.</param>
        /// <param name="json">Optional parameter: JSON string describing the upload.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task UploadOrgNacPortalImageAsync(
                Guid orgId,
                Guid nacportalId,
                FileStreamInfo file = null,
                string json = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/api/v1/orgs/{org_id}/nacportals/{nacportal_id}/portal_image")
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
                      .Template(_template => _template.Setup("nacportal_id", nacportalId))
                      .Form(_form => _form.Setup("file", file))
                      .Form(_form => _form.Setup("json", json))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Syntax", (_reason, _context) => new ApiV1OrgsNacportalsPortalImage400ErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new ApiV1OrgsNacportalsPortalImage401ErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Permission Denied", (_reason, _context) => new ApiV1OrgsNacportalsPortalImage403ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not found. The API endpoint doesnâ€™t exist or resource doesnâ€™ t exist", (_reason, _context) => new ResponseHttp404Exception(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too Many Request. The API Token used for the request reached the 5000 API Calls per hour threshold", (_reason, _context) => new ApiV1OrgsNacportalsPortalImage429ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Update Org NAC Portal Template.
        /// </summary>
        /// <param name="orgId">Required parameter: Example: .</param>
        /// <param name="nacportalId">Required parameter: Example: .</param>
        /// <param name="body">Optional parameter: Example: .</param>
        public void UpdateOrgNacPortalTempalte(
                Guid orgId,
                Guid nacportalId,
                Models.NacPortalTemplateModel body = null)
            => CoreHelper.RunVoidTask(UpdateOrgNacPortalTempalteAsync(orgId, nacportalId, body));

        /// <summary>
        /// Update Org NAC Portal Template.
        /// </summary>
        /// <param name="orgId">Required parameter: Example: .</param>
        /// <param name="nacportalId">Required parameter: Example: .</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task UpdateOrgNacPortalTempalteAsync(
                Guid orgId,
                Guid nacportalId,
                Models.NacPortalTemplateModel body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/api/v1/orgs/{org_id}/nacportals/{nacportal_id}/portal_template")
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
                      .Template(_template => _template.Setup("nacportal_id", nacportalId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Syntax", (_reason, _context) => new ApiV1OrgsNacportalsPortalTemplate400ErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new ApiV1OrgsNacportalsPortalTemplate401ErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Permission Denied", (_reason, _context) => new ApiV1OrgsNacportalsPortalTemplate403ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not found. The API endpoint doesnâ€™t exist or resource doesnâ€™ t exist", (_reason, _context) => new ResponseHttp404Exception(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too Many Request. The API Token used for the request reached the 5000 API Calls per hour threshold", (_reason, _context) => new ApiV1OrgsNacportalsPortalTemplate429ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}