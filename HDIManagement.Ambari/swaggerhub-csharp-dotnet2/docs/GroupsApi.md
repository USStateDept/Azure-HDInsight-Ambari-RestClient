# IO.Swagger.Api.GroupsApi

All URIs are relative to *https://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GroupPrivilegeServiceGetPrivilege**](GroupsApi.md#groupprivilegeservicegetprivilege) | **GET** /groups/{groupName}/privileges/{privilegeId} | Get group privilege
[**GroupPrivilegeServiceGetPrivileges**](GroupsApi.md#groupprivilegeservicegetprivileges) | **GET** /groups/{groupName}/privileges | Get all privileges
[**GroupServiceCreateGroup**](GroupsApi.md#groupservicecreategroup) | **POST** /groups | Create new group
[**GroupServiceDeleteGroup**](GroupsApi.md#groupservicedeletegroup) | **DELETE** /groups/{groupName} | Delete group
[**GroupServiceGetGroup**](GroupsApi.md#groupservicegetgroup) | **GET** /groups/{groupName} | Get group
[**GroupServiceGetGroups**](GroupsApi.md#groupservicegetgroups) | **GET** /groups | Get all groups
[**MemberServiceDeleteMember**](GroupsApi.md#memberservicedeletemember) | **DELETE** /groups/{groupName}/members/{userName} | Delete group member
[**MemberServiceGetMember**](GroupsApi.md#memberservicegetmember) | **GET** /groups/{groupName}/members/{userName} | Get group member
[**MemberServiceGetMembers**](GroupsApi.md#memberservicegetmembers) | **GET** /groups/{groupName}/members | Get all group members
[**MemberServiceUpdateMembers**](GroupsApi.md#memberserviceupdatemembers) | **PUT** /groups/{groupName}/members | Update group members


<a name="groupprivilegeservicegetprivilege"></a>
# **GroupPrivilegeServiceGetPrivilege**
> PrivilegeResponse GroupPrivilegeServiceGetPrivilege (string groupName, string privilegeId, string fields)

Get group privilege

Returns group privilege details.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GroupPrivilegeServiceGetPrivilegeExample
    {
        public void main()
        {
            
            var apiInstance = new GroupsApi();
            var groupName = groupName_example;  // string | group name
            var privilegeId = privilegeId_example;  // string | privilege id
            var fields = fields_example;  // string | Filter group privilege details (optional)  (default to PrivilegeInfo/*)

            try
            {
                // Get group privilege
                PrivilegeResponse result = apiInstance.GroupPrivilegeServiceGetPrivilege(groupName, privilegeId, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GroupPrivilegeServiceGetPrivilege: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupName** | **string**| group name | 
 **privilegeId** | **string**| privilege id | 
 **fields** | **string**| Filter group privilege details | [optional] [default to PrivilegeInfo/*]

### Return type

[**PrivilegeResponse**](PrivilegeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupprivilegeservicegetprivileges"></a>
# **GroupPrivilegeServiceGetPrivileges**
> List<GroupPrivilegeResponse> GroupPrivilegeServiceGetPrivileges (string groupName, string fields, string sortBy, int? pageSize, string from, string to)

Get all privileges

Returns all privileges for group.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GroupPrivilegeServiceGetPrivilegesExample
    {
        public void main()
        {
            
            var apiInstance = new GroupsApi();
            var groupName = groupName_example;  // string | group name
            var fields = fields_example;  // string | Filter user privileges (optional)  (default to PrivilegeInfo/*)
            var sortBy = sortBy_example;  // string | Sort user privileges (asc | desc) (optional)  (default to PrivilegeInfo/user_name.asc)
            var pageSize = 56;  // int? | The number of resources to be returned for the paged response. (optional)  (default to 10)
            var from = from_example;  // string | The starting page resource (inclusive). Valid values are :offset | \"start\" (optional)  (default to 0)
            var to = to_example;  // string | The ending page resource (inclusive). Valid values are :offset | \"end\" (optional) 

            try
            {
                // Get all privileges
                List&lt;GroupPrivilegeResponse&gt; result = apiInstance.GroupPrivilegeServiceGetPrivileges(groupName, fields, sortBy, pageSize, from, to);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GroupPrivilegeServiceGetPrivileges: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupName** | **string**| group name | 
 **fields** | **string**| Filter user privileges | [optional] [default to PrivilegeInfo/*]
 **sortBy** | **string**| Sort user privileges (asc | desc) | [optional] [default to PrivilegeInfo/user_name.asc]
 **pageSize** | **int?**| The number of resources to be returned for the paged response. | [optional] [default to 10]
 **from** | **string**| The starting page resource (inclusive). Valid values are :offset | \&quot;start\&quot; | [optional] [default to 0]
 **to** | **string**| The ending page resource (inclusive). Valid values are :offset | \&quot;end\&quot; | [optional] 

### Return type

[**List<GroupPrivilegeResponse>**](GroupPrivilegeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupservicecreategroup"></a>
# **GroupServiceCreateGroup**
> void GroupServiceCreateGroup (GroupRequest body)

Create new group

Creates group resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GroupServiceCreateGroupExample
    {
        public void main()
        {
            
            var apiInstance = new GroupsApi();
            var body = new GroupRequest(); // GroupRequest | input parameters in json form

            try
            {
                // Create new group
                apiInstance.GroupServiceCreateGroup(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GroupServiceCreateGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GroupRequest**](GroupRequest.md)| input parameters in json form | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupservicedeletegroup"></a>
# **GroupServiceDeleteGroup**
> void GroupServiceDeleteGroup (string groupName)

Delete group

Delete group resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GroupServiceDeleteGroupExample
    {
        public void main()
        {
            
            var apiInstance = new GroupsApi();
            var groupName = groupName_example;  // string | group name

            try
            {
                // Delete group
                apiInstance.GroupServiceDeleteGroup(groupName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GroupServiceDeleteGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupName** | **string**| group name | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupservicegetgroup"></a>
# **GroupServiceGetGroup**
> GroupResponse GroupServiceGetGroup (string groupName, string fields)

Get group

Returns group details.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GroupServiceGetGroupExample
    {
        public void main()
        {
            
            var apiInstance = new GroupsApi();
            var groupName = groupName_example;  // string | group name
            var fields = fields_example;  // string | Filter group details (optional)  (default to Groups)

            try
            {
                // Get group
                GroupResponse result = apiInstance.GroupServiceGetGroup(groupName, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GroupServiceGetGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupName** | **string**| group name | 
 **fields** | **string**| Filter group details | [optional] [default to Groups]

### Return type

[**GroupResponse**](GroupResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupservicegetgroups"></a>
# **GroupServiceGetGroups**
> List<GroupResponse> GroupServiceGetGroups (string fields, string sortBy, int? pageSize, string from, string to)

Get all groups

Returns details of all groups.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GroupServiceGetGroupsExample
    {
        public void main()
        {
            
            var apiInstance = new GroupsApi();
            var fields = fields_example;  // string | Filter group details (optional)  (default to Groups/*)
            var sortBy = sortBy_example;  // string | Sort groups (asc | desc) (optional)  (default to Groups/group_name.asc)
            var pageSize = 56;  // int? | The number of resources to be returned for the paged response. (optional)  (default to 10)
            var from = from_example;  // string | The starting page resource (inclusive). Valid values are :offset | \"start\" (optional)  (default to 0)
            var to = to_example;  // string | The ending page resource (inclusive). Valid values are :offset | \"end\" (optional) 

            try
            {
                // Get all groups
                List&lt;GroupResponse&gt; result = apiInstance.GroupServiceGetGroups(fields, sortBy, pageSize, from, to);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GroupServiceGetGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fields** | **string**| Filter group details | [optional] [default to Groups/*]
 **sortBy** | **string**| Sort groups (asc | desc) | [optional] [default to Groups/group_name.asc]
 **pageSize** | **int?**| The number of resources to be returned for the paged response. | [optional] [default to 10]
 **from** | **string**| The starting page resource (inclusive). Valid values are :offset | \&quot;start\&quot; | [optional] [default to 0]
 **to** | **string**| The ending page resource (inclusive). Valid values are :offset | \&quot;end\&quot; | [optional] 

### Return type

[**List<GroupResponse>**](GroupResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="memberservicedeletemember"></a>
# **MemberServiceDeleteMember**
> void MemberServiceDeleteMember (string groupName, string userName)

Delete group member

Delete member resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MemberServiceDeleteMemberExample
    {
        public void main()
        {
            
            var apiInstance = new GroupsApi();
            var groupName = groupName_example;  // string | group name
            var userName = userName_example;  // string | user name

            try
            {
                // Delete group member
                apiInstance.MemberServiceDeleteMember(groupName, userName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.MemberServiceDeleteMember: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupName** | **string**| group name | 
 **userName** | **string**| user name | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="memberservicegetmember"></a>
# **MemberServiceGetMember**
> MemberResponse MemberServiceGetMember (string groupName, string userName, string fields)

Get group member

Returns member details.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MemberServiceGetMemberExample
    {
        public void main()
        {
            
            var apiInstance = new GroupsApi();
            var groupName = groupName_example;  // string | group name
            var userName = userName_example;  // string | user name
            var fields = fields_example;  // string | Filter member details (optional)  (default to MemberInfo)

            try
            {
                // Get group member
                MemberResponse result = apiInstance.MemberServiceGetMember(groupName, userName, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.MemberServiceGetMember: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupName** | **string**| group name | 
 **userName** | **string**| user name | 
 **fields** | **string**| Filter member details | [optional] [default to MemberInfo]

### Return type

[**MemberResponse**](MemberResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="memberservicegetmembers"></a>
# **MemberServiceGetMembers**
> List<MemberResponse> MemberServiceGetMembers (string groupName, string fields, string sortBy, int? pageSize, string from, string to)

Get all group members

Returns details of all members.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MemberServiceGetMembersExample
    {
        public void main()
        {
            
            var apiInstance = new GroupsApi();
            var groupName = groupName_example;  // string | group name
            var fields = fields_example;  // string | Filter member details (optional)  (default to MemberInfo/*)
            var sortBy = sortBy_example;  // string | Sort members (asc | desc) (optional)  (default to MemberInfo/user_name.asc)
            var pageSize = 56;  // int? | The number of resources to be returned for the paged response. (optional)  (default to 10)
            var from = from_example;  // string | The starting page resource (inclusive). Valid values are :offset | \"start\" (optional)  (default to 0)
            var to = to_example;  // string | The ending page resource (inclusive). Valid values are :offset | \"end\" (optional) 

            try
            {
                // Get all group members
                List&lt;MemberResponse&gt; result = apiInstance.MemberServiceGetMembers(groupName, fields, sortBy, pageSize, from, to);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.MemberServiceGetMembers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupName** | **string**| group name | 
 **fields** | **string**| Filter member details | [optional] [default to MemberInfo/*]
 **sortBy** | **string**| Sort members (asc | desc) | [optional] [default to MemberInfo/user_name.asc]
 **pageSize** | **int?**| The number of resources to be returned for the paged response. | [optional] [default to 10]
 **from** | **string**| The starting page resource (inclusive). Valid values are :offset | \&quot;start\&quot; | [optional] [default to 0]
 **to** | **string**| The ending page resource (inclusive). Valid values are :offset | \&quot;end\&quot; | [optional] 

### Return type

[**List<MemberResponse>**](MemberResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="memberserviceupdatemembers"></a>
# **MemberServiceUpdateMembers**
> void MemberServiceUpdateMembers (string groupName, MemberRequest body)

Update group members

Updates group member resources.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MemberServiceUpdateMembersExample
    {
        public void main()
        {
            
            var apiInstance = new GroupsApi();
            var groupName = groupName_example;  // string | group name
            var body = new MemberRequest(); // MemberRequest | input parameters in json form

            try
            {
                // Update group members
                apiInstance.MemberServiceUpdateMembers(groupName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.MemberServiceUpdateMembers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupName** | **string**| group name | 
 **body** | [**MemberRequest**](MemberRequest.md)| input parameters in json form | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

