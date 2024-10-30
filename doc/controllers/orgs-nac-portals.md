# Orgs NAC Portals

```csharp
OrgsNACPortalsController orgsNACPortalsController = client.OrgsNACPortalsController;
```

## Class Name

`OrgsNACPortalsController`

## Methods

* [List Org Nac Portals](../../doc/controllers/orgs-nac-portals.md#list-org-nac-portals)
* [Create Org Nac Portal](../../doc/controllers/orgs-nac-portals.md#create-org-nac-portal)
* [Delete Org Nac Portal](../../doc/controllers/orgs-nac-portals.md#delete-org-nac-portal)
* [Get Org Nac Portal](../../doc/controllers/orgs-nac-portals.md#get-org-nac-portal)
* [Update Org Nac Portal](../../doc/controllers/orgs-nac-portals.md#update-org-nac-portal)
* [List Org Nac Portal Sso Latest Failures](../../doc/controllers/orgs-nac-portals.md#list-org-nac-portal-sso-latest-failures)
* [Delete Org Nac Portal Image](../../doc/controllers/orgs-nac-portals.md#delete-org-nac-portal-image)
* [Upload Org Nac Portal Image](../../doc/controllers/orgs-nac-portals.md#upload-org-nac-portal-image)
* [Update Org Nac Portal Tempalte](../../doc/controllers/orgs-nac-portals.md#update-org-nac-portal-tempalte)


# List Org Nac Portals

List Org NAC Portals

```csharp
ListOrgNacPortalsAsync(
    Guid orgId,
    int? page = 1,
    int? limit = 100)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `orgId` | `Guid` | Template, Required | - |
| `page` | `int?` | Query, Optional | **Default**: `1`<br>**Constraints**: `>= 1` |
| `limit` | `int?` | Query, Optional | **Default**: `100`<br>**Constraints**: `>= 0` |

## Response Type

[`Task<ApiResponse<List<Models.NacPortal>>>`](../../doc/models/nac-portal.md)

## Example Usage

```csharp
Guid orgId = new Guid("000000ab-00ab-00ab-00ab-0000000000ab");
int? page = 1;
int? limit = 100;
try
{
    ApiResponse<List<NacPortal>> result = await orgsNACPortalsController.ListOrgNacPortalsAsync(
        orgId,
        page,
        limit
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
[
  {
    "access_type": "wireless",
    "cert_expire_time": 365,
    "enable_telemetry": true,
    "expiry_notification_time": 2,
    "name": "get-wifi",
    "notify_expiry": true,
    "ssid": "Corp",
    "sso": {
      "idp_cert": "-----BEGIN CERTIFICATE-----\nMIIFZjCCA06gAwIBAgIIP61/1qm/uDowDQYJKoZIhvcNAQELBQE\n-----END CERTIFICATE-----",
      "idp_sign_algo": "sha256",
      "idp_sso_url": "https://yourorg.onelogin.com/trust/saml2/http-post/sso/138130",
      "issuer": "https://app.onelogin.com/saml/metadata/138130",
      "nameid_format": "email",
      "sso_role_matching": [
        {
          "assigned": "user",
          "match": "Student"
        }
      ],
      "use_sso_role_for_cert": true
    }
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Syntax | [`ApiV1OrgsNacportals400ErrorException`](../../doc/models/api-v1-orgs-nacportals-400-error-exception.md) |
| 401 | Unauthorized | [`ApiV1OrgsNacportals401ErrorException`](../../doc/models/api-v1-orgs-nacportals-401-error-exception.md) |
| 403 | Permission Denied | [`ApiV1OrgsNacportals403ErrorException`](../../doc/models/api-v1-orgs-nacportals-403-error-exception.md) |
| 404 | Not found. The API endpoint doesnâ€™t exist or resource doesnâ€™ t exist | [`ResponseHttp404Exception`](../../doc/models/response-http-404-exception.md) |
| 429 | Too Many Request. The API Token used for the request reached the 5000 API Calls per hour threshold | [`ApiV1OrgsNacportals429ErrorException`](../../doc/models/api-v1-orgs-nacportals-429-error-exception.md) |


# Create Org Nac Portal

Create Org NAC Portal

```csharp
CreateOrgNacPortalAsync(
    Guid orgId,
    Models.NacPortal body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `orgId` | `Guid` | Template, Required | - |
| `body` | [`NacPortal`](../../doc/models/nac-portal.md) | Body, Optional | - |

## Response Type

[`Task<ApiResponse<Models.NacPortal>>`](../../doc/models/nac-portal.md)

## Example Usage

```csharp
Guid orgId = new Guid("000000ab-00ab-00ab-00ab-0000000000ab");
NacPortal body = new NacPortal
{
    CertExpireTime = 365,
    Name = "get-wifi",
    Ssid = "Corp",
};

try
{
    ApiResponse<NacPortal> result = await orgsNACPortalsController.CreateOrgNacPortalAsync(
        orgId,
        body
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "access_type": "wireless",
  "cert_expire_time": 365,
  "enable_telemetry": true,
  "expiry_notification_time": 2,
  "name": "get-wifi",
  "notify_expiry": true,
  "ssid": "Corp",
  "sso": {
    "idp_cert": "-----BEGIN CERTIFICATE-----\nMIIFZjCCA06gAwIBAgIIP61/1qm/uDowDQYJKoZIhvcNAQELBQE\n-----END CERTIFICATE-----",
    "idp_sign_algo": "sha256",
    "idp_sso_url": "https://yourorg.onelogin.com/trust/saml2/http-post/sso/138130",
    "issuer": "https://app.onelogin.com/saml/metadata/138130",
    "nameid_format": "email",
    "sso_role_matching": [
      {
        "assigned": "user",
        "match": "Student"
      }
    ],
    "use_sso_role_for_cert": true
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Syntax | [`ApiV1OrgsNacportals400ErrorException`](../../doc/models/api-v1-orgs-nacportals-400-error-exception.md) |
| 401 | Unauthorized | [`ApiV1OrgsNacportals401ErrorException`](../../doc/models/api-v1-orgs-nacportals-401-error-exception.md) |
| 403 | Permission Denied | [`ApiV1OrgsNacportals403ErrorException`](../../doc/models/api-v1-orgs-nacportals-403-error-exception.md) |
| 404 | Not found. The API endpoint doesnâ€™t exist or resource doesnâ€™ t exist | [`ResponseHttp404Exception`](../../doc/models/response-http-404-exception.md) |
| 429 | Too Many Request. The API Token used for the request reached the 5000 API Calls per hour threshold | [`ApiV1OrgsNacportals429ErrorException`](../../doc/models/api-v1-orgs-nacportals-429-error-exception.md) |


# Delete Org Nac Portal

Delete Org NAC Portal

```csharp
DeleteOrgNacPortalAsync(
    Guid orgId,
    Guid nacportalId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `orgId` | `Guid` | Template, Required | - |
| `nacportalId` | `Guid` | Template, Required | - |

## Response Type

`Task`

## Example Usage

```csharp
Guid orgId = new Guid("000000ab-00ab-00ab-00ab-0000000000ab");
Guid nacportalId = new Guid("000000ab-00ab-00ab-00ab-0000000000ab");
try
{
    await orgsNACPortalsController.DeleteOrgNacPortalAsync(
        orgId,
        nacportalId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Syntax | [`ApiV1OrgsNacportals400ErrorException`](../../doc/models/api-v1-orgs-nacportals-400-error-exception.md) |
| 401 | Unauthorized | [`ApiV1OrgsNacportals401ErrorException`](../../doc/models/api-v1-orgs-nacportals-401-error-exception.md) |
| 403 | Permission Denied | [`ApiV1OrgsNacportals403ErrorException`](../../doc/models/api-v1-orgs-nacportals-403-error-exception.md) |
| 404 | Not found. The API endpoint doesnâ€™t exist or resource doesnâ€™ t exist | [`ResponseHttp404Exception`](../../doc/models/response-http-404-exception.md) |
| 429 | Too Many Request. The API Token used for the request reached the 5000 API Calls per hour threshold | [`ApiV1OrgsNacportals429ErrorException`](../../doc/models/api-v1-orgs-nacportals-429-error-exception.md) |


# Get Org Nac Portal

Get Org NAC Portal

```csharp
GetOrgNacPortalAsync(
    Guid orgId,
    Guid nacportalId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `orgId` | `Guid` | Template, Required | - |
| `nacportalId` | `Guid` | Template, Required | - |

## Response Type

[`Task<ApiResponse<Models.NacPortal>>`](../../doc/models/nac-portal.md)

## Example Usage

```csharp
Guid orgId = new Guid("000000ab-00ab-00ab-00ab-0000000000ab");
Guid nacportalId = new Guid("000000ab-00ab-00ab-00ab-0000000000ab");
try
{
    ApiResponse<NacPortal> result = await orgsNACPortalsController.GetOrgNacPortalAsync(
        orgId,
        nacportalId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "access_type": "wireless",
  "cert_expire_time": 365,
  "enable_telemetry": true,
  "expiry_notification_time": 2,
  "name": "get-wifi",
  "notify_expiry": true,
  "ssid": "Corp",
  "sso": {
    "idp_cert": "-----BEGIN CERTIFICATE-----\nMIIFZjCCA06gAwIBAgIIP61/1qm/uDowDQYJKoZIhvcNAQELBQE\n-----END CERTIFICATE-----",
    "idp_sign_algo": "sha256",
    "idp_sso_url": "https://yourorg.onelogin.com/trust/saml2/http-post/sso/138130",
    "issuer": "https://app.onelogin.com/saml/metadata/138130",
    "nameid_format": "email",
    "sso_role_matching": [
      {
        "assigned": "user",
        "match": "Student"
      }
    ],
    "use_sso_role_for_cert": true
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Syntax | [`ApiV1OrgsNacportals400ErrorException`](../../doc/models/api-v1-orgs-nacportals-400-error-exception.md) |
| 401 | Unauthorized | [`ApiV1OrgsNacportals401ErrorException`](../../doc/models/api-v1-orgs-nacportals-401-error-exception.md) |
| 403 | Permission Denied | [`ApiV1OrgsNacportals403ErrorException`](../../doc/models/api-v1-orgs-nacportals-403-error-exception.md) |
| 404 | Not found. The API endpoint doesnâ€™t exist or resource doesnâ€™ t exist | [`ResponseHttp404Exception`](../../doc/models/response-http-404-exception.md) |
| 429 | Too Many Request. The API Token used for the request reached the 5000 API Calls per hour threshold | [`ApiV1OrgsNacportals429ErrorException`](../../doc/models/api-v1-orgs-nacportals-429-error-exception.md) |


# Update Org Nac Portal

Update Org NAC Portal

```csharp
UpdateOrgNacPortalAsync(
    Guid orgId,
    Guid nacportalId,
    Models.NacPortal body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `orgId` | `Guid` | Template, Required | - |
| `nacportalId` | `Guid` | Template, Required | - |
| `body` | [`NacPortal`](../../doc/models/nac-portal.md) | Body, Optional | - |

## Response Type

[`Task<ApiResponse<Models.NacPortal>>`](../../doc/models/nac-portal.md)

## Example Usage

```csharp
Guid orgId = new Guid("000000ab-00ab-00ab-00ab-0000000000ab");
Guid nacportalId = new Guid("000000ab-00ab-00ab-00ab-0000000000ab");
NacPortal body = new NacPortal
{
    CertExpireTime = 365,
    Name = "get-wifi",
    Ssid = "Corp",
};

try
{
    ApiResponse<NacPortal> result = await orgsNACPortalsController.UpdateOrgNacPortalAsync(
        orgId,
        nacportalId,
        body
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "access_type": "wireless",
  "cert_expire_time": 365,
  "enable_telemetry": true,
  "expiry_notification_time": 2,
  "name": "get-wifi",
  "notify_expiry": true,
  "ssid": "Corp",
  "sso": {
    "idp_cert": "-----BEGIN CERTIFICATE-----\nMIIFZjCCA06gAwIBAgIIP61/1qm/uDowDQYJKoZIhvcNAQELBQE\n-----END CERTIFICATE-----",
    "idp_sign_algo": "sha256",
    "idp_sso_url": "https://yourorg.onelogin.com/trust/saml2/http-post/sso/138130",
    "issuer": "https://app.onelogin.com/saml/metadata/138130",
    "nameid_format": "email",
    "sso_role_matching": [
      {
        "assigned": "user",
        "match": "Student"
      }
    ],
    "use_sso_role_for_cert": true
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Syntax | [`ApiV1OrgsNacportals400ErrorException`](../../doc/models/api-v1-orgs-nacportals-400-error-exception.md) |
| 401 | Unauthorized | [`ApiV1OrgsNacportals401ErrorException`](../../doc/models/api-v1-orgs-nacportals-401-error-exception.md) |
| 403 | Permission Denied | [`ApiV1OrgsNacportals403ErrorException`](../../doc/models/api-v1-orgs-nacportals-403-error-exception.md) |
| 404 | Not found. The API endpoint doesnâ€™t exist or resource doesnâ€™ t exist | [`ResponseHttp404Exception`](../../doc/models/response-http-404-exception.md) |
| 429 | Too Many Request. The API Token used for the request reached the 5000 API Calls per hour threshold | [`ApiV1OrgsNacportals429ErrorException`](../../doc/models/api-v1-orgs-nacportals-429-error-exception.md) |


# List Org Nac Portal Sso Latest Failures

Get List of Org NAC Portal SSO Latest Failures

```csharp
ListOrgNacPortalSsoLatestFailuresAsync(
    Guid orgId,
    Guid nacportalId,
    int? page = 1,
    int? limit = 100,
    int? start = null,
    int? end = null,
    string duration = "1d")
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `orgId` | `Guid` | Template, Required | - |
| `nacportalId` | `Guid` | Template, Required | - |
| `page` | `int?` | Query, Optional | **Default**: `1`<br>**Constraints**: `>= 1` |
| `limit` | `int?` | Query, Optional | **Default**: `100`<br>**Constraints**: `>= 0` |
| `start` | `int?` | Query, Optional | start datetime, can be epoch or relative time like -1d, -1w; -1d if not specified |
| `end` | `int?` | Query, Optional | end datetime, can be epoch or relative time like -1d, -2h; now if not specified |
| `duration` | `string` | Query, Optional | duration like 7d, 2w<br>**Default**: `"1d"` |

## Response Type

[`Task<ApiResponse<Models.ResponseSsoFailureSearch>>`](../../doc/models/response-sso-failure-search.md)

## Example Usage

```csharp
Guid orgId = new Guid("000000ab-00ab-00ab-00ab-0000000000ab");
Guid nacportalId = new Guid("000000ab-00ab-00ab-00ab-0000000000ab");
int? page = 1;
int? limit = 100;
string duration = "10m";
try
{
    ApiResponse<ResponseSsoFailureSearch> result = await orgsNACPortalsController.ListOrgNacPortalSsoLatestFailuresAsync(
        orgId,
        nacportalId,
        page,
        limit,
        null,
        null,
        duration
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "results": [
    {
      "detail": "string",
      "saml_assertion_xml": "string",
      "timestamp": 0
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Syntax | [`ApiV1OrgsNacportalsFailures400ErrorException`](../../doc/models/api-v1-orgs-nacportals-failures-400-error-exception.md) |
| 401 | Unauthorized | [`ApiV1OrgsNacportalsFailures401ErrorException`](../../doc/models/api-v1-orgs-nacportals-failures-401-error-exception.md) |
| 403 | Permission Denied | [`ApiV1OrgsNacportalsFailures403ErrorException`](../../doc/models/api-v1-orgs-nacportals-failures-403-error-exception.md) |
| 404 | Not found. The API endpoint doesnâ€™t exist or resource doesnâ€™ t exist | [`ResponseHttp404Exception`](../../doc/models/response-http-404-exception.md) |
| 429 | Too Many Request. The API Token used for the request reached the 5000 API Calls per hour threshold | [`ApiV1OrgsNacportalsFailures429ErrorException`](../../doc/models/api-v1-orgs-nacportals-failures-429-error-exception.md) |


# Delete Org Nac Portal Image

Delete background image for NAC Portal

If image is not uploaded or is deleted, NAC Portal will use default image.

```csharp
DeleteOrgNacPortalImageAsync(
    Guid orgId,
    Guid nacportalId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `orgId` | `Guid` | Template, Required | - |
| `nacportalId` | `Guid` | Template, Required | - |

## Response Type

`Task`

## Example Usage

```csharp
Guid orgId = new Guid("000000ab-00ab-00ab-00ab-0000000000ab");
Guid nacportalId = new Guid("000000ab-00ab-00ab-00ab-0000000000ab");
try
{
    await orgsNACPortalsController.DeleteOrgNacPortalImageAsync(
        orgId,
        nacportalId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Syntax | [`ApiV1OrgsNacportalsPortalImage400ErrorException`](../../doc/models/api-v1-orgs-nacportals-portal-image-400-error-exception.md) |
| 401 | Unauthorized | [`ApiV1OrgsNacportalsPortalImage401ErrorException`](../../doc/models/api-v1-orgs-nacportals-portal-image-401-error-exception.md) |
| 403 | Permission Denied | [`ApiV1OrgsNacportalsPortalImage403ErrorException`](../../doc/models/api-v1-orgs-nacportals-portal-image-403-error-exception.md) |
| 404 | Not found. The API endpoint doesnâ€™t exist or resource doesnâ€™ t exist | [`ResponseHttp404Exception`](../../doc/models/response-http-404-exception.md) |
| 429 | Too Many Request. The API Token used for the request reached the 5000 API Calls per hour threshold | [`ApiV1OrgsNacportalsPortalImage429ErrorException`](../../doc/models/api-v1-orgs-nacportals-portal-image-429-error-exception.md) |


# Upload Org Nac Portal Image

Upload background image for NAC Portal

```csharp
UploadOrgNacPortalImageAsync(
    Guid orgId,
    Guid nacportalId,
    FileStreamInfo file = null,
    string json = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `orgId` | `Guid` | Template, Required | - |
| `nacportalId` | `Guid` | Template, Required | - |
| `file` | `FileStreamInfo` | Form, Optional | Binary file |
| `json` | `string` | Form, Optional | JSON string describing the upload |

## Response Type

`Task`

## Example Usage

```csharp
Guid orgId = new Guid("000000ab-00ab-00ab-00ab-0000000000ab");
Guid nacportalId = new Guid("000000ab-00ab-00ab-00ab-0000000000ab");
try
{
    await orgsNACPortalsController.UploadOrgNacPortalImageAsync(
        orgId,
        nacportalId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Syntax | [`ApiV1OrgsNacportalsPortalImage400ErrorException`](../../doc/models/api-v1-orgs-nacportals-portal-image-400-error-exception.md) |
| 401 | Unauthorized | [`ApiV1OrgsNacportalsPortalImage401ErrorException`](../../doc/models/api-v1-orgs-nacportals-portal-image-401-error-exception.md) |
| 403 | Permission Denied | [`ApiV1OrgsNacportalsPortalImage403ErrorException`](../../doc/models/api-v1-orgs-nacportals-portal-image-403-error-exception.md) |
| 404 | Not found. The API endpoint doesnâ€™t exist or resource doesnâ€™ t exist | [`ResponseHttp404Exception`](../../doc/models/response-http-404-exception.md) |
| 429 | Too Many Request. The API Token used for the request reached the 5000 API Calls per hour threshold | [`ApiV1OrgsNacportalsPortalImage429ErrorException`](../../doc/models/api-v1-orgs-nacportals-portal-image-429-error-exception.md) |


# Update Org Nac Portal Tempalte

Update Org NAC Portal Template

```csharp
UpdateOrgNacPortalTempalteAsync(
    Guid orgId,
    Guid nacportalId,
    Models.NacPortalTemplate body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `orgId` | `Guid` | Template, Required | - |
| `nacportalId` | `Guid` | Template, Required | - |
| `body` | [`NacPortalTemplate`](../../doc/models/nac-portal-template.md) | Body, Optional | - |

## Response Type

`Task`

## Example Usage

```csharp
Guid orgId = new Guid("000000ab-00ab-00ab-00ab-0000000000ab");
Guid nacportalId = new Guid("000000ab-00ab-00ab-00ab-0000000000ab");
NacPortalTemplate body = new NacPortalTemplate
{
    Color = "#1074bc",
    PoweredBy = false,
};

try
{
    await orgsNACPortalsController.UpdateOrgNacPortalTempalteAsync(
        orgId,
        nacportalId,
        body
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Syntax | [`ApiV1OrgsNacportalsPortalTemplate400ErrorException`](../../doc/models/api-v1-orgs-nacportals-portal-template-400-error-exception.md) |
| 401 | Unauthorized | [`ApiV1OrgsNacportalsPortalTemplate401ErrorException`](../../doc/models/api-v1-orgs-nacportals-portal-template-401-error-exception.md) |
| 403 | Permission Denied | [`ApiV1OrgsNacportalsPortalTemplate403ErrorException`](../../doc/models/api-v1-orgs-nacportals-portal-template-403-error-exception.md) |
| 404 | Not found. The API endpoint doesnâ€™t exist or resource doesnâ€™ t exist | [`ResponseHttp404Exception`](../../doc/models/response-http-404-exception.md) |
| 429 | Too Many Request. The API Token used for the request reached the 5000 API Calls per hour threshold | [`ApiV1OrgsNacportalsPortalTemplate429ErrorException`](../../doc/models/api-v1-orgs-nacportals-portal-template-429-error-exception.md) |

