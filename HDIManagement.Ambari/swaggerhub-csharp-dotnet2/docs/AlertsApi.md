# IO.Swagger.Api.AlertsApi

All URIs are relative to *https://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateTarget**](AlertsApi.md#createtarget) | **POST** /alert_targets | Creates an alert target
[**DeleteTarget**](AlertsApi.md#deletetarget) | **DELETE** /alert_targets/{targetId} | Deletes an alert target
[**GetTarget**](AlertsApi.md#gettarget) | **GET** /alert_targets/{targetId} | Returns a single alert target
[**GetTargets**](AlertsApi.md#gettargets) | **GET** /alert_targets | Returns all alert targets
[**UpdateTarget**](AlertsApi.md#updatetarget) | **PUT** /alert_targets/{targetId} | Updates an alert target


<a name="createtarget"></a>
# **CreateTarget**
> void CreateTarget (AlertTargetSwagger body, string validateConfig, string overwriteExisting)

Creates an alert target



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateTargetExample
    {
        public void main()
        {
            
            var apiInstance = new AlertsApi();
            var body = new AlertTargetSwagger(); // AlertTargetSwagger |  (optional) 
            var validateConfig = validateConfig_example;  // string |  (optional) 
            var overwriteExisting = overwriteExisting_example;  // string |  (optional) 

            try
            {
                // Creates an alert target
                apiInstance.CreateTarget(body, validateConfig, overwriteExisting);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.CreateTarget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AlertTargetSwagger**](AlertTargetSwagger.md)|  | [optional] 
 **validateConfig** | **string**|  | [optional] 
 **overwriteExisting** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetarget"></a>
# **DeleteTarget**
> void DeleteTarget (long? targetId)

Deletes an alert target



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteTargetExample
    {
        public void main()
        {
            
            var apiInstance = new AlertsApi();
            var targetId = 789;  // long? | 

            try
            {
                // Deletes an alert target
                apiInstance.DeleteTarget(targetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.DeleteTarget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **targetId** | **long?**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettarget"></a>
# **GetTarget**
> AlertTargetSwagger GetTarget (long? targetId, string fields, string sortBy, int? pageSize, int? from, int? to)

Returns a single alert target



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTargetExample
    {
        public void main()
        {
            
            var apiInstance = new AlertsApi();
            var targetId = 789;  // long? | alert target id
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional)  (default to AlertTarget/*)
            var sortBy = sortBy_example;  // string | Sort resources in result by (asc | desc) (optional) 
            var pageSize = 56;  // int? | The number of resources to be returned for the paged response. (optional)  (default to 10)
            var from = 56;  // int? | The starting page resource (inclusive).  \"start\" is also accepted. (optional)  (default to 0)
            var to = 56;  // int? | The ending page resource (inclusive).  \"end\" is also accepted. (optional) 

            try
            {
                // Returns a single alert target
                AlertTargetSwagger result = apiInstance.GetTarget(targetId, fields, sortBy, pageSize, from, to);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.GetTarget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **targetId** | **long?**| alert target id | 
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] [default to AlertTarget/*]
 **sortBy** | **string**| Sort resources in result by (asc | desc) | [optional] 
 **pageSize** | **int?**| The number of resources to be returned for the paged response. | [optional] [default to 10]
 **from** | **int?**| The starting page resource (inclusive).  \&quot;start\&quot; is also accepted. | [optional] [default to 0]
 **to** | **int?**| The ending page resource (inclusive).  \&quot;end\&quot; is also accepted. | [optional] 

### Return type

[**AlertTargetSwagger**](AlertTargetSwagger.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettargets"></a>
# **GetTargets**
> List<AlertTargetSwagger> GetTargets (string fields, string sortBy, int? pageSize, int? from, int? to)

Returns all alert targets



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTargetsExample
    {
        public void main()
        {
            
            var apiInstance = new AlertsApi();
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional)  (default to AlertTarget/*)
            var sortBy = sortBy_example;  // string | Sort resources in result by (asc | desc) (optional) 
            var pageSize = 56;  // int? | The number of resources to be returned for the paged response. (optional)  (default to 10)
            var from = 56;  // int? | The starting page resource (inclusive).  \"start\" is also accepted. (optional)  (default to 0)
            var to = 56;  // int? | The ending page resource (inclusive).  \"end\" is also accepted. (optional) 

            try
            {
                // Returns all alert targets
                List&lt;AlertTargetSwagger&gt; result = apiInstance.GetTargets(fields, sortBy, pageSize, from, to);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.GetTargets: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] [default to AlertTarget/*]
 **sortBy** | **string**| Sort resources in result by (asc | desc) | [optional] 
 **pageSize** | **int?**| The number of resources to be returned for the paged response. | [optional] [default to 10]
 **from** | **int?**| The starting page resource (inclusive).  \&quot;start\&quot; is also accepted. | [optional] [default to 0]
 **to** | **int?**| The ending page resource (inclusive).  \&quot;end\&quot; is also accepted. | [optional] 

### Return type

[**List<AlertTargetSwagger>**](AlertTargetSwagger.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetarget"></a>
# **UpdateTarget**
> void UpdateTarget (long? targetId, AlertTargetSwagger body)

Updates an alert target



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateTargetExample
    {
        public void main()
        {
            
            var apiInstance = new AlertsApi();
            var targetId = 789;  // long? | 
            var body = new AlertTargetSwagger(); // AlertTargetSwagger |  (optional) 

            try
            {
                // Updates an alert target
                apiInstance.UpdateTarget(targetId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.UpdateTarget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **targetId** | **long?**|  | 
 **body** | [**AlertTargetSwagger**](AlertTargetSwagger.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

