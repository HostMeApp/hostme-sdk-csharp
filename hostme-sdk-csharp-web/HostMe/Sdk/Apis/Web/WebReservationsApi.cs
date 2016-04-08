using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using HostMe.Sdk.Client;
using HostMe.Sdk.Models;


namespace HostMe.Sdk.Apis.Web
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IWebReservationsApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="value"></param>
        /// <returns>Reservation</returns>
        Reservation AddNewReservation (int? restaurantId, NewWebReservationBindingModel value);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="value"></param>
        /// <returns>ApiResponse of Reservation</returns>
        ApiResponse<Reservation> AddNewReservationWithHttpInfo (int? restaurantId, NewWebReservationBindingModel value);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lat"> (optional)</param>
        /// <param name="lon"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <returns>List&lt;RestaurantInfo&gt;</returns>
        List<RestaurantInfo> FindRestaurants (double? lat, double? lon, string name);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lat"> (optional)</param>
        /// <param name="lon"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <returns>ApiResponse of List&lt;RestaurantInfo&gt;</returns>
        ApiResponse<List<RestaurantInfo>> FindRestaurantsWithHttpInfo (double? lat, double? lon, string name);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="date"></param>
        /// <param name="partySize"></param>
        /// <param name="rangeInMinutes"></param>
        /// <param name="areas"> (optional)</param>
        /// <returns>List&lt;OnlineAvailability&gt;</returns>
        List<OnlineAvailability> GetReservationAvailability (int? restaurantId, DateTimeOffset? date, int? partySize, int? rangeInMinutes, string areas);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="date"></param>
        /// <param name="partySize"></param>
        /// <param name="rangeInMinutes"></param>
        /// <param name="areas"> (optional)</param>
        /// <returns>ApiResponse of List&lt;OnlineAvailability&gt;</returns>
        ApiResponse<List<OnlineAvailability>> GetReservationAvailabilityWithHttpInfo (int? restaurantId, DateTimeOffset? date, int? partySize, int? rangeInMinutes, string areas);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>RestaurantInfo</returns>
        RestaurantInfo GetRestaurantById (int? restaurantId);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>ApiResponse of RestaurantInfo</returns>
        ApiResponse<RestaurantInfo> GetRestaurantByIdWithHttpInfo (int? restaurantId);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="value"></param>
        /// <returns>Task of Reservation</returns>
        System.Threading.Tasks.Task<Reservation> AddNewReservationAsync (int? restaurantId, NewWebReservationBindingModel value);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="value"></param>
        /// <returns>Task of ApiResponse (Reservation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Reservation>> AddNewReservationAsyncWithHttpInfo (int? restaurantId, NewWebReservationBindingModel value);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lat"> (optional)</param>
        /// <param name="lon"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <returns>Task of List&lt;RestaurantInfo&gt;</returns>
        System.Threading.Tasks.Task<List<RestaurantInfo>> FindRestaurantsAsync (double? lat, double? lon, string name);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lat"> (optional)</param>
        /// <param name="lon"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;RestaurantInfo&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<RestaurantInfo>>> FindRestaurantsAsyncWithHttpInfo (double? lat, double? lon, string name);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="date"></param>
        /// <param name="partySize"></param>
        /// <param name="rangeInMinutes"></param>
        /// <param name="areas"> (optional)</param>
        /// <returns>Task of List&lt;OnlineAvailability&gt;</returns>
        System.Threading.Tasks.Task<List<OnlineAvailability>> GetReservationAvailabilityAsync (int? restaurantId, DateTimeOffset? date, int? partySize, int? rangeInMinutes, string areas);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="date"></param>
        /// <param name="partySize"></param>
        /// <param name="rangeInMinutes"></param>
        /// <param name="areas"> (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;OnlineAvailability&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<OnlineAvailability>>> GetReservationAvailabilityAsyncWithHttpInfo (int? restaurantId, DateTimeOffset? date, int? partySize, int? rangeInMinutes, string areas);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Task of RestaurantInfo</returns>
        System.Threading.Tasks.Task<RestaurantInfo> GetRestaurantByIdAsync (int? restaurantId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Task of ApiResponse (RestaurantInfo)</returns>
        System.Threading.Tasks.Task<ApiResponse<RestaurantInfo>> GetRestaurantByIdAsyncWithHttpInfo (int? restaurantId);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class WebReservationsApi : IWebReservationsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebReservationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WebReservationsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WebReservationsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public WebReservationsApi(Configuration configuration = null)
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
        /// <param name="restaurantId"></param> 
        /// <param name="value"></param> 
        /// <returns>Reservation</returns>
        public Reservation AddNewReservation (int? restaurantId, NewWebReservationBindingModel value)
        {
             ApiResponse<Reservation> localVarResponse = AddNewReservationWithHttpInfo(restaurantId, value);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="value"></param> 
        /// <returns>ApiResponse of Reservation</returns>
        public ApiResponse< Reservation > AddNewReservationWithHttpInfo (int? restaurantId, NewWebReservationBindingModel value)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling WebReservationsApi->AddNewReservation");
            
            // verify the required parameter 'value' is set
            if (value == null)
                throw new ApiException(400, "Missing required parameter 'value' when calling WebReservationsApi->AddNewReservation");
            
    
            var localVarPath = "/api/rsv/web/restaurants/{restaurantId}/reservations";
    
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
            if (restaurantId != null) localVarPathParams.Add("restaurantId", Configuration.ApiClient.ParameterToString(restaurantId)); // path parameter
            
            
            
            
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
        /// <param name="restaurantId"></param>
        /// <param name="value"></param>
        /// <returns>Task of Reservation</returns>
        public async System.Threading.Tasks.Task<Reservation> AddNewReservationAsync (int? restaurantId, NewWebReservationBindingModel value)
        {
             ApiResponse<Reservation> localVarResponse = await AddNewReservationAsyncWithHttpInfo(restaurantId, value);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="value"></param>
        /// <returns>Task of ApiResponse (Reservation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Reservation>> AddNewReservationAsyncWithHttpInfo (int? restaurantId, NewWebReservationBindingModel value)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AddNewReservation");
            // verify the required parameter 'value' is set
            if (value == null) throw new ApiException(400, "Missing required parameter 'value' when calling AddNewReservation");
            
    
            var localVarPath = "/api/rsv/web/restaurants/{restaurantId}/reservations";
    
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
            if (restaurantId != null) localVarPathParams.Add("restaurantId", Configuration.ApiClient.ParameterToString(restaurantId)); // path parameter
            
            
            
            
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
        /// <param name="lat"> (optional)</param> 
        /// <param name="lon"> (optional)</param> 
        /// <param name="name"> (optional)</param> 
        /// <returns>List&lt;RestaurantInfo&gt;</returns>
        public List<RestaurantInfo> FindRestaurants (double? lat, double? lon, string name)
        {
             ApiResponse<List<RestaurantInfo>> localVarResponse = FindRestaurantsWithHttpInfo(lat, lon, name);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lat"> (optional)</param> 
        /// <param name="lon"> (optional)</param> 
        /// <param name="name"> (optional)</param> 
        /// <returns>ApiResponse of List&lt;RestaurantInfo&gt;</returns>
        public ApiResponse< List<RestaurantInfo> > FindRestaurantsWithHttpInfo (double? lat, double? lon, string name)
        {
            
    
            var localVarPath = "/api/rsv/web/restaurants/find";
    
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
            
            if (lat != null) localVarQueryParams.Add("lat", Configuration.ApiClient.ParameterToString(lat)); // query parameter
            if (lon != null) localVarQueryParams.Add("lon", Configuration.ApiClient.ParameterToString(lon)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling FindRestaurants: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling FindRestaurants: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<RestaurantInfo>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<RestaurantInfo>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<RestaurantInfo>)));
            
        }

        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lat"> (optional)</param>
        /// <param name="lon"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <returns>Task of List&lt;RestaurantInfo&gt;</returns>
        public async System.Threading.Tasks.Task<List<RestaurantInfo>> FindRestaurantsAsync (double? lat, double? lon, string name)
        {
             ApiResponse<List<RestaurantInfo>> localVarResponse = await FindRestaurantsAsyncWithHttpInfo(lat, lon, name);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lat"> (optional)</param>
        /// <param name="lon"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;RestaurantInfo&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<RestaurantInfo>>> FindRestaurantsAsyncWithHttpInfo (double? lat, double? lon, string name)
        {
            
    
            var localVarPath = "/api/rsv/web/restaurants/find";
    
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
            
            if (lat != null) localVarQueryParams.Add("lat", Configuration.ApiClient.ParameterToString(lat)); // query parameter
            if (lon != null) localVarQueryParams.Add("lon", Configuration.ApiClient.ParameterToString(lon)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling FindRestaurants: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling FindRestaurants: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<RestaurantInfo>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<RestaurantInfo>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<RestaurantInfo>)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="date"></param> 
        /// <param name="partySize"></param> 
        /// <param name="rangeInMinutes"></param> 
        /// <param name="areas"> (optional)</param> 
        /// <returns>List&lt;OnlineAvailability&gt;</returns>
        public List<OnlineAvailability> GetReservationAvailability (int? restaurantId, DateTimeOffset? date, int? partySize, int? rangeInMinutes, string areas)
        {
             ApiResponse<List<OnlineAvailability>> localVarResponse = GetReservationAvailabilityWithHttpInfo(restaurantId, date, partySize, rangeInMinutes, areas);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="date"></param> 
        /// <param name="partySize"></param> 
        /// <param name="rangeInMinutes"></param> 
        /// <param name="areas"> (optional)</param> 
        /// <returns>ApiResponse of List&lt;OnlineAvailability&gt;</returns>
        public ApiResponse< List<OnlineAvailability> > GetReservationAvailabilityWithHttpInfo (int? restaurantId, DateTimeOffset? date, int? partySize, int? rangeInMinutes, string areas)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling WebReservationsApi->GetReservationAvailability");
            
            // verify the required parameter 'date' is set
            if (date == null)
                throw new ApiException(400, "Missing required parameter 'date' when calling WebReservationsApi->GetReservationAvailability");
            
            // verify the required parameter 'partySize' is set
            if (partySize == null)
                throw new ApiException(400, "Missing required parameter 'partySize' when calling WebReservationsApi->GetReservationAvailability");
            
            // verify the required parameter 'rangeInMinutes' is set
            if (rangeInMinutes == null)
                throw new ApiException(400, "Missing required parameter 'rangeInMinutes' when calling WebReservationsApi->GetReservationAvailability");
            
    
            var localVarPath = "/api/rsv/web/restaurants/{restaurantId}/availability";
    
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
            if (restaurantId != null) localVarPathParams.Add("restaurantId", Configuration.ApiClient.ParameterToString(restaurantId)); // path parameter
            
            if (date != null) localVarQueryParams.Add("date", Configuration.ApiClient.ParameterToString(date)); // query parameter
            if (partySize != null) localVarQueryParams.Add("partySize", Configuration.ApiClient.ParameterToString(partySize)); // query parameter
            if (rangeInMinutes != null) localVarQueryParams.Add("rangeInMinutes", Configuration.ApiClient.ParameterToString(rangeInMinutes)); // query parameter
            if (areas != null) localVarQueryParams.Add("areas", Configuration.ApiClient.ParameterToString(areas)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetReservationAvailability: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetReservationAvailability: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<OnlineAvailability>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<OnlineAvailability>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<OnlineAvailability>)));
            
        }

        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="date"></param>
        /// <param name="partySize"></param>
        /// <param name="rangeInMinutes"></param>
        /// <param name="areas"> (optional)</param>
        /// <returns>Task of List&lt;OnlineAvailability&gt;</returns>
        public async System.Threading.Tasks.Task<List<OnlineAvailability>> GetReservationAvailabilityAsync (int? restaurantId, DateTimeOffset? date, int? partySize, int? rangeInMinutes, string areas)
        {
             ApiResponse<List<OnlineAvailability>> localVarResponse = await GetReservationAvailabilityAsyncWithHttpInfo(restaurantId, date, partySize, rangeInMinutes, areas);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="date"></param>
        /// <param name="partySize"></param>
        /// <param name="rangeInMinutes"></param>
        /// <param name="areas"> (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;OnlineAvailability&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<OnlineAvailability>>> GetReservationAvailabilityAsyncWithHttpInfo (int? restaurantId, DateTimeOffset? date, int? partySize, int? rangeInMinutes, string areas)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling GetReservationAvailability");
            // verify the required parameter 'date' is set
            if (date == null) throw new ApiException(400, "Missing required parameter 'date' when calling GetReservationAvailability");
            // verify the required parameter 'partySize' is set
            if (partySize == null) throw new ApiException(400, "Missing required parameter 'partySize' when calling GetReservationAvailability");
            // verify the required parameter 'rangeInMinutes' is set
            if (rangeInMinutes == null) throw new ApiException(400, "Missing required parameter 'rangeInMinutes' when calling GetReservationAvailability");
            
    
            var localVarPath = "/api/rsv/web/restaurants/{restaurantId}/availability";
    
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
            if (restaurantId != null) localVarPathParams.Add("restaurantId", Configuration.ApiClient.ParameterToString(restaurantId)); // path parameter
            
            if (date != null) localVarQueryParams.Add("date", Configuration.ApiClient.ParameterToString(date)); // query parameter
            if (partySize != null) localVarQueryParams.Add("partySize", Configuration.ApiClient.ParameterToString(partySize)); // query parameter
            if (rangeInMinutes != null) localVarQueryParams.Add("rangeInMinutes", Configuration.ApiClient.ParameterToString(rangeInMinutes)); // query parameter
            if (areas != null) localVarQueryParams.Add("areas", Configuration.ApiClient.ParameterToString(areas)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetReservationAvailability: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetReservationAvailability: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<OnlineAvailability>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<OnlineAvailability>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<OnlineAvailability>)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <returns>RestaurantInfo</returns>
        public RestaurantInfo GetRestaurantById (int? restaurantId)
        {
             ApiResponse<RestaurantInfo> localVarResponse = GetRestaurantByIdWithHttpInfo(restaurantId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <returns>ApiResponse of RestaurantInfo</returns>
        public ApiResponse< RestaurantInfo > GetRestaurantByIdWithHttpInfo (int? restaurantId)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling WebReservationsApi->GetRestaurantById");
            
    
            var localVarPath = "/api/rsv/web/restaurants/{restaurantId}";
    
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
            if (restaurantId != null) localVarPathParams.Add("restaurantId", Configuration.ApiClient.ParameterToString(restaurantId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetRestaurantById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRestaurantById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<RestaurantInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RestaurantInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestaurantInfo)));
            
        }

        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Task of RestaurantInfo</returns>
        public async System.Threading.Tasks.Task<RestaurantInfo> GetRestaurantByIdAsync (int? restaurantId)
        {
             ApiResponse<RestaurantInfo> localVarResponse = await GetRestaurantByIdAsyncWithHttpInfo(restaurantId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Task of ApiResponse (RestaurantInfo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RestaurantInfo>> GetRestaurantByIdAsyncWithHttpInfo (int? restaurantId)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling GetRestaurantById");
            
    
            var localVarPath = "/api/rsv/web/restaurants/{restaurantId}";
    
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
            if (restaurantId != null) localVarPathParams.Add("restaurantId", Configuration.ApiClient.ParameterToString(restaurantId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetRestaurantById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRestaurantById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RestaurantInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RestaurantInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestaurantInfo)));
            
        }
        
    }
    
}
