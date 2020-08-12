# IO.Swagger.Api.RootServiceConfigurationsApi

All URIs are relative to *https://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RootServiceComponentConfigurationServiceDeleteConfiguration**](RootServiceConfigurationsApi.md#rootservicecomponentconfigurationservicedeleteconfiguration) | **DELETE** /services/{serviceName}/components/{componentName}/configurations/{category} | Deletes a root service component configuration resource
[**RootServiceComponentConfigurationServiceGetConfiguration**](RootServiceConfigurationsApi.md#rootservicecomponentconfigurationservicegetconfiguration) | **GET** /services/{serviceName}/components/{componentName}/configurations/{category} | Retrieve the details of a root service component configuration resource
[**RootServiceComponentConfigurationServiceUpdateConfiguration**](RootServiceConfigurationsApi.md#rootservicecomponentconfigurationserviceupdateconfiguration) | **PUT** /services/{serviceName}/components/{componentName}/configurations/{category} | Updates root service component configuration resources 


<a name="rootservicecomponentconfigurationservicedeleteconfiguration"></a>
# **RootServiceComponentConfigurationServiceDeleteConfiguration**
> void RootServiceComponentConfigurationServiceDeleteConfiguration (string category, string serviceName, string componentName)

Deletes a root service component configuration resource



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RootServiceComponentConfigurationServiceDeleteConfigurationExample
    {
        public void main()
        {
            
            var apiInstance = new RootServiceConfigurationsApi();
            var category = category_example;  // string | 
            var serviceName = serviceName_example;  // string | 
            var componentName = componentName_example;  // string | 

            try
            {
                // Deletes a root service component configuration resource
                apiInstance.RootServiceComponentConfigurationServiceDeleteConfiguration(category, serviceName, componentName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RootServiceConfigurationsApi.RootServiceComponentConfigurationServiceDeleteConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **category** | **string**|  | 
 **serviceName** | **string**|  | 
 **componentName** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rootservicecomponentconfigurationservicegetconfiguration"></a>
# **RootServiceComponentConfigurationServiceGetConfiguration**
> RootServiceComponentConfigurationResponseSwagger RootServiceComponentConfigurationServiceGetConfiguration (string category, string serviceName, string componentName, string fields)

Retrieve the details of a root service component configuration resource



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RootServiceComponentConfigurationServiceGetConfigurationExample
    {
        public void main()
        {
            
            var apiInstance = new RootServiceConfigurationsApi();
            var category = category_example;  // string | 
            var serviceName = serviceName_example;  // string | 
            var componentName = componentName_example;  // string | 
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional)  (default to Configuration/*)

            try
            {
                // Retrieve the details of a root service component configuration resource
                RootServiceComponentConfigurationResponseSwagger result = apiInstance.RootServiceComponentConfigurationServiceGetConfiguration(category, serviceName, componentName, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RootServiceConfigurationsApi.RootServiceComponentConfigurationServiceGetConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **category** | **string**|  | 
 **serviceName** | **string**|  | 
 **componentName** | **string**|  | 
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] [default to Configuration/*]

### Return type

[**RootServiceComponentConfigurationResponseSwagger**](RootServiceComponentConfigurationResponseSwagger.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rootservicecomponentconfigurationserviceupdateconfiguration"></a>
# **RootServiceComponentConfigurationServiceUpdateConfiguration**
> void RootServiceComponentConfigurationServiceUpdateConfiguration (string category, string serviceName, string componentName, RootServiceComponentConfigurationRequestSwagger body, string fields)

Updates root service component configuration resources 



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RootServiceComponentConfigurationServiceUpdateConfigurationExample
    {
        public void main()
        {
            
            var apiInstance = new RootServiceConfigurationsApi();
            var category = category_example;  // string | 
            var serviceName = serviceName_example;  // string | 
            var componentName = componentName_example;  // string | 
            var body = new RootServiceComponentConfigurationRequestSwagger(); // RootServiceComponentConfigurationRequestSwagger |  (optional) 
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional)  (default to Configuration/*)

            try
            {
                // Updates root service component configuration resources 
                apiInstance.RootServiceComponentConfigurationServiceUpdateConfiguration(category, serviceName, componentName, body, fields);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RootServiceConfigurationsApi.RootServiceComponentConfigurationServiceUpdateConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **category** | **string**|  | 
 **serviceName** | **string**|  | 
 **componentName** | **string**|  | 
 **body** | [**RootServiceComponentConfigurationRequestSwagger**](RootServiceComponentConfigurationRequestSwagger.md)|  | [optional] 
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] [default to Configuration/*]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

