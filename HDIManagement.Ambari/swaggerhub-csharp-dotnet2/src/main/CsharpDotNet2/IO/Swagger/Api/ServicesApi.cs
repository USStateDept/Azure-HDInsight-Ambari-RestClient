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
    public interface IServicesApi
    {
        /// <summary>
        /// Returns information about the given host 
        /// </summary>
        /// <param name="hostName">host name</param>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param>
        /// <returns>HostResponseWrapper</returns>
        HostResponseWrapper GetRootHost (string hostName, string fields);
        /// <summary>
        /// Returns the list of hosts for the given root-level service 
        /// </summary>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param>
        /// <returns>List&lt;HostResponseWrapper&gt;</returns>
        List<HostResponseWrapper> GetRootHosts (string fields);
        /// <summary>
        /// Returns information about the given root-level service, including a list of its components 
        /// </summary>
        /// <param name="serviceName">service name</param>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param>
        /// <returns>RootServiceResponseWithComponentList</returns>
        RootServiceResponseWithComponentList GetRootService (string serviceName, string fields);
        /// <summary>
        /// Returns information about the given component for the given root-level service 
        /// </summary>
        /// <param name="serviceName">service name</param>
        /// <param name="componentName">component name</param>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param>
        /// <returns>RootServiceComponentWithHostComponentList</returns>
        RootServiceComponentWithHostComponentList GetRootServiceComponent (string serviceName, string componentName, string fields);
        /// <summary>
        /// Returns the list of hosts for the given root-level service component 
        /// </summary>
        /// <param name="serviceName">service name</param>
        /// <param name="componentName">component name</param>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param>
        /// <returns>List&lt;RootServiceHostComponentResponseWrapper&gt;</returns>
        List<RootServiceHostComponentResponseWrapper> GetRootServiceComponentHosts (string serviceName, string componentName, string fields);
        /// <summary>
        /// Returns the list of components for the given root-level service 
        /// </summary>
        /// <param name="serviceName">service name</param>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param>
        /// <returns>List&lt;RootServiceComponentResponseWrapper&gt;</returns>
        List<RootServiceComponentResponseWrapper> GetRootServiceComponents (string serviceName, string fields);
        /// <summary>
        /// Returns information about the given component for the given root-level service on the given host 
        /// </summary>
        /// <param name="serviceName">service name</param>
        /// <param name="hostName">host name</param>
        /// <param name="hostComponent">component name</param>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param>
        /// <returns>RootServiceHostComponentResponseWrapper</returns>
        RootServiceHostComponentResponseWrapper GetRootServiceHostComponent (string serviceName, string hostName, string hostComponent, string fields);
        /// <summary>
        /// Returns the list of components for the given root-level service on the given host 
        /// </summary>
        /// <param name="serviceName">service name</param>
        /// <param name="hostName">host name</param>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param>
        /// <returns>List&lt;RootServiceHostComponentResponseWrapper&gt;</returns>
        List<RootServiceHostComponentResponseWrapper> GetRootServiceHostComponents (string serviceName, string hostName, string fields);
        /// <summary>
        /// Returns the list of root-level services 
        /// </summary>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param>
        /// <returns>List&lt;RootServiceResponseWrapper&gt;</returns>
        List<RootServiceResponseWrapper> GetRootServices (string fields);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ServicesApi : IServicesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServicesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ServicesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ServicesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ServicesApi(String basePath)
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
        /// Returns information about the given host 
        /// </summary>
        /// <param name="hostName">host name</param> 
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param> 
        /// <returns>HostResponseWrapper</returns>            
        public HostResponseWrapper GetRootHost (string hostName, string fields)
        {
            
            // verify the required parameter 'hostName' is set
            if (hostName == null) throw new ApiException(400, "Missing required parameter 'hostName' when calling GetRootHost");
            
    
            var path = "/services/{serviceName}/hosts/{hostName}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetRootHost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRootHost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (HostResponseWrapper) ApiClient.Deserialize(response.Content, typeof(HostResponseWrapper), response.Headers);
        }
    
        /// <summary>
        /// Returns the list of hosts for the given root-level service 
        /// </summary>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param> 
        /// <returns>List&lt;HostResponseWrapper&gt;</returns>            
        public List<HostResponseWrapper> GetRootHosts (string fields)
        {
            
    
            var path = "/services/{serviceName}/hosts";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetRootHosts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRootHosts: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<HostResponseWrapper>) ApiClient.Deserialize(response.Content, typeof(List<HostResponseWrapper>), response.Headers);
        }
    
        /// <summary>
        /// Returns information about the given root-level service, including a list of its components 
        /// </summary>
        /// <param name="serviceName">service name</param> 
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param> 
        /// <returns>RootServiceResponseWithComponentList</returns>            
        public RootServiceResponseWithComponentList GetRootService (string serviceName, string fields)
        {
            
            // verify the required parameter 'serviceName' is set
            if (serviceName == null) throw new ApiException(400, "Missing required parameter 'serviceName' when calling GetRootService");
            
    
            var path = "/services/{serviceName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "serviceName" + "}", ApiClient.ParameterToString(serviceName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetRootService: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRootService: " + response.ErrorMessage, response.ErrorMessage);
    
            return (RootServiceResponseWithComponentList) ApiClient.Deserialize(response.Content, typeof(RootServiceResponseWithComponentList), response.Headers);
        }
    
        /// <summary>
        /// Returns information about the given component for the given root-level service 
        /// </summary>
        /// <param name="serviceName">service name</param> 
        /// <param name="componentName">component name</param> 
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param> 
        /// <returns>RootServiceComponentWithHostComponentList</returns>            
        public RootServiceComponentWithHostComponentList GetRootServiceComponent (string serviceName, string componentName, string fields)
        {
            
            // verify the required parameter 'serviceName' is set
            if (serviceName == null) throw new ApiException(400, "Missing required parameter 'serviceName' when calling GetRootServiceComponent");
            
            // verify the required parameter 'componentName' is set
            if (componentName == null) throw new ApiException(400, "Missing required parameter 'componentName' when calling GetRootServiceComponent");
            
    
            var path = "/services/{serviceName}/components/{componentName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "serviceName" + "}", ApiClient.ParameterToString(serviceName));
path = path.Replace("{" + "componentName" + "}", ApiClient.ParameterToString(componentName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetRootServiceComponent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRootServiceComponent: " + response.ErrorMessage, response.ErrorMessage);
    
            return (RootServiceComponentWithHostComponentList) ApiClient.Deserialize(response.Content, typeof(RootServiceComponentWithHostComponentList), response.Headers);
        }
    
        /// <summary>
        /// Returns the list of hosts for the given root-level service component 
        /// </summary>
        /// <param name="serviceName">service name</param> 
        /// <param name="componentName">component name</param> 
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param> 
        /// <returns>List&lt;RootServiceHostComponentResponseWrapper&gt;</returns>            
        public List<RootServiceHostComponentResponseWrapper> GetRootServiceComponentHosts (string serviceName, string componentName, string fields)
        {
            
            // verify the required parameter 'serviceName' is set
            if (serviceName == null) throw new ApiException(400, "Missing required parameter 'serviceName' when calling GetRootServiceComponentHosts");
            
            // verify the required parameter 'componentName' is set
            if (componentName == null) throw new ApiException(400, "Missing required parameter 'componentName' when calling GetRootServiceComponentHosts");
            
    
            var path = "/services/{serviceName}/components/{componentName}/hostComponents";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "serviceName" + "}", ApiClient.ParameterToString(serviceName));
path = path.Replace("{" + "componentName" + "}", ApiClient.ParameterToString(componentName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetRootServiceComponentHosts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRootServiceComponentHosts: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<RootServiceHostComponentResponseWrapper>) ApiClient.Deserialize(response.Content, typeof(List<RootServiceHostComponentResponseWrapper>), response.Headers);
        }
    
        /// <summary>
        /// Returns the list of components for the given root-level service 
        /// </summary>
        /// <param name="serviceName">service name</param> 
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param> 
        /// <returns>List&lt;RootServiceComponentResponseWrapper&gt;</returns>            
        public List<RootServiceComponentResponseWrapper> GetRootServiceComponents (string serviceName, string fields)
        {
            
            // verify the required parameter 'serviceName' is set
            if (serviceName == null) throw new ApiException(400, "Missing required parameter 'serviceName' when calling GetRootServiceComponents");
            
    
            var path = "/services/{serviceName}/components";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "serviceName" + "}", ApiClient.ParameterToString(serviceName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetRootServiceComponents: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRootServiceComponents: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<RootServiceComponentResponseWrapper>) ApiClient.Deserialize(response.Content, typeof(List<RootServiceComponentResponseWrapper>), response.Headers);
        }
    
        /// <summary>
        /// Returns information about the given component for the given root-level service on the given host 
        /// </summary>
        /// <param name="serviceName">service name</param> 
        /// <param name="hostName">host name</param> 
        /// <param name="hostComponent">component name</param> 
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param> 
        /// <returns>RootServiceHostComponentResponseWrapper</returns>            
        public RootServiceHostComponentResponseWrapper GetRootServiceHostComponent (string serviceName, string hostName, string hostComponent, string fields)
        {
            
            // verify the required parameter 'serviceName' is set
            if (serviceName == null) throw new ApiException(400, "Missing required parameter 'serviceName' when calling GetRootServiceHostComponent");
            
            // verify the required parameter 'hostName' is set
            if (hostName == null) throw new ApiException(400, "Missing required parameter 'hostName' when calling GetRootServiceHostComponent");
            
            // verify the required parameter 'hostComponent' is set
            if (hostComponent == null) throw new ApiException(400, "Missing required parameter 'hostComponent' when calling GetRootServiceHostComponent");
            
    
            var path = "/services/{serviceName}/hosts/{hostName}/hostComponents/{hostComponent}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "serviceName" + "}", ApiClient.ParameterToString(serviceName));
path = path.Replace("{" + "hostName" + "}", ApiClient.ParameterToString(hostName));
path = path.Replace("{" + "hostComponent" + "}", ApiClient.ParameterToString(hostComponent));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetRootServiceHostComponent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRootServiceHostComponent: " + response.ErrorMessage, response.ErrorMessage);
    
            return (RootServiceHostComponentResponseWrapper) ApiClient.Deserialize(response.Content, typeof(RootServiceHostComponentResponseWrapper), response.Headers);
        }
    
        /// <summary>
        /// Returns the list of components for the given root-level service on the given host 
        /// </summary>
        /// <param name="serviceName">service name</param> 
        /// <param name="hostName">host name</param> 
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param> 
        /// <returns>List&lt;RootServiceHostComponentResponseWrapper&gt;</returns>            
        public List<RootServiceHostComponentResponseWrapper> GetRootServiceHostComponents (string serviceName, string hostName, string fields)
        {
            
            // verify the required parameter 'serviceName' is set
            if (serviceName == null) throw new ApiException(400, "Missing required parameter 'serviceName' when calling GetRootServiceHostComponents");
            
            // verify the required parameter 'hostName' is set
            if (hostName == null) throw new ApiException(400, "Missing required parameter 'hostName' when calling GetRootServiceHostComponents");
            
    
            var path = "/services/{serviceName}/hosts/{hostName}/hostComponents";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "serviceName" + "}", ApiClient.ParameterToString(serviceName));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetRootServiceHostComponents: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRootServiceHostComponents: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<RootServiceHostComponentResponseWrapper>) ApiClient.Deserialize(response.Content, typeof(List<RootServiceHostComponentResponseWrapper>), response.Headers);
        }
    
        /// <summary>
        /// Returns the list of root-level services 
        /// </summary>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param> 
        /// <returns>List&lt;RootServiceResponseWrapper&gt;</returns>            
        public List<RootServiceResponseWrapper> GetRootServices (string fields)
        {
            
    
            var path = "/services";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetRootServices: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRootServices: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<RootServiceResponseWrapper>) ApiClient.Deserialize(response.Content, typeof(List<RootServiceResponseWrapper>), response.Headers);
        }
    
    }
}
