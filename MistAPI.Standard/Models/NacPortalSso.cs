// <copyright file="NacPortalSso.cs" company="APIMatic">
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
using MistAPI.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MistAPI.Standard.Models
{
    /// <summary>
    /// NacPortalSso.
    /// </summary>
    public class NacPortalSso
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NacPortalSso"/> class.
        /// </summary>
        public NacPortalSso()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NacPortalSso"/> class.
        /// </summary>
        /// <param name="idpCert">idp_cert.</param>
        /// <param name="idpSignAlgo">idp_sign_algo.</param>
        /// <param name="idpSsoUrl">idp_sso_url.</param>
        /// <param name="issuer">issuer.</param>
        /// <param name="nameidFormat">nameid_format.</param>
        /// <param name="ssoRoleMatching">sso_role_matching.</param>
        /// <param name="useSsoRoleForCert">use_sso_role_for_cert.</param>
        public NacPortalSso(
            string idpCert = null,
            string idpSignAlgo = null,
            string idpSsoUrl = null,
            string issuer = null,
            string nameidFormat = null,
            List<Models.NacPortalSsoRoleMatching> ssoRoleMatching = null,
            bool? useSsoRoleForCert = null)
        {
            this.IdpCert = idpCert;
            this.IdpSignAlgo = idpSignAlgo;
            this.IdpSsoUrl = idpSsoUrl;
            this.Issuer = issuer;
            this.NameidFormat = nameidFormat;
            this.SsoRoleMatching = ssoRoleMatching;
            this.UseSsoRoleForCert = useSsoRoleForCert;
        }

        /// <summary>
        /// Gets or sets IdpCert.
        /// </summary>
        [JsonProperty("idp_cert", NullValueHandling = NullValueHandling.Ignore)]
        public string IdpCert { get; set; }

        /// <summary>
        /// Gets or sets IdpSignAlgo.
        /// </summary>
        [JsonProperty("idp_sign_algo", NullValueHandling = NullValueHandling.Ignore)]
        public string IdpSignAlgo { get; set; }

        /// <summary>
        /// Gets or sets IdpSsoUrl.
        /// </summary>
        [JsonProperty("idp_sso_url", NullValueHandling = NullValueHandling.Ignore)]
        public string IdpSsoUrl { get; set; }

        /// <summary>
        /// Gets or sets Issuer.
        /// </summary>
        [JsonProperty("issuer", NullValueHandling = NullValueHandling.Ignore)]
        public string Issuer { get; set; }

        /// <summary>
        /// Gets or sets NameidFormat.
        /// </summary>
        [JsonProperty("nameid_format", NullValueHandling = NullValueHandling.Ignore)]
        public string NameidFormat { get; set; }

        /// <summary>
        /// Gets or sets SsoRoleMatching.
        /// </summary>
        [JsonProperty("sso_role_matching", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.NacPortalSsoRoleMatching> SsoRoleMatching { get; set; }

        /// <summary>
        /// if it's desired to inject a role into Cert's Subject (so it can be used later on in policy)
        /// </summary>
        [JsonProperty("use_sso_role_for_cert", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseSsoRoleForCert { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"NacPortalSso : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is NacPortalSso other &&                ((this.IdpCert == null && other.IdpCert == null) || (this.IdpCert?.Equals(other.IdpCert) == true)) &&
                ((this.IdpSignAlgo == null && other.IdpSignAlgo == null) || (this.IdpSignAlgo?.Equals(other.IdpSignAlgo) == true)) &&
                ((this.IdpSsoUrl == null && other.IdpSsoUrl == null) || (this.IdpSsoUrl?.Equals(other.IdpSsoUrl) == true)) &&
                ((this.Issuer == null && other.Issuer == null) || (this.Issuer?.Equals(other.Issuer) == true)) &&
                ((this.NameidFormat == null && other.NameidFormat == null) || (this.NameidFormat?.Equals(other.NameidFormat) == true)) &&
                ((this.SsoRoleMatching == null && other.SsoRoleMatching == null) || (this.SsoRoleMatching?.Equals(other.SsoRoleMatching) == true)) &&
                ((this.UseSsoRoleForCert == null && other.UseSsoRoleForCert == null) || (this.UseSsoRoleForCert?.Equals(other.UseSsoRoleForCert) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.IdpCert = {(this.IdpCert == null ? "null" : this.IdpCert)}");
            toStringOutput.Add($"this.IdpSignAlgo = {(this.IdpSignAlgo == null ? "null" : this.IdpSignAlgo)}");
            toStringOutput.Add($"this.IdpSsoUrl = {(this.IdpSsoUrl == null ? "null" : this.IdpSsoUrl)}");
            toStringOutput.Add($"this.Issuer = {(this.Issuer == null ? "null" : this.Issuer)}");
            toStringOutput.Add($"this.NameidFormat = {(this.NameidFormat == null ? "null" : this.NameidFormat)}");
            toStringOutput.Add($"this.SsoRoleMatching = {(this.SsoRoleMatching == null ? "null" : $"[{string.Join(", ", this.SsoRoleMatching)} ]")}");
            toStringOutput.Add($"this.UseSsoRoleForCert = {(this.UseSsoRoleForCert == null ? "null" : this.UseSsoRoleForCert.ToString())}");
        }
    }
}