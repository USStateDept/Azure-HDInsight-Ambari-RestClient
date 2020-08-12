# IO.Swagger.Api.RequestSchedulesApi

All URIs are relative to *https://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateRequestSchedule**](RequestSchedulesApi.md#createrequestschedule) | **POST** /clusters/{clusterName}/request_schedules | Create new request schedule
[**DeleteRequestSchedule**](RequestSchedulesApi.md#deleterequestschedule) | **DELETE** /clusters/{clusterName}/request_schedules/{requestScheduleId} | Delete a request schedule
[**GetRequestSchedule**](RequestSchedulesApi.md#getrequestschedule) | **GET** /clusters/{clusterName}/request_schedules/{requestScheduleId} | Get request schedule
[**GetRequestSchedules**](RequestSchedulesApi.md#getrequestschedules) | **GET** /clusters/{clusterName}/request_schedules | Get all request schedules


<a name="createrequestschedule"></a>
# **CreateRequestSchedule**
> void CreateRequestSchedule (string clusterName, RequestScheduleRequestSwagger body)

Create new request schedule



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateRequestScheduleExample
    {
        public void main()
        {
            
            var apiInstance = new RequestSchedulesApi();
            var clusterName = clusterName_example;  // string | 
            var body = new RequestScheduleRequestSwagger(); // RequestScheduleRequestSwagger |  (optional) 

            try
            {
                // Create new request schedule
                apiInstance.CreateRequestSchedule(clusterName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RequestSchedulesApi.CreateRequestSchedule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clusterName** | **string**|  | 
 **body** | [**RequestScheduleRequestSwagger**](RequestScheduleRequestSwagger.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleterequestschedule"></a>
# **DeleteRequestSchedule**
> void DeleteRequestSchedule (string requestScheduleId, string clusterName)

Delete a request schedule

Changes status from COMPLETED to DISABLED

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteRequestScheduleExample
    {
        public void main()
        {
            
            var apiInstance = new RequestSchedulesApi();
            var requestScheduleId = requestScheduleId_example;  // string | 
            var clusterName = clusterName_example;  // string | 

            try
            {
                // Delete a request schedule
                apiInstance.DeleteRequestSchedule(requestScheduleId, clusterName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RequestSchedulesApi.DeleteRequestSchedule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestScheduleId** | **string**|  | 
 **clusterName** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrequestschedule"></a>
# **GetRequestSchedule**
> RequestScheduleResponseSwagger GetRequestSchedule (string requestScheduleId, string clusterName, string fields)

Get request schedule



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRequestScheduleExample
    {
        public void main()
        {
            
            var apiInstance = new RequestSchedulesApi();
            var requestScheduleId = requestScheduleId_example;  // string | 
            var clusterName = clusterName_example;  // string | 
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional)  (default to RequestSchedule/*)

            try
            {
                // Get request schedule
                RequestScheduleResponseSwagger result = apiInstance.GetRequestSchedule(requestScheduleId, clusterName, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RequestSchedulesApi.GetRequestSchedule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestScheduleId** | **string**|  | 
 **clusterName** | **string**|  | 
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] [default to RequestSchedule/*]

### Return type

[**RequestScheduleResponseSwagger**](RequestScheduleResponseSwagger.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrequestschedules"></a>
# **GetRequestSchedules**
> List<RequestScheduleResponseSwagger> GetRequestSchedules (string clusterName, string fields)

Get all request schedules



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRequestSchedulesExample
    {
        public void main()
        {
            
            var apiInstance = new RequestSchedulesApi();
            var clusterName = clusterName_example;  // string | 
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional)  (default to RequestSchedule/*)

            try
            {
                // Get all request schedules
                List&lt;RequestScheduleResponseSwagger&gt; result = apiInstance.GetRequestSchedules(clusterName, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RequestSchedulesApi.GetRequestSchedules: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clusterName** | **string**|  | 
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] [default to RequestSchedule/*]

### Return type

[**List<RequestScheduleResponseSwagger>**](RequestScheduleResponseSwagger.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

