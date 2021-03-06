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
    public interface IActionsApi
    {
        /// <summary>
        /// Creates an action definition - Currently Not Supported 
        /// </summary>
        /// <param name="actionName"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void ActionServiceCreateActionDefinition (string actionName, ActionRequestSwagger body);
        /// <summary>
        /// Deletes an action definition - Currently Not Supported 
        /// </summary>
        /// <param name="actionName"></param>
        /// <returns></returns>
        void ActionServiceDeleteActionDefinition (string actionName);
        /// <summary>
        /// Get the details of an action definition 
        /// </summary>
        /// <param name="actionName"></param>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param>
        /// <returns>ActionResponseSwagger</returns>
        ActionResponseSwagger ActionServiceGetActionDefinition (string actionName, string fields);
        /// <summary>
        /// Get all action definitions 
        /// </summary>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param>
        /// <param name="sortBy">Sort resources in result by (asc | desc)</param>
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param>
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param>
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param>
        /// <returns>List&lt;ActionResponseSwagger&gt;</returns>
        List<ActionResponseSwagger> ActionServiceGetActionDefinitions (string fields, string sortBy, int? pageSize, string from, string to);
        /// <summary>
        /// Updates an action definition - Currently Not Supported 
        /// </summary>
        /// <param name="actionName"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void ActionServiceUpdateActionDefinition (string actionName, ActionRequestSwagger body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ActionsApi : IActionsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ActionsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ActionsApi(String basePath)
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
        /// Creates an action definition - Currently Not Supported 
        /// </summary>
        /// <param name="actionName"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void ActionServiceCreateActionDefinition (string actionName, ActionRequestSwagger body)
        {
            
            // verify the required parameter 'actionName' is set
            if (actionName == null) throw new ApiException(400, "Missing required parameter 'actionName' when calling ActionServiceCreateActionDefinition");
            
    
            var path = "/actions/{actionName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "actionName" + "}", ApiClient.ParameterToString(actionName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionServiceCreateActionDefinition: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionServiceCreateActionDefinition: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Deletes an action definition - Currently Not Supported 
        /// </summary>
        /// <param name="actionName"></param> 
        /// <returns></returns>            
        public void ActionServiceDeleteActionDefinition (string actionName)
        {
            
            // verify the required parameter 'actionName' is set
            if (actionName == null) throw new ApiException(400, "Missing required parameter 'actionName' when calling ActionServiceDeleteActionDefinition");
            
    
            var path = "/actions/{actionName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "actionName" + "}", ApiClient.ParameterToString(actionName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionServiceDeleteActionDefinition: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionServiceDeleteActionDefinition: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get the details of an action definition 
        /// </summary>
        /// <param name="actionName"></param> 
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param> 
        /// <returns>ActionResponseSwagger</returns>            
        public ActionResponseSwagger ActionServiceGetActionDefinition (string actionName, string fields)
        {
            
            // verify the required parameter 'actionName' is set
            if (actionName == null) throw new ApiException(400, "Missing required parameter 'actionName' when calling ActionServiceGetActionDefinition");
            
    
            var path = "/actions/{actionName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "actionName" + "}", ApiClient.ParameterToString(actionName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionServiceGetActionDefinition: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionServiceGetActionDefinition: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ActionResponseSwagger) ApiClient.Deserialize(response.Content, typeof(ActionResponseSwagger), response.Headers);
        }
    
        /// <summary>
        /// Get all action definitions 
        /// </summary>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param> 
        /// <param name="sortBy">Sort resources in result by (asc | desc)</param> 
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param> 
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param> 
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param> 
        /// <returns>List&lt;ActionResponseSwagger&gt;</returns>            
        public List<ActionResponseSwagger> ActionServiceGetActionDefinitions (string fields, string sortBy, int? pageSize, string from, string to)
        {
            
    
            var path = "/actions";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionServiceGetActionDefinitions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionServiceGetActionDefinitions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ActionResponseSwagger>) ApiClient.Deserialize(response.Content, typeof(List<ActionResponseSwagger>), response.Headers);
        }
    
        /// <summary>
        /// Updates an action definition - Currently Not Supported 
        /// </summary>
        /// <param name="actionName"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void ActionServiceUpdateActionDefinition (string actionName, ActionRequestSwagger body)
        {
            
            // verify the required parameter 'actionName' is set
            if (actionName == null) throw new ApiException(400, "Missing required parameter 'actionName' when calling ActionServiceUpdateActionDefinition");
            
    
            var path = "/actions/{actionName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "actionName" + "}", ApiClient.ParameterToString(actionName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionServiceUpdateActionDefinition: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionServiceUpdateActionDefinition: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
