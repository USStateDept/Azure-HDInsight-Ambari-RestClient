# IO.Swagger.Api.BlueprintsApi

All URIs are relative to *https://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BlueprintServiceCreateBlueprint**](BlueprintsApi.md#blueprintservicecreateblueprint) | **POST** /blueprints/{blueprintName} | Creates a blueprint
[**BlueprintServiceDeleteBlueprint**](BlueprintsApi.md#blueprintservicedeleteblueprint) | **DELETE** /blueprints/{blueprintName} | Deletes a blueprint
[**BlueprintServiceDeleteBlueprints**](BlueprintsApi.md#blueprintservicedeleteblueprints) | **DELETE** /blueprints | Deletes multiple blueprints that match the predicate. Omitting the predicate will delete all blueprints.
[**BlueprintServiceGetBlueprint**](BlueprintsApi.md#blueprintservicegetblueprint) | **GET** /blueprints/{blueprintName} | Get the details of a blueprint
[**BlueprintServiceGetBlueprints**](BlueprintsApi.md#blueprintservicegetblueprints) | **GET** /blueprints | Get all blueprints


<a name="blueprintservicecreateblueprint"></a>
# **BlueprintServiceCreateBlueprint**
> void BlueprintServiceCreateBlueprint (string blueprintName, BlueprintSwagger body)

Creates a blueprint



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BlueprintServiceCreateBlueprintExample
    {
        public void main()
        {
            
            var apiInstance = new BlueprintsApi();
            var blueprintName = blueprintName_example;  // string | 
            var body = new BlueprintSwagger(); // BlueprintSwagger |  (optional) 

            try
            {
                // Creates a blueprint
                apiInstance.BlueprintServiceCreateBlueprint(blueprintName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BlueprintsApi.BlueprintServiceCreateBlueprint: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **blueprintName** | **string**|  | 
 **body** | [**BlueprintSwagger**](BlueprintSwagger.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="blueprintservicedeleteblueprint"></a>
# **BlueprintServiceDeleteBlueprint**
> void BlueprintServiceDeleteBlueprint (string blueprintName)

Deletes a blueprint



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BlueprintServiceDeleteBlueprintExample
    {
        public void main()
        {
            
            var apiInstance = new BlueprintsApi();
            var blueprintName = blueprintName_example;  // string | 

            try
            {
                // Deletes a blueprint
                apiInstance.BlueprintServiceDeleteBlueprint(blueprintName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BlueprintsApi.BlueprintServiceDeleteBlueprint: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **blueprintName** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="blueprintservicedeleteblueprints"></a>
# **BlueprintServiceDeleteBlueprints**
> void BlueprintServiceDeleteBlueprints ()

Deletes multiple blueprints that match the predicate. Omitting the predicate will delete all blueprints.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BlueprintServiceDeleteBlueprintsExample
    {
        public void main()
        {
            
            var apiInstance = new BlueprintsApi();

            try
            {
                // Deletes multiple blueprints that match the predicate. Omitting the predicate will delete all blueprints.
                apiInstance.BlueprintServiceDeleteBlueprints();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BlueprintsApi.BlueprintServiceDeleteBlueprints: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="blueprintservicegetblueprint"></a>
# **BlueprintServiceGetBlueprint**
> List<BlueprintSwagger> BlueprintServiceGetBlueprint (string blueprintName, string fields)

Get the details of a blueprint



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BlueprintServiceGetBlueprintExample
    {
        public void main()
        {
            
            var apiInstance = new BlueprintsApi();
            var blueprintName = blueprintName_example;  // string | 
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional)  (default to Blueprints/*)

            try
            {
                // Get the details of a blueprint
                List&lt;BlueprintSwagger&gt; result = apiInstance.BlueprintServiceGetBlueprint(blueprintName, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BlueprintsApi.BlueprintServiceGetBlueprint: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **blueprintName** | **string**|  | 
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] [default to Blueprints/*]

### Return type

[**List<BlueprintSwagger>**](BlueprintSwagger.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="blueprintservicegetblueprints"></a>
# **BlueprintServiceGetBlueprints**
> List<BlueprintSwagger> BlueprintServiceGetBlueprints (string fields, string sortBy, int? pageSize, string from, string to)

Get all blueprints



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BlueprintServiceGetBlueprintsExample
    {
        public void main()
        {
            
            var apiInstance = new BlueprintsApi();
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional)  (default to Blueprints/blueprint_name)
            var sortBy = sortBy_example;  // string | Sort resources in result by (asc | desc) (optional)  (default to Blueprints/blueprint_name.asc)
            var pageSize = 56;  // int? | The number of resources to be returned for the paged response. (optional)  (default to 10)
            var from = from_example;  // string | The starting page resource (inclusive).  \"start\" is also accepted. (optional)  (default to 0)
            var to = to_example;  // string | The ending page resource (inclusive).  \"end\" is also accepted. (optional) 

            try
            {
                // Get all blueprints
                List&lt;BlueprintSwagger&gt; result = apiInstance.BlueprintServiceGetBlueprints(fields, sortBy, pageSize, from, to);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BlueprintsApi.BlueprintServiceGetBlueprints: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] [default to Blueprints/blueprint_name]
 **sortBy** | **string**| Sort resources in result by (asc | desc) | [optional] [default to Blueprints/blueprint_name.asc]
 **pageSize** | **int?**| The number of resources to be returned for the paged response. | [optional] [default to 10]
 **from** | **string**| The starting page resource (inclusive).  \&quot;start\&quot; is also accepted. | [optional] [default to 0]
 **to** | **string**| The ending page resource (inclusive).  \&quot;end\&quot; is also accepted. | [optional] 

### Return type

[**List<BlueprintSwagger>**](BlueprintSwagger.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

