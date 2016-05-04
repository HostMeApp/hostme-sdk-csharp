using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using HostMe.Sdk.Client;
using HostMe.Sdk.Models;


namespace HostMe.Sdk.Apis.Mobile
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMobileReservationsApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value"></param>
        /// <returns>Reservation</returns>
        Reservation AddNewReservation (CreateCustomerReservation value);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value"></param>
        /// <returns>ApiResponse of Reservation</returns>
        ApiResponse<Reservation> AddNewReservationWithHttpInfo (CreateCustomerReservation value);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reservationId"></param>
        /// <param name="cancelReservationContract"></param>
        /// <returns></returns>
        void CloseAsCanceled (string reservationId, CancelReservation cancelReservationContract);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reservationId"></param>
        /// <param name="cancelReservationContract"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CloseAsCanceledWithHttpInfo (string reservationId, CancelReservation cancelReservationContract);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reservationId"></param>
        /// <returns>Reservation</returns>
        Reservation GetReservationById (string reservationId);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reservationId"></param>
        /// <returns>ApiResponse of Reservation</returns>
        ApiResponse<Reservation> GetReservationByIdWithHttpInfo (string reservationId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryOptions"> (optional)</param>
        /// <returns>List&lt;Reservation&gt;</returns>
        List<Reservation> GetUserReservations (string queryOptions = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryOptions"> (optional)</param>
        /// <returns>ApiResponse of List&lt;Reservation&gt;</returns>
        ApiResponse<List<Reservation>> GetUserReservationsWithHttpInfo (string queryOptions = null);
        
        /// <summary>
        /// Mark all messages as read.
        /// </summary>
        /// <remarks>
        /// Mark all reservation messages as read.
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reservationId">Reservation identifier</param>
        /// <returns></returns>
        void ReadAllMessage (string reservationId);
  
        /// <summary>
        /// Mark all messages as read.
        /// </summary>
        /// <remarks>
        /// Mark all reservation messages as read.
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reservationId">Reservation identifier</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ReadAllMessageWithHttpInfo (string reservationId);
        
        /// <summary>
        /// Sends a message related to specified reservation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reservationId">Reservation identifier</param>
        /// <param name="createMessageContract">The message with body</param>
        /// <returns></returns>
        void SendMessageToReservation (string reservationId, CreateMessage createMessageContract);
  
        /// <summary>
        /// Sends a message related to specified reservation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reservationId">Reservation identifier</param>
        /// <param name="createMessageContract">The message with body</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> SendMessageToReservationWithHttpInfo (string reservationId, CreateMessage createMessageContract);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reservationId"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        void UpdateReservation (string reservationId, UpdateReservation value);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reservationId"></param>
        /// <param name="value"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateReservationWithHttpInfo (string reservationId, UpdateReservation value);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value"></param>
        /// <returns>Task of Reservation</returns>
        System.Threading.Tasks.Task<Reservation> AddNewReservationAsync (CreateCustomerReservation value);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value"></param>
        /// <returns>Task of ApiResponse (Reservation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Reservation>> AddNewReservationAsyncWithHttpInfo (CreateCustomerReservation value);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reservationId"></param>
        /// <param name="cancelReservationContract"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task CloseAsCanceledAsync (string reservationId, CancelReservation cancelReservationContract);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reservationId"></param>
        /// <param name="cancelReservationContract"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CloseAsCanceledAsyncWithHttpInfo (string reservationId, CancelReservation cancelReservationContract);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reservationId"></param>
        /// <returns>Task of Reservation</returns>
        System.Threading.Tasks.Task<Reservation> GetReservationByIdAsync (string reservationId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reservationId"></param>
        /// <returns>Task of ApiResponse (Reservation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Reservation>> GetReservationByIdAsyncWithHttpInfo (string reservationId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryOptions"> (optional)</param>
        /// <returns>Task of List&lt;Reservation&gt;</returns>
        System.Threading.Tasks.Task<List<Reservation>> GetUserReservationsAsync (string queryOptions = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryOptions"> (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Reservation&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Reservation>>> GetUserReservationsAsyncWithHttpInfo (string queryOptions = null);
        
        /// <summary>
        /// Mark all messages as read.
        /// </summary>
        /// <remarks>
        /// Mark all reservation messages as read.
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reservationId">Reservation identifier</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ReadAllMessageAsync (string reservationId);

        /// <summary>
        /// Mark all messages as read.
        /// </summary>
        /// <remarks>
        /// Mark all reservation messages as read.
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reservationId">Reservation identifier</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ReadAllMessageAsyncWithHttpInfo (string reservationId);
        
        /// <summary>
        /// Sends a message related to specified reservation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reservationId">Reservation identifier</param>
        /// <param name="createMessageContract">The message with body</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task SendMessageToReservationAsync (string reservationId, CreateMessage createMessageContract);

        /// <summary>
        /// Sends a message related to specified reservation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reservationId">Reservation identifier</param>
        /// <param name="createMessageContract">The message with body</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> SendMessageToReservationAsyncWithHttpInfo (string reservationId, CreateMessage createMessageContract);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reservationId"></param>
        /// <param name="value"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateReservationAsync (string reservationId, UpdateReservation value);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reservationId"></param>
        /// <param name="value"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateReservationAsyncWithHttpInfo (string reservationId, UpdateReservation value);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MobileReservationsApi : IMobileReservationsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MobileReservationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MobileReservationsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MobileReservationsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MobileReservationsApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default; 
            else
                this.Configuration = configuration;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }
    
        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }
   
        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value"></param> 
        /// <returns>Reservation</returns>
        public Reservation AddNewReservation (CreateCustomerReservation value)
        {
             ApiResponse<Reservation> localVarResponse = AddNewReservationWithHttpInfo(value);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value"></param> 
        /// <returns>ApiResponse of Reservation</returns>
        public ApiResponse< Reservation > AddNewReservationWithHttpInfo (CreateCustomerReservation value)
        {
            
            // verify the required parameter 'value' is set
            if (value == null)
                throw new ApiException(400, "Missing required parameter 'value' when calling MobileReservationsApi->AddNewReservation");
            
    
            var localVarPath = "/api/rsv/mb/reservations";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", "text/json", "application/xml", "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (value.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(value); // http body (model) parameter
            }
            else
            {
                localVarPostBody = value; // byte array
            }

            // authentication (oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AddNewReservation: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddNewReservation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Reservation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Reservation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Reservation)));
            
        }

        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value"></param>
        /// <returns>Task of Reservation</returns>
        public async System.Threading.Tasks.Task<Reservation> AddNewReservationAsync (CreateCustomerReservation value)
        {
             ApiResponse<Reservation> localVarResponse = await AddNewReservationAsyncWithHttpInfo(value);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value"></param>
        /// <returns>Task of ApiResponse (Reservation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Reservation>> AddNewReservationAsyncWithHttpInfo (CreateCustomerReservation value)
        {
            // verify the required parameter 'value' is set
            if (value == null) throw new ApiException(400, "Missing required parameter 'value' when calling AddNewReservation");
            
    
            var localVarPath = "/api/rsv/mb/reservations";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", "text/json", "application/xml", "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (value.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(value); // http body (model) parameter
            }
            else
            {
                localVarPostBody = value; // byte array
            }

            
            // authentication (oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AddNewReservation: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddNewReservation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Reservation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Reservation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Reservation)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reservationId"></param> 
        /// <param name="cancelReservationContract"></param> 
        /// <returns></returns>
        public void CloseAsCanceled (string reservationId, CancelReservation cancelReservationContract)
        {
             CloseAsCanceledWithHttpInfo(reservationId, cancelReservationContract);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reservationId"></param> 
        /// <param name="cancelReservationContract"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> CloseAsCanceledWithHttpInfo (string reservationId, CancelReservation cancelReservationContract)
        {
            
            // verify the required parameter 'reservationId' is set
            if (reservationId == null)
                throw new ApiException(400, "Missing required parameter 'reservationId' when calling MobileReservationsApi->CloseAsCanceled");
            
            // verify the required parameter 'cancelReservationContract' is set
            if (cancelReservationContract == null)
                throw new ApiException(400, "Missing required parameter 'cancelReservationContract' when calling MobileReservationsApi->CloseAsCanceled");
            
    
            var localVarPath = "/api/rsv/mb/reservations/{reservationId}/cancel";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", "text/json", "application/xml", "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (reservationId != null) localVarPathParams.Add("reservationId", Configuration.ApiClient.ParameterToString(reservationId)); // path parameter
            
            
            
            
            if (cancelReservationContract.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(cancelReservationContract); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cancelReservationContract; // byte array
            }

            // authentication (oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CloseAsCanceled: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CloseAsCanceled: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reservationId"></param>
        /// <param name="cancelReservationContract"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task CloseAsCanceledAsync (string reservationId, CancelReservation cancelReservationContract)
        {
             await CloseAsCanceledAsyncWithHttpInfo(reservationId, cancelReservationContract);

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reservationId"></param>
        /// <param name="cancelReservationContract"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> CloseAsCanceledAsyncWithHttpInfo (string reservationId, CancelReservation cancelReservationContract)
        {
            // verify the required parameter 'reservationId' is set
            if (reservationId == null) throw new ApiException(400, "Missing required parameter 'reservationId' when calling CloseAsCanceled");
            // verify the required parameter 'cancelReservationContract' is set
            if (cancelReservationContract == null) throw new ApiException(400, "Missing required parameter 'cancelReservationContract' when calling CloseAsCanceled");
            
    
            var localVarPath = "/api/rsv/mb/reservations/{reservationId}/cancel";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", "text/json", "application/xml", "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (reservationId != null) localVarPathParams.Add("reservationId", Configuration.ApiClient.ParameterToString(reservationId)); // path parameter
            
            
            
            
            if (cancelReservationContract.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(cancelReservationContract); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cancelReservationContract; // byte array
            }

            
            // authentication (oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CloseAsCanceled: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CloseAsCanceled: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reservationId"></param> 
        /// <returns>Reservation</returns>
        public Reservation GetReservationById (string reservationId)
        {
             ApiResponse<Reservation> localVarResponse = GetReservationByIdWithHttpInfo(reservationId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reservationId"></param> 
        /// <returns>ApiResponse of Reservation</returns>
        public ApiResponse< Reservation > GetReservationByIdWithHttpInfo (string reservationId)
        {
            
            // verify the required parameter 'reservationId' is set
            if (reservationId == null)
                throw new ApiException(400, "Missing required parameter 'reservationId' when calling MobileReservationsApi->GetReservationById");
            
    
            var localVarPath = "/api/rsv/mb/reservations/{reservationId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", "text/json", "application/xml", "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (reservationId != null) localVarPathParams.Add("reservationId", Configuration.ApiClient.ParameterToString(reservationId)); // path parameter
            
            
            
            
            

            // authentication (oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetReservationById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetReservationById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Reservation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Reservation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Reservation)));
            
        }

        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reservationId"></param>
        /// <returns>Task of Reservation</returns>
        public async System.Threading.Tasks.Task<Reservation> GetReservationByIdAsync (string reservationId)
        {
             ApiResponse<Reservation> localVarResponse = await GetReservationByIdAsyncWithHttpInfo(reservationId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reservationId"></param>
        /// <returns>Task of ApiResponse (Reservation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Reservation>> GetReservationByIdAsyncWithHttpInfo (string reservationId)
        {
            // verify the required parameter 'reservationId' is set
            if (reservationId == null) throw new ApiException(400, "Missing required parameter 'reservationId' when calling GetReservationById");
            
    
            var localVarPath = "/api/rsv/mb/reservations/{reservationId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", "text/json", "application/xml", "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (reservationId != null) localVarPathParams.Add("reservationId", Configuration.ApiClient.ParameterToString(reservationId)); // path parameter
            
            
            
            
            

            
            // authentication (oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetReservationById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetReservationById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Reservation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Reservation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Reservation)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryOptions"> (optional)</param> 
        /// <returns>List&lt;Reservation&gt;</returns>
        public List<Reservation> GetUserReservations (string queryOptions = null)
        {
             ApiResponse<List<Reservation>> localVarResponse = GetUserReservationsWithHttpInfo(queryOptions);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryOptions"> (optional)</param> 
        /// <returns>ApiResponse of List&lt;Reservation&gt;</returns>
        public ApiResponse< List<Reservation> > GetUserReservationsWithHttpInfo (string queryOptions = null)
        {
            
    
            var localVarPath = "/api/rsv/mb/reservations";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", "text/json", "application/xml", "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (queryOptions != null) localVarQueryParams.Add("queryOptions", Configuration.ApiClient.ParameterToString(queryOptions)); // query parameter
            
            
            
            

            // authentication (oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetUserReservations: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserReservations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<Reservation>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Reservation>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Reservation>)));
            
        }

        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryOptions"> (optional)</param>
        /// <returns>Task of List&lt;Reservation&gt;</returns>
        public async System.Threading.Tasks.Task<List<Reservation>> GetUserReservationsAsync (string queryOptions = null)
        {
             ApiResponse<List<Reservation>> localVarResponse = await GetUserReservationsAsyncWithHttpInfo(queryOptions);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryOptions"> (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Reservation&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Reservation>>> GetUserReservationsAsyncWithHttpInfo (string queryOptions = null)
        {
            
    
            var localVarPath = "/api/rsv/mb/reservations";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", "text/json", "application/xml", "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (queryOptions != null) localVarQueryParams.Add("queryOptions", Configuration.ApiClient.ParameterToString(queryOptions)); // query parameter
            
            
            
            

            
            // authentication (oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetUserReservations: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserReservations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Reservation>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Reservation>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Reservation>)));
            
        }
        
        /// <summary>
        /// Mark all messages as read. Mark all reservation messages as read.
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reservationId">Reservation identifier</param> 
        /// <returns></returns>
        public void ReadAllMessage (string reservationId)
        {
             ReadAllMessageWithHttpInfo(reservationId);
        }

        /// <summary>
        /// Mark all messages as read. Mark all reservation messages as read.
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reservationId">Reservation identifier</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ReadAllMessageWithHttpInfo (string reservationId)
        {
            
            // verify the required parameter 'reservationId' is set
            if (reservationId == null)
                throw new ApiException(400, "Missing required parameter 'reservationId' when calling MobileReservationsApi->ReadAllMessage");
            
    
            var localVarPath = "/api/rsv/mb/reservations/{reservationId}/messages/readall";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", "text/json", "application/xml", "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (reservationId != null) localVarPathParams.Add("reservationId", Configuration.ApiClient.ParameterToString(reservationId)); // path parameter
            
            
            
            
            

            // authentication (oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ReadAllMessage: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ReadAllMessage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Mark all messages as read. Mark all reservation messages as read.
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reservationId">Reservation identifier</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ReadAllMessageAsync (string reservationId)
        {
             await ReadAllMessageAsyncWithHttpInfo(reservationId);

        }

        /// <summary>
        /// Mark all messages as read. Mark all reservation messages as read.
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reservationId">Reservation identifier</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ReadAllMessageAsyncWithHttpInfo (string reservationId)
        {
            // verify the required parameter 'reservationId' is set
            if (reservationId == null) throw new ApiException(400, "Missing required parameter 'reservationId' when calling ReadAllMessage");
            
    
            var localVarPath = "/api/rsv/mb/reservations/{reservationId}/messages/readall";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", "text/json", "application/xml", "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (reservationId != null) localVarPathParams.Add("reservationId", Configuration.ApiClient.ParameterToString(reservationId)); // path parameter
            
            
            
            
            

            
            // authentication (oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ReadAllMessage: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ReadAllMessage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Sends a message related to specified reservation 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reservationId">Reservation identifier</param> 
        /// <param name="createMessageContract">The message with body</param> 
        /// <returns></returns>
        public void SendMessageToReservation (string reservationId, CreateMessage createMessageContract)
        {
             SendMessageToReservationWithHttpInfo(reservationId, createMessageContract);
        }

        /// <summary>
        /// Sends a message related to specified reservation 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reservationId">Reservation identifier</param> 
        /// <param name="createMessageContract">The message with body</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> SendMessageToReservationWithHttpInfo (string reservationId, CreateMessage createMessageContract)
        {
            
            // verify the required parameter 'reservationId' is set
            if (reservationId == null)
                throw new ApiException(400, "Missing required parameter 'reservationId' when calling MobileReservationsApi->SendMessageToReservation");
            
            // verify the required parameter 'createMessageContract' is set
            if (createMessageContract == null)
                throw new ApiException(400, "Missing required parameter 'createMessageContract' when calling MobileReservationsApi->SendMessageToReservation");
            
    
            var localVarPath = "/api/rsv/mb/reservations/{reservationId}/messages";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", "text/json", "application/xml", "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (reservationId != null) localVarPathParams.Add("reservationId", Configuration.ApiClient.ParameterToString(reservationId)); // path parameter
            
            
            
            
            if (createMessageContract.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(createMessageContract); // http body (model) parameter
            }
            else
            {
                localVarPostBody = createMessageContract; // byte array
            }

            // authentication (oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SendMessageToReservation: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SendMessageToReservation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Sends a message related to specified reservation 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reservationId">Reservation identifier</param>
        /// <param name="createMessageContract">The message with body</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task SendMessageToReservationAsync (string reservationId, CreateMessage createMessageContract)
        {
             await SendMessageToReservationAsyncWithHttpInfo(reservationId, createMessageContract);

        }

        /// <summary>
        /// Sends a message related to specified reservation 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reservationId">Reservation identifier</param>
        /// <param name="createMessageContract">The message with body</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> SendMessageToReservationAsyncWithHttpInfo (string reservationId, CreateMessage createMessageContract)
        {
            // verify the required parameter 'reservationId' is set
            if (reservationId == null) throw new ApiException(400, "Missing required parameter 'reservationId' when calling SendMessageToReservation");
            // verify the required parameter 'createMessageContract' is set
            if (createMessageContract == null) throw new ApiException(400, "Missing required parameter 'createMessageContract' when calling SendMessageToReservation");
            
    
            var localVarPath = "/api/rsv/mb/reservations/{reservationId}/messages";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", "text/json", "application/xml", "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (reservationId != null) localVarPathParams.Add("reservationId", Configuration.ApiClient.ParameterToString(reservationId)); // path parameter
            
            
            
            
            if (createMessageContract.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(createMessageContract); // http body (model) parameter
            }
            else
            {
                localVarPostBody = createMessageContract; // byte array
            }

            
            // authentication (oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SendMessageToReservation: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SendMessageToReservation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reservationId"></param> 
        /// <param name="value"></param> 
        /// <returns></returns>
        public void UpdateReservation (string reservationId, UpdateReservation value)
        {
             UpdateReservationWithHttpInfo(reservationId, value);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reservationId"></param> 
        /// <param name="value"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateReservationWithHttpInfo (string reservationId, UpdateReservation value)
        {
            
            // verify the required parameter 'reservationId' is set
            if (reservationId == null)
                throw new ApiException(400, "Missing required parameter 'reservationId' when calling MobileReservationsApi->UpdateReservation");
            
            // verify the required parameter 'value' is set
            if (value == null)
                throw new ApiException(400, "Missing required parameter 'value' when calling MobileReservationsApi->UpdateReservation");
            
    
            var localVarPath = "/api/rsv/mb/reservations/{reservationId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", "text/json", "application/xml", "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (reservationId != null) localVarPathParams.Add("reservationId", Configuration.ApiClient.ParameterToString(reservationId)); // path parameter
            
            
            
            
            if (value.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(value); // http body (model) parameter
            }
            else
            {
                localVarPostBody = value; // byte array
            }

            // authentication (oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UpdateReservation: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateReservation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reservationId"></param>
        /// <param name="value"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateReservationAsync (string reservationId, UpdateReservation value)
        {
             await UpdateReservationAsyncWithHttpInfo(reservationId, value);

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reservationId"></param>
        /// <param name="value"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateReservationAsyncWithHttpInfo (string reservationId, UpdateReservation value)
        {
            // verify the required parameter 'reservationId' is set
            if (reservationId == null) throw new ApiException(400, "Missing required parameter 'reservationId' when calling UpdateReservation");
            // verify the required parameter 'value' is set
            if (value == null) throw new ApiException(400, "Missing required parameter 'value' when calling UpdateReservation");
            
    
            var localVarPath = "/api/rsv/mb/reservations/{reservationId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", "text/json", "application/xml", "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (reservationId != null) localVarPathParams.Add("reservationId", Configuration.ApiClient.ParameterToString(reservationId)); // path parameter
            
            
            
            
            if (value.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(value); // http body (model) parameter
            }
            else
            {
                localVarPostBody = value; // byte array
            }

            
            // authentication (oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UpdateReservation: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateReservation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
