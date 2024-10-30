# Orgs NAC Tags

```csharp
OrgsNACTagsController orgsNACTagsController = client.OrgsNACTagsController;
```

## Class Name

`OrgsNACTagsController`

## Methods

* [List Org Nac Tags](../../doc/controllers/orgs-nac-tags.md#list-org-nac-tags)
* [Create Org Nac Tag](../../doc/controllers/orgs-nac-tags.md#create-org-nac-tag)
* [Delete Org Nac Tag](../../doc/controllers/orgs-nac-tags.md#delete-org-nac-tag)
* [Get Org Nac Tag](../../doc/controllers/orgs-nac-tags.md#get-org-nac-tag)
* [Update Org Nac Tag](../../doc/controllers/orgs-nac-tags.md#update-org-nac-tag)


# List Org Nac Tags

Get List of Org NAC Tags

```csharp
ListOrgNacTagsAsync(
    Guid orgId,
    string type = null,
    string name = null,
    string match = null,
    int? page = 1,
    int? limit = 100)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `orgId` | `Guid` | Template, Required | - |
| `type` | `string` | Query, Optional | Type of NAC Tag |
| `name` | `string` | Query, Optional | Name of NAC Tag |
| `match` | `string` | Query, Optional | Type of NAC Tag |
| `page` | `int?` | Query, Optional | **Default**: `1`<br>**Constraints**: `>= 1` |
| `limit` | `int?` | Query, Optional | **Default**: `100`<br>**Constraints**: `>= 0` |

## Response Type

[`Task<ApiResponse<List<Models.NacTag>>>`](../../doc/models/nac-tag.md)

## Example Usage

```csharp
Guid orgId = new Guid("000000ab-00ab-00ab-00ab-0000000000ab");
int? page = 1;
int? limit = 100;
try
{
    ApiResponse<List<NacTag>> result = await orgsNACTagsController.ListOrgNacTagsAsync(
        orgId,
        null,
        null,
        null,
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

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Syntax | [`ApiV1OrgsNactags400ErrorException`](../../doc/models/api-v1-orgs-nactags-400-error-exception.md) |
| 401 | Unauthorized | [`ApiV1OrgsNactags401ErrorException`](../../doc/models/api-v1-orgs-nactags-401-error-exception.md) |
| 403 | Permission Denied | [`ApiV1OrgsNactags403ErrorException`](../../doc/models/api-v1-orgs-nactags-403-error-exception.md) |
| 404 | Not found. The API endpoint doesnâ€™t exist or resource doesnâ€™ t exist | [`ResponseHttp404Exception`](../../doc/models/response-http-404-exception.md) |
| 429 | Too Many Request. The API Token used for the request reached the 5000 API Calls per hour threshold | [`ApiV1OrgsNactags429ErrorException`](../../doc/models/api-v1-orgs-nactags-429-error-exception.md) |


# Create Org Nac Tag

Create Org NAC Tag

```csharp
CreateOrgNacTagAsync(
    Guid orgId,
    Models.NacTag body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `orgId` | `Guid` | Template, Required | - |
| `body` | [`NacTag`](../../doc/models/nac-tag.md) | Body, Optional | - |

## Response Type

[`Task<ApiResponse<Models.NacTag>>`](../../doc/models/nac-tag.md)

## Example Usage

```csharp
Guid orgId = new Guid("000000ab-00ab-00ab-00ab-0000000000ab");
NacTag body = new NacTag
{
    Name = "name6",
    Type = NacTagType.UsernameAttr,
    AllowUsermacOverride = false,
    EgressVlanNames = new List<string>
    {
        "1vlan-30",
        "1vlan-20",
        "2-vlan10",
    },
    MatchAll = false,
    RadiusAttrs = new List<string>
    {
        "Idle-Timeout=600",
        "Termination-Action=RADIUS-Request",
    },
    RadiusVendorAttrs = new List<string>
    {
        "PaloAlto-Admin-Role=superuser",
        "PaloAlto-Panorama-Admin-Role=administrator",
    },
    SessionTimeout = 86000,
};

try
{
    ApiResponse<NacTag> result = await orgsNACTagsController.CreateOrgNacTagAsync(
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
  "match": "client_mac",
  "name": "cameras",
  "type": "match",
  "values": [
    "010203040506",
    "abcdef*"
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Syntax | [`ApiV1OrgsNactags400ErrorException`](../../doc/models/api-v1-orgs-nactags-400-error-exception.md) |
| 401 | Unauthorized | [`ApiV1OrgsNactags401ErrorException`](../../doc/models/api-v1-orgs-nactags-401-error-exception.md) |
| 403 | Permission Denied | [`ApiV1OrgsNactags403ErrorException`](../../doc/models/api-v1-orgs-nactags-403-error-exception.md) |
| 404 | Not found. The API endpoint doesnâ€™t exist or resource doesnâ€™ t exist | [`ResponseHttp404Exception`](../../doc/models/response-http-404-exception.md) |
| 429 | Too Many Request. The API Token used for the request reached the 5000 API Calls per hour threshold | [`ApiV1OrgsNactags429ErrorException`](../../doc/models/api-v1-orgs-nactags-429-error-exception.md) |


# Delete Org Nac Tag

Delete Org NAC Tag

```csharp
DeleteOrgNacTagAsync(
    Guid orgId,
    Guid nactagId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `orgId` | `Guid` | Template, Required | - |
| `nactagId` | `Guid` | Template, Required | - |

## Response Type

`Task`

## Example Usage

```csharp
Guid orgId = new Guid("000000ab-00ab-00ab-00ab-0000000000ab");
Guid nactagId = new Guid("000000ab-00ab-00ab-00ab-0000000000ab");
try
{
    await orgsNACTagsController.DeleteOrgNacTagAsync(
        orgId,
        nactagId
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
| 400 | Bad Syntax | [`ApiV1OrgsNactags400ErrorException`](../../doc/models/api-v1-orgs-nactags-400-error-exception.md) |
| 401 | Unauthorized | [`ApiV1OrgsNactags401ErrorException`](../../doc/models/api-v1-orgs-nactags-401-error-exception.md) |
| 403 | Permission Denied | [`ApiV1OrgsNactags403ErrorException`](../../doc/models/api-v1-orgs-nactags-403-error-exception.md) |
| 404 | Not found. The API endpoint doesnâ€™t exist or resource doesnâ€™ t exist | [`ResponseHttp404Exception`](../../doc/models/response-http-404-exception.md) |
| 429 | Too Many Request. The API Token used for the request reached the 5000 API Calls per hour threshold | [`ApiV1OrgsNactags429ErrorException`](../../doc/models/api-v1-orgs-nactags-429-error-exception.md) |


# Get Org Nac Tag

Get Org NAC Tag

```csharp
GetOrgNacTagAsync(
    Guid orgId,
    Guid nactagId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `orgId` | `Guid` | Template, Required | - |
| `nactagId` | `Guid` | Template, Required | - |

## Response Type

[`Task<ApiResponse<Models.NacTag>>`](../../doc/models/nac-tag.md)

## Example Usage

```csharp
Guid orgId = new Guid("000000ab-00ab-00ab-00ab-0000000000ab");
Guid nactagId = new Guid("000000ab-00ab-00ab-00ab-0000000000ab");
try
{
    ApiResponse<NacTag> result = await orgsNACTagsController.GetOrgNacTagAsync(
        orgId,
        nactagId
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
  "match": "client_mac",
  "name": "cameras",
  "type": "match",
  "values": [
    "010203040506",
    "abcdef*"
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Syntax | [`ApiV1OrgsNactags400ErrorException`](../../doc/models/api-v1-orgs-nactags-400-error-exception.md) |
| 401 | Unauthorized | [`ApiV1OrgsNactags401ErrorException`](../../doc/models/api-v1-orgs-nactags-401-error-exception.md) |
| 403 | Permission Denied | [`ApiV1OrgsNactags403ErrorException`](../../doc/models/api-v1-orgs-nactags-403-error-exception.md) |
| 404 | Not found. The API endpoint doesnâ€™t exist or resource doesnâ€™ t exist | [`ResponseHttp404Exception`](../../doc/models/response-http-404-exception.md) |
| 429 | Too Many Request. The API Token used for the request reached the 5000 API Calls per hour threshold | [`ApiV1OrgsNactags429ErrorException`](../../doc/models/api-v1-orgs-nactags-429-error-exception.md) |


# Update Org Nac Tag

Update Org NAC Tag

```csharp
UpdateOrgNacTagAsync(
    Guid orgId,
    Guid nactagId,
    Models.NacTag body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `orgId` | `Guid` | Template, Required | - |
| `nactagId` | `Guid` | Template, Required | - |
| `body` | [`NacTag`](../../doc/models/nac-tag.md) | Body, Optional | - |

## Response Type

[`Task<ApiResponse<Models.NacTag>>`](../../doc/models/nac-tag.md)

## Example Usage

```csharp
Guid orgId = new Guid("000000ab-00ab-00ab-00ab-0000000000ab");
Guid nactagId = new Guid("000000ab-00ab-00ab-00ab-0000000000ab");
NacTag body = new NacTag
{
    Name = "name6",
    Type = NacTagType.UsernameAttr,
    AllowUsermacOverride = false,
    EgressVlanNames = new List<string>
    {
        "1vlan-30",
        "1vlan-20",
        "2-vlan10",
    },
    MatchAll = false,
    RadiusAttrs = new List<string>
    {
        "Idle-Timeout=600",
        "Termination-Action=RADIUS-Request",
    },
    RadiusVendorAttrs = new List<string>
    {
        "PaloAlto-Admin-Role=superuser",
        "PaloAlto-Panorama-Admin-Role=administrator",
    },
    SessionTimeout = 86000,
};

try
{
    ApiResponse<NacTag> result = await orgsNACTagsController.UpdateOrgNacTagAsync(
        orgId,
        nactagId,
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
  "match": "client_mac",
  "name": "cameras",
  "type": "match",
  "values": [
    "010203040506",
    "abcdef*"
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Syntax | [`ApiV1OrgsNactags400ErrorException`](../../doc/models/api-v1-orgs-nactags-400-error-exception.md) |
| 401 | Unauthorized | [`ApiV1OrgsNactags401ErrorException`](../../doc/models/api-v1-orgs-nactags-401-error-exception.md) |
| 403 | Permission Denied | [`ApiV1OrgsNactags403ErrorException`](../../doc/models/api-v1-orgs-nactags-403-error-exception.md) |
| 404 | Not found. The API endpoint doesnâ€™t exist or resource doesnâ€™ t exist | [`ResponseHttp404Exception`](../../doc/models/response-http-404-exception.md) |
| 429 | Too Many Request. The API Token used for the request reached the 5000 API Calls per hour threshold | [`ApiV1OrgsNactags429ErrorException`](../../doc/models/api-v1-orgs-nactags-429-error-exception.md) |

