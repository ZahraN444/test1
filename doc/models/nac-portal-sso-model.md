
# Nac Portal Sso Model

## Structure

`NacPortalSsoModel`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `IdpCert` | `string` | Optional | - |
| `IdpSignAlgo` | `string` | Optional | - |
| `IdpSsoUrl` | `string` | Optional | - |
| `Issuer` | `string` | Optional | - |
| `NameidFormat` | `string` | Optional | - |
| `SsoRoleMatching` | [`List<NacPortalSsoRoleMatchingModel>`](../../doc/models/nac-portal-sso-role-matching-model.md) | Optional | - |
| `UseSsoRoleForCert` | `bool?` | Optional | if it's desired to inject a role into Cert's Subject (so it can be used later on in policy) |

## Example (as JSON)

```json
{
  "idp_cert": "-----BEGIN CERTIFICATE-----\\nMIIFZjCCA06gAwIBAgIIP61/1qm/uDowDQYJKoZIhvcNAQELBQE\\n-----END CERTIFICATE-----",
  "idp_sign_algo": "sha256",
  "idp_sso_url": "https://yourorg.onelogin.com/trust/saml2/http-post/sso/138130",
  "issuer": "https://app.onelogin.com/saml/metadata/138130",
  "nameid_format": "email"
}
```

