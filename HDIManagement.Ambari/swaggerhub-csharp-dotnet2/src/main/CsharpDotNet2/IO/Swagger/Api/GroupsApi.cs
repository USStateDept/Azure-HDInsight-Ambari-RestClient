using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IGroupsApi
    {
        /// <summary>
        /// Get group privilege Returns group privilege details.
        /// </summary>
        /// <param name="groupName">group name</param>
        /// <param name="privilegeId">privilege id</param>
        /// <param name="fields">Filter group privilege details</param>
        /// <returns>PrivilegeResponse</returns>
        PrivilegeResponse GroupPrivilegeServiceGetPrivilege (string groupName, string privilegeId, string fields);
        /// <summary>
        /// Get all privileges Returns all privileges for group.
        /// </summary>
        /// <param name="groupName">group name</param>
        /// <param name="fields">Filter user privileges</param>
        /// <param name="sortBy">Sort user privileges (asc | desc)</param>
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param>
        /// <param name="from">The starting page resource (inclusive). Valid values are :offset | \&quot;start\&quot;</param>
        /// <param name="to">The ending page resource (inclusive). Valid values are :offset | \&quot;end\&quot;</param>
        /// <returns>List&lt;GroupPrivilegeResponse&gt;</returns>
        List<GroupPrivilegeResponse> GroupPrivilegeServiceGetPrivileges (string groupName, string fields, string sortBy, int? pageSize, string from, string to);
        /// <summary>
        /// Create new group Creates group resource.
        /// </summary>
        /// <param name="body">input parameters in json form</param>
        /// <returns></returns>
        void GroupServiceCreateGroup (GroupRequest body);
        /// <summary>
        /// Delete group Delete group resource.
        /// </summary>
        /// <param name="groupName">group name</param>
        /// <returns></returns>
        void GroupServiceDeleteGroup (string groupName);
        /// <summary>
        /// Get group Returns group details.
        /// </summary>
        /// <param name="groupName">group name</param>
        /// <param name="fields">Filter group details</param>
        /// <returns>GroupResponse</returns>
        GroupResponse GroupServiceGetGroup (string groupName, string fields);
        /// <summary>
        /// Get all groups Returns details of all groups.
        /// </summary>
        /// <param name="fields">Filter group details</param>
        /// <param name="sortBy">Sort groups (asc | desc)</param>
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param>
        /// <param name="from">The starting page resource (inclusive). Valid values are :offset | \&quot;start\&quot;</param>
        /// <param name="to">The ending page resource (inclusive). Valid values are :offset | \&quot;end\&quot;</param>
        /// <returns>List&lt;GroupResponse&gt;</returns>
        List<GroupResponse> GroupServiceGetGroups (string fields, string sortBy, int? pageSize, string from, string to);
        /// <summary>
        /// Delete group member Delete member resource.
        /// </summary>
        /// <param name="groupName">group name</param>
        /// <param name="userName">user name</param>
        /// <returns></returns>
        void MemberServiceDeleteMember (string groupName, string userName);
        /// <summary>
        /// Get group member Returns member details.
        /// </summary>
        /// <param name="groupName">group name</param>
        /// <param name="userName">user name</param>
        /// <param name="fields">Filter member details</param>
        /// <returns>MemberResponse</returns>
        MemberResponse MemberServiceGetMember (string groupName, string userName, string fields);
        /// <summary>
        /// Get all group members Returns details of all members.
        /// </summary>
        /// <param name="groupName">group name</param>
        /// <param name="fields">Filter member details</param>
        /// <param name="sortBy">Sort members (asc | desc)</param>
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param>
        /// <param name="from">The starting page resource (inclusive). Valid values are :offset | \&quot;start\&quot;</param>
        /// <param name="to">The ending page resource (inclusive). Valid values are :offset | \&quot;end\&quot;</param>
        /// <returns>List&lt;MemberResponse&gt;</returns>
        List<MemberResponse> MemberServiceGetMembers (string groupName, string fields, string sortBy, int? pageSize, string from, string to);
        /// <summary>
        /// Update group members Updates group member resources.
        /// </summary>
        /// <param name="groupName">group name</param>
        /// <param name="body">input parameters in json form</param>
        /// <returns></returns>
        void MemberServiceUpdateMembers (string groupName, MemberRequest body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GroupsApi : IGroupsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public GroupsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GroupsApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Get group privilege Returns group privilege details.
        /// </summary>
        /// <param name="groupName">group name</param> 
        /// <param name="privilegeId">privilege id</param> 
        /// <param name="fields">Filter group privilege details</param> 
        /// <returns>PrivilegeResponse</returns>            
        public PrivilegeResponse GroupPrivilegeServiceGetPrivilege (string groupName, string privilegeId, string fields)
        {
            
            // verify the required parameter 'groupName' is set
            if (groupName == null) throw new ApiException(400, "Missing required parameter 'groupName' when calling GroupPrivilegeServiceGetPrivilege");
            
            // verify the required parameter 'privilegeId' is set
            if (privilegeId == null) throw new ApiException(400, "Missing required parameter 'privilegeId' when calling GroupPrivilegeServiceGetPrivilege");
            
    
            var path = "/groups/{groupName}/privileges/{privilegeId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "groupName" + "}", ApiClient.ParameterToString(groupName));
path = path.Replace("{" + "privilegeId" + "}", ApiClient.ParameterToString(privilegeId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupPrivilegeServiceGetPrivilege: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupPrivilegeServiceGetPrivilege: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PrivilegeResponse) ApiClient.Deserialize(response.Content, typeof(PrivilegeResponse), response.Headers);
        }
    
        /// <summary>
        /// Get all privileges Returns all privileges for group.
        /// </summary>
        /// <param name="groupName">group name</param> 
        /// <param name="fields">Filter user privileges</param> 
        /// <param name="sortBy">Sort user privileges (asc | desc)</param> 
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param> 
        /// <param name="from">The starting page resource (inclusive). Valid values are :offset | \&quot;start\&quot;</param> 
        /// <param name="to">The ending page resource (inclusive). Valid values are :offset | \&quot;end\&quot;</param> 
        /// <returns>List&lt;GroupPrivilegeResponse&gt;</returns>            
        public List<GroupPrivilegeResponse> GroupPrivilegeServiceGetPrivileges (string groupName, string fields, string sortBy, int? pageSize, string from, string to)
        {
            
            // verify the required parameter 'groupName' is set
            if (groupName == null) throw new ApiException(400, "Missing required parameter 'groupName' when calling GroupPrivilegeServiceGetPrivileges");
            
    
            var path = "/groups/{groupName}/privileges";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "groupName" + "}", ApiClient.ParameterToString(groupName));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
 if (sortBy != null) queryParams.Add("sortBy", ApiClient.ParameterToString(sortBy)); // query parameter
 if (pageSize != null) queryParams.Add("page_size", ApiClient.ParameterToString(pageSize)); // query parameter
 if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (to != null) queryParams.Add("to", ApiClient.ParameterToString(to)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupPrivilegeServiceGetPrivileges: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupPrivilegeServiceGetPrivileges: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GroupPrivilegeResponse>) ApiClient.Deserialize(response.Content, typeof(List<GroupPrivilegeResponse>), response.Headers);
        }
    
        /// <summary>
        /// Create new group Creates group resource.
        /// </summary>
        /// <param name="body">input parameters in json form</param> 
        /// <returns></returns>            
        public void GroupServiceCreateGroup (GroupRequest body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling GroupServiceCreateGroup");
            
    
            var path = "/groups";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupServiceCreateGroup: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupServiceCreateGroup: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete group Delete group resource.
        /// </summary>
        /// <param name="groupName">group name</param> 
        /// <returns></returns>            
        public void GroupServiceDeleteGroup (string groupName)
        {
            
            // verify the required parameter 'groupName' is set
            if (groupName == null) throw new ApiException(400, "Missing required parameter 'groupName' when calling GroupServiceDeleteGroup");
            
    
            var path = "/groups/{groupName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "groupName" + "}", ApiClient.ParameterToString(groupName));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupServiceDeleteGroup: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupServiceDeleteGroup: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get group Returns group details.
        /// </summary>
        /// <param name="groupName">group name</param> 
        /// <param name="fields">Filter group details</param> 
        /// <returns>GroupResponse</returns>            
        public GroupResponse GroupServiceGetGroup (string groupName, string fields)
        {
            
            // verify the required parameter 'groupName' is set
            if (groupName == null) throw new ApiException(400, "Missing required parameter 'groupName' when calling GroupServiceGetGroup");
            
    
            var path = "/groups/{groupName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "groupName" + "}", ApiClient.ParameterToString(groupName));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupServiceGetGroup: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupServiceGetGroup: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GroupResponse) ApiClient.Deserialize(response.Content, typeof(GroupResponse), response.Headers);
        }
    
        /// <summary>
        /// Get all groups Returns details of all groups.
        /// </summary>
        /// <param name="fields">Filter group details</param> 
        /// <param name="sortBy">Sort groups (asc | desc)</param> 
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param> 
        /// <param name="from">The starting page resource (inclusive). Valid values are :offset | \&quot;start\&quot;</param> 
        /// <param name="to">The ending page resource (inclusive). Valid values are :offset | \&quot;end\&quot;</param> 
        /// <returns>List&lt;GroupResponse&gt;</returns>            
        public List<GroupResponse> GroupServiceGetGroups (string fields, string sortBy, int? pageSize, string from, string to)
        {
            
    
            var path = "/groups";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
 if (sortBy != null) queryParams.Add("sortBy", ApiClient.ParameterToString(sortBy)); // query parameter
 if (pageSize != null) queryParams.Add("page_size", ApiClient.ParameterToString(pageSize)); // query parameter
 if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (to != null) queryParams.Add("to", ApiClient.ParameterToString(to)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupServiceGetGroups: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupServiceGetGroups: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GroupResponse>) ApiClient.Deserialize(response.Content, typeof(List<GroupResponse>), response.Headers);
        }
    
        /// <summary>
        /// Delete group member Delete member resource.
        /// </summary>
        /// <param name="groupName">group name</param> 
        /// <param name="userName">user name</param> 
        /// <returns></returns>            
        public void MemberServiceDeleteMember (string groupName, string userName)
        {
            
            // verify the required parameter 'groupName' is set
            if (groupName == null) throw new ApiException(400, "Missing required parameter 'groupName' when calling MemberServiceDeleteMember");
            
            // verify the required parameter 'userName' is set
            if (userName == null) throw new ApiException(400, "Missing required parameter 'userName' when calling MemberServiceDeleteMember");
            
    
            var path = "/groups/{groupName}/members/{userName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "groupName" + "}", ApiClient.ParameterToString(groupName));
path = path.Replace("{" + "userName" + "}", ApiClient.ParameterToString(userName));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MemberServiceDeleteMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MemberServiceDeleteMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get group member Returns member details.
        /// </summary>
        /// <param name="groupName">group name</param> 
        /// <param name="userName">user name</param> 
        /// <param name="fields">Filter member details</param> 
        /// <returns>MemberResponse</returns>            
        public MemberResponse MemberServiceGetMember (string groupName, string userName, string fields)
        {
            
            // verify the required parameter 'groupName' is set
            if (groupName == null) throw new ApiException(400, "Missing required parameter 'groupName' when calling MemberServiceGetMember");
            
            // verify the required parameter 'userName' is set
            if (userName == null) throw new ApiException(400, "Missing required parameter 'userName' when calling MemberServiceGetMember");
            
    
            var path = "/groups/{groupName}/members/{userName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "groupName" + "}", ApiClient.ParameterToString(groupName));
path = path.Replace("{" + "userName" + "}", ApiClient.ParameterToString(userName));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MemberServiceGetMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MemberServiceGetMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return (MemberResponse) ApiClient.Deserialize(response.Content, typeof(MemberResponse), response.Headers);
        }
    
        /// <summary>
        /// Get all group members Returns details of all members.
        /// </summary>
        /// <param name="groupName">group name</param> 
        /// <param name="fields">Filter member details</param> 
        /// <param name="sortBy">Sort members (asc | desc)</param> 
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param> 
        /// <param name="from">The starting page resource (inclusive). Valid values are :offset | \&quot;start\&quot;</param> 
        /// <param name="to">The ending page resource (inclusive). Valid values are :offset | \&quot;end\&quot;</param> 
        /// <returns>List&lt;MemberResponse&gt;</returns>            
        public List<MemberResponse> MemberServiceGetMembers (string groupName, string fields, string sortBy, int? pageSize, string from, string to)
        {
            
            // verify the required parameter 'groupName' is set
            if (groupName == null) throw new ApiException(400, "Missing required parameter 'groupName' when calling MemberServiceGetMembers");
            
    
            var path = "/groups/{groupName}/members";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "groupName" + "}", ApiClient.ParameterToString(groupName));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
 if (sortBy != null) queryParams.Add("sortBy", ApiClient.ParameterToString(sortBy)); // query parameter
 if (pageSize != null) queryParams.Add("page_size", ApiClient.ParameterToString(pageSize)); // query parameter
 if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (to != null) queryParams.Add("to", ApiClient.ParameterToString(to)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MemberServiceGetMembers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MemberServiceGetMembers: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<MemberResponse>) ApiClient.Deserialize(response.Content, typeof(List<MemberResponse>), response.Headers);
        }
    
        /// <summary>
        /// Update group members Updates group member resources.
        /// </summary>
        /// <param name="groupName">group name</param> 
        /// <param name="body">input parameters in json form</param> 
        /// <returns></returns>            
        public void MemberServiceUpdateMembers (string groupName, MemberRequest body)
        {
            
            // verify the required parameter 'groupName' is set
            if (groupName == null) throw new ApiException(400, "Missing required parameter 'groupName' when calling MemberServiceUpdateMembers");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling MemberServiceUpdateMembers");
            
    
            var path = "/groups/{groupName}/members";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "groupName" + "}", ApiClient.ParameterToString(groupName));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MemberServiceUpdateMembers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MemberServiceUpdateMembers: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
