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
    public interface IBlueprintsApi
    {
        /// <summary>
        /// Creates a blueprint 
        /// </summary>
        /// <param name="blueprintName"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void BlueprintServiceCreateBlueprint (string blueprintName, BlueprintSwagger body);
        /// <summary>
        /// Deletes a blueprint 
        /// </summary>
        /// <param name="blueprintName"></param>
        /// <returns></returns>
        void BlueprintServiceDeleteBlueprint (string blueprintName);
        /// <summary>
        /// Deletes multiple blueprints that match the predicate. Omitting the predicate will delete all blueprints. 
        /// </summary>
        /// <returns></returns>
        void BlueprintServiceDeleteBlueprints ();
        /// <summary>
        /// Get the details of a blueprint 
        /// </summary>
        /// <param name="blueprintName"></param>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param>
        /// <returns>List&lt;BlueprintSwagger&gt;</returns>
        List<BlueprintSwagger> BlueprintServiceGetBlueprint (string blueprintName, string fields);
        /// <summary>
        /// Get all blueprints 
        /// </summary>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param>
        /// <param name="sortBy">Sort resources in result by (asc | desc)</param>
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param>
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param>
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param>
        /// <returns>List&lt;BlueprintSwagger&gt;</returns>
        List<BlueprintSwagger> BlueprintServiceGetBlueprints (string fields, string sortBy, int? pageSize, string from, string to);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class BlueprintsApi : IBlueprintsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BlueprintsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public BlueprintsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BlueprintsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BlueprintsApi(String basePath)
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
        /// Creates a blueprint 
        /// </summary>
        /// <param name="blueprintName"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void BlueprintServiceCreateBlueprint (string blueprintName, BlueprintSwagger body)
        {
            
            // verify the required parameter 'blueprintName' is set
            if (blueprintName == null) throw new ApiException(400, "Missing required parameter 'blueprintName' when calling BlueprintServiceCreateBlueprint");
            
    
            var path = "/blueprints/{blueprintName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "blueprintName" + "}", ApiClient.ParameterToString(blueprintName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling BlueprintServiceCreateBlueprint: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BlueprintServiceCreateBlueprint: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Deletes a blueprint 
        /// </summary>
        /// <param name="blueprintName"></param> 
        /// <returns></returns>            
        public void BlueprintServiceDeleteBlueprint (string blueprintName)
        {
            
            // verify the required parameter 'blueprintName' is set
            if (blueprintName == null) throw new ApiException(400, "Missing required parameter 'blueprintName' when calling BlueprintServiceDeleteBlueprint");
            
    
            var path = "/blueprints/{blueprintName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "blueprintName" + "}", ApiClient.ParameterToString(blueprintName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling BlueprintServiceDeleteBlueprint: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BlueprintServiceDeleteBlueprint: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Deletes multiple blueprints that match the predicate. Omitting the predicate will delete all blueprints. 
        /// </summary>
        /// <returns></returns>            
        public void BlueprintServiceDeleteBlueprints ()
        {
            
    
            var path = "/blueprints";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling BlueprintServiceDeleteBlueprints: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BlueprintServiceDeleteBlueprints: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get the details of a blueprint 
        /// </summary>
        /// <param name="blueprintName"></param> 
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param> 
        /// <returns>List&lt;BlueprintSwagger&gt;</returns>            
        public List<BlueprintSwagger> BlueprintServiceGetBlueprint (string blueprintName, string fields)
        {
            
            // verify the required parameter 'blueprintName' is set
            if (blueprintName == null) throw new ApiException(400, "Missing required parameter 'blueprintName' when calling BlueprintServiceGetBlueprint");
            
    
            var path = "/blueprints/{blueprintName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "blueprintName" + "}", ApiClient.ParameterToString(blueprintName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling BlueprintServiceGetBlueprint: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BlueprintServiceGetBlueprint: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<BlueprintSwagger>) ApiClient.Deserialize(response.Content, typeof(List<BlueprintSwagger>), response.Headers);
        }
    
        /// <summary>
        /// Get all blueprints 
        /// </summary>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param> 
        /// <param name="sortBy">Sort resources in result by (asc | desc)</param> 
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param> 
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param> 
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param> 
        /// <returns>List&lt;BlueprintSwagger&gt;</returns>            
        public List<BlueprintSwagger> BlueprintServiceGetBlueprints (string fields, string sortBy, int? pageSize, string from, string to)
        {
            
    
            var path = "/blueprints";
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
                throw new ApiException ((int)response.StatusCode, "Error calling BlueprintServiceGetBlueprints: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BlueprintServiceGetBlueprints: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<BlueprintSwagger>) ApiClient.Deserialize(response.Content, typeof(List<BlueprintSwagger>), response.Headers);
        }
    
    }
}
