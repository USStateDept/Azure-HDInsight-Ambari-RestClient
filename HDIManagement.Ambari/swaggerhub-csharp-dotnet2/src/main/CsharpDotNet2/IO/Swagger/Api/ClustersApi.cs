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
    public interface IClustersApi
    {
        /// <summary>
        /// Creates a cluster 
        /// </summary>
        /// <param name="clusterName"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void CreateCluster (string clusterName, ClusterRequestSwagger body);
        /// <summary>
        /// Creates a cluster artifact 
        /// </summary>
        /// <param name="clusterName"></param>
        /// <param name="artifactName"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void CreateClusterArtifact (string clusterName, string artifactName, ClusterArtifactRequest body);
        /// <summary>
        /// Deletes a cluster 
        /// </summary>
        /// <param name="clusterName"></param>
        /// <returns></returns>
        void DeleteCluster (string clusterName);
        /// <summary>
        /// Deletes a single artifact 
        /// </summary>
        /// <param name="clusterName"></param>
        /// <param name="artifactName"></param>
        /// <returns></returns>
        void DeleteClusterArtifact (string clusterName, string artifactName);
        /// <summary>
        /// Deletes all artifacts of a cluster that match the provided predicate 
        /// </summary>
        /// <param name="clusterName"></param>
        /// <returns></returns>
        void DeleteClusterArtifacts (string clusterName);
        /// <summary>
        /// Returns information about a specific cluster 
        /// </summary>
        /// <param name="clusterName"></param>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param>
        /// <returns>ClusterResponseWrapper</returns>
        ClusterResponseWrapper GetCluster (string clusterName, string fields);
        /// <summary>
        /// Get the details of a cluster artifact 
        /// </summary>
        /// <param name="clusterName"></param>
        /// <param name="artifactName"></param>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param>
        /// <param name="sortBy">Sort resources in result by (asc | desc)</param>
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param>
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param>
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param>
        /// <returns>ClusterArtifactResponse</returns>
        ClusterArtifactResponse GetClusterArtifact (string clusterName, string artifactName, string fields, string sortBy, int? pageSize, string from, string to);
        /// <summary>
        /// Returns all artifacts associated with the cluster 
        /// </summary>
        /// <param name="clusterName"></param>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param>
        /// <param name="sortBy">Sort resources in result by (asc | desc)</param>
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param>
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param>
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param>
        /// <returns>List&lt;ClusterArtifactResponse&gt;</returns>
        List<ClusterArtifactResponse> GetClusterArtifacts (string clusterName, string fields, string sortBy, int? pageSize, int? from, int? to);
        /// <summary>
        /// Returns all clusters 
        /// </summary>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param>
        /// <param name="sortBy">Sort resources in result by (asc | desc)</param>
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param>
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param>
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param>
        /// <returns>List&lt;ClusterResponseWrapper&gt;</returns>
        List<ClusterResponseWrapper> GetClusters (string fields, string sortBy, int? pageSize, int? from, int? to);
        /// <summary>
        /// Updates a cluster 
        /// </summary>
        /// <param name="clusterName"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void UpdateCluster (string clusterName, ClusterRequestSwagger body);
        /// <summary>
        /// Updates a single artifact 
        /// </summary>
        /// <param name="clusterName"></param>
        /// <param name="artifactName"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void UpdateClusterArtifact (string clusterName, string artifactName, ClusterArtifactRequest body);
        /// <summary>
        /// Updates multiple artifacts 
        /// </summary>
        /// <param name="clusterName"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void UpdateClusterArtifacts (string clusterName, ClusterArtifactRequest body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ClustersApi : IClustersApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClustersApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ClustersApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ClustersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ClustersApi(String basePath)
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
        /// Creates a cluster 
        /// </summary>
        /// <param name="clusterName"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void CreateCluster (string clusterName, ClusterRequestSwagger body)
        {
            
            // verify the required parameter 'clusterName' is set
            if (clusterName == null) throw new ApiException(400, "Missing required parameter 'clusterName' when calling CreateCluster");
            
    
            var path = "/clusters/{clusterName}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateCluster: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateCluster: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }

        public void UpdateUserClusterPriviledge(string clusterName, ClusterPrivilegeUpdateUserRequestSwagger body)
        {
            // verify the required parameter 'clusterName' is set
            if (clusterName == null) throw new ApiException(400, "Missing required parameter 'clusterName' when calling CreateCluster");


            var path = "/clusters/{clusterName}/privileges";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "clusterName" + "}", ApiClient.ParameterToString(clusterName));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling CreateCluster: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CreateCluster: " + response.ErrorMessage, response.ErrorMessage);

            return;

        }

        /// <summary>
        /// Creates a cluster artifact 
        /// </summary>
        /// <param name="clusterName"></param> 
        /// <param name="artifactName"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void CreateClusterArtifact (string clusterName, string artifactName, ClusterArtifactRequest body)
        {
            
            // verify the required parameter 'clusterName' is set
            if (clusterName == null) throw new ApiException(400, "Missing required parameter 'clusterName' when calling CreateClusterArtifact");
            
            // verify the required parameter 'artifactName' is set
            if (artifactName == null) throw new ApiException(400, "Missing required parameter 'artifactName' when calling CreateClusterArtifact");
            
    
            var path = "/clusters/{clusterName}/artifacts/{artifactName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "clusterName" + "}", ApiClient.ParameterToString(clusterName));
path = path.Replace("{" + "artifactName" + "}", ApiClient.ParameterToString(artifactName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateClusterArtifact: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateClusterArtifact: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Deletes a cluster 
        /// </summary>
        /// <param name="clusterName"></param> 
        /// <returns></returns>            
        public void DeleteCluster (string clusterName)
        {
            
            // verify the required parameter 'clusterName' is set
            if (clusterName == null) throw new ApiException(400, "Missing required parameter 'clusterName' when calling DeleteCluster");
            
    
            var path = "/clusters/{clusterName}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCluster: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCluster: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Deletes a single artifact 
        /// </summary>
        /// <param name="clusterName"></param> 
        /// <param name="artifactName"></param> 
        /// <returns></returns>            
        public void DeleteClusterArtifact (string clusterName, string artifactName)
        {
            
            // verify the required parameter 'clusterName' is set
            if (clusterName == null) throw new ApiException(400, "Missing required parameter 'clusterName' when calling DeleteClusterArtifact");
            
            // verify the required parameter 'artifactName' is set
            if (artifactName == null) throw new ApiException(400, "Missing required parameter 'artifactName' when calling DeleteClusterArtifact");
            
    
            var path = "/clusters/{clusterName}/artifacts/{artifactName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "clusterName" + "}", ApiClient.ParameterToString(clusterName));
path = path.Replace("{" + "artifactName" + "}", ApiClient.ParameterToString(artifactName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteClusterArtifact: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteClusterArtifact: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Deletes all artifacts of a cluster that match the provided predicate 
        /// </summary>
        /// <param name="clusterName"></param> 
        /// <returns></returns>            
        public void DeleteClusterArtifacts (string clusterName)
        {
            
            // verify the required parameter 'clusterName' is set
            if (clusterName == null) throw new ApiException(400, "Missing required parameter 'clusterName' when calling DeleteClusterArtifacts");
            
    
            var path = "/clusters/{clusterName}/artifacts";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteClusterArtifacts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteClusterArtifacts: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Returns information about a specific cluster 
        /// </summary>
        /// <param name="clusterName"></param> 
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param> 
        /// <returns>ClusterResponseWrapper</returns>            
        public ClusterResponseWrapper GetCluster (string clusterName, string fields)
        {
            
            // verify the required parameter 'clusterName' is set
            if (clusterName == null) throw new ApiException(400, "Missing required parameter 'clusterName' when calling GetCluster");
            
    
            var path = "/clusters/{clusterName}";
            path = path.Replace("{format}", "json");
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCluster: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCluster: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ClusterResponseWrapper) ApiClient.Deserialize(response.Content, typeof(ClusterResponseWrapper), response.Headers);
        }
    
        /// <summary>
        /// Get the details of a cluster artifact 
        /// </summary>
        /// <param name="clusterName"></param> 
        /// <param name="artifactName"></param> 
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param> 
        /// <param name="sortBy">Sort resources in result by (asc | desc)</param> 
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param> 
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param> 
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param> 
        /// <returns>ClusterArtifactResponse</returns>            
        public ClusterArtifactResponse GetClusterArtifact (string clusterName, string artifactName, string fields, string sortBy, int? pageSize, string from, string to)
        {
            
            // verify the required parameter 'clusterName' is set
            if (clusterName == null) throw new ApiException(400, "Missing required parameter 'clusterName' when calling GetClusterArtifact");
            
            // verify the required parameter 'artifactName' is set
            if (artifactName == null) throw new ApiException(400, "Missing required parameter 'artifactName' when calling GetClusterArtifact");
            
    
            var path = "/clusters/{clusterName}/artifacts/{artifactName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "clusterName" + "}", ApiClient.ParameterToString(clusterName));
path = path.Replace("{" + "artifactName" + "}", ApiClient.ParameterToString(artifactName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClusterArtifact: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClusterArtifact: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ClusterArtifactResponse) ApiClient.Deserialize(response.Content, typeof(ClusterArtifactResponse), response.Headers);
        }
    
        /// <summary>
        /// Returns all artifacts associated with the cluster 
        /// </summary>
        /// <param name="clusterName"></param> 
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param> 
        /// <param name="sortBy">Sort resources in result by (asc | desc)</param> 
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param> 
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param> 
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param> 
        /// <returns>List&lt;ClusterArtifactResponse&gt;</returns>            
        public List<ClusterArtifactResponse> GetClusterArtifacts (string clusterName, string fields, string sortBy, int? pageSize, int? from, int? to)
        {
            
            // verify the required parameter 'clusterName' is set
            if (clusterName == null) throw new ApiException(400, "Missing required parameter 'clusterName' when calling GetClusterArtifacts");
            
    
            var path = "/clusters/{clusterName}/artifacts";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClusterArtifacts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClusterArtifacts: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ClusterArtifactResponse>) ApiClient.Deserialize(response.Content, typeof(List<ClusterArtifactResponse>), response.Headers);
        }
    
        /// <summary>
        /// Returns all clusters 
        /// </summary>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param> 
        /// <param name="sortBy">Sort resources in result by (asc | desc)</param> 
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param> 
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param> 
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param> 
        /// <returns>List&lt;ClusterResponseWrapper&gt;</returns>            
        public List<ClusterResponseWrapper> GetClusters (string fields, string sortBy, int? pageSize, int? from, int? to)
        {
            
    
            var path = "/clusters";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClusters: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClusters: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ClusterResponseWrapper>) ApiClient.Deserialize(response.Content, typeof(List<ClusterResponseWrapper>), response.Headers);
        }
    
        /// <summary>
        /// Updates a cluster 
        /// </summary>
        /// <param name="clusterName"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void UpdateCluster (string clusterName, ClusterRequestSwagger body)
        {
            
            // verify the required parameter 'clusterName' is set
            if (clusterName == null) throw new ApiException(400, "Missing required parameter 'clusterName' when calling UpdateCluster");
            
    
            var path = "/clusters/{clusterName}";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCluster: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCluster: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Updates a single artifact 
        /// </summary>
        /// <param name="clusterName"></param> 
        /// <param name="artifactName"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void UpdateClusterArtifact (string clusterName, string artifactName, ClusterArtifactRequest body)
        {
            
            // verify the required parameter 'clusterName' is set
            if (clusterName == null) throw new ApiException(400, "Missing required parameter 'clusterName' when calling UpdateClusterArtifact");
            
            // verify the required parameter 'artifactName' is set
            if (artifactName == null) throw new ApiException(400, "Missing required parameter 'artifactName' when calling UpdateClusterArtifact");
            
    
            var path = "/clusters/{clusterName}/artifacts/{artifactName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "clusterName" + "}", ApiClient.ParameterToString(clusterName));
path = path.Replace("{" + "artifactName" + "}", ApiClient.ParameterToString(artifactName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateClusterArtifact: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateClusterArtifact: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Updates multiple artifacts 
        /// </summary>
        /// <param name="clusterName"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void UpdateClusterArtifacts (string clusterName, ClusterArtifactRequest body)
        {
            
            // verify the required parameter 'clusterName' is set
            if (clusterName == null) throw new ApiException(400, "Missing required parameter 'clusterName' when calling UpdateClusterArtifacts");
            
    
            var path = "/clusters/{clusterName}/artifacts";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateClusterArtifacts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateClusterArtifacts: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
