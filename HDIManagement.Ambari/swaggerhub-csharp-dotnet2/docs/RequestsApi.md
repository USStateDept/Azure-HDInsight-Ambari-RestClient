# IO.Swagger.Api.RequestsApi

All URIs are relative to *https://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RequestServiceCreateRequests**](RequestsApi.md#requestservicecreaterequests) | **POST** /requests | Creates one or more Requests
[**RequestServiceGetRequest**](RequestsApi.md#requestservicegetrequest) | **GET** /requests/{requestId} | Get the details of a request
[**RequestServiceGetRequests**](RequestsApi.md#requestservicegetrequests) | **GET** /requests | Get all requests. A predicate can be given to filter results.
[**RequestServiceUpdateRequests**](RequestsApi.md#requestserviceupdaterequests) | **PUT** /requests/{requestId} | Updates a request, usually used to cancel running requests.


<a name="requestservicecreaterequests"></a>
# **RequestServiceCreateRequests**
> void RequestServiceCreateRequests (RequestPostRequest body)

Creates one or more Requests



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RequestServiceCreateRequestsExample
    {
        public void main()
        {
            
            var apiInstance = new RequestsApi();
            var body = new RequestPostRequest(); // RequestPostRequest |  (optional) 

            try
            {
                // Creates one or more Requests
                apiInstance.RequestServiceCreateRequests(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RequestsApi.RequestServiceCreateRequests: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RequestPostRequest**](RequestPostRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="requestservicegetrequest"></a>
# **RequestServiceGetRequest**
> RequestResponse RequestServiceGetRequest (string requestId, string fields)

Get the details of a request



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RequestServiceGetRequestExample
    {
        public void main()
        {
            
            var apiInstance = new RequestsApi();
            var requestId = requestId_example;  // string | 
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional)  (default to Requests/*)

            try
            {
                // Get the details of a request
                RequestResponse result = apiInstance.RequestServiceGetRequest(requestId, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RequestsApi.RequestServiceGetRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestId** | **string**|  | 
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] [default to Requests/*]

### Return type

[**RequestResponse**](RequestResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="requestservicegetrequests"></a>
# **RequestServiceGetRequests**
> List<RequestResponse> RequestServiceGetRequests (string fields, string sortBy, int? pageSize, string from, string to)

Get all requests. A predicate can be given to filter results.



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RequestServiceGetRequestsExample
    {
        public void main()
        {
            
            var apiInstance = new RequestsApi();
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional)  (default to Requests/id)
            var sortBy = sortBy_example;  // string | Sort resources in result by (asc | desc) (optional)  (default to Requests/id.asc)
            var pageSize = 56;  // int? | The number of resources to be returned for the paged response. (optional)  (default to 10)
            var from = from_example;  // string | The starting page resource (inclusive).  \"start\" is also accepted. (optional)  (default to 0)
            var to = to_example;  // string | The ending page resource (inclusive).  \"end\" is also accepted. (optional) 

            try
            {
                // Get all requests. A predicate can be given to filter results.
                List&lt;RequestResponse&gt; result = apiInstance.RequestServiceGetRequests(fields, sortBy, pageSize, from, to);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RequestsApi.RequestServiceGetRequests: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] [default to Requests/id]
 **sortBy** | **string**| Sort resources in result by (asc | desc) | [optional] [default to Requests/id.asc]
 **pageSize** | **int?**| The number of resources to be returned for the paged response. | [optional] [default to 10]
 **from** | **string**| The starting page resource (inclusive).  \&quot;start\&quot; is also accepted. | [optional] [default to 0]
 **to** | **string**| The ending page resource (inclusive).  \&quot;end\&quot; is also accepted. | [optional] 

### Return type

[**List<RequestResponse>**](RequestResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="requestserviceupdaterequests"></a>
# **RequestServiceUpdateRequests**
> void RequestServiceUpdateRequests (string requestId, RequestPutRequest body)

Updates a request, usually used to cancel running requests.

Changes the state of an existing request. Usually used to cancel running requests.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RequestServiceUpdateRequestsExample
    {
        public void main()
        {
            
            var apiInstance = new RequestsApi();
            var requestId = requestId_example;  // string | 
            var body = new RequestPutRequest(); // RequestPutRequest |  (optional) 

            try
            {
                // Updates a request, usually used to cancel running requests.
                apiInstance.RequestServiceUpdateRequests(requestId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RequestsApi.RequestServiceUpdateRequests: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestId** | **string**|  | 
 **body** | [**RequestPutRequest**](RequestPutRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

