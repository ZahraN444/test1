
# Nac Portal Template Model

## Structure

`NacPortalTemplateModel`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Alignment` | [`Alignment?`](../../doc/models/alignment.md) | Optional | - |
| `Color` | `string` | Optional | **Default**: `"#1074bc"` |
| `Logo` | `string` | Optional | custom logo custom logo with â€œdata:image/png;base64,â€ format. default null, uses Juniper Mist Logo. |
| `PoweredBy` | `bool?` | Optional | whether to hide â€œPowered by Juniper Mistâ€ and email footers<br><br>**Default**: `false` |

## Example (as JSON)

```json
{
  "color": "#1074bc",
  "poweredBy": false,
  "alignment": "marvis_client",
  "logo": "logo6"
}
```

