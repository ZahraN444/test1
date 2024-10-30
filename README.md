
# Getting Started with Mist API

## Introduction

> Version: **2408.1.0**
> 
> Date: **August 1, 2024**

---


### Additional Documentation

* [Mist Automation Guide](https://www.juniper.net/documentation/us/en/software/mist/automation-integration/index.html)
* [Mist Location SDK](https://www.juniper.net/documentation/us/en/software/mist/location_services/topics/concept/mist-how-get-mist-sdk.html)
* [Mist Product Updates](https://www.mist.com/documentation/category/product-updates/)

---


### Helpful Resources

* [API Sandbox and Exercises](https://api-class.mist.com/)
* [Postman Collection, Runners and Webhook Samples](https://www.postman.com/juniper-mist/workspace/mist-systems-s-public-workspace)
* [API Demo Apps](https://apps.mist-lab.fr/)
* [Juniper Blog](https://blogs.juniper.net/)

---


## Install the Package

If you are building with .NET CLI tools then you can also use the following command:

```bash
dotnet add package testpackage.rd --version 1.2.3
```

You can also view the package at:
https://www.nuget.org/packages/testpackage.rd/1.2.3

## Test the SDK

The generated SDK also contain one or more Tests, which are contained in the Tests project. In order to invoke these test cases, you will need `NUnit 3.0 Test Adapter Extension` for Visual Studio. Once the SDK is complied, the test cases should appear in the Test Explorer window. Here, you can click `Run All` to execute these test cases.

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](https://www.github.com/ZahraN444/test1/tree/1.2.3/doc/client.md)

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| `LogBuilder` | [`LogBuilder`](https://www.github.com/ZahraN444/test1/tree/1.2.3/doc/log-builder.md) | Represents the logging configuration builder for API calls |
| `ApiTokenCredentials` | [`ApiTokenCredentials`](https://www.github.com/ZahraN444/test1/tree/1.2.3/doc/auth/custom-header-signature.md) | The Credentials Setter for Custom Header Signature |
| `BasicAuthCredentials` | [`BasicAuthCredentials`](https://www.github.com/ZahraN444/test1/tree/1.2.3/doc/auth/basic-authentication.md) | The Credentials Setter for Basic Authentication |
| `CsrfTokenCredentials` | [`CsrfTokenCredentials`](https://www.github.com/ZahraN444/test1/tree/1.2.3/doc/auth/custom-header-signature-1.md) | The Credentials Setter for Custom Header Signature |

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

API calls return an `ApiResponse` object that includes the following fields:

| Field | Description |
|  --- | --- |
| `StatusCode` | Status code of the HTTP response |
| `Headers` | Headers of the HTTP response as a Hash |
| `Data` | The deserialized body of the HTTP response as a String |

## Authorization

This API uses the following authentication schemes.

* [`apiToken (Custom Header Signature)`](https://www.github.com/ZahraN444/test1/tree/1.2.3/doc/auth/custom-header-signature.md)
* [`basicAuth (Basic Authentication)`](https://www.github.com/ZahraN444/test1/tree/1.2.3/doc/auth/basic-authentication.md)
* [`csrfToken (Custom Header Signature)`](https://www.github.com/ZahraN444/test1/tree/1.2.3/doc/auth/custom-header-signature-1.md)

## List of APIs

* [Orgs NAC Tags](https://www.github.com/ZahraN444/test1/tree/1.2.3/doc/controllers/orgs-nac-tags.md)
* [Orgs NAC Portals](https://www.github.com/ZahraN444/test1/tree/1.2.3/doc/controllers/orgs-nac-portals.md)

## Classes Documentation

* [Utility Classes](https://www.github.com/ZahraN444/test1/tree/1.2.3/doc/utility-classes.md)
* [HttpRequest](https://www.github.com/ZahraN444/test1/tree/1.2.3/doc/http-request.md)
* [HttpResponse](https://www.github.com/ZahraN444/test1/tree/1.2.3/doc/http-response.md)
* [HttpStringResponse](https://www.github.com/ZahraN444/test1/tree/1.2.3/doc/http-string-response.md)
* [HttpContext](https://www.github.com/ZahraN444/test1/tree/1.2.3/doc/http-context.md)
* [HttpClientConfiguration](https://www.github.com/ZahraN444/test1/tree/1.2.3/doc/http-client-configuration.md)
* [HttpClientConfiguration Builder](https://www.github.com/ZahraN444/test1/tree/1.2.3/doc/http-client-configuration-builder.md)
* [IAuthManager](https://www.github.com/ZahraN444/test1/tree/1.2.3/doc/i-auth-manager.md)
* [ApiException](https://www.github.com/ZahraN444/test1/tree/1.2.3/doc/api-exception.md)
* [LogBuilder](https://www.github.com/ZahraN444/test1/tree/1.2.3/doc/log-builder.md)
* [LogRequestBuilder](https://www.github.com/ZahraN444/test1/tree/1.2.3/doc/log-request-builder.md)
* [LogResponseBuilder](https://www.github.com/ZahraN444/test1/tree/1.2.3/doc/log-response-builder.md)

