// <copyright file="OrgsNACPortalsControllerTest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using APIMatic.Core.Utilities;
using MistAPI.Standard;
using MistAPI.Standard.Controllers;
using MistAPI.Standard.Exceptions;
using MistAPI.Standard.Http.Client;
using MistAPI.Standard.Http.Response;
using MistAPI.Standard.Utilities;
using Newtonsoft.Json.Converters;
using NUnit.Framework;

namespace MistAPI.Tests
{
    /// <summary>
    /// OrgsNACPortalsControllerTest.
    /// </summary>
    [TestFixture]
    public class OrgsNACPortalsControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private OrgsNACPortalsController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.OrgsNACPortalsController;
        }

        /// <summary>
        /// List Org NAC Portals.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestListOrgNacPortals()
        {
            // Parameters for the API call
            Guid orgId = Guid.Parse("000000ab-00ab-00ab-00ab-0000000000ab");
            int? page = 1;
            int? limit = 100;

            // Perform API call
            ApiResponse<List<Standard.Models.NacPortalModel>> result = null;
            try
            {
                result = await this.controller.ListOrgNacPortalsAsync(orgId, page, limit);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsProperSubsetOf(
                    "[{\"access_type\":\"wireless\",\"cert_expire_time\":365,\"enable_telemetry\":true,\"expiry_notification_time\":2,\"name\":\"get-wifi\",\"notify_expiry\":true,\"ssid\":\"Corp\",\"sso\":{\"idp_cert\":\"-----BEGIN CERTIFICATE-----\\nMIIFZjCCA06gAwIBAgIIP61/1qm/uDowDQYJKoZIhvcNAQELBQE\\n-----END CERTIFICATE-----\",\"idp_sign_algo\":\"sha256\",\"idp_sso_url\":\"https://yourorg.onelogin.com/trust/saml2/http-post/sso/138130\",\"issuer\":\"https://app.onelogin.com/saml/metadata/138130\",\"nameid_format\":\"email\",\"sso_role_matching\":[{\"assigned\":\"user\",\"match\":\"Student\"}],\"use_sso_role_for_cert\":true}}]",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Create Org NAC Portal.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCreateOrgNacPortal()
        {
            // Parameters for the API call
            Guid orgId = Guid.Parse("000000ab-00ab-00ab-00ab-0000000000ab");
            Standard.Models.NacPortalModel body = null;

            // Perform API call
            ApiResponse<Standard.Models.NacPortalModel> result = null;
            try
            {
                result = await this.controller.CreateOrgNacPortalAsync(orgId, body);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsProperSubsetOf(
                    "{\"access_type\":\"wireless\",\"cert_expire_time\":365,\"enable_telemetry\":true,\"expiry_notification_time\":2,\"name\":\"get-wifi\",\"notify_expiry\":true,\"ssid\":\"Corp\",\"sso\":{\"idp_cert\":\"-----BEGIN CERTIFICATE-----\\nMIIFZjCCA06gAwIBAgIIP61/1qm/uDowDQYJKoZIhvcNAQELBQE\\n-----END CERTIFICATE-----\",\"idp_sign_algo\":\"sha256\",\"idp_sso_url\":\"https://yourorg.onelogin.com/trust/saml2/http-post/sso/138130\",\"issuer\":\"https://app.onelogin.com/saml/metadata/138130\",\"nameid_format\":\"email\",\"sso_role_matching\":[{\"assigned\":\"user\",\"match\":\"Student\"}],\"use_sso_role_for_cert\":true}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Delete Org NAC Portal.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestDeleteOrgNacPortal()
        {
            // Parameters for the API call
            Guid orgId = Guid.Parse("000000ab-00ab-00ab-00ab-0000000000ab");
            Guid nacportalId = Guid.Parse("000000ab-00ab-00ab-00ab-0000000000ab");

            // Perform API call
            try
            {
                await this.controller.DeleteOrgNacPortalAsync(orgId, nacportalId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// Get Org NAC Portal.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetOrgNacPortal()
        {
            // Parameters for the API call
            Guid orgId = Guid.Parse("000000ab-00ab-00ab-00ab-0000000000ab");
            Guid nacportalId = Guid.Parse("000000ab-00ab-00ab-00ab-0000000000ab");

            // Perform API call
            ApiResponse<Standard.Models.NacPortalModel> result = null;
            try
            {
                result = await this.controller.GetOrgNacPortalAsync(orgId, nacportalId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsProperSubsetOf(
                    "{\"access_type\":\"wireless\",\"cert_expire_time\":365,\"enable_telemetry\":true,\"expiry_notification_time\":2,\"name\":\"get-wifi\",\"notify_expiry\":true,\"ssid\":\"Corp\",\"sso\":{\"idp_cert\":\"-----BEGIN CERTIFICATE-----\\nMIIFZjCCA06gAwIBAgIIP61/1qm/uDowDQYJKoZIhvcNAQELBQE\\n-----END CERTIFICATE-----\",\"idp_sign_algo\":\"sha256\",\"idp_sso_url\":\"https://yourorg.onelogin.com/trust/saml2/http-post/sso/138130\",\"issuer\":\"https://app.onelogin.com/saml/metadata/138130\",\"nameid_format\":\"email\",\"sso_role_matching\":[{\"assigned\":\"user\",\"match\":\"Student\"}],\"use_sso_role_for_cert\":true}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Update Org NAC Portal.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestUpdateOrgNacPortal()
        {
            // Parameters for the API call
            Guid orgId = Guid.Parse("000000ab-00ab-00ab-00ab-0000000000ab");
            Guid nacportalId = Guid.Parse("000000ab-00ab-00ab-00ab-0000000000ab");
            Standard.Models.NacPortalModel body = null;

            // Perform API call
            ApiResponse<Standard.Models.NacPortalModel> result = null;
            try
            {
                result = await this.controller.UpdateOrgNacPortalAsync(orgId, nacportalId, body);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsProperSubsetOf(
                    "{\"access_type\":\"wireless\",\"cert_expire_time\":365,\"enable_telemetry\":true,\"expiry_notification_time\":2,\"name\":\"get-wifi\",\"notify_expiry\":true,\"ssid\":\"Corp\",\"sso\":{\"idp_cert\":\"-----BEGIN CERTIFICATE-----\\nMIIFZjCCA06gAwIBAgIIP61/1qm/uDowDQYJKoZIhvcNAQELBQE\\n-----END CERTIFICATE-----\",\"idp_sign_algo\":\"sha256\",\"idp_sso_url\":\"https://yourorg.onelogin.com/trust/saml2/http-post/sso/138130\",\"issuer\":\"https://app.onelogin.com/saml/metadata/138130\",\"nameid_format\":\"email\",\"sso_role_matching\":[{\"assigned\":\"user\",\"match\":\"Student\"}],\"use_sso_role_for_cert\":true}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Get List of Org NAC Portal SSO Latest Failures.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestListOrgNacPortalSsoLatestFailures()
        {
            // Parameters for the API call
            Guid orgId = Guid.Parse("000000ab-00ab-00ab-00ab-0000000000ab");
            Guid nacportalId = Guid.Parse("000000ab-00ab-00ab-00ab-0000000000ab");
            int? page = 1;
            int? limit = 100;
            int? start = null;
            int? end = null;
            string duration = "1d";

            // Perform API call
            ApiResponse<Standard.Models.ResponseSsoFailureSearchModel> result = null;
            try
            {
                result = await this.controller.ListOrgNacPortalSsoLatestFailuresAsync(orgId, nacportalId, page, limit, start, end, duration);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsProperSubsetOf(
                    "{\"results\":[{\"detail\":\"string\",\"saml_assertion_xml\":\"string\",\"timestamp\":0}]}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Delete background image for NAC Portal
        ///
        ///
        ///If image is not uploaded or is deleted, NAC Portal will use default image..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestDeleteOrgNacPortalImage()
        {
            // Parameters for the API call
            Guid orgId = Guid.Parse("000000ab-00ab-00ab-00ab-0000000000ab");
            Guid nacportalId = Guid.Parse("000000ab-00ab-00ab-00ab-0000000000ab");

            // Perform API call
            try
            {
                await this.controller.DeleteOrgNacPortalImageAsync(orgId, nacportalId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// Upload background image for NAC Portal.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestUploadOrgNacPortalImage()
        {
            // Parameters for the API call
            Guid orgId = Guid.Parse("000000ab-00ab-00ab-00ab-0000000000ab");
            Guid nacportalId = Guid.Parse("000000ab-00ab-00ab-00ab-0000000000ab");
            FileStreamInfo file = null;
            string json = null;

            // Perform API call
            try
            {
                await this.controller.UploadOrgNacPortalImageAsync(orgId, nacportalId, file, json);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// Update Org NAC Portal Template.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestUpdateOrgNacPortalTempalte()
        {
            // Parameters for the API call
            Guid orgId = Guid.Parse("000000ab-00ab-00ab-00ab-0000000000ab");
            Guid nacportalId = Guid.Parse("000000ab-00ab-00ab-00ab-0000000000ab");
            Standard.Models.NacPortalTemplateModel body = null;

            // Perform API call
            try
            {
                await this.controller.UpdateOrgNacPortalTempalteAsync(orgId, nacportalId, body);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }
    }
}