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
    public interface IUserAuthenticationSourcesApi
    {
        /// <summary>
        /// Create one or more new authentication sources for a user 
        /// </summary>
        /// <param name="userName">user name</param>
        /// <param name="body"></param>
        /// <returns></returns>
        void CreateAuthenticationSources (string userName, UserAuthenticationSourceRequestCreateSwagger body);
        /// <summary>
        /// Deletes an existing authentication source 
        /// </summary>
        /// <param name="userName">user name</param>
        /// <param name="sourceId">source id</param>
        /// <returns></returns>
        void DeleteAuthenticationSource (string userName, string sourceId);
        /// <summary>
        /// Get user authentication source 
        /// </summary>
        /// <param name="userName">user name</param>
        /// <param name="sourceId">source id</param>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param>
        /// <returns>UserAuthenticationSourceResponseSwagger</returns>
        UserAuthenticationSourceResponseSwagger GetAuthenticationSource (string userName, string sourceId, string fields);
        /// <summary>
        /// Get all authentication sources 
        /// </summary>
        /// <param name="userName">user name</param>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param>
        /// <param name="sortBy">Sort resources in result by (asc | desc)</param>
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param>
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param>
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param>
        /// <returns>List&lt;UserAuthenticationSourceResponseSwagger&gt;</returns>
        List<UserAuthenticationSourceResponseSwagger> GetAuthenticationSources (string userName, string fields, string sortBy, int? pageSize, int? from, int? to);
        /// <summary>
        /// Updates an existing authentication source 
        /// </summary>
        /// <param name="userName">user name</param>
        /// <param name="sourceId">source id</param>
        /// <param name="body"></param>
        /// <returns></returns>
        void UpdateAuthenticationSource (string userName, string sourceId, UserAuthenticationSourceRequestUpdateSwagger body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UserAuthenticationSourcesApi : IUserAuthenticationSourcesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAuthenticationSourcesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UserAuthenticationSourcesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAuthenticationSourcesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserAuthenticationSourcesApi(String basePath)
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
        /// Create one or more new authentication sources for a user 
        /// </summary>
        /// <param name="userName">user name</param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void CreateAuthenticationSources (string userName, UserAuthenticationSourceRequestCreateSwagger body)
        {
            
            // verify the required parameter 'userName' is set
            if (userName == null) throw new ApiException(400, "Missing required parameter 'userName' when calling CreateAuthenticationSources");
            
    
            var path = "/users/{userName}/sources";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateAuthenticationSources: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateAuthenticationSources: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Deletes an existing authentication source 
        /// </summary>
        /// <param name="userName">user name</param> 
        /// <param name="sourceId">source id</param> 
        /// <returns></returns>            
        public void DeleteAuthenticationSource (string userName, string sourceId)
        {
            
            // verify the required parameter 'userName' is set
            if (userName == null) throw new ApiException(400, "Missing required parameter 'userName' when calling DeleteAuthenticationSource");
            
            // verify the required parameter 'sourceId' is set
            if (sourceId == null) throw new ApiException(400, "Missing required parameter 'sourceId' when calling DeleteAuthenticationSource");
            
    
            var path = "/users/{userName}/sources/{sourceId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "userName" + "}", ApiClient.ParameterToString(userName));
path = path.Replace("{" + "sourceId" + "}", ApiClient.ParameterToString(sourceId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAuthenticationSource: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAuthenticationSource: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get user authentication source 
        /// </summary>
        /// <param name="userName">user name</param> 
        /// <param name="sourceId">source id</param> 
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param> 
        /// <returns>UserAuthenticationSourceResponseSwagger</returns>            
        public UserAuthenticationSourceResponseSwagger GetAuthenticationSource (string userName, string sourceId, string fields)
        {
            
            // verify the required parameter 'userName' is set
            if (userName == null) throw new ApiException(400, "Missing required parameter 'userName' when calling GetAuthenticationSource");
            
            // verify the required parameter 'sourceId' is set
            if (sourceId == null) throw new ApiException(400, "Missing required parameter 'sourceId' when calling GetAuthenticationSource");
            
    
            var path = "/users/{userName}/sources/{sourceId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "userName" + "}", ApiClient.ParameterToString(userName));
path = path.Replace("{" + "sourceId" + "}", ApiClient.ParameterToString(sourceId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetAuthenticationSource: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAuthenticationSource: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserAuthenticationSourceResponseSwagger) ApiClient.Deserialize(response.Content, typeof(UserAuthenticationSourceResponseSwagger), response.Headers);
        }
    
        /// <summary>
        /// Get all authentication sources 
        /// </summary>
        /// <param name="userName">user name</param> 
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param> 
        /// <param name="sortBy">Sort resources in result by (asc | desc)</param> 
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param> 
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param> 
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param> 
        /// <returns>List&lt;UserAuthenticationSourceResponseSwagger&gt;</returns>            
        public List<UserAuthenticationSourceResponseSwagger> GetAuthenticationSources (string userName, string fields, string sortBy, int? pageSize, int? from, int? to)
        {
            
            // verify the required parameter 'userName' is set
            if (userName == null) throw new ApiException(400, "Missing required parameter 'userName' when calling GetAuthenticationSources");
            
    
            var path = "/users/{userName}/sources";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetAuthenticationSources: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAuthenticationSources: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<UserAuthenticationSourceResponseSwagger>) ApiClient.Deserialize(response.Content, typeof(List<UserAuthenticationSourceResponseSwagger>), response.Headers);
        }
    
        /// <summary>
        /// Updates an existing authentication source 
        /// </summary>
        /// <param name="userName">user name</param> 
        /// <param name="sourceId">source id</param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void UpdateAuthenticationSource (string userName, string sourceId, UserAuthenticationSourceRequestUpdateSwagger body)
        {
            
            // verify the required parameter 'userName' is set
            if (userName == null) throw new ApiException(400, "Missing required parameter 'userName' when calling UpdateAuthenticationSource");
            
            // verify the required parameter 'sourceId' is set
            if (sourceId == null) throw new ApiException(400, "Missing required parameter 'sourceId' when calling UpdateAuthenticationSource");
            
    
            var path = "/users/{userName}/sources/{sourceId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "userName" + "}", ApiClient.ParameterToString(userName));
path = path.Replace("{" + "sourceId" + "}", ApiClient.ParameterToString(sourceId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateAuthenticationSource: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateAuthenticationSource: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
