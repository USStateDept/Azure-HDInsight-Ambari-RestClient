# IO.Swagger.Api.ActionsApi

All URIs are relative to *https://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActionServiceCreateActionDefinition**](ActionsApi.md#actionservicecreateactiondefinition) | **POST** /actions/{actionName} | Creates an action definition - Currently Not Supported
[**ActionServiceDeleteActionDefinition**](ActionsApi.md#actionservicedeleteactiondefinition) | **DELETE** /actions/{actionName} | Deletes an action definition - Currently Not Supported
[**ActionServiceGetActionDefinition**](ActionsApi.md#actionservicegetactiondefinition) | **GET** /actions/{actionName} | Get the details of an action definition
[**ActionServiceGetActionDefinitions**](ActionsApi.md#actionservicegetactiondefinitions) | **GET** /actions | Get all action definitions
[**ActionServiceUpdateActionDefinition**](ActionsApi.md#actionserviceupdateactiondefinition) | **PUT** /actions/{actionName} | Updates an action definition - Currently Not Supported


<a name="actionservicecreateactiondefinition"></a>
# **ActionServiceCreateActionDefinition**
> void ActionServiceCreateActionDefinition (string actionName, ActionRequestSwagger body)

Creates an action definition - Currently Not Supported



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ActionServiceCreateActionDefinitionExample
    {
        public void main()
        {
            
            var apiInstance = new ActionsApi();
            var actionName = actionName_example;  // string | 
            var body = new ActionRequestSwagger(); // ActionRequestSwagger |  (optional) 

            try
            {
                // Creates an action definition - Currently Not Supported
                apiInstance.ActionServiceCreateActionDefinition(actionName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionServiceCreateActionDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **actionName** | **string**|  | 
 **body** | [**ActionRequestSwagger**](ActionRequestSwagger.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionservicedeleteactiondefinition"></a>
# **ActionServiceDeleteActionDefinition**
> void ActionServiceDeleteActionDefinition (string actionName)

Deletes an action definition - Currently Not Supported



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ActionServiceDeleteActionDefinitionExample
    {
        public void main()
        {
            
            var apiInstance = new ActionsApi();
            var actionName = actionName_example;  // string | 

            try
            {
                // Deletes an action definition - Currently Not Supported
                apiInstance.ActionServiceDeleteActionDefinition(actionName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionServiceDeleteActionDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **actionName** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionservicegetactiondefinition"></a>
# **ActionServiceGetActionDefinition**
> ActionResponseSwagger ActionServiceGetActionDefinition (string actionName, string fields)

Get the details of an action definition



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ActionServiceGetActionDefinitionExample
    {
        public void main()
        {
            
            var apiInstance = new ActionsApi();
            var actionName = actionName_example;  // string | 
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional)  (default to Actions/*)

            try
            {
                // Get the details of an action definition
                ActionResponseSwagger result = apiInstance.ActionServiceGetActionDefinition(actionName, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionServiceGetActionDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **actionName** | **string**|  | 
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] [default to Actions/*]

### Return type

[**ActionResponseSwagger**](ActionResponseSwagger.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionservicegetactiondefinitions"></a>
# **ActionServiceGetActionDefinitions**
> List<ActionResponseSwagger> ActionServiceGetActionDefinitions (string fields, string sortBy, int? pageSize, string from, string to)

Get all action definitions



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ActionServiceGetActionDefinitionsExample
    {
        public void main()
        {
            
            var apiInstance = new ActionsApi();
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional)  (default to Actions/action_name)
            var sortBy = sortBy_example;  // string | Sort resources in result by (asc | desc) (optional)  (default to Actions/action_name.asc)
            var pageSize = 56;  // int? | The number of resources to be returned for the paged response. (optional)  (default to 10)
            var from = from_example;  // string | The starting page resource (inclusive).  \"start\" is also accepted. (optional)  (default to 0)
            var to = to_example;  // string | The ending page resource (inclusive).  \"end\" is also accepted. (optional) 

            try
            {
                // Get all action definitions
                List&lt;ActionResponseSwagger&gt; result = apiInstance.ActionServiceGetActionDefinitions(fields, sortBy, pageSize, from, to);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionServiceGetActionDefinitions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] [default to Actions/action_name]
 **sortBy** | **string**| Sort resources in result by (asc | desc) | [optional] [default to Actions/action_name.asc]
 **pageSize** | **int?**| The number of resources to be returned for the paged response. | [optional] [default to 10]
 **from** | **string**| The starting page resource (inclusive).  \&quot;start\&quot; is also accepted. | [optional] [default to 0]
 **to** | **string**| The ending page resource (inclusive).  \&quot;end\&quot; is also accepted. | [optional] 

### Return type

[**List<ActionResponseSwagger>**](ActionResponseSwagger.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionserviceupdateactiondefinition"></a>
# **ActionServiceUpdateActionDefinition**
> void ActionServiceUpdateActionDefinition (string actionName, ActionRequestSwagger body)

Updates an action definition - Currently Not Supported



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ActionServiceUpdateActionDefinitionExample
    {
        public void main()
        {
            
            var apiInstance = new ActionsApi();
            var actionName = actionName_example;  // string | 
            var body = new ActionRequestSwagger(); // ActionRequestSwagger |  (optional) 

            try
            {
                // Updates an action definition - Currently Not Supported
                apiInstance.ActionServiceUpdateActionDefinition(actionName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionServiceUpdateActionDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **actionName** | **string**|  | 
 **body** | [**ActionRequestSwagger**](ActionRequestSwagger.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

