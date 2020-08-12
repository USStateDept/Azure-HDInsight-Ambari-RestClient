# IO.Swagger.Api.ClusterServicesApi

All URIs are relative to *https://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ServiceServiceCreateArtifact**](ClusterServicesApi.md#serviceservicecreateartifact) | **POST** /clusters/{clusterName}/services/{serviceName}/artifacts/{artifactName} | Creates a service artifact
[**ServiceServiceCreateServices**](ClusterServicesApi.md#serviceservicecreateservices) | **POST** /clusters/{clusterName}/services/{serviceName} | Creates a service
[**ServiceServiceDeleteArtifact**](ClusterServicesApi.md#serviceservicedeleteartifact) | **DELETE** /clusters/{clusterName}/services/{serviceName}/artifacts/{artifactName} | Deletes a single service artifact
[**ServiceServiceDeleteArtifacts**](ClusterServicesApi.md#serviceservicedeleteartifacts) | **DELETE** /clusters/{clusterName}/services/{serviceName}/artifacts | Deletes all artifacts of a service that match the provided predicate
[**ServiceServiceDeleteService**](ClusterServicesApi.md#serviceservicedeleteservice) | **DELETE** /clusters/{clusterName}/services/{serviceName} | Deletes a service
[**ServiceServiceGetArtifact**](ClusterServicesApi.md#serviceservicegetartifact) | **GET** /clusters/{clusterName}/services/{serviceName}/artifacts/{artifactName} | Get the details of a service artifact
[**ServiceServiceGetArtifacts**](ClusterServicesApi.md#serviceservicegetartifacts) | **GET** /clusters/{clusterName}/services/{serviceName}/artifacts | Get all service artifacts
[**ServiceServiceGetService**](ClusterServicesApi.md#serviceservicegetservice) | **GET** /clusters/{clusterName}/services/{serviceName} | Get the details of a service
[**ServiceServiceGetServices**](ClusterServicesApi.md#serviceservicegetservices) | **GET** /clusters/{clusterName}/services | Get all services
[**ServiceServiceUpdateArtifact**](ClusterServicesApi.md#serviceserviceupdateartifact) | **PUT** /clusters/{clusterName}/services/{serviceName}/artifacts/{artifactName} | Updates a single artifact
[**ServiceServiceUpdateArtifacts**](ClusterServicesApi.md#serviceserviceupdateartifacts) | **PUT** /clusters/{clusterName}/services/{serviceName}/artifacts | Updates multiple artifacts
[**ServiceServiceUpdateService**](ClusterServicesApi.md#serviceserviceupdateservice) | **PUT** /clusters/{clusterName}/services/{serviceName} | Updates a service


<a name="serviceservicecreateartifact"></a>
# **ServiceServiceCreateArtifact**
> void ServiceServiceCreateArtifact (string serviceName, string artifactName, string clusterName, ClusterServiceArtifactRequest body)

Creates a service artifact



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceServiceCreateArtifactExample
    {
        public void main()
        {
            
            var apiInstance = new ClusterServicesApi();
            var serviceName = serviceName_example;  // string | 
            var artifactName = artifactName_example;  // string | 
            var clusterName = clusterName_example;  // string | 
            var body = new ClusterServiceArtifactRequest(); // ClusterServiceArtifactRequest |  (optional) 

            try
            {
                // Creates a service artifact
                apiInstance.ServiceServiceCreateArtifact(serviceName, artifactName, clusterName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClusterServicesApi.ServiceServiceCreateArtifact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceName** | **string**|  | 
 **artifactName** | **string**|  | 
 **clusterName** | **string**|  | 
 **body** | [**ClusterServiceArtifactRequest**](ClusterServiceArtifactRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceservicecreateservices"></a>
# **ServiceServiceCreateServices**
> void ServiceServiceCreateServices (string serviceName, string clusterName, ServiceRequestSwagger body)

Creates a service



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceServiceCreateServicesExample
    {
        public void main()
        {
            
            var apiInstance = new ClusterServicesApi();
            var serviceName = serviceName_example;  // string | 
            var clusterName = clusterName_example;  // string | 
            var body = new ServiceRequestSwagger(); // ServiceRequestSwagger |  (optional) 

            try
            {
                // Creates a service
                apiInstance.ServiceServiceCreateServices(serviceName, clusterName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClusterServicesApi.ServiceServiceCreateServices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceName** | **string**|  | 
 **clusterName** | **string**|  | 
 **body** | [**ServiceRequestSwagger**](ServiceRequestSwagger.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceservicedeleteartifact"></a>
# **ServiceServiceDeleteArtifact**
> void ServiceServiceDeleteArtifact (string serviceName, string artifactName, string clusterName)

Deletes a single service artifact



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceServiceDeleteArtifactExample
    {
        public void main()
        {
            
            var apiInstance = new ClusterServicesApi();
            var serviceName = serviceName_example;  // string | 
            var artifactName = artifactName_example;  // string | 
            var clusterName = clusterName_example;  // string | 

            try
            {
                // Deletes a single service artifact
                apiInstance.ServiceServiceDeleteArtifact(serviceName, artifactName, clusterName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClusterServicesApi.ServiceServiceDeleteArtifact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceName** | **string**|  | 
 **artifactName** | **string**|  | 
 **clusterName** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceservicedeleteartifacts"></a>
# **ServiceServiceDeleteArtifacts**
> void ServiceServiceDeleteArtifacts (string serviceName, string clusterName)

Deletes all artifacts of a service that match the provided predicate



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceServiceDeleteArtifactsExample
    {
        public void main()
        {
            
            var apiInstance = new ClusterServicesApi();
            var serviceName = serviceName_example;  // string | 
            var clusterName = clusterName_example;  // string | 

            try
            {
                // Deletes all artifacts of a service that match the provided predicate
                apiInstance.ServiceServiceDeleteArtifacts(serviceName, clusterName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClusterServicesApi.ServiceServiceDeleteArtifacts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceName** | **string**|  | 
 **clusterName** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceservicedeleteservice"></a>
# **ServiceServiceDeleteService**
> void ServiceServiceDeleteService (string serviceName, string clusterName)

Deletes a service



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceServiceDeleteServiceExample
    {
        public void main()
        {
            
            var apiInstance = new ClusterServicesApi();
            var serviceName = serviceName_example;  // string | 
            var clusterName = clusterName_example;  // string | 

            try
            {
                // Deletes a service
                apiInstance.ServiceServiceDeleteService(serviceName, clusterName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClusterServicesApi.ServiceServiceDeleteService: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceName** | **string**|  | 
 **clusterName** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceservicegetartifact"></a>
# **ServiceServiceGetArtifact**
> List<ClusterServiceArtifactResponse> ServiceServiceGetArtifact (string serviceName, string artifactName, string clusterName, string fields, string sortBy, int? pageSize, string from, string to)

Get the details of a service artifact



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceServiceGetArtifactExample
    {
        public void main()
        {
            
            var apiInstance = new ClusterServicesApi();
            var serviceName = serviceName_example;  // string | 
            var artifactName = artifactName_example;  // string | 
            var clusterName = clusterName_example;  // string | 
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional)  (default to Artifacts/artifact_name)
            var sortBy = sortBy_example;  // string | Sort resources in result by (asc | desc) (optional)  (default to Artifacts/artifact_name)
            var pageSize = 56;  // int? | The number of resources to be returned for the paged response. (optional)  (default to 10)
            var from = from_example;  // string | The starting page resource (inclusive).  \"start\" is also accepted. (optional)  (default to 0)
            var to = to_example;  // string | The ending page resource (inclusive).  \"end\" is also accepted. (optional) 

            try
            {
                // Get the details of a service artifact
                List&lt;ClusterServiceArtifactResponse&gt; result = apiInstance.ServiceServiceGetArtifact(serviceName, artifactName, clusterName, fields, sortBy, pageSize, from, to);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClusterServicesApi.ServiceServiceGetArtifact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceName** | **string**|  | 
 **artifactName** | **string**|  | 
 **clusterName** | **string**|  | 
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] [default to Artifacts/artifact_name]
 **sortBy** | **string**| Sort resources in result by (asc | desc) | [optional] [default to Artifacts/artifact_name]
 **pageSize** | **int?**| The number of resources to be returned for the paged response. | [optional] [default to 10]
 **from** | **string**| The starting page resource (inclusive).  \&quot;start\&quot; is also accepted. | [optional] [default to 0]
 **to** | **string**| The ending page resource (inclusive).  \&quot;end\&quot; is also accepted. | [optional] 

### Return type

[**List<ClusterServiceArtifactResponse>**](ClusterServiceArtifactResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceservicegetartifacts"></a>
# **ServiceServiceGetArtifacts**
> List<ClusterServiceArtifactResponse> ServiceServiceGetArtifacts (string serviceName, string clusterName, string fields, string sortBy, int? pageSize, string from, string to)

Get all service artifacts



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceServiceGetArtifactsExample
    {
        public void main()
        {
            
            var apiInstance = new ClusterServicesApi();
            var serviceName = serviceName_example;  // string | 
            var clusterName = clusterName_example;  // string | 
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional)  (default to Artifacts/artifact_name)
            var sortBy = sortBy_example;  // string | Sort resources in result by (asc | desc) (optional)  (default to Artifacts/artifact_name)
            var pageSize = 56;  // int? | The number of resources to be returned for the paged response. (optional)  (default to 10)
            var from = from_example;  // string | The starting page resource (inclusive).  \"start\" is also accepted. (optional)  (default to 0)
            var to = to_example;  // string | The ending page resource (inclusive).  \"end\" is also accepted. (optional) 

            try
            {
                // Get all service artifacts
                List&lt;ClusterServiceArtifactResponse&gt; result = apiInstance.ServiceServiceGetArtifacts(serviceName, clusterName, fields, sortBy, pageSize, from, to);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClusterServicesApi.ServiceServiceGetArtifacts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceName** | **string**|  | 
 **clusterName** | **string**|  | 
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] [default to Artifacts/artifact_name]
 **sortBy** | **string**| Sort resources in result by (asc | desc) | [optional] [default to Artifacts/artifact_name]
 **pageSize** | **int?**| The number of resources to be returned for the paged response. | [optional] [default to 10]
 **from** | **string**| The starting page resource (inclusive).  \&quot;start\&quot; is also accepted. | [optional] [default to 0]
 **to** | **string**| The ending page resource (inclusive).  \&quot;end\&quot; is also accepted. | [optional] 

### Return type

[**List<ClusterServiceArtifactResponse>**](ClusterServiceArtifactResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceservicegetservice"></a>
# **ServiceServiceGetService**
> List<ServiceResponseSwagger> ServiceServiceGetService (string serviceName, string clusterName, string fields)

Get the details of a service

Returns the details of a service.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceServiceGetServiceExample
    {
        public void main()
        {
            
            var apiInstance = new ClusterServicesApi();
            var serviceName = serviceName_example;  // string | 
            var clusterName = clusterName_example;  // string | 
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional)  (default to ServiceInfo/*)

            try
            {
                // Get the details of a service
                List&lt;ServiceResponseSwagger&gt; result = apiInstance.ServiceServiceGetService(serviceName, clusterName, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClusterServicesApi.ServiceServiceGetService: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceName** | **string**|  | 
 **clusterName** | **string**|  | 
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] [default to ServiceInfo/*]

### Return type

[**List<ServiceResponseSwagger>**](ServiceResponseSwagger.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceservicegetservices"></a>
# **ServiceServiceGetServices**
> List<ServiceResponseSwagger> ServiceServiceGetServices (string clusterName, string fields, string sortBy, int? pageSize, string from, string to)

Get all services

Returns all services.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceServiceGetServicesExample
    {
        public void main()
        {
            
            var apiInstance = new ClusterServicesApi();
            var clusterName = clusterName_example;  // string | 
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional)  (default to ServiceInfo/service_name,ServiceInfo/cluster_name)
            var sortBy = sortBy_example;  // string | Sort resources in result by (asc | desc) (optional)  (default to ServiceInfo/service_name.asc,ServiceInfo/cluster_name.asc)
            var pageSize = 56;  // int? | The number of resources to be returned for the paged response. (optional)  (default to 10)
            var from = from_example;  // string | The starting page resource (inclusive).  \"start\" is also accepted. (optional)  (default to 0)
            var to = to_example;  // string | The ending page resource (inclusive).  \"end\" is also accepted. (optional) 

            try
            {
                // Get all services
                List&lt;ServiceResponseSwagger&gt; result = apiInstance.ServiceServiceGetServices(clusterName, fields, sortBy, pageSize, from, to);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClusterServicesApi.ServiceServiceGetServices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clusterName** | **string**|  | 
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] [default to ServiceInfo/service_name,ServiceInfo/cluster_name]
 **sortBy** | **string**| Sort resources in result by (asc | desc) | [optional] [default to ServiceInfo/service_name.asc,ServiceInfo/cluster_name.asc]
 **pageSize** | **int?**| The number of resources to be returned for the paged response. | [optional] [default to 10]
 **from** | **string**| The starting page resource (inclusive).  \&quot;start\&quot; is also accepted. | [optional] [default to 0]
 **to** | **string**| The ending page resource (inclusive).  \&quot;end\&quot; is also accepted. | [optional] 

### Return type

[**List<ServiceResponseSwagger>**](ServiceResponseSwagger.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceserviceupdateartifact"></a>
# **ServiceServiceUpdateArtifact**
> void ServiceServiceUpdateArtifact (string serviceName, string artifactName, string clusterName, ClusterServiceArtifactRequest body)

Updates a single artifact



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceServiceUpdateArtifactExample
    {
        public void main()
        {
            
            var apiInstance = new ClusterServicesApi();
            var serviceName = serviceName_example;  // string | 
            var artifactName = artifactName_example;  // string | 
            var clusterName = clusterName_example;  // string | 
            var body = new ClusterServiceArtifactRequest(); // ClusterServiceArtifactRequest |  (optional) 

            try
            {
                // Updates a single artifact
                apiInstance.ServiceServiceUpdateArtifact(serviceName, artifactName, clusterName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClusterServicesApi.ServiceServiceUpdateArtifact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceName** | **string**|  | 
 **artifactName** | **string**|  | 
 **clusterName** | **string**|  | 
 **body** | [**ClusterServiceArtifactRequest**](ClusterServiceArtifactRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceserviceupdateartifacts"></a>
# **ServiceServiceUpdateArtifacts**
> void ServiceServiceUpdateArtifacts (string serviceName, string clusterName, ClusterServiceArtifactRequest body)

Updates multiple artifacts



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceServiceUpdateArtifactsExample
    {
        public void main()
        {
            
            var apiInstance = new ClusterServicesApi();
            var serviceName = serviceName_example;  // string | 
            var clusterName = clusterName_example;  // string | 
            var body = new ClusterServiceArtifactRequest(); // ClusterServiceArtifactRequest |  (optional) 

            try
            {
                // Updates multiple artifacts
                apiInstance.ServiceServiceUpdateArtifacts(serviceName, clusterName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClusterServicesApi.ServiceServiceUpdateArtifacts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceName** | **string**|  | 
 **clusterName** | **string**|  | 
 **body** | [**ClusterServiceArtifactRequest**](ClusterServiceArtifactRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceserviceupdateservice"></a>
# **ServiceServiceUpdateService**
> void ServiceServiceUpdateService (string serviceName, string clusterName, ServiceRequestSwagger body)

Updates a service



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceServiceUpdateServiceExample
    {
        public void main()
        {
            
            var apiInstance = new ClusterServicesApi();
            var serviceName = serviceName_example;  // string | 
            var clusterName = clusterName_example;  // string | 
            var body = new ServiceRequestSwagger(); // ServiceRequestSwagger |  (optional) 

            try
            {
                // Updates a service
                apiInstance.ServiceServiceUpdateService(serviceName, clusterName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClusterServicesApi.ServiceServiceUpdateService: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceName** | **string**|  | 
 **clusterName** | **string**|  | 
 **body** | [**ServiceRequestSwagger**](ServiceRequestSwagger.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

