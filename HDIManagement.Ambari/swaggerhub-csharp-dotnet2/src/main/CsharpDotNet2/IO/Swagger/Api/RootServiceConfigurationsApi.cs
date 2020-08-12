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
    public interface IRootServiceConfigurationsApi
    {
        /// <summary>
        /// Deletes a root service component configuration resource 
        /// </summary>
        /// <param name="category"></param>
        /// <param name="serviceName"></param>
        /// <param name="componentName"></param>
        /// <returns></returns>
        void RootServiceComponentConfigurationServiceDeleteConfiguration (string category, string serviceName, string componentName);
        /// <summary>
        /// Retrieve the details of a root service component configuration resource 
        /// </summary>
        /// <param name="category"></param>
        /// <param name="serviceName"></param>
        /// <param name="componentName"></param>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param>
        /// <returns>RootServiceComponentConfigurationResponseSwagger</returns>
        RootServiceComponentConfigurationResponseSwagger RootServiceComponentConfigurationServiceGetConfiguration (string category, string serviceName, string componentName, string fields);
        /// <summary>
        /// Updates root service component configuration resources  
        /// </summary>
        /// <param name="category"></param>
        /// <param name="serviceName"></param>
        /// <param name="componentName"></param>
        /// <param name="body"></param>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param>
        /// <returns></returns>
        void RootServiceComponentConfigurationServiceUpdateConfiguration (string category, string serviceName, string componentName, RootServiceComponentConfigurationRequestSwagger body, string fields);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RootServiceConfigurationsApi : IRootServiceConfigurationsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RootServiceConfigurationsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public RootServiceConfigurationsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RootServiceConfigurationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RootServiceConfigurationsApi(String basePath)
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
        /// Deletes a root service component configuration resource 
        /// </summary>
        /// <param name="category"></param> 
        /// <param name="serviceName"></param> 
        /// <param name="componentName"></param> 
        /// <returns></returns>            
        public void RootServiceComponentConfigurationServiceDeleteConfiguration (string category, string serviceName, string componentName)
        {
            
            // verify the required parameter 'category' is set
            if (category == null) throw new ApiException(400, "Missing required parameter 'category' when calling RootServiceComponentConfigurationServiceDeleteConfiguration");
            
            // verify the required parameter 'serviceName' is set
            if (serviceName == null) throw new ApiException(400, "Missing required parameter 'serviceName' when calling RootServiceComponentConfigurationServiceDeleteConfiguration");
            
            // verify the required parameter 'componentName' is set
            if (componentName == null) throw new ApiException(400, "Missing required parameter 'componentName' when calling RootServiceComponentConfigurationServiceDeleteConfiguration");
            
    
            var path = "/services/{serviceName}/components/{componentName}/configurations/{category}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "category" + "}", ApiClient.ParameterToString(category));
path = path.Replace("{" + "serviceName" + "}", ApiClient.ParameterToString(serviceName));
path = path.Replace("{" + "componentName" + "}", ApiClient.ParameterToString(componentName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling RootServiceComponentConfigurationServiceDeleteConfiguration: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RootServiceComponentConfigurationServiceDeleteConfiguration: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Retrieve the details of a root service component configuration resource 
        /// </summary>
        /// <param name="category"></param> 
        /// <param name="serviceName"></param> 
        /// <param name="componentName"></param> 
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param> 
        /// <returns>RootServiceComponentConfigurationResponseSwagger</returns>            
        public RootServiceComponentConfigurationResponseSwagger RootServiceComponentConfigurationServiceGetConfiguration (string category, string serviceName, string componentName, string fields)
        {
            
            // verify the required parameter 'category' is set
            if (category == null) throw new ApiException(400, "Missing required parameter 'category' when calling RootServiceComponentConfigurationServiceGetConfiguration");
            
            // verify the required parameter 'serviceName' is set
            if (serviceName == null) throw new ApiException(400, "Missing required parameter 'serviceName' when calling RootServiceComponentConfigurationServiceGetConfiguration");
            
            // verify the required parameter 'componentName' is set
            if (componentName == null) throw new ApiException(400, "Missing required parameter 'componentName' when calling RootServiceComponentConfigurationServiceGetConfiguration");
            
    
            var path = "/services/{serviceName}/components/{componentName}/configurations/{category}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "category" + "}", ApiClient.ParameterToString(category));
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
                throw new ApiException ((int)response.StatusCode, "Error calling RootServiceComponentConfigurationServiceGetConfiguration: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RootServiceComponentConfigurationServiceGetConfiguration: " + response.ErrorMessage, response.ErrorMessage);
    
            return (RootServiceComponentConfigurationResponseSwagger) ApiClient.Deserialize(response.Content, typeof(RootServiceComponentConfigurationResponseSwagger), response.Headers);
        }
    
        /// <summary>
        /// Updates root service component configuration resources  
        /// </summary>
        /// <param name="category"></param> 
        /// <param name="serviceName"></param> 
        /// <param name="componentName"></param> 
        /// <param name="body"></param> 
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param> 
        /// <returns></returns>            
        public void RootServiceComponentConfigurationServiceUpdateConfiguration (string category, string serviceName, string componentName, RootServiceComponentConfigurationRequestSwagger body, string fields)
        {
            
            // verify the required parameter 'category' is set
            if (category == null) throw new ApiException(400, "Missing required parameter 'category' when calling RootServiceComponentConfigurationServiceUpdateConfiguration");
            
            // verify the required parameter 'serviceName' is set
            if (serviceName == null) throw new ApiException(400, "Missing required parameter 'serviceName' when calling RootServiceComponentConfigurationServiceUpdateConfiguration");
            
            // verify the required parameter 'componentName' is set
            if (componentName == null) throw new ApiException(400, "Missing required parameter 'componentName' when calling RootServiceComponentConfigurationServiceUpdateConfiguration");
            
    
            var path = "/services/{serviceName}/components/{componentName}/configurations/{category}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "category" + "}", ApiClient.ParameterToString(category));
path = path.Replace("{" + "serviceName" + "}", ApiClient.ParameterToString(serviceName));
path = path.Replace("{" + "componentName" + "}", ApiClient.ParameterToString(componentName));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling RootServiceComponentConfigurationServiceUpdateConfiguration: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RootServiceComponentConfigurationServiceUpdateConfiguration: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
