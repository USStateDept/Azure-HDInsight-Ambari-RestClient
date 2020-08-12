# IO.Swagger.Api.ServicesApi

All URIs are relative to *https://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetRootHost**](ServicesApi.md#getroothost) | **GET** /services/{serviceName}/hosts/{hostName} | Returns information about the given host
[**GetRootHosts**](ServicesApi.md#getroothosts) | **GET** /services/{serviceName}/hosts | Returns the list of hosts for the given root-level service
[**GetRootService**](ServicesApi.md#getrootservice) | **GET** /services/{serviceName} | Returns information about the given root-level service, including a list of its components
[**GetRootServiceComponent**](ServicesApi.md#getrootservicecomponent) | **GET** /services/{serviceName}/components/{componentName} | Returns information about the given component for the given root-level service
[**GetRootServiceComponentHosts**](ServicesApi.md#getrootservicecomponenthosts) | **GET** /services/{serviceName}/components/{componentName}/hostComponents | Returns the list of hosts for the given root-level service component
[**GetRootServiceComponents**](ServicesApi.md#getrootservicecomponents) | **GET** /services/{serviceName}/components | Returns the list of components for the given root-level service
[**GetRootServiceHostComponent**](ServicesApi.md#getrootservicehostcomponent) | **GET** /services/{serviceName}/hosts/{hostName}/hostComponents/{hostComponent} | Returns information about the given component for the given root-level service on the given host
[**GetRootServiceHostComponents**](ServicesApi.md#getrootservicehostcomponents) | **GET** /services/{serviceName}/hosts/{hostName}/hostComponents | Returns the list of components for the given root-level service on the given host
[**GetRootServices**](ServicesApi.md#getrootservices) | **GET** /services | Returns the list of root-level services


<a name="getroothost"></a>
# **GetRootHost**
> HostResponseWrapper GetRootHost (string hostName, string fields)

Returns information about the given host



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRootHostExample
    {
        public void main()
        {
            
            var apiInstance = new ServicesApi();
            var hostName = hostName_example;  // string | host name
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional)  (default to Hosts/*)

            try
            {
                // Returns information about the given host
                HostResponseWrapper result = apiInstance.GetRootHost(hostName, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServicesApi.GetRootHost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **hostName** | **string**| host name | 
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] [default to Hosts/*]

### Return type

[**HostResponseWrapper**](HostResponseWrapper.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getroothosts"></a>
# **GetRootHosts**
> List<HostResponseWrapper> GetRootHosts (string fields)

Returns the list of hosts for the given root-level service



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRootHostsExample
    {
        public void main()
        {
            
            var apiInstance = new ServicesApi();
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional)  (default to Hosts/host_name)

            try
            {
                // Returns the list of hosts for the given root-level service
                List&lt;HostResponseWrapper&gt; result = apiInstance.GetRootHosts(fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServicesApi.GetRootHosts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] [default to Hosts/host_name]

### Return type

[**List<HostResponseWrapper>**](HostResponseWrapper.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrootservice"></a>
# **GetRootService**
> RootServiceResponseWithComponentList GetRootService (string serviceName, string fields)

Returns information about the given root-level service, including a list of its components



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRootServiceExample
    {
        public void main()
        {
            
            var apiInstance = new ServicesApi();
            var serviceName = serviceName_example;  // string | service name
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional)  (default to RootService/service_name, components/RootServiceComponents/component_name, components/RootServiceComponents/service_name)

            try
            {
                // Returns information about the given root-level service, including a list of its components
                RootServiceResponseWithComponentList result = apiInstance.GetRootService(serviceName, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServicesApi.GetRootService: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceName** | **string**| service name | 
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] [default to RootService/service_name, components/RootServiceComponents/component_name, components/RootServiceComponents/service_name]

### Return type

[**RootServiceResponseWithComponentList**](RootServiceResponseWithComponentList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrootservicecomponent"></a>
# **GetRootServiceComponent**
> RootServiceComponentWithHostComponentList GetRootServiceComponent (string serviceName, string componentName, string fields)

Returns information about the given component for the given root-level service



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRootServiceComponentExample
    {
        public void main()
        {
            
            var apiInstance = new ServicesApi();
            var serviceName = serviceName_example;  // string | service name
            var componentName = componentName_example;  // string | component name
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional)  (default to RootServiceComponents/*, hostComponents/RootServiceHostComponents/component_name, hostComponents/RootServiceHostComponents/host_name, hostComponents/RootServiceHostComponents/service_name)

            try
            {
                // Returns information about the given component for the given root-level service
                RootServiceComponentWithHostComponentList result = apiInstance.GetRootServiceComponent(serviceName, componentName, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServicesApi.GetRootServiceComponent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceName** | **string**| service name | 
 **componentName** | **string**| component name | 
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] [default to RootServiceComponents/*, hostComponents/RootServiceHostComponents/component_name, hostComponents/RootServiceHostComponents/host_name, hostComponents/RootServiceHostComponents/service_name]

### Return type

[**RootServiceComponentWithHostComponentList**](RootServiceComponentWithHostComponentList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrootservicecomponenthosts"></a>
# **GetRootServiceComponentHosts**
> List<RootServiceHostComponentResponseWrapper> GetRootServiceComponentHosts (string serviceName, string componentName, string fields)

Returns the list of hosts for the given root-level service component



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRootServiceComponentHostsExample
    {
        public void main()
        {
            
            var apiInstance = new ServicesApi();
            var serviceName = serviceName_example;  // string | service name
            var componentName = componentName_example;  // string | component name
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional)  (default to RootServiceHostComponents/component_name, RootServiceHostComponents/host_name, RootServiceHostComponents/service_name)

            try
            {
                // Returns the list of hosts for the given root-level service component
                List&lt;RootServiceHostComponentResponseWrapper&gt; result = apiInstance.GetRootServiceComponentHosts(serviceName, componentName, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServicesApi.GetRootServiceComponentHosts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceName** | **string**| service name | 
 **componentName** | **string**| component name | 
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] [default to RootServiceHostComponents/component_name, RootServiceHostComponents/host_name, RootServiceHostComponents/service_name]

### Return type

[**List<RootServiceHostComponentResponseWrapper>**](RootServiceHostComponentResponseWrapper.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrootservicecomponents"></a>
# **GetRootServiceComponents**
> List<RootServiceComponentResponseWrapper> GetRootServiceComponents (string serviceName, string fields)

Returns the list of components for the given root-level service



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRootServiceComponentsExample
    {
        public void main()
        {
            
            var apiInstance = new ServicesApi();
            var serviceName = serviceName_example;  // string | service name
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional)  (default to RootServiceComponents/component_name, RootServiceComponents/service_name)

            try
            {
                // Returns the list of components for the given root-level service
                List&lt;RootServiceComponentResponseWrapper&gt; result = apiInstance.GetRootServiceComponents(serviceName, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServicesApi.GetRootServiceComponents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceName** | **string**| service name | 
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] [default to RootServiceComponents/component_name, RootServiceComponents/service_name]

### Return type

[**List<RootServiceComponentResponseWrapper>**](RootServiceComponentResponseWrapper.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrootservicehostcomponent"></a>
# **GetRootServiceHostComponent**
> RootServiceHostComponentResponseWrapper GetRootServiceHostComponent (string serviceName, string hostName, string hostComponent, string fields)

Returns information about the given component for the given root-level service on the given host



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRootServiceHostComponentExample
    {
        public void main()
        {
            
            var apiInstance = new ServicesApi();
            var serviceName = serviceName_example;  // string | service name
            var hostName = hostName_example;  // string | host name
            var hostComponent = hostComponent_example;  // string | component name
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional)  (default to RootServiceHostComponents/component_name, RootServiceHostComponents/host_name, RootServiceHostComponents/service_name)

            try
            {
                // Returns information about the given component for the given root-level service on the given host
                RootServiceHostComponentResponseWrapper result = apiInstance.GetRootServiceHostComponent(serviceName, hostName, hostComponent, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServicesApi.GetRootServiceHostComponent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceName** | **string**| service name | 
 **hostName** | **string**| host name | 
 **hostComponent** | **string**| component name | 
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] [default to RootServiceHostComponents/component_name, RootServiceHostComponents/host_name, RootServiceHostComponents/service_name]

### Return type

[**RootServiceHostComponentResponseWrapper**](RootServiceHostComponentResponseWrapper.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrootservicehostcomponents"></a>
# **GetRootServiceHostComponents**
> List<RootServiceHostComponentResponseWrapper> GetRootServiceHostComponents (string serviceName, string hostName, string fields)

Returns the list of components for the given root-level service on the given host



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRootServiceHostComponentsExample
    {
        public void main()
        {
            
            var apiInstance = new ServicesApi();
            var serviceName = serviceName_example;  // string | service name
            var hostName = hostName_example;  // string | host name
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional)  (default to RootServiceHostComponents/component_name, RootServiceHostComponents/host_name, RootServiceHostComponents/service_name)

            try
            {
                // Returns the list of components for the given root-level service on the given host
                List&lt;RootServiceHostComponentResponseWrapper&gt; result = apiInstance.GetRootServiceHostComponents(serviceName, hostName, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServicesApi.GetRootServiceHostComponents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceName** | **string**| service name | 
 **hostName** | **string**| host name | 
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] [default to RootServiceHostComponents/component_name, RootServiceHostComponents/host_name, RootServiceHostComponents/service_name]

### Return type

[**List<RootServiceHostComponentResponseWrapper>**](RootServiceHostComponentResponseWrapper.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrootservices"></a>
# **GetRootServices**
> List<RootServiceResponseWrapper> GetRootServices (string fields)

Returns the list of root-level services



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRootServicesExample
    {
        public void main()
        {
            
            var apiInstance = new ServicesApi();
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional)  (default to RootService/service_name)

            try
            {
                // Returns the list of root-level services
                List&lt;RootServiceResponseWrapper&gt; result = apiInstance.GetRootServices(fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServicesApi.GetRootServices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] [default to RootService/service_name]

### Return type

[**List<RootServiceResponseWrapper>**](RootServiceResponseWrapper.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

