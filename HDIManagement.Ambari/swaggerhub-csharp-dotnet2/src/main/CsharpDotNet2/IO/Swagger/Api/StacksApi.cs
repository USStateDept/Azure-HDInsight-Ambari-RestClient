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
    public interface IStacksApi
    {
        /// <summary>
        /// Get details for a stack service component Returns details for a stack service component.
        /// </summary>
        /// <param name="stackName"></param>
        /// <param name="stackVersion"></param>
        /// <param name="serviceName"></param>
        /// <param name="componentName"></param>
        /// <param name="fields">Filter returned attributes</param>
        /// <returns>StackServiceComponentResponseSwagger</returns>
        StackServiceComponentResponseSwagger StacksServiceGetServiceComponent (string stackName, string stackVersion, string serviceName, string componentName, string fields);
        /// <summary>
        /// Get all dependencies for a stack service component Returns all dependencies for a stack service component.
        /// </summary>
        /// <param name="stackName"></param>
        /// <param name="stackVersion"></param>
        /// <param name="serviceName"></param>
        /// <param name="componentName"></param>
        /// <param name="fields">Filter returned attributes</param>
        /// <param name="sortBy">Sort component dependencies (asc | desc)</param>
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param>
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param>
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param>
        /// <returns>List&lt;ComponentDependencyResponse&gt;</returns>
        List<ComponentDependencyResponse> StacksServiceGetServiceComponentDependencies (string stackName, string stackVersion, string serviceName, string componentName, string fields, string sortBy, int? pageSize, string from, string to);
        /// <summary>
        /// Get a stack service component dependency Returns a stack service component dependency.
        /// </summary>
        /// <param name="stackName"></param>
        /// <param name="stackVersion"></param>
        /// <param name="serviceName"></param>
        /// <param name="componentName"></param>
        /// <param name="dependencyName"></param>
        /// <param name="fields">Filter returned attributes</param>
        /// <returns>ComponentDependencyResponse</returns>
        ComponentDependencyResponse StacksServiceGetServiceComponentDependency (string stackName, string stackVersion, string serviceName, string componentName, string dependencyName, string fields);
        /// <summary>
        /// Get all components for a stack service Returns all components for a stack service.
        /// </summary>
        /// <param name="stackName"></param>
        /// <param name="stackVersion"></param>
        /// <param name="serviceName"></param>
        /// <param name="fields">Filter returned attributes</param>
        /// <param name="sortBy">Sort service components (asc | desc)</param>
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param>
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param>
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param>
        /// <returns>List&lt;StackServiceComponentResponseSwagger&gt;</returns>
        List<StackServiceComponentResponseSwagger> StacksServiceGetServiceComponents (string stackName, string stackVersion, string serviceName, string fields, string sortBy, int? pageSize, string from, string to);
        /// <summary>
        /// Get a stack Returns stack details.
        /// </summary>
        /// <param name="stackName"></param>
        /// <param name="fields">Filter stack details</param>
        /// <returns>List&lt;StackResponseSwagger&gt;</returns>
        List<StackResponseSwagger> StacksServiceGetStack (string stackName, string fields);
        /// <summary>
        /// Get stack artifact details Returns the details of a stack artifact
        /// </summary>
        /// <param name="stackName"></param>
        /// <param name="stackVersion"></param>
        /// <param name="artifactName"></param>
        /// <param name="fields">Filter returned attributes</param>
        /// <returns>StackArtifactResponse</returns>
        StackArtifactResponse StacksServiceGetStackArtifact (string stackName, string stackVersion, string artifactName, string fields);
        /// <summary>
        /// Get all stack artifacts Returns all stack artifacts (e.g: kerberos descriptor, metrics descriptor)
        /// </summary>
        /// <param name="stackName"></param>
        /// <param name="stackVersion"></param>
        /// <param name="fields">Filter returned attributes</param>
        /// <returns>List&lt;StackArtifactResponse&gt;</returns>
        List<StackArtifactResponse> StacksServiceGetStackArtifacts (string stackName, string stackVersion, string fields);
        /// <summary>
        /// Get stack service configuration details Returns the details of a stack service configuration.
        /// </summary>
        /// <param name="stackName"></param>
        /// <param name="stackVersion"></param>
        /// <param name="serviceName"></param>
        /// <param name="propertyName"></param>
        /// <param name="fields">Filter returned attributes</param>
        /// <returns>StackConfigurationResponseSwagger</returns>
        StackConfigurationResponseSwagger StacksServiceGetStackConfiguration (string stackName, string stackVersion, string serviceName, string propertyName, string fields);
        /// <summary>
        /// Get all dependencies for a stack service configuration Returns all dependencies for a stack service configuration.
        /// </summary>
        /// <param name="stackName"></param>
        /// <param name="stackVersion"></param>
        /// <param name="serviceName"></param>
        /// <param name="propertyName"></param>
        /// <param name="fields">Filter returned attributes</param>
        /// <param name="sortBy">Sort configuration dependencies (asc | desc)</param>
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param>
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param>
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param>
        /// <returns>List&lt;StackConfigurationDependencyResponseSwagger&gt;</returns>
        List<StackConfigurationDependencyResponseSwagger> StacksServiceGetStackConfigurationDependencies (string stackName, string stackVersion, string serviceName, string propertyName, string fields, string sortBy, int? pageSize, string from, string to);
        /// <summary>
        /// Get all configurations for a stack service Returns all configurations for a stack service.
        /// </summary>
        /// <param name="stackName"></param>
        /// <param name="stackVersion"></param>
        /// <param name="serviceName"></param>
        /// <param name="fields">Filter returned attributes</param>
        /// <param name="sortBy">Sort service configurations (asc | desc)</param>
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param>
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param>
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param>
        /// <returns>List&lt;StackConfigurationResponseSwagger&gt;</returns>
        List<StackConfigurationResponseSwagger> StacksServiceGetStackConfigurations (string stackName, string stackVersion, string serviceName, string fields, string sortBy, int? pageSize, string from, string to);
        /// <summary>
        /// Get configuration details for a given property Returns the configuration details for a given property.
        /// </summary>
        /// <param name="stackName"></param>
        /// <param name="stackVersion"></param>
        /// <param name="serviceName"></param>
        /// <param name="propertyName"></param>
        /// <param name="fields">Filter returned attributes</param>
        /// <returns>StackConfigurationResponseSwagger</returns>
        StackConfigurationResponseSwagger StacksServiceGetStackLevelConfiguration (string stackName, string stackVersion, string serviceName, string propertyName, string fields);
        /// <summary>
        /// Get all configurations for a stack version Returns all configurations for a stack version.
        /// </summary>
        /// <param name="stackName"></param>
        /// <param name="stackVersion"></param>
        /// <param name="fields">Filter returned attributes</param>
        /// <param name="sortBy">Sort configuration (asc | desc)</param>
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param>
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param>
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param>
        /// <returns>List&lt;StackConfigurationResponseSwagger&gt;</returns>
        List<StackConfigurationResponseSwagger> StacksServiceGetStackLevelConfigurations (string stackName, string stackVersion, string fields, string sortBy, int? pageSize, string from, string to);
        /// <summary>
        /// Get stack service details Returns the details of a stack service.
        /// </summary>
        /// <param name="stackName"></param>
        /// <param name="stackVersion"></param>
        /// <param name="serviceName"></param>
        /// <param name="fields">Filter returned attributes</param>
        /// <returns>StackServiceResponseSwagger</returns>
        StackServiceResponseSwagger StacksServiceGetStackService (string stackName, string stackVersion, string serviceName, string fields);
        /// <summary>
        /// Get stack service artifact details Returns the details of a stack service artifact.
        /// </summary>
        /// <param name="stackName"></param>
        /// <param name="stackVersion"></param>
        /// <param name="serviceName"></param>
        /// <param name="artifactName"></param>
        /// <param name="fields">Filter returned attributes</param>
        /// <returns>StackArtifactResponse</returns>
        StackArtifactResponse StacksServiceGetStackServiceArtifact (string stackName, string stackVersion, string serviceName, string artifactName, string fields);
        /// <summary>
        /// Get all artifacts for a stack service Returns all stack service artifacts
        /// </summary>
        /// <param name="stackName"></param>
        /// <param name="stackVersion"></param>
        /// <param name="serviceName"></param>
        /// <param name="fields">Filter returned attributes</param>
        /// <param name="sortBy">Sort service artifacts (asc | desc)</param>
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param>
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param>
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param>
        /// <returns>List&lt;StackServiceArtifactResponse&gt;</returns>
        List<StackServiceArtifactResponse> StacksServiceGetStackServiceArtifacts (string stackName, string stackVersion, string serviceName, string fields, string sortBy, int? pageSize, string from, string to);
        /// <summary>
        /// Get quicklinks configuration details Returns the details of a quicklinks configuration.
        /// </summary>
        /// <param name="stackName"></param>
        /// <param name="stackVersion"></param>
        /// <param name="serviceName"></param>
        /// <param name="quickLinksConfigurationName"></param>
        /// <param name="fields">Filter returned attributes</param>
        /// <returns>List&lt;QuickLinksResponse&gt;</returns>
        List<QuickLinksResponse> StacksServiceGetStackServiceQuickLinksConfiguration (string stackName, string stackVersion, string serviceName, string quickLinksConfigurationName, string fields);
        /// <summary>
        /// Get all quicklinks configurations for a stack service Returns all quicklinks configurations for a stack service.
        /// </summary>
        /// <param name="stackName"></param>
        /// <param name="stackVersion"></param>
        /// <param name="serviceName"></param>
        /// <param name="fields">Filter returned attributes</param>
        /// <param name="sortBy">Sort quick links (asc | desc)</param>
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param>
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param>
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param>
        /// <returns>List&lt;QuickLinksResponse&gt;</returns>
        List<QuickLinksResponse> StacksServiceGetStackServiceQuickLinksConfigurations (string stackName, string stackVersion, string serviceName, string fields, string sortBy, int? pageSize, string from, string to);
        /// <summary>
        /// Get theme details for a stack service Returns stack service theme details.
        /// </summary>
        /// <param name="stackName"></param>
        /// <param name="stackVersion"></param>
        /// <param name="serviceName"></param>
        /// <param name="themeName"></param>
        /// <param name="fields">Filter returned attributes</param>
        /// <returns>ThemeResponse</returns>
        ThemeResponse StacksServiceGetStackServiceTheme (string stackName, string stackVersion, string serviceName, string themeName, string fields);
        /// <summary>
        /// Get all themes for a stack service Returns all stack themes
        /// </summary>
        /// <param name="stackName"></param>
        /// <param name="stackVersion"></param>
        /// <param name="serviceName"></param>
        /// <param name="fields">Filter returned attributes</param>
        /// <param name="sortBy">Sort service artifacts (asc | desc)</param>
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param>
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param>
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param>
        /// <returns>List&lt;ThemeResponse&gt;</returns>
        List<ThemeResponse> StacksServiceGetStackServiceThemes (string stackName, string stackVersion, string serviceName, string fields, string sortBy, int? pageSize, string from, string to);
        /// <summary>
        /// Get all services for a stack version Returns all services for a stack version.
        /// </summary>
        /// <param name="stackName"></param>
        /// <param name="stackVersion"></param>
        /// <param name="fields">Filter returned attributes</param>
        /// <param name="sortBy">Sort stack services (asc | desc)</param>
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param>
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param>
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param>
        /// <returns>List&lt;StackServiceResponseSwagger&gt;</returns>
        List<StackServiceResponseSwagger> StacksServiceGetStackServices (string stackName, string stackVersion, string fields, string sortBy, int? pageSize, string from, string to);
        /// <summary>
        /// Get details for a stack version Returns the details for a stack version.
        /// </summary>
        /// <param name="stackName"></param>
        /// <param name="stackVersion"></param>
        /// <param name="fields">Filter stack version details</param>
        /// <returns>StackVersionResponseSwagger</returns>
        StackVersionResponseSwagger StacksServiceGetStackVersion (string stackName, string stackVersion, string fields);
        /// <summary>
        /// Get extension links for a stack version Returns the extension links for a stack version.
        /// </summary>
        /// <param name="stackName"></param>
        /// <param name="stackVersion"></param>
        /// <param name="fields">Filter extension link attributes</param>
        /// <param name="sortBy">Sort extension links (asc | desc)</param>
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param>
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param>
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param>
        /// <returns>List&lt;ExtensionLinkResponse&gt;</returns>
        List<ExtensionLinkResponse> StacksServiceGetStackVersionLinks (string stackName, string stackVersion, string fields, string sortBy, int? pageSize, string from, string to);
        /// <summary>
        /// Get all versions for a stacks Returns all versions for a stack.
        /// </summary>
        /// <param name="stackName"></param>
        /// <param name="fields">Filter stack version details</param>
        /// <param name="sortBy">Sort stack privileges (asc | desc)</param>
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param>
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param>
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param>
        /// <returns>List&lt;StackVersionResponseSwagger&gt;</returns>
        List<StackVersionResponseSwagger> StacksServiceGetStackVersions (string stackName, string fields, string sortBy, int? pageSize, string from, string to);
        /// <summary>
        /// Get all stacks Returns all stacks.
        /// </summary>
        /// <param name="fields">Filter stack details</param>
        /// <param name="sortBy">Sort stack privileges (asc | desc)</param>
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param>
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param>
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param>
        /// <returns>List&lt;StackResponseSwagger&gt;</returns>
        List<StackResponseSwagger> StacksServiceGetStacks (string fields, string sortBy, int? pageSize, string from, string to);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class StacksApi : IStacksApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StacksApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public StacksApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StacksApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StacksApi(String basePath)
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
        /// Get details for a stack service component Returns details for a stack service component.
        /// </summary>
        /// <param name="stackName"></param> 
        /// <param name="stackVersion"></param> 
        /// <param name="serviceName"></param> 
        /// <param name="componentName"></param> 
        /// <param name="fields">Filter returned attributes</param> 
        /// <returns>StackServiceComponentResponseSwagger</returns>            
        public StackServiceComponentResponseSwagger StacksServiceGetServiceComponent (string stackName, string stackVersion, string serviceName, string componentName, string fields)
        {
            
            // verify the required parameter 'stackName' is set
            if (stackName == null) throw new ApiException(400, "Missing required parameter 'stackName' when calling StacksServiceGetServiceComponent");
            
            // verify the required parameter 'stackVersion' is set
            if (stackVersion == null) throw new ApiException(400, "Missing required parameter 'stackVersion' when calling StacksServiceGetServiceComponent");
            
            // verify the required parameter 'serviceName' is set
            if (serviceName == null) throw new ApiException(400, "Missing required parameter 'serviceName' when calling StacksServiceGetServiceComponent");
            
            // verify the required parameter 'componentName' is set
            if (componentName == null) throw new ApiException(400, "Missing required parameter 'componentName' when calling StacksServiceGetServiceComponent");
            
    
            var path = "/stacks/{stackName}/versions/{stackVersion}/services/{serviceName}/components/{componentName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "stackName" + "}", ApiClient.ParameterToString(stackName));
path = path.Replace("{" + "stackVersion" + "}", ApiClient.ParameterToString(stackVersion));
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
                throw new ApiException ((int)response.StatusCode, "Error calling StacksServiceGetServiceComponent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StacksServiceGetServiceComponent: " + response.ErrorMessage, response.ErrorMessage);
    
            return (StackServiceComponentResponseSwagger) ApiClient.Deserialize(response.Content, typeof(StackServiceComponentResponseSwagger), response.Headers);
        }
    
        /// <summary>
        /// Get all dependencies for a stack service component Returns all dependencies for a stack service component.
        /// </summary>
        /// <param name="stackName"></param> 
        /// <param name="stackVersion"></param> 
        /// <param name="serviceName"></param> 
        /// <param name="componentName"></param> 
        /// <param name="fields">Filter returned attributes</param> 
        /// <param name="sortBy">Sort component dependencies (asc | desc)</param> 
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param> 
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param> 
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param> 
        /// <returns>List&lt;ComponentDependencyResponse&gt;</returns>            
        public List<ComponentDependencyResponse> StacksServiceGetServiceComponentDependencies (string stackName, string stackVersion, string serviceName, string componentName, string fields, string sortBy, int? pageSize, string from, string to)
        {
            
            // verify the required parameter 'stackName' is set
            if (stackName == null) throw new ApiException(400, "Missing required parameter 'stackName' when calling StacksServiceGetServiceComponentDependencies");
            
            // verify the required parameter 'stackVersion' is set
            if (stackVersion == null) throw new ApiException(400, "Missing required parameter 'stackVersion' when calling StacksServiceGetServiceComponentDependencies");
            
            // verify the required parameter 'serviceName' is set
            if (serviceName == null) throw new ApiException(400, "Missing required parameter 'serviceName' when calling StacksServiceGetServiceComponentDependencies");
            
            // verify the required parameter 'componentName' is set
            if (componentName == null) throw new ApiException(400, "Missing required parameter 'componentName' when calling StacksServiceGetServiceComponentDependencies");
            
    
            var path = "/stacks/{stackName}/versions/{stackVersion}/services/{serviceName}/components/{componentName}/dependencies";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "stackName" + "}", ApiClient.ParameterToString(stackName));
path = path.Replace("{" + "stackVersion" + "}", ApiClient.ParameterToString(stackVersion));
path = path.Replace("{" + "serviceName" + "}", ApiClient.ParameterToString(serviceName));
path = path.Replace("{" + "componentName" + "}", ApiClient.ParameterToString(componentName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling StacksServiceGetServiceComponentDependencies: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StacksServiceGetServiceComponentDependencies: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ComponentDependencyResponse>) ApiClient.Deserialize(response.Content, typeof(List<ComponentDependencyResponse>), response.Headers);
        }
    
        /// <summary>
        /// Get a stack service component dependency Returns a stack service component dependency.
        /// </summary>
        /// <param name="stackName"></param> 
        /// <param name="stackVersion"></param> 
        /// <param name="serviceName"></param> 
        /// <param name="componentName"></param> 
        /// <param name="dependencyName"></param> 
        /// <param name="fields">Filter returned attributes</param> 
        /// <returns>ComponentDependencyResponse</returns>            
        public ComponentDependencyResponse StacksServiceGetServiceComponentDependency (string stackName, string stackVersion, string serviceName, string componentName, string dependencyName, string fields)
        {
            
            // verify the required parameter 'stackName' is set
            if (stackName == null) throw new ApiException(400, "Missing required parameter 'stackName' when calling StacksServiceGetServiceComponentDependency");
            
            // verify the required parameter 'stackVersion' is set
            if (stackVersion == null) throw new ApiException(400, "Missing required parameter 'stackVersion' when calling StacksServiceGetServiceComponentDependency");
            
            // verify the required parameter 'serviceName' is set
            if (serviceName == null) throw new ApiException(400, "Missing required parameter 'serviceName' when calling StacksServiceGetServiceComponentDependency");
            
            // verify the required parameter 'componentName' is set
            if (componentName == null) throw new ApiException(400, "Missing required parameter 'componentName' when calling StacksServiceGetServiceComponentDependency");
            
            // verify the required parameter 'dependencyName' is set
            if (dependencyName == null) throw new ApiException(400, "Missing required parameter 'dependencyName' when calling StacksServiceGetServiceComponentDependency");
            
    
            var path = "/stacks/{stackName}/versions/{stackVersion}/services/{serviceName}/components/{componentName}/dependencies/{dependencyName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "stackName" + "}", ApiClient.ParameterToString(stackName));
path = path.Replace("{" + "stackVersion" + "}", ApiClient.ParameterToString(stackVersion));
path = path.Replace("{" + "serviceName" + "}", ApiClient.ParameterToString(serviceName));
path = path.Replace("{" + "componentName" + "}", ApiClient.ParameterToString(componentName));
path = path.Replace("{" + "dependencyName" + "}", ApiClient.ParameterToString(dependencyName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling StacksServiceGetServiceComponentDependency: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StacksServiceGetServiceComponentDependency: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ComponentDependencyResponse) ApiClient.Deserialize(response.Content, typeof(ComponentDependencyResponse), response.Headers);
        }
    
        /// <summary>
        /// Get all components for a stack service Returns all components for a stack service.
        /// </summary>
        /// <param name="stackName"></param> 
        /// <param name="stackVersion"></param> 
        /// <param name="serviceName"></param> 
        /// <param name="fields">Filter returned attributes</param> 
        /// <param name="sortBy">Sort service components (asc | desc)</param> 
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param> 
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param> 
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param> 
        /// <returns>List&lt;StackServiceComponentResponseSwagger&gt;</returns>            
        public List<StackServiceComponentResponseSwagger> StacksServiceGetServiceComponents (string stackName, string stackVersion, string serviceName, string fields, string sortBy, int? pageSize, string from, string to)
        {
            
            // verify the required parameter 'stackName' is set
            if (stackName == null) throw new ApiException(400, "Missing required parameter 'stackName' when calling StacksServiceGetServiceComponents");
            
            // verify the required parameter 'stackVersion' is set
            if (stackVersion == null) throw new ApiException(400, "Missing required parameter 'stackVersion' when calling StacksServiceGetServiceComponents");
            
            // verify the required parameter 'serviceName' is set
            if (serviceName == null) throw new ApiException(400, "Missing required parameter 'serviceName' when calling StacksServiceGetServiceComponents");
            
    
            var path = "/stacks/{stackName}/versions/{stackVersion}/services/{serviceName}/components";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "stackName" + "}", ApiClient.ParameterToString(stackName));
path = path.Replace("{" + "stackVersion" + "}", ApiClient.ParameterToString(stackVersion));
path = path.Replace("{" + "serviceName" + "}", ApiClient.ParameterToString(serviceName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling StacksServiceGetServiceComponents: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StacksServiceGetServiceComponents: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<StackServiceComponentResponseSwagger>) ApiClient.Deserialize(response.Content, typeof(List<StackServiceComponentResponseSwagger>), response.Headers);
        }
    
        /// <summary>
        /// Get a stack Returns stack details.
        /// </summary>
        /// <param name="stackName"></param> 
        /// <param name="fields">Filter stack details</param> 
        /// <returns>List&lt;StackResponseSwagger&gt;</returns>            
        public List<StackResponseSwagger> StacksServiceGetStack (string stackName, string fields)
        {
            
            // verify the required parameter 'stackName' is set
            if (stackName == null) throw new ApiException(400, "Missing required parameter 'stackName' when calling StacksServiceGetStack");
            
    
            var path = "/stacks/{stackName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "stackName" + "}", ApiClient.ParameterToString(stackName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling StacksServiceGetStack: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StacksServiceGetStack: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<StackResponseSwagger>) ApiClient.Deserialize(response.Content, typeof(List<StackResponseSwagger>), response.Headers);
        }
    
        /// <summary>
        /// Get stack artifact details Returns the details of a stack artifact
        /// </summary>
        /// <param name="stackName"></param> 
        /// <param name="stackVersion"></param> 
        /// <param name="artifactName"></param> 
        /// <param name="fields">Filter returned attributes</param> 
        /// <returns>StackArtifactResponse</returns>            
        public StackArtifactResponse StacksServiceGetStackArtifact (string stackName, string stackVersion, string artifactName, string fields)
        {
            
            // verify the required parameter 'stackName' is set
            if (stackName == null) throw new ApiException(400, "Missing required parameter 'stackName' when calling StacksServiceGetStackArtifact");
            
            // verify the required parameter 'stackVersion' is set
            if (stackVersion == null) throw new ApiException(400, "Missing required parameter 'stackVersion' when calling StacksServiceGetStackArtifact");
            
            // verify the required parameter 'artifactName' is set
            if (artifactName == null) throw new ApiException(400, "Missing required parameter 'artifactName' when calling StacksServiceGetStackArtifact");
            
    
            var path = "/stacks/{stackName}/versions/{stackVersion}/artifacts/{artifactName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "stackName" + "}", ApiClient.ParameterToString(stackName));
path = path.Replace("{" + "stackVersion" + "}", ApiClient.ParameterToString(stackVersion));
path = path.Replace("{" + "artifactName" + "}", ApiClient.ParameterToString(artifactName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling StacksServiceGetStackArtifact: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StacksServiceGetStackArtifact: " + response.ErrorMessage, response.ErrorMessage);
    
            return (StackArtifactResponse) ApiClient.Deserialize(response.Content, typeof(StackArtifactResponse), response.Headers);
        }
    
        /// <summary>
        /// Get all stack artifacts Returns all stack artifacts (e.g: kerberos descriptor, metrics descriptor)
        /// </summary>
        /// <param name="stackName"></param> 
        /// <param name="stackVersion"></param> 
        /// <param name="fields">Filter returned attributes</param> 
        /// <returns>List&lt;StackArtifactResponse&gt;</returns>            
        public List<StackArtifactResponse> StacksServiceGetStackArtifacts (string stackName, string stackVersion, string fields)
        {
            
            // verify the required parameter 'stackName' is set
            if (stackName == null) throw new ApiException(400, "Missing required parameter 'stackName' when calling StacksServiceGetStackArtifacts");
            
            // verify the required parameter 'stackVersion' is set
            if (stackVersion == null) throw new ApiException(400, "Missing required parameter 'stackVersion' when calling StacksServiceGetStackArtifacts");
            
    
            var path = "/stacks/{stackName}/versions/{stackVersion}/artifacts";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "stackName" + "}", ApiClient.ParameterToString(stackName));
path = path.Replace("{" + "stackVersion" + "}", ApiClient.ParameterToString(stackVersion));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling StacksServiceGetStackArtifacts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StacksServiceGetStackArtifacts: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<StackArtifactResponse>) ApiClient.Deserialize(response.Content, typeof(List<StackArtifactResponse>), response.Headers);
        }
    
        /// <summary>
        /// Get stack service configuration details Returns the details of a stack service configuration.
        /// </summary>
        /// <param name="stackName"></param> 
        /// <param name="stackVersion"></param> 
        /// <param name="serviceName"></param> 
        /// <param name="propertyName"></param> 
        /// <param name="fields">Filter returned attributes</param> 
        /// <returns>StackConfigurationResponseSwagger</returns>            
        public StackConfigurationResponseSwagger StacksServiceGetStackConfiguration (string stackName, string stackVersion, string serviceName, string propertyName, string fields)
        {
            
            // verify the required parameter 'stackName' is set
            if (stackName == null) throw new ApiException(400, "Missing required parameter 'stackName' when calling StacksServiceGetStackConfiguration");
            
            // verify the required parameter 'stackVersion' is set
            if (stackVersion == null) throw new ApiException(400, "Missing required parameter 'stackVersion' when calling StacksServiceGetStackConfiguration");
            
            // verify the required parameter 'serviceName' is set
            if (serviceName == null) throw new ApiException(400, "Missing required parameter 'serviceName' when calling StacksServiceGetStackConfiguration");
            
            // verify the required parameter 'propertyName' is set
            if (propertyName == null) throw new ApiException(400, "Missing required parameter 'propertyName' when calling StacksServiceGetStackConfiguration");
            
    
            var path = "/stacks/{stackName}/versions/{stackVersion}/services/{serviceName}/configurations/{propertyName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "stackName" + "}", ApiClient.ParameterToString(stackName));
path = path.Replace("{" + "stackVersion" + "}", ApiClient.ParameterToString(stackVersion));
path = path.Replace("{" + "serviceName" + "}", ApiClient.ParameterToString(serviceName));
path = path.Replace("{" + "propertyName" + "}", ApiClient.ParameterToString(propertyName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling StacksServiceGetStackConfiguration: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StacksServiceGetStackConfiguration: " + response.ErrorMessage, response.ErrorMessage);
    
            return (StackConfigurationResponseSwagger) ApiClient.Deserialize(response.Content, typeof(StackConfigurationResponseSwagger), response.Headers);
        }
    
        /// <summary>
        /// Get all dependencies for a stack service configuration Returns all dependencies for a stack service configuration.
        /// </summary>
        /// <param name="stackName"></param> 
        /// <param name="stackVersion"></param> 
        /// <param name="serviceName"></param> 
        /// <param name="propertyName"></param> 
        /// <param name="fields">Filter returned attributes</param> 
        /// <param name="sortBy">Sort configuration dependencies (asc | desc)</param> 
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param> 
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param> 
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param> 
        /// <returns>List&lt;StackConfigurationDependencyResponseSwagger&gt;</returns>            
        public List<StackConfigurationDependencyResponseSwagger> StacksServiceGetStackConfigurationDependencies (string stackName, string stackVersion, string serviceName, string propertyName, string fields, string sortBy, int? pageSize, string from, string to)
        {
            
            // verify the required parameter 'stackName' is set
            if (stackName == null) throw new ApiException(400, "Missing required parameter 'stackName' when calling StacksServiceGetStackConfigurationDependencies");
            
            // verify the required parameter 'stackVersion' is set
            if (stackVersion == null) throw new ApiException(400, "Missing required parameter 'stackVersion' when calling StacksServiceGetStackConfigurationDependencies");
            
            // verify the required parameter 'serviceName' is set
            if (serviceName == null) throw new ApiException(400, "Missing required parameter 'serviceName' when calling StacksServiceGetStackConfigurationDependencies");
            
            // verify the required parameter 'propertyName' is set
            if (propertyName == null) throw new ApiException(400, "Missing required parameter 'propertyName' when calling StacksServiceGetStackConfigurationDependencies");
            
    
            var path = "/stacks/{stackName}/versions/{stackVersion}/services/{serviceName}/configurations/{propertyName}/dependencies";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "stackName" + "}", ApiClient.ParameterToString(stackName));
path = path.Replace("{" + "stackVersion" + "}", ApiClient.ParameterToString(stackVersion));
path = path.Replace("{" + "serviceName" + "}", ApiClient.ParameterToString(serviceName));
path = path.Replace("{" + "propertyName" + "}", ApiClient.ParameterToString(propertyName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling StacksServiceGetStackConfigurationDependencies: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StacksServiceGetStackConfigurationDependencies: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<StackConfigurationDependencyResponseSwagger>) ApiClient.Deserialize(response.Content, typeof(List<StackConfigurationDependencyResponseSwagger>), response.Headers);
        }
    
        /// <summary>
        /// Get all configurations for a stack service Returns all configurations for a stack service.
        /// </summary>
        /// <param name="stackName"></param> 
        /// <param name="stackVersion"></param> 
        /// <param name="serviceName"></param> 
        /// <param name="fields">Filter returned attributes</param> 
        /// <param name="sortBy">Sort service configurations (asc | desc)</param> 
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param> 
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param> 
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param> 
        /// <returns>List&lt;StackConfigurationResponseSwagger&gt;</returns>            
        public List<StackConfigurationResponseSwagger> StacksServiceGetStackConfigurations (string stackName, string stackVersion, string serviceName, string fields, string sortBy, int? pageSize, string from, string to)
        {
            
            // verify the required parameter 'stackName' is set
            if (stackName == null) throw new ApiException(400, "Missing required parameter 'stackName' when calling StacksServiceGetStackConfigurations");
            
            // verify the required parameter 'stackVersion' is set
            if (stackVersion == null) throw new ApiException(400, "Missing required parameter 'stackVersion' when calling StacksServiceGetStackConfigurations");
            
            // verify the required parameter 'serviceName' is set
            if (serviceName == null) throw new ApiException(400, "Missing required parameter 'serviceName' when calling StacksServiceGetStackConfigurations");
            
    
            var path = "/stacks/{stackName}/versions/{stackVersion}/services/{serviceName}/configurations";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "stackName" + "}", ApiClient.ParameterToString(stackName));
path = path.Replace("{" + "stackVersion" + "}", ApiClient.ParameterToString(stackVersion));
path = path.Replace("{" + "serviceName" + "}", ApiClient.ParameterToString(serviceName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling StacksServiceGetStackConfigurations: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StacksServiceGetStackConfigurations: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<StackConfigurationResponseSwagger>) ApiClient.Deserialize(response.Content, typeof(List<StackConfigurationResponseSwagger>), response.Headers);
        }
    
        /// <summary>
        /// Get configuration details for a given property Returns the configuration details for a given property.
        /// </summary>
        /// <param name="stackName"></param> 
        /// <param name="stackVersion"></param> 
        /// <param name="serviceName"></param> 
        /// <param name="propertyName"></param> 
        /// <param name="fields">Filter returned attributes</param> 
        /// <returns>StackConfigurationResponseSwagger</returns>            
        public StackConfigurationResponseSwagger StacksServiceGetStackLevelConfiguration (string stackName, string stackVersion, string serviceName, string propertyName, string fields)
        {
            
            // verify the required parameter 'stackName' is set
            if (stackName == null) throw new ApiException(400, "Missing required parameter 'stackName' when calling StacksServiceGetStackLevelConfiguration");
            
            // verify the required parameter 'stackVersion' is set
            if (stackVersion == null) throw new ApiException(400, "Missing required parameter 'stackVersion' when calling StacksServiceGetStackLevelConfiguration");
            
            // verify the required parameter 'serviceName' is set
            if (serviceName == null) throw new ApiException(400, "Missing required parameter 'serviceName' when calling StacksServiceGetStackLevelConfiguration");
            
            // verify the required parameter 'propertyName' is set
            if (propertyName == null) throw new ApiException(400, "Missing required parameter 'propertyName' when calling StacksServiceGetStackLevelConfiguration");
            
    
            var path = "/stacks/{stackName}/versions/{stackVersion}/configurations/{propertyName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "stackName" + "}", ApiClient.ParameterToString(stackName));
path = path.Replace("{" + "stackVersion" + "}", ApiClient.ParameterToString(stackVersion));
path = path.Replace("{" + "serviceName" + "}", ApiClient.ParameterToString(serviceName));
path = path.Replace("{" + "propertyName" + "}", ApiClient.ParameterToString(propertyName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling StacksServiceGetStackLevelConfiguration: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StacksServiceGetStackLevelConfiguration: " + response.ErrorMessage, response.ErrorMessage);
    
            return (StackConfigurationResponseSwagger) ApiClient.Deserialize(response.Content, typeof(StackConfigurationResponseSwagger), response.Headers);
        }
    
        /// <summary>
        /// Get all configurations for a stack version Returns all configurations for a stack version.
        /// </summary>
        /// <param name="stackName"></param> 
        /// <param name="stackVersion"></param> 
        /// <param name="fields">Filter returned attributes</param> 
        /// <param name="sortBy">Sort configuration (asc | desc)</param> 
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param> 
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param> 
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param> 
        /// <returns>List&lt;StackConfigurationResponseSwagger&gt;</returns>            
        public List<StackConfigurationResponseSwagger> StacksServiceGetStackLevelConfigurations (string stackName, string stackVersion, string fields, string sortBy, int? pageSize, string from, string to)
        {
            
            // verify the required parameter 'stackName' is set
            if (stackName == null) throw new ApiException(400, "Missing required parameter 'stackName' when calling StacksServiceGetStackLevelConfigurations");
            
            // verify the required parameter 'stackVersion' is set
            if (stackVersion == null) throw new ApiException(400, "Missing required parameter 'stackVersion' when calling StacksServiceGetStackLevelConfigurations");
            
    
            var path = "/stacks/{stackName}/versions/{stackVersion}/configurations";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "stackName" + "}", ApiClient.ParameterToString(stackName));
path = path.Replace("{" + "stackVersion" + "}", ApiClient.ParameterToString(stackVersion));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling StacksServiceGetStackLevelConfigurations: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StacksServiceGetStackLevelConfigurations: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<StackConfigurationResponseSwagger>) ApiClient.Deserialize(response.Content, typeof(List<StackConfigurationResponseSwagger>), response.Headers);
        }
    
        /// <summary>
        /// Get stack service details Returns the details of a stack service.
        /// </summary>
        /// <param name="stackName"></param> 
        /// <param name="stackVersion"></param> 
        /// <param name="serviceName"></param> 
        /// <param name="fields">Filter returned attributes</param> 
        /// <returns>StackServiceResponseSwagger</returns>            
        public StackServiceResponseSwagger StacksServiceGetStackService (string stackName, string stackVersion, string serviceName, string fields)
        {
            
            // verify the required parameter 'stackName' is set
            if (stackName == null) throw new ApiException(400, "Missing required parameter 'stackName' when calling StacksServiceGetStackService");
            
            // verify the required parameter 'stackVersion' is set
            if (stackVersion == null) throw new ApiException(400, "Missing required parameter 'stackVersion' when calling StacksServiceGetStackService");
            
            // verify the required parameter 'serviceName' is set
            if (serviceName == null) throw new ApiException(400, "Missing required parameter 'serviceName' when calling StacksServiceGetStackService");
            
    
            var path = "/stacks/{stackName}/versions/{stackVersion}/services/{serviceName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "stackName" + "}", ApiClient.ParameterToString(stackName));
path = path.Replace("{" + "stackVersion" + "}", ApiClient.ParameterToString(stackVersion));
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
                throw new ApiException ((int)response.StatusCode, "Error calling StacksServiceGetStackService: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StacksServiceGetStackService: " + response.ErrorMessage, response.ErrorMessage);
    
            return (StackServiceResponseSwagger) ApiClient.Deserialize(response.Content, typeof(StackServiceResponseSwagger), response.Headers);
        }
    
        /// <summary>
        /// Get stack service artifact details Returns the details of a stack service artifact.
        /// </summary>
        /// <param name="stackName"></param> 
        /// <param name="stackVersion"></param> 
        /// <param name="serviceName"></param> 
        /// <param name="artifactName"></param> 
        /// <param name="fields">Filter returned attributes</param> 
        /// <returns>StackArtifactResponse</returns>            
        public StackArtifactResponse StacksServiceGetStackServiceArtifact (string stackName, string stackVersion, string serviceName, string artifactName, string fields)
        {
            
            // verify the required parameter 'stackName' is set
            if (stackName == null) throw new ApiException(400, "Missing required parameter 'stackName' when calling StacksServiceGetStackServiceArtifact");
            
            // verify the required parameter 'stackVersion' is set
            if (stackVersion == null) throw new ApiException(400, "Missing required parameter 'stackVersion' when calling StacksServiceGetStackServiceArtifact");
            
            // verify the required parameter 'serviceName' is set
            if (serviceName == null) throw new ApiException(400, "Missing required parameter 'serviceName' when calling StacksServiceGetStackServiceArtifact");
            
            // verify the required parameter 'artifactName' is set
            if (artifactName == null) throw new ApiException(400, "Missing required parameter 'artifactName' when calling StacksServiceGetStackServiceArtifact");
            
    
            var path = "/stacks/{stackName}/versions/{stackVersion}/services/{serviceName}/artifacts/{artifactName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "stackName" + "}", ApiClient.ParameterToString(stackName));
path = path.Replace("{" + "stackVersion" + "}", ApiClient.ParameterToString(stackVersion));
path = path.Replace("{" + "serviceName" + "}", ApiClient.ParameterToString(serviceName));
path = path.Replace("{" + "artifactName" + "}", ApiClient.ParameterToString(artifactName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling StacksServiceGetStackServiceArtifact: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StacksServiceGetStackServiceArtifact: " + response.ErrorMessage, response.ErrorMessage);
    
            return (StackArtifactResponse) ApiClient.Deserialize(response.Content, typeof(StackArtifactResponse), response.Headers);
        }
    
        /// <summary>
        /// Get all artifacts for a stack service Returns all stack service artifacts
        /// </summary>
        /// <param name="stackName"></param> 
        /// <param name="stackVersion"></param> 
        /// <param name="serviceName"></param> 
        /// <param name="fields">Filter returned attributes</param> 
        /// <param name="sortBy">Sort service artifacts (asc | desc)</param> 
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param> 
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param> 
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param> 
        /// <returns>List&lt;StackServiceArtifactResponse&gt;</returns>            
        public List<StackServiceArtifactResponse> StacksServiceGetStackServiceArtifacts (string stackName, string stackVersion, string serviceName, string fields, string sortBy, int? pageSize, string from, string to)
        {
            
            // verify the required parameter 'stackName' is set
            if (stackName == null) throw new ApiException(400, "Missing required parameter 'stackName' when calling StacksServiceGetStackServiceArtifacts");
            
            // verify the required parameter 'stackVersion' is set
            if (stackVersion == null) throw new ApiException(400, "Missing required parameter 'stackVersion' when calling StacksServiceGetStackServiceArtifacts");
            
            // verify the required parameter 'serviceName' is set
            if (serviceName == null) throw new ApiException(400, "Missing required parameter 'serviceName' when calling StacksServiceGetStackServiceArtifacts");
            
    
            var path = "/stacks/{stackName}/versions/{stackVersion}/services/{serviceName}/artifacts";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "stackName" + "}", ApiClient.ParameterToString(stackName));
path = path.Replace("{" + "stackVersion" + "}", ApiClient.ParameterToString(stackVersion));
path = path.Replace("{" + "serviceName" + "}", ApiClient.ParameterToString(serviceName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling StacksServiceGetStackServiceArtifacts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StacksServiceGetStackServiceArtifacts: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<StackServiceArtifactResponse>) ApiClient.Deserialize(response.Content, typeof(List<StackServiceArtifactResponse>), response.Headers);
        }
    
        /// <summary>
        /// Get quicklinks configuration details Returns the details of a quicklinks configuration.
        /// </summary>
        /// <param name="stackName"></param> 
        /// <param name="stackVersion"></param> 
        /// <param name="serviceName"></param> 
        /// <param name="quickLinksConfigurationName"></param> 
        /// <param name="fields">Filter returned attributes</param> 
        /// <returns>List&lt;QuickLinksResponse&gt;</returns>            
        public List<QuickLinksResponse> StacksServiceGetStackServiceQuickLinksConfiguration (string stackName, string stackVersion, string serviceName, string quickLinksConfigurationName, string fields)
        {
            
            // verify the required parameter 'stackName' is set
            if (stackName == null) throw new ApiException(400, "Missing required parameter 'stackName' when calling StacksServiceGetStackServiceQuickLinksConfiguration");
            
            // verify the required parameter 'stackVersion' is set
            if (stackVersion == null) throw new ApiException(400, "Missing required parameter 'stackVersion' when calling StacksServiceGetStackServiceQuickLinksConfiguration");
            
            // verify the required parameter 'serviceName' is set
            if (serviceName == null) throw new ApiException(400, "Missing required parameter 'serviceName' when calling StacksServiceGetStackServiceQuickLinksConfiguration");
            
            // verify the required parameter 'quickLinksConfigurationName' is set
            if (quickLinksConfigurationName == null) throw new ApiException(400, "Missing required parameter 'quickLinksConfigurationName' when calling StacksServiceGetStackServiceQuickLinksConfiguration");
            
    
            var path = "/stacks/{stackName}/versions/{stackVersion}/services/{serviceName}/quicklinks/{quickLinksConfigurationName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "stackName" + "}", ApiClient.ParameterToString(stackName));
path = path.Replace("{" + "stackVersion" + "}", ApiClient.ParameterToString(stackVersion));
path = path.Replace("{" + "serviceName" + "}", ApiClient.ParameterToString(serviceName));
path = path.Replace("{" + "quickLinksConfigurationName" + "}", ApiClient.ParameterToString(quickLinksConfigurationName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling StacksServiceGetStackServiceQuickLinksConfiguration: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StacksServiceGetStackServiceQuickLinksConfiguration: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<QuickLinksResponse>) ApiClient.Deserialize(response.Content, typeof(List<QuickLinksResponse>), response.Headers);
        }
    
        /// <summary>
        /// Get all quicklinks configurations for a stack service Returns all quicklinks configurations for a stack service.
        /// </summary>
        /// <param name="stackName"></param> 
        /// <param name="stackVersion"></param> 
        /// <param name="serviceName"></param> 
        /// <param name="fields">Filter returned attributes</param> 
        /// <param name="sortBy">Sort quick links (asc | desc)</param> 
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param> 
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param> 
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param> 
        /// <returns>List&lt;QuickLinksResponse&gt;</returns>            
        public List<QuickLinksResponse> StacksServiceGetStackServiceQuickLinksConfigurations (string stackName, string stackVersion, string serviceName, string fields, string sortBy, int? pageSize, string from, string to)
        {
            
            // verify the required parameter 'stackName' is set
            if (stackName == null) throw new ApiException(400, "Missing required parameter 'stackName' when calling StacksServiceGetStackServiceQuickLinksConfigurations");
            
            // verify the required parameter 'stackVersion' is set
            if (stackVersion == null) throw new ApiException(400, "Missing required parameter 'stackVersion' when calling StacksServiceGetStackServiceQuickLinksConfigurations");
            
            // verify the required parameter 'serviceName' is set
            if (serviceName == null) throw new ApiException(400, "Missing required parameter 'serviceName' when calling StacksServiceGetStackServiceQuickLinksConfigurations");
            
    
            var path = "/stacks/{stackName}/versions/{stackVersion}/services/{serviceName}/quicklinks";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "stackName" + "}", ApiClient.ParameterToString(stackName));
path = path.Replace("{" + "stackVersion" + "}", ApiClient.ParameterToString(stackVersion));
path = path.Replace("{" + "serviceName" + "}", ApiClient.ParameterToString(serviceName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling StacksServiceGetStackServiceQuickLinksConfigurations: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StacksServiceGetStackServiceQuickLinksConfigurations: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<QuickLinksResponse>) ApiClient.Deserialize(response.Content, typeof(List<QuickLinksResponse>), response.Headers);
        }
    
        /// <summary>
        /// Get theme details for a stack service Returns stack service theme details.
        /// </summary>
        /// <param name="stackName"></param> 
        /// <param name="stackVersion"></param> 
        /// <param name="serviceName"></param> 
        /// <param name="themeName"></param> 
        /// <param name="fields">Filter returned attributes</param> 
        /// <returns>ThemeResponse</returns>            
        public ThemeResponse StacksServiceGetStackServiceTheme (string stackName, string stackVersion, string serviceName, string themeName, string fields)
        {
            
            // verify the required parameter 'stackName' is set
            if (stackName == null) throw new ApiException(400, "Missing required parameter 'stackName' when calling StacksServiceGetStackServiceTheme");
            
            // verify the required parameter 'stackVersion' is set
            if (stackVersion == null) throw new ApiException(400, "Missing required parameter 'stackVersion' when calling StacksServiceGetStackServiceTheme");
            
            // verify the required parameter 'serviceName' is set
            if (serviceName == null) throw new ApiException(400, "Missing required parameter 'serviceName' when calling StacksServiceGetStackServiceTheme");
            
            // verify the required parameter 'themeName' is set
            if (themeName == null) throw new ApiException(400, "Missing required parameter 'themeName' when calling StacksServiceGetStackServiceTheme");
            
    
            var path = "/stacks/{stackName}/versions/{stackVersion}/services/{serviceName}/themes/{themeName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "stackName" + "}", ApiClient.ParameterToString(stackName));
path = path.Replace("{" + "stackVersion" + "}", ApiClient.ParameterToString(stackVersion));
path = path.Replace("{" + "serviceName" + "}", ApiClient.ParameterToString(serviceName));
path = path.Replace("{" + "themeName" + "}", ApiClient.ParameterToString(themeName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling StacksServiceGetStackServiceTheme: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StacksServiceGetStackServiceTheme: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ThemeResponse) ApiClient.Deserialize(response.Content, typeof(ThemeResponse), response.Headers);
        }
    
        /// <summary>
        /// Get all themes for a stack service Returns all stack themes
        /// </summary>
        /// <param name="stackName"></param> 
        /// <param name="stackVersion"></param> 
        /// <param name="serviceName"></param> 
        /// <param name="fields">Filter returned attributes</param> 
        /// <param name="sortBy">Sort service artifacts (asc | desc)</param> 
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param> 
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param> 
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param> 
        /// <returns>List&lt;ThemeResponse&gt;</returns>            
        public List<ThemeResponse> StacksServiceGetStackServiceThemes (string stackName, string stackVersion, string serviceName, string fields, string sortBy, int? pageSize, string from, string to)
        {
            
            // verify the required parameter 'stackName' is set
            if (stackName == null) throw new ApiException(400, "Missing required parameter 'stackName' when calling StacksServiceGetStackServiceThemes");
            
            // verify the required parameter 'stackVersion' is set
            if (stackVersion == null) throw new ApiException(400, "Missing required parameter 'stackVersion' when calling StacksServiceGetStackServiceThemes");
            
            // verify the required parameter 'serviceName' is set
            if (serviceName == null) throw new ApiException(400, "Missing required parameter 'serviceName' when calling StacksServiceGetStackServiceThemes");
            
    
            var path = "/stacks/{stackName}/versions/{stackVersion}/services/{serviceName}/themes";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "stackName" + "}", ApiClient.ParameterToString(stackName));
path = path.Replace("{" + "stackVersion" + "}", ApiClient.ParameterToString(stackVersion));
path = path.Replace("{" + "serviceName" + "}", ApiClient.ParameterToString(serviceName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling StacksServiceGetStackServiceThemes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StacksServiceGetStackServiceThemes: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ThemeResponse>) ApiClient.Deserialize(response.Content, typeof(List<ThemeResponse>), response.Headers);
        }
    
        /// <summary>
        /// Get all services for a stack version Returns all services for a stack version.
        /// </summary>
        /// <param name="stackName"></param> 
        /// <param name="stackVersion"></param> 
        /// <param name="fields">Filter returned attributes</param> 
        /// <param name="sortBy">Sort stack services (asc | desc)</param> 
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param> 
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param> 
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param> 
        /// <returns>List&lt;StackServiceResponseSwagger&gt;</returns>            
        public List<StackServiceResponseSwagger> StacksServiceGetStackServices (string stackName, string stackVersion, string fields, string sortBy, int? pageSize, string from, string to)
        {
            
            // verify the required parameter 'stackName' is set
            if (stackName == null) throw new ApiException(400, "Missing required parameter 'stackName' when calling StacksServiceGetStackServices");
            
            // verify the required parameter 'stackVersion' is set
            if (stackVersion == null) throw new ApiException(400, "Missing required parameter 'stackVersion' when calling StacksServiceGetStackServices");
            
    
            var path = "/stacks/{stackName}/versions/{stackVersion}/services";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "stackName" + "}", ApiClient.ParameterToString(stackName));
path = path.Replace("{" + "stackVersion" + "}", ApiClient.ParameterToString(stackVersion));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling StacksServiceGetStackServices: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StacksServiceGetStackServices: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<StackServiceResponseSwagger>) ApiClient.Deserialize(response.Content, typeof(List<StackServiceResponseSwagger>), response.Headers);
        }
    
        /// <summary>
        /// Get details for a stack version Returns the details for a stack version.
        /// </summary>
        /// <param name="stackName"></param> 
        /// <param name="stackVersion"></param> 
        /// <param name="fields">Filter stack version details</param> 
        /// <returns>StackVersionResponseSwagger</returns>            
        public StackVersionResponseSwagger StacksServiceGetStackVersion (string stackName, string stackVersion, string fields)
        {
            
            // verify the required parameter 'stackName' is set
            if (stackName == null) throw new ApiException(400, "Missing required parameter 'stackName' when calling StacksServiceGetStackVersion");
            
            // verify the required parameter 'stackVersion' is set
            if (stackVersion == null) throw new ApiException(400, "Missing required parameter 'stackVersion' when calling StacksServiceGetStackVersion");
            
    
            var path = "/stacks/{stackName}/versions/{stackVersion}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "stackName" + "}", ApiClient.ParameterToString(stackName));
path = path.Replace("{" + "stackVersion" + "}", ApiClient.ParameterToString(stackVersion));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling StacksServiceGetStackVersion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StacksServiceGetStackVersion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (StackVersionResponseSwagger) ApiClient.Deserialize(response.Content, typeof(StackVersionResponseSwagger), response.Headers);
        }
    
        /// <summary>
        /// Get extension links for a stack version Returns the extension links for a stack version.
        /// </summary>
        /// <param name="stackName"></param> 
        /// <param name="stackVersion"></param> 
        /// <param name="fields">Filter extension link attributes</param> 
        /// <param name="sortBy">Sort extension links (asc | desc)</param> 
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param> 
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param> 
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param> 
        /// <returns>List&lt;ExtensionLinkResponse&gt;</returns>            
        public List<ExtensionLinkResponse> StacksServiceGetStackVersionLinks (string stackName, string stackVersion, string fields, string sortBy, int? pageSize, string from, string to)
        {
            
            // verify the required parameter 'stackName' is set
            if (stackName == null) throw new ApiException(400, "Missing required parameter 'stackName' when calling StacksServiceGetStackVersionLinks");
            
            // verify the required parameter 'stackVersion' is set
            if (stackVersion == null) throw new ApiException(400, "Missing required parameter 'stackVersion' when calling StacksServiceGetStackVersionLinks");
            
    
            var path = "/stacks/{stackName}/versions/{stackVersion}/links";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "stackName" + "}", ApiClient.ParameterToString(stackName));
path = path.Replace("{" + "stackVersion" + "}", ApiClient.ParameterToString(stackVersion));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling StacksServiceGetStackVersionLinks: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StacksServiceGetStackVersionLinks: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ExtensionLinkResponse>) ApiClient.Deserialize(response.Content, typeof(List<ExtensionLinkResponse>), response.Headers);
        }
    
        /// <summary>
        /// Get all versions for a stacks Returns all versions for a stack.
        /// </summary>
        /// <param name="stackName"></param> 
        /// <param name="fields">Filter stack version details</param> 
        /// <param name="sortBy">Sort stack privileges (asc | desc)</param> 
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param> 
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param> 
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param> 
        /// <returns>List&lt;StackVersionResponseSwagger&gt;</returns>            
        public List<StackVersionResponseSwagger> StacksServiceGetStackVersions (string stackName, string fields, string sortBy, int? pageSize, string from, string to)
        {
            
            // verify the required parameter 'stackName' is set
            if (stackName == null) throw new ApiException(400, "Missing required parameter 'stackName' when calling StacksServiceGetStackVersions");
            
    
            var path = "/stacks/{stackName}/versions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "stackName" + "}", ApiClient.ParameterToString(stackName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling StacksServiceGetStackVersions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StacksServiceGetStackVersions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<StackVersionResponseSwagger>) ApiClient.Deserialize(response.Content, typeof(List<StackVersionResponseSwagger>), response.Headers);
        }
    
        /// <summary>
        /// Get all stacks Returns all stacks.
        /// </summary>
        /// <param name="fields">Filter stack details</param> 
        /// <param name="sortBy">Sort stack privileges (asc | desc)</param> 
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param> 
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param> 
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param> 
        /// <returns>List&lt;StackResponseSwagger&gt;</returns>            
        public List<StackResponseSwagger> StacksServiceGetStacks (string fields, string sortBy, int? pageSize, string from, string to)
        {
            
    
            var path = "/stacks";
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
                throw new ApiException ((int)response.StatusCode, "Error calling StacksServiceGetStacks: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StacksServiceGetStacks: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<StackResponseSwagger>) ApiClient.Deserialize(response.Content, typeof(List<StackResponseSwagger>), response.Headers);
        }
    
    }
}
