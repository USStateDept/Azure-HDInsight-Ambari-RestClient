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
    public interface IClusterServicesApi
    {
        /// <summary>
        /// Creates a service artifact 
        /// </summary>
        /// <param name="serviceName"></param>
        /// <param name="artifactName"></param>
        /// <param name="clusterName"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void ServiceServiceCreateArtifact (string serviceName, string artifactName, string clusterName, ClusterServiceArtifactRequest body);
        /// <summary>
        /// Creates a service 
        /// </summary>
        /// <param name="serviceName"></param>
        /// <param name="clusterName"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void ServiceServiceCreateServices (string serviceName, string clusterName, ServiceRequestSwagger body);
        /// <summary>
        /// Deletes a single service artifact 
        /// </summary>
        /// <param name="serviceName"></param>
        /// <param name="artifactName"></param>
        /// <param name="clusterName"></param>
        /// <returns></returns>
        void ServiceServiceDeleteArtifact (string serviceName, string artifactName, string clusterName);
        /// <summary>
        /// Deletes all artifacts of a service that match the provided predicate 
        /// </summary>
        /// <param name="serviceName"></param>
        /// <param name="clusterName"></param>
        /// <returns></returns>
        void ServiceServiceDeleteArtifacts (string serviceName, string clusterName);
        /// <summary>
        /// Deletes a service 
        /// </summary>
        /// <param name="serviceName"></param>
        /// <param name="clusterName"></param>
        /// <returns></returns>
        void ServiceServiceDeleteService (string serviceName, string clusterName);
        /// <summary>
        /// Get the details of a service artifact 
        /// </summary>
        /// <param name="serviceName"></param>
        /// <param name="artifactName"></param>
        /// <param name="clusterName"></param>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param>
        /// <param name="sortBy">Sort resources in result by (asc | desc)</param>
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param>
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param>
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param>
        /// <returns>List&lt;ClusterServiceArtifactResponse&gt;</returns>
        List<ClusterServiceArtifactResponse> ServiceServiceGetArtifact (string serviceName, string artifactName, string clusterName, string fields, string sortBy, int? pageSize, string from, string to);
        /// <summary>
        /// Get all service artifacts 
        /// </summary>
        /// <param name="serviceName"></param>
        /// <param name="clusterName"></param>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param>
        /// <param name="sortBy">Sort resources in result by (asc | desc)</param>
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param>
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param>
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param>
        /// <returns>List&lt;ClusterServiceArtifactResponse&gt;</returns>
        List<ClusterServiceArtifactResponse> ServiceServiceGetArtifacts (string serviceName, string clusterName, string fields, string sortBy, int? pageSize, string from, string to);
        /// <summary>
        /// Get the details of a service Returns the details of a service.
        /// </summary>
        /// <param name="serviceName"></param>
        /// <param name="clusterName"></param>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param>
        /// <returns>List&lt;ServiceResponseSwagger&gt;</returns>
        List<ServiceResponseSwagger> ServiceServiceGetService (string serviceName, string clusterName, string fields);
        /// <summary>
        /// Get all services Returns all services.
        /// </summary>
        /// <param name="clusterName"></param>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param>
        /// <param name="sortBy">Sort resources in result by (asc | desc)</param>
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param>
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param>
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param>
        /// <returns>List&lt;ServiceResponseSwagger&gt;</returns>
        List<ServiceResponseSwagger> ServiceServiceGetServices (string clusterName, string fields, string sortBy, int? pageSize, string from, string to);
        /// <summary>
        /// Updates a single artifact 
        /// </summary>
        /// <param name="serviceName"></param>
        /// <param name="artifactName"></param>
        /// <param name="clusterName"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void ServiceServiceUpdateArtifact (string serviceName, string artifactName, string clusterName, ClusterServiceArtifactRequest body);
        /// <summary>
        /// Updates multiple artifacts 
        /// </summary>
        /// <param name="serviceName"></param>
        /// <param name="clusterName"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void ServiceServiceUpdateArtifacts (string serviceName, string clusterName, ClusterServiceArtifactRequest body);
        /// <summary>
        /// Updates a service 
        /// </summary>
        /// <param name="serviceName"></param>
        /// <param name="clusterName"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void ServiceServiceUpdateService (string serviceName, string clusterName, ServiceRequestSwagger body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ClusterServicesApi : IClusterServicesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterServicesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ClusterServicesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterServicesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ClusterServicesApi(String basePath)
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
        /// Creates a service artifact 
        /// </summary>
        /// <param name="serviceName"></param> 
        /// <param name="artifactName"></param> 
        /// <param name="clusterName"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void ServiceServiceCreateArtifact (string serviceName, string artifactName, string clusterName, ClusterServiceArtifactRequest body)
        {
            
            // verify the required parameter 'serviceName' is set
            if (serviceName == null) throw new ApiException(400, "Missing required parameter 'serviceName' when calling ServiceServiceCreateArtifact");
            
            // verify the required parameter 'artifactName' is set
            if (artifactName == null) throw new ApiException(400, "Missing required parameter 'artifactName' when calling ServiceServiceCreateArtifact");
            
            // verify the required parameter 'clusterName' is set
            if (clusterName == null) throw new ApiException(400, "Missing required parameter 'clusterName' when calling ServiceServiceCreateArtifact");
            
    
            var path = "/clusters/{clusterName}/services/{serviceName}/artifacts/{artifactName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "serviceName" + "}", ApiClient.ParameterToString(serviceName));
path = path.Replace("{" + "artifactName" + "}", ApiClient.ParameterToString(artifactName));
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
                throw new ApiException ((int)response.StatusCode, "Error calling ServiceServiceCreateArtifact: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ServiceServiceCreateArtifact: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Creates a service 
        /// </summary>
        /// <param name="serviceName"></param> 
        /// <param name="clusterName"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void ServiceServiceCreateServices (string serviceName, string clusterName, ServiceRequestSwagger body)
        {
            
            // verify the required parameter 'serviceName' is set
            if (serviceName == null) throw new ApiException(400, "Missing required parameter 'serviceName' when calling ServiceServiceCreateServices");
            
            // verify the required parameter 'clusterName' is set
            if (clusterName == null) throw new ApiException(400, "Missing required parameter 'clusterName' when calling ServiceServiceCreateServices");
            
    
            var path = "/clusters/{clusterName}/services/{serviceName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "serviceName" + "}", ApiClient.ParameterToString(serviceName));
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
                throw new ApiException ((int)response.StatusCode, "Error calling ServiceServiceCreateServices: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ServiceServiceCreateServices: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Deletes a single service artifact 
        /// </summary>
        /// <param name="serviceName"></param> 
        /// <param name="artifactName"></param> 
        /// <param name="clusterName"></param> 
        /// <returns></returns>            
        public void ServiceServiceDeleteArtifact (string serviceName, string artifactName, string clusterName)
        {
            
            // verify the required parameter 'serviceName' is set
            if (serviceName == null) throw new ApiException(400, "Missing required parameter 'serviceName' when calling ServiceServiceDeleteArtifact");
            
            // verify the required parameter 'artifactName' is set
            if (artifactName == null) throw new ApiException(400, "Missing required parameter 'artifactName' when calling ServiceServiceDeleteArtifact");
            
            // verify the required parameter 'clusterName' is set
            if (clusterName == null) throw new ApiException(400, "Missing required parameter 'clusterName' when calling ServiceServiceDeleteArtifact");
            
    
            var path = "/clusters/{clusterName}/services/{serviceName}/artifacts/{artifactName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "serviceName" + "}", ApiClient.ParameterToString(serviceName));
path = path.Replace("{" + "artifactName" + "}", ApiClient.ParameterToString(artifactName));
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
                throw new ApiException ((int)response.StatusCode, "Error calling ServiceServiceDeleteArtifact: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ServiceServiceDeleteArtifact: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Deletes all artifacts of a service that match the provided predicate 
        /// </summary>
        /// <param name="serviceName"></param> 
        /// <param name="clusterName"></param> 
        /// <returns></returns>            
        public void ServiceServiceDeleteArtifacts (string serviceName, string clusterName)
        {
            
            // verify the required parameter 'serviceName' is set
            if (serviceName == null) throw new ApiException(400, "Missing required parameter 'serviceName' when calling ServiceServiceDeleteArtifacts");
            
            // verify the required parameter 'clusterName' is set
            if (clusterName == null) throw new ApiException(400, "Missing required parameter 'clusterName' when calling ServiceServiceDeleteArtifacts");
            
    
            var path = "/clusters/{clusterName}/services/{serviceName}/artifacts";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "serviceName" + "}", ApiClient.ParameterToString(serviceName));
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
                throw new ApiException ((int)response.StatusCode, "Error calling ServiceServiceDeleteArtifacts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ServiceServiceDeleteArtifacts: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Deletes a service 
        /// </summary>
        /// <param name="serviceName"></param> 
        /// <param name="clusterName"></param> 
        /// <returns></returns>            
        public void ServiceServiceDeleteService (string serviceName, string clusterName)
        {
            
            // verify the required parameter 'serviceName' is set
            if (serviceName == null) throw new ApiException(400, "Missing required parameter 'serviceName' when calling ServiceServiceDeleteService");
            
            // verify the required parameter 'clusterName' is set
            if (clusterName == null) throw new ApiException(400, "Missing required parameter 'clusterName' when calling ServiceServiceDeleteService");
            
    
            var path = "/clusters/{clusterName}/services/{serviceName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "serviceName" + "}", ApiClient.ParameterToString(serviceName));
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
                throw new ApiException ((int)response.StatusCode, "Error calling ServiceServiceDeleteService: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ServiceServiceDeleteService: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get the details of a service artifact 
        /// </summary>
        /// <param name="serviceName"></param> 
        /// <param name="artifactName"></param> 
        /// <param name="clusterName"></param> 
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param> 
        /// <param name="sortBy">Sort resources in result by (asc | desc)</param> 
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param> 
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param> 
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param> 
        /// <returns>List&lt;ClusterServiceArtifactResponse&gt;</returns>            
        public List<ClusterServiceArtifactResponse> ServiceServiceGetArtifact (string serviceName, string artifactName, string clusterName, string fields, string sortBy, int? pageSize, string from, string to)
        {
            
            // verify the required parameter 'serviceName' is set
            if (serviceName == null) throw new ApiException(400, "Missing required parameter 'serviceName' when calling ServiceServiceGetArtifact");
            
            // verify the required parameter 'artifactName' is set
            if (artifactName == null) throw new ApiException(400, "Missing required parameter 'artifactName' when calling ServiceServiceGetArtifact");
            
            // verify the required parameter 'clusterName' is set
            if (clusterName == null) throw new ApiException(400, "Missing required parameter 'clusterName' when calling ServiceServiceGetArtifact");
            
    
            var path = "/clusters/{clusterName}/services/{serviceName}/artifacts/{artifactName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "serviceName" + "}", ApiClient.ParameterToString(serviceName));
path = path.Replace("{" + "artifactName" + "}", ApiClient.ParameterToString(artifactName));
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
                throw new ApiException ((int)response.StatusCode, "Error calling ServiceServiceGetArtifact: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ServiceServiceGetArtifact: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ClusterServiceArtifactResponse>) ApiClient.Deserialize(response.Content, typeof(List<ClusterServiceArtifactResponse>), response.Headers);
        }
    
        /// <summary>
        /// Get all service artifacts 
        /// </summary>
        /// <param name="serviceName"></param> 
        /// <param name="clusterName"></param> 
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param> 
        /// <param name="sortBy">Sort resources in result by (asc | desc)</param> 
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param> 
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param> 
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param> 
        /// <returns>List&lt;ClusterServiceArtifactResponse&gt;</returns>            
        public List<ClusterServiceArtifactResponse> ServiceServiceGetArtifacts (string serviceName, string clusterName, string fields, string sortBy, int? pageSize, string from, string to)
        {
            
            // verify the required parameter 'serviceName' is set
            if (serviceName == null) throw new ApiException(400, "Missing required parameter 'serviceName' when calling ServiceServiceGetArtifacts");
            
            // verify the required parameter 'clusterName' is set
            if (clusterName == null) throw new ApiException(400, "Missing required parameter 'clusterName' when calling ServiceServiceGetArtifacts");
            
    
            var path = "/clusters/{clusterName}/services/{serviceName}/artifacts";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "serviceName" + "}", ApiClient.ParameterToString(serviceName));
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
                throw new ApiException ((int)response.StatusCode, "Error calling ServiceServiceGetArtifacts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ServiceServiceGetArtifacts: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ClusterServiceArtifactResponse>) ApiClient.Deserialize(response.Content, typeof(List<ClusterServiceArtifactResponse>), response.Headers);
        }
    
        /// <summary>
        /// Get the details of a service Returns the details of a service.
        /// </summary>
        /// <param name="serviceName"></param> 
        /// <param name="clusterName"></param> 
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param> 
        /// <returns>List&lt;ServiceResponseSwagger&gt;</returns>            
        public List<ServiceResponseSwagger> ServiceServiceGetService (string serviceName, string clusterName, string fields)
        {
            
            // verify the required parameter 'serviceName' is set
            if (serviceName == null) throw new ApiException(400, "Missing required parameter 'serviceName' when calling ServiceServiceGetService");
            
            // verify the required parameter 'clusterName' is set
            if (clusterName == null) throw new ApiException(400, "Missing required parameter 'clusterName' when calling ServiceServiceGetService");
            
    
            var path = "/clusters/{clusterName}/services/{serviceName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "serviceName" + "}", ApiClient.ParameterToString(serviceName));
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
                throw new ApiException ((int)response.StatusCode, "Error calling ServiceServiceGetService: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ServiceServiceGetService: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ServiceResponseSwagger>) ApiClient.Deserialize(response.Content, typeof(List<ServiceResponseSwagger>), response.Headers);
        }
    
        /// <summary>
        /// Get all services Returns all services.
        /// </summary>
        /// <param name="clusterName"></param> 
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param> 
        /// <param name="sortBy">Sort resources in result by (asc | desc)</param> 
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param> 
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param> 
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param> 
        /// <returns>List&lt;ServiceResponseSwagger&gt;</returns>            
        public List<ServiceResponseSwagger> ServiceServiceGetServices (string clusterName, string fields, string sortBy, int? pageSize, string from, string to)
        {
            
            // verify the required parameter 'clusterName' is set
            if (clusterName == null) throw new ApiException(400, "Missing required parameter 'clusterName' when calling ServiceServiceGetServices");
            
    
            var path = "/clusters/{clusterName}/services";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ServiceServiceGetServices: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ServiceServiceGetServices: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ServiceResponseSwagger>) ApiClient.Deserialize(response.Content, typeof(List<ServiceResponseSwagger>), response.Headers);
        }
    
        /// <summary>
        /// Updates a single artifact 
        /// </summary>
        /// <param name="serviceName"></param> 
        /// <param name="artifactName"></param> 
        /// <param name="clusterName"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void ServiceServiceUpdateArtifact (string serviceName, string artifactName, string clusterName, ClusterServiceArtifactRequest body)
        {
            
            // verify the required parameter 'serviceName' is set
            if (serviceName == null) throw new ApiException(400, "Missing required parameter 'serviceName' when calling ServiceServiceUpdateArtifact");
            
            // verify the required parameter 'artifactName' is set
            if (artifactName == null) throw new ApiException(400, "Missing required parameter 'artifactName' when calling ServiceServiceUpdateArtifact");
            
            // verify the required parameter 'clusterName' is set
            if (clusterName == null) throw new ApiException(400, "Missing required parameter 'clusterName' when calling ServiceServiceUpdateArtifact");
            
    
            var path = "/clusters/{clusterName}/services/{serviceName}/artifacts/{artifactName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "serviceName" + "}", ApiClient.ParameterToString(serviceName));
path = path.Replace("{" + "artifactName" + "}", ApiClient.ParameterToString(artifactName));
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
                throw new ApiException ((int)response.StatusCode, "Error calling ServiceServiceUpdateArtifact: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ServiceServiceUpdateArtifact: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Updates multiple artifacts 
        /// </summary>
        /// <param name="serviceName"></param> 
        /// <param name="clusterName"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void ServiceServiceUpdateArtifacts (string serviceName, string clusterName, ClusterServiceArtifactRequest body)
        {
            
            // verify the required parameter 'serviceName' is set
            if (serviceName == null) throw new ApiException(400, "Missing required parameter 'serviceName' when calling ServiceServiceUpdateArtifacts");
            
            // verify the required parameter 'clusterName' is set
            if (clusterName == null) throw new ApiException(400, "Missing required parameter 'clusterName' when calling ServiceServiceUpdateArtifacts");
            
    
            var path = "/clusters/{clusterName}/services/{serviceName}/artifacts";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "serviceName" + "}", ApiClient.ParameterToString(serviceName));
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
                throw new ApiException ((int)response.StatusCode, "Error calling ServiceServiceUpdateArtifacts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ServiceServiceUpdateArtifacts: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Updates a service 
        /// </summary>
        /// <param name="serviceName"></param> 
        /// <param name="clusterName"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void ServiceServiceUpdateService (string serviceName, string clusterName, ServiceRequestSwagger body)
        {
            
            // verify the required parameter 'serviceName' is set
            if (serviceName == null) throw new ApiException(400, "Missing required parameter 'serviceName' when calling ServiceServiceUpdateService");
            
            // verify the required parameter 'clusterName' is set
            if (clusterName == null) throw new ApiException(400, "Missing required parameter 'clusterName' when calling ServiceServiceUpdateService");
            
    
            var path = "/clusters/{clusterName}/services/{serviceName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "serviceName" + "}", ApiClient.ParameterToString(serviceName));
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
                throw new ApiException ((int)response.StatusCode, "Error calling ServiceServiceUpdateService: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ServiceServiceUpdateService: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
