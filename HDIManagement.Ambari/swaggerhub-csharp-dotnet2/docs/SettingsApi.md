# IO.Swagger.Api.SettingsApi

All URIs are relative to *https://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSetting**](SettingsApi.md#createsetting) | **POST** /settings | Creates a setting
[**DeleteSetting**](SettingsApi.md#deletesetting) | **DELETE** /settings/{settingName} | Deletes a setting
[**GetSetting**](SettingsApi.md#getsetting) | **GET** /settings/{settingName} | Returns a specific setting
[**GetSettings**](SettingsApi.md#getsettings) | **GET** /settings | Returns all settings
[**UpdateSetting**](SettingsApi.md#updatesetting) | **PUT** /settings/{settingName} | Updates a setting


<a name="createsetting"></a>
# **CreateSetting**
> void CreateSetting (SettingRequestSwagger body)

Creates a setting



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateSettingExample
    {
        public void main()
        {
            
            var apiInstance = new SettingsApi();
            var body = new SettingRequestSwagger(); // SettingRequestSwagger | 

            try
            {
                // Creates a setting
                apiInstance.CreateSetting(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SettingsApi.CreateSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SettingRequestSwagger**](SettingRequestSwagger.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesetting"></a>
# **DeleteSetting**
> void DeleteSetting (string settingName)

Deletes a setting



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteSettingExample
    {
        public void main()
        {
            
            var apiInstance = new SettingsApi();
            var settingName = settingName_example;  // string | setting name

            try
            {
                // Deletes a setting
                apiInstance.DeleteSetting(settingName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SettingsApi.DeleteSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **settingName** | **string**| setting name | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsetting"></a>
# **GetSetting**
> SettingResponseWrapper GetSetting (string settingName, string fields, string sortBy, int? pageSize, int? from, int? to)

Returns a specific setting



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSettingExample
    {
        public void main()
        {
            
            var apiInstance = new SettingsApi();
            var settingName = settingName_example;  // string | setting name
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional)  (default to Settings/*)
            var sortBy = sortBy_example;  // string | Sort resources in result by (asc | desc) (optional) 
            var pageSize = 56;  // int? | The number of resources to be returned for the paged response. (optional)  (default to 10)
            var from = 56;  // int? | The starting page resource (inclusive).  \"start\" is also accepted. (optional)  (default to 0)
            var to = 56;  // int? | The ending page resource (inclusive).  \"end\" is also accepted. (optional) 

            try
            {
                // Returns a specific setting
                SettingResponseWrapper result = apiInstance.GetSetting(settingName, fields, sortBy, pageSize, from, to);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SettingsApi.GetSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **settingName** | **string**| setting name | 
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] [default to Settings/*]
 **sortBy** | **string**| Sort resources in result by (asc | desc) | [optional] 
 **pageSize** | **int?**| The number of resources to be returned for the paged response. | [optional] [default to 10]
 **from** | **int?**| The starting page resource (inclusive).  \&quot;start\&quot; is also accepted. | [optional] [default to 0]
 **to** | **int?**| The ending page resource (inclusive).  \&quot;end\&quot; is also accepted. | [optional] 

### Return type

[**SettingResponseWrapper**](SettingResponseWrapper.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsettings"></a>
# **GetSettings**
> List<SettingResponseWrapper> GetSettings (string fields, string sortBy, int? pageSize, int? from, int? to)

Returns all settings



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSettingsExample
    {
        public void main()
        {
            
            var apiInstance = new SettingsApi();
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional)  (default to Settings/name)
            var sortBy = sortBy_example;  // string | Sort resources in result by (asc | desc) (optional) 
            var pageSize = 56;  // int? | The number of resources to be returned for the paged response. (optional)  (default to 10)
            var from = 56;  // int? | The starting page resource (inclusive).  \"start\" is also accepted. (optional)  (default to 0)
            var to = 56;  // int? | The ending page resource (inclusive).  \"end\" is also accepted. (optional) 

            try
            {
                // Returns all settings
                List&lt;SettingResponseWrapper&gt; result = apiInstance.GetSettings(fields, sortBy, pageSize, from, to);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SettingsApi.GetSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] [default to Settings/name]
 **sortBy** | **string**| Sort resources in result by (asc | desc) | [optional] 
 **pageSize** | **int?**| The number of resources to be returned for the paged response. | [optional] [default to 10]
 **from** | **int?**| The starting page resource (inclusive).  \&quot;start\&quot; is also accepted. | [optional] [default to 0]
 **to** | **int?**| The ending page resource (inclusive).  \&quot;end\&quot; is also accepted. | [optional] 

### Return type

[**List<SettingResponseWrapper>**](SettingResponseWrapper.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesetting"></a>
# **UpdateSetting**
> void UpdateSetting (string settingName, SettingRequestSwagger body)

Updates a setting



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateSettingExample
    {
        public void main()
        {
            
            var apiInstance = new SettingsApi();
            var settingName = settingName_example;  // string | setting name
            var body = new SettingRequestSwagger(); // SettingRequestSwagger | 

            try
            {
                // Updates a setting
                apiInstance.UpdateSetting(settingName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SettingsApi.UpdateSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **settingName** | **string**| setting name | 
 **body** | [**SettingRequestSwagger**](SettingRequestSwagger.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

