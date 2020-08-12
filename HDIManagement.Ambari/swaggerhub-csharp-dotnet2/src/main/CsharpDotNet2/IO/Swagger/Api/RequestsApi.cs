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
    public interface IRequestsApi
    {
        /// <summary>
        /// Creates one or more Requests 
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        void RequestServiceCreateRequests (RequestPostRequest body);
        /// <summary>
        /// Get the details of a request 
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param>
        /// <returns>RequestResponse</returns>
        RequestResponse RequestServiceGetRequest (string requestId, string fields);
        /// <summary>
        /// Get all requests. A predicate can be given to filter results. 
        /// </summary>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param>
        /// <param name="sortBy">Sort resources in result by (asc | desc)</param>
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param>
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param>
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param>
        /// <returns>List&lt;RequestResponse&gt;</returns>
        List<RequestResponse> RequestServiceGetRequests (string fields, string sortBy, int? pageSize, string from, string to);
        /// <summary>
        /// Updates a request, usually used to cancel running requests. Changes the state of an existing request. Usually used to cancel running requests.
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void RequestServiceUpdateRequests (string requestId, RequestPutRequest body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RequestsApi : IRequestsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public RequestsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RequestsApi(String basePath)
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
        /// Creates one or more Requests 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void RequestServiceCreateRequests (RequestPostRequest body)
        {
            
    
            var path = "/requests";
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
                throw new ApiException ((int)response.StatusCode, "Error calling RequestServiceCreateRequests: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RequestServiceCreateRequests: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get the details of a request 
        /// </summary>
        /// <param name="requestId"></param> 
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param> 
        /// <returns>RequestResponse</returns>            
        public RequestResponse RequestServiceGetRequest (string requestId, string fields)
        {
            
            // verify the required parameter 'requestId' is set
            if (requestId == null) throw new ApiException(400, "Missing required parameter 'requestId' when calling RequestServiceGetRequest");
            
    
            var path = "/requests/{requestId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "requestId" + "}", ApiClient.ParameterToString(requestId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling RequestServiceGetRequest: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RequestServiceGetRequest: " + response.ErrorMessage, response.ErrorMessage);
    
            return (RequestResponse) ApiClient.Deserialize(response.Content, typeof(RequestResponse), response.Headers);
        }
    
        /// <summary>
        /// Get all requests. A predicate can be given to filter results. 
        /// </summary>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param> 
        /// <param name="sortBy">Sort resources in result by (asc | desc)</param> 
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param> 
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param> 
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param> 
        /// <returns>List&lt;RequestResponse&gt;</returns>            
        public List<RequestResponse> RequestServiceGetRequests (string fields, string sortBy, int? pageSize, string from, string to)
        {
            
    
            var path = "/requests";
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
                throw new ApiException ((int)response.StatusCode, "Error calling RequestServiceGetRequests: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RequestServiceGetRequests: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<RequestResponse>) ApiClient.Deserialize(response.Content, typeof(List<RequestResponse>), response.Headers);
        }
    
        /// <summary>
        /// Updates a request, usually used to cancel running requests. Changes the state of an existing request. Usually used to cancel running requests.
        /// </summary>
        /// <param name="requestId"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void RequestServiceUpdateRequests (string requestId, RequestPutRequest body)
        {
            
            // verify the required parameter 'requestId' is set
            if (requestId == null) throw new ApiException(400, "Missing required parameter 'requestId' when calling RequestServiceUpdateRequests");
            
    
            var path = "/requests/{requestId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "requestId" + "}", ApiClient.ParameterToString(requestId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling RequestServiceUpdateRequests: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RequestServiceUpdateRequests: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
