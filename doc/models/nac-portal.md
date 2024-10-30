
# Nac Portal

## Structure

`NacPortal`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccessType` | [`NacPortalAccessTypeEnum?`](../../doc/models/nac-portal-access-type-enum.md) | Optional | - |
| `BgImageUrl` | `string` | Optional | background image |
| `CertExpireTime` | `int?` | Optional | in days |
| `EnableTelemetry` | `bool?` | Optional | model, version, fingering, events (connecting, disconnect, roaming), which ap |
| `ExpiryNotificationTime` | `int?` | Optional | in days |
| `GuestPortalConfig` | [`NacPortalSso`](../../doc/models/nac-portal-sso.md) | Optional | - |
| `Name` | `string` | Optional | - |
| `NotifyExpiry` | `bool?` | Optional | phase 2 |
| `Ssid` | `string` | Optional | - |
| `Sso` | [`NacPortalSso`](../../doc/models/nac-portal-sso.md) | Optional | - |
| `TemplateUrl` | `string` | Optional | - |
| `ThumbnailUrl` | `string` | Optional | - |
| `Tos` | `string` | Optional | - |
| `Type` | [`NacPortalTypeEnum?`](../../doc/models/nac-portal-type-enum.md) | Optional | - |

## Example (as JSON)

```json
{
  "cert_expire_time": 365,
  "name": "get-wifi",
  "ssid": "Corp",
  "access_type": "wireless",
  "bg_image_url": "bg_image_url2",
  "enable_telemetry": false,
  "expiry_notification_time": 2
}
```

