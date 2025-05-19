
# Client Class Documentation

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| Timeout | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| HttpClientConfiguration | [`Action<HttpClientConfiguration.Builder>`](../doc/http-client-configuration-builder.md) | Action delegate that configures the HTTP client by using the HttpClientConfiguration.Builder for customizing API call settings.<br>*Default*: `new HttpClient()` |
| LogBuilder | [`LogBuilder`](../doc/log-builder.md) | Represents the logging configuration builder for API calls |
| ApiTokenCredentials | [`ApiTokenCredentials`](auth/custom-header-signature.md) | The Credentials Setter for Custom Header Signature |
| BasicAuthCredentials | [`BasicAuthCredentials`](auth/basic-authentication.md) | The Credentials Setter for Basic Authentication |
| CsrfTokenCredentials | [`CsrfTokenCredentials`](auth/custom-header-signature-1.md) | The Credentials Setter for Custom Header Signature |

The API client can be initialized as follows:

```csharp
MistAPIClient client = new MistAPIClient.Builder()
    .ApiTokenCredentials(
        new ApiTokenModel.Builder(
            "Authorization"
        )
        .Build())
    .BasicAuthCredentials(
        new BasicAuthModel.Builder(
            "Username",
            "Password"
        )
        .Build())
    .CsrfTokenCredentials(
        new CsrfTokenModel.Builder(
            "X-CSRFToken"
        )
        .Build())
    .LoggingConfig(config => config
        .LogLevel(LogLevel.Information)
        .RequestConfig(reqConfig => reqConfig.Body(true))
        .ResponseConfig(respConfig => respConfig.Headers(true))
    )
    .Build();
```

## Mist APIClient Class

The gateway for the SDK. This class acts as a factory for the Controllers and also holds the configuration of the SDK.

### Controllers

| Name | Description |
|  --- | --- |
| OrgsNACTagsController | Gets OrgsNACTagsController controller. |
| OrgsNACPortalsController | Gets OrgsNACPortalsController controller. |

### Properties

| Name | Description | Type |
|  --- | --- | --- |
| HttpClientConfiguration | Gets the configuration of the Http Client associated with this client. | [`IHttpClientConfiguration`](../doc/http-client-configuration.md) |
| Timeout | Http client timeout. | `TimeSpan` |
| Environment | Current API environment. | `Environment` |
| ApiTokenCredentials | Gets the credentials to use with ApiToken. | [`IApiTokenCredentials`](auth/custom-header-signature.md) |
| BasicAuthCredentials | Gets the credentials to use with BasicAuth. | [`IBasicAuthCredentials`](auth/basic-authentication.md) |
| CsrfTokenCredentials | Gets the credentials to use with CsrfToken. | [`ICsrfTokenCredentials`](auth/custom-header-signature-1.md) |

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `GetBaseUri(Server alias = Server.Default)` | Gets the URL for a particular alias in the current environment and appends it with template parameters. | `string` |
| `ToBuilder()` | Creates an object of the Mist APIClient using the values provided for the builder. | `Builder` |

## Mist APIClient Builder Class

Class to build instances of Mist APIClient.

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `HttpClientConfiguration(Action<`[`HttpClientConfiguration.Builder`](../doc/http-client-configuration-builder.md)`> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `ApiTokenCredentials(Action<ApiTokenModel.Builder> action)` | Sets credentials for ApiToken. | `Builder` |
| `BasicAuthCredentials(Action<BasicAuthModel.Builder> action)` | Sets credentials for BasicAuth. | `Builder` |
| `CsrfTokenCredentials(Action<CsrfTokenModel.Builder> action)` | Sets credentials for CsrfToken. | `Builder` |

