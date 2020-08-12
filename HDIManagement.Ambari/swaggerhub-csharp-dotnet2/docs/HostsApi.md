# IO.Swagger.Api.HostsApi

All URIs are relative to *https://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateHost**](HostsApi.md#createhost) | **POST** /hosts/{hostName} | Creates a host
[**CreateHosts**](HostsApi.md#createhosts) | **POST** /hosts | Creates multiple hosts in a single request
[**DeleteHost**](HostsApi.md#deletehost) | **DELETE** /hosts/{hostName} | Deletes a host
[**DeleteHosts**](HostsApi.md#deletehosts) | **DELETE** /hosts | Deletes multiple hosts in a single request
[**GetHost**](HostsApi.md#gethost) | **GET** /hosts/{hostName} | Returns information about a single host
[**GetHosts**](HostsApi.md#gethosts) | **GET** /hosts | Returns a collection of all hosts
[**UpdateHost**](HostsApi.md#updatehost) | **PUT** /hosts/{hostName} | Updates a host
[**UpdateHosts**](HostsApi.md#updatehosts) | **PUT** /hosts | Updates multiple hosts in a single request


<a name="createhost"></a>
# **CreateHost**
> void CreateHost (string hostName, HostRequest body)

Creates a host



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateHostExample
    {
        public void main()
        {
            
            var apiInstance = new HostsApi();
            var hostName = hostName_example;  // string | host name
            var body = new HostRequest(); // HostRequest |  (optional) 

            try
            {
                // Creates a host
                apiInstance.CreateHost(hostName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HostsApi.CreateHost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **hostName** | **string**| host name | 
 **body** | [**HostRequest**](HostRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createhosts"></a>
# **CreateHosts**
> void CreateHosts (HostRequest body)

Creates multiple hosts in a single request



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateHostsExample
    {
        public void main()
        {
            
            var apiInstance = new HostsApi();
            var body = new HostRequest(); // HostRequest |  (optional) 

            try
            {
                // Creates multiple hosts in a single request
                apiInstance.CreateHosts(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HostsApi.CreateHosts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**HostRequest**](HostRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletehost"></a>
# **DeleteHost**
> void DeleteHost (string hostName)

Deletes a host



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteHostExample
    {
        public void main()
        {
            
            var apiInstance = new HostsApi();
            var hostName = hostName_example;  // string | host name

            try
            {
                // Deletes a host
                apiInstance.DeleteHost(hostName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HostsApi.DeleteHost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **hostName** | **string**| host name | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletehosts"></a>
# **DeleteHosts**
> void DeleteHosts (HostRequest body)

Deletes multiple hosts in a single request



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteHostsExample
    {
        public void main()
        {
            
            var apiInstance = new HostsApi();
            var body = new HostRequest(); // HostRequest |  (optional) 

            try
            {
                // Deletes multiple hosts in a single request
                apiInstance.DeleteHosts(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HostsApi.DeleteHosts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**HostRequest**](HostRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethost"></a>
# **GetHost**
> HostResponseWrapper GetHost (string hostName, string fields)

Returns information about a single host



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetHostExample
    {
        public void main()
        {
            
            var apiInstance = new HostsApi();
            var hostName = hostName_example;  // string | host name
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional) 

            try
            {
                // Returns information about a single host
                HostResponseWrapper result = apiInstance.GetHost(hostName, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HostsApi.GetHost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **hostName** | **string**| host name | 
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] 

### Return type

[**HostResponseWrapper**](HostResponseWrapper.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethosts"></a>
# **GetHosts**
> List<HostResponseWrapper> GetHosts (string fields, string sortBy, int? pageSize, int? from, int? to)

Returns a collection of all hosts



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetHostsExample
    {
        public void main()
        {
            
            var apiInstance = new HostsApi();
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional)  (default to Hosts/*)
            var sortBy = sortBy_example;  // string | Sort resources in result by (asc | desc) (optional)  (default to Hosts/host_name.asc)
            var pageSize = 56;  // int? | The number of resources to be returned for the paged response. (optional)  (default to 10)
            var from = 56;  // int? | The starting page resource (inclusive).  \"start\" is also accepted. (optional)  (default to 0)
            var to = 56;  // int? | The ending page resource (inclusive).  \"end\" is also accepted. (optional) 

            try
            {
                // Returns a collection of all hosts
                List&lt;HostResponseWrapper&gt; result = apiInstance.GetHosts(fields, sortBy, pageSize, from, to);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HostsApi.GetHosts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] [default to Hosts/*]
 **sortBy** | **string**| Sort resources in result by (asc | desc) | [optional] [default to Hosts/host_name.asc]
 **pageSize** | **int?**| The number of resources to be returned for the paged response. | [optional] [default to 10]
 **from** | **int?**| The starting page resource (inclusive).  \&quot;start\&quot; is also accepted. | [optional] [default to 0]
 **to** | **int?**| The ending page resource (inclusive).  \&quot;end\&quot; is also accepted. | [optional] 

### Return type

[**List<HostResponseWrapper>**](HostResponseWrapper.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatehost"></a>
# **UpdateHost**
> void UpdateHost (string hostName, HostRequest body)

Updates a host



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateHostExample
    {
        public void main()
        {
            
            var apiInstance = new HostsApi();
            var hostName = hostName_example;  // string | host name
            var body = new HostRequest(); // HostRequest |  (optional) 

            try
            {
                // Updates a host
                apiInstance.UpdateHost(hostName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HostsApi.UpdateHost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **hostName** | **string**| host name | 
 **body** | [**HostRequest**](HostRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatehosts"></a>
# **UpdateHosts**
> void UpdateHosts (HostRequest body)

Updates multiple hosts in a single request



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateHostsExample
    {
        public void main()
        {
            
            var apiInstance = new HostsApi();
            var body = new HostRequest(); // HostRequest |  (optional) 

            try
            {
                // Updates multiple hosts in a single request
                apiInstance.UpdateHosts(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HostsApi.UpdateHosts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**HostRequest**](HostRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

