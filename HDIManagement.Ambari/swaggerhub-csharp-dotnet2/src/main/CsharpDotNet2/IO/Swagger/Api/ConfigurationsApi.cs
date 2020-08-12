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
    public interface IConfigurationsApi
    {
        /// <summary>
        /// Create new configurations 
        /// </summary>
        /// <param name="clusterName"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void CreateConfigurations (string clusterName, ConfigurationRequest body);
        /// <summary>
        /// Get all configurations 
        /// </summary>
        /// <param name="clusterName"></param>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param>
        /// <param name="sortBy">Sort resources in result by (asc | desc)</param>
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param>
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param>
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param>
        /// <returns>List&lt;ConfigurationResponse&gt;</returns>
        List<ConfigurationResponse> GetConfigurations (string clusterName, string fields, string sortBy, int? pageSize, int? from, int? to);
        /// <summary>
        /// Get all service config versions 
        /// </summary>
        /// <param name="clusterName"></param>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param>
        /// <param name="sortBy">Sort resources in result by (asc | desc)</param>
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param>
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param>
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param>
        /// <returns>List&lt;ServiceConfigVersionResponse&gt;</returns>
        List<ServiceConfigVersionResponse> GetServiceConfigVersions (string clusterName, string fields, string sortBy, int? pageSize, int? from, int? to);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ConfigurationsApi : IConfigurationsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ConfigurationsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ConfigurationsApi(String basePath)
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
        /// Create new configurations 
        /// </summary>
        /// <param name="clusterName"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void CreateConfigurations (string clusterName, ConfigurationRequest body)
        {
            
            // verify the required parameter 'clusterName' is set
            if (clusterName == null) throw new ApiException(400, "Missing required parameter 'clusterName' when calling CreateConfigurations");
            
    
            var path = "/clusters/{clusterName}/configurations";
            path = path.Replace("{format}", "json");
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateConfigurations: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateConfigurations: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get all configurations 
        /// </summary>
        /// <param name="clusterName"></param> 
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param> 
        /// <param name="sortBy">Sort resources in result by (asc | desc)</param> 
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param> 
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param> 
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param> 
        /// <returns>List&lt;ConfigurationResponse&gt;</returns>            
        public List<ConfigurationResponse> GetConfigurations (string clusterName, string fields, string sortBy, int? pageSize, int? from, int? to)
        {
            
            // verify the required parameter 'clusterName' is set
            if (clusterName == null) throw new ApiException(400, "Missing required parameter 'clusterName' when calling GetConfigurations");
            
    
            var path = "/clusters/{clusterName}/configurations";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "clusterName" + "}", ApiClient.ParameterToString(clusterName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetConfigurations: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetConfigurations: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ConfigurationResponse>) ApiClient.Deserialize(response.Content, typeof(List<ConfigurationResponse>), response.Headers);
        }
    
        /// <summary>
        /// Get all service config versions 
        /// </summary>
        /// <param name="clusterName"></param> 
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param> 
        /// <param name="sortBy">Sort resources in result by (asc | desc)</param> 
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param> 
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param> 
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param> 
        /// <returns>List&lt;ServiceConfigVersionResponse&gt;</returns>            
        public List<ServiceConfigVersionResponse> GetServiceConfigVersions (string clusterName, string fields, string sortBy, int? pageSize, int? from, int? to)
        {
            
            // verify the required parameter 'clusterName' is set
            if (clusterName == null) throw new ApiException(400, "Missing required parameter 'clusterName' when calling GetServiceConfigVersions");
            
    
            var path = "/clusters/{clusterName}/configurations/service_config_versions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "clusterName" + "}", ApiClient.ParameterToString(clusterName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetServiceConfigVersions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetServiceConfigVersions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ServiceConfigVersionResponse>) ApiClient.Deserialize(response.Content, typeof(List<ServiceConfigVersionResponse>), response.Headers);
        }
    
    }
}
