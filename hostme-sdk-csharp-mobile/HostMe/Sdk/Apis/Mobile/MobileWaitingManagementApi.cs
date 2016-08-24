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
    public interface IMobileWaitingManagementApi
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="waitingItemId"></param>
        /// <returns>Transaction</returns>
        Transaction CheckInWithWaiting (int? waitingItemId);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="waitingItemId"></param>
        /// <returns>ApiResponse of Transaction</returns>
        ApiResponse<Transaction> CheckInWithWaitingWithHttpInfo (int? waitingItemId);
        /// <summary>
        /// Closes waiting position.
        /// </summary>
        /// <remarks>
        /// Closes current waiting position. When person gets a table, hostess should close current position.
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="waitingItemId">Identifier of the waiting item</param>
        /// <returns></returns>
        void Close (int? waitingItemId);
  
        /// <summary>
        /// Closes waiting position.
        /// </summary>
        /// <remarks>
        /// Closes current waiting position. When person gets a table, hostess should close current position.
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="waitingItemId">Identifier of the waiting item</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CloseWithHttpInfo (int? waitingItemId);
        /// <summary>
        /// Confirm waiting record from HostMe mobile application
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="confirmationCode">Confirmation code that has been generated during initial registration by hostess</param>
        /// <param name="conf">Conformation model</param>
        /// <returns></returns>
        void ConfirmWithApp (int? confirmationCode, PhoneConfirmation conf);
  
        /// <summary>
        /// Confirm waiting record from HostMe mobile application
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="confirmationCode">Confirmation code that has been generated during initial registration by hostess</param>
        /// <param name="conf">Conformation model</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ConfirmWithAppWithHttpInfo (int? confirmationCode, PhoneConfirmation conf);
        /// <summary>
        /// Put customer in line.
        /// </summary>
        /// <remarks>
        /// This method puts customer in a line on a fly. This is remote registration in a line. Waiting item will be automatically put on hold.
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value"></param>
        /// <returns>WaitingItem</returns>
        WaitingItem GetInLine (PutInLine value);
  
        /// <summary>
        /// Put customer in line.
        /// </summary>
        /// <remarks>
        /// This method puts customer in a line on a fly. This is remote registration in a line. Waiting item will be automatically put on hold.
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value"></param>
        /// <returns>ApiResponse of WaitingItem</returns>
        ApiResponse<WaitingItem> GetInLineWithHttpInfo (PutInLine value);
        /// <summary>
        /// Returns current user waiting item
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>WaitingItem</returns>
        WaitingItem GetUserCurrentWaiting ();
  
        /// <summary>
        /// Returns current user waiting item
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of WaitingItem</returns>
        ApiResponse<WaitingItem> GetUserCurrentWaitingWithHttpInfo ();
        /// <summary>
        /// Cancels waiting position.
        /// </summary>
        /// <remarks>
        /// Cancels specified waiting position. Client may decide to go to another restaurant and cancel current waiting item.
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <returns></returns>
        void LeaveTheLine (int? waitingItemId);
  
        /// <summary>
        /// Cancels waiting position.
        /// </summary>
        /// <remarks>
        /// Cancels specified waiting position. Client may decide to go to another restaurant and cancel current waiting item.
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> LeaveTheLineWithHttpInfo (int? waitingItemId);
        /// <summary>
        /// Mark all message as read.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <returns></returns>
        void MarkAllMessagesAsRead (int? waitingItemId);
  
        /// <summary>
        /// Mark all message as read.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> MarkAllMessagesAsReadWithHttpInfo (int? waitingItemId);
        /// <summary>
        /// Put waiting item on hold manually
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <returns></returns>
        void PutOnHold (int? restaurantId, int? waitingItemId);
  
        /// <summary>
        /// Put waiting item on hold manually
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PutOnHoldWithHttpInfo (int? restaurantId, int? waitingItemId);
        /// <summary>
        /// Sends a message related to specified waiting item.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <param name="createMessage">The body of the message</param>
        /// <returns></returns>
        void SendMessageToWaiting (int? waitingItemId, CreateMessage createMessage);
  
        /// <summary>
        /// Sends a message related to specified waiting item.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <param name="createMessage">The body of the message</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> SendMessageToWaitingWithHttpInfo (int? waitingItemId, CreateMessage createMessage);
        /// <summary>
        /// Set waiting item off hold
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <returns></returns>
        void TakeOffHold (int? restaurantId, int? waitingItemId);
  
        /// <summary>
        /// Set waiting item off hold
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> TakeOffHoldWithHttpInfo (int? restaurantId, int? waitingItemId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="waitingItemId"></param>
        /// <returns>Task of Transaction</returns>
        System.Threading.Tasks.Task<Transaction> CheckInWithWaitingAsync (int? waitingItemId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="waitingItemId"></param>
        /// <returns>Task of ApiResponse (Transaction)</returns>
        System.Threading.Tasks.Task<ApiResponse<Transaction>> CheckInWithWaitingAsyncWithHttpInfo (int? waitingItemId);
        /// <summary>
        /// Closes waiting position.
        /// </summary>
        /// <remarks>
        /// Closes current waiting position. When person gets a table, hostess should close current position.
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="waitingItemId">Identifier of the waiting item</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task CloseAsync (int? waitingItemId);

        /// <summary>
        /// Closes waiting position.
        /// </summary>
        /// <remarks>
        /// Closes current waiting position. When person gets a table, hostess should close current position.
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="waitingItemId">Identifier of the waiting item</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CloseAsyncWithHttpInfo (int? waitingItemId);
        /// <summary>
        /// Confirm waiting record from HostMe mobile application
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="confirmationCode">Confirmation code that has been generated during initial registration by hostess</param>
        /// <param name="conf">Conformation model</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ConfirmWithAppAsync (int? confirmationCode, PhoneConfirmation conf);

        /// <summary>
        /// Confirm waiting record from HostMe mobile application
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="confirmationCode">Confirmation code that has been generated during initial registration by hostess</param>
        /// <param name="conf">Conformation model</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ConfirmWithAppAsyncWithHttpInfo (int? confirmationCode, PhoneConfirmation conf);
        /// <summary>
        /// Put customer in line.
        /// </summary>
        /// <remarks>
        /// This method puts customer in a line on a fly. This is remote registration in a line. Waiting item will be automatically put on hold.
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value"></param>
        /// <returns>Task of WaitingItem</returns>
        System.Threading.Tasks.Task<WaitingItem> GetInLineAsync (PutInLine value);

        /// <summary>
        /// Put customer in line.
        /// </summary>
        /// <remarks>
        /// This method puts customer in a line on a fly. This is remote registration in a line. Waiting item will be automatically put on hold.
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value"></param>
        /// <returns>Task of ApiResponse (WaitingItem)</returns>
        System.Threading.Tasks.Task<ApiResponse<WaitingItem>> GetInLineAsyncWithHttpInfo (PutInLine value);
        /// <summary>
        /// Returns current user waiting item
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of WaitingItem</returns>
        System.Threading.Tasks.Task<WaitingItem> GetUserCurrentWaitingAsync ();

        /// <summary>
        /// Returns current user waiting item
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (WaitingItem)</returns>
        System.Threading.Tasks.Task<ApiResponse<WaitingItem>> GetUserCurrentWaitingAsyncWithHttpInfo ();
        /// <summary>
        /// Cancels waiting position.
        /// </summary>
        /// <remarks>
        /// Cancels specified waiting position. Client may decide to go to another restaurant and cancel current waiting item.
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task LeaveTheLineAsync (int? waitingItemId);

        /// <summary>
        /// Cancels waiting position.
        /// </summary>
        /// <remarks>
        /// Cancels specified waiting position. Client may decide to go to another restaurant and cancel current waiting item.
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> LeaveTheLineAsyncWithHttpInfo (int? waitingItemId);
        /// <summary>
        /// Mark all message as read.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task MarkAllMessagesAsReadAsync (int? waitingItemId);

        /// <summary>
        /// Mark all message as read.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> MarkAllMessagesAsReadAsyncWithHttpInfo (int? waitingItemId);
        /// <summary>
        /// Put waiting item on hold manually
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PutOnHoldAsync (int? restaurantId, int? waitingItemId);

        /// <summary>
        /// Put waiting item on hold manually
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PutOnHoldAsyncWithHttpInfo (int? restaurantId, int? waitingItemId);
        /// <summary>
        /// Sends a message related to specified waiting item.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <param name="createMessage">The body of the message</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task SendMessageToWaitingAsync (int? waitingItemId, CreateMessage createMessage);

        /// <summary>
        /// Sends a message related to specified waiting item.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <param name="createMessage">The body of the message</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> SendMessageToWaitingAsyncWithHttpInfo (int? waitingItemId, CreateMessage createMessage);
        /// <summary>
        /// Set waiting item off hold
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task TakeOffHoldAsync (int? restaurantId, int? waitingItemId);

        /// <summary>
        /// Set waiting item off hold
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> TakeOffHoldAsyncWithHttpInfo (int? restaurantId, int? waitingItemId);
        #endregion Asynchronous Operations
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MobileWaitingManagementApi : IMobileWaitingManagementApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MobileWaitingManagementApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MobileWaitingManagementApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MobileWaitingManagementApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MobileWaitingManagementApi(Configuration configuration = null)
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
        /// <param name="waitingItemId"></param> 
        /// <returns>Transaction</returns>
        public Transaction CheckInWithWaiting (int? waitingItemId)
        {
             ApiResponse<Transaction> localVarResponse = CheckInWithWaitingWithHttpInfo(waitingItemId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="waitingItemId"></param> 
        /// <returns>ApiResponse of Transaction</returns>
        public ApiResponse< Transaction > CheckInWithWaitingWithHttpInfo (int? waitingItemId)
        {
            
            // verify the required parameter 'waitingItemId' is set
            if (waitingItemId == null)
                throw new ApiException(400, "Missing required parameter 'waitingItemId' when calling MobileWaitingManagementApi->CheckInWithWaiting");
            
    
            var localVarPath = "/api/wm/mb/waitings/{waitingItemId}/checkin";
    
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
            if (waitingItemId != null) localVarPathParams.Add("waitingItemId", Configuration.ApiClient.ParameterToString(waitingItemId)); // path parameter
                                                

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
                throw new ApiException (localVarStatusCode, "Error calling CheckInWithWaiting: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CheckInWithWaiting: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Transaction>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Transaction) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Transaction)));
            
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="waitingItemId"></param>
        /// <returns>Task of Transaction</returns>
        public async System.Threading.Tasks.Task<Transaction> CheckInWithWaitingAsync (int? waitingItemId)
        {
             ApiResponse<Transaction> localVarResponse = await CheckInWithWaitingAsyncWithHttpInfo(waitingItemId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="waitingItemId"></param>
        /// <returns>Task of ApiResponse (Transaction)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Transaction>> CheckInWithWaitingAsyncWithHttpInfo (int? waitingItemId)
        {
            // verify the required parameter 'waitingItemId' is set
            if (waitingItemId == null) throw new ApiException(400, "Missing required parameter 'waitingItemId' when calling CheckInWithWaiting");
            
    
            var localVarPath = "/api/wm/mb/waitings/{waitingItemId}/checkin";
    
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
            if (waitingItemId != null) localVarPathParams.Add("waitingItemId", Configuration.ApiClient.ParameterToString(waitingItemId)); // path parameter
                                                

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
                throw new ApiException (localVarStatusCode, "Error calling CheckInWithWaiting: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CheckInWithWaiting: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Transaction>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Transaction) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Transaction)));
            
        }
        /// <summary>
        /// Closes waiting position. Closes current waiting position. When person gets a table, hostess should close current position.
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="waitingItemId">Identifier of the waiting item</param> 
        /// <returns></returns>
        public void Close (int? waitingItemId)
        {
             CloseWithHttpInfo(waitingItemId);
        }

        /// <summary>
        /// Closes waiting position. Closes current waiting position. When person gets a table, hostess should close current position.
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="waitingItemId">Identifier of the waiting item</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> CloseWithHttpInfo (int? waitingItemId)
        {
            
            // verify the required parameter 'waitingItemId' is set
            if (waitingItemId == null)
                throw new ApiException(400, "Missing required parameter 'waitingItemId' when calling MobileWaitingManagementApi->Close");
            
    
            var localVarPath = "/api/wm/mb/waitings/{waitingItemId}/close";
    
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
            if (waitingItemId != null) localVarPathParams.Add("waitingItemId", Configuration.ApiClient.ParameterToString(waitingItemId)); // path parameter
                                                

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
                throw new ApiException (localVarStatusCode, "Error calling Close: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Close: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Closes waiting position. Closes current waiting position. When person gets a table, hostess should close current position.
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="waitingItemId">Identifier of the waiting item</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task CloseAsync (int? waitingItemId)
        {
             await CloseAsyncWithHttpInfo(waitingItemId);

        }

        /// <summary>
        /// Closes waiting position. Closes current waiting position. When person gets a table, hostess should close current position.
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="waitingItemId">Identifier of the waiting item</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> CloseAsyncWithHttpInfo (int? waitingItemId)
        {
            // verify the required parameter 'waitingItemId' is set
            if (waitingItemId == null) throw new ApiException(400, "Missing required parameter 'waitingItemId' when calling Close");
            
    
            var localVarPath = "/api/wm/mb/waitings/{waitingItemId}/close";
    
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
            if (waitingItemId != null) localVarPathParams.Add("waitingItemId", Configuration.ApiClient.ParameterToString(waitingItemId)); // path parameter
                                                

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
                throw new ApiException (localVarStatusCode, "Error calling Close: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Close: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        /// <summary>
        /// Confirm waiting record from HostMe mobile application 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="confirmationCode">Confirmation code that has been generated during initial registration by hostess</param> 
        /// <param name="conf">Conformation model</param> 
        /// <returns></returns>
        public void ConfirmWithApp (int? confirmationCode, PhoneConfirmation conf)
        {
             ConfirmWithAppWithHttpInfo(confirmationCode, conf);
        }

        /// <summary>
        /// Confirm waiting record from HostMe mobile application 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="confirmationCode">Confirmation code that has been generated during initial registration by hostess</param> 
        /// <param name="conf">Conformation model</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ConfirmWithAppWithHttpInfo (int? confirmationCode, PhoneConfirmation conf)
        {
            
            // verify the required parameter 'confirmationCode' is set
            if (confirmationCode == null)
                throw new ApiException(400, "Missing required parameter 'confirmationCode' when calling MobileWaitingManagementApi->ConfirmWithApp");
            
            // verify the required parameter 'conf' is set
            if (conf == null)
                throw new ApiException(400, "Missing required parameter 'conf' when calling MobileWaitingManagementApi->ConfirmWithApp");
            
    
            var localVarPath = "/api/wm/mb/waitings/confirm/{confirmationCode}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded", "image/jpg", "image/jpeg", "image/png"
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
            if (confirmationCode != null) localVarPathParams.Add("confirmationCode", Configuration.ApiClient.ParameterToString(confirmationCode)); // path parameter
                                                if (conf.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(conf); // http body (model) parameter
            }
            else
            {
                localVarPostBody = conf; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling ConfirmWithApp: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfirmWithApp: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Confirm waiting record from HostMe mobile application 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="confirmationCode">Confirmation code that has been generated during initial registration by hostess</param>
        /// <param name="conf">Conformation model</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ConfirmWithAppAsync (int? confirmationCode, PhoneConfirmation conf)
        {
             await ConfirmWithAppAsyncWithHttpInfo(confirmationCode, conf);

        }

        /// <summary>
        /// Confirm waiting record from HostMe mobile application 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="confirmationCode">Confirmation code that has been generated during initial registration by hostess</param>
        /// <param name="conf">Conformation model</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ConfirmWithAppAsyncWithHttpInfo (int? confirmationCode, PhoneConfirmation conf)
        {
            // verify the required parameter 'confirmationCode' is set
            if (confirmationCode == null) throw new ApiException(400, "Missing required parameter 'confirmationCode' when calling ConfirmWithApp");
            // verify the required parameter 'conf' is set
            if (conf == null) throw new ApiException(400, "Missing required parameter 'conf' when calling ConfirmWithApp");
            
    
            var localVarPath = "/api/wm/mb/waitings/confirm/{confirmationCode}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded", "image/jpg", "image/jpeg", "image/png"
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
            if (confirmationCode != null) localVarPathParams.Add("confirmationCode", Configuration.ApiClient.ParameterToString(confirmationCode)); // path parameter
                                                if (conf.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(conf); // http body (model) parameter
            }
            else
            {
                localVarPostBody = conf; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling ConfirmWithApp: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfirmWithApp: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        /// <summary>
        /// Put customer in line. This method puts customer in a line on a fly. This is remote registration in a line. Waiting item will be automatically put on hold.
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value"></param> 
        /// <returns>WaitingItem</returns>
        public WaitingItem GetInLine (PutInLine value)
        {
             ApiResponse<WaitingItem> localVarResponse = GetInLineWithHttpInfo(value);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Put customer in line. This method puts customer in a line on a fly. This is remote registration in a line. Waiting item will be automatically put on hold.
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value"></param> 
        /// <returns>ApiResponse of WaitingItem</returns>
        public ApiResponse< WaitingItem > GetInLineWithHttpInfo (PutInLine value)
        {
            
            // verify the required parameter 'value' is set
            if (value == null)
                throw new ApiException(400, "Missing required parameter 'value' when calling MobileWaitingManagementApi->GetInLine");
            
    
            var localVarPath = "/api/wm/mb/waitings";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded", "image/jpg", "image/jpeg", "image/png"
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
                throw new ApiException (localVarStatusCode, "Error calling GetInLine: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInLine: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<WaitingItem>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WaitingItem) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WaitingItem)));
            
        }

        /// <summary>
        /// Put customer in line. This method puts customer in a line on a fly. This is remote registration in a line. Waiting item will be automatically put on hold.
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value"></param>
        /// <returns>Task of WaitingItem</returns>
        public async System.Threading.Tasks.Task<WaitingItem> GetInLineAsync (PutInLine value)
        {
             ApiResponse<WaitingItem> localVarResponse = await GetInLineAsyncWithHttpInfo(value);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Put customer in line. This method puts customer in a line on a fly. This is remote registration in a line. Waiting item will be automatically put on hold.
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value"></param>
        /// <returns>Task of ApiResponse (WaitingItem)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WaitingItem>> GetInLineAsyncWithHttpInfo (PutInLine value)
        {
            // verify the required parameter 'value' is set
            if (value == null) throw new ApiException(400, "Missing required parameter 'value' when calling GetInLine");
            
    
            var localVarPath = "/api/wm/mb/waitings";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded", "image/jpg", "image/jpeg", "image/png"
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
                throw new ApiException (localVarStatusCode, "Error calling GetInLine: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInLine: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WaitingItem>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WaitingItem) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WaitingItem)));
            
        }
        /// <summary>
        /// Returns current user waiting item 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>WaitingItem</returns>
        public WaitingItem GetUserCurrentWaiting ()
        {
             ApiResponse<WaitingItem> localVarResponse = GetUserCurrentWaitingWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns current user waiting item 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of WaitingItem</returns>
        public ApiResponse< WaitingItem > GetUserCurrentWaitingWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/wm/mb/waitings";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetUserCurrentWaiting: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserCurrentWaiting: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<WaitingItem>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WaitingItem) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WaitingItem)));
            
        }

        /// <summary>
        /// Returns current user waiting item 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of WaitingItem</returns>
        public async System.Threading.Tasks.Task<WaitingItem> GetUserCurrentWaitingAsync ()
        {
             ApiResponse<WaitingItem> localVarResponse = await GetUserCurrentWaitingAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns current user waiting item 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (WaitingItem)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WaitingItem>> GetUserCurrentWaitingAsyncWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/wm/mb/waitings";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetUserCurrentWaiting: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserCurrentWaiting: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WaitingItem>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WaitingItem) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WaitingItem)));
            
        }
        /// <summary>
        /// Cancels waiting position. Cancels specified waiting position. Client may decide to go to another restaurant and cancel current waiting item.
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="waitingItemId">Waiting item identifier</param> 
        /// <returns></returns>
        public void LeaveTheLine (int? waitingItemId)
        {
             LeaveTheLineWithHttpInfo(waitingItemId);
        }

        /// <summary>
        /// Cancels waiting position. Cancels specified waiting position. Client may decide to go to another restaurant and cancel current waiting item.
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="waitingItemId">Waiting item identifier</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> LeaveTheLineWithHttpInfo (int? waitingItemId)
        {
            
            // verify the required parameter 'waitingItemId' is set
            if (waitingItemId == null)
                throw new ApiException(400, "Missing required parameter 'waitingItemId' when calling MobileWaitingManagementApi->LeaveTheLine");
            
    
            var localVarPath = "/api/wm/mb/waitings/{waitingItemId}/cancel";
    
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
            if (waitingItemId != null) localVarPathParams.Add("waitingItemId", Configuration.ApiClient.ParameterToString(waitingItemId)); // path parameter
                                                

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
                throw new ApiException (localVarStatusCode, "Error calling LeaveTheLine: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling LeaveTheLine: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Cancels waiting position. Cancels specified waiting position. Client may decide to go to another restaurant and cancel current waiting item.
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task LeaveTheLineAsync (int? waitingItemId)
        {
             await LeaveTheLineAsyncWithHttpInfo(waitingItemId);

        }

        /// <summary>
        /// Cancels waiting position. Cancels specified waiting position. Client may decide to go to another restaurant and cancel current waiting item.
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> LeaveTheLineAsyncWithHttpInfo (int? waitingItemId)
        {
            // verify the required parameter 'waitingItemId' is set
            if (waitingItemId == null) throw new ApiException(400, "Missing required parameter 'waitingItemId' when calling LeaveTheLine");
            
    
            var localVarPath = "/api/wm/mb/waitings/{waitingItemId}/cancel";
    
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
            if (waitingItemId != null) localVarPathParams.Add("waitingItemId", Configuration.ApiClient.ParameterToString(waitingItemId)); // path parameter
                                                

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
                throw new ApiException (localVarStatusCode, "Error calling LeaveTheLine: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling LeaveTheLine: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        /// <summary>
        /// Mark all message as read. 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="waitingItemId">Waiting item identifier</param> 
        /// <returns></returns>
        public void MarkAllMessagesAsRead (int? waitingItemId)
        {
             MarkAllMessagesAsReadWithHttpInfo(waitingItemId);
        }

        /// <summary>
        /// Mark all message as read. 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="waitingItemId">Waiting item identifier</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> MarkAllMessagesAsReadWithHttpInfo (int? waitingItemId)
        {
            
            // verify the required parameter 'waitingItemId' is set
            if (waitingItemId == null)
                throw new ApiException(400, "Missing required parameter 'waitingItemId' when calling MobileWaitingManagementApi->MarkAllMessagesAsRead");
            
    
            var localVarPath = "/api/wm/mb/waitings/{waitingItemId}/messages/readall";
    
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
            if (waitingItemId != null) localVarPathParams.Add("waitingItemId", Configuration.ApiClient.ParameterToString(waitingItemId)); // path parameter
                                                

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
                throw new ApiException (localVarStatusCode, "Error calling MarkAllMessagesAsRead: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling MarkAllMessagesAsRead: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Mark all message as read. 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task MarkAllMessagesAsReadAsync (int? waitingItemId)
        {
             await MarkAllMessagesAsReadAsyncWithHttpInfo(waitingItemId);

        }

        /// <summary>
        /// Mark all message as read. 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> MarkAllMessagesAsReadAsyncWithHttpInfo (int? waitingItemId)
        {
            // verify the required parameter 'waitingItemId' is set
            if (waitingItemId == null) throw new ApiException(400, "Missing required parameter 'waitingItemId' when calling MarkAllMessagesAsRead");
            
    
            var localVarPath = "/api/wm/mb/waitings/{waitingItemId}/messages/readall";
    
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
            if (waitingItemId != null) localVarPathParams.Add("waitingItemId", Configuration.ApiClient.ParameterToString(waitingItemId)); // path parameter
                                                

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
                throw new ApiException (localVarStatusCode, "Error calling MarkAllMessagesAsRead: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling MarkAllMessagesAsRead: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        /// <summary>
        /// Put waiting item on hold manually 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param> 
        /// <param name="waitingItemId">Waiting item identifier</param> 
        /// <returns></returns>
        public void PutOnHold (int? restaurantId, int? waitingItemId)
        {
             PutOnHoldWithHttpInfo(restaurantId, waitingItemId);
        }

        /// <summary>
        /// Put waiting item on hold manually 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param> 
        /// <param name="waitingItemId">Waiting item identifier</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PutOnHoldWithHttpInfo (int? restaurantId, int? waitingItemId)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling MobileWaitingManagementApi->PutOnHold");
            
            // verify the required parameter 'waitingItemId' is set
            if (waitingItemId == null)
                throw new ApiException(400, "Missing required parameter 'waitingItemId' when calling MobileWaitingManagementApi->PutOnHold");
            
    
            var localVarPath = "/api/wm/mb/waitings/{waitingItemId}/putonhold";
    
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
            if (waitingItemId != null) localVarPathParams.Add("waitingItemId", Configuration.ApiClient.ParameterToString(waitingItemId)); // path parameter
            if (restaurantId != null) localVarQueryParams.Add("restaurantId", Configuration.ApiClient.ParameterToString(restaurantId)); // query parameter
                                    

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
                throw new ApiException (localVarStatusCode, "Error calling PutOnHold: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutOnHold: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Put waiting item on hold manually 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PutOnHoldAsync (int? restaurantId, int? waitingItemId)
        {
             await PutOnHoldAsyncWithHttpInfo(restaurantId, waitingItemId);

        }

        /// <summary>
        /// Put waiting item on hold manually 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PutOnHoldAsyncWithHttpInfo (int? restaurantId, int? waitingItemId)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling PutOnHold");
            // verify the required parameter 'waitingItemId' is set
            if (waitingItemId == null) throw new ApiException(400, "Missing required parameter 'waitingItemId' when calling PutOnHold");
            
    
            var localVarPath = "/api/wm/mb/waitings/{waitingItemId}/putonhold";
    
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
            if (waitingItemId != null) localVarPathParams.Add("waitingItemId", Configuration.ApiClient.ParameterToString(waitingItemId)); // path parameter
            if (restaurantId != null) localVarQueryParams.Add("restaurantId", Configuration.ApiClient.ParameterToString(restaurantId)); // query parameter
                                    

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
                throw new ApiException (localVarStatusCode, "Error calling PutOnHold: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutOnHold: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        /// <summary>
        /// Sends a message related to specified waiting item. 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="waitingItemId">Waiting item identifier</param> 
        /// <param name="createMessage">The body of the message</param> 
        /// <returns></returns>
        public void SendMessageToWaiting (int? waitingItemId, CreateMessage createMessage)
        {
             SendMessageToWaitingWithHttpInfo(waitingItemId, createMessage);
        }

        /// <summary>
        /// Sends a message related to specified waiting item. 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="waitingItemId">Waiting item identifier</param> 
        /// <param name="createMessage">The body of the message</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> SendMessageToWaitingWithHttpInfo (int? waitingItemId, CreateMessage createMessage)
        {
            
            // verify the required parameter 'waitingItemId' is set
            if (waitingItemId == null)
                throw new ApiException(400, "Missing required parameter 'waitingItemId' when calling MobileWaitingManagementApi->SendMessageToWaiting");
            
            // verify the required parameter 'createMessage' is set
            if (createMessage == null)
                throw new ApiException(400, "Missing required parameter 'createMessage' when calling MobileWaitingManagementApi->SendMessageToWaiting");
            
    
            var localVarPath = "/api/wm/mb/waitings/{waitingItemId}/sendmessage";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded", "image/jpg", "image/jpeg", "image/png"
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
            if (waitingItemId != null) localVarPathParams.Add("waitingItemId", Configuration.ApiClient.ParameterToString(waitingItemId)); // path parameter
                                                if (createMessage.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(createMessage); // http body (model) parameter
            }
            else
            {
                localVarPostBody = createMessage; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling SendMessageToWaiting: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SendMessageToWaiting: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Sends a message related to specified waiting item. 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <param name="createMessage">The body of the message</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task SendMessageToWaitingAsync (int? waitingItemId, CreateMessage createMessage)
        {
             await SendMessageToWaitingAsyncWithHttpInfo(waitingItemId, createMessage);

        }

        /// <summary>
        /// Sends a message related to specified waiting item. 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <param name="createMessage">The body of the message</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> SendMessageToWaitingAsyncWithHttpInfo (int? waitingItemId, CreateMessage createMessage)
        {
            // verify the required parameter 'waitingItemId' is set
            if (waitingItemId == null) throw new ApiException(400, "Missing required parameter 'waitingItemId' when calling SendMessageToWaiting");
            // verify the required parameter 'createMessage' is set
            if (createMessage == null) throw new ApiException(400, "Missing required parameter 'createMessage' when calling SendMessageToWaiting");
            
    
            var localVarPath = "/api/wm/mb/waitings/{waitingItemId}/sendmessage";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded", "image/jpg", "image/jpeg", "image/png"
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
            if (waitingItemId != null) localVarPathParams.Add("waitingItemId", Configuration.ApiClient.ParameterToString(waitingItemId)); // path parameter
                                                if (createMessage.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(createMessage); // http body (model) parameter
            }
            else
            {
                localVarPostBody = createMessage; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling SendMessageToWaiting: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SendMessageToWaiting: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        /// <summary>
        /// Set waiting item off hold 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param> 
        /// <param name="waitingItemId">Waiting item identifier</param> 
        /// <returns></returns>
        public void TakeOffHold (int? restaurantId, int? waitingItemId)
        {
             TakeOffHoldWithHttpInfo(restaurantId, waitingItemId);
        }

        /// <summary>
        /// Set waiting item off hold 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param> 
        /// <param name="waitingItemId">Waiting item identifier</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> TakeOffHoldWithHttpInfo (int? restaurantId, int? waitingItemId)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling MobileWaitingManagementApi->TakeOffHold");
            
            // verify the required parameter 'waitingItemId' is set
            if (waitingItemId == null)
                throw new ApiException(400, "Missing required parameter 'waitingItemId' when calling MobileWaitingManagementApi->TakeOffHold");
            
    
            var localVarPath = "/api/wm/mb/waitings/{waitingItemId}/takeoffhold";
    
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
            if (waitingItemId != null) localVarPathParams.Add("waitingItemId", Configuration.ApiClient.ParameterToString(waitingItemId)); // path parameter
            if (restaurantId != null) localVarQueryParams.Add("restaurantId", Configuration.ApiClient.ParameterToString(restaurantId)); // query parameter
                                    

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
                throw new ApiException (localVarStatusCode, "Error calling TakeOffHold: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TakeOffHold: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Set waiting item off hold 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task TakeOffHoldAsync (int? restaurantId, int? waitingItemId)
        {
             await TakeOffHoldAsyncWithHttpInfo(restaurantId, waitingItemId);

        }

        /// <summary>
        /// Set waiting item off hold 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> TakeOffHoldAsyncWithHttpInfo (int? restaurantId, int? waitingItemId)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling TakeOffHold");
            // verify the required parameter 'waitingItemId' is set
            if (waitingItemId == null) throw new ApiException(400, "Missing required parameter 'waitingItemId' when calling TakeOffHold");
            
    
            var localVarPath = "/api/wm/mb/waitings/{waitingItemId}/takeoffhold";
    
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
            if (waitingItemId != null) localVarPathParams.Add("waitingItemId", Configuration.ApiClient.ParameterToString(waitingItemId)); // path parameter
            if (restaurantId != null) localVarQueryParams.Add("restaurantId", Configuration.ApiClient.ParameterToString(restaurantId)); // query parameter
                                    

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
                throw new ApiException (localVarStatusCode, "Error calling TakeOffHold: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TakeOffHold: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    }
}
