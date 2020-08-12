# IO.Swagger.Api.UsersApi

All URIs are relative to *https://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActiveWidgetLayoutServiceGetServices**](UsersApi.md#activewidgetlayoutservicegetservices) | **GET** /users/{userName}/activeWidgetLayouts | Get user widget layouts
[**ActiveWidgetLayoutServiceUpdateServices**](UsersApi.md#activewidgetlayoutserviceupdateservices) | **PUT** /users/{userName}/activeWidgetLayouts | Update user widget layouts
[**CreateUser**](UsersApi.md#createuser) | **POST** /users/{userName} | Create new user
[**CreateUsers**](UsersApi.md#createusers) | **POST** /users | Creates one or more users in a single request
[**DeleteUser**](UsersApi.md#deleteuser) | **DELETE** /users/{userName} | Delete single user
[**GetUser**](UsersApi.md#getuser) | **GET** /users/{userName} | Get single user
[**GetUsers**](UsersApi.md#getusers) | **GET** /users | Get all users
[**UpdateUser**](UsersApi.md#updateuser) | **PUT** /users/{userName} | Update user details
[**UserAuthorizationServiceGetAuthorization**](UsersApi.md#userauthorizationservicegetauthorization) | **GET** /users/{userName}/authorizations/{authorization_id} | Get user authorization
[**UserAuthorizationServiceGetAuthorizations**](UsersApi.md#userauthorizationservicegetauthorizations) | **GET** /users/{userName}/authorizations | Get all authorizations
[**UserPrivilegeServiceGetPrivilege**](UsersApi.md#userprivilegeservicegetprivilege) | **GET** /users/{userName}/privileges/{privilegeId} | Get user privilege
[**UserPrivilegeServiceGetPrivileges**](UsersApi.md#userprivilegeservicegetprivileges) | **GET** /users/{userName}/privileges | Get all privileges


<a name="activewidgetlayoutservicegetservices"></a>
# **ActiveWidgetLayoutServiceGetServices**
> List<ActiveWidgetLayoutResponse> ActiveWidgetLayoutServiceGetServices (string userName, string fields, string sortBy, int? pageSize, string from, string to)

Get user widget layouts

Returns all active widget layouts for user.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ActiveWidgetLayoutServiceGetServicesExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var userName = userName_example;  // string | user name
            var fields = fields_example;  // string | Filter user layout details (optional)  (default to WidgetLayoutInfo/*)
            var sortBy = sortBy_example;  // string | Sort layouts (asc | desc) (optional)  (default to WidgetLayoutInfo/user_name.asc)
            var pageSize = 56;  // int? | The number of resources to be returned for the paged response. (optional)  (default to 10)
            var from = from_example;  // string | The starting page resource (inclusive). Valid values are :offset | \"start\" (optional)  (default to 0)
            var to = to_example;  // string | The ending page resource (inclusive). Valid values are :offset | \"end\" (optional) 

            try
            {
                // Get user widget layouts
                List&lt;ActiveWidgetLayoutResponse&gt; result = apiInstance.ActiveWidgetLayoutServiceGetServices(userName, fields, sortBy, pageSize, from, to);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.ActiveWidgetLayoutServiceGetServices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userName** | **string**| user name | 
 **fields** | **string**| Filter user layout details | [optional] [default to WidgetLayoutInfo/*]
 **sortBy** | **string**| Sort layouts (asc | desc) | [optional] [default to WidgetLayoutInfo/user_name.asc]
 **pageSize** | **int?**| The number of resources to be returned for the paged response. | [optional] [default to 10]
 **from** | **string**| The starting page resource (inclusive). Valid values are :offset | \&quot;start\&quot; | [optional] [default to 0]
 **to** | **string**| The ending page resource (inclusive). Valid values are :offset | \&quot;end\&quot; | [optional] 

### Return type

[**List<ActiveWidgetLayoutResponse>**](ActiveWidgetLayoutResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="activewidgetlayoutserviceupdateservices"></a>
# **ActiveWidgetLayoutServiceUpdateServices**
> void ActiveWidgetLayoutServiceUpdateServices (string userName, ActiveWidgetLayoutRequest body)

Update user widget layouts

Updates user widget layout.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ActiveWidgetLayoutServiceUpdateServicesExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var userName = userName_example;  // string | user name
            var body = new ActiveWidgetLayoutRequest(); // ActiveWidgetLayoutRequest | input parameters in json form

            try
            {
                // Update user widget layouts
                apiInstance.ActiveWidgetLayoutServiceUpdateServices(userName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.ActiveWidgetLayoutServiceUpdateServices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userName** | **string**| user name | 
 **body** | [**ActiveWidgetLayoutRequest**](ActiveWidgetLayoutRequest.md)| input parameters in json form | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createuser"></a>
# **CreateUser**
> void CreateUser (string userName, UserRequestCreateUserSwagger body)

Create new user



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateUserExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var userName = userName_example;  // string | user name
            var body = new UserRequestCreateUserSwagger(); // UserRequestCreateUserSwagger |  (optional) 

            try
            {
                // Create new user
                apiInstance.CreateUser(userName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.CreateUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userName** | **string**| user name | 
 **body** | [**UserRequestCreateUserSwagger**](UserRequestCreateUserSwagger.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createusers"></a>
# **CreateUsers**
> void CreateUsers (UserRequestCreateUsersSwagger body)

Creates one or more users in a single request



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateUsersExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var body = new UserRequestCreateUsersSwagger(); // UserRequestCreateUsersSwagger |  (optional) 

            try
            {
                // Creates one or more users in a single request
                apiInstance.CreateUsers(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.CreateUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserRequestCreateUsersSwagger**](UserRequestCreateUsersSwagger.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteuser"></a>
# **DeleteUser**
> void DeleteUser (string userName)

Delete single user



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteUserExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var userName = userName_example;  // string | user name

            try
            {
                // Delete single user
                apiInstance.DeleteUser(userName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userName** | **string**| user name | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuser"></a>
# **GetUser**
> UserResponseSwagger GetUser (string userName, string fields)

Get single user



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var userName = userName_example;  // string | user name
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional)  (default to Users/*)

            try
            {
                // Get single user
                UserResponseSwagger result = apiInstance.GetUser(userName, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userName** | **string**| user name | 
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] [default to Users/*]

### Return type

[**UserResponseSwagger**](UserResponseSwagger.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusers"></a>
# **GetUsers**
> List<UserResponseSwagger> GetUsers (string fields, string sortBy, int? pageSize, int? from, int? to)

Get all users



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUsersExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var fields = fields_example;  // string | Filter fields in the response (identifier fields are mandatory) (optional)  (default to Users/user_name)
            var sortBy = sortBy_example;  // string | Sort resources in result by (asc | desc) (optional)  (default to Users/user_name.asc)
            var pageSize = 56;  // int? | The number of resources to be returned for the paged response. (optional)  (default to 10)
            var from = 56;  // int? | The starting page resource (inclusive).  \"start\" is also accepted. (optional)  (default to 0)
            var to = 56;  // int? | The ending page resource (inclusive).  \"end\" is also accepted. (optional) 

            try
            {
                // Get all users
                List&lt;UserResponseSwagger&gt; result = apiInstance.GetUsers(fields, sortBy, pageSize, from, to);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fields** | **string**| Filter fields in the response (identifier fields are mandatory) | [optional] [default to Users/user_name]
 **sortBy** | **string**| Sort resources in result by (asc | desc) | [optional] [default to Users/user_name.asc]
 **pageSize** | **int?**| The number of resources to be returned for the paged response. | [optional] [default to 10]
 **from** | **int?**| The starting page resource (inclusive).  \&quot;start\&quot; is also accepted. | [optional] [default to 0]
 **to** | **int?**| The ending page resource (inclusive).  \&quot;end\&quot; is also accepted. | [optional] 

### Return type

[**List<UserResponseSwagger>**](UserResponseSwagger.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateuser"></a>
# **UpdateUser**
> void UpdateUser (string userName, UserRequestUpdateUserSwagger body)

Update user details



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateUserExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var userName = userName_example;  // string | user name
            var body = new UserRequestUpdateUserSwagger(); // UserRequestUpdateUserSwagger |  (optional) 

            try
            {
                // Update user details
                apiInstance.UpdateUser(userName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UpdateUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userName** | **string**| user name | 
 **body** | [**UserRequestUpdateUserSwagger**](UserRequestUpdateUserSwagger.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userauthorizationservicegetauthorization"></a>
# **UserAuthorizationServiceGetAuthorization**
> UserAuthorizationResponse UserAuthorizationServiceGetAuthorization (string userName, string authorizationId, string fields)

Get user authorization

Returns user authorization details.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserAuthorizationServiceGetAuthorizationExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var userName = userName_example;  // string | user name
            var authorizationId = authorizationId_example;  // string | Authorization Id
            var fields = fields_example;  // string | Filter user authorization details (optional)  (default to AuthorizationInfo/*)

            try
            {
                // Get user authorization
                UserAuthorizationResponse result = apiInstance.UserAuthorizationServiceGetAuthorization(userName, authorizationId, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UserAuthorizationServiceGetAuthorization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userName** | **string**| user name | 
 **authorizationId** | **string**| Authorization Id | 
 **fields** | **string**| Filter user authorization details | [optional] [default to AuthorizationInfo/*]

### Return type

[**UserAuthorizationResponse**](UserAuthorizationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userauthorizationservicegetauthorizations"></a>
# **UserAuthorizationServiceGetAuthorizations**
> List<UserAuthorizationResponse> UserAuthorizationServiceGetAuthorizations (string userName, string fields, string sortBy, int? pageSize, string from, string to)

Get all authorizations

Returns all authorization for user.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserAuthorizationServiceGetAuthorizationsExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var userName = userName_example;  // string | user name
            var fields = fields_example;  // string | Filter user authorization details (optional)  (default to AuthorizationInfo/*)
            var sortBy = sortBy_example;  // string | Sort user authorizations (asc | desc) (optional)  (default to AuthorizationInfo/user_name.asc)
            var pageSize = 56;  // int? | The number of resources to be returned for the paged response. (optional)  (default to 10)
            var from = from_example;  // string | The starting page resource (inclusive). Valid values are :offset | \"start\" (optional)  (default to 0)
            var to = to_example;  // string | The ending page resource (inclusive). Valid values are :offset | \"end\" (optional) 

            try
            {
                // Get all authorizations
                List&lt;UserAuthorizationResponse&gt; result = apiInstance.UserAuthorizationServiceGetAuthorizations(userName, fields, sortBy, pageSize, from, to);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UserAuthorizationServiceGetAuthorizations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userName** | **string**| user name | 
 **fields** | **string**| Filter user authorization details | [optional] [default to AuthorizationInfo/*]
 **sortBy** | **string**| Sort user authorizations (asc | desc) | [optional] [default to AuthorizationInfo/user_name.asc]
 **pageSize** | **int?**| The number of resources to be returned for the paged response. | [optional] [default to 10]
 **from** | **string**| The starting page resource (inclusive). Valid values are :offset | \&quot;start\&quot; | [optional] [default to 0]
 **to** | **string**| The ending page resource (inclusive). Valid values are :offset | \&quot;end\&quot; | [optional] 

### Return type

[**List<UserAuthorizationResponse>**](UserAuthorizationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userprivilegeservicegetprivilege"></a>
# **UserPrivilegeServiceGetPrivilege**
> UserPrivilegeResponse UserPrivilegeServiceGetPrivilege (string userName, string privilegeId, string fields)

Get user privilege

Returns user privilege details.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserPrivilegeServiceGetPrivilegeExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var userName = userName_example;  // string | user name
            var privilegeId = privilegeId_example;  // string | privilege id
            var fields = fields_example;  // string | Filter user privilege details (optional)  (default to PrivilegeInfo/*)

            try
            {
                // Get user privilege
                UserPrivilegeResponse result = apiInstance.UserPrivilegeServiceGetPrivilege(userName, privilegeId, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UserPrivilegeServiceGetPrivilege: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userName** | **string**| user name | 
 **privilegeId** | **string**| privilege id | 
 **fields** | **string**| Filter user privilege details | [optional] [default to PrivilegeInfo/*]

### Return type

[**UserPrivilegeResponse**](UserPrivilegeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userprivilegeservicegetprivileges"></a>
# **UserPrivilegeServiceGetPrivileges**
> List<UserPrivilegeResponse> UserPrivilegeServiceGetPrivileges (string userName, string fields, string sortBy, int? pageSize, string from, string to)

Get all privileges

Returns all privileges for user.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserPrivilegeServiceGetPrivilegesExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var userName = userName_example;  // string | user name
            var fields = fields_example;  // string | Filter user privileges (optional)  (default to PrivilegeInfo/*)
            var sortBy = sortBy_example;  // string | Sort user privileges (asc | desc) (optional)  (default to PrivilegeInfo/user_name.asc)
            var pageSize = 56;  // int? | The number of resources to be returned for the paged response. (optional)  (default to 10)
            var from = from_example;  // string | The starting page resource (inclusive). Valid values are :offset | \"start\" (optional)  (default to 0)
            var to = to_example;  // string | The ending page resource (inclusive). Valid values are :offset | \"end\" (optional) 

            try
            {
                // Get all privileges
                List&lt;UserPrivilegeResponse&gt; result = apiInstance.UserPrivilegeServiceGetPrivileges(userName, fields, sortBy, pageSize, from, to);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UserPrivilegeServiceGetPrivileges: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userName** | **string**| user name | 
 **fields** | **string**| Filter user privileges | [optional] [default to PrivilegeInfo/*]
 **sortBy** | **string**| Sort user privileges (asc | desc) | [optional] [default to PrivilegeInfo/user_name.asc]
 **pageSize** | **int?**| The number of resources to be returned for the paged response. | [optional] [default to 10]
 **from** | **string**| The starting page resource (inclusive). Valid values are :offset | \&quot;start\&quot; | [optional] [default to 0]
 **to** | **string**| The ending page resource (inclusive). Valid values are :offset | \&quot;end\&quot; | [optional] 

### Return type

[**List<UserPrivilegeResponse>**](UserPrivilegeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

