// <copyright file="OrgsNACTagsControllerTest.cs" company="APIMatic">
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
    /// OrgsNACTagsControllerTest.
    /// </summary>
    [TestFixture]
    public class OrgsNACTagsControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private OrgsNACTagsController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.OrgsNACTagsController;
        }

        /// <summary>
        /// Get List of Org NAC Tags.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestListOrgNacTags()
        {
            // Parameters for the API call
            Guid orgId = Guid.Parse("000000ab-00ab-00ab-00ab-0000000000ab");
            string type = null;
            string name = null;
            string match = null;
            int? page = 1;
            int? limit = 100;

            // Perform API call
            ApiResponse<List<Standard.Models.NacTag>> result = null;
            try
            {
                result = await this.controller.ListOrgNacTagsAsync(orgId, type, name, match, page, limit);
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
        }

        /// <summary>
        /// Create Org NAC Tag.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCreateOrgNacTag()
        {
            // Parameters for the API call
            Guid orgId = Guid.Parse("000000ab-00ab-00ab-00ab-0000000000ab");
            Standard.Models.NacTag body = null;

            // Perform API call
            ApiResponse<Standard.Models.NacTag> result = null;
            try
            {
                result = await this.controller.CreateOrgNacTagAsync(orgId, body);
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
                    "{\"match\":\"client_mac\",\"name\":\"cameras\",\"type\":\"match\",\"values\":[\"010203040506\",\"abcdef*\"]}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Delete Org NAC Tag.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestDeleteOrgNacTag()
        {
            // Parameters for the API call
            Guid orgId = Guid.Parse("000000ab-00ab-00ab-00ab-0000000000ab");
            Guid nactagId = Guid.Parse("000000ab-00ab-00ab-00ab-0000000000ab");

            // Perform API call
            try
            {
                await this.controller.DeleteOrgNacTagAsync(orgId, nactagId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// Get Org NAC Tag.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetOrgNacTag()
        {
            // Parameters for the API call
            Guid orgId = Guid.Parse("000000ab-00ab-00ab-00ab-0000000000ab");
            Guid nactagId = Guid.Parse("000000ab-00ab-00ab-00ab-0000000000ab");

            // Perform API call
            ApiResponse<Standard.Models.NacTag> result = null;
            try
            {
                result = await this.controller.GetOrgNacTagAsync(orgId, nactagId);
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
                    "{\"match\":\"client_mac\",\"name\":\"cameras\",\"type\":\"match\",\"values\":[\"010203040506\",\"abcdef*\"]}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Update Org NAC Tag.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestUpdateOrgNacTag()
        {
            // Parameters for the API call
            Guid orgId = Guid.Parse("000000ab-00ab-00ab-00ab-0000000000ab");
            Guid nactagId = Guid.Parse("000000ab-00ab-00ab-00ab-0000000000ab");
            Standard.Models.NacTag body = null;

            // Perform API call
            ApiResponse<Standard.Models.NacTag> result = null;
            try
            {
                result = await this.controller.UpdateOrgNacTagAsync(orgId, nactagId, body);
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
                    "{\"match\":\"client_mac\",\"name\":\"cameras\",\"type\":\"match\",\"values\":[\"010203040506\",\"abcdef*\"]}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}