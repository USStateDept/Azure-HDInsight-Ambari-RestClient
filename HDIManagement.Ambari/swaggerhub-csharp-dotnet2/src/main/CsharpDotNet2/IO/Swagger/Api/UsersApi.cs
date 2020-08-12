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
    public interface IUsersApi
    {
        /// <summary>
        /// Get user widget layouts Returns all active widget layouts for user.
        /// </summary>
        /// <param name="userName">user name</param>
        /// <param name="fields">Filter user layout details</param>
        /// <param name="sortBy">Sort layouts (asc | desc)</param>
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param>
        /// <param name="from">The starting page resource (inclusive). Valid values are :offset | \&quot;start\&quot;</param>
        /// <param name="to">The ending page resource (inclusive). Valid values are :offset | \&quot;end\&quot;</param>
        /// <returns>List&lt;ActiveWidgetLayoutResponse&gt;</returns>
        List<ActiveWidgetLayoutResponse> ActiveWidgetLayoutServiceGetServices (string userName, string fields, string sortBy, int? pageSize, string from, string to);
        /// <summary>
        /// Update user widget layouts Updates user widget layout.
        /// </summary>
        /// <param name="userName">user name</param>
        /// <param name="body">input parameters in json form</param>
        /// <returns></returns>
        void ActiveWidgetLayoutServiceUpdateServices (string userName, ActiveWidgetLayoutRequest body);
        /// <summary>
        /// Create new user 
        /// </summary>
        /// <param name="userName">user name</param>
        /// <param name="body"></param>
        /// <returns></returns>
        void CreateUser (string userName, UserRequestCreateUserSwagger body);
        /// <summary>
        /// Creates one or more users in a single request 
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        void CreateUsers (UserRequestCreateUsersSwagger body);
        /// <summary>
        /// Delete single user 
        /// </summary>
        /// <param name="userName">user name</param>
        /// <returns></returns>
        void DeleteUser (string userName);
        /// <summary>
        /// Get single user 
        /// </summary>
        /// <param name="userName">user name</param>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param>
        /// <returns>UserResponseSwagger</returns>
        UserResponseSwagger GetUser (string userName, string fields);
        /// <summary>
        /// Get all users 
        /// </summary>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param>
        /// <param name="sortBy">Sort resources in result by (asc | desc)</param>
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param>
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param>
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param>
        /// <returns>List&lt;UserResponseSwagger&gt;</returns>
        List<UserResponseSwagger> GetUsers (string fields, string sortBy, int? pageSize, int? from, int? to);
        /// <summary>
        /// Update user details 
        /// </summary>
        /// <param name="userName">user name</param>
        /// <param name="body"></param>
        /// <returns></returns>
        void UpdateUser (string userName, UserRequestUpdateUserSwagger body);
        /// <summary>
        /// Get user authorization Returns user authorization details.
        /// </summary>
        /// <param name="userName">user name</param>
        /// <param name="authorizationId">Authorization Id</param>
        /// <param name="fields">Filter user authorization details</param>
        /// <returns>UserAuthorizationResponse</returns>
        UserAuthorizationResponse UserAuthorizationServiceGetAuthorization (string userName, string authorizationId, string fields);
        /// <summary>
        /// Get all authorizations Returns all authorization for user.
        /// </summary>
        /// <param name="userName">user name</param>
        /// <param name="fields">Filter user authorization details</param>
        /// <param name="sortBy">Sort user authorizations (asc | desc)</param>
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param>
        /// <param name="from">The starting page resource (inclusive). Valid values are :offset | \&quot;start\&quot;</param>
        /// <param name="to">The ending page resource (inclusive). Valid values are :offset | \&quot;end\&quot;</param>
        /// <returns>List&lt;UserAuthorizationResponse&gt;</returns>
        List<UserAuthorizationResponse> UserAuthorizationServiceGetAuthorizations (string userName, string fields, string sortBy, int? pageSize, string from, string to);
        /// <summary>
        /// Get user privilege Returns user privilege details.
        /// </summary>
        /// <param name="userName">user name</param>
        /// <param name="privilegeId">privilege id</param>
        /// <param name="fields">Filter user privilege details</param>
        /// <returns>UserPrivilegeResponse</returns>
        UserPrivilegeResponse UserPrivilegeServiceGetPrivilege (string userName, string privilegeId, string fields);
        /// <summary>
        /// Get all privileges Returns all privileges for user.
        /// </summary>
        /// <param name="userName">user name</param>
        /// <param name="fields">Filter user privileges</param>
        /// <param name="sortBy">Sort user privileges (asc | desc)</param>
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param>
        /// <param name="from">The starting page resource (inclusive). Valid values are :offset | \&quot;start\&quot;</param>
        /// <param name="to">The ending page resource (inclusive). Valid values are :offset | \&quot;end\&quot;</param>
        /// <returns>List&lt;UserPrivilegeResponse&gt;</returns>
        List<UserPrivilegeResponseSwagger> UserPrivilegeServiceGetPrivileges (string userName, string fields, string sortBy, int? pageSize, string from, string to);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UsersApi : IUsersApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UsersApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UsersApi(String basePath)
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
        /// Get user widget layouts Returns all active widget layouts for user.
        /// </summary>
        /// <param name="userName">user name</param> 
        /// <param name="fields">Filter user layout details</param> 
        /// <param name="sortBy">Sort layouts (asc | desc)</param> 
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param> 
        /// <param name="from">The starting page resource (inclusive). Valid values are :offset | \&quot;start\&quot;</param> 
        /// <param name="to">The ending page resource (inclusive). Valid values are :offset | \&quot;end\&quot;</param> 
        /// <returns>List&lt;ActiveWidgetLayoutResponse&gt;</returns>            
        public List<ActiveWidgetLayoutResponse> ActiveWidgetLayoutServiceGetServices (string userName, string fields, string sortBy, int? pageSize, string from, string to)
        {
            
            // verify the required parameter 'userName' is set
            if (userName == null) throw new ApiException(400, "Missing required parameter 'userName' when calling ActiveWidgetLayoutServiceGetServices");
            
    
            var path = "/users/{userName}/activeWidgetLayouts";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "userName" + "}", ApiClient.ParameterToString(userName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActiveWidgetLayoutServiceGetServices: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActiveWidgetLayoutServiceGetServices: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ActiveWidgetLayoutResponse>) ApiClient.Deserialize(response.Content, typeof(List<ActiveWidgetLayoutResponse>), response.Headers);
        }
    
        /// <summary>
        /// Update user widget layouts Updates user widget layout.
        /// </summary>
        /// <param name="userName">user name</param> 
        /// <param name="body">input parameters in json form</param> 
        /// <returns></returns>            
        public void ActiveWidgetLayoutServiceUpdateServices (string userName, ActiveWidgetLayoutRequest body)
        {
            
            // verify the required parameter 'userName' is set
            if (userName == null) throw new ApiException(400, "Missing required parameter 'userName' when calling ActiveWidgetLayoutServiceUpdateServices");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ActiveWidgetLayoutServiceUpdateServices");
            
    
            var path = "/users/{userName}/activeWidgetLayouts";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "userName" + "}", ApiClient.ParameterToString(userName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActiveWidgetLayoutServiceUpdateServices: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActiveWidgetLayoutServiceUpdateServices: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create new user 
        /// </summary>
        /// <param name="userName">user name</param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void CreateUser (string userName, UserRequestCreateUserSwagger body)
        {
            
            // verify the required parameter 'userName' is set
            if (userName == null) throw new ApiException(400, "Missing required parameter 'userName' when calling CreateUser");
            
    
            var path = "/users/{userName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "userName" + "}", ApiClient.ParameterToString(userName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Creates one or more users in a single request 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void CreateUsers (UserRequestCreateUsersSwagger body)
        {
            
    
            var path = "/users";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateUsers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateUsers: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete single user 
        /// </summary>
        /// <param name="userName">user name</param> 
        /// <returns></returns>            
        public void DeleteUser (string userName)
        {
            
            // verify the required parameter 'userName' is set
            if (userName == null) throw new ApiException(400, "Missing required parameter 'userName' when calling DeleteUser");
            
    
            var path = "/users/{userName}";
            path = path.Replace("{format}", "json");
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get single user 
        /// </summary>
        /// <param name="userName">user name</param> 
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param> 
        /// <returns>UserResponseSwagger</returns>            
        public UserResponseSwagger GetUser (string userName, string fields)
        {
            
            // verify the required parameter 'userName' is set
            if (userName == null) throw new ApiException(400, "Missing required parameter 'userName' when calling GetUser");
            
    
            var path = "/users/{userName}";
            path = path.Replace("{format}", "json");
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserResponseSwagger) ApiClient.Deserialize(response.Content, typeof(UserResponseSwagger), response.Headers);
        }
    
        /// <summary>
        /// Get all users 
        /// </summary>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param> 
        /// <param name="sortBy">Sort resources in result by (asc | desc)</param> 
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param> 
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param> 
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param> 
        /// <returns>List&lt;UserResponseSwagger&gt;</returns>            
        public List<UserResponseSwagger> GetUsers (string fields, string sortBy, int? pageSize, int? from, int? to)
        {
            
    
            var path = "/users";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUsers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUsers: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<UserResponseSwagger>) ApiClient.Deserialize(response.Content, typeof(List<UserResponseSwagger>), response.Headers);
        }
    
        /// <summary>
        /// Update user details 
        /// </summary>
        /// <param name="userName">user name</param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void UpdateUser (string userName, UserRequestUpdateUserSwagger body)
        {
            
            // verify the required parameter 'userName' is set
            if (userName == null) throw new ApiException(400, "Missing required parameter 'userName' when calling UpdateUser");
            
    
            var path = "/users/{userName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "userName" + "}", ApiClient.ParameterToString(userName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get user authorization Returns user authorization details.
        /// </summary>
        /// <param name="userName">user name</param> 
        /// <param name="authorizationId">Authorization Id</param> 
        /// <param name="fields">Filter user authorization details</param> 
        /// <returns>UserAuthorizationResponse</returns>            
        public UserAuthorizationResponse UserAuthorizationServiceGetAuthorization (string userName, string authorizationId, string fields)
        {
            
            // verify the required parameter 'userName' is set
            if (userName == null) throw new ApiException(400, "Missing required parameter 'userName' when calling UserAuthorizationServiceGetAuthorization");
            
            // verify the required parameter 'authorizationId' is set
            if (authorizationId == null) throw new ApiException(400, "Missing required parameter 'authorizationId' when calling UserAuthorizationServiceGetAuthorization");
            
    
            var path = "/users/{userName}/authorizations/{authorization_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "userName" + "}", ApiClient.ParameterToString(userName));
path = path.Replace("{" + "authorization_id" + "}", ApiClient.ParameterToString(authorizationId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UserAuthorizationServiceGetAuthorization: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserAuthorizationServiceGetAuthorization: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserAuthorizationResponse) ApiClient.Deserialize(response.Content, typeof(UserAuthorizationResponse), response.Headers);
        }
    
        /// <summary>
        /// Get all authorizations Returns all authorization for user.
        /// </summary>
        /// <param name="userName">user name</param> 
        /// <param name="fields">Filter user authorization details</param> 
        /// <param name="sortBy">Sort user authorizations (asc | desc)</param> 
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param> 
        /// <param name="from">The starting page resource (inclusive). Valid values are :offset | \&quot;start\&quot;</param> 
        /// <param name="to">The ending page resource (inclusive). Valid values are :offset | \&quot;end\&quot;</param> 
        /// <returns>List&lt;UserAuthorizationResponse&gt;</returns>            
        public List<UserAuthorizationResponse> UserAuthorizationServiceGetAuthorizations (string userName, string fields, string sortBy, int? pageSize, string from, string to)
        {
            
            // verify the required parameter 'userName' is set
            if (userName == null) throw new ApiException(400, "Missing required parameter 'userName' when calling UserAuthorizationServiceGetAuthorizations");
            
    
            var path = "/users/{userName}/authorizations";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "userName" + "}", ApiClient.ParameterToString(userName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UserAuthorizationServiceGetAuthorizations: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserAuthorizationServiceGetAuthorizations: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<UserAuthorizationResponse>) ApiClient.Deserialize(response.Content, typeof(List<UserAuthorizationResponse>), response.Headers);
        }
    
        /// <summary>
        /// Get user privilege Returns user privilege details.
        /// </summary>
        /// <param name="userName">user name</param> 
        /// <param name="privilegeId">privilege id</param> 
        /// <param name="fields">Filter user privilege details</param> 
        /// <returns>UserPrivilegeResponse</returns>            
        public UserPrivilegeResponse UserPrivilegeServiceGetPrivilege (string userName, string privilegeId, string fields)
        {
            
            // verify the required parameter 'userName' is set
            if (userName == null) throw new ApiException(400, "Missing required parameter 'userName' when calling UserPrivilegeServiceGetPrivilege");
            
            // verify the required parameter 'privilegeId' is set
            if (privilegeId == null) throw new ApiException(400, "Missing required parameter 'privilegeId' when calling UserPrivilegeServiceGetPrivilege");
            
    
            var path = "/users/{userName}/privileges/{privilegeId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "userName" + "}", ApiClient.ParameterToString(userName));
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
                throw new ApiException ((int)response.StatusCode, "Error calling UserPrivilegeServiceGetPrivilege: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserPrivilegeServiceGetPrivilege: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserPrivilegeResponse) ApiClient.Deserialize(response.Content, typeof(UserPrivilegeResponse), response.Headers);
        }
    
        /// <summary>
        /// Get all privileges Returns all privileges for user.
        /// </summary>
        /// <param name="userName">user name</param> 
        /// <param name="fields">Filter user privileges</param> 
        /// <param name="sortBy">Sort user privileges (asc | desc)</param> 
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param> 
        /// <param name="from">The starting page resource (inclusive). Valid values are :offset | \&quot;start\&quot;</param> 
        /// <param name="to">The ending page resource (inclusive). Valid values are :offset | \&quot;end\&quot;</param> 
        /// <returns>List&lt;UserPrivilegeResponse&gt;</returns>            
        public List<UserPrivilegeResponseSwagger> UserPrivilegeServiceGetPrivileges (string userName, string fields, string sortBy, int? pageSize, string from, string to)
        {
            
            // verify the required parameter 'userName' is set
            if (userName == null) throw new ApiException(400, "Missing required parameter 'userName' when calling UserPrivilegeServiceGetPrivileges");
            
    
            var path = "/users/{userName}/privileges";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "userName" + "}", ApiClient.ParameterToString(userName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UserPrivilegeServiceGetPrivileges: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserPrivilegeServiceGetPrivileges: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<UserPrivilegeResponseSwagger>) ApiClient.Deserialize(response.Content, typeof(List<UserPrivilegeResponseSwagger>), response.Headers);
        }
    
    }
}
