# IO.Swagger.Api.StacksApi

All URIs are relative to *https://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**StacksServiceGetServiceComponent**](StacksApi.md#stacksservicegetservicecomponent) | **GET** /stacks/{stackName}/versions/{stackVersion}/services/{serviceName}/components/{componentName} | Get details for a stack service component
[**StacksServiceGetServiceComponentDependencies**](StacksApi.md#stacksservicegetservicecomponentdependencies) | **GET** /stacks/{stackName}/versions/{stackVersion}/services/{serviceName}/components/{componentName}/dependencies | Get all dependencies for a stack service component
[**StacksServiceGetServiceComponentDependency**](StacksApi.md#stacksservicegetservicecomponentdependency) | **GET** /stacks/{stackName}/versions/{stackVersion}/services/{serviceName}/components/{componentName}/dependencies/{dependencyName} | Get a stack service component dependency
[**StacksServiceGetServiceComponents**](StacksApi.md#stacksservicegetservicecomponents) | **GET** /stacks/{stackName}/versions/{stackVersion}/services/{serviceName}/components | Get all components for a stack service
[**StacksServiceGetStack**](StacksApi.md#stacksservicegetstack) | **GET** /stacks/{stackName} | Get a stack
[**StacksServiceGetStackArtifact**](StacksApi.md#stacksservicegetstackartifact) | **GET** /stacks/{stackName}/versions/{stackVersion}/artifacts/{artifactName} | Get stack artifact details
[**StacksServiceGetStackArtifacts**](StacksApi.md#stacksservicegetstackartifacts) | **GET** /stacks/{stackName}/versions/{stackVersion}/artifacts | Get all stack artifacts
[**StacksServiceGetStackConfiguration**](StacksApi.md#stacksservicegetstackconfiguration) | **GET** /stacks/{stackName}/versions/{stackVersion}/services/{serviceName}/configurations/{propertyName} | Get stack service configuration details
[**StacksServiceGetStackConfigurationDependencies**](StacksApi.md#stacksservicegetstackconfigurationdependencies) | **GET** /stacks/{stackName}/versions/{stackVersion}/services/{serviceName}/configurations/{propertyName}/dependencies | Get all dependencies for a stack service configuration
[**StacksServiceGetStackConfigurations**](StacksApi.md#stacksservicegetstackconfigurations) | **GET** /stacks/{stackName}/versions/{stackVersion}/services/{serviceName}/configurations | Get all configurations for a stack service
[**StacksServiceGetStackLevelConfiguration**](StacksApi.md#stacksservicegetstacklevelconfiguration) | **GET** /stacks/{stackName}/versions/{stackVersion}/configurations/{propertyName} | Get configuration details for a given property
[**StacksServiceGetStackLevelConfigurations**](StacksApi.md#stacksservicegetstacklevelconfigurations) | **GET** /stacks/{stackName}/versions/{stackVersion}/configurations | Get all configurations for a stack version
[**StacksServiceGetStackService**](StacksApi.md#stacksservicegetstackservice) | **GET** /stacks/{stackName}/versions/{stackVersion}/services/{serviceName} | Get stack service details
[**StacksServiceGetStackServiceArtifact**](StacksApi.md#stacksservicegetstackserviceartifact) | **GET** /stacks/{stackName}/versions/{stackVersion}/services/{serviceName}/artifacts/{artifactName} | Get stack service artifact details
[**StacksServiceGetStackServiceArtifacts**](StacksApi.md#stacksservicegetstackserviceartifacts) | **GET** /stacks/{stackName}/versions/{stackVersion}/services/{serviceName}/artifacts | Get all artifacts for a stack service
[**StacksServiceGetStackServiceQuickLinksConfiguration**](StacksApi.md#stacksservicegetstackservicequicklinksconfiguration) | **GET** /stacks/{stackName}/versions/{stackVersion}/services/{serviceName}/quicklinks/{quickLinksConfigurationName} | Get quicklinks configuration details
[**StacksServiceGetStackServiceQuickLinksConfigurations**](StacksApi.md#stacksservicegetstackservicequicklinksconfigurations) | **GET** /stacks/{stackName}/versions/{stackVersion}/services/{serviceName}/quicklinks | Get all quicklinks configurations for a stack service
[**StacksServiceGetStackServiceTheme**](StacksApi.md#stacksservicegetstackservicetheme) | **GET** /stacks/{stackName}/versions/{stackVersion}/services/{serviceName}/themes/{themeName} | Get theme details for a stack service
[**StacksServiceGetStackServiceThemes**](StacksApi.md#stacksservicegetstackservicethemes) | **GET** /stacks/{stackName}/versions/{stackVersion}/services/{serviceName}/themes | Get all themes for a stack service
[**StacksServiceGetStackServices**](StacksApi.md#stacksservicegetstackservices) | **GET** /stacks/{stackName}/versions/{stackVersion}/services | Get all services for a stack version
[**StacksServiceGetStackVersion**](StacksApi.md#stacksservicegetstackversion) | **GET** /stacks/{stackName}/versions/{stackVersion} | Get details for a stack version
[**StacksServiceGetStackVersionLinks**](StacksApi.md#stacksservicegetstackversionlinks) | **GET** /stacks/{stackName}/versions/{stackVersion}/links | Get extension links for a stack version
[**StacksServiceGetStackVersions**](StacksApi.md#stacksservicegetstackversions) | **GET** /stacks/{stackName}/versions | Get all versions for a stacks
[**StacksServiceGetStacks**](StacksApi.md#stacksservicegetstacks) | **GET** /stacks | Get all stacks


<a name="stacksservicegetservicecomponent"></a>
# **StacksServiceGetServiceComponent**
> StackServiceComponentResponseSwagger StacksServiceGetServiceComponent (string stackName, string stackVersion, string serviceName, string componentName, string fields)

Get details for a stack service component

Returns details for a stack service component.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StacksServiceGetServiceComponentExample
    {
        public void main()
        {
            
            var apiInstance = new StacksApi();
            var stackName = stackName_example;  // string | 
            var stackVersion = stackVersion_example;  // string | 
            var serviceName = serviceName_example;  // string | 
            var componentName = componentName_example;  // string | 
            var fields = fields_example;  // string | Filter returned attributes (optional)  (default to StackServiceComponents/*)

            try
            {
                // Get details for a stack service component
                StackServiceComponentResponseSwagger result = apiInstance.StacksServiceGetServiceComponent(stackName, stackVersion, serviceName, componentName, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StacksApi.StacksServiceGetServiceComponent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stackName** | **string**|  | 
 **stackVersion** | **string**|  | 
 **serviceName** | **string**|  | 
 **componentName** | **string**|  | 
 **fields** | **string**| Filter returned attributes | [optional] [default to StackServiceComponents/*]

### Return type

[**StackServiceComponentResponseSwagger**](StackServiceComponentResponseSwagger.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stacksservicegetservicecomponentdependencies"></a>
# **StacksServiceGetServiceComponentDependencies**
> List<ComponentDependencyResponse> StacksServiceGetServiceComponentDependencies (string stackName, string stackVersion, string serviceName, string componentName, string fields, string sortBy, int? pageSize, string from, string to)

Get all dependencies for a stack service component

Returns all dependencies for a stack service component.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StacksServiceGetServiceComponentDependenciesExample
    {
        public void main()
        {
            
            var apiInstance = new StacksApi();
            var stackName = stackName_example;  // string | 
            var stackVersion = stackVersion_example;  // string | 
            var serviceName = serviceName_example;  // string | 
            var componentName = componentName_example;  // string | 
            var fields = fields_example;  // string | Filter returned attributes (optional)  (default to Dependencies/stack_name,Dependencies/stack_version,Dependencies/dependent_service_name,Dependencies/dependent_component_name,Dependencies/component_name)
            var sortBy = sortBy_example;  // string | Sort component dependencies (asc | desc) (optional)  (default to Dependencies/stack_name.asc,Dependencies/stack_version.asc,Dependencies/dependent_service_name.asc,Dependencies/dependent_component_name.asc,Dependencies/component_name.asc)
            var pageSize = 56;  // int? | The number of resources to be returned for the paged response. (optional)  (default to 10)
            var from = from_example;  // string | The starting page resource (inclusive).  \"start\" is also accepted. (optional)  (default to 0)
            var to = to_example;  // string | The ending page resource (inclusive).  \"end\" is also accepted. (optional) 

            try
            {
                // Get all dependencies for a stack service component
                List&lt;ComponentDependencyResponse&gt; result = apiInstance.StacksServiceGetServiceComponentDependencies(stackName, stackVersion, serviceName, componentName, fields, sortBy, pageSize, from, to);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StacksApi.StacksServiceGetServiceComponentDependencies: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stackName** | **string**|  | 
 **stackVersion** | **string**|  | 
 **serviceName** | **string**|  | 
 **componentName** | **string**|  | 
 **fields** | **string**| Filter returned attributes | [optional] [default to Dependencies/stack_name,Dependencies/stack_version,Dependencies/dependent_service_name,Dependencies/dependent_component_name,Dependencies/component_name]
 **sortBy** | **string**| Sort component dependencies (asc | desc) | [optional] [default to Dependencies/stack_name.asc,Dependencies/stack_version.asc,Dependencies/dependent_service_name.asc,Dependencies/dependent_component_name.asc,Dependencies/component_name.asc]
 **pageSize** | **int?**| The number of resources to be returned for the paged response. | [optional] [default to 10]
 **from** | **string**| The starting page resource (inclusive).  \&quot;start\&quot; is also accepted. | [optional] [default to 0]
 **to** | **string**| The ending page resource (inclusive).  \&quot;end\&quot; is also accepted. | [optional] 

### Return type

[**List<ComponentDependencyResponse>**](ComponentDependencyResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stacksservicegetservicecomponentdependency"></a>
# **StacksServiceGetServiceComponentDependency**
> ComponentDependencyResponse StacksServiceGetServiceComponentDependency (string stackName, string stackVersion, string serviceName, string componentName, string dependencyName, string fields)

Get a stack service component dependency

Returns a stack service component dependency.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StacksServiceGetServiceComponentDependencyExample
    {
        public void main()
        {
            
            var apiInstance = new StacksApi();
            var stackName = stackName_example;  // string | 
            var stackVersion = stackVersion_example;  // string | 
            var serviceName = serviceName_example;  // string | 
            var componentName = componentName_example;  // string | 
            var dependencyName = dependencyName_example;  // string | 
            var fields = fields_example;  // string | Filter returned attributes (optional)  (default to Dependencies/*)

            try
            {
                // Get a stack service component dependency
                ComponentDependencyResponse result = apiInstance.StacksServiceGetServiceComponentDependency(stackName, stackVersion, serviceName, componentName, dependencyName, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StacksApi.StacksServiceGetServiceComponentDependency: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stackName** | **string**|  | 
 **stackVersion** | **string**|  | 
 **serviceName** | **string**|  | 
 **componentName** | **string**|  | 
 **dependencyName** | **string**|  | 
 **fields** | **string**| Filter returned attributes | [optional] [default to Dependencies/*]

### Return type

[**ComponentDependencyResponse**](ComponentDependencyResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stacksservicegetservicecomponents"></a>
# **StacksServiceGetServiceComponents**
> List<StackServiceComponentResponseSwagger> StacksServiceGetServiceComponents (string stackName, string stackVersion, string serviceName, string fields, string sortBy, int? pageSize, string from, string to)

Get all components for a stack service

Returns all components for a stack service.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StacksServiceGetServiceComponentsExample
    {
        public void main()
        {
            
            var apiInstance = new StacksApi();
            var stackName = stackName_example;  // string | 
            var stackVersion = stackVersion_example;  // string | 
            var serviceName = serviceName_example;  // string | 
            var fields = fields_example;  // string | Filter returned attributes (optional)  (default to StackServiceComponents/component_name,StackServiceComponents/service_name,StackServiceComponents/stack_name,StackServiceComponents/stack_version)
            var sortBy = sortBy_example;  // string | Sort service components (asc | desc) (optional)  (default to StackServiceComponents/component_name.asc,StackServiceComponents/service_name.asc,StackServiceComponents/stack_name.asc,StackServiceComponents/stack_version.asc)
            var pageSize = 56;  // int? | The number of resources to be returned for the paged response. (optional)  (default to 10)
            var from = from_example;  // string | The starting page resource (inclusive).  \"start\" is also accepted. (optional)  (default to 0)
            var to = to_example;  // string | The ending page resource (inclusive).  \"end\" is also accepted. (optional) 

            try
            {
                // Get all components for a stack service
                List&lt;StackServiceComponentResponseSwagger&gt; result = apiInstance.StacksServiceGetServiceComponents(stackName, stackVersion, serviceName, fields, sortBy, pageSize, from, to);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StacksApi.StacksServiceGetServiceComponents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stackName** | **string**|  | 
 **stackVersion** | **string**|  | 
 **serviceName** | **string**|  | 
 **fields** | **string**| Filter returned attributes | [optional] [default to StackServiceComponents/component_name,StackServiceComponents/service_name,StackServiceComponents/stack_name,StackServiceComponents/stack_version]
 **sortBy** | **string**| Sort service components (asc | desc) | [optional] [default to StackServiceComponents/component_name.asc,StackServiceComponents/service_name.asc,StackServiceComponents/stack_name.asc,StackServiceComponents/stack_version.asc]
 **pageSize** | **int?**| The number of resources to be returned for the paged response. | [optional] [default to 10]
 **from** | **string**| The starting page resource (inclusive).  \&quot;start\&quot; is also accepted. | [optional] [default to 0]
 **to** | **string**| The ending page resource (inclusive).  \&quot;end\&quot; is also accepted. | [optional] 

### Return type

[**List<StackServiceComponentResponseSwagger>**](StackServiceComponentResponseSwagger.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stacksservicegetstack"></a>
# **StacksServiceGetStack**
> List<StackResponseSwagger> StacksServiceGetStack (string stackName, string fields)

Get a stack

Returns stack details.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StacksServiceGetStackExample
    {
        public void main()
        {
            
            var apiInstance = new StacksApi();
            var stackName = stackName_example;  // string | 
            var fields = fields_example;  // string | Filter stack details (optional)  (default to Stacks/*)

            try
            {
                // Get a stack
                List&lt;StackResponseSwagger&gt; result = apiInstance.StacksServiceGetStack(stackName, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StacksApi.StacksServiceGetStack: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stackName** | **string**|  | 
 **fields** | **string**| Filter stack details | [optional] [default to Stacks/*]

### Return type

[**List<StackResponseSwagger>**](StackResponseSwagger.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stacksservicegetstackartifact"></a>
# **StacksServiceGetStackArtifact**
> StackArtifactResponse StacksServiceGetStackArtifact (string stackName, string stackVersion, string artifactName, string fields)

Get stack artifact details

Returns the details of a stack artifact

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StacksServiceGetStackArtifactExample
    {
        public void main()
        {
            
            var apiInstance = new StacksApi();
            var stackName = stackName_example;  // string | 
            var stackVersion = stackVersion_example;  // string | 
            var artifactName = artifactName_example;  // string | 
            var fields = fields_example;  // string | Filter returned attributes (optional)  (default to Artifacts/*)

            try
            {
                // Get stack artifact details
                StackArtifactResponse result = apiInstance.StacksServiceGetStackArtifact(stackName, stackVersion, artifactName, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StacksApi.StacksServiceGetStackArtifact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stackName** | **string**|  | 
 **stackVersion** | **string**|  | 
 **artifactName** | **string**|  | 
 **fields** | **string**| Filter returned attributes | [optional] [default to Artifacts/*]

### Return type

[**StackArtifactResponse**](StackArtifactResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stacksservicegetstackartifacts"></a>
# **StacksServiceGetStackArtifacts**
> List<StackArtifactResponse> StacksServiceGetStackArtifacts (string stackName, string stackVersion, string fields)

Get all stack artifacts

Returns all stack artifacts (e.g: kerberos descriptor, metrics descriptor)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StacksServiceGetStackArtifactsExample
    {
        public void main()
        {
            
            var apiInstance = new StacksApi();
            var stackName = stackName_example;  // string | 
            var stackVersion = stackVersion_example;  // string | 
            var fields = fields_example;  // string | Filter returned attributes (optional)  (default to Artifacts/artifact_name,Artifacts/stack_name,Artifacts/stack_version)

            try
            {
                // Get all stack artifacts
                List&lt;StackArtifactResponse&gt; result = apiInstance.StacksServiceGetStackArtifacts(stackName, stackVersion, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StacksApi.StacksServiceGetStackArtifacts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stackName** | **string**|  | 
 **stackVersion** | **string**|  | 
 **fields** | **string**| Filter returned attributes | [optional] [default to Artifacts/artifact_name,Artifacts/stack_name,Artifacts/stack_version]

### Return type

[**List<StackArtifactResponse>**](StackArtifactResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stacksservicegetstackconfiguration"></a>
# **StacksServiceGetStackConfiguration**
> StackConfigurationResponseSwagger StacksServiceGetStackConfiguration (string stackName, string stackVersion, string serviceName, string propertyName, string fields)

Get stack service configuration details

Returns the details of a stack service configuration.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StacksServiceGetStackConfigurationExample
    {
        public void main()
        {
            
            var apiInstance = new StacksApi();
            var stackName = stackName_example;  // string | 
            var stackVersion = stackVersion_example;  // string | 
            var serviceName = serviceName_example;  // string | 
            var propertyName = propertyName_example;  // string | 
            var fields = fields_example;  // string | Filter returned attributes (optional)  (default to StackConfigurations/*)

            try
            {
                // Get stack service configuration details
                StackConfigurationResponseSwagger result = apiInstance.StacksServiceGetStackConfiguration(stackName, stackVersion, serviceName, propertyName, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StacksApi.StacksServiceGetStackConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stackName** | **string**|  | 
 **stackVersion** | **string**|  | 
 **serviceName** | **string**|  | 
 **propertyName** | **string**|  | 
 **fields** | **string**| Filter returned attributes | [optional] [default to StackConfigurations/*]

### Return type

[**StackConfigurationResponseSwagger**](StackConfigurationResponseSwagger.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stacksservicegetstackconfigurationdependencies"></a>
# **StacksServiceGetStackConfigurationDependencies**
> List<StackConfigurationDependencyResponseSwagger> StacksServiceGetStackConfigurationDependencies (string stackName, string stackVersion, string serviceName, string propertyName, string fields, string sortBy, int? pageSize, string from, string to)

Get all dependencies for a stack service configuration

Returns all dependencies for a stack service configuration.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StacksServiceGetStackConfigurationDependenciesExample
    {
        public void main()
        {
            
            var apiInstance = new StacksApi();
            var stackName = stackName_example;  // string | 
            var stackVersion = stackVersion_example;  // string | 
            var serviceName = serviceName_example;  // string | 
            var propertyName = propertyName_example;  // string | 
            var fields = fields_example;  // string | Filter returned attributes (optional)  (default to StackConfigurationDependency/stack_name,StackConfigurationDependency/stack_version,StackConfigurationDependency/service_name,StackConfigurationDependency/property_name,StackConfigurationDependency/dependency_name)
            var sortBy = sortBy_example;  // string | Sort configuration dependencies (asc | desc) (optional)  (default to StackConfigurationDependency/stack_name.asc,StackConfigurationDependency/stack_version.asc,StackConfigurationDependency/service_name.asc,StackConfigurationDependency/property_name.asc,StackConfigurationDependency/dependency_name.asc)
            var pageSize = 56;  // int? | The number of resources to be returned for the paged response. (optional)  (default to 10)
            var from = from_example;  // string | The starting page resource (inclusive).  \"start\" is also accepted. (optional)  (default to 0)
            var to = to_example;  // string | The ending page resource (inclusive).  \"end\" is also accepted. (optional) 

            try
            {
                // Get all dependencies for a stack service configuration
                List&lt;StackConfigurationDependencyResponseSwagger&gt; result = apiInstance.StacksServiceGetStackConfigurationDependencies(stackName, stackVersion, serviceName, propertyName, fields, sortBy, pageSize, from, to);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StacksApi.StacksServiceGetStackConfigurationDependencies: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stackName** | **string**|  | 
 **stackVersion** | **string**|  | 
 **serviceName** | **string**|  | 
 **propertyName** | **string**|  | 
 **fields** | **string**| Filter returned attributes | [optional] [default to StackConfigurationDependency/stack_name,StackConfigurationDependency/stack_version,StackConfigurationDependency/service_name,StackConfigurationDependency/property_name,StackConfigurationDependency/dependency_name]
 **sortBy** | **string**| Sort configuration dependencies (asc | desc) | [optional] [default to StackConfigurationDependency/stack_name.asc,StackConfigurationDependency/stack_version.asc,StackConfigurationDependency/service_name.asc,StackConfigurationDependency/property_name.asc,StackConfigurationDependency/dependency_name.asc]
 **pageSize** | **int?**| The number of resources to be returned for the paged response. | [optional] [default to 10]
 **from** | **string**| The starting page resource (inclusive).  \&quot;start\&quot; is also accepted. | [optional] [default to 0]
 **to** | **string**| The ending page resource (inclusive).  \&quot;end\&quot; is also accepted. | [optional] 

### Return type

[**List<StackConfigurationDependencyResponseSwagger>**](StackConfigurationDependencyResponseSwagger.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stacksservicegetstackconfigurations"></a>
# **StacksServiceGetStackConfigurations**
> List<StackConfigurationResponseSwagger> StacksServiceGetStackConfigurations (string stackName, string stackVersion, string serviceName, string fields, string sortBy, int? pageSize, string from, string to)

Get all configurations for a stack service

Returns all configurations for a stack service.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StacksServiceGetStackConfigurationsExample
    {
        public void main()
        {
            
            var apiInstance = new StacksApi();
            var stackName = stackName_example;  // string | 
            var stackVersion = stackVersion_example;  // string | 
            var serviceName = serviceName_example;  // string | 
            var fields = fields_example;  // string | Filter returned attributes (optional)  (default to StackConfigurations/property_name,StackConfigurations/service_name,StackConfigurations/stack_nameStackConfigurations/stack_version)
            var sortBy = sortBy_example;  // string | Sort service configurations (asc | desc) (optional)  (default to StackConfigurations/property_name.asc,StackConfigurations/service_name.asc,StackConfigurations/stack_name.ascStackConfigurations/stack_version.asc)
            var pageSize = 56;  // int? | The number of resources to be returned for the paged response. (optional)  (default to 10)
            var from = from_example;  // string | The starting page resource (inclusive).  \"start\" is also accepted. (optional)  (default to 0)
            var to = to_example;  // string | The ending page resource (inclusive).  \"end\" is also accepted. (optional) 

            try
            {
                // Get all configurations for a stack service
                List&lt;StackConfigurationResponseSwagger&gt; result = apiInstance.StacksServiceGetStackConfigurations(stackName, stackVersion, serviceName, fields, sortBy, pageSize, from, to);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StacksApi.StacksServiceGetStackConfigurations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stackName** | **string**|  | 
 **stackVersion** | **string**|  | 
 **serviceName** | **string**|  | 
 **fields** | **string**| Filter returned attributes | [optional] [default to StackConfigurations/property_name,StackConfigurations/service_name,StackConfigurations/stack_nameStackConfigurations/stack_version]
 **sortBy** | **string**| Sort service configurations (asc | desc) | [optional] [default to StackConfigurations/property_name.asc,StackConfigurations/service_name.asc,StackConfigurations/stack_name.ascStackConfigurations/stack_version.asc]
 **pageSize** | **int?**| The number of resources to be returned for the paged response. | [optional] [default to 10]
 **from** | **string**| The starting page resource (inclusive).  \&quot;start\&quot; is also accepted. | [optional] [default to 0]
 **to** | **string**| The ending page resource (inclusive).  \&quot;end\&quot; is also accepted. | [optional] 

### Return type

[**List<StackConfigurationResponseSwagger>**](StackConfigurationResponseSwagger.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stacksservicegetstacklevelconfiguration"></a>
# **StacksServiceGetStackLevelConfiguration**
> StackConfigurationResponseSwagger StacksServiceGetStackLevelConfiguration (string stackName, string stackVersion, string serviceName, string propertyName, string fields)

Get configuration details for a given property

Returns the configuration details for a given property.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StacksServiceGetStackLevelConfigurationExample
    {
        public void main()
        {
            
            var apiInstance = new StacksApi();
            var stackName = stackName_example;  // string | 
            var stackVersion = stackVersion_example;  // string | 
            var serviceName = serviceName_example;  // string | 
            var propertyName = propertyName_example;  // string | 
            var fields = fields_example;  // string | Filter returned attributes (optional)  (default to StackLevelConfigurations/*)

            try
            {
                // Get configuration details for a given property
                StackConfigurationResponseSwagger result = apiInstance.StacksServiceGetStackLevelConfiguration(stackName, stackVersion, serviceName, propertyName, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StacksApi.StacksServiceGetStackLevelConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stackName** | **string**|  | 
 **stackVersion** | **string**|  | 
 **serviceName** | **string**|  | 
 **propertyName** | **string**|  | 
 **fields** | **string**| Filter returned attributes | [optional] [default to StackLevelConfigurations/*]

### Return type

[**StackConfigurationResponseSwagger**](StackConfigurationResponseSwagger.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stacksservicegetstacklevelconfigurations"></a>
# **StacksServiceGetStackLevelConfigurations**
> List<StackConfigurationResponseSwagger> StacksServiceGetStackLevelConfigurations (string stackName, string stackVersion, string fields, string sortBy, int? pageSize, string from, string to)

Get all configurations for a stack version

Returns all configurations for a stack version.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StacksServiceGetStackLevelConfigurationsExample
    {
        public void main()
        {
            
            var apiInstance = new StacksApi();
            var stackName = stackName_example;  // string | 
            var stackVersion = stackVersion_example;  // string | 
            var fields = fields_example;  // string | Filter returned attributes (optional)  (default to StackLevelConfigurations/stack_name,StackLevelConfigurations/stack_version,StackLevelConfigurations/property_name)
            var sortBy = sortBy_example;  // string | Sort configuration (asc | desc) (optional)  (default to StackLevelConfigurations/stack_name.asc,StackLevelConfigurations/stack_version.asc,StackLevelConfigurations/property_name.asc )
            var pageSize = 56;  // int? | The number of resources to be returned for the paged response. (optional)  (default to 10)
            var from = from_example;  // string | The starting page resource (inclusive).  \"start\" is also accepted. (optional)  (default to 0)
            var to = to_example;  // string | The ending page resource (inclusive).  \"end\" is also accepted. (optional) 

            try
            {
                // Get all configurations for a stack version
                List&lt;StackConfigurationResponseSwagger&gt; result = apiInstance.StacksServiceGetStackLevelConfigurations(stackName, stackVersion, fields, sortBy, pageSize, from, to);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StacksApi.StacksServiceGetStackLevelConfigurations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stackName** | **string**|  | 
 **stackVersion** | **string**|  | 
 **fields** | **string**| Filter returned attributes | [optional] [default to StackLevelConfigurations/stack_name,StackLevelConfigurations/stack_version,StackLevelConfigurations/property_name]
 **sortBy** | **string**| Sort configuration (asc | desc) | [optional] [default to StackLevelConfigurations/stack_name.asc,StackLevelConfigurations/stack_version.asc,StackLevelConfigurations/property_name.asc ]
 **pageSize** | **int?**| The number of resources to be returned for the paged response. | [optional] [default to 10]
 **from** | **string**| The starting page resource (inclusive).  \&quot;start\&quot; is also accepted. | [optional] [default to 0]
 **to** | **string**| The ending page resource (inclusive).  \&quot;end\&quot; is also accepted. | [optional] 

### Return type

[**List<StackConfigurationResponseSwagger>**](StackConfigurationResponseSwagger.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stacksservicegetstackservice"></a>
# **StacksServiceGetStackService**
> StackServiceResponseSwagger StacksServiceGetStackService (string stackName, string stackVersion, string serviceName, string fields)

Get stack service details

Returns the details of a stack service.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StacksServiceGetStackServiceExample
    {
        public void main()
        {
            
            var apiInstance = new StacksApi();
            var stackName = stackName_example;  // string | 
            var stackVersion = stackVersion_example;  // string | 
            var serviceName = serviceName_example;  // string | 
            var fields = fields_example;  // string | Filter returned attributes (optional)  (default to StackServices/*)

            try
            {
                // Get stack service details
                StackServiceResponseSwagger result = apiInstance.StacksServiceGetStackService(stackName, stackVersion, serviceName, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StacksApi.StacksServiceGetStackService: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stackName** | **string**|  | 
 **stackVersion** | **string**|  | 
 **serviceName** | **string**|  | 
 **fields** | **string**| Filter returned attributes | [optional] [default to StackServices/*]

### Return type

[**StackServiceResponseSwagger**](StackServiceResponseSwagger.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stacksservicegetstackserviceartifact"></a>
# **StacksServiceGetStackServiceArtifact**
> StackArtifactResponse StacksServiceGetStackServiceArtifact (string stackName, string stackVersion, string serviceName, string artifactName, string fields)

Get stack service artifact details

Returns the details of a stack service artifact.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StacksServiceGetStackServiceArtifactExample
    {
        public void main()
        {
            
            var apiInstance = new StacksApi();
            var stackName = stackName_example;  // string | 
            var stackVersion = stackVersion_example;  // string | 
            var serviceName = serviceName_example;  // string | 
            var artifactName = artifactName_example;  // string | 
            var fields = fields_example;  // string | Filter returned attributes (optional)  (default to Artifacts/*)

            try
            {
                // Get stack service artifact details
                StackArtifactResponse result = apiInstance.StacksServiceGetStackServiceArtifact(stackName, stackVersion, serviceName, artifactName, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StacksApi.StacksServiceGetStackServiceArtifact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stackName** | **string**|  | 
 **stackVersion** | **string**|  | 
 **serviceName** | **string**|  | 
 **artifactName** | **string**|  | 
 **fields** | **string**| Filter returned attributes | [optional] [default to Artifacts/*]

### Return type

[**StackArtifactResponse**](StackArtifactResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stacksservicegetstackserviceartifacts"></a>
# **StacksServiceGetStackServiceArtifacts**
> List<StackServiceArtifactResponse> StacksServiceGetStackServiceArtifacts (string stackName, string stackVersion, string serviceName, string fields, string sortBy, int? pageSize, string from, string to)

Get all artifacts for a stack service

Returns all stack service artifacts

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StacksServiceGetStackServiceArtifactsExample
    {
        public void main()
        {
            
            var apiInstance = new StacksApi();
            var stackName = stackName_example;  // string | 
            var stackVersion = stackVersion_example;  // string | 
            var serviceName = serviceName_example;  // string | 
            var fields = fields_example;  // string | Filter returned attributes (optional)  (default to Artifacts/artifact_name,Artifacts/stack_name,Artifacts/stack_version)
            var sortBy = sortBy_example;  // string | Sort service artifacts (asc | desc) (optional)  (default to Artifacts/artifact_name.asc,Artifacts/stack_name.asc,Artifacts/stack_version.asc)
            var pageSize = 56;  // int? | The number of resources to be returned for the paged response. (optional)  (default to 10)
            var from = from_example;  // string | The starting page resource (inclusive).  \"start\" is also accepted. (optional)  (default to 0)
            var to = to_example;  // string | The ending page resource (inclusive).  \"end\" is also accepted. (optional) 

            try
            {
                // Get all artifacts for a stack service
                List&lt;StackServiceArtifactResponse&gt; result = apiInstance.StacksServiceGetStackServiceArtifacts(stackName, stackVersion, serviceName, fields, sortBy, pageSize, from, to);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StacksApi.StacksServiceGetStackServiceArtifacts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stackName** | **string**|  | 
 **stackVersion** | **string**|  | 
 **serviceName** | **string**|  | 
 **fields** | **string**| Filter returned attributes | [optional] [default to Artifacts/artifact_name,Artifacts/stack_name,Artifacts/stack_version]
 **sortBy** | **string**| Sort service artifacts (asc | desc) | [optional] [default to Artifacts/artifact_name.asc,Artifacts/stack_name.asc,Artifacts/stack_version.asc]
 **pageSize** | **int?**| The number of resources to be returned for the paged response. | [optional] [default to 10]
 **from** | **string**| The starting page resource (inclusive).  \&quot;start\&quot; is also accepted. | [optional] [default to 0]
 **to** | **string**| The ending page resource (inclusive).  \&quot;end\&quot; is also accepted. | [optional] 

### Return type

[**List<StackServiceArtifactResponse>**](StackServiceArtifactResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stacksservicegetstackservicequicklinksconfiguration"></a>
# **StacksServiceGetStackServiceQuickLinksConfiguration**
> List<QuickLinksResponse> StacksServiceGetStackServiceQuickLinksConfiguration (string stackName, string stackVersion, string serviceName, string quickLinksConfigurationName, string fields)

Get quicklinks configuration details

Returns the details of a quicklinks configuration.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StacksServiceGetStackServiceQuickLinksConfigurationExample
    {
        public void main()
        {
            
            var apiInstance = new StacksApi();
            var stackName = stackName_example;  // string | 
            var stackVersion = stackVersion_example;  // string | 
            var serviceName = serviceName_example;  // string | 
            var quickLinksConfigurationName = quickLinksConfigurationName_example;  // string | 
            var fields = fields_example;  // string | Filter returned attributes (optional)  (default to QuickLinkInfo/*)

            try
            {
                // Get quicklinks configuration details
                List&lt;QuickLinksResponse&gt; result = apiInstance.StacksServiceGetStackServiceQuickLinksConfiguration(stackName, stackVersion, serviceName, quickLinksConfigurationName, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StacksApi.StacksServiceGetStackServiceQuickLinksConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stackName** | **string**|  | 
 **stackVersion** | **string**|  | 
 **serviceName** | **string**|  | 
 **quickLinksConfigurationName** | **string**|  | 
 **fields** | **string**| Filter returned attributes | [optional] [default to QuickLinkInfo/*]

### Return type

[**List<QuickLinksResponse>**](QuickLinksResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stacksservicegetstackservicequicklinksconfigurations"></a>
# **StacksServiceGetStackServiceQuickLinksConfigurations**
> List<QuickLinksResponse> StacksServiceGetStackServiceQuickLinksConfigurations (string stackName, string stackVersion, string serviceName, string fields, string sortBy, int? pageSize, string from, string to)

Get all quicklinks configurations for a stack service

Returns all quicklinks configurations for a stack service.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StacksServiceGetStackServiceQuickLinksConfigurationsExample
    {
        public void main()
        {
            
            var apiInstance = new StacksApi();
            var stackName = stackName_example;  // string | 
            var stackVersion = stackVersion_example;  // string | 
            var serviceName = serviceName_example;  // string | 
            var fields = fields_example;  // string | Filter returned attributes (optional)  (default to QuickLinkInfo/file_name,QuickLinkInfo/service_name,QuickLinkInfo/stack_name,QuickLinkInfo/stack_version)
            var sortBy = sortBy_example;  // string | Sort quick links (asc | desc) (optional)  (default to QuickLinkInfo/file_name.asc,QuickLinkInfo/service_name.asc,QuickLinkInfo/stack_name.asc,QuickLinkInfo/stack_version.asc)
            var pageSize = 56;  // int? | The number of resources to be returned for the paged response. (optional)  (default to 10)
            var from = from_example;  // string | The starting page resource (inclusive).  \"start\" is also accepted. (optional)  (default to 0)
            var to = to_example;  // string | The ending page resource (inclusive).  \"end\" is also accepted. (optional) 

            try
            {
                // Get all quicklinks configurations for a stack service
                List&lt;QuickLinksResponse&gt; result = apiInstance.StacksServiceGetStackServiceQuickLinksConfigurations(stackName, stackVersion, serviceName, fields, sortBy, pageSize, from, to);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StacksApi.StacksServiceGetStackServiceQuickLinksConfigurations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stackName** | **string**|  | 
 **stackVersion** | **string**|  | 
 **serviceName** | **string**|  | 
 **fields** | **string**| Filter returned attributes | [optional] [default to QuickLinkInfo/file_name,QuickLinkInfo/service_name,QuickLinkInfo/stack_name,QuickLinkInfo/stack_version]
 **sortBy** | **string**| Sort quick links (asc | desc) | [optional] [default to QuickLinkInfo/file_name.asc,QuickLinkInfo/service_name.asc,QuickLinkInfo/stack_name.asc,QuickLinkInfo/stack_version.asc]
 **pageSize** | **int?**| The number of resources to be returned for the paged response. | [optional] [default to 10]
 **from** | **string**| The starting page resource (inclusive).  \&quot;start\&quot; is also accepted. | [optional] [default to 0]
 **to** | **string**| The ending page resource (inclusive).  \&quot;end\&quot; is also accepted. | [optional] 

### Return type

[**List<QuickLinksResponse>**](QuickLinksResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stacksservicegetstackservicetheme"></a>
# **StacksServiceGetStackServiceTheme**
> ThemeResponse StacksServiceGetStackServiceTheme (string stackName, string stackVersion, string serviceName, string themeName, string fields)

Get theme details for a stack service

Returns stack service theme details.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StacksServiceGetStackServiceThemeExample
    {
        public void main()
        {
            
            var apiInstance = new StacksApi();
            var stackName = stackName_example;  // string | 
            var stackVersion = stackVersion_example;  // string | 
            var serviceName = serviceName_example;  // string | 
            var themeName = themeName_example;  // string | 
            var fields = fields_example;  // string | Filter returned attributes (optional)  (default to ThemeInfo/*)

            try
            {
                // Get theme details for a stack service
                ThemeResponse result = apiInstance.StacksServiceGetStackServiceTheme(stackName, stackVersion, serviceName, themeName, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StacksApi.StacksServiceGetStackServiceTheme: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stackName** | **string**|  | 
 **stackVersion** | **string**|  | 
 **serviceName** | **string**|  | 
 **themeName** | **string**|  | 
 **fields** | **string**| Filter returned attributes | [optional] [default to ThemeInfo/*]

### Return type

[**ThemeResponse**](ThemeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stacksservicegetstackservicethemes"></a>
# **StacksServiceGetStackServiceThemes**
> List<ThemeResponse> StacksServiceGetStackServiceThemes (string stackName, string stackVersion, string serviceName, string fields, string sortBy, int? pageSize, string from, string to)

Get all themes for a stack service

Returns all stack themes

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StacksServiceGetStackServiceThemesExample
    {
        public void main()
        {
            
            var apiInstance = new StacksApi();
            var stackName = stackName_example;  // string | 
            var stackVersion = stackVersion_example;  // string | 
            var serviceName = serviceName_example;  // string | 
            var fields = fields_example;  // string | Filter returned attributes (optional)  (default to ThemeInfo/file_name,ThemeInfo/service_name,ThemeInfo/stack_name,ThemeInfo/stack_version)
            var sortBy = sortBy_example;  // string | Sort service artifacts (asc | desc) (optional)  (default to ThemeInfo/file_name.asc,ThemeInfo/service_name.asc,ThemeInfo/stack_name.asc,ThemeInfo/stack_version.asc)
            var pageSize = 56;  // int? | The number of resources to be returned for the paged response. (optional)  (default to 10)
            var from = from_example;  // string | The starting page resource (inclusive).  \"start\" is also accepted. (optional)  (default to 0)
            var to = to_example;  // string | The ending page resource (inclusive).  \"end\" is also accepted. (optional) 

            try
            {
                // Get all themes for a stack service
                List&lt;ThemeResponse&gt; result = apiInstance.StacksServiceGetStackServiceThemes(stackName, stackVersion, serviceName, fields, sortBy, pageSize, from, to);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StacksApi.StacksServiceGetStackServiceThemes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stackName** | **string**|  | 
 **stackVersion** | **string**|  | 
 **serviceName** | **string**|  | 
 **fields** | **string**| Filter returned attributes | [optional] [default to ThemeInfo/file_name,ThemeInfo/service_name,ThemeInfo/stack_name,ThemeInfo/stack_version]
 **sortBy** | **string**| Sort service artifacts (asc | desc) | [optional] [default to ThemeInfo/file_name.asc,ThemeInfo/service_name.asc,ThemeInfo/stack_name.asc,ThemeInfo/stack_version.asc]
 **pageSize** | **int?**| The number of resources to be returned for the paged response. | [optional] [default to 10]
 **from** | **string**| The starting page resource (inclusive).  \&quot;start\&quot; is also accepted. | [optional] [default to 0]
 **to** | **string**| The ending page resource (inclusive).  \&quot;end\&quot; is also accepted. | [optional] 

### Return type

[**List<ThemeResponse>**](ThemeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stacksservicegetstackservices"></a>
# **StacksServiceGetStackServices**
> List<StackServiceResponseSwagger> StacksServiceGetStackServices (string stackName, string stackVersion, string fields, string sortBy, int? pageSize, string from, string to)

Get all services for a stack version

Returns all services for a stack version.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StacksServiceGetStackServicesExample
    {
        public void main()
        {
            
            var apiInstance = new StacksApi();
            var stackName = stackName_example;  // string | 
            var stackVersion = stackVersion_example;  // string | 
            var fields = fields_example;  // string | Filter returned attributes (optional)  (default to StackServices/stack_name,StackServices/stack_version,StackServices/service_name)
            var sortBy = sortBy_example;  // string | Sort stack services (asc | desc) (optional)  (default to StackServices/stack_name.asc,StackServices/stack_version.asc,StackServices/service_name.asc)
            var pageSize = 56;  // int? | The number of resources to be returned for the paged response. (optional)  (default to 10)
            var from = from_example;  // string | The starting page resource (inclusive).  \"start\" is also accepted. (optional)  (default to 0)
            var to = to_example;  // string | The ending page resource (inclusive).  \"end\" is also accepted. (optional) 

            try
            {
                // Get all services for a stack version
                List&lt;StackServiceResponseSwagger&gt; result = apiInstance.StacksServiceGetStackServices(stackName, stackVersion, fields, sortBy, pageSize, from, to);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StacksApi.StacksServiceGetStackServices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stackName** | **string**|  | 
 **stackVersion** | **string**|  | 
 **fields** | **string**| Filter returned attributes | [optional] [default to StackServices/stack_name,StackServices/stack_version,StackServices/service_name]
 **sortBy** | **string**| Sort stack services (asc | desc) | [optional] [default to StackServices/stack_name.asc,StackServices/stack_version.asc,StackServices/service_name.asc]
 **pageSize** | **int?**| The number of resources to be returned for the paged response. | [optional] [default to 10]
 **from** | **string**| The starting page resource (inclusive).  \&quot;start\&quot; is also accepted. | [optional] [default to 0]
 **to** | **string**| The ending page resource (inclusive).  \&quot;end\&quot; is also accepted. | [optional] 

### Return type

[**List<StackServiceResponseSwagger>**](StackServiceResponseSwagger.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stacksservicegetstackversion"></a>
# **StacksServiceGetStackVersion**
> StackVersionResponseSwagger StacksServiceGetStackVersion (string stackName, string stackVersion, string fields)

Get details for a stack version

Returns the details for a stack version.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StacksServiceGetStackVersionExample
    {
        public void main()
        {
            
            var apiInstance = new StacksApi();
            var stackName = stackName_example;  // string | 
            var stackVersion = stackVersion_example;  // string | 
            var fields = fields_example;  // string | Filter stack version details (optional)  (default to Versions/*)

            try
            {
                // Get details for a stack version
                StackVersionResponseSwagger result = apiInstance.StacksServiceGetStackVersion(stackName, stackVersion, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StacksApi.StacksServiceGetStackVersion: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stackName** | **string**|  | 
 **stackVersion** | **string**|  | 
 **fields** | **string**| Filter stack version details | [optional] [default to Versions/*]

### Return type

[**StackVersionResponseSwagger**](StackVersionResponseSwagger.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stacksservicegetstackversionlinks"></a>
# **StacksServiceGetStackVersionLinks**
> List<ExtensionLinkResponse> StacksServiceGetStackVersionLinks (string stackName, string stackVersion, string fields, string sortBy, int? pageSize, string from, string to)

Get extension links for a stack version

Returns the extension links for a stack version.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StacksServiceGetStackVersionLinksExample
    {
        public void main()
        {
            
            var apiInstance = new StacksApi();
            var stackName = stackName_example;  // string | 
            var stackVersion = stackVersion_example;  // string | 
            var fields = fields_example;  // string | Filter extension link attributes (optional)  (default to ExtensionLink/link_id,ExtensionLink/stack_name,ExtensionLink/stack_version,ExtensionLink/extension_name,ExtensionLink/extension_version)
            var sortBy = sortBy_example;  // string | Sort extension links (asc | desc) (optional)  (default to ExtensionLink/link_id.asc,ExtensionLink/stack_name.asc,ExtensionLink/stack_version.asc,ExtensionLink/extension_name.asc,ExtensionLink/extension_version.asc)
            var pageSize = 56;  // int? | The number of resources to be returned for the paged response. (optional)  (default to 10)
            var from = from_example;  // string | The starting page resource (inclusive).  \"start\" is also accepted. (optional)  (default to 0)
            var to = to_example;  // string | The ending page resource (inclusive).  \"end\" is also accepted. (optional) 

            try
            {
                // Get extension links for a stack version
                List&lt;ExtensionLinkResponse&gt; result = apiInstance.StacksServiceGetStackVersionLinks(stackName, stackVersion, fields, sortBy, pageSize, from, to);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StacksApi.StacksServiceGetStackVersionLinks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stackName** | **string**|  | 
 **stackVersion** | **string**|  | 
 **fields** | **string**| Filter extension link attributes | [optional] [default to ExtensionLink/link_id,ExtensionLink/stack_name,ExtensionLink/stack_version,ExtensionLink/extension_name,ExtensionLink/extension_version]
 **sortBy** | **string**| Sort extension links (asc | desc) | [optional] [default to ExtensionLink/link_id.asc,ExtensionLink/stack_name.asc,ExtensionLink/stack_version.asc,ExtensionLink/extension_name.asc,ExtensionLink/extension_version.asc]
 **pageSize** | **int?**| The number of resources to be returned for the paged response. | [optional] [default to 10]
 **from** | **string**| The starting page resource (inclusive).  \&quot;start\&quot; is also accepted. | [optional] [default to 0]
 **to** | **string**| The ending page resource (inclusive).  \&quot;end\&quot; is also accepted. | [optional] 

### Return type

[**List<ExtensionLinkResponse>**](ExtensionLinkResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stacksservicegetstackversions"></a>
# **StacksServiceGetStackVersions**
> List<StackVersionResponseSwagger> StacksServiceGetStackVersions (string stackName, string fields, string sortBy, int? pageSize, string from, string to)

Get all versions for a stacks

Returns all versions for a stack.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StacksServiceGetStackVersionsExample
    {
        public void main()
        {
            
            var apiInstance = new StacksApi();
            var stackName = stackName_example;  // string | 
            var fields = fields_example;  // string | Filter stack version details (optional)  (default to Versions/stack_name,Versions/stack_version)
            var sortBy = sortBy_example;  // string | Sort stack privileges (asc | desc) (optional)  (default to Versions/stack_name.asc,Versions/stack_version.asc)
            var pageSize = 56;  // int? | The number of resources to be returned for the paged response. (optional)  (default to 10)
            var from = from_example;  // string | The starting page resource (inclusive).  \"start\" is also accepted. (optional)  (default to 0)
            var to = to_example;  // string | The ending page resource (inclusive).  \"end\" is also accepted. (optional) 

            try
            {
                // Get all versions for a stacks
                List&lt;StackVersionResponseSwagger&gt; result = apiInstance.StacksServiceGetStackVersions(stackName, fields, sortBy, pageSize, from, to);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StacksApi.StacksServiceGetStackVersions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stackName** | **string**|  | 
 **fields** | **string**| Filter stack version details | [optional] [default to Versions/stack_name,Versions/stack_version]
 **sortBy** | **string**| Sort stack privileges (asc | desc) | [optional] [default to Versions/stack_name.asc,Versions/stack_version.asc]
 **pageSize** | **int?**| The number of resources to be returned for the paged response. | [optional] [default to 10]
 **from** | **string**| The starting page resource (inclusive).  \&quot;start\&quot; is also accepted. | [optional] [default to 0]
 **to** | **string**| The ending page resource (inclusive).  \&quot;end\&quot; is also accepted. | [optional] 

### Return type

[**List<StackVersionResponseSwagger>**](StackVersionResponseSwagger.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stacksservicegetstacks"></a>
# **StacksServiceGetStacks**
> List<StackResponseSwagger> StacksServiceGetStacks (string fields, string sortBy, int? pageSize, string from, string to)

Get all stacks

Returns all stacks.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StacksServiceGetStacksExample
    {
        public void main()
        {
            
            var apiInstance = new StacksApi();
            var fields = fields_example;  // string | Filter stack details (optional)  (default to Stacks/stack_name)
            var sortBy = sortBy_example;  // string | Sort stack privileges (asc | desc) (optional)  (default to Stacks/stack_name.asc)
            var pageSize = 56;  // int? | The number of resources to be returned for the paged response. (optional)  (default to 10)
            var from = from_example;  // string | The starting page resource (inclusive).  \"start\" is also accepted. (optional)  (default to 0)
            var to = to_example;  // string | The ending page resource (inclusive).  \"end\" is also accepted. (optional) 

            try
            {
                // Get all stacks
                List&lt;StackResponseSwagger&gt; result = apiInstance.StacksServiceGetStacks(fields, sortBy, pageSize, from, to);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StacksApi.StacksServiceGetStacks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fields** | **string**| Filter stack details | [optional] [default to Stacks/stack_name]
 **sortBy** | **string**| Sort stack privileges (asc | desc) | [optional] [default to Stacks/stack_name.asc]
 **pageSize** | **int?**| The number of resources to be returned for the paged response. | [optional] [default to 10]
 **from** | **string**| The starting page resource (inclusive).  \&quot;start\&quot; is also accepted. | [optional] [default to 0]
 **to** | **string**| The ending page resource (inclusive).  \&quot;end\&quot; is also accepted. | [optional] 

### Return type

[**List<StackResponseSwagger>**](StackResponseSwagger.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

