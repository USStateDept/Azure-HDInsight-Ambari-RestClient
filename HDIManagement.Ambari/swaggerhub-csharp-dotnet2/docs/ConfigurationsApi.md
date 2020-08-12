# IO.Swagger.Api.ConfigurationsApi

All URIs are relative to *https://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateConfigurations**](ConfigurationsApi.md#createconfigurations) | **POST** /clusters/{clusterName}/configurations | Create new configurations
[**GetConfigurations**](ConfigurationsApi.md#getconfigurations) | **GET** /clusters/{clusterName}/configurations | Get all configurations
[**GetServiceConfigVersions**](ConfigurationsApi.md#getserviceconfigversions) | **GET** /clusters/{clusterName}/configurations/service_config_versions | Get all service config versions


<a name="createconfigurations"></a>
# **CreateConfigurations**
> void CreateConfigurations (string clusterName, ConfigurationRequest body)

Create new configurations



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateConfigurationsExample
    {
        public void main()
        {
            
            var apiInstance = new ConfigurationsApi();
            var clusterName = clusterName_example;  // string | 
            var body = new ConfigurationRequest(); // ConfigurationRequest |  (optional) 

            try
            {
                // Create new configurations
                apiInstance.CreateConfigurations(clusterName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationsApi.CreateConfigurations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clusterName** | **string**|  | 
 **body** | [**ConfigurationRequest**](ConfigurationRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconfigurations"></a>
# **GetConfigurations**
> List<ConfigurationResponse> GetConfigurations (string clusterName, string fields, string sortBy, int? pageSize, int? from, int? to)

Get all configurations



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetConfigurationsExample
    {
        public void main()
        {
            
            var apiInstance = new ConfigurationsApi();
            var clusterName = clusterName_example;  // string | 
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional) 
            var sortBy = sortBy_example;  // string | Sort resources in result by (asc | desc) (optional) 
            var pageSize = 56;  // int? | The number of resources to be returned for the paged response. (optional)  (default to 10)
            var from = 56;  // int? | The starting page resource (inclusive).  \"start\" is also accepted. (optional)  (default to 0)
            var to = 56;  // int? | The ending page resource (inclusive).  \"end\" is also accepted. (optional) 

            try
            {
                // Get all configurations
                List&lt;ConfigurationResponse&gt; result = apiInstance.GetConfigurations(clusterName, fields, sortBy, pageSize, from, to);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationsApi.GetConfigurations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clusterName** | **string**|  | 
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] 
 **sortBy** | **string**| Sort resources in result by (asc | desc) | [optional] 
 **pageSize** | **int?**| The number of resources to be returned for the paged response. | [optional] [default to 10]
 **from** | **int?**| The starting page resource (inclusive).  \&quot;start\&quot; is also accepted. | [optional] [default to 0]
 **to** | **int?**| The ending page resource (inclusive).  \&quot;end\&quot; is also accepted. | [optional] 

### Return type

[**List<ConfigurationResponse>**](ConfigurationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getserviceconfigversions"></a>
# **GetServiceConfigVersions**
> List<ServiceConfigVersionResponse> GetServiceConfigVersions (string clusterName, string fields, string sortBy, int? pageSize, int? from, int? to)

Get all service config versions



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetServiceConfigVersionsExample
    {
        public void main()
        {
            
            var apiInstance = new ConfigurationsApi();
            var clusterName = clusterName_example;  // string | 
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional) 
            var sortBy = sortBy_example;  // string | Sort resources in result by (asc | desc) (optional) 
            var pageSize = 56;  // int? | The number of resources to be returned for the paged response. (optional)  (default to 10)
            var from = 56;  // int? | The starting page resource (inclusive).  \"start\" is also accepted. (optional)  (default to 0)
            var to = 56;  // int? | The ending page resource (inclusive).  \"end\" is also accepted. (optional) 

            try
            {
                // Get all service config versions
                List&lt;ServiceConfigVersionResponse&gt; result = apiInstance.GetServiceConfigVersions(clusterName, fields, sortBy, pageSize, from, to);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationsApi.GetServiceConfigVersions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clusterName** | **string**|  | 
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] 
 **sortBy** | **string**| Sort resources in result by (asc | desc) | [optional] 
 **pageSize** | **int?**| The number of resources to be returned for the paged response. | [optional] [default to 10]
 **from** | **int?**| The starting page resource (inclusive).  \&quot;start\&quot; is also accepted. | [optional] [default to 0]
 **to** | **int?**| The ending page resource (inclusive).  \&quot;end\&quot; is also accepted. | [optional] 

### Return type

[**List<ServiceConfigVersionResponse>**](ServiceConfigVersionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

