# IO.Swagger.Api.ConfigGroupsApi

All URIs are relative to *https://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateConfigGroup**](ConfigGroupsApi.md#createconfiggroup) | **POST** /clusters/{clusterName}/config_groups | Creates a config group
[**DeleteConfigGroup**](ConfigGroupsApi.md#deleteconfiggroup) | **DELETE** /clusters/{clusterName}/config_groups/{groupId} | Deletes a config group
[**GetConfigGroup**](ConfigGroupsApi.md#getconfiggroup) | **GET** /clusters/{clusterName}/config_groups/{groupId} | Returns a single config group
[**GetConfigGroups**](ConfigGroupsApi.md#getconfiggroups) | **GET** /clusters/{clusterName}/config_groups | Returns all config groups
[**UpdateConfigGroup**](ConfigGroupsApi.md#updateconfiggroup) | **PUT** /clusters/{clusterName}/config_groups/{groupId} | Updates a config group


<a name="createconfiggroup"></a>
# **CreateConfigGroup**
> void CreateConfigGroup (string clusterName, ConfigGroupRequest body)

Creates a config group



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateConfigGroupExample
    {
        public void main()
        {
            
            var apiInstance = new ConfigGroupsApi();
            var clusterName = clusterName_example;  // string | 
            var body = new ConfigGroupRequest(); // ConfigGroupRequest |  (optional) 

            try
            {
                // Creates a config group
                apiInstance.CreateConfigGroup(clusterName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigGroupsApi.CreateConfigGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clusterName** | **string**|  | 
 **body** | [**ConfigGroupRequest**](ConfigGroupRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteconfiggroup"></a>
# **DeleteConfigGroup**
> void DeleteConfigGroup (string groupId, string clusterName)

Deletes a config group



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteConfigGroupExample
    {
        public void main()
        {
            
            var apiInstance = new ConfigGroupsApi();
            var groupId = groupId_example;  // string | 
            var clusterName = clusterName_example;  // string | 

            try
            {
                // Deletes a config group
                apiInstance.DeleteConfigGroup(groupId, clusterName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigGroupsApi.DeleteConfigGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **string**|  | 
 **clusterName** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconfiggroup"></a>
# **GetConfigGroup**
> ConfigGroupWrapper GetConfigGroup (string groupId, string clusterName, string fields)

Returns a single config group



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetConfigGroupExample
    {
        public void main()
        {
            
            var apiInstance = new ConfigGroupsApi();
            var groupId = groupId_example;  // string | 
            var clusterName = clusterName_example;  // string | 
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional)  (default to ConfigGroup/*)

            try
            {
                // Returns a single config group
                ConfigGroupWrapper result = apiInstance.GetConfigGroup(groupId, clusterName, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigGroupsApi.GetConfigGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **string**|  | 
 **clusterName** | **string**|  | 
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] [default to ConfigGroup/*]

### Return type

[**ConfigGroupWrapper**](ConfigGroupWrapper.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconfiggroups"></a>
# **GetConfigGroups**
> List<ConfigGroupWrapper> GetConfigGroups (string clusterName, string fields, string sortBy, int? pageSize, int? from, int? to)

Returns all config groups



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetConfigGroupsExample
    {
        public void main()
        {
            
            var apiInstance = new ConfigGroupsApi();
            var clusterName = clusterName_example;  // string | 
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional)  (default to ConfigGroup/*)
            var sortBy = sortBy_example;  // string | Sort resources in result by (asc | desc) (optional) 
            var pageSize = 56;  // int? | The number of resources to be returned for the paged response. (optional)  (default to 10)
            var from = 56;  // int? | The starting page resource (inclusive).  \"start\" is also accepted. (optional)  (default to 0)
            var to = 56;  // int? | The ending page resource (inclusive).  \"end\" is also accepted. (optional) 

            try
            {
                // Returns all config groups
                List&lt;ConfigGroupWrapper&gt; result = apiInstance.GetConfigGroups(clusterName, fields, sortBy, pageSize, from, to);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigGroupsApi.GetConfigGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clusterName** | **string**|  | 
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] [default to ConfigGroup/*]
 **sortBy** | **string**| Sort resources in result by (asc | desc) | [optional] 
 **pageSize** | **int?**| The number of resources to be returned for the paged response. | [optional] [default to 10]
 **from** | **int?**| The starting page resource (inclusive).  \&quot;start\&quot; is also accepted. | [optional] [default to 0]
 **to** | **int?**| The ending page resource (inclusive).  \&quot;end\&quot; is also accepted. | [optional] 

### Return type

[**List<ConfigGroupWrapper>**](ConfigGroupWrapper.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateconfiggroup"></a>
# **UpdateConfigGroup**
> void UpdateConfigGroup (string groupId, string clusterName, ConfigGroupRequest body)

Updates a config group



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateConfigGroupExample
    {
        public void main()
        {
            
            var apiInstance = new ConfigGroupsApi();
            var groupId = groupId_example;  // string | 
            var clusterName = clusterName_example;  // string | 
            var body = new ConfigGroupRequest(); // ConfigGroupRequest |  (optional) 

            try
            {
                // Updates a config group
                apiInstance.UpdateConfigGroup(groupId, clusterName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigGroupsApi.UpdateConfigGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **string**|  | 
 **clusterName** | **string**|  | 
 **body** | [**ConfigGroupRequest**](ConfigGroupRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

