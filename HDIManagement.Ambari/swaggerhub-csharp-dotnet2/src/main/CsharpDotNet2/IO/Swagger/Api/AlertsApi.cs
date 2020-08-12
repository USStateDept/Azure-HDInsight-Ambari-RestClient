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
    public interface IAlertsApi
    {
        /// <summary>
        /// Creates an alert target 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="validateConfig"></param>
        /// <param name="overwriteExisting"></param>
        /// <returns></returns>
        void CreateTarget (AlertTargetSwagger body, string validateConfig, string overwriteExisting);
        /// <summary>
        /// Deletes an alert target 
        /// </summary>
        /// <param name="targetId"></param>
        /// <returns></returns>
        void DeleteTarget (long? targetId);
        /// <summary>
        /// Returns a single alert target 
        /// </summary>
        /// <param name="targetId">alert target id</param>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param>
        /// <param name="sortBy">Sort resources in result by (asc | desc)</param>
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param>
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param>
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param>
        /// <returns>AlertTargetSwagger</returns>
        AlertTargetSwagger GetTarget (long? targetId, string fields, string sortBy, int? pageSize, int? from, int? to);
        /// <summary>
        /// Returns all alert targets 
        /// </summary>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param>
        /// <param name="sortBy">Sort resources in result by (asc | desc)</param>
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param>
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param>
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param>
        /// <returns>List&lt;AlertTargetSwagger&gt;</returns>
        List<AlertTargetSwagger> GetTargets (string fields, string sortBy, int? pageSize, int? from, int? to);
        /// <summary>
        /// Updates an alert target 
        /// </summary>
        /// <param name="targetId"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void UpdateTarget (long? targetId, AlertTargetSwagger body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AlertsApi : IAlertsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlertsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AlertsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AlertsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlertsApi(String basePath)
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
        /// Creates an alert target 
        /// </summary>
        /// <param name="body"></param> 
        /// <param name="validateConfig"></param> 
        /// <param name="overwriteExisting"></param> 
        /// <returns></returns>            
        public void CreateTarget (AlertTargetSwagger body, string validateConfig, string overwriteExisting)
        {
            
    
            var path = "/alert_targets";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (validateConfig != null) queryParams.Add("validate_config", ApiClient.ParameterToString(validateConfig)); // query parameter
 if (overwriteExisting != null) queryParams.Add("overwrite_existing", ApiClient.ParameterToString(overwriteExisting)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateTarget: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateTarget: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Deletes an alert target 
        /// </summary>
        /// <param name="targetId"></param> 
        /// <returns></returns>            
        public void DeleteTarget (long? targetId)
        {
            
            // verify the required parameter 'targetId' is set
            if (targetId == null) throw new ApiException(400, "Missing required parameter 'targetId' when calling DeleteTarget");
            
    
            var path = "/alert_targets/{targetId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "targetId" + "}", ApiClient.ParameterToString(targetId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteTarget: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteTarget: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Returns a single alert target 
        /// </summary>
        /// <param name="targetId">alert target id</param> 
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param> 
        /// <param name="sortBy">Sort resources in result by (asc | desc)</param> 
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param> 
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param> 
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param> 
        /// <returns>AlertTargetSwagger</returns>            
        public AlertTargetSwagger GetTarget (long? targetId, string fields, string sortBy, int? pageSize, int? from, int? to)
        {
            
            // verify the required parameter 'targetId' is set
            if (targetId == null) throw new ApiException(400, "Missing required parameter 'targetId' when calling GetTarget");
            
    
            var path = "/alert_targets/{targetId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "targetId" + "}", ApiClient.ParameterToString(targetId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetTarget: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTarget: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AlertTargetSwagger) ApiClient.Deserialize(response.Content, typeof(AlertTargetSwagger), response.Headers);
        }
    
        /// <summary>
        /// Returns all alert targets 
        /// </summary>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param> 
        /// <param name="sortBy">Sort resources in result by (asc | desc)</param> 
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param> 
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param> 
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param> 
        /// <returns>List&lt;AlertTargetSwagger&gt;</returns>            
        public List<AlertTargetSwagger> GetTargets (string fields, string sortBy, int? pageSize, int? from, int? to)
        {
            
    
            var path = "/alert_targets";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetTargets: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTargets: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AlertTargetSwagger>) ApiClient.Deserialize(response.Content, typeof(List<AlertTargetSwagger>), response.Headers);
        }
    
        /// <summary>
        /// Updates an alert target 
        /// </summary>
        /// <param name="targetId"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void UpdateTarget (long? targetId, AlertTargetSwagger body)
        {
            
            // verify the required parameter 'targetId' is set
            if (targetId == null) throw new ApiException(400, "Missing required parameter 'targetId' when calling UpdateTarget");
            
    
            var path = "/alert_targets/{targetId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "targetId" + "}", ApiClient.ParameterToString(targetId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateTarget: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateTarget: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
