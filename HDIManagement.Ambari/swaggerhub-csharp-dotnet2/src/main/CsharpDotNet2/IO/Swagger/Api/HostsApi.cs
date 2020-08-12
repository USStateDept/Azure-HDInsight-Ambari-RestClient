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
    public interface IHostsApi
    {
        /// <summary>
        /// Creates a host 
        /// </summary>
        /// <param name="hostName">host name</param>
        /// <param name="body"></param>
        /// <returns></returns>
        void CreateHost (string hostName, HostRequest body);
        /// <summary>
        /// Creates multiple hosts in a single request 
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        void CreateHosts (HostRequest body);
        /// <summary>
        /// Deletes a host 
        /// </summary>
        /// <param name="hostName">host name</param>
        /// <returns></returns>
        void DeleteHost (string hostName);
        /// <summary>
        /// Deletes multiple hosts in a single request 
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        void DeleteHosts (HostRequest body);
        /// <summary>
        /// Returns information about a single host 
        /// </summary>
        /// <param name="hostName">host name</param>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param>
        /// <returns>HostResponseWrapper</returns>
        HostResponseWrapper GetHost (string hostName, string fields);
        /// <summary>
        /// Returns a collection of all hosts 
        /// </summary>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param>
        /// <param name="sortBy">Sort resources in result by (asc | desc)</param>
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param>
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param>
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param>
        /// <returns>List&lt;HostResponseWrapper&gt;</returns>
        List<HostResponseWrapper> GetHosts (string fields, string sortBy, int? pageSize, int? from, int? to);
        /// <summary>
        /// Updates a host 
        /// </summary>
        /// <param name="hostName">host name</param>
        /// <param name="body"></param>
        /// <returns></returns>
        void UpdateHost (string hostName, HostRequest body);
        /// <summary>
        /// Updates multiple hosts in a single request 
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        void UpdateHosts (HostRequest body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class HostsApi : IHostsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HostsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public HostsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="HostsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public HostsApi(String basePath)
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
        /// Creates a host 
        /// </summary>
        /// <param name="hostName">host name</param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void CreateHost (string hostName, HostRequest body)
        {
            
            // verify the required parameter 'hostName' is set
            if (hostName == null) throw new ApiException(400, "Missing required parameter 'hostName' when calling CreateHost");
            
    
            var path = "/hosts/{hostName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "hostName" + "}", ApiClient.ParameterToString(hostName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateHost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateHost: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Creates multiple hosts in a single request 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void CreateHosts (HostRequest body)
        {
            
    
            var path = "/hosts";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateHosts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateHosts: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Deletes a host 
        /// </summary>
        /// <param name="hostName">host name</param> 
        /// <returns></returns>            
        public void DeleteHost (string hostName)
        {
            
            // verify the required parameter 'hostName' is set
            if (hostName == null) throw new ApiException(400, "Missing required parameter 'hostName' when calling DeleteHost");
            
    
            var path = "/hosts/{hostName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "hostName" + "}", ApiClient.ParameterToString(hostName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteHost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteHost: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Deletes multiple hosts in a single request 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void DeleteHosts (HostRequest body)
        {
            
    
            var path = "/hosts";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteHosts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteHosts: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Returns information about a single host 
        /// </summary>
        /// <param name="hostName">host name</param> 
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param> 
        /// <returns>HostResponseWrapper</returns>            
        public HostResponseWrapper GetHost (string hostName, string fields)
        {
            
            // verify the required parameter 'hostName' is set
            if (hostName == null) throw new ApiException(400, "Missing required parameter 'hostName' when calling GetHost");
            
    
            var path = "/hosts/{hostName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "hostName" + "}", ApiClient.ParameterToString(hostName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetHost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetHost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (HostResponseWrapper) ApiClient.Deserialize(response.Content, typeof(HostResponseWrapper), response.Headers);
        }
    
        /// <summary>
        /// Returns a collection of all hosts 
        /// </summary>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param> 
        /// <param name="sortBy">Sort resources in result by (asc | desc)</param> 
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param> 
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param> 
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param> 
        /// <returns>List&lt;HostResponseWrapper&gt;</returns>            
        public List<HostResponseWrapper> GetHosts (string fields, string sortBy, int? pageSize, int? from, int? to)
        {
            
    
            var path = "/hosts";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetHosts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetHosts: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<HostResponseWrapper>) ApiClient.Deserialize(response.Content, typeof(List<HostResponseWrapper>), response.Headers);
        }
    
        /// <summary>
        /// Updates a host 
        /// </summary>
        /// <param name="hostName">host name</param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void UpdateHost (string hostName, HostRequest body)
        {
            
            // verify the required parameter 'hostName' is set
            if (hostName == null) throw new ApiException(400, "Missing required parameter 'hostName' when calling UpdateHost");
            
    
            var path = "/hosts/{hostName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "hostName" + "}", ApiClient.ParameterToString(hostName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateHost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateHost: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Updates multiple hosts in a single request 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void UpdateHosts (HostRequest body)
        {
            
    
            var path = "/hosts";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateHosts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateHosts: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
