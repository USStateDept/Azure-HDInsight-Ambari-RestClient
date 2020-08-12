# IO.Swagger.Api.UserAuthenticationSourcesApi

All URIs are relative to *https://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAuthenticationSources**](UserAuthenticationSourcesApi.md#createauthenticationsources) | **POST** /users/{userName}/sources | Create one or more new authentication sources for a user
[**DeleteAuthenticationSource**](UserAuthenticationSourcesApi.md#deleteauthenticationsource) | **DELETE** /users/{userName}/sources/{sourceId} | Deletes an existing authentication source
[**GetAuthenticationSource**](UserAuthenticationSourcesApi.md#getauthenticationsource) | **GET** /users/{userName}/sources/{sourceId} | Get user authentication source
[**GetAuthenticationSources**](UserAuthenticationSourcesApi.md#getauthenticationsources) | **GET** /users/{userName}/sources | Get all authentication sources
[**UpdateAuthenticationSource**](UserAuthenticationSourcesApi.md#updateauthenticationsource) | **PUT** /users/{userName}/sources/{sourceId} | Updates an existing authentication source


<a name="createauthenticationsources"></a>
# **CreateAuthenticationSources**
> void CreateAuthenticationSources (string userName, UserAuthenticationSourceRequestCreateSwagger body)

Create one or more new authentication sources for a user



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateAuthenticationSourcesExample
    {
        public void main()
        {
            
            var apiInstance = new UserAuthenticationSourcesApi();
            var userName = userName_example;  // string | user name
            var body = new UserAuthenticationSourceRequestCreateSwagger(); // UserAuthenticationSourceRequestCreateSwagger |  (optional) 

            try
            {
                // Create one or more new authentication sources for a user
                apiInstance.CreateAuthenticationSources(userName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserAuthenticationSourcesApi.CreateAuthenticationSources: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userName** | **string**| user name | 
 **body** | [**UserAuthenticationSourceRequestCreateSwagger**](UserAuthenticationSourceRequestCreateSwagger.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteauthenticationsource"></a>
# **DeleteAuthenticationSource**
> void DeleteAuthenticationSource (string userName, string sourceId)

Deletes an existing authentication source



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteAuthenticationSourceExample
    {
        public void main()
        {
            
            var apiInstance = new UserAuthenticationSourcesApi();
            var userName = userName_example;  // string | user name
            var sourceId = sourceId_example;  // string | source id

            try
            {
                // Deletes an existing authentication source
                apiInstance.DeleteAuthenticationSource(userName, sourceId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserAuthenticationSourcesApi.DeleteAuthenticationSource: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userName** | **string**| user name | 
 **sourceId** | **string**| source id | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthenticationsource"></a>
# **GetAuthenticationSource**
> UserAuthenticationSourceResponseSwagger GetAuthenticationSource (string userName, string sourceId, string fields)

Get user authentication source



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAuthenticationSourceExample
    {
        public void main()
        {
            
            var apiInstance = new UserAuthenticationSourcesApi();
            var userName = userName_example;  // string | user name
            var sourceId = sourceId_example;  // string | source id
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional)  (default to AuthenticationSourceInfo/*)

            try
            {
                // Get user authentication source
                UserAuthenticationSourceResponseSwagger result = apiInstance.GetAuthenticationSource(userName, sourceId, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserAuthenticationSourcesApi.GetAuthenticationSource: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userName** | **string**| user name | 
 **sourceId** | **string**| source id | 
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] [default to AuthenticationSourceInfo/*]

### Return type

[**UserAuthenticationSourceResponseSwagger**](UserAuthenticationSourceResponseSwagger.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthenticationsources"></a>
# **GetAuthenticationSources**
> List<UserAuthenticationSourceResponseSwagger> GetAuthenticationSources (string userName, string fields, string sortBy, int? pageSize, int? from, int? to)

Get all authentication sources



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAuthenticationSourcesExample
    {
        public void main()
        {
            
            var apiInstance = new UserAuthenticationSourcesApi();
            var userName = userName_example;  // string | user name
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional)  (default to AuthenticationSourceInfo/source_id,AuthenticationSourceInfo/user_name)
            var sortBy = sortBy_example;  // string | Sort resources in result by (asc | desc) (optional)  (default to AuthenticationSourceInfo/source_id.asc)
            var pageSize = 56;  // int? | The number of resources to be returned for the paged response. (optional)  (default to 10)
            var from = 56;  // int? | The starting page resource (inclusive).  \"start\" is also accepted. (optional)  (default to 0)
            var to = 56;  // int? | The ending page resource (inclusive).  \"end\" is also accepted. (optional) 

            try
            {
                // Get all authentication sources
                List&lt;UserAuthenticationSourceResponseSwagger&gt; result = apiInstance.GetAuthenticationSources(userName, fields, sortBy, pageSize, from, to);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserAuthenticationSourcesApi.GetAuthenticationSources: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userName** | **string**| user name | 
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] [default to AuthenticationSourceInfo/source_id,AuthenticationSourceInfo/user_name]
 **sortBy** | **string**| Sort resources in result by (asc | desc) | [optional] [default to AuthenticationSourceInfo/source_id.asc]
 **pageSize** | **int?**| The number of resources to be returned for the paged response. | [optional] [default to 10]
 **from** | **int?**| The starting page resource (inclusive).  \&quot;start\&quot; is also accepted. | [optional] [default to 0]
 **to** | **int?**| The ending page resource (inclusive).  \&quot;end\&quot; is also accepted. | [optional] 

### Return type

[**List<UserAuthenticationSourceResponseSwagger>**](UserAuthenticationSourceResponseSwagger.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateauthenticationsource"></a>
# **UpdateAuthenticationSource**
> void UpdateAuthenticationSource (string userName, string sourceId, UserAuthenticationSourceRequestUpdateSwagger body)

Updates an existing authentication source



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateAuthenticationSourceExample
    {
        public void main()
        {
            
            var apiInstance = new UserAuthenticationSourcesApi();
            var userName = userName_example;  // string | user name
            var sourceId = sourceId_example;  // string | source id
            var body = new UserAuthenticationSourceRequestUpdateSwagger(); // UserAuthenticationSourceRequestUpdateSwagger |  (optional) 

            try
            {
                // Updates an existing authentication source
                apiInstance.UpdateAuthenticationSource(userName, sourceId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserAuthenticationSourcesApi.UpdateAuthenticationSource: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userName** | **string**| user name | 
 **sourceId** | **string**| source id | 
 **body** | [**UserAuthenticationSourceRequestUpdateSwagger**](UserAuthenticationSourceRequestUpdateSwagger.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

