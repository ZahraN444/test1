
# Nac Rule Matching

## Structure

`NacRuleMatching`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AuthType` | [`NacRuleMatchingAuthType?`](../../doc/models/nac-rule-matching-auth-type.md) | Optional | - |
| `Nactags` | `List<string>` | Optional | - |
| `PortTypes` | [`List<NacRuleMatchingPortType>`](../../doc/models/nac-rule-matching-port-type.md) | Optional | - |
| `SiteIds` | `List<Guid>` | Optional | list of site ids to match |
| `SitegroupIds` | `List<Guid>` | Optional | list of sitegroup ids to match |
| `Vendor` | `List<string>` | Optional | list of vendors to match |

## Example (as JSON)

```json
{
  "nactags": [
    "041d5d36-716c-4cfb-4988-3857c6aa14a2",
    "a809a97f-d599-f812-eb8c-c3f84aabf6ba"
  ],
  "port_types": [
    "wired"
  ],
  "site_ids": [
    "bb19fc3e-4124-4b57-80d9-c3f6edce47c4",
    "bb19fc3e-6564-4b57-80d9-c3f6edce47c1"
  ],
  "sitegroup_ids": [
    "bb19fc3e-4124-4b57-80d9-c3f6edce47c4",
    "bb19fc3e-6564-4b57-80d9-c3f6edce47c1"
  ],
  "auth_type": "idp"
}
```

