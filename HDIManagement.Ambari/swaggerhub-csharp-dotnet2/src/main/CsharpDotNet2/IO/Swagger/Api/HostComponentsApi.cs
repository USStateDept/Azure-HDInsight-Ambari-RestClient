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
    public interface IHostComponentsApi
    {
        /// <summary>
        /// Create new host component 
        /// </summary>
        /// <param name="hostComponentName"></param>
        /// <param name="clusterName"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void CreateHostComponent (string hostComponentName, string clusterName, ServiceComponentHostResponse body);
        /// <summary>
        /// Delete host component 
        /// </summary>
        /// <param name="hostComponentName"></param>
        /// <param name="clusterName"></param>
        /// <returns></returns>
        void DeleteHostComponent (string hostComponentName, string clusterName);
        /// <summary>
        /// Delete host components 
        /// </summary>
        /// <param name="clusterName"></param>
        /// <returns></returns>
        void DeleteHostComponents (string clusterName);
        /// <summary>
        /// Get single host component for a host 
        /// </summary>
        /// <param name="hostComponentName"></param>
        /// <param name="clusterName"></param>
        /// <param name="format"></param>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param>
        /// <returns>HostComponentSwagger</returns>
        HostComponentSwagger GetHostComponent (string hostComponentName, string clusterName, string format, string fields);
        /// <summary>
        /// Get all host components for a host 
        /// </summary>
        /// <param name="clusterName"></param>
        /// <param name="format"></param>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param>
        /// <returns>List&lt;HostComponentSwagger&gt;</returns>
        List<HostComponentSwagger> GetHostComponents (string clusterName, string format, string fields);
        /// <summary>
        /// Get processes of a specific host component 
        /// </summary>
        /// <param name="hostComponentName"></param>
        /// <param name="clusterName"></param>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param>
        /// <returns>HostComponentProcessResponse</returns>
        HostComponentProcessResponse GetProcesses (string hostComponentName, string clusterName, string fields);
        /// <summary>
        /// Update host component detail 
        /// </summary>
        /// <param name="hostComponentName"></param>
        /// <param name="clusterName"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void UpdateHostComponent (string hostComponentName, string clusterName, ServiceComponentHostResponse body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class HostComponentsApi : IHostComponentsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HostComponentsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public HostComponentsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="HostComponentsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public HostComponentsApi(String basePath)
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
        /// Create new host component 
        /// </summary>
        /// <param name="hostComponentName"></param> 
        /// <param name="clusterName"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void CreateHostComponent (string hostComponentName, string clusterName, ServiceComponentHostResponse body)
        {
            
            // verify the required parameter 'hostComponentName' is set
            if (hostComponentName == null) throw new ApiException(400, "Missing required parameter 'hostComponentName' when calling CreateHostComponent");
            
            // verify the required parameter 'clusterName' is set
            if (clusterName == null) throw new ApiException(400, "Missing required parameter 'clusterName' when calling CreateHostComponent");
            
    
            var path = "/clusters/{clusterName}/host_components/{hostComponentName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "hostComponentName" + "}", ApiClient.ParameterToString(hostComponentName));
path = path.Replace("{" + "clusterName" + "}", ApiClient.ParameterToString(clusterName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateHostComponent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateHostComponent: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete host component 
        /// </summary>
        /// <param name="hostComponentName"></param> 
        /// <param name="clusterName"></param> 
        /// <returns></returns>            
        public void DeleteHostComponent (string hostComponentName, string clusterName)
        {
            
            // verify the required parameter 'hostComponentName' is set
            if (hostComponentName == null) throw new ApiException(400, "Missing required parameter 'hostComponentName' when calling DeleteHostComponent");
            
            // verify the required parameter 'clusterName' is set
            if (clusterName == null) throw new ApiException(400, "Missing required parameter 'clusterName' when calling DeleteHostComponent");
            
    
            var path = "/clusters/{clusterName}/host_components/{hostComponentName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "hostComponentName" + "}", ApiClient.ParameterToString(hostComponentName));
path = path.Replace("{" + "clusterName" + "}", ApiClient.ParameterToString(clusterName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteHostComponent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteHostComponent: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete host components 
        /// </summary>
        /// <param name="clusterName"></param> 
        /// <returns></returns>            
        public void DeleteHostComponents (string clusterName)
        {
            
            // verify the required parameter 'clusterName' is set
            if (clusterName == null) throw new ApiException(400, "Missing required parameter 'clusterName' when calling DeleteHostComponents");
            
    
            var path = "/clusters/{clusterName}/host_components";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "clusterName" + "}", ApiClient.ParameterToString(clusterName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteHostComponents: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteHostComponents: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get single host component for a host 
        /// </summary>
        /// <param name="hostComponentName"></param> 
        /// <param name="clusterName"></param> 
        /// <param name="format"></param> 
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param> 
        /// <returns>HostComponentSwagger</returns>            
        public HostComponentSwagger GetHostComponent (string hostComponentName, string clusterName, string format, string fields)
        {
            
            // verify the required parameter 'hostComponentName' is set
            if (hostComponentName == null) throw new ApiException(400, "Missing required parameter 'hostComponentName' when calling GetHostComponent");
            
            // verify the required parameter 'clusterName' is set
            if (clusterName == null) throw new ApiException(400, "Missing required parameter 'clusterName' when calling GetHostComponent");
            
    
            var path = "/clusters/{clusterName}/host_components/{hostComponentName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "hostComponentName" + "}", ApiClient.ParameterToString(hostComponentName));
path = path.Replace("{" + "clusterName" + "}", ApiClient.ParameterToString(clusterName));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (format != null) queryParams.Add("format", ApiClient.ParameterToString(format)); // query parameter
 if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetHostComponent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetHostComponent: " + response.ErrorMessage, response.ErrorMessage);
    
            return (HostComponentSwagger) ApiClient.Deserialize(response.Content, typeof(HostComponentSwagger), response.Headers);
        }
    
        /// <summary>
        /// Get all host components for a host 
        /// </summary>
        /// <param name="clusterName"></param> 
        /// <param name="format"></param> 
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param> 
        /// <returns>List&lt;HostComponentSwagger&gt;</returns>            
        public List<HostComponentSwagger> GetHostComponents (string clusterName, string format, string fields)
        {
            
            // verify the required parameter 'clusterName' is set
            if (clusterName == null) throw new ApiException(400, "Missing required parameter 'clusterName' when calling GetHostComponents");
            
    
            var path = "/clusters/{clusterName}/host_components";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "clusterName" + "}", ApiClient.ParameterToString(clusterName));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (format != null) queryParams.Add("format", ApiClient.ParameterToString(format)); // query parameter
 if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetHostComponents: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetHostComponents: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<HostComponentSwagger>) ApiClient.Deserialize(response.Content, typeof(List<HostComponentSwagger>), response.Headers);
        }
    
        /// <summary>
        /// Get processes of a specific host component 
        /// </summary>
        /// <param name="hostComponentName"></param> 
        /// <param name="clusterName"></param> 
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param> 
        /// <returns>HostComponentProcessResponse</returns>            
        public HostComponentProcessResponse GetProcesses (string hostComponentName, string clusterName, string fields)
        {
            
            // verify the required parameter 'hostComponentName' is set
            if (hostComponentName == null) throw new ApiException(400, "Missing required parameter 'hostComponentName' when calling GetProcesses");
            
            // verify the required parameter 'clusterName' is set
            if (clusterName == null) throw new ApiException(400, "Missing required parameter 'clusterName' when calling GetProcesses");
            
    
            var path = "/clusters/{clusterName}/host_components/{hostComponentName}/processes";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "hostComponentName" + "}", ApiClient.ParameterToString(hostComponentName));
path = path.Replace("{" + "clusterName" + "}", ApiClient.ParameterToString(clusterName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetProcesses: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetProcesses: " + response.ErrorMessage, response.ErrorMessage);
    
            return (HostComponentProcessResponse) ApiClient.Deserialize(response.Content, typeof(HostComponentProcessResponse), response.Headers);
        }
    
        /// <summary>
        /// Update host component detail 
        /// </summary>
        /// <param name="hostComponentName"></param> 
        /// <param name="clusterName"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void UpdateHostComponent (string hostComponentName, string clusterName, ServiceComponentHostResponse body)
        {
            
            // verify the required parameter 'hostComponentName' is set
            if (hostComponentName == null) throw new ApiException(400, "Missing required parameter 'hostComponentName' when calling UpdateHostComponent");
            
            // verify the required parameter 'clusterName' is set
            if (clusterName == null) throw new ApiException(400, "Missing required parameter 'clusterName' when calling UpdateHostComponent");
            
    
            var path = "/clusters/{clusterName}/host_components/{hostComponentName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "hostComponentName" + "}", ApiClient.ParameterToString(hostComponentName));
path = path.Replace("{" + "clusterName" + "}", ApiClient.ParameterToString(clusterName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateHostComponent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateHostComponent: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
