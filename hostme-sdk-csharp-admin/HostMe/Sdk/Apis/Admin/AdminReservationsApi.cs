using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using HostMe.Sdk.Client;
using HostMe.Sdk.Models;

namespace HostMe.Sdk.Apis.Admin
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAdminReservationsApi
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
        Reservation AddNewReservation (int? restaurantId, AdminReservationBindingModel value);
  
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
        ApiResponse<Reservation> AddNewReservationWithHttpInfo (int? restaurantId, AdminReservationBindingModel value);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="reservationId"></param>
        /// <param name="notes"></param>
        /// <returns>Reservation</returns>
        Reservation CancelReservation (int? restaurantId, string reservationId, string notes);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="reservationId"></param>
        /// <param name="notes"></param>
        /// <returns>ApiResponse of Reservation</returns>
        ApiResponse<Reservation> CancelReservationWithHttpInfo (int? restaurantId, string reservationId, string notes);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="reservationId"></param>
        /// <returns>Reservation</returns>
        Reservation CloseAsNoShow (int? restaurantId, string reservationId);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="reservationId"></param>
        /// <returns>ApiResponse of Reservation</returns>
        ApiResponse<Reservation> CloseAsNoShowWithHttpInfo (int? restaurantId, string reservationId);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="reservationId"></param>
        /// <param name="tableNumber"> (optional)</param>
        /// <returns>Reservation</returns>
        Reservation CloseAsSeated (int? restaurantId, string reservationId, string tableNumber = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="reservationId"></param>
        /// <param name="tableNumber"> (optional)</param>
        /// <returns>ApiResponse of Reservation</returns>
        ApiResponse<Reservation> CloseAsSeatedWithHttpInfo (int? restaurantId, string reservationId, string tableNumber = null);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>ReservationSettings</returns>
        ReservationSettings GeReservationSettings (int? restaurantId);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>ApiResponse of ReservationSettings</returns>
        ApiResponse<ReservationSettings> GeReservationSettingsWithHttpInfo (int? restaurantId);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="reservationId"></param>
        /// <returns>List&lt;Message&gt;</returns>
        List<Message> GetMessages (int? restaurantId, string reservationId);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="reservationId"></param>
        /// <returns>ApiResponse of List&lt;Message&gt;</returns>
        ApiResponse<List<Message>> GetMessagesWithHttpInfo (int? restaurantId, string reservationId);
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
        /// <param name="tableTurnOver"> (optional)</param>
        /// <param name="type"> (optional)</param>
        /// <param name="areas"> (optional)</param>
        /// <returns>AvailabilityResponse</returns>
        AvailabilityResponse GetReservationAvailability (int? restaurantId, DateTimeOffset? date, int? partySize, int? rangeInMinutes, double? tableTurnOver = null, string type = null, string areas = null);
  
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
        /// <param name="tableTurnOver"> (optional)</param>
        /// <param name="type"> (optional)</param>
        /// <param name="areas"> (optional)</param>
        /// <returns>ApiResponse of AvailabilityResponse</returns>
        ApiResponse<AvailabilityResponse> GetReservationAvailabilityWithHttpInfo (int? restaurantId, DateTimeOffset? date, int? partySize, int? rangeInMinutes, double? tableTurnOver = null, string type = null, string areas = null);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="reservationId"></param>
        /// <returns>Reservation</returns>
        Reservation GetReservationById (int? restaurantId, string reservationId);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="reservationId"></param>
        /// <returns>ApiResponse of Reservation</returns>
        ApiResponse<Reservation> GetReservationByIdWithHttpInfo (int? restaurantId, string reservationId);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="from"> (optional)</param>
        /// <param name="to"> (optional)</param>
        /// <returns>List&lt;Reservation&gt;</returns>
        List<Reservation> GetReservationsForPeriod (int? restaurantId, DateTimeOffset? from = null, DateTimeOffset? to = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="from"> (optional)</param>
        /// <param name="to"> (optional)</param>
        /// <returns>ApiResponse of List&lt;Reservation&gt;</returns>
        ApiResponse<List<Reservation>> GetReservationsForPeriodWithHttpInfo (int? restaurantId, DateTimeOffset? from = null, DateTimeOffset? to = null);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>ReservationsStatistic</returns>
        ReservationsStatistic GetRestaurantReservationsStatistic (int? restaurantId);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>ApiResponse of ReservationsStatistic</returns>
        ApiResponse<ReservationsStatistic> GetRestaurantReservationsStatisticWithHttpInfo (int? restaurantId);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="from"> (optional)</param>
        /// <returns>int?</returns>
        int? GetUnreadMessagesCount (int? restaurantId, DateTimeOffset? from = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="from"> (optional)</param>
        /// <returns>ApiResponse of int?</returns>
        ApiResponse<int?> GetUnreadMessagesCountWithHttpInfo (int? restaurantId, DateTimeOffset? from = null);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="reservationId"></param>
        /// <returns>WaitingItem</returns>
        WaitingItem PlaceOnWaitList (int? restaurantId, string reservationId);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="reservationId"></param>
        /// <returns>ApiResponse of WaitingItem</returns>
        ApiResponse<WaitingItem> PlaceOnWaitListWithHttpInfo (int? restaurantId, string reservationId);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="reservationId"></param>
        /// <returns>Reservation</returns>
        Reservation ReOpenReservation (int? restaurantId, string reservationId);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="reservationId"></param>
        /// <returns>ApiResponse of Reservation</returns>
        ApiResponse<Reservation> ReOpenReservationWithHttpInfo (int? restaurantId, string reservationId);
        /// <summary>
        /// Mark all message as read.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="reservationId">Reservation identifier</param>
        /// <returns>Object</returns>
        Object ReadAllMessage (int? restaurantId, string reservationId);
  
        /// <summary>
        /// Mark all message as read.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="reservationId">Reservation identifier</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> ReadAllMessageWithHttpInfo (int? restaurantId, string reservationId);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="from"></param>
        /// <param name="html"></param>
        /// <param name="text"></param>
        /// <param name="to"></param>
        /// <param name="subject"></param>
        /// <returns>Reservation</returns>
        Reservation SendGrid (string from, string html, string text, string to, string subject);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="from"></param>
        /// <param name="html"></param>
        /// <param name="text"></param>
        /// <param name="to"></param>
        /// <param name="subject"></param>
        /// <returns>ApiResponse of Reservation</returns>
        ApiResponse<Reservation> SendGridWithHttpInfo (string from, string html, string text, string to, string subject);
        /// <summary>
        /// Sends a message related to specified reservation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="reservationId">Reservation identifier</param>
        /// <param name="body">The body of the message</param>
        /// <returns>Message</returns>
        Message SendMessage (int? restaurantId, string reservationId, string body);
  
        /// <summary>
        /// Sends a message related to specified reservation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="reservationId">Reservation identifier</param>
        /// <param name="body">The body of the message</param>
        /// <returns>ApiResponse of Message</returns>
        ApiResponse<Message> SendMessageWithHttpInfo (int? restaurantId, string reservationId, string body);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="settings"></param>
        /// <returns>Object</returns>
        Object SetReservationSettings (int? restaurantId, ReservationSettings settings);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="settings"></param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> SetReservationSettingsWithHttpInfo (int? restaurantId, ReservationSettings settings);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Object</returns>
        Object SubmitYelpReservation ();
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> SubmitYelpReservationWithHttpInfo ();
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="reservationId"></param>
        /// <param name="value"></param>
        /// <returns>Object</returns>
        Object UpdateReservation (int? restaurantId, string reservationId, AdminReservationBindingModel value);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="reservationId"></param>
        /// <param name="value"></param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> UpdateReservationWithHttpInfo (int? restaurantId, string reservationId, AdminReservationBindingModel value);
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
        System.Threading.Tasks.Task<Reservation> AddNewReservationAsync (int? restaurantId, AdminReservationBindingModel value);

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
        System.Threading.Tasks.Task<ApiResponse<Reservation>> AddNewReservationAsyncWithHttpInfo (int? restaurantId, AdminReservationBindingModel value);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="reservationId"></param>
        /// <param name="notes"></param>
        /// <returns>Task of Reservation</returns>
        System.Threading.Tasks.Task<Reservation> CancelReservationAsync (int? restaurantId, string reservationId, string notes);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="reservationId"></param>
        /// <param name="notes"></param>
        /// <returns>Task of ApiResponse (Reservation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Reservation>> CancelReservationAsyncWithHttpInfo (int? restaurantId, string reservationId, string notes);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="reservationId"></param>
        /// <returns>Task of Reservation</returns>
        System.Threading.Tasks.Task<Reservation> CloseAsNoShowAsync (int? restaurantId, string reservationId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="reservationId"></param>
        /// <returns>Task of ApiResponse (Reservation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Reservation>> CloseAsNoShowAsyncWithHttpInfo (int? restaurantId, string reservationId);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="reservationId"></param>
        /// <param name="tableNumber"> (optional)</param>
        /// <returns>Task of Reservation</returns>
        System.Threading.Tasks.Task<Reservation> CloseAsSeatedAsync (int? restaurantId, string reservationId, string tableNumber = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="reservationId"></param>
        /// <param name="tableNumber"> (optional)</param>
        /// <returns>Task of ApiResponse (Reservation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Reservation>> CloseAsSeatedAsyncWithHttpInfo (int? restaurantId, string reservationId, string tableNumber = null);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Task of ReservationSettings</returns>
        System.Threading.Tasks.Task<ReservationSettings> GeReservationSettingsAsync (int? restaurantId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Task of ApiResponse (ReservationSettings)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReservationSettings>> GeReservationSettingsAsyncWithHttpInfo (int? restaurantId);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="reservationId"></param>
        /// <returns>Task of List&lt;Message&gt;</returns>
        System.Threading.Tasks.Task<List<Message>> GetMessagesAsync (int? restaurantId, string reservationId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="reservationId"></param>
        /// <returns>Task of ApiResponse (List&lt;Message&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Message>>> GetMessagesAsyncWithHttpInfo (int? restaurantId, string reservationId);
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
        /// <param name="tableTurnOver"> (optional)</param>
        /// <param name="type"> (optional)</param>
        /// <param name="areas"> (optional)</param>
        /// <returns>Task of AvailabilityResponse</returns>
        System.Threading.Tasks.Task<AvailabilityResponse> GetReservationAvailabilityAsync (int? restaurantId, DateTimeOffset? date, int? partySize, int? rangeInMinutes, double? tableTurnOver = null, string type = null, string areas = null);

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
        /// <param name="tableTurnOver"> (optional)</param>
        /// <param name="type"> (optional)</param>
        /// <param name="areas"> (optional)</param>
        /// <returns>Task of ApiResponse (AvailabilityResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AvailabilityResponse>> GetReservationAvailabilityAsyncWithHttpInfo (int? restaurantId, DateTimeOffset? date, int? partySize, int? rangeInMinutes, double? tableTurnOver = null, string type = null, string areas = null);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="reservationId"></param>
        /// <returns>Task of Reservation</returns>
        System.Threading.Tasks.Task<Reservation> GetReservationByIdAsync (int? restaurantId, string reservationId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="reservationId"></param>
        /// <returns>Task of ApiResponse (Reservation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Reservation>> GetReservationByIdAsyncWithHttpInfo (int? restaurantId, string reservationId);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="from"> (optional)</param>
        /// <param name="to"> (optional)</param>
        /// <returns>Task of List&lt;Reservation&gt;</returns>
        System.Threading.Tasks.Task<List<Reservation>> GetReservationsForPeriodAsync (int? restaurantId, DateTimeOffset? from = null, DateTimeOffset? to = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="from"> (optional)</param>
        /// <param name="to"> (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Reservation&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Reservation>>> GetReservationsForPeriodAsyncWithHttpInfo (int? restaurantId, DateTimeOffset? from = null, DateTimeOffset? to = null);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Task of ReservationsStatistic</returns>
        System.Threading.Tasks.Task<ReservationsStatistic> GetRestaurantReservationsStatisticAsync (int? restaurantId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Task of ApiResponse (ReservationsStatistic)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReservationsStatistic>> GetRestaurantReservationsStatisticAsyncWithHttpInfo (int? restaurantId);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="from"> (optional)</param>
        /// <returns>Task of int?</returns>
        System.Threading.Tasks.Task<int?> GetUnreadMessagesCountAsync (int? restaurantId, DateTimeOffset? from = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="from"> (optional)</param>
        /// <returns>Task of ApiResponse (int?)</returns>
        System.Threading.Tasks.Task<ApiResponse<int?>> GetUnreadMessagesCountAsyncWithHttpInfo (int? restaurantId, DateTimeOffset? from = null);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="reservationId"></param>
        /// <returns>Task of WaitingItem</returns>
        System.Threading.Tasks.Task<WaitingItem> PlaceOnWaitListAsync (int? restaurantId, string reservationId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="reservationId"></param>
        /// <returns>Task of ApiResponse (WaitingItem)</returns>
        System.Threading.Tasks.Task<ApiResponse<WaitingItem>> PlaceOnWaitListAsyncWithHttpInfo (int? restaurantId, string reservationId);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="reservationId"></param>
        /// <returns>Task of Reservation</returns>
        System.Threading.Tasks.Task<Reservation> ReOpenReservationAsync (int? restaurantId, string reservationId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="reservationId"></param>
        /// <returns>Task of ApiResponse (Reservation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Reservation>> ReOpenReservationAsyncWithHttpInfo (int? restaurantId, string reservationId);
        /// <summary>
        /// Mark all message as read.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="reservationId">Reservation identifier</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> ReadAllMessageAsync (int? restaurantId, string reservationId);

        /// <summary>
        /// Mark all message as read.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="reservationId">Reservation identifier</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ReadAllMessageAsyncWithHttpInfo (int? restaurantId, string reservationId);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="from"></param>
        /// <param name="html"></param>
        /// <param name="text"></param>
        /// <param name="to"></param>
        /// <param name="subject"></param>
        /// <returns>Task of Reservation</returns>
        System.Threading.Tasks.Task<Reservation> SendGridAsync (string from, string html, string text, string to, string subject);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="from"></param>
        /// <param name="html"></param>
        /// <param name="text"></param>
        /// <param name="to"></param>
        /// <param name="subject"></param>
        /// <returns>Task of ApiResponse (Reservation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Reservation>> SendGridAsyncWithHttpInfo (string from, string html, string text, string to, string subject);
        /// <summary>
        /// Sends a message related to specified reservation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="reservationId">Reservation identifier</param>
        /// <param name="body">The body of the message</param>
        /// <returns>Task of Message</returns>
        System.Threading.Tasks.Task<Message> SendMessageAsync (int? restaurantId, string reservationId, string body);

        /// <summary>
        /// Sends a message related to specified reservation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="reservationId">Reservation identifier</param>
        /// <param name="body">The body of the message</param>
        /// <returns>Task of ApiResponse (Message)</returns>
        System.Threading.Tasks.Task<ApiResponse<Message>> SendMessageAsyncWithHttpInfo (int? restaurantId, string reservationId, string body);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="settings"></param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> SetReservationSettingsAsync (int? restaurantId, ReservationSettings settings);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="settings"></param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> SetReservationSettingsAsyncWithHttpInfo (int? restaurantId, ReservationSettings settings);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> SubmitYelpReservationAsync ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> SubmitYelpReservationAsyncWithHttpInfo ();
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="reservationId"></param>
        /// <param name="value"></param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> UpdateReservationAsync (int? restaurantId, string reservationId, AdminReservationBindingModel value);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="reservationId"></param>
        /// <param name="value"></param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateReservationAsyncWithHttpInfo (int? restaurantId, string reservationId, AdminReservationBindingModel value);
        #endregion Asynchronous Operations
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AdminReservationsApi : IAdminReservationsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdminReservationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AdminReservationsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AdminReservationsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AdminReservationsApi(Configuration configuration = null)
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
        public Reservation AddNewReservation (int? restaurantId, AdminReservationBindingModel value)
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
        public ApiResponse< Reservation > AddNewReservationWithHttpInfo (int? restaurantId, AdminReservationBindingModel value)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminReservationsApi->AddNewReservation");
            
            // verify the required parameter 'value' is set
            if (value == null)
                throw new ApiException(400, "Missing required parameter 'value' when calling AdminReservationsApi->AddNewReservation");
            
    
            var localVarPath = "/api/rsv/admin/restaurants/{restaurantId}/reservations";
    
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
        public async System.Threading.Tasks.Task<Reservation> AddNewReservationAsync (int? restaurantId, AdminReservationBindingModel value)
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
        public async System.Threading.Tasks.Task<ApiResponse<Reservation>> AddNewReservationAsyncWithHttpInfo (int? restaurantId, AdminReservationBindingModel value)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AddNewReservation");
            // verify the required parameter 'value' is set
            if (value == null) throw new ApiException(400, "Missing required parameter 'value' when calling AddNewReservation");
            
    
            var localVarPath = "/api/rsv/admin/restaurants/{restaurantId}/reservations";
    
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
        /// <param name="restaurantId"></param> 
        /// <param name="reservationId"></param> 
        /// <param name="notes"></param> 
        /// <returns>Reservation</returns>
        public Reservation CancelReservation (int? restaurantId, string reservationId, string notes)
        {
             ApiResponse<Reservation> localVarResponse = CancelReservationWithHttpInfo(restaurantId, reservationId, notes);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="reservationId"></param> 
        /// <param name="notes"></param> 
        /// <returns>ApiResponse of Reservation</returns>
        public ApiResponse< Reservation > CancelReservationWithHttpInfo (int? restaurantId, string reservationId, string notes)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminReservationsApi->CancelReservation");
            
            // verify the required parameter 'reservationId' is set
            if (reservationId == null)
                throw new ApiException(400, "Missing required parameter 'reservationId' when calling AdminReservationsApi->CancelReservation");
            
            // verify the required parameter 'notes' is set
            if (notes == null)
                throw new ApiException(400, "Missing required parameter 'notes' when calling AdminReservationsApi->CancelReservation");
            
    
            var localVarPath = "/api/rsv/admin/restaurants/{restaurantId}/reservations/{reservationId}/cancel";
    
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
if (reservationId != null) localVarPathParams.Add("reservationId", Configuration.ApiClient.ParameterToString(reservationId)); // path parameter
                                                if (notes.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(notes); // http body (model) parameter
            }
            else
            {
                localVarPostBody = notes; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling CancelReservation: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CancelReservation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Reservation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Reservation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Reservation)));
            
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="reservationId"></param>
        /// <param name="notes"></param>
        /// <returns>Task of Reservation</returns>
        public async System.Threading.Tasks.Task<Reservation> CancelReservationAsync (int? restaurantId, string reservationId, string notes)
        {
             ApiResponse<Reservation> localVarResponse = await CancelReservationAsyncWithHttpInfo(restaurantId, reservationId, notes);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="reservationId"></param>
        /// <param name="notes"></param>
        /// <returns>Task of ApiResponse (Reservation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Reservation>> CancelReservationAsyncWithHttpInfo (int? restaurantId, string reservationId, string notes)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling CancelReservation");
            // verify the required parameter 'reservationId' is set
            if (reservationId == null) throw new ApiException(400, "Missing required parameter 'reservationId' when calling CancelReservation");
            // verify the required parameter 'notes' is set
            if (notes == null) throw new ApiException(400, "Missing required parameter 'notes' when calling CancelReservation");
            
    
            var localVarPath = "/api/rsv/admin/restaurants/{restaurantId}/reservations/{reservationId}/cancel";
    
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
if (reservationId != null) localVarPathParams.Add("reservationId", Configuration.ApiClient.ParameterToString(reservationId)); // path parameter
                                                if (notes.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(notes); // http body (model) parameter
            }
            else
            {
                localVarPostBody = notes; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling CancelReservation: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CancelReservation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Reservation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Reservation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Reservation)));
            
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="reservationId"></param> 
        /// <returns>Reservation</returns>
        public Reservation CloseAsNoShow (int? restaurantId, string reservationId)
        {
             ApiResponse<Reservation> localVarResponse = CloseAsNoShowWithHttpInfo(restaurantId, reservationId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="reservationId"></param> 
        /// <returns>ApiResponse of Reservation</returns>
        public ApiResponse< Reservation > CloseAsNoShowWithHttpInfo (int? restaurantId, string reservationId)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminReservationsApi->CloseAsNoShow");
            
            // verify the required parameter 'reservationId' is set
            if (reservationId == null)
                throw new ApiException(400, "Missing required parameter 'reservationId' when calling AdminReservationsApi->CloseAsNoShow");
            
    
            var localVarPath = "/api/rsv/admin/restaurants/{restaurantId}/reservations/{reservationId}/noshow";
    
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
if (reservationId != null) localVarPathParams.Add("reservationId", Configuration.ApiClient.ParameterToString(reservationId)); // path parameter
                                                

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
                throw new ApiException (localVarStatusCode, "Error calling CloseAsNoShow: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CloseAsNoShow: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Reservation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Reservation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Reservation)));
            
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="reservationId"></param>
        /// <returns>Task of Reservation</returns>
        public async System.Threading.Tasks.Task<Reservation> CloseAsNoShowAsync (int? restaurantId, string reservationId)
        {
             ApiResponse<Reservation> localVarResponse = await CloseAsNoShowAsyncWithHttpInfo(restaurantId, reservationId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="reservationId"></param>
        /// <returns>Task of ApiResponse (Reservation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Reservation>> CloseAsNoShowAsyncWithHttpInfo (int? restaurantId, string reservationId)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling CloseAsNoShow");
            // verify the required parameter 'reservationId' is set
            if (reservationId == null) throw new ApiException(400, "Missing required parameter 'reservationId' when calling CloseAsNoShow");
            
    
            var localVarPath = "/api/rsv/admin/restaurants/{restaurantId}/reservations/{reservationId}/noshow";
    
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
if (reservationId != null) localVarPathParams.Add("reservationId", Configuration.ApiClient.ParameterToString(reservationId)); // path parameter
                                                

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
                throw new ApiException (localVarStatusCode, "Error calling CloseAsNoShow: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CloseAsNoShow: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Reservation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Reservation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Reservation)));
            
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="reservationId"></param> 
        /// <param name="tableNumber"> (optional)</param> 
        /// <returns>Reservation</returns>
        public Reservation CloseAsSeated (int? restaurantId, string reservationId, string tableNumber = null)
        {
             ApiResponse<Reservation> localVarResponse = CloseAsSeatedWithHttpInfo(restaurantId, reservationId, tableNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="reservationId"></param> 
        /// <param name="tableNumber"> (optional)</param> 
        /// <returns>ApiResponse of Reservation</returns>
        public ApiResponse< Reservation > CloseAsSeatedWithHttpInfo (int? restaurantId, string reservationId, string tableNumber = null)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminReservationsApi->CloseAsSeated");
            
            // verify the required parameter 'reservationId' is set
            if (reservationId == null)
                throw new ApiException(400, "Missing required parameter 'reservationId' when calling AdminReservationsApi->CloseAsSeated");
            
    
            var localVarPath = "/api/rsv/admin/restaurants/{restaurantId}/reservations/{reservationId}/seat";
    
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
if (reservationId != null) localVarPathParams.Add("reservationId", Configuration.ApiClient.ParameterToString(reservationId)); // path parameter
            if (tableNumber != null) localVarQueryParams.Add("tableNumber", Configuration.ApiClient.ParameterToString(tableNumber)); // query parameter
                                    

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
                throw new ApiException (localVarStatusCode, "Error calling CloseAsSeated: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CloseAsSeated: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Reservation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Reservation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Reservation)));
            
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="reservationId"></param>
        /// <param name="tableNumber"> (optional)</param>
        /// <returns>Task of Reservation</returns>
        public async System.Threading.Tasks.Task<Reservation> CloseAsSeatedAsync (int? restaurantId, string reservationId, string tableNumber = null)
        {
             ApiResponse<Reservation> localVarResponse = await CloseAsSeatedAsyncWithHttpInfo(restaurantId, reservationId, tableNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="reservationId"></param>
        /// <param name="tableNumber"> (optional)</param>
        /// <returns>Task of ApiResponse (Reservation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Reservation>> CloseAsSeatedAsyncWithHttpInfo (int? restaurantId, string reservationId, string tableNumber = null)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling CloseAsSeated");
            // verify the required parameter 'reservationId' is set
            if (reservationId == null) throw new ApiException(400, "Missing required parameter 'reservationId' when calling CloseAsSeated");
            
    
            var localVarPath = "/api/rsv/admin/restaurants/{restaurantId}/reservations/{reservationId}/seat";
    
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
if (reservationId != null) localVarPathParams.Add("reservationId", Configuration.ApiClient.ParameterToString(reservationId)); // path parameter
            if (tableNumber != null) localVarQueryParams.Add("tableNumber", Configuration.ApiClient.ParameterToString(tableNumber)); // query parameter
                                    

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
                throw new ApiException (localVarStatusCode, "Error calling CloseAsSeated: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CloseAsSeated: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Reservation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Reservation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Reservation)));
            
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <returns>ReservationSettings</returns>
        public ReservationSettings GeReservationSettings (int? restaurantId)
        {
             ApiResponse<ReservationSettings> localVarResponse = GeReservationSettingsWithHttpInfo(restaurantId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <returns>ApiResponse of ReservationSettings</returns>
        public ApiResponse< ReservationSettings > GeReservationSettingsWithHttpInfo (int? restaurantId)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminReservationsApi->GeReservationSettings");
            
    
            var localVarPath = "/api/rsv/admin/restaurants/{restaurantId}/settings";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GeReservationSettings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GeReservationSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ReservationSettings>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReservationSettings) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReservationSettings)));
            
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Task of ReservationSettings</returns>
        public async System.Threading.Tasks.Task<ReservationSettings> GeReservationSettingsAsync (int? restaurantId)
        {
             ApiResponse<ReservationSettings> localVarResponse = await GeReservationSettingsAsyncWithHttpInfo(restaurantId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Task of ApiResponse (ReservationSettings)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReservationSettings>> GeReservationSettingsAsyncWithHttpInfo (int? restaurantId)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling GeReservationSettings");
            
    
            var localVarPath = "/api/rsv/admin/restaurants/{restaurantId}/settings";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GeReservationSettings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GeReservationSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReservationSettings>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReservationSettings) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReservationSettings)));
            
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="reservationId"></param> 
        /// <returns>List&lt;Message&gt;</returns>
        public List<Message> GetMessages (int? restaurantId, string reservationId)
        {
             ApiResponse<List<Message>> localVarResponse = GetMessagesWithHttpInfo(restaurantId, reservationId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="reservationId"></param> 
        /// <returns>ApiResponse of List&lt;Message&gt;</returns>
        public ApiResponse< List<Message> > GetMessagesWithHttpInfo (int? restaurantId, string reservationId)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminReservationsApi->GetMessages");
            
            // verify the required parameter 'reservationId' is set
            if (reservationId == null)
                throw new ApiException(400, "Missing required parameter 'reservationId' when calling AdminReservationsApi->GetMessages");
            
    
            var localVarPath = "/api/rsv/admin/restaurants/{restaurantId}/reservations/{reservationId}/messages";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetMessages: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<Message>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Message>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Message>)));
            
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="reservationId"></param>
        /// <returns>Task of List&lt;Message&gt;</returns>
        public async System.Threading.Tasks.Task<List<Message>> GetMessagesAsync (int? restaurantId, string reservationId)
        {
             ApiResponse<List<Message>> localVarResponse = await GetMessagesAsyncWithHttpInfo(restaurantId, reservationId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="reservationId"></param>
        /// <returns>Task of ApiResponse (List&lt;Message&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Message>>> GetMessagesAsyncWithHttpInfo (int? restaurantId, string reservationId)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling GetMessages");
            // verify the required parameter 'reservationId' is set
            if (reservationId == null) throw new ApiException(400, "Missing required parameter 'reservationId' when calling GetMessages");
            
    
            var localVarPath = "/api/rsv/admin/restaurants/{restaurantId}/reservations/{reservationId}/messages";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetMessages: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Message>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Message>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Message>)));
            
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="date"></param> 
        /// <param name="partySize"></param> 
        /// <param name="rangeInMinutes"></param> 
        /// <param name="tableTurnOver"> (optional)</param> 
        /// <param name="type"> (optional)</param> 
        /// <param name="areas"> (optional)</param> 
        /// <returns>AvailabilityResponse</returns>
        public AvailabilityResponse GetReservationAvailability (int? restaurantId, DateTimeOffset? date, int? partySize, int? rangeInMinutes, double? tableTurnOver = null, string type = null, string areas = null)
        {
             ApiResponse<AvailabilityResponse> localVarResponse = GetReservationAvailabilityWithHttpInfo(restaurantId, date, partySize, rangeInMinutes, tableTurnOver, type, areas);
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
        /// <param name="tableTurnOver"> (optional)</param> 
        /// <param name="type"> (optional)</param> 
        /// <param name="areas"> (optional)</param> 
        /// <returns>ApiResponse of AvailabilityResponse</returns>
        public ApiResponse< AvailabilityResponse > GetReservationAvailabilityWithHttpInfo (int? restaurantId, DateTimeOffset? date, int? partySize, int? rangeInMinutes, double? tableTurnOver = null, string type = null, string areas = null)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminReservationsApi->GetReservationAvailability");
            
            // verify the required parameter 'date' is set
            if (date == null)
                throw new ApiException(400, "Missing required parameter 'date' when calling AdminReservationsApi->GetReservationAvailability");
            
            // verify the required parameter 'partySize' is set
            if (partySize == null)
                throw new ApiException(400, "Missing required parameter 'partySize' when calling AdminReservationsApi->GetReservationAvailability");
            
            // verify the required parameter 'rangeInMinutes' is set
            if (rangeInMinutes == null)
                throw new ApiException(400, "Missing required parameter 'rangeInMinutes' when calling AdminReservationsApi->GetReservationAvailability");
            
    
            var localVarPath = "/api/rsv/admin/restaurants/{restaurantId}/availability";
    
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
if (tableTurnOver != null) localVarQueryParams.Add("tableTurnOver", Configuration.ApiClient.ParameterToString(tableTurnOver)); // query parameter
if (type != null) localVarQueryParams.Add("type", Configuration.ApiClient.ParameterToString(type)); // query parameter
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
    
            return new ApiResponse<AvailabilityResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AvailabilityResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AvailabilityResponse)));
            
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="date"></param>
        /// <param name="partySize"></param>
        /// <param name="rangeInMinutes"></param>
        /// <param name="tableTurnOver"> (optional)</param>
        /// <param name="type"> (optional)</param>
        /// <param name="areas"> (optional)</param>
        /// <returns>Task of AvailabilityResponse</returns>
        public async System.Threading.Tasks.Task<AvailabilityResponse> GetReservationAvailabilityAsync (int? restaurantId, DateTimeOffset? date, int? partySize, int? rangeInMinutes, double? tableTurnOver = null, string type = null, string areas = null)
        {
             ApiResponse<AvailabilityResponse> localVarResponse = await GetReservationAvailabilityAsyncWithHttpInfo(restaurantId, date, partySize, rangeInMinutes, tableTurnOver, type, areas);
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
        /// <param name="tableTurnOver"> (optional)</param>
        /// <param name="type"> (optional)</param>
        /// <param name="areas"> (optional)</param>
        /// <returns>Task of ApiResponse (AvailabilityResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AvailabilityResponse>> GetReservationAvailabilityAsyncWithHttpInfo (int? restaurantId, DateTimeOffset? date, int? partySize, int? rangeInMinutes, double? tableTurnOver = null, string type = null, string areas = null)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling GetReservationAvailability");
            // verify the required parameter 'date' is set
            if (date == null) throw new ApiException(400, "Missing required parameter 'date' when calling GetReservationAvailability");
            // verify the required parameter 'partySize' is set
            if (partySize == null) throw new ApiException(400, "Missing required parameter 'partySize' when calling GetReservationAvailability");
            // verify the required parameter 'rangeInMinutes' is set
            if (rangeInMinutes == null) throw new ApiException(400, "Missing required parameter 'rangeInMinutes' when calling GetReservationAvailability");
            
    
            var localVarPath = "/api/rsv/admin/restaurants/{restaurantId}/availability";
    
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
if (tableTurnOver != null) localVarQueryParams.Add("tableTurnOver", Configuration.ApiClient.ParameterToString(tableTurnOver)); // query parameter
if (type != null) localVarQueryParams.Add("type", Configuration.ApiClient.ParameterToString(type)); // query parameter
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

            return new ApiResponse<AvailabilityResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AvailabilityResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AvailabilityResponse)));
            
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="reservationId"></param> 
        /// <returns>Reservation</returns>
        public Reservation GetReservationById (int? restaurantId, string reservationId)
        {
             ApiResponse<Reservation> localVarResponse = GetReservationByIdWithHttpInfo(restaurantId, reservationId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="reservationId"></param> 
        /// <returns>ApiResponse of Reservation</returns>
        public ApiResponse< Reservation > GetReservationByIdWithHttpInfo (int? restaurantId, string reservationId)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminReservationsApi->GetReservationById");
            
            // verify the required parameter 'reservationId' is set
            if (reservationId == null)
                throw new ApiException(400, "Missing required parameter 'reservationId' when calling AdminReservationsApi->GetReservationById");
            
    
            var localVarPath = "/api/rsv/admin/restaurants/{restaurantId}/reservations/{reservationId}";
    
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
        /// <param name="restaurantId"></param>
        /// <param name="reservationId"></param>
        /// <returns>Task of Reservation</returns>
        public async System.Threading.Tasks.Task<Reservation> GetReservationByIdAsync (int? restaurantId, string reservationId)
        {
             ApiResponse<Reservation> localVarResponse = await GetReservationByIdAsyncWithHttpInfo(restaurantId, reservationId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="reservationId"></param>
        /// <returns>Task of ApiResponse (Reservation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Reservation>> GetReservationByIdAsyncWithHttpInfo (int? restaurantId, string reservationId)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling GetReservationById");
            // verify the required parameter 'reservationId' is set
            if (reservationId == null) throw new ApiException(400, "Missing required parameter 'reservationId' when calling GetReservationById");
            
    
            var localVarPath = "/api/rsv/admin/restaurants/{restaurantId}/reservations/{reservationId}";
    
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
        /// <param name="restaurantId"></param> 
        /// <param name="from"> (optional)</param> 
        /// <param name="to"> (optional)</param> 
        /// <returns>List&lt;Reservation&gt;</returns>
        public List<Reservation> GetReservationsForPeriod (int? restaurantId, DateTimeOffset? from = null, DateTimeOffset? to = null)
        {
             ApiResponse<List<Reservation>> localVarResponse = GetReservationsForPeriodWithHttpInfo(restaurantId, from, to);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="from"> (optional)</param> 
        /// <param name="to"> (optional)</param> 
        /// <returns>ApiResponse of List&lt;Reservation&gt;</returns>
        public ApiResponse< List<Reservation> > GetReservationsForPeriodWithHttpInfo (int? restaurantId, DateTimeOffset? from = null, DateTimeOffset? to = null)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminReservationsApi->GetReservationsForPeriod");
            
    
            var localVarPath = "/api/rsv/admin/restaurants/{restaurantId}/reservations";
    
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
            if (from != null) localVarQueryParams.Add("from", Configuration.ApiClient.ParameterToString(from)); // query parameter
if (to != null) localVarQueryParams.Add("to", Configuration.ApiClient.ParameterToString(to)); // query parameter
                                    

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
                throw new ApiException (localVarStatusCode, "Error calling GetReservationsForPeriod: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetReservationsForPeriod: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<Reservation>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Reservation>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Reservation>)));
            
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="from"> (optional)</param>
        /// <param name="to"> (optional)</param>
        /// <returns>Task of List&lt;Reservation&gt;</returns>
        public async System.Threading.Tasks.Task<List<Reservation>> GetReservationsForPeriodAsync (int? restaurantId, DateTimeOffset? from = null, DateTimeOffset? to = null)
        {
             ApiResponse<List<Reservation>> localVarResponse = await GetReservationsForPeriodAsyncWithHttpInfo(restaurantId, from, to);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="from"> (optional)</param>
        /// <param name="to"> (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Reservation&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Reservation>>> GetReservationsForPeriodAsyncWithHttpInfo (int? restaurantId, DateTimeOffset? from = null, DateTimeOffset? to = null)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling GetReservationsForPeriod");
            
    
            var localVarPath = "/api/rsv/admin/restaurants/{restaurantId}/reservations";
    
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
            if (from != null) localVarQueryParams.Add("from", Configuration.ApiClient.ParameterToString(from)); // query parameter
if (to != null) localVarQueryParams.Add("to", Configuration.ApiClient.ParameterToString(to)); // query parameter
                                    

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
                throw new ApiException (localVarStatusCode, "Error calling GetReservationsForPeriod: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetReservationsForPeriod: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Reservation>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Reservation>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Reservation>)));
            
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <returns>ReservationsStatistic</returns>
        public ReservationsStatistic GetRestaurantReservationsStatistic (int? restaurantId)
        {
             ApiResponse<ReservationsStatistic> localVarResponse = GetRestaurantReservationsStatisticWithHttpInfo(restaurantId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <returns>ApiResponse of ReservationsStatistic</returns>
        public ApiResponse< ReservationsStatistic > GetRestaurantReservationsStatisticWithHttpInfo (int? restaurantId)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminReservationsApi->GetRestaurantReservationsStatistic");
            
    
            var localVarPath = "/api/rsv/admin/restaurants/{restaurantId}/reservations/stats";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetRestaurantReservationsStatistic: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRestaurantReservationsStatistic: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ReservationsStatistic>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReservationsStatistic) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReservationsStatistic)));
            
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Task of ReservationsStatistic</returns>
        public async System.Threading.Tasks.Task<ReservationsStatistic> GetRestaurantReservationsStatisticAsync (int? restaurantId)
        {
             ApiResponse<ReservationsStatistic> localVarResponse = await GetRestaurantReservationsStatisticAsyncWithHttpInfo(restaurantId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Task of ApiResponse (ReservationsStatistic)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReservationsStatistic>> GetRestaurantReservationsStatisticAsyncWithHttpInfo (int? restaurantId)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling GetRestaurantReservationsStatistic");
            
    
            var localVarPath = "/api/rsv/admin/restaurants/{restaurantId}/reservations/stats";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetRestaurantReservationsStatistic: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRestaurantReservationsStatistic: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReservationsStatistic>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReservationsStatistic) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReservationsStatistic)));
            
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="from"> (optional)</param> 
        /// <returns>int?</returns>
        public int? GetUnreadMessagesCount (int? restaurantId, DateTimeOffset? from = null)
        {
             ApiResponse<int?> localVarResponse = GetUnreadMessagesCountWithHttpInfo(restaurantId, from);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="from"> (optional)</param> 
        /// <returns>ApiResponse of int?</returns>
        public ApiResponse< int? > GetUnreadMessagesCountWithHttpInfo (int? restaurantId, DateTimeOffset? from = null)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminReservationsApi->GetUnreadMessagesCount");
            
    
            var localVarPath = "/api/rsv/admin/restaurants/{restaurantId}/reservations/messages/count-unread";
    
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
            if (from != null) localVarQueryParams.Add("from", Configuration.ApiClient.ParameterToString(from)); // query parameter
                                    

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
                throw new ApiException (localVarStatusCode, "Error calling GetUnreadMessagesCount: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUnreadMessagesCount: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<int?>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (int?) Configuration.ApiClient.Deserialize(localVarResponse, typeof(int?)));
            
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="from"> (optional)</param>
        /// <returns>Task of int?</returns>
        public async System.Threading.Tasks.Task<int?> GetUnreadMessagesCountAsync (int? restaurantId, DateTimeOffset? from = null)
        {
             ApiResponse<int?> localVarResponse = await GetUnreadMessagesCountAsyncWithHttpInfo(restaurantId, from);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="from"> (optional)</param>
        /// <returns>Task of ApiResponse (int?)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<int?>> GetUnreadMessagesCountAsyncWithHttpInfo (int? restaurantId, DateTimeOffset? from = null)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling GetUnreadMessagesCount");
            
    
            var localVarPath = "/api/rsv/admin/restaurants/{restaurantId}/reservations/messages/count-unread";
    
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
            if (from != null) localVarQueryParams.Add("from", Configuration.ApiClient.ParameterToString(from)); // query parameter
                                    

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
                throw new ApiException (localVarStatusCode, "Error calling GetUnreadMessagesCount: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUnreadMessagesCount: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<int?>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (int?) Configuration.ApiClient.Deserialize(localVarResponse, typeof(int?)));
            
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="reservationId"></param> 
        /// <returns>WaitingItem</returns>
        public WaitingItem PlaceOnWaitList (int? restaurantId, string reservationId)
        {
             ApiResponse<WaitingItem> localVarResponse = PlaceOnWaitListWithHttpInfo(restaurantId, reservationId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="reservationId"></param> 
        /// <returns>ApiResponse of WaitingItem</returns>
        public ApiResponse< WaitingItem > PlaceOnWaitListWithHttpInfo (int? restaurantId, string reservationId)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminReservationsApi->PlaceOnWaitList");
            
            // verify the required parameter 'reservationId' is set
            if (reservationId == null)
                throw new ApiException(400, "Missing required parameter 'reservationId' when calling AdminReservationsApi->PlaceOnWaitList");
            
    
            var localVarPath = "/api/rsv/admin/restaurants/{restaurantId}/reservations/{reservationId}/schedule";
    
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
if (reservationId != null) localVarPathParams.Add("reservationId", Configuration.ApiClient.ParameterToString(reservationId)); // path parameter
                                                

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
                throw new ApiException (localVarStatusCode, "Error calling PlaceOnWaitList: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PlaceOnWaitList: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<WaitingItem>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WaitingItem) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WaitingItem)));
            
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="reservationId"></param>
        /// <returns>Task of WaitingItem</returns>
        public async System.Threading.Tasks.Task<WaitingItem> PlaceOnWaitListAsync (int? restaurantId, string reservationId)
        {
             ApiResponse<WaitingItem> localVarResponse = await PlaceOnWaitListAsyncWithHttpInfo(restaurantId, reservationId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="reservationId"></param>
        /// <returns>Task of ApiResponse (WaitingItem)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WaitingItem>> PlaceOnWaitListAsyncWithHttpInfo (int? restaurantId, string reservationId)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling PlaceOnWaitList");
            // verify the required parameter 'reservationId' is set
            if (reservationId == null) throw new ApiException(400, "Missing required parameter 'reservationId' when calling PlaceOnWaitList");
            
    
            var localVarPath = "/api/rsv/admin/restaurants/{restaurantId}/reservations/{reservationId}/schedule";
    
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
if (reservationId != null) localVarPathParams.Add("reservationId", Configuration.ApiClient.ParameterToString(reservationId)); // path parameter
                                                

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
                throw new ApiException (localVarStatusCode, "Error calling PlaceOnWaitList: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PlaceOnWaitList: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WaitingItem>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WaitingItem) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WaitingItem)));
            
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="reservationId"></param> 
        /// <returns>Reservation</returns>
        public Reservation ReOpenReservation (int? restaurantId, string reservationId)
        {
             ApiResponse<Reservation> localVarResponse = ReOpenReservationWithHttpInfo(restaurantId, reservationId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="reservationId"></param> 
        /// <returns>ApiResponse of Reservation</returns>
        public ApiResponse< Reservation > ReOpenReservationWithHttpInfo (int? restaurantId, string reservationId)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminReservationsApi->ReOpenReservation");
            
            // verify the required parameter 'reservationId' is set
            if (reservationId == null)
                throw new ApiException(400, "Missing required parameter 'reservationId' when calling AdminReservationsApi->ReOpenReservation");
            
    
            var localVarPath = "/api/rsv/admin/restaurants/{restaurantId}/reservations/{reservationId}/reopen";
    
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
if (reservationId != null) localVarPathParams.Add("reservationId", Configuration.ApiClient.ParameterToString(reservationId)); // path parameter
                                                

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
                throw new ApiException (localVarStatusCode, "Error calling ReOpenReservation: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ReOpenReservation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Reservation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Reservation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Reservation)));
            
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="reservationId"></param>
        /// <returns>Task of Reservation</returns>
        public async System.Threading.Tasks.Task<Reservation> ReOpenReservationAsync (int? restaurantId, string reservationId)
        {
             ApiResponse<Reservation> localVarResponse = await ReOpenReservationAsyncWithHttpInfo(restaurantId, reservationId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="reservationId"></param>
        /// <returns>Task of ApiResponse (Reservation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Reservation>> ReOpenReservationAsyncWithHttpInfo (int? restaurantId, string reservationId)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling ReOpenReservation");
            // verify the required parameter 'reservationId' is set
            if (reservationId == null) throw new ApiException(400, "Missing required parameter 'reservationId' when calling ReOpenReservation");
            
    
            var localVarPath = "/api/rsv/admin/restaurants/{restaurantId}/reservations/{reservationId}/reopen";
    
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
if (reservationId != null) localVarPathParams.Add("reservationId", Configuration.ApiClient.ParameterToString(reservationId)); // path parameter
                                                

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
                throw new ApiException (localVarStatusCode, "Error calling ReOpenReservation: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ReOpenReservation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Reservation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Reservation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Reservation)));
            
        }
        /// <summary>
        /// Mark all message as read. 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param> 
        /// <param name="reservationId">Reservation identifier</param> 
        /// <returns>Object</returns>
        public Object ReadAllMessage (int? restaurantId, string reservationId)
        {
             ApiResponse<Object> localVarResponse = ReadAllMessageWithHttpInfo(restaurantId, reservationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Mark all message as read. 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param> 
        /// <param name="reservationId">Reservation identifier</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > ReadAllMessageWithHttpInfo (int? restaurantId, string reservationId)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminReservationsApi->ReadAllMessage");
            
            // verify the required parameter 'reservationId' is set
            if (reservationId == null)
                throw new ApiException(400, "Missing required parameter 'reservationId' when calling AdminReservationsApi->ReadAllMessage");
            
    
            var localVarPath = "/api/rsv/admin/restaurants/{restaurantId}/reservations/{reservationId}/messages/readall";
    
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
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        /// <summary>
        /// Mark all message as read. 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="reservationId">Reservation identifier</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> ReadAllMessageAsync (int? restaurantId, string reservationId)
        {
             ApiResponse<Object> localVarResponse = await ReadAllMessageAsyncWithHttpInfo(restaurantId, reservationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Mark all message as read. 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="reservationId">Reservation identifier</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ReadAllMessageAsyncWithHttpInfo (int? restaurantId, string reservationId)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling ReadAllMessage");
            // verify the required parameter 'reservationId' is set
            if (reservationId == null) throw new ApiException(400, "Missing required parameter 'reservationId' when calling ReadAllMessage");
            
    
            var localVarPath = "/api/rsv/admin/restaurants/{restaurantId}/reservations/{reservationId}/messages/readall";
    
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
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="from"></param> 
        /// <param name="html"></param> 
        /// <param name="text"></param> 
        /// <param name="to"></param> 
        /// <param name="subject"></param> 
        /// <returns>Reservation</returns>
        public Reservation SendGrid (string from, string html, string text, string to, string subject)
        {
             ApiResponse<Reservation> localVarResponse = SendGridWithHttpInfo(from, html, text, to, subject);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="from"></param> 
        /// <param name="html"></param> 
        /// <param name="text"></param> 
        /// <param name="to"></param> 
        /// <param name="subject"></param> 
        /// <returns>ApiResponse of Reservation</returns>
        public ApiResponse< Reservation > SendGridWithHttpInfo (string from, string html, string text, string to, string subject)
        {
            
            // verify the required parameter 'from' is set
            if (from == null)
                throw new ApiException(400, "Missing required parameter 'from' when calling AdminReservationsApi->SendGrid");
            
            // verify the required parameter 'html' is set
            if (html == null)
                throw new ApiException(400, "Missing required parameter 'html' when calling AdminReservationsApi->SendGrid");
            
            // verify the required parameter 'text' is set
            if (text == null)
                throw new ApiException(400, "Missing required parameter 'text' when calling AdminReservationsApi->SendGrid");
            
            // verify the required parameter 'to' is set
            if (to == null)
                throw new ApiException(400, "Missing required parameter 'to' when calling AdminReservationsApi->SendGrid");
            
            // verify the required parameter 'subject' is set
            if (subject == null)
                throw new ApiException(400, "Missing required parameter 'subject' when calling AdminReservationsApi->SendGrid");
            
    
            var localVarPath = "/api/rsv/admin/email/yelp";
    
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
                        if (from != null) localVarQueryParams.Add("from", Configuration.ApiClient.ParameterToString(from)); // query parameter
if (html != null) localVarQueryParams.Add("html", Configuration.ApiClient.ParameterToString(html)); // query parameter
if (text != null) localVarQueryParams.Add("text", Configuration.ApiClient.ParameterToString(text)); // query parameter
if (to != null) localVarQueryParams.Add("to", Configuration.ApiClient.ParameterToString(to)); // query parameter
if (subject != null) localVarQueryParams.Add("subject", Configuration.ApiClient.ParameterToString(subject)); // query parameter
                                    

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
                throw new ApiException (localVarStatusCode, "Error calling SendGrid: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SendGrid: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Reservation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Reservation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Reservation)));
            
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="from"></param>
        /// <param name="html"></param>
        /// <param name="text"></param>
        /// <param name="to"></param>
        /// <param name="subject"></param>
        /// <returns>Task of Reservation</returns>
        public async System.Threading.Tasks.Task<Reservation> SendGridAsync (string from, string html, string text, string to, string subject)
        {
             ApiResponse<Reservation> localVarResponse = await SendGridAsyncWithHttpInfo(from, html, text, to, subject);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="from"></param>
        /// <param name="html"></param>
        /// <param name="text"></param>
        /// <param name="to"></param>
        /// <param name="subject"></param>
        /// <returns>Task of ApiResponse (Reservation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Reservation>> SendGridAsyncWithHttpInfo (string from, string html, string text, string to, string subject)
        {
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling SendGrid");
            // verify the required parameter 'html' is set
            if (html == null) throw new ApiException(400, "Missing required parameter 'html' when calling SendGrid");
            // verify the required parameter 'text' is set
            if (text == null) throw new ApiException(400, "Missing required parameter 'text' when calling SendGrid");
            // verify the required parameter 'to' is set
            if (to == null) throw new ApiException(400, "Missing required parameter 'to' when calling SendGrid");
            // verify the required parameter 'subject' is set
            if (subject == null) throw new ApiException(400, "Missing required parameter 'subject' when calling SendGrid");
            
    
            var localVarPath = "/api/rsv/admin/email/yelp";
    
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
                        if (from != null) localVarQueryParams.Add("from", Configuration.ApiClient.ParameterToString(from)); // query parameter
if (html != null) localVarQueryParams.Add("html", Configuration.ApiClient.ParameterToString(html)); // query parameter
if (text != null) localVarQueryParams.Add("text", Configuration.ApiClient.ParameterToString(text)); // query parameter
if (to != null) localVarQueryParams.Add("to", Configuration.ApiClient.ParameterToString(to)); // query parameter
if (subject != null) localVarQueryParams.Add("subject", Configuration.ApiClient.ParameterToString(subject)); // query parameter
                                    

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
                throw new ApiException (localVarStatusCode, "Error calling SendGrid: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SendGrid: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Reservation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Reservation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Reservation)));
            
        }
        /// <summary>
        /// Sends a message related to specified reservation. 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param> 
        /// <param name="reservationId">Reservation identifier</param> 
        /// <param name="body">The body of the message</param> 
        /// <returns>Message</returns>
        public Message SendMessage (int? restaurantId, string reservationId, string body)
        {
             ApiResponse<Message> localVarResponse = SendMessageWithHttpInfo(restaurantId, reservationId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Sends a message related to specified reservation. 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param> 
        /// <param name="reservationId">Reservation identifier</param> 
        /// <param name="body">The body of the message</param> 
        /// <returns>ApiResponse of Message</returns>
        public ApiResponse< Message > SendMessageWithHttpInfo (int? restaurantId, string reservationId, string body)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminReservationsApi->SendMessage");
            
            // verify the required parameter 'reservationId' is set
            if (reservationId == null)
                throw new ApiException(400, "Missing required parameter 'reservationId' when calling AdminReservationsApi->SendMessage");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AdminReservationsApi->SendMessage");
            
    
            var localVarPath = "/api/rsv/admin/restaurants/{restaurantId}/reservations/{reservationId}/messages";
    
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
if (reservationId != null) localVarPathParams.Add("reservationId", Configuration.ApiClient.ParameterToString(reservationId)); // path parameter
                                                if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling SendMessage: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SendMessage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Message>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Message) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Message)));
            
        }

        /// <summary>
        /// Sends a message related to specified reservation. 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="reservationId">Reservation identifier</param>
        /// <param name="body">The body of the message</param>
        /// <returns>Task of Message</returns>
        public async System.Threading.Tasks.Task<Message> SendMessageAsync (int? restaurantId, string reservationId, string body)
        {
             ApiResponse<Message> localVarResponse = await SendMessageAsyncWithHttpInfo(restaurantId, reservationId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Sends a message related to specified reservation. 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="reservationId">Reservation identifier</param>
        /// <param name="body">The body of the message</param>
        /// <returns>Task of ApiResponse (Message)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Message>> SendMessageAsyncWithHttpInfo (int? restaurantId, string reservationId, string body)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling SendMessage");
            // verify the required parameter 'reservationId' is set
            if (reservationId == null) throw new ApiException(400, "Missing required parameter 'reservationId' when calling SendMessage");
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling SendMessage");
            
    
            var localVarPath = "/api/rsv/admin/restaurants/{restaurantId}/reservations/{reservationId}/messages";
    
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
if (reservationId != null) localVarPathParams.Add("reservationId", Configuration.ApiClient.ParameterToString(reservationId)); // path parameter
                                                if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling SendMessage: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SendMessage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Message>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Message) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Message)));
            
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="settings"></param> 
        /// <returns>Object</returns>
        public Object SetReservationSettings (int? restaurantId, ReservationSettings settings)
        {
             ApiResponse<Object> localVarResponse = SetReservationSettingsWithHttpInfo(restaurantId, settings);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="settings"></param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > SetReservationSettingsWithHttpInfo (int? restaurantId, ReservationSettings settings)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminReservationsApi->SetReservationSettings");
            
            // verify the required parameter 'settings' is set
            if (settings == null)
                throw new ApiException(400, "Missing required parameter 'settings' when calling AdminReservationsApi->SetReservationSettings");
            
    
            var localVarPath = "/api/rsv/admin/restaurants/{restaurantId}/settings";
    
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
                                                if (settings.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(settings); // http body (model) parameter
            }
            else
            {
                localVarPostBody = settings; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling SetReservationSettings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SetReservationSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="settings"></param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> SetReservationSettingsAsync (int? restaurantId, ReservationSettings settings)
        {
             ApiResponse<Object> localVarResponse = await SetReservationSettingsAsyncWithHttpInfo(restaurantId, settings);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="settings"></param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> SetReservationSettingsAsyncWithHttpInfo (int? restaurantId, ReservationSettings settings)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling SetReservationSettings");
            // verify the required parameter 'settings' is set
            if (settings == null) throw new ApiException(400, "Missing required parameter 'settings' when calling SetReservationSettings");
            
    
            var localVarPath = "/api/rsv/admin/restaurants/{restaurantId}/settings";
    
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
                                                if (settings.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(settings); // http body (model) parameter
            }
            else
            {
                localVarPostBody = settings; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling SetReservationSettings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SetReservationSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Object</returns>
        public Object SubmitYelpReservation ()
        {
             ApiResponse<Object> localVarResponse = SubmitYelpReservationWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > SubmitYelpReservationWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/rsv/admin/email/yelp/inbound";
    
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SubmitYelpReservation: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SubmitYelpReservation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> SubmitYelpReservationAsync ()
        {
             ApiResponse<Object> localVarResponse = await SubmitYelpReservationAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> SubmitYelpReservationAsyncWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/rsv/admin/email/yelp/inbound";
    
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SubmitYelpReservation: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SubmitYelpReservation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="reservationId"></param> 
        /// <param name="value"></param> 
        /// <returns>Object</returns>
        public Object UpdateReservation (int? restaurantId, string reservationId, AdminReservationBindingModel value)
        {
             ApiResponse<Object> localVarResponse = UpdateReservationWithHttpInfo(restaurantId, reservationId, value);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="reservationId"></param> 
        /// <param name="value"></param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > UpdateReservationWithHttpInfo (int? restaurantId, string reservationId, AdminReservationBindingModel value)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminReservationsApi->UpdateReservation");
            
            // verify the required parameter 'reservationId' is set
            if (reservationId == null)
                throw new ApiException(400, "Missing required parameter 'reservationId' when calling AdminReservationsApi->UpdateReservation");
            
            // verify the required parameter 'value' is set
            if (value == null)
                throw new ApiException(400, "Missing required parameter 'value' when calling AdminReservationsApi->UpdateReservation");
            
    
            var localVarPath = "/api/rsv/admin/restaurants/{restaurantId}/reservations/{reservationId}";
    
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
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="reservationId"></param>
        /// <param name="value"></param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> UpdateReservationAsync (int? restaurantId, string reservationId, AdminReservationBindingModel value)
        {
             ApiResponse<Object> localVarResponse = await UpdateReservationAsyncWithHttpInfo(restaurantId, reservationId, value);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="reservationId"></param>
        /// <param name="value"></param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateReservationAsyncWithHttpInfo (int? restaurantId, string reservationId, AdminReservationBindingModel value)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling UpdateReservation");
            // verify the required parameter 'reservationId' is set
            if (reservationId == null) throw new ApiException(400, "Missing required parameter 'reservationId' when calling UpdateReservation");
            // verify the required parameter 'value' is set
            if (value == null) throw new ApiException(400, "Missing required parameter 'value' when calling UpdateReservation");
            
    
            var localVarPath = "/api/rsv/admin/restaurants/{restaurantId}/reservations/{reservationId}";
    
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
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
    }
}
