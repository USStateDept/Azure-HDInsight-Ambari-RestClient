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
    public interface IViewsApi
    {
        /// <summary>
        /// Create view instance privilege 
        /// </summary>
        /// <param name="viewName">view name</param>
        /// <param name="version">view version</param>
        /// <param name="instanceName">instance name</param>
        /// <param name="body"></param>
        /// <returns></returns>
        void CreatePrivilege (string viewName, string version, string instanceName, ViewPrivilegeService body);
        /// <summary>
        /// Create view instance 
        /// </summary>
        /// <param name="viewName">view name</param>
        /// <param name="version"></param>
        /// <param name="instanceName">instance name</param>
        /// <param name="body"></param>
        /// <returns></returns>
        void CreateService (string viewName, string version, string instanceName, ViewInstanceResponse body);
        /// <summary>
        /// Create view instances 
        /// </summary>
        /// <param name="viewName"></param>
        /// <param name="version"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void CreateServices (string viewName, string version, ViewInstanceResponse body);
        /// <summary>
        /// Create view URL 
        /// </summary>
        /// <param name="urlName"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void CreateUrl (string urlName, ViewUrlResponseSwagger body);
        /// <summary>
        /// Delete privileges 
        /// </summary>
        /// <param name="viewName">view name</param>
        /// <param name="version">view version</param>
        /// <param name="instanceName">instance name</param>
        /// <param name="privilegeId">privilege id</param>
        /// <returns></returns>
        void DeletePrivilege (string viewName, string version, string instanceName, string privilegeId);
        /// <summary>
        /// Delete view instance privileges 
        /// </summary>
        /// <param name="viewName">view name</param>
        /// <param name="viewVersion">view version</param>
        /// <param name="instanceName">instance name</param>
        /// <returns></returns>
        void DeletePrivileges (string viewName, string viewVersion, string instanceName);
        /// <summary>
        /// Delete view instance 
        /// </summary>
        /// <param name="viewName">view name</param>
        /// <param name="version"></param>
        /// <param name="instanceName">instance name</param>
        /// <returns></returns>
        void DeleteService (string viewName, string version, string instanceName);
        /// <summary>
        /// Delete view URL 
        /// </summary>
        /// <param name="urlName"></param>
        /// <returns></returns>
        void DeleteUrl (string urlName);
        /// <summary>
        /// Get single view permission 
        /// </summary>
        /// <param name="viewName">view name</param>
        /// <param name="version">view version</param>
        /// <param name="permissionId">permission id</param>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param>
        /// <returns>ViewPermissionResponse</returns>
        ViewPermissionResponse GetPermission (string viewName, string version, string permissionId, string fields);
        /// <summary>
        /// Get all permissions for a view 
        /// </summary>
        /// <param name="viewName">view name</param>
        /// <param name="version">view version</param>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param>
        /// <param name="sortBy">Sort resources in result by (asc | desc)</param>
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param>
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param>
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param>
        /// <returns>List&lt;ViewPermissionResponse&gt;</returns>
        List<ViewPermissionResponse> GetPermissions (string viewName, string version, string fields, string sortBy, int? pageSize, int? from, int? to);
        /// <summary>
        /// Get single view instance privilege 
        /// </summary>
        /// <param name="viewName">view name</param>
        /// <param name="version">view version</param>
        /// <param name="instanceName">instance name</param>
        /// <param name="privilegeId">privilege id</param>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param>
        /// <returns>ViewPrivilegeResponseWrapper</returns>
        ViewPrivilegeResponseWrapper GetPrivilege (string viewName, string version, string instanceName, string privilegeId, string fields);
        /// <summary>
        /// Get all view instance privileges 
        /// </summary>
        /// <param name="viewName">view name</param>
        /// <param name="version">view version</param>
        /// <param name="instanceName">instance name</param>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param>
        /// <param name="sortBy">Sort resources in result by (asc | desc)</param>
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param>
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param>
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param>
        /// <returns>List&lt;ViewPrivilegeResponseWrapper&gt;</returns>
        List<ViewPrivilegeResponseWrapper> GetPrivileges (string viewName, string version, string instanceName, string fields, string sortBy, int? pageSize, int? from, int? to);
        /// <summary>
        /// Get single view instance 
        /// </summary>
        /// <param name="viewName">view name</param>
        /// <param name="version"></param>
        /// <param name="instanceName">instance name</param>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param>
        /// <returns>ViewInstanceResponse</returns>
        ViewInstanceResponse GetService (string viewName, string version, string instanceName, string fields);
        /// <summary>
        /// Get all view instances 
        /// </summary>
        /// <param name="viewName"></param>
        /// <param name="version"></param>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param>
        /// <param name="sortBy">Sort resources in result by (asc | desc)</param>
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param>
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param>
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param>
        /// <returns>List&lt;ViewInstanceResponse&gt;</returns>
        List<ViewInstanceResponse> GetServices (string viewName, string version, string fields, string sortBy, int? pageSize, int? from, int? to);
        /// <summary>
        /// Get single view version 
        /// </summary>
        /// <param name="viewName">view name</param>
        /// <param name="version"></param>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param>
        /// <returns>ViewVersionResponse</returns>
        ViewVersionResponse GetVersion (string viewName, string version, string fields);
        /// <summary>
        /// Get all versions for a view 
        /// </summary>
        /// <param name="viewName">view name</param>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param>
        /// <param name="sortBy">Sort resources in result by (asc | desc)</param>
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param>
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param>
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param>
        /// <returns>List&lt;ViewVersionResponse&gt;</returns>
        List<ViewVersionResponse> GetVersions (string viewName, string fields, string sortBy, int? pageSize, int? from, int? to);
        /// <summary>
        /// Get single view 
        /// </summary>
        /// <param name="viewName">view name</param>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param>
        /// <returns>ViewResponse</returns>
        ViewResponse GetView (string viewName, string fields);
        /// <summary>
        /// Get single view URL 
        /// </summary>
        /// <param name="urlName"></param>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param>
        /// <returns>ViewUrlResponseSwagger</returns>
        ViewUrlResponseSwagger GetViewUrl (string urlName, string fields);
        /// <summary>
        /// Get all view URLs 
        /// </summary>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param>
        /// <param name="sortBy">Sort resources in result by (asc | desc)</param>
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param>
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param>
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param>
        /// <returns>List&lt;ViewUrlResponseSwagger&gt;</returns>
        List<ViewUrlResponseSwagger> GetViewUrls (string fields, string sortBy, int? pageSize, int? from, int? to);
        /// <summary>
        /// Get all views Returns details of all views.
        /// </summary>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param>
        /// <param name="sortBy">Sort resources in result by (asc | desc)</param>
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param>
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param>
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param>
        /// <returns>List&lt;ViewResponse&gt;</returns>
        List<ViewResponse> GetViews (string fields, string sortBy, int? pageSize, int? from, int? to);
        /// <summary>
        /// Migrate view instance data Migrates view instance persistence data from origin view instance specified in the path params.
        /// </summary>
        /// <param name="viewName">view name</param>
        /// <param name="version">view version</param>
        /// <param name="instanceName">instance name</param>
        /// <param name="originVersion">origin version</param>
        /// <param name="originInstanceName">origin instance name</param>
        /// <returns></returns>
        void MigrateData (string viewName, string version, string instanceName, string originVersion, string originInstanceName);
        /// <summary>
        /// Update view instance privilege 
        /// </summary>
        /// <param name="viewName">view name</param>
        /// <param name="version">view version</param>
        /// <param name="instanceName">instance name</param>
        /// <param name="body"></param>
        /// <returns></returns>
        void UpdatePrivileges (string viewName, string version, string instanceName, ViewPrivilegeService body);
        /// <summary>
        /// Update view instance detail 
        /// </summary>
        /// <param name="viewName">view name</param>
        /// <param name="version"></param>
        /// <param name="instanceName">instance name</param>
        /// <param name="body"></param>
        /// <returns></returns>
        void UpdateService (string viewName, string version, string instanceName, ViewInstanceResponse body);
        /// <summary>
        /// Update multiple view instance detail 
        /// </summary>
        /// <param name="viewName"></param>
        /// <param name="version"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void UpdateServices (string viewName, string version, ViewInstanceResponse body);
        /// <summary>
        /// Update view URL 
        /// </summary>
        /// <param name="urlName"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void UpdateUrl (string urlName, ViewUrlResponseSwagger body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ViewsApi : IViewsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ViewsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ViewsApi(String basePath)
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
        /// Create view instance privilege 
        /// </summary>
        /// <param name="viewName">view name</param> 
        /// <param name="version">view version</param> 
        /// <param name="instanceName">instance name</param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void CreatePrivilege (string viewName, string version, string instanceName, ViewPrivilegeService body)
        {
            
            // verify the required parameter 'viewName' is set
            if (viewName == null) throw new ApiException(400, "Missing required parameter 'viewName' when calling CreatePrivilege");
            
            // verify the required parameter 'version' is set
            if (version == null) throw new ApiException(400, "Missing required parameter 'version' when calling CreatePrivilege");
            
            // verify the required parameter 'instanceName' is set
            if (instanceName == null) throw new ApiException(400, "Missing required parameter 'instanceName' when calling CreatePrivilege");
            
    
            var path = "/views/{viewName}/versions/{version}/instances/{instanceName}/privileges";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "viewName" + "}", ApiClient.ParameterToString(viewName));
path = path.Replace("{" + "version" + "}", ApiClient.ParameterToString(version));
path = path.Replace("{" + "instanceName" + "}", ApiClient.ParameterToString(instanceName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreatePrivilege: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreatePrivilege: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create view instance 
        /// </summary>
        /// <param name="viewName">view name</param> 
        /// <param name="version"></param> 
        /// <param name="instanceName">instance name</param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void CreateService (string viewName, string version, string instanceName, ViewInstanceResponse body)
        {
            
            // verify the required parameter 'viewName' is set
            if (viewName == null) throw new ApiException(400, "Missing required parameter 'viewName' when calling CreateService");
            
            // verify the required parameter 'version' is set
            if (version == null) throw new ApiException(400, "Missing required parameter 'version' when calling CreateService");
            
            // verify the required parameter 'instanceName' is set
            if (instanceName == null) throw new ApiException(400, "Missing required parameter 'instanceName' when calling CreateService");
            
    
            var path = "/views/{viewName}/versions/{version}/instances/{instanceName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "viewName" + "}", ApiClient.ParameterToString(viewName));
path = path.Replace("{" + "version" + "}", ApiClient.ParameterToString(version));
path = path.Replace("{" + "instanceName" + "}", ApiClient.ParameterToString(instanceName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateService: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateService: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create view instances 
        /// </summary>
        /// <param name="viewName"></param> 
        /// <param name="version"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void CreateServices (string viewName, string version, ViewInstanceResponse body)
        {
            
            // verify the required parameter 'viewName' is set
            if (viewName == null) throw new ApiException(400, "Missing required parameter 'viewName' when calling CreateServices");
            
            // verify the required parameter 'version' is set
            if (version == null) throw new ApiException(400, "Missing required parameter 'version' when calling CreateServices");
            
    
            var path = "/views/{viewName}/versions/{version}/instances";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "viewName" + "}", ApiClient.ParameterToString(viewName));
path = path.Replace("{" + "version" + "}", ApiClient.ParameterToString(version));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateServices: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateServices: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create view URL 
        /// </summary>
        /// <param name="urlName"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void CreateUrl (string urlName, ViewUrlResponseSwagger body)
        {
            
            // verify the required parameter 'urlName' is set
            if (urlName == null) throw new ApiException(400, "Missing required parameter 'urlName' when calling CreateUrl");
            
    
            var path = "/view/urls/{urlName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "urlName" + "}", ApiClient.ParameterToString(urlName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateUrl: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateUrl: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete privileges 
        /// </summary>
        /// <param name="viewName">view name</param> 
        /// <param name="version">view version</param> 
        /// <param name="instanceName">instance name</param> 
        /// <param name="privilegeId">privilege id</param> 
        /// <returns></returns>            
        public void DeletePrivilege (string viewName, string version, string instanceName, string privilegeId)
        {
            
            // verify the required parameter 'viewName' is set
            if (viewName == null) throw new ApiException(400, "Missing required parameter 'viewName' when calling DeletePrivilege");
            
            // verify the required parameter 'version' is set
            if (version == null) throw new ApiException(400, "Missing required parameter 'version' when calling DeletePrivilege");
            
            // verify the required parameter 'instanceName' is set
            if (instanceName == null) throw new ApiException(400, "Missing required parameter 'instanceName' when calling DeletePrivilege");
            
            // verify the required parameter 'privilegeId' is set
            if (privilegeId == null) throw new ApiException(400, "Missing required parameter 'privilegeId' when calling DeletePrivilege");
            
    
            var path = "/views/{viewName}/versions/{version}/instances/{instanceName}/privileges/{privilegeId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "viewName" + "}", ApiClient.ParameterToString(viewName));
path = path.Replace("{" + "version" + "}", ApiClient.ParameterToString(version));
path = path.Replace("{" + "instanceName" + "}", ApiClient.ParameterToString(instanceName));
path = path.Replace("{" + "privilegeId" + "}", ApiClient.ParameterToString(privilegeId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeletePrivilege: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeletePrivilege: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete view instance privileges 
        /// </summary>
        /// <param name="viewName">view name</param> 
        /// <param name="viewVersion">view version</param> 
        /// <param name="instanceName">instance name</param> 
        /// <returns></returns>            
        public void DeletePrivileges (string viewName, string viewVersion, string instanceName)
        {
            
            // verify the required parameter 'viewName' is set
            if (viewName == null) throw new ApiException(400, "Missing required parameter 'viewName' when calling DeletePrivileges");
            
            // verify the required parameter 'viewVersion' is set
            if (viewVersion == null) throw new ApiException(400, "Missing required parameter 'viewVersion' when calling DeletePrivileges");
            
            // verify the required parameter 'instanceName' is set
            if (instanceName == null) throw new ApiException(400, "Missing required parameter 'instanceName' when calling DeletePrivileges");
            
    
            var path = "/views/{viewName}/versions/{version}/instances/{instanceName}/privileges";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "viewName" + "}", ApiClient.ParameterToString(viewName));
path = path.Replace("{" + "viewVersion" + "}", ApiClient.ParameterToString(viewVersion));
path = path.Replace("{" + "instanceName" + "}", ApiClient.ParameterToString(instanceName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeletePrivileges: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeletePrivileges: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete view instance 
        /// </summary>
        /// <param name="viewName">view name</param> 
        /// <param name="version"></param> 
        /// <param name="instanceName">instance name</param> 
        /// <returns></returns>            
        public void DeleteService (string viewName, string version, string instanceName)
        {
            
            // verify the required parameter 'viewName' is set
            if (viewName == null) throw new ApiException(400, "Missing required parameter 'viewName' when calling DeleteService");
            
            // verify the required parameter 'version' is set
            if (version == null) throw new ApiException(400, "Missing required parameter 'version' when calling DeleteService");
            
            // verify the required parameter 'instanceName' is set
            if (instanceName == null) throw new ApiException(400, "Missing required parameter 'instanceName' when calling DeleteService");
            
    
            var path = "/views/{viewName}/versions/{version}/instances/{instanceName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "viewName" + "}", ApiClient.ParameterToString(viewName));
path = path.Replace("{" + "version" + "}", ApiClient.ParameterToString(version));
path = path.Replace("{" + "instanceName" + "}", ApiClient.ParameterToString(instanceName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteService: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteService: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete view URL 
        /// </summary>
        /// <param name="urlName"></param> 
        /// <returns></returns>            
        public void DeleteUrl (string urlName)
        {
            
            // verify the required parameter 'urlName' is set
            if (urlName == null) throw new ApiException(400, "Missing required parameter 'urlName' when calling DeleteUrl");
            
    
            var path = "/view/urls/{urlName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "urlName" + "}", ApiClient.ParameterToString(urlName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteUrl: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteUrl: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get single view permission 
        /// </summary>
        /// <param name="viewName">view name</param> 
        /// <param name="version">view version</param> 
        /// <param name="permissionId">permission id</param> 
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param> 
        /// <returns>ViewPermissionResponse</returns>            
        public ViewPermissionResponse GetPermission (string viewName, string version, string permissionId, string fields)
        {
            
            // verify the required parameter 'viewName' is set
            if (viewName == null) throw new ApiException(400, "Missing required parameter 'viewName' when calling GetPermission");
            
            // verify the required parameter 'version' is set
            if (version == null) throw new ApiException(400, "Missing required parameter 'version' when calling GetPermission");
            
            // verify the required parameter 'permissionId' is set
            if (permissionId == null) throw new ApiException(400, "Missing required parameter 'permissionId' when calling GetPermission");
            
    
            var path = "/views/{viewName}/versions/{version}/permissions/{permissionId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "viewName" + "}", ApiClient.ParameterToString(viewName));
path = path.Replace("{" + "version" + "}", ApiClient.ParameterToString(version));
path = path.Replace("{" + "permissionId" + "}", ApiClient.ParameterToString(permissionId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetPermission: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPermission: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ViewPermissionResponse) ApiClient.Deserialize(response.Content, typeof(ViewPermissionResponse), response.Headers);
        }
    
        /// <summary>
        /// Get all permissions for a view 
        /// </summary>
        /// <param name="viewName">view name</param> 
        /// <param name="version">view version</param> 
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param> 
        /// <param name="sortBy">Sort resources in result by (asc | desc)</param> 
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param> 
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param> 
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param> 
        /// <returns>List&lt;ViewPermissionResponse&gt;</returns>            
        public List<ViewPermissionResponse> GetPermissions (string viewName, string version, string fields, string sortBy, int? pageSize, int? from, int? to)
        {
            
            // verify the required parameter 'viewName' is set
            if (viewName == null) throw new ApiException(400, "Missing required parameter 'viewName' when calling GetPermissions");
            
            // verify the required parameter 'version' is set
            if (version == null) throw new ApiException(400, "Missing required parameter 'version' when calling GetPermissions");
            
    
            var path = "/views/{viewName}/versions/{version}/permissions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "viewName" + "}", ApiClient.ParameterToString(viewName));
path = path.Replace("{" + "version" + "}", ApiClient.ParameterToString(version));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetPermissions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPermissions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ViewPermissionResponse>) ApiClient.Deserialize(response.Content, typeof(List<ViewPermissionResponse>), response.Headers);
        }
    
        /// <summary>
        /// Get single view instance privilege 
        /// </summary>
        /// <param name="viewName">view name</param> 
        /// <param name="version">view version</param> 
        /// <param name="instanceName">instance name</param> 
        /// <param name="privilegeId">privilege id</param> 
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param> 
        /// <returns>ViewPrivilegeResponseWrapper</returns>            
        public ViewPrivilegeResponseWrapper GetPrivilege (string viewName, string version, string instanceName, string privilegeId, string fields)
        {
            
            // verify the required parameter 'viewName' is set
            if (viewName == null) throw new ApiException(400, "Missing required parameter 'viewName' when calling GetPrivilege");
            
            // verify the required parameter 'version' is set
            if (version == null) throw new ApiException(400, "Missing required parameter 'version' when calling GetPrivilege");
            
            // verify the required parameter 'instanceName' is set
            if (instanceName == null) throw new ApiException(400, "Missing required parameter 'instanceName' when calling GetPrivilege");
            
            // verify the required parameter 'privilegeId' is set
            if (privilegeId == null) throw new ApiException(400, "Missing required parameter 'privilegeId' when calling GetPrivilege");
            
    
            var path = "/views/{viewName}/versions/{version}/instances/{instanceName}/privileges/{privilegeId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "viewName" + "}", ApiClient.ParameterToString(viewName));
path = path.Replace("{" + "version" + "}", ApiClient.ParameterToString(version));
path = path.Replace("{" + "instanceName" + "}", ApiClient.ParameterToString(instanceName));
path = path.Replace("{" + "privilegeId" + "}", ApiClient.ParameterToString(privilegeId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetPrivilege: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPrivilege: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ViewPrivilegeResponseWrapper) ApiClient.Deserialize(response.Content, typeof(ViewPrivilegeResponseWrapper), response.Headers);
        }
    
        /// <summary>
        /// Get all view instance privileges 
        /// </summary>
        /// <param name="viewName">view name</param> 
        /// <param name="version">view version</param> 
        /// <param name="instanceName">instance name</param> 
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param> 
        /// <param name="sortBy">Sort resources in result by (asc | desc)</param> 
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param> 
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param> 
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param> 
        /// <returns>List&lt;ViewPrivilegeResponseWrapper&gt;</returns>            
        public List<ViewPrivilegeResponseWrapper> GetPrivileges (string viewName, string version, string instanceName, string fields, string sortBy, int? pageSize, int? from, int? to)
        {
            
            // verify the required parameter 'viewName' is set
            if (viewName == null) throw new ApiException(400, "Missing required parameter 'viewName' when calling GetPrivileges");
            
            // verify the required parameter 'version' is set
            if (version == null) throw new ApiException(400, "Missing required parameter 'version' when calling GetPrivileges");
            
            // verify the required parameter 'instanceName' is set
            if (instanceName == null) throw new ApiException(400, "Missing required parameter 'instanceName' when calling GetPrivileges");
            
    
            var path = "/views/{viewName}/versions/{version}/instances/{instanceName}/privileges";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "viewName" + "}", ApiClient.ParameterToString(viewName));
path = path.Replace("{" + "version" + "}", ApiClient.ParameterToString(version));
path = path.Replace("{" + "instanceName" + "}", ApiClient.ParameterToString(instanceName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetPrivileges: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPrivileges: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ViewPrivilegeResponseWrapper>) ApiClient.Deserialize(response.Content, typeof(List<ViewPrivilegeResponseWrapper>), response.Headers);
        }
    
        /// <summary>
        /// Get single view instance 
        /// </summary>
        /// <param name="viewName">view name</param> 
        /// <param name="version"></param> 
        /// <param name="instanceName">instance name</param> 
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param> 
        /// <returns>ViewInstanceResponse</returns>            
        public ViewInstanceResponse GetService (string viewName, string version, string instanceName, string fields)
        {
            
            // verify the required parameter 'viewName' is set
            if (viewName == null) throw new ApiException(400, "Missing required parameter 'viewName' when calling GetService");
            
            // verify the required parameter 'version' is set
            if (version == null) throw new ApiException(400, "Missing required parameter 'version' when calling GetService");
            
            // verify the required parameter 'instanceName' is set
            if (instanceName == null) throw new ApiException(400, "Missing required parameter 'instanceName' when calling GetService");
            
    
            var path = "/views/{viewName}/versions/{version}/instances/{instanceName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "viewName" + "}", ApiClient.ParameterToString(viewName));
path = path.Replace("{" + "version" + "}", ApiClient.ParameterToString(version));
path = path.Replace("{" + "instanceName" + "}", ApiClient.ParameterToString(instanceName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetService: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetService: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ViewInstanceResponse) ApiClient.Deserialize(response.Content, typeof(ViewInstanceResponse), response.Headers);
        }
    
        /// <summary>
        /// Get all view instances 
        /// </summary>
        /// <param name="viewName"></param> 
        /// <param name="version"></param> 
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param> 
        /// <param name="sortBy">Sort resources in result by (asc | desc)</param> 
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param> 
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param> 
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param> 
        /// <returns>List&lt;ViewInstanceResponse&gt;</returns>            
        public List<ViewInstanceResponse> GetServices (string viewName, string version, string fields, string sortBy, int? pageSize, int? from, int? to)
        {
            
            // verify the required parameter 'viewName' is set
            if (viewName == null) throw new ApiException(400, "Missing required parameter 'viewName' when calling GetServices");
            
            // verify the required parameter 'version' is set
            if (version == null) throw new ApiException(400, "Missing required parameter 'version' when calling GetServices");
            
    
            var path = "/views/{viewName}/versions/{version}/instances";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "viewName" + "}", ApiClient.ParameterToString(viewName));
path = path.Replace("{" + "version" + "}", ApiClient.ParameterToString(version));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetServices: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetServices: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ViewInstanceResponse>) ApiClient.Deserialize(response.Content, typeof(List<ViewInstanceResponse>), response.Headers);
        }
    
        /// <summary>
        /// Get single view version 
        /// </summary>
        /// <param name="viewName">view name</param> 
        /// <param name="version"></param> 
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param> 
        /// <returns>ViewVersionResponse</returns>            
        public ViewVersionResponse GetVersion (string viewName, string version, string fields)
        {
            
            // verify the required parameter 'viewName' is set
            if (viewName == null) throw new ApiException(400, "Missing required parameter 'viewName' when calling GetVersion");
            
            // verify the required parameter 'version' is set
            if (version == null) throw new ApiException(400, "Missing required parameter 'version' when calling GetVersion");
            
    
            var path = "/views/{viewName}/versions/{version}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "viewName" + "}", ApiClient.ParameterToString(viewName));
path = path.Replace("{" + "version" + "}", ApiClient.ParameterToString(version));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetVersion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetVersion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ViewVersionResponse) ApiClient.Deserialize(response.Content, typeof(ViewVersionResponse), response.Headers);
        }
    
        /// <summary>
        /// Get all versions for a view 
        /// </summary>
        /// <param name="viewName">view name</param> 
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param> 
        /// <param name="sortBy">Sort resources in result by (asc | desc)</param> 
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param> 
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param> 
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param> 
        /// <returns>List&lt;ViewVersionResponse&gt;</returns>            
        public List<ViewVersionResponse> GetVersions (string viewName, string fields, string sortBy, int? pageSize, int? from, int? to)
        {
            
            // verify the required parameter 'viewName' is set
            if (viewName == null) throw new ApiException(400, "Missing required parameter 'viewName' when calling GetVersions");
            
    
            var path = "/views/{viewName}/versions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "viewName" + "}", ApiClient.ParameterToString(viewName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetVersions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetVersions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ViewVersionResponse>) ApiClient.Deserialize(response.Content, typeof(List<ViewVersionResponse>), response.Headers);
        }
    
        /// <summary>
        /// Get single view 
        /// </summary>
        /// <param name="viewName">view name</param> 
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param> 
        /// <returns>ViewResponse</returns>            
        public ViewResponse GetView (string viewName, string fields)
        {
            
            // verify the required parameter 'viewName' is set
            if (viewName == null) throw new ApiException(400, "Missing required parameter 'viewName' when calling GetView");
            
    
            var path = "/views/{viewName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "viewName" + "}", ApiClient.ParameterToString(viewName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetView: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetView: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ViewResponse) ApiClient.Deserialize(response.Content, typeof(ViewResponse), response.Headers);
        }
    
        /// <summary>
        /// Get single view URL 
        /// </summary>
        /// <param name="urlName"></param> 
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param> 
        /// <returns>ViewUrlResponseSwagger</returns>            
        public ViewUrlResponseSwagger GetViewUrl (string urlName, string fields)
        {
            
            // verify the required parameter 'urlName' is set
            if (urlName == null) throw new ApiException(400, "Missing required parameter 'urlName' when calling GetViewUrl");
            
    
            var path = "/view/urls/{urlName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "urlName" + "}", ApiClient.ParameterToString(urlName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetViewUrl: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetViewUrl: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ViewUrlResponseSwagger) ApiClient.Deserialize(response.Content, typeof(ViewUrlResponseSwagger), response.Headers);
        }
    
        /// <summary>
        /// Get all view URLs 
        /// </summary>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param> 
        /// <param name="sortBy">Sort resources in result by (asc | desc)</param> 
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param> 
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param> 
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param> 
        /// <returns>List&lt;ViewUrlResponseSwagger&gt;</returns>            
        public List<ViewUrlResponseSwagger> GetViewUrls (string fields, string sortBy, int? pageSize, int? from, int? to)
        {
            
    
            var path = "/view/urls";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetViewUrls: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetViewUrls: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ViewUrlResponseSwagger>) ApiClient.Deserialize(response.Content, typeof(List<ViewUrlResponseSwagger>), response.Headers);
        }
    
        /// <summary>
        /// Get all views Returns details of all views.
        /// </summary>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param> 
        /// <param name="sortBy">Sort resources in result by (asc | desc)</param> 
        /// <param name="pageSize">The number of resources to be returned for the paged response.</param> 
        /// <param name="from">The starting page resource (inclusive).  \&quot;start\&quot; is also accepted.</param> 
        /// <param name="to">The ending page resource (inclusive).  \&quot;end\&quot; is also accepted.</param> 
        /// <returns>List&lt;ViewResponse&gt;</returns>            
        public List<ViewResponse> GetViews (string fields, string sortBy, int? pageSize, int? from, int? to)
        {
            
    
            var path = "/views";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetViews: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetViews: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ViewResponse>) ApiClient.Deserialize(response.Content, typeof(List<ViewResponse>), response.Headers);
        }
    
        /// <summary>
        /// Migrate view instance data Migrates view instance persistence data from origin view instance specified in the path params.
        /// </summary>
        /// <param name="viewName">view name</param> 
        /// <param name="version">view version</param> 
        /// <param name="instanceName">instance name</param> 
        /// <param name="originVersion">origin version</param> 
        /// <param name="originInstanceName">origin instance name</param> 
        /// <returns></returns>            
        public void MigrateData (string viewName, string version, string instanceName, string originVersion, string originInstanceName)
        {
            
            // verify the required parameter 'viewName' is set
            if (viewName == null) throw new ApiException(400, "Missing required parameter 'viewName' when calling MigrateData");
            
            // verify the required parameter 'version' is set
            if (version == null) throw new ApiException(400, "Missing required parameter 'version' when calling MigrateData");
            
            // verify the required parameter 'instanceName' is set
            if (instanceName == null) throw new ApiException(400, "Missing required parameter 'instanceName' when calling MigrateData");
            
            // verify the required parameter 'originVersion' is set
            if (originVersion == null) throw new ApiException(400, "Missing required parameter 'originVersion' when calling MigrateData");
            
            // verify the required parameter 'originInstanceName' is set
            if (originInstanceName == null) throw new ApiException(400, "Missing required parameter 'originInstanceName' when calling MigrateData");
            
    
            var path = "/views/{viewName}/versions/{version}/instances/{instanceName}/migrate/{originVersion}/{originInstanceName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "viewName" + "}", ApiClient.ParameterToString(viewName));
path = path.Replace("{" + "version" + "}", ApiClient.ParameterToString(version));
path = path.Replace("{" + "instanceName" + "}", ApiClient.ParameterToString(instanceName));
path = path.Replace("{" + "originVersion" + "}", ApiClient.ParameterToString(originVersion));
path = path.Replace("{" + "originInstanceName" + "}", ApiClient.ParameterToString(originInstanceName));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MigrateData: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MigrateData: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update view instance privilege 
        /// </summary>
        /// <param name="viewName">view name</param> 
        /// <param name="version">view version</param> 
        /// <param name="instanceName">instance name</param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void UpdatePrivileges (string viewName, string version, string instanceName, ViewPrivilegeService body)
        {
            
            // verify the required parameter 'viewName' is set
            if (viewName == null) throw new ApiException(400, "Missing required parameter 'viewName' when calling UpdatePrivileges");
            
            // verify the required parameter 'version' is set
            if (version == null) throw new ApiException(400, "Missing required parameter 'version' when calling UpdatePrivileges");
            
            // verify the required parameter 'instanceName' is set
            if (instanceName == null) throw new ApiException(400, "Missing required parameter 'instanceName' when calling UpdatePrivileges");
            
    
            var path = "/views/{viewName}/versions/{version}/instances/{instanceName}/privileges";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "viewName" + "}", ApiClient.ParameterToString(viewName));
path = path.Replace("{" + "version" + "}", ApiClient.ParameterToString(version));
path = path.Replace("{" + "instanceName" + "}", ApiClient.ParameterToString(instanceName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdatePrivileges: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdatePrivileges: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update view instance detail 
        /// </summary>
        /// <param name="viewName">view name</param> 
        /// <param name="version"></param> 
        /// <param name="instanceName">instance name</param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void UpdateService (string viewName, string version, string instanceName, ViewInstanceResponse body)
        {
            
            // verify the required parameter 'viewName' is set
            if (viewName == null) throw new ApiException(400, "Missing required parameter 'viewName' when calling UpdateService");
            
            // verify the required parameter 'version' is set
            if (version == null) throw new ApiException(400, "Missing required parameter 'version' when calling UpdateService");
            
            // verify the required parameter 'instanceName' is set
            if (instanceName == null) throw new ApiException(400, "Missing required parameter 'instanceName' when calling UpdateService");
            
    
            var path = "/views/{viewName}/versions/{version}/instances/{instanceName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "viewName" + "}", ApiClient.ParameterToString(viewName));
path = path.Replace("{" + "version" + "}", ApiClient.ParameterToString(version));
path = path.Replace("{" + "instanceName" + "}", ApiClient.ParameterToString(instanceName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateService: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateService: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update multiple view instance detail 
        /// </summary>
        /// <param name="viewName"></param> 
        /// <param name="version"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void UpdateServices (string viewName, string version, ViewInstanceResponse body)
        {
            
            // verify the required parameter 'viewName' is set
            if (viewName == null) throw new ApiException(400, "Missing required parameter 'viewName' when calling UpdateServices");
            
            // verify the required parameter 'version' is set
            if (version == null) throw new ApiException(400, "Missing required parameter 'version' when calling UpdateServices");
            
    
            var path = "/views/{viewName}/versions/{version}/instances";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "viewName" + "}", ApiClient.ParameterToString(viewName));
path = path.Replace("{" + "version" + "}", ApiClient.ParameterToString(version));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateServices: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateServices: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update view URL 
        /// </summary>
        /// <param name="urlName"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void UpdateUrl (string urlName, ViewUrlResponseSwagger body)
        {
            
            // verify the required parameter 'urlName' is set
            if (urlName == null) throw new ApiException(400, "Missing required parameter 'urlName' when calling UpdateUrl");
            
    
            var path = "/view/urls/{urlName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "urlName" + "}", ApiClient.ParameterToString(urlName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateUrl: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateUrl: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
