# IO.Swagger.Api.HostComponentsApi

All URIs are relative to *https://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateHostComponent**](HostComponentsApi.md#createhostcomponent) | **POST** /clusters/{clusterName}/host_components/{hostComponentName} | Create new host component
[**DeleteHostComponent**](HostComponentsApi.md#deletehostcomponent) | **DELETE** /clusters/{clusterName}/host_components/{hostComponentName} | Delete host component
[**DeleteHostComponents**](HostComponentsApi.md#deletehostcomponents) | **DELETE** /clusters/{clusterName}/host_components | Delete host components
[**GetHostComponent**](HostComponentsApi.md#gethostcomponent) | **GET** /clusters/{clusterName}/host_components/{hostComponentName} | Get single host component for a host
[**GetHostComponents**](HostComponentsApi.md#gethostcomponents) | **GET** /clusters/{clusterName}/host_components | Get all host components for a host
[**GetProcesses**](HostComponentsApi.md#getprocesses) | **GET** /clusters/{clusterName}/host_components/{hostComponentName}/processes | Get processes of a specific host component
[**UpdateHostComponent**](HostComponentsApi.md#updatehostcomponent) | **PUT** /clusters/{clusterName}/host_components/{hostComponentName} | Update host component detail


<a name="createhostcomponent"></a>
# **CreateHostComponent**
> void CreateHostComponent (string hostComponentName, string clusterName, ServiceComponentHostResponse body)

Create new host component



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateHostComponentExample
    {
        public void main()
        {
            
            var apiInstance = new HostComponentsApi();
            var hostComponentName = hostComponentName_example;  // string | 
            var clusterName = clusterName_example;  // string | 
            var body = new ServiceComponentHostResponse(); // ServiceComponentHostResponse |  (optional) 

            try
            {
                // Create new host component
                apiInstance.CreateHostComponent(hostComponentName, clusterName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HostComponentsApi.CreateHostComponent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **hostComponentName** | **string**|  | 
 **clusterName** | **string**|  | 
 **body** | [**ServiceComponentHostResponse**](ServiceComponentHostResponse.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletehostcomponent"></a>
# **DeleteHostComponent**
> void DeleteHostComponent (string hostComponentName, string clusterName)

Delete host component



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteHostComponentExample
    {
        public void main()
        {
            
            var apiInstance = new HostComponentsApi();
            var hostComponentName = hostComponentName_example;  // string | 
            var clusterName = clusterName_example;  // string | 

            try
            {
                // Delete host component
                apiInstance.DeleteHostComponent(hostComponentName, clusterName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HostComponentsApi.DeleteHostComponent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **hostComponentName** | **string**|  | 
 **clusterName** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletehostcomponents"></a>
# **DeleteHostComponents**
> void DeleteHostComponents (string clusterName)

Delete host components



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteHostComponentsExample
    {
        public void main()
        {
            
            var apiInstance = new HostComponentsApi();
            var clusterName = clusterName_example;  // string | 

            try
            {
                // Delete host components
                apiInstance.DeleteHostComponents(clusterName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HostComponentsApi.DeleteHostComponents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clusterName** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethostcomponent"></a>
# **GetHostComponent**
> HostComponentSwagger GetHostComponent (string hostComponentName, string clusterName, string format, string fields)

Get single host component for a host



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetHostComponentExample
    {
        public void main()
        {
            
            var apiInstance = new HostComponentsApi();
            var hostComponentName = hostComponentName_example;  // string | 
            var clusterName = clusterName_example;  // string | 
            var format = format_example;  // string |  (optional) 
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional) 

            try
            {
                // Get single host component for a host
                HostComponentSwagger result = apiInstance.GetHostComponent(hostComponentName, clusterName, format, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HostComponentsApi.GetHostComponent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **hostComponentName** | **string**|  | 
 **clusterName** | **string**|  | 
 **format** | **string**|  | [optional] 
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] 

### Return type

[**HostComponentSwagger**](HostComponentSwagger.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethostcomponents"></a>
# **GetHostComponents**
> List<HostComponentSwagger> GetHostComponents (string clusterName, string format, string fields)

Get all host components for a host



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetHostComponentsExample
    {
        public void main()
        {
            
            var apiInstance = new HostComponentsApi();
            var clusterName = clusterName_example;  // string | 
            var format = format_example;  // string |  (optional) 
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional) 

            try
            {
                // Get all host components for a host
                List&lt;HostComponentSwagger&gt; result = apiInstance.GetHostComponents(clusterName, format, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HostComponentsApi.GetHostComponents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clusterName** | **string**|  | 
 **format** | **string**|  | [optional] 
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] 

### Return type

[**List<HostComponentSwagger>**](HostComponentSwagger.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprocesses"></a>
# **GetProcesses**
> HostComponentProcessResponse GetProcesses (string hostComponentName, string clusterName, string fields)

Get processes of a specific host component



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProcessesExample
    {
        public void main()
        {
            
            var apiInstance = new HostComponentsApi();
            var hostComponentName = hostComponentName_example;  // string | 
            var clusterName = clusterName_example;  // string | 
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional) 

            try
            {
                // Get processes of a specific host component
                HostComponentProcessResponse result = apiInstance.GetProcesses(hostComponentName, clusterName, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HostComponentsApi.GetProcesses: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **hostComponentName** | **string**|  | 
 **clusterName** | **string**|  | 
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] 

### Return type

[**HostComponentProcessResponse**](HostComponentProcessResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatehostcomponent"></a>
# **UpdateHostComponent**
> void UpdateHostComponent (string hostComponentName, string clusterName, ServiceComponentHostResponse body)

Update host component detail



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateHostComponentExample
    {
        public void main()
        {
            
            var apiInstance = new HostComponentsApi();
            var hostComponentName = hostComponentName_example;  // string | 
            var clusterName = clusterName_example;  // string | 
            var body = new ServiceComponentHostResponse(); // ServiceComponentHostResponse |  (optional) 

            try
            {
                // Update host component detail
                apiInstance.UpdateHostComponent(hostComponentName, clusterName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HostComponentsApi.UpdateHostComponent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **hostComponentName** | **string**|  | 
 **clusterName** | **string**|  | 
 **body** | [**ServiceComponentHostResponse**](ServiceComponentHostResponse.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

