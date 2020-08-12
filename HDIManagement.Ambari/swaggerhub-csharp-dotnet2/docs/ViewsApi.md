# IO.Swagger.Api.ViewsApi

All URIs are relative to *https://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePrivilege**](ViewsApi.md#createprivilege) | **POST** /views/{viewName}/versions/{version}/instances/{instanceName}/privileges | Create view instance privilege
[**CreateService**](ViewsApi.md#createservice) | **POST** /views/{viewName}/versions/{version}/instances/{instanceName} | Create view instance
[**CreateServices**](ViewsApi.md#createservices) | **POST** /views/{viewName}/versions/{version}/instances | Create view instances
[**CreateUrl**](ViewsApi.md#createurl) | **POST** /view/urls/{urlName} | Create view URL
[**DeletePrivilege**](ViewsApi.md#deleteprivilege) | **DELETE** /views/{viewName}/versions/{version}/instances/{instanceName}/privileges/{privilegeId} | Delete privileges
[**DeletePrivileges**](ViewsApi.md#deleteprivileges) | **DELETE** /views/{viewName}/versions/{version}/instances/{instanceName}/privileges | Delete view instance privileges
[**DeleteService**](ViewsApi.md#deleteservice) | **DELETE** /views/{viewName}/versions/{version}/instances/{instanceName} | Delete view instance
[**DeleteUrl**](ViewsApi.md#deleteurl) | **DELETE** /view/urls/{urlName} | Delete view URL
[**GetPermission**](ViewsApi.md#getpermission) | **GET** /views/{viewName}/versions/{version}/permissions/{permissionId} | Get single view permission
[**GetPermissions**](ViewsApi.md#getpermissions) | **GET** /views/{viewName}/versions/{version}/permissions | Get all permissions for a view
[**GetPrivilege**](ViewsApi.md#getprivilege) | **GET** /views/{viewName}/versions/{version}/instances/{instanceName}/privileges/{privilegeId} | Get single view instance privilege
[**GetPrivileges**](ViewsApi.md#getprivileges) | **GET** /views/{viewName}/versions/{version}/instances/{instanceName}/privileges | Get all view instance privileges
[**GetService**](ViewsApi.md#getservice) | **GET** /views/{viewName}/versions/{version}/instances/{instanceName} | Get single view instance
[**GetServices**](ViewsApi.md#getservices) | **GET** /views/{viewName}/versions/{version}/instances | Get all view instances
[**GetVersion**](ViewsApi.md#getversion) | **GET** /views/{viewName}/versions/{version} | Get single view version
[**GetVersions**](ViewsApi.md#getversions) | **GET** /views/{viewName}/versions | Get all versions for a view
[**GetView**](ViewsApi.md#getview) | **GET** /views/{viewName} | Get single view
[**GetViewUrl**](ViewsApi.md#getviewurl) | **GET** /view/urls/{urlName} | Get single view URL
[**GetViewUrls**](ViewsApi.md#getviewurls) | **GET** /view/urls | Get all view URLs
[**GetViews**](ViewsApi.md#getviews) | **GET** /views | Get all views
[**MigrateData**](ViewsApi.md#migratedata) | **PUT** /views/{viewName}/versions/{version}/instances/{instanceName}/migrate/{originVersion}/{originInstanceName} | Migrate view instance data
[**UpdatePrivileges**](ViewsApi.md#updateprivileges) | **PUT** /views/{viewName}/versions/{version}/instances/{instanceName}/privileges | Update view instance privilege
[**UpdateService**](ViewsApi.md#updateservice) | **PUT** /views/{viewName}/versions/{version}/instances/{instanceName} | Update view instance detail
[**UpdateServices**](ViewsApi.md#updateservices) | **PUT** /views/{viewName}/versions/{version}/instances | Update multiple view instance detail
[**UpdateUrl**](ViewsApi.md#updateurl) | **PUT** /view/urls/{urlName} | Update view URL


<a name="createprivilege"></a>
# **CreatePrivilege**
> void CreatePrivilege (string viewName, string version, string instanceName, ViewPrivilegeService body)

Create view instance privilege



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreatePrivilegeExample
    {
        public void main()
        {
            
            var apiInstance = new ViewsApi();
            var viewName = viewName_example;  // string | view name
            var version = version_example;  // string | view version
            var instanceName = instanceName_example;  // string | instance name
            var body = new ViewPrivilegeService(); // ViewPrivilegeService |  (optional) 

            try
            {
                // Create view instance privilege
                apiInstance.CreatePrivilege(viewName, version, instanceName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.CreatePrivilege: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **viewName** | **string**| view name | 
 **version** | **string**| view version | 
 **instanceName** | **string**| instance name | 
 **body** | [**ViewPrivilegeService**](ViewPrivilegeService.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createservice"></a>
# **CreateService**
> void CreateService (string viewName, string version, string instanceName, ViewInstanceResponse body)

Create view instance



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateServiceExample
    {
        public void main()
        {
            
            var apiInstance = new ViewsApi();
            var viewName = viewName_example;  // string | view name
            var version = version_example;  // string | 
            var instanceName = instanceName_example;  // string | instance name
            var body = new ViewInstanceResponse(); // ViewInstanceResponse |  (optional) 

            try
            {
                // Create view instance
                apiInstance.CreateService(viewName, version, instanceName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.CreateService: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **viewName** | **string**| view name | 
 **version** | **string**|  | 
 **instanceName** | **string**| instance name | 
 **body** | [**ViewInstanceResponse**](ViewInstanceResponse.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createservices"></a>
# **CreateServices**
> void CreateServices (string viewName, string version, ViewInstanceResponse body)

Create view instances



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateServicesExample
    {
        public void main()
        {
            
            var apiInstance = new ViewsApi();
            var viewName = viewName_example;  // string | 
            var version = version_example;  // string | 
            var body = new ViewInstanceResponse(); // ViewInstanceResponse |  (optional) 

            try
            {
                // Create view instances
                apiInstance.CreateServices(viewName, version, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.CreateServices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **viewName** | **string**|  | 
 **version** | **string**|  | 
 **body** | [**ViewInstanceResponse**](ViewInstanceResponse.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createurl"></a>
# **CreateUrl**
> void CreateUrl (string urlName, ViewUrlResponseSwagger body)

Create view URL



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateUrlExample
    {
        public void main()
        {
            
            var apiInstance = new ViewsApi();
            var urlName = urlName_example;  // string | 
            var body = new ViewUrlResponseSwagger(); // ViewUrlResponseSwagger |  (optional) 

            try
            {
                // Create view URL
                apiInstance.CreateUrl(urlName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.CreateUrl: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **urlName** | **string**|  | 
 **body** | [**ViewUrlResponseSwagger**](ViewUrlResponseSwagger.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteprivilege"></a>
# **DeletePrivilege**
> void DeletePrivilege (string viewName, string version, string instanceName, string privilegeId)

Delete privileges



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeletePrivilegeExample
    {
        public void main()
        {
            
            var apiInstance = new ViewsApi();
            var viewName = viewName_example;  // string | view name
            var version = version_example;  // string | view version
            var instanceName = instanceName_example;  // string | instance name
            var privilegeId = privilegeId_example;  // string | privilege id

            try
            {
                // Delete privileges
                apiInstance.DeletePrivilege(viewName, version, instanceName, privilegeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.DeletePrivilege: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **viewName** | **string**| view name | 
 **version** | **string**| view version | 
 **instanceName** | **string**| instance name | 
 **privilegeId** | **string**| privilege id | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteprivileges"></a>
# **DeletePrivileges**
> void DeletePrivileges (string viewName, string viewVersion, string instanceName)

Delete view instance privileges



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeletePrivilegesExample
    {
        public void main()
        {
            
            var apiInstance = new ViewsApi();
            var viewName = viewName_example;  // string | view name
            var viewVersion = viewVersion_example;  // string | view version
            var instanceName = instanceName_example;  // string | instance name

            try
            {
                // Delete view instance privileges
                apiInstance.DeletePrivileges(viewName, viewVersion, instanceName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.DeletePrivileges: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **viewName** | **string**| view name | 
 **viewVersion** | **string**| view version | 
 **instanceName** | **string**| instance name | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteservice"></a>
# **DeleteService**
> void DeleteService (string viewName, string version, string instanceName)

Delete view instance



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteServiceExample
    {
        public void main()
        {
            
            var apiInstance = new ViewsApi();
            var viewName = viewName_example;  // string | view name
            var version = version_example;  // string | 
            var instanceName = instanceName_example;  // string | instance name

            try
            {
                // Delete view instance
                apiInstance.DeleteService(viewName, version, instanceName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.DeleteService: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **viewName** | **string**| view name | 
 **version** | **string**|  | 
 **instanceName** | **string**| instance name | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteurl"></a>
# **DeleteUrl**
> void DeleteUrl (string urlName)

Delete view URL



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteUrlExample
    {
        public void main()
        {
            
            var apiInstance = new ViewsApi();
            var urlName = urlName_example;  // string | 

            try
            {
                // Delete view URL
                apiInstance.DeleteUrl(urlName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.DeleteUrl: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **urlName** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpermission"></a>
# **GetPermission**
> ViewPermissionResponse GetPermission (string viewName, string version, string permissionId, string fields)

Get single view permission



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPermissionExample
    {
        public void main()
        {
            
            var apiInstance = new ViewsApi();
            var viewName = viewName_example;  // string | view name
            var version = version_example;  // string | view version
            var permissionId = permissionId_example;  // string | permission id
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional)  (default to PermissionInfo/*)

            try
            {
                // Get single view permission
                ViewPermissionResponse result = apiInstance.GetPermission(viewName, version, permissionId, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.GetPermission: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **viewName** | **string**| view name | 
 **version** | **string**| view version | 
 **permissionId** | **string**| permission id | 
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] [default to PermissionInfo/*]

### Return type

[**ViewPermissionResponse**](ViewPermissionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpermissions"></a>
# **GetPermissions**
> List<ViewPermissionResponse> GetPermissions (string viewName, string version, string fields, string sortBy, int? pageSize, int? from, int? to)

Get all permissions for a view



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPermissionsExample
    {
        public void main()
        {
            
            var apiInstance = new ViewsApi();
            var viewName = viewName_example;  // string | view name
            var version = version_example;  // string | view version
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional)  (default to PermissionInfo/*)
            var sortBy = sortBy_example;  // string | Sort resources in result by (asc | desc) (optional) 
            var pageSize = 56;  // int? | The number of resources to be returned for the paged response. (optional)  (default to 10)
            var from = 56;  // int? | The starting page resource (inclusive).  \"start\" is also accepted. (optional)  (default to 0)
            var to = 56;  // int? | The ending page resource (inclusive).  \"end\" is also accepted. (optional) 

            try
            {
                // Get all permissions for a view
                List&lt;ViewPermissionResponse&gt; result = apiInstance.GetPermissions(viewName, version, fields, sortBy, pageSize, from, to);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.GetPermissions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **viewName** | **string**| view name | 
 **version** | **string**| view version | 
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] [default to PermissionInfo/*]
 **sortBy** | **string**| Sort resources in result by (asc | desc) | [optional] 
 **pageSize** | **int?**| The number of resources to be returned for the paged response. | [optional] [default to 10]
 **from** | **int?**| The starting page resource (inclusive).  \&quot;start\&quot; is also accepted. | [optional] [default to 0]
 **to** | **int?**| The ending page resource (inclusive).  \&quot;end\&quot; is also accepted. | [optional] 

### Return type

[**List<ViewPermissionResponse>**](ViewPermissionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprivilege"></a>
# **GetPrivilege**
> ViewPrivilegeResponseWrapper GetPrivilege (string viewName, string version, string instanceName, string privilegeId, string fields)

Get single view instance privilege



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPrivilegeExample
    {
        public void main()
        {
            
            var apiInstance = new ViewsApi();
            var viewName = viewName_example;  // string | view name
            var version = version_example;  // string | view version
            var instanceName = instanceName_example;  // string | instance name
            var privilegeId = privilegeId_example;  // string | privilege id
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional)  (default to PrivilegeInfo/*)

            try
            {
                // Get single view instance privilege
                ViewPrivilegeResponseWrapper result = apiInstance.GetPrivilege(viewName, version, instanceName, privilegeId, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.GetPrivilege: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **viewName** | **string**| view name | 
 **version** | **string**| view version | 
 **instanceName** | **string**| instance name | 
 **privilegeId** | **string**| privilege id | 
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] [default to PrivilegeInfo/*]

### Return type

[**ViewPrivilegeResponseWrapper**](ViewPrivilegeResponseWrapper.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprivileges"></a>
# **GetPrivileges**
> List<ViewPrivilegeResponseWrapper> GetPrivileges (string viewName, string version, string instanceName, string fields, string sortBy, int? pageSize, int? from, int? to)

Get all view instance privileges



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPrivilegesExample
    {
        public void main()
        {
            
            var apiInstance = new ViewsApi();
            var viewName = viewName_example;  // string | view name
            var version = version_example;  // string | view version
            var instanceName = instanceName_example;  // string | instance name
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional)  (default to PrivilegeInfo/*)
            var sortBy = sortBy_example;  // string | Sort resources in result by (asc | desc) (optional) 
            var pageSize = 56;  // int? | The number of resources to be returned for the paged response. (optional)  (default to 10)
            var from = 56;  // int? | The starting page resource (inclusive).  \"start\" is also accepted. (optional)  (default to 0)
            var to = 56;  // int? | The ending page resource (inclusive).  \"end\" is also accepted. (optional) 

            try
            {
                // Get all view instance privileges
                List&lt;ViewPrivilegeResponseWrapper&gt; result = apiInstance.GetPrivileges(viewName, version, instanceName, fields, sortBy, pageSize, from, to);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.GetPrivileges: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **viewName** | **string**| view name | 
 **version** | **string**| view version | 
 **instanceName** | **string**| instance name | 
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] [default to PrivilegeInfo/*]
 **sortBy** | **string**| Sort resources in result by (asc | desc) | [optional] 
 **pageSize** | **int?**| The number of resources to be returned for the paged response. | [optional] [default to 10]
 **from** | **int?**| The starting page resource (inclusive).  \&quot;start\&quot; is also accepted. | [optional] [default to 0]
 **to** | **int?**| The ending page resource (inclusive).  \&quot;end\&quot; is also accepted. | [optional] 

### Return type

[**List<ViewPrivilegeResponseWrapper>**](ViewPrivilegeResponseWrapper.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getservice"></a>
# **GetService**
> ViewInstanceResponse GetService (string viewName, string version, string instanceName, string fields)

Get single view instance



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetServiceExample
    {
        public void main()
        {
            
            var apiInstance = new ViewsApi();
            var viewName = viewName_example;  // string | view name
            var version = version_example;  // string | 
            var instanceName = instanceName_example;  // string | instance name
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional)  (default to ViewInstanceInfo/*)

            try
            {
                // Get single view instance
                ViewInstanceResponse result = apiInstance.GetService(viewName, version, instanceName, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.GetService: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **viewName** | **string**| view name | 
 **version** | **string**|  | 
 **instanceName** | **string**| instance name | 
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] [default to ViewInstanceInfo/*]

### Return type

[**ViewInstanceResponse**](ViewInstanceResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getservices"></a>
# **GetServices**
> List<ViewInstanceResponse> GetServices (string viewName, string version, string fields, string sortBy, int? pageSize, int? from, int? to)

Get all view instances



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetServicesExample
    {
        public void main()
        {
            
            var apiInstance = new ViewsApi();
            var viewName = viewName_example;  // string | 
            var version = version_example;  // string | 
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional)  (default to ViewInstanceInfo/*)
            var sortBy = sortBy_example;  // string | Sort resources in result by (asc | desc) (optional) 
            var pageSize = 56;  // int? | The number of resources to be returned for the paged response. (optional)  (default to 10)
            var from = 56;  // int? | The starting page resource (inclusive).  \"start\" is also accepted. (optional)  (default to 0)
            var to = 56;  // int? | The ending page resource (inclusive).  \"end\" is also accepted. (optional) 

            try
            {
                // Get all view instances
                List&lt;ViewInstanceResponse&gt; result = apiInstance.GetServices(viewName, version, fields, sortBy, pageSize, from, to);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.GetServices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **viewName** | **string**|  | 
 **version** | **string**|  | 
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] [default to ViewInstanceInfo/*]
 **sortBy** | **string**| Sort resources in result by (asc | desc) | [optional] 
 **pageSize** | **int?**| The number of resources to be returned for the paged response. | [optional] [default to 10]
 **from** | **int?**| The starting page resource (inclusive).  \&quot;start\&quot; is also accepted. | [optional] [default to 0]
 **to** | **int?**| The ending page resource (inclusive).  \&quot;end\&quot; is also accepted. | [optional] 

### Return type

[**List<ViewInstanceResponse>**](ViewInstanceResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getversion"></a>
# **GetVersion**
> ViewVersionResponse GetVersion (string viewName, string version, string fields)

Get single view version



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetVersionExample
    {
        public void main()
        {
            
            var apiInstance = new ViewsApi();
            var viewName = viewName_example;  // string | view name
            var version = version_example;  // string | 
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional)  (default to ViewVersionInfo/*)

            try
            {
                // Get single view version
                ViewVersionResponse result = apiInstance.GetVersion(viewName, version, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.GetVersion: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **viewName** | **string**| view name | 
 **version** | **string**|  | 
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] [default to ViewVersionInfo/*]

### Return type

[**ViewVersionResponse**](ViewVersionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getversions"></a>
# **GetVersions**
> List<ViewVersionResponse> GetVersions (string viewName, string fields, string sortBy, int? pageSize, int? from, int? to)

Get all versions for a view



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetVersionsExample
    {
        public void main()
        {
            
            var apiInstance = new ViewsApi();
            var viewName = viewName_example;  // string | view name
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional)  (default to ViewVersionInfo/*)
            var sortBy = sortBy_example;  // string | Sort resources in result by (asc | desc) (optional) 
            var pageSize = 56;  // int? | The number of resources to be returned for the paged response. (optional)  (default to 10)
            var from = 56;  // int? | The starting page resource (inclusive).  \"start\" is also accepted. (optional)  (default to 0)
            var to = 56;  // int? | The ending page resource (inclusive).  \"end\" is also accepted. (optional) 

            try
            {
                // Get all versions for a view
                List&lt;ViewVersionResponse&gt; result = apiInstance.GetVersions(viewName, fields, sortBy, pageSize, from, to);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.GetVersions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **viewName** | **string**| view name | 
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] [default to ViewVersionInfo/*]
 **sortBy** | **string**| Sort resources in result by (asc | desc) | [optional] 
 **pageSize** | **int?**| The number of resources to be returned for the paged response. | [optional] [default to 10]
 **from** | **int?**| The starting page resource (inclusive).  \&quot;start\&quot; is also accepted. | [optional] [default to 0]
 **to** | **int?**| The ending page resource (inclusive).  \&quot;end\&quot; is also accepted. | [optional] 

### Return type

[**List<ViewVersionResponse>**](ViewVersionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getview"></a>
# **GetView**
> ViewResponse GetView (string viewName, string fields)

Get single view



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetViewExample
    {
        public void main()
        {
            
            var apiInstance = new ViewsApi();
            var viewName = viewName_example;  // string | view name
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional)  (default to Views/*)

            try
            {
                // Get single view
                ViewResponse result = apiInstance.GetView(viewName, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.GetView: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **viewName** | **string**| view name | 
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] [default to Views/*]

### Return type

[**ViewResponse**](ViewResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getviewurl"></a>
# **GetViewUrl**
> ViewUrlResponseSwagger GetViewUrl (string urlName, string fields)

Get single view URL



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetViewUrlExample
    {
        public void main()
        {
            
            var apiInstance = new ViewsApi();
            var urlName = urlName_example;  // string | 
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional)  (default to ViewUrlInfo/*)

            try
            {
                // Get single view URL
                ViewUrlResponseSwagger result = apiInstance.GetViewUrl(urlName, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.GetViewUrl: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **urlName** | **string**|  | 
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] [default to ViewUrlInfo/*]

### Return type

[**ViewUrlResponseSwagger**](ViewUrlResponseSwagger.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getviewurls"></a>
# **GetViewUrls**
> List<ViewUrlResponseSwagger> GetViewUrls (string fields, string sortBy, int? pageSize, int? from, int? to)

Get all view URLs



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetViewUrlsExample
    {
        public void main()
        {
            
            var apiInstance = new ViewsApi();
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional)  (default to ViewUrlInfo/*)
            var sortBy = sortBy_example;  // string | Sort resources in result by (asc | desc) (optional) 
            var pageSize = 56;  // int? | The number of resources to be returned for the paged response. (optional)  (default to 10)
            var from = 56;  // int? | The starting page resource (inclusive).  \"start\" is also accepted. (optional)  (default to 0)
            var to = 56;  // int? | The ending page resource (inclusive).  \"end\" is also accepted. (optional) 

            try
            {
                // Get all view URLs
                List&lt;ViewUrlResponseSwagger&gt; result = apiInstance.GetViewUrls(fields, sortBy, pageSize, from, to);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.GetViewUrls: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] [default to ViewUrlInfo/*]
 **sortBy** | **string**| Sort resources in result by (asc | desc) | [optional] 
 **pageSize** | **int?**| The number of resources to be returned for the paged response. | [optional] [default to 10]
 **from** | **int?**| The starting page resource (inclusive).  \&quot;start\&quot; is also accepted. | [optional] [default to 0]
 **to** | **int?**| The ending page resource (inclusive).  \&quot;end\&quot; is also accepted. | [optional] 

### Return type

[**List<ViewUrlResponseSwagger>**](ViewUrlResponseSwagger.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getviews"></a>
# **GetViews**
> List<ViewResponse> GetViews (string fields, string sortBy, int? pageSize, int? from, int? to)

Get all views

Returns details of all views.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetViewsExample
    {
        public void main()
        {
            
            var apiInstance = new ViewsApi();
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional)  (default to Views/*)
            var sortBy = sortBy_example;  // string | Sort resources in result by (asc | desc) (optional)  (default to Views/view_name.asc)
            var pageSize = 56;  // int? | The number of resources to be returned for the paged response. (optional)  (default to 10)
            var from = 56;  // int? | The starting page resource (inclusive).  \"start\" is also accepted. (optional)  (default to 0)
            var to = 56;  // int? | The ending page resource (inclusive).  \"end\" is also accepted. (optional) 

            try
            {
                // Get all views
                List&lt;ViewResponse&gt; result = apiInstance.GetViews(fields, sortBy, pageSize, from, to);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.GetViews: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] [default to Views/*]
 **sortBy** | **string**| Sort resources in result by (asc | desc) | [optional] [default to Views/view_name.asc]
 **pageSize** | **int?**| The number of resources to be returned for the paged response. | [optional] [default to 10]
 **from** | **int?**| The starting page resource (inclusive).  \&quot;start\&quot; is also accepted. | [optional] [default to 0]
 **to** | **int?**| The ending page resource (inclusive).  \&quot;end\&quot; is also accepted. | [optional] 

### Return type

[**List<ViewResponse>**](ViewResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="migratedata"></a>
# **MigrateData**
> void MigrateData (string viewName, string version, string instanceName, string originVersion, string originInstanceName)

Migrate view instance data

Migrates view instance persistence data from origin view instance specified in the path params.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MigrateDataExample
    {
        public void main()
        {
            
            var apiInstance = new ViewsApi();
            var viewName = viewName_example;  // string | view name
            var version = version_example;  // string | view version
            var instanceName = instanceName_example;  // string | instance name
            var originVersion = originVersion_example;  // string | origin version
            var originInstanceName = originInstanceName_example;  // string | origin instance name

            try
            {
                // Migrate view instance data
                apiInstance.MigrateData(viewName, version, instanceName, originVersion, originInstanceName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.MigrateData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **viewName** | **string**| view name | 
 **version** | **string**| view version | 
 **instanceName** | **string**| instance name | 
 **originVersion** | **string**| origin version | 
 **originInstanceName** | **string**| origin instance name | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateprivileges"></a>
# **UpdatePrivileges**
> void UpdatePrivileges (string viewName, string version, string instanceName, ViewPrivilegeService body)

Update view instance privilege



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdatePrivilegesExample
    {
        public void main()
        {
            
            var apiInstance = new ViewsApi();
            var viewName = viewName_example;  // string | view name
            var version = version_example;  // string | view version
            var instanceName = instanceName_example;  // string | instance name
            var body = new ViewPrivilegeService(); // ViewPrivilegeService |  (optional) 

            try
            {
                // Update view instance privilege
                apiInstance.UpdatePrivileges(viewName, version, instanceName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.UpdatePrivileges: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **viewName** | **string**| view name | 
 **version** | **string**| view version | 
 **instanceName** | **string**| instance name | 
 **body** | [**ViewPrivilegeService**](ViewPrivilegeService.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateservice"></a>
# **UpdateService**
> void UpdateService (string viewName, string version, string instanceName, ViewInstanceResponse body)

Update view instance detail



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateServiceExample
    {
        public void main()
        {
            
            var apiInstance = new ViewsApi();
            var viewName = viewName_example;  // string | view name
            var version = version_example;  // string | 
            var instanceName = instanceName_example;  // string | instance name
            var body = new ViewInstanceResponse(); // ViewInstanceResponse |  (optional) 

            try
            {
                // Update view instance detail
                apiInstance.UpdateService(viewName, version, instanceName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.UpdateService: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **viewName** | **string**| view name | 
 **version** | **string**|  | 
 **instanceName** | **string**| instance name | 
 **body** | [**ViewInstanceResponse**](ViewInstanceResponse.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateservices"></a>
# **UpdateServices**
> void UpdateServices (string viewName, string version, ViewInstanceResponse body)

Update multiple view instance detail



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateServicesExample
    {
        public void main()
        {
            
            var apiInstance = new ViewsApi();
            var viewName = viewName_example;  // string | 
            var version = version_example;  // string | 
            var body = new ViewInstanceResponse(); // ViewInstanceResponse |  (optional) 

            try
            {
                // Update multiple view instance detail
                apiInstance.UpdateServices(viewName, version, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.UpdateServices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **viewName** | **string**|  | 
 **version** | **string**|  | 
 **body** | [**ViewInstanceResponse**](ViewInstanceResponse.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateurl"></a>
# **UpdateUrl**
> void UpdateUrl (string urlName, ViewUrlResponseSwagger body)

Update view URL



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateUrlExample
    {
        public void main()
        {
            
            var apiInstance = new ViewsApi();
            var urlName = urlName_example;  // string | 
            var body = new ViewUrlResponseSwagger(); // ViewUrlResponseSwagger |  (optional) 

            try
            {
                // Update view URL
                apiInstance.UpdateUrl(urlName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.UpdateUrl: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **urlName** | **string**|  | 
 **body** | [**ViewUrlResponseSwagger**](ViewUrlResponseSwagger.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

