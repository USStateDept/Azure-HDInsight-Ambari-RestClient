# IO.Swagger.Api.ClustersApi

All URIs are relative to *https://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCluster**](ClustersApi.md#createcluster) | **POST** /clusters/{clusterName} | Creates a cluster
[**CreateClusterArtifact**](ClustersApi.md#createclusterartifact) | **POST** /clusters/{clusterName}/artifacts/{artifactName} | Creates a cluster artifact
[**DeleteCluster**](ClustersApi.md#deletecluster) | **DELETE** /clusters/{clusterName} | Deletes a cluster
[**DeleteClusterArtifact**](ClustersApi.md#deleteclusterartifact) | **DELETE** /clusters/{clusterName}/artifacts/{artifactName} | Deletes a single artifact
[**DeleteClusterArtifacts**](ClustersApi.md#deleteclusterartifacts) | **DELETE** /clusters/{clusterName}/artifacts | Deletes all artifacts of a cluster that match the provided predicate
[**GetCluster**](ClustersApi.md#getcluster) | **GET** /clusters/{clusterName} | Returns information about a specific cluster
[**GetClusterArtifact**](ClustersApi.md#getclusterartifact) | **GET** /clusters/{clusterName}/artifacts/{artifactName} | Get the details of a cluster artifact
[**GetClusterArtifacts**](ClustersApi.md#getclusterartifacts) | **GET** /clusters/{clusterName}/artifacts | Returns all artifacts associated with the cluster
[**GetClusters**](ClustersApi.md#getclusters) | **GET** /clusters | Returns all clusters
[**UpdateCluster**](ClustersApi.md#updatecluster) | **PUT** /clusters/{clusterName} | Updates a cluster
[**UpdateClusterArtifact**](ClustersApi.md#updateclusterartifact) | **PUT** /clusters/{clusterName}/artifacts/{artifactName} | Updates a single artifact
[**UpdateClusterArtifacts**](ClustersApi.md#updateclusterartifacts) | **PUT** /clusters/{clusterName}/artifacts | Updates multiple artifacts


<a name="createcluster"></a>
# **CreateCluster**
> void CreateCluster (string clusterName, ClusterRequestSwagger body)

Creates a cluster



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateClusterExample
    {
        public void main()
        {
            
            var apiInstance = new ClustersApi();
            var clusterName = clusterName_example;  // string | 
            var body = new ClusterRequestSwagger(); // ClusterRequestSwagger |  (optional) 

            try
            {
                // Creates a cluster
                apiInstance.CreateCluster(clusterName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClustersApi.CreateCluster: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clusterName** | **string**|  | 
 **body** | [**ClusterRequestSwagger**](ClusterRequestSwagger.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createclusterartifact"></a>
# **CreateClusterArtifact**
> void CreateClusterArtifact (string clusterName, string artifactName, ClusterArtifactRequest body)

Creates a cluster artifact



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateClusterArtifactExample
    {
        public void main()
        {
            
            var apiInstance = new ClustersApi();
            var clusterName = clusterName_example;  // string | 
            var artifactName = artifactName_example;  // string | 
            var body = new ClusterArtifactRequest(); // ClusterArtifactRequest |  (optional) 

            try
            {
                // Creates a cluster artifact
                apiInstance.CreateClusterArtifact(clusterName, artifactName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClustersApi.CreateClusterArtifact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clusterName** | **string**|  | 
 **artifactName** | **string**|  | 
 **body** | [**ClusterArtifactRequest**](ClusterArtifactRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecluster"></a>
# **DeleteCluster**
> void DeleteCluster (string clusterName)

Deletes a cluster



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteClusterExample
    {
        public void main()
        {
            
            var apiInstance = new ClustersApi();
            var clusterName = clusterName_example;  // string | 

            try
            {
                // Deletes a cluster
                apiInstance.DeleteCluster(clusterName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClustersApi.DeleteCluster: " + e.Message );
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

<a name="deleteclusterartifact"></a>
# **DeleteClusterArtifact**
> void DeleteClusterArtifact (string clusterName, string artifactName)

Deletes a single artifact



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteClusterArtifactExample
    {
        public void main()
        {
            
            var apiInstance = new ClustersApi();
            var clusterName = clusterName_example;  // string | 
            var artifactName = artifactName_example;  // string | 

            try
            {
                // Deletes a single artifact
                apiInstance.DeleteClusterArtifact(clusterName, artifactName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClustersApi.DeleteClusterArtifact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clusterName** | **string**|  | 
 **artifactName** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteclusterartifacts"></a>
# **DeleteClusterArtifacts**
> void DeleteClusterArtifacts (string clusterName)

Deletes all artifacts of a cluster that match the provided predicate



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteClusterArtifactsExample
    {
        public void main()
        {
            
            var apiInstance = new ClustersApi();
            var clusterName = clusterName_example;  // string | 

            try
            {
                // Deletes all artifacts of a cluster that match the provided predicate
                apiInstance.DeleteClusterArtifacts(clusterName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClustersApi.DeleteClusterArtifacts: " + e.Message );
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

<a name="getcluster"></a>
# **GetCluster**
> ClusterResponseWrapper GetCluster (string clusterName, string fields)

Returns information about a specific cluster



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetClusterExample
    {
        public void main()
        {
            
            var apiInstance = new ClustersApi();
            var clusterName = clusterName_example;  // string | 
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional)  (default to Clusters/*)

            try
            {
                // Returns information about a specific cluster
                ClusterResponseWrapper result = apiInstance.GetCluster(clusterName, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClustersApi.GetCluster: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clusterName** | **string**|  | 
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] [default to Clusters/*]

### Return type

[**ClusterResponseWrapper**](ClusterResponseWrapper.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclusterartifact"></a>
# **GetClusterArtifact**
> ClusterArtifactResponse GetClusterArtifact (string clusterName, string artifactName, string fields, string sortBy, int? pageSize, string from, string to)

Get the details of a cluster artifact



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetClusterArtifactExample
    {
        public void main()
        {
            
            var apiInstance = new ClustersApi();
            var clusterName = clusterName_example;  // string | 
            var artifactName = artifactName_example;  // string | 
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional) 
            var sortBy = sortBy_example;  // string | Sort resources in result by (asc | desc) (optional) 
            var pageSize = 56;  // int? | The number of resources to be returned for the paged response. (optional)  (default to 10)
            var from = from_example;  // string | The starting page resource (inclusive).  \"start\" is also accepted. (optional)  (default to 0)
            var to = to_example;  // string | The ending page resource (inclusive).  \"end\" is also accepted. (optional) 

            try
            {
                // Get the details of a cluster artifact
                ClusterArtifactResponse result = apiInstance.GetClusterArtifact(clusterName, artifactName, fields, sortBy, pageSize, from, to);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClustersApi.GetClusterArtifact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clusterName** | **string**|  | 
 **artifactName** | **string**|  | 
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] 
 **sortBy** | **string**| Sort resources in result by (asc | desc) | [optional] 
 **pageSize** | **int?**| The number of resources to be returned for the paged response. | [optional] [default to 10]
 **from** | **string**| The starting page resource (inclusive).  \&quot;start\&quot; is also accepted. | [optional] [default to 0]
 **to** | **string**| The ending page resource (inclusive).  \&quot;end\&quot; is also accepted. | [optional] 

### Return type

[**ClusterArtifactResponse**](ClusterArtifactResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclusterartifacts"></a>
# **GetClusterArtifacts**
> List<ClusterArtifactResponse> GetClusterArtifacts (string clusterName, string fields, string sortBy, int? pageSize, int? from, int? to)

Returns all artifacts associated with the cluster



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetClusterArtifactsExample
    {
        public void main()
        {
            
            var apiInstance = new ClustersApi();
            var clusterName = clusterName_example;  // string | 
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional) 
            var sortBy = sortBy_example;  // string | Sort resources in result by (asc | desc) (optional) 
            var pageSize = 56;  // int? | The number of resources to be returned for the paged response. (optional)  (default to 10)
            var from = 56;  // int? | The starting page resource (inclusive).  \"start\" is also accepted. (optional)  (default to 0)
            var to = 56;  // int? | The ending page resource (inclusive).  \"end\" is also accepted. (optional) 

            try
            {
                // Returns all artifacts associated with the cluster
                List&lt;ClusterArtifactResponse&gt; result = apiInstance.GetClusterArtifacts(clusterName, fields, sortBy, pageSize, from, to);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClustersApi.GetClusterArtifacts: " + e.Message );
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

[**List<ClusterArtifactResponse>**](ClusterArtifactResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclusters"></a>
# **GetClusters**
> List<ClusterResponseWrapper> GetClusters (string fields, string sortBy, int? pageSize, int? from, int? to)

Returns all clusters



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetClustersExample
    {
        public void main()
        {
            
            var apiInstance = new ClustersApi();
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional) 
            var sortBy = sortBy_example;  // string | Sort resources in result by (asc | desc) (optional) 
            var pageSize = 56;  // int? | The number of resources to be returned for the paged response. (optional)  (default to 10)
            var from = 56;  // int? | The starting page resource (inclusive).  \"start\" is also accepted. (optional)  (default to 0)
            var to = 56;  // int? | The ending page resource (inclusive).  \"end\" is also accepted. (optional) 

            try
            {
                // Returns all clusters
                List&lt;ClusterResponseWrapper&gt; result = apiInstance.GetClusters(fields, sortBy, pageSize, from, to);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClustersApi.GetClusters: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] 
 **sortBy** | **string**| Sort resources in result by (asc | desc) | [optional] 
 **pageSize** | **int?**| The number of resources to be returned for the paged response. | [optional] [default to 10]
 **from** | **int?**| The starting page resource (inclusive).  \&quot;start\&quot; is also accepted. | [optional] [default to 0]
 **to** | **int?**| The ending page resource (inclusive).  \&quot;end\&quot; is also accepted. | [optional] 

### Return type

[**List<ClusterResponseWrapper>**](ClusterResponseWrapper.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecluster"></a>
# **UpdateCluster**
> void UpdateCluster (string clusterName, ClusterRequestSwagger body)

Updates a cluster



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateClusterExample
    {
        public void main()
        {
            
            var apiInstance = new ClustersApi();
            var clusterName = clusterName_example;  // string | 
            var body = new ClusterRequestSwagger(); // ClusterRequestSwagger |  (optional) 

            try
            {
                // Updates a cluster
                apiInstance.UpdateCluster(clusterName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClustersApi.UpdateCluster: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clusterName** | **string**|  | 
 **body** | [**ClusterRequestSwagger**](ClusterRequestSwagger.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateclusterartifact"></a>
# **UpdateClusterArtifact**
> void UpdateClusterArtifact (string clusterName, string artifactName, ClusterArtifactRequest body)

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
    public class UpdateClusterArtifactExample
    {
        public void main()
        {
            
            var apiInstance = new ClustersApi();
            var clusterName = clusterName_example;  // string | 
            var artifactName = artifactName_example;  // string | 
            var body = new ClusterArtifactRequest(); // ClusterArtifactRequest |  (optional) 

            try
            {
                // Updates a single artifact
                apiInstance.UpdateClusterArtifact(clusterName, artifactName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClustersApi.UpdateClusterArtifact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clusterName** | **string**|  | 
 **artifactName** | **string**|  | 
 **body** | [**ClusterArtifactRequest**](ClusterArtifactRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateclusterartifacts"></a>
# **UpdateClusterArtifacts**
> void UpdateClusterArtifacts (string clusterName, ClusterArtifactRequest body)

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
    public class UpdateClusterArtifactsExample
    {
        public void main()
        {
            
            var apiInstance = new ClustersApi();
            var clusterName = clusterName_example;  // string | 
            var body = new ClusterArtifactRequest(); // ClusterArtifactRequest |  (optional) 

            try
            {
                // Updates multiple artifacts
                apiInstance.UpdateClusterArtifacts(clusterName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClustersApi.UpdateClusterArtifacts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clusterName** | **string**|  | 
 **body** | [**ClusterArtifactRequest**](ClusterArtifactRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

