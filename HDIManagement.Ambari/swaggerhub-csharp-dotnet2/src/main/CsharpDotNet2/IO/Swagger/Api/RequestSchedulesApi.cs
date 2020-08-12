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
    public interface IRequestSchedulesApi
    {
        /// <summary>
        /// Create new request schedule 
        /// </summary>
        /// <param name="clusterName"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void CreateRequestSchedule (string clusterName, RequestScheduleRequestSwagger body);
        /// <summary>
        /// Delete a request schedule Changes status from COMPLETED to DISABLED
        /// </summary>
        /// <param name="requestScheduleId"></param>
        /// <param name="clusterName"></param>
        /// <returns></returns>
        void DeleteRequestSchedule (string requestScheduleId, string clusterName);
        /// <summary>
        /// Get request schedule 
        /// </summary>
        /// <param name="requestScheduleId"></param>
        /// <param name="clusterName"></param>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param>
        /// <returns>RequestScheduleResponseSwagger</returns>
        RequestScheduleResponseSwagger GetRequestSchedule (string requestScheduleId, string clusterName, string fields);
        /// <summary>
        /// Get all request schedules 
        /// </summary>
        /// <param name="clusterName"></param>
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param>
        /// <returns>List&lt;RequestScheduleResponseSwagger&gt;</returns>
        List<RequestScheduleResponseSwagger> GetRequestSchedules (string clusterName, string fields);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RequestSchedulesApi : IRequestSchedulesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestSchedulesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public RequestSchedulesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestSchedulesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RequestSchedulesApi(String basePath)
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
        /// Create new request schedule 
        /// </summary>
        /// <param name="clusterName"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void CreateRequestSchedule (string clusterName, RequestScheduleRequestSwagger body)
        {
            
            // verify the required parameter 'clusterName' is set
            if (clusterName == null) throw new ApiException(400, "Missing required parameter 'clusterName' when calling CreateRequestSchedule");
            
    
            var path = "/clusters/{clusterName}/request_schedules";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateRequestSchedule: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateRequestSchedule: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a request schedule Changes status from COMPLETED to DISABLED
        /// </summary>
        /// <param name="requestScheduleId"></param> 
        /// <param name="clusterName"></param> 
        /// <returns></returns>            
        public void DeleteRequestSchedule (string requestScheduleId, string clusterName)
        {
            
            // verify the required parameter 'requestScheduleId' is set
            if (requestScheduleId == null) throw new ApiException(400, "Missing required parameter 'requestScheduleId' when calling DeleteRequestSchedule");
            
            // verify the required parameter 'clusterName' is set
            if (clusterName == null) throw new ApiException(400, "Missing required parameter 'clusterName' when calling DeleteRequestSchedule");
            
    
            var path = "/clusters/{clusterName}/request_schedules/{requestScheduleId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "requestScheduleId" + "}", ApiClient.ParameterToString(requestScheduleId));
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteRequestSchedule: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteRequestSchedule: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get request schedule 
        /// </summary>
        /// <param name="requestScheduleId"></param> 
        /// <param name="clusterName"></param> 
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param> 
        /// <returns>RequestScheduleResponseSwagger</returns>            
        public RequestScheduleResponseSwagger GetRequestSchedule (string requestScheduleId, string clusterName, string fields)
        {
            
            // verify the required parameter 'requestScheduleId' is set
            if (requestScheduleId == null) throw new ApiException(400, "Missing required parameter 'requestScheduleId' when calling GetRequestSchedule");
            
            // verify the required parameter 'clusterName' is set
            if (clusterName == null) throw new ApiException(400, "Missing required parameter 'clusterName' when calling GetRequestSchedule");
            
    
            var path = "/clusters/{clusterName}/request_schedules/{requestScheduleId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "requestScheduleId" + "}", ApiClient.ParameterToString(requestScheduleId));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetRequestSchedule: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRequestSchedule: " + response.ErrorMessage, response.ErrorMessage);
    
            return (RequestScheduleResponseSwagger) ApiClient.Deserialize(response.Content, typeof(RequestScheduleResponseSwagger), response.Headers);
        }
    
        /// <summary>
        /// Get all request schedules 
        /// </summary>
        /// <param name="clusterName"></param> 
        /// <param name="fields">Filter fields in the response (identifier fields are mandatory)</param> 
        /// <returns>List&lt;RequestScheduleResponseSwagger&gt;</returns>            
        public List<RequestScheduleResponseSwagger> GetRequestSchedules (string clusterName, string fields)
        {
            
            // verify the required parameter 'clusterName' is set
            if (clusterName == null) throw new ApiException(400, "Missing required parameter 'clusterName' when calling GetRequestSchedules");
            
    
            var path = "/clusters/{clusterName}/request_schedules";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetRequestSchedules: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRequestSchedules: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<RequestScheduleResponseSwagger>) ApiClient.Deserialize(response.Content, typeof(List<RequestScheduleResponseSwagger>), response.Headers);
        }
    
    }
}
