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
    public interface IAdminWaitlistApi
    {
        #region Synchronous Operations
        /// <summary>
        /// Preregister customer for the specified restaurant and returns waiting record with Confirmation Code. Use this method when  customer is going to use HostMe mobile application.\r\n            This registration requires customer confirmation by entering confirmation number.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Identifier of the restaurant registered in our system</param>
        /// <returns>WaitingItem</returns>
        WaitingItem AddNewWaiting (int? restaurantId);
  
        /// <summary>
        /// Preregister customer for the specified restaurant and returns waiting record with Confirmation Code. Use this method when  customer is going to use HostMe mobile application.\r\n            This registration requires customer confirmation by entering confirmation number.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Identifier of the restaurant registered in our system</param>
        /// <returns>ApiResponse of WaitingItem</returns>
        ApiResponse<WaitingItem> AddNewWaitingWithHttpInfo (int? restaurantId);
        /// <summary>
        /// When table is ready hostess originates Call event. It notifies client that table is ready
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <param name="tableNumber">Number of the table (optional)</param>
        /// <returns></returns>
        void CallWaitingParty (int? restaurantId, int? waitingItemId, string tableNumber);
  
        /// <summary>
        /// When table is ready hostess originates Call event. It notifies client that table is ready
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <param name="tableNumber">Number of the table (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CallWaitingPartyWithHttpInfo (int? restaurantId, int? waitingItemId, string tableNumber);
        /// <summary>
        /// Closes current waiting position. When person gets a table, hostess should close current position.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Identifier of the waiting item</param>
        /// <returns></returns>
        void Close (int? restaurantId, int? waitingItemId);
  
        /// <summary>
        /// Closes current waiting position. When person gets a table, hostess should close current position.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Identifier of the waiting item</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CloseWithHttpInfo (int? restaurantId, int? waitingItemId);
        /// <summary>
        /// Cancel waiting item
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <param name="origin">This parameter specifies who send the message. It could be host or client.</param>
        /// <param name="comment">Free text comment, such as \&quot;Sorry but it was to long wait, we decided to go to another restaurant.\&quot;</param>
        /// <returns></returns>
        void CloseAsCanceled (int? restaurantId, int? waitingItemId, string origin, string comment);
  
        /// <summary>
        /// Cancel waiting item
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <param name="origin">This parameter specifies who send the message. It could be host or client.</param>
        /// <param name="comment">Free text comment, such as \&quot;Sorry but it was to long wait, we decided to go to another restaurant.\&quot;</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CloseAsCanceledWithHttpInfo (int? restaurantId, int? waitingItemId, string origin, string comment);
        /// <summary>
        /// Set current waiting record in sited state. When person gets a table, hostess should mark current record as sited.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Identifier of the waiting item</param>
        /// <returns></returns>
        void CloseAsSeated (int? restaurantId, int? waitingItemId);
  
        /// <summary>
        /// Set current waiting record in sited state. When person gets a table, hostess should mark current record as sited.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Identifier of the waiting item</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CloseAsSeatedWithHttpInfo (int? restaurantId, int? waitingItemId);
        /// <summary>
        /// Confirm waiting record from HostMe mobile application
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <param name="conf">Confirmation model</param>
        /// <returns>WaitingItem</returns>
        WaitingItem Confirm (int? restaurantId, int? waitingItemId, PanelConfirmationBindingModel conf);
  
        /// <summary>
        /// Confirm waiting record from HostMe mobile application
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <param name="conf">Confirmation model</param>
        /// <returns>ApiResponse of WaitingItem</returns>
        ApiResponse<WaitingItem> ConfirmWithHttpInfo (int? restaurantId, int? waitingItemId, PanelConfirmationBindingModel conf);
        /// <summary>
        /// Returns all waiting items for the selecetd restaurant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="queryOptions">OData query (optional)</param>
        /// <param name="from"> (optional)</param>
        /// <param name="to"> (optional)</param>
        /// <returns>List&lt;WaitingItem&gt;</returns>
        List<WaitingItem> GetAllWaitings (int? restaurantId, string queryOptions, string from, int? to);
  
        /// <summary>
        /// Returns all waiting items for the selecetd restaurant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="queryOptions">OData query (optional)</param>
        /// <param name="from"> (optional)</param>
        /// <param name="to"> (optional)</param>
        /// <returns>ApiResponse of List&lt;WaitingItem&gt;</returns>
        ApiResponse<List<WaitingItem>> GetAllWaitingsWithHttpInfo (int? restaurantId, string queryOptions, string from, int? to);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="waitingItemId"></param>
        /// <returns>List&lt;Message&gt;</returns>
        List<Message> GetMessages (int? restaurantId, int? waitingItemId);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="waitingItemId"></param>
        /// <returns>ApiResponse of List&lt;Message&gt;</returns>
        ApiResponse<List<Message>> GetMessagesWithHttpInfo (int? restaurantId, int? waitingItemId);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>WaitingStats</returns>
        WaitingStats GetTodayStats (int? restaurantId);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>ApiResponse of WaitingStats</returns>
        ApiResponse<WaitingStats> GetTodayStatsWithHttpInfo (int? restaurantId);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>int?</returns>
        int? GetUnreadMessagesCount (int? restaurantId);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>ApiResponse of int?</returns>
        ApiResponse<int?> GetUnreadMessagesCountWithHttpInfo (int? restaurantId);
        /// <summary>
        /// Returns waiting item by waiting item identifier
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Identifier of the waiting item</param>
        /// <returns>WaitingItem</returns>
        WaitingItem GetWaitingById (int? restaurantId, int? waitingItemId);
  
        /// <summary>
        /// Returns waiting item by waiting item identifier
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Identifier of the waiting item</param>
        /// <returns>ApiResponse of WaitingItem</returns>
        ApiResponse<WaitingItem> GetWaitingByIdWithHttpInfo (int? restaurantId, int? waitingItemId);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>WaitingSettings</returns>
        WaitingSettings GetWaitingSettings (int? restaurantId);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>ApiResponse of WaitingSettings</returns>
        ApiResponse<WaitingSettings> GetWaitingSettingsWithHttpInfo (int? restaurantId);
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
        /// <returns>List&lt;WaitingsStatReportItem&gt;</returns>
        List<WaitingsStatReportItem> GetWaitingTimeByGroup (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to);
  
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
        /// <returns>ApiResponse of List&lt;WaitingsStatReportItem&gt;</returns>
        ApiResponse<List<WaitingsStatReportItem>> GetWaitingTimeByGroupWithHttpInfo (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to);
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
        /// <returns>List&lt;WaitingsStatReportItem&gt;</returns>
        List<WaitingsStatReportItem> GetWaitingTimeByHour (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to);
  
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
        /// <returns>ApiResponse of List&lt;WaitingsStatReportItem&gt;</returns>
        ApiResponse<List<WaitingsStatReportItem>> GetWaitingTimeByHourWithHttpInfo (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to);
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
        /// <returns>List&lt;WaitingsStatReportItem&gt;</returns>
        List<WaitingsStatReportItem> GetWaitingTimeByLine (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to);
  
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
        /// <returns>ApiResponse of List&lt;WaitingsStatReportItem&gt;</returns>
        ApiResponse<List<WaitingsStatReportItem>> GetWaitingTimeByLineWithHttpInfo (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to);
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
        /// <returns>List&lt;WaitingsStatReportItem&gt;</returns>
        List<WaitingsStatReportItem> GetWaitingTimeByMeal (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to);
  
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
        /// <returns>ApiResponse of List&lt;WaitingsStatReportItem&gt;</returns>
        ApiResponse<List<WaitingsStatReportItem>> GetWaitingTimeByMealWithHttpInfo (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to);
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
        /// <returns>List&lt;WaitingsStatReportItem&gt;</returns>
        List<WaitingsStatReportItem> GetWaitingTimeByWeek (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to);
  
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
        /// <returns>ApiResponse of List&lt;WaitingsStatReportItem&gt;</returns>
        ApiResponse<List<WaitingsStatReportItem>> GetWaitingTimeByWeekWithHttpInfo (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to);
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
        /// <returns>List&lt;WaitingsStatReportItem&gt;</returns>
        List<WaitingsStatReportItem> GetWaitingTimeByWeekDay (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to);
  
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
        /// <returns>ApiResponse of List&lt;WaitingsStatReportItem&gt;</returns>
        ApiResponse<List<WaitingsStatReportItem>> GetWaitingTimeByWeekDayWithHttpInfo (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to);
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
        /// <returns>List&lt;WaitingReportItem&gt;</returns>
        List<WaitingReportItem> GetWaitingsForPeriod (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to);
  
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
        /// <returns>ApiResponse of List&lt;WaitingReportItem&gt;</returns>
        ApiResponse<List<WaitingReportItem>> GetWaitingsForPeriodWithHttpInfo (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="groupBy"></param>
        /// <param name="from"> (optional)</param>
        /// <param name="to"> (optional)</param>
        /// <returns>List&lt;WaitingsStatReportItem&gt;</returns>
        List<WaitingsStatReportItem> GetWaitingsGroupBy (int? restaurantId, string groupBy, DateTimeOffset? from, DateTimeOffset? to);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="groupBy"></param>
        /// <param name="from"> (optional)</param>
        /// <param name="to"> (optional)</param>
        /// <returns>ApiResponse of List&lt;WaitingsStatReportItem&gt;</returns>
        ApiResponse<List<WaitingsStatReportItem>> GetWaitingsGroupByWithHttpInfo (int? restaurantId, string groupBy, DateTimeOffset? from, DateTimeOffset? to);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="body"></param>
        /// <returns>Object</returns>
        Object Incoming (string from, string to, string body);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> IncomingWithHttpInfo (string from, string to, string body);
        /// <summary>
        /// Mark all message as read.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <returns></returns>
        void MarkAllMessagesAsRead (int? restaurantId, int? waitingItemId);
  
        /// <summary>
        /// Mark all message as read.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> MarkAllMessagesAsReadWithHttpInfo (int? restaurantId, int? waitingItemId);
        /// <summary>
        /// Put waiting item, on hold manually
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
        /// Put waiting item, on hold manually
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
        /// Reopen closed waiting item
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <returns>WaitingItem</returns>
        WaitingItem ReOpenWaiting (int? restaurantId, int? waitingItemId);
  
        /// <summary>
        /// Reopen closed waiting item
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <returns>ApiResponse of WaitingItem</returns>
        ApiResponse<WaitingItem> ReOpenWaitingWithHttpInfo (int? restaurantId, int? waitingItemId);
        /// <summary>
        /// Sends a message related to specified waiting item.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <param name="origin">This parameter specifies who send the message. It could be host or client.</param>
        /// <param name="body">The body of the message</param>
        /// <returns>Message</returns>
        Message SendMessage (int? restaurantId, int? waitingItemId, string origin, string body);
  
        /// <summary>
        /// Sends a message related to specified waiting item.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <param name="origin">This parameter specifies who send the message. It could be host or client.</param>
        /// <param name="body">The body of the message</param>
        /// <returns>ApiResponse of Message</returns>
        ApiResponse<Message> SendMessageWithHttpInfo (int? restaurantId, int? waitingItemId, string origin, string body);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        void SetWaitingSettings (int? restaurantId, WaitingSettings settings);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="settings"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> SetWaitingSettingsWithHttpInfo (int? restaurantId, WaitingSettings settings);
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
        /// <summary>
        /// Update waitingitem
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Identifier of the restaurant registered in our system</param>
        /// <param name="waitingItemId">Identifier of the waiting record in our system</param>
        /// <param name="item">Update model of witing record</param>
        /// <returns>WaitingItem</returns>
        WaitingItem UpdateWaiting (int? restaurantId, int? waitingItemId, UpdateWaitingItemBindingModel item);
  
        /// <summary>
        /// Update waitingitem
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Identifier of the restaurant registered in our system</param>
        /// <param name="waitingItemId">Identifier of the waiting record in our system</param>
        /// <param name="item">Update model of witing record</param>
        /// <returns>ApiResponse of WaitingItem</returns>
        ApiResponse<WaitingItem> UpdateWaitingWithHttpInfo (int? restaurantId, int? waitingItemId, UpdateWaitingItemBindingModel item);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Preregister customer for the specified restaurant and returns waiting record with Confirmation Code. Use this method when  customer is going to use HostMe mobile application.\r\n            This registration requires customer confirmation by entering confirmation number.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Identifier of the restaurant registered in our system</param>
        /// <returns>Task of WaitingItem</returns>
        System.Threading.Tasks.Task<WaitingItem> AddNewWaitingAsync (int? restaurantId);

        /// <summary>
        /// Preregister customer for the specified restaurant and returns waiting record with Confirmation Code. Use this method when  customer is going to use HostMe mobile application.\r\n            This registration requires customer confirmation by entering confirmation number.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Identifier of the restaurant registered in our system</param>
        /// <returns>Task of ApiResponse (WaitingItem)</returns>
        System.Threading.Tasks.Task<ApiResponse<WaitingItem>> AddNewWaitingAsyncWithHttpInfo (int? restaurantId);
        /// <summary>
        /// When table is ready hostess originates Call event. It notifies client that table is ready
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <param name="tableNumber">Number of the table (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task CallWaitingPartyAsync (int? restaurantId, int? waitingItemId, string tableNumber);

        /// <summary>
        /// When table is ready hostess originates Call event. It notifies client that table is ready
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <param name="tableNumber">Number of the table (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CallWaitingPartyAsyncWithHttpInfo (int? restaurantId, int? waitingItemId, string tableNumber);
        /// <summary>
        /// Closes current waiting position. When person gets a table, hostess should close current position.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Identifier of the waiting item</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task CloseAsync (int? restaurantId, int? waitingItemId);

        /// <summary>
        /// Closes current waiting position. When person gets a table, hostess should close current position.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Identifier of the waiting item</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CloseAsyncWithHttpInfo (int? restaurantId, int? waitingItemId);
        /// <summary>
        /// Cancel waiting item
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <param name="origin">This parameter specifies who send the message. It could be host or client.</param>
        /// <param name="comment">Free text comment, such as \&quot;Sorry but it was to long wait, we decided to go to another restaurant.\&quot;</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task CloseAsCanceledAsync (int? restaurantId, int? waitingItemId, string origin, string comment);

        /// <summary>
        /// Cancel waiting item
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <param name="origin">This parameter specifies who send the message. It could be host or client.</param>
        /// <param name="comment">Free text comment, such as \&quot;Sorry but it was to long wait, we decided to go to another restaurant.\&quot;</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CloseAsCanceledAsyncWithHttpInfo (int? restaurantId, int? waitingItemId, string origin, string comment);
        /// <summary>
        /// Set current waiting record in sited state. When person gets a table, hostess should mark current record as sited.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Identifier of the waiting item</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task CloseAsSeatedAsync (int? restaurantId, int? waitingItemId);

        /// <summary>
        /// Set current waiting record in sited state. When person gets a table, hostess should mark current record as sited.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Identifier of the waiting item</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CloseAsSeatedAsyncWithHttpInfo (int? restaurantId, int? waitingItemId);
        /// <summary>
        /// Confirm waiting record from HostMe mobile application
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <param name="conf">Confirmation model</param>
        /// <returns>Task of WaitingItem</returns>
        System.Threading.Tasks.Task<WaitingItem> ConfirmAsync (int? restaurantId, int? waitingItemId, PanelConfirmationBindingModel conf);

        /// <summary>
        /// Confirm waiting record from HostMe mobile application
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <param name="conf">Confirmation model</param>
        /// <returns>Task of ApiResponse (WaitingItem)</returns>
        System.Threading.Tasks.Task<ApiResponse<WaitingItem>> ConfirmAsyncWithHttpInfo (int? restaurantId, int? waitingItemId, PanelConfirmationBindingModel conf);
        /// <summary>
        /// Returns all waiting items for the selecetd restaurant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="queryOptions">OData query (optional)</param>
        /// <param name="from"> (optional)</param>
        /// <param name="to"> (optional)</param>
        /// <returns>Task of List&lt;WaitingItem&gt;</returns>
        System.Threading.Tasks.Task<List<WaitingItem>> GetAllWaitingsAsync (int? restaurantId, string queryOptions, string from, int? to);

        /// <summary>
        /// Returns all waiting items for the selecetd restaurant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="queryOptions">OData query (optional)</param>
        /// <param name="from"> (optional)</param>
        /// <param name="to"> (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;WaitingItem&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<WaitingItem>>> GetAllWaitingsAsyncWithHttpInfo (int? restaurantId, string queryOptions, string from, int? to);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="waitingItemId"></param>
        /// <returns>Task of List&lt;Message&gt;</returns>
        System.Threading.Tasks.Task<List<Message>> GetMessagesAsync (int? restaurantId, int? waitingItemId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="waitingItemId"></param>
        /// <returns>Task of ApiResponse (List&lt;Message&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Message>>> GetMessagesAsyncWithHttpInfo (int? restaurantId, int? waitingItemId);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Task of WaitingStats</returns>
        System.Threading.Tasks.Task<WaitingStats> GetTodayStatsAsync (int? restaurantId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Task of ApiResponse (WaitingStats)</returns>
        System.Threading.Tasks.Task<ApiResponse<WaitingStats>> GetTodayStatsAsyncWithHttpInfo (int? restaurantId);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Task of int?</returns>
        System.Threading.Tasks.Task<int?> GetUnreadMessagesCountAsync (int? restaurantId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Task of ApiResponse (int?)</returns>
        System.Threading.Tasks.Task<ApiResponse<int?>> GetUnreadMessagesCountAsyncWithHttpInfo (int? restaurantId);
        /// <summary>
        /// Returns waiting item by waiting item identifier
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Identifier of the waiting item</param>
        /// <returns>Task of WaitingItem</returns>
        System.Threading.Tasks.Task<WaitingItem> GetWaitingByIdAsync (int? restaurantId, int? waitingItemId);

        /// <summary>
        /// Returns waiting item by waiting item identifier
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Identifier of the waiting item</param>
        /// <returns>Task of ApiResponse (WaitingItem)</returns>
        System.Threading.Tasks.Task<ApiResponse<WaitingItem>> GetWaitingByIdAsyncWithHttpInfo (int? restaurantId, int? waitingItemId);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Task of WaitingSettings</returns>
        System.Threading.Tasks.Task<WaitingSettings> GetWaitingSettingsAsync (int? restaurantId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Task of ApiResponse (WaitingSettings)</returns>
        System.Threading.Tasks.Task<ApiResponse<WaitingSettings>> GetWaitingSettingsAsyncWithHttpInfo (int? restaurantId);
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
        /// <returns>Task of List&lt;WaitingsStatReportItem&gt;</returns>
        System.Threading.Tasks.Task<List<WaitingsStatReportItem>> GetWaitingTimeByGroupAsync (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to);

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
        /// <returns>Task of ApiResponse (List&lt;WaitingsStatReportItem&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<WaitingsStatReportItem>>> GetWaitingTimeByGroupAsyncWithHttpInfo (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to);
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
        /// <returns>Task of List&lt;WaitingsStatReportItem&gt;</returns>
        System.Threading.Tasks.Task<List<WaitingsStatReportItem>> GetWaitingTimeByHourAsync (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to);

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
        /// <returns>Task of ApiResponse (List&lt;WaitingsStatReportItem&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<WaitingsStatReportItem>>> GetWaitingTimeByHourAsyncWithHttpInfo (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to);
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
        /// <returns>Task of List&lt;WaitingsStatReportItem&gt;</returns>
        System.Threading.Tasks.Task<List<WaitingsStatReportItem>> GetWaitingTimeByLineAsync (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to);

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
        /// <returns>Task of ApiResponse (List&lt;WaitingsStatReportItem&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<WaitingsStatReportItem>>> GetWaitingTimeByLineAsyncWithHttpInfo (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to);
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
        /// <returns>Task of List&lt;WaitingsStatReportItem&gt;</returns>
        System.Threading.Tasks.Task<List<WaitingsStatReportItem>> GetWaitingTimeByMealAsync (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to);

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
        /// <returns>Task of ApiResponse (List&lt;WaitingsStatReportItem&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<WaitingsStatReportItem>>> GetWaitingTimeByMealAsyncWithHttpInfo (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to);
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
        /// <returns>Task of List&lt;WaitingsStatReportItem&gt;</returns>
        System.Threading.Tasks.Task<List<WaitingsStatReportItem>> GetWaitingTimeByWeekAsync (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to);

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
        /// <returns>Task of ApiResponse (List&lt;WaitingsStatReportItem&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<WaitingsStatReportItem>>> GetWaitingTimeByWeekAsyncWithHttpInfo (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to);
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
        /// <returns>Task of List&lt;WaitingsStatReportItem&gt;</returns>
        System.Threading.Tasks.Task<List<WaitingsStatReportItem>> GetWaitingTimeByWeekDayAsync (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to);

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
        /// <returns>Task of ApiResponse (List&lt;WaitingsStatReportItem&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<WaitingsStatReportItem>>> GetWaitingTimeByWeekDayAsyncWithHttpInfo (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to);
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
        /// <returns>Task of List&lt;WaitingReportItem&gt;</returns>
        System.Threading.Tasks.Task<List<WaitingReportItem>> GetWaitingsForPeriodAsync (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to);

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
        /// <returns>Task of ApiResponse (List&lt;WaitingReportItem&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<WaitingReportItem>>> GetWaitingsForPeriodAsyncWithHttpInfo (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="groupBy"></param>
        /// <param name="from"> (optional)</param>
        /// <param name="to"> (optional)</param>
        /// <returns>Task of List&lt;WaitingsStatReportItem&gt;</returns>
        System.Threading.Tasks.Task<List<WaitingsStatReportItem>> GetWaitingsGroupByAsync (int? restaurantId, string groupBy, DateTimeOffset? from, DateTimeOffset? to);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="groupBy"></param>
        /// <param name="from"> (optional)</param>
        /// <param name="to"> (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;WaitingsStatReportItem&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<WaitingsStatReportItem>>> GetWaitingsGroupByAsyncWithHttpInfo (int? restaurantId, string groupBy, DateTimeOffset? from, DateTimeOffset? to);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="body"></param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> IncomingAsync (string from, string to, string body);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> IncomingAsyncWithHttpInfo (string from, string to, string body);
        /// <summary>
        /// Mark all message as read.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task MarkAllMessagesAsReadAsync (int? restaurantId, int? waitingItemId);

        /// <summary>
        /// Mark all message as read.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> MarkAllMessagesAsReadAsyncWithHttpInfo (int? restaurantId, int? waitingItemId);
        /// <summary>
        /// Put waiting item, on hold manually
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
        /// Put waiting item, on hold manually
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
        /// Reopen closed waiting item
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <returns>Task of WaitingItem</returns>
        System.Threading.Tasks.Task<WaitingItem> ReOpenWaitingAsync (int? restaurantId, int? waitingItemId);

        /// <summary>
        /// Reopen closed waiting item
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <returns>Task of ApiResponse (WaitingItem)</returns>
        System.Threading.Tasks.Task<ApiResponse<WaitingItem>> ReOpenWaitingAsyncWithHttpInfo (int? restaurantId, int? waitingItemId);
        /// <summary>
        /// Sends a message related to specified waiting item.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <param name="origin">This parameter specifies who send the message. It could be host or client.</param>
        /// <param name="body">The body of the message</param>
        /// <returns>Task of Message</returns>
        System.Threading.Tasks.Task<Message> SendMessageAsync (int? restaurantId, int? waitingItemId, string origin, string body);

        /// <summary>
        /// Sends a message related to specified waiting item.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <param name="origin">This parameter specifies who send the message. It could be host or client.</param>
        /// <param name="body">The body of the message</param>
        /// <returns>Task of ApiResponse (Message)</returns>
        System.Threading.Tasks.Task<ApiResponse<Message>> SendMessageAsyncWithHttpInfo (int? restaurantId, int? waitingItemId, string origin, string body);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="settings"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task SetWaitingSettingsAsync (int? restaurantId, WaitingSettings settings);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="settings"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> SetWaitingSettingsAsyncWithHttpInfo (int? restaurantId, WaitingSettings settings);
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
        /// <summary>
        /// Update waitingitem
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Identifier of the restaurant registered in our system</param>
        /// <param name="waitingItemId">Identifier of the waiting record in our system</param>
        /// <param name="item">Update model of witing record</param>
        /// <returns>Task of WaitingItem</returns>
        System.Threading.Tasks.Task<WaitingItem> UpdateWaitingAsync (int? restaurantId, int? waitingItemId, UpdateWaitingItemBindingModel item);

        /// <summary>
        /// Update waitingitem
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Identifier of the restaurant registered in our system</param>
        /// <param name="waitingItemId">Identifier of the waiting record in our system</param>
        /// <param name="item">Update model of witing record</param>
        /// <returns>Task of ApiResponse (WaitingItem)</returns>
        System.Threading.Tasks.Task<ApiResponse<WaitingItem>> UpdateWaitingAsyncWithHttpInfo (int? restaurantId, int? waitingItemId, UpdateWaitingItemBindingModel item);
        #endregion Asynchronous Operations
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AdminWaitlistApi : IAdminWaitlistApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdminWaitlistApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AdminWaitlistApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AdminWaitlistApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AdminWaitlistApi(Configuration configuration = null)
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
        /// Preregister customer for the specified restaurant and returns waiting record with Confirmation Code. Use this method when  customer is going to use HostMe mobile application.\r\n            This registration requires customer confirmation by entering confirmation number. 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Identifier of the restaurant registered in our system</param> 
        /// <returns>WaitingItem</returns>
        public WaitingItem AddNewWaiting (int? restaurantId)
        {
             ApiResponse<WaitingItem> localVarResponse = AddNewWaitingWithHttpInfo(restaurantId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Preregister customer for the specified restaurant and returns waiting record with Confirmation Code. Use this method when  customer is going to use HostMe mobile application.\r\n            This registration requires customer confirmation by entering confirmation number. 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Identifier of the restaurant registered in our system</param> 
        /// <returns>ApiResponse of WaitingItem</returns>
        public ApiResponse< WaitingItem > AddNewWaitingWithHttpInfo (int? restaurantId)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminWaitlistApi->AddNewWaiting");
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/waitings";
    
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AddNewWaiting: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddNewWaiting: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<WaitingItem>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WaitingItem) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WaitingItem)));
            
        }

        /// <summary>
        /// Preregister customer for the specified restaurant and returns waiting record with Confirmation Code. Use this method when  customer is going to use HostMe mobile application.\r\n            This registration requires customer confirmation by entering confirmation number. 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Identifier of the restaurant registered in our system</param>
        /// <returns>Task of WaitingItem</returns>
        public async System.Threading.Tasks.Task<WaitingItem> AddNewWaitingAsync (int? restaurantId)
        {
             ApiResponse<WaitingItem> localVarResponse = await AddNewWaitingAsyncWithHttpInfo(restaurantId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Preregister customer for the specified restaurant and returns waiting record with Confirmation Code. Use this method when  customer is going to use HostMe mobile application.\r\n            This registration requires customer confirmation by entering confirmation number. 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Identifier of the restaurant registered in our system</param>
        /// <returns>Task of ApiResponse (WaitingItem)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WaitingItem>> AddNewWaitingAsyncWithHttpInfo (int? restaurantId)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AddNewWaiting");
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/waitings";
    
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AddNewWaiting: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddNewWaiting: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WaitingItem>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WaitingItem) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WaitingItem)));
            
        }
        /// <summary>
        /// When table is ready hostess originates Call event. It notifies client that table is ready 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param> 
        /// <param name="waitingItemId">Waiting item identifier</param> 
        /// <param name="tableNumber">Number of the table (optional)</param> 
        /// <returns></returns>
        public void CallWaitingParty (int? restaurantId, int? waitingItemId, string tableNumber)
        {
             CallWaitingPartyWithHttpInfo(restaurantId, waitingItemId, tableNumber);
        }

        /// <summary>
        /// When table is ready hostess originates Call event. It notifies client that table is ready 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param> 
        /// <param name="waitingItemId">Waiting item identifier</param> 
        /// <param name="tableNumber">Number of the table (optional)</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> CallWaitingPartyWithHttpInfo (int? restaurantId, int? waitingItemId, string tableNumber)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminWaitlistApi->CallWaitingParty");
            
            // verify the required parameter 'waitingItemId' is set
            if (waitingItemId == null)
                throw new ApiException(400, "Missing required parameter 'waitingItemId' when calling AdminWaitlistApi->CallWaitingParty");
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/waitings/{waitingItemId}/call";
    
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
if (waitingItemId != null) localVarPathParams.Add("waitingItemId", Configuration.ApiClient.ParameterToString(waitingItemId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling CallWaitingParty: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CallWaitingParty: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// When table is ready hostess originates Call event. It notifies client that table is ready 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <param name="tableNumber">Number of the table (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task CallWaitingPartyAsync (int? restaurantId, int? waitingItemId, string tableNumber)
        {
             await CallWaitingPartyAsyncWithHttpInfo(restaurantId, waitingItemId, tableNumber);

        }

        /// <summary>
        /// When table is ready hostess originates Call event. It notifies client that table is ready 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <param name="tableNumber">Number of the table (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> CallWaitingPartyAsyncWithHttpInfo (int? restaurantId, int? waitingItemId, string tableNumber)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling CallWaitingParty");
            // verify the required parameter 'waitingItemId' is set
            if (waitingItemId == null) throw new ApiException(400, "Missing required parameter 'waitingItemId' when calling CallWaitingParty");
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/waitings/{waitingItemId}/call";
    
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
if (waitingItemId != null) localVarPathParams.Add("waitingItemId", Configuration.ApiClient.ParameterToString(waitingItemId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling CallWaitingParty: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CallWaitingParty: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        /// <summary>
        /// Closes current waiting position. When person gets a table, hostess should close current position. 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param> 
        /// <param name="waitingItemId">Identifier of the waiting item</param> 
        /// <returns></returns>
        public void Close (int? restaurantId, int? waitingItemId)
        {
             CloseWithHttpInfo(restaurantId, waitingItemId);
        }

        /// <summary>
        /// Closes current waiting position. When person gets a table, hostess should close current position. 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param> 
        /// <param name="waitingItemId">Identifier of the waiting item</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> CloseWithHttpInfo (int? restaurantId, int? waitingItemId)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminWaitlistApi->Close");
            
            // verify the required parameter 'waitingItemId' is set
            if (waitingItemId == null)
                throw new ApiException(400, "Missing required parameter 'waitingItemId' when calling AdminWaitlistApi->Close");
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/waitings/{waitingItemId}/close";
    
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
        /// Closes current waiting position. When person gets a table, hostess should close current position. 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Identifier of the waiting item</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task CloseAsync (int? restaurantId, int? waitingItemId)
        {
             await CloseAsyncWithHttpInfo(restaurantId, waitingItemId);

        }

        /// <summary>
        /// Closes current waiting position. When person gets a table, hostess should close current position. 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Identifier of the waiting item</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> CloseAsyncWithHttpInfo (int? restaurantId, int? waitingItemId)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling Close");
            // verify the required parameter 'waitingItemId' is set
            if (waitingItemId == null) throw new ApiException(400, "Missing required parameter 'waitingItemId' when calling Close");
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/waitings/{waitingItemId}/close";
    
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
        /// Cancel waiting item 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param> 
        /// <param name="waitingItemId">Waiting item identifier</param> 
        /// <param name="origin">This parameter specifies who send the message. It could be host or client.</param> 
        /// <param name="comment">Free text comment, such as \&quot;Sorry but it was to long wait, we decided to go to another restaurant.\&quot;</param> 
        /// <returns></returns>
        public void CloseAsCanceled (int? restaurantId, int? waitingItemId, string origin, string comment)
        {
             CloseAsCanceledWithHttpInfo(restaurantId, waitingItemId, origin, comment);
        }

        /// <summary>
        /// Cancel waiting item 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param> 
        /// <param name="waitingItemId">Waiting item identifier</param> 
        /// <param name="origin">This parameter specifies who send the message. It could be host or client.</param> 
        /// <param name="comment">Free text comment, such as \&quot;Sorry but it was to long wait, we decided to go to another restaurant.\&quot;</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> CloseAsCanceledWithHttpInfo (int? restaurantId, int? waitingItemId, string origin, string comment)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminWaitlistApi->CloseAsCanceled");
            
            // verify the required parameter 'waitingItemId' is set
            if (waitingItemId == null)
                throw new ApiException(400, "Missing required parameter 'waitingItemId' when calling AdminWaitlistApi->CloseAsCanceled");
            
            // verify the required parameter 'origin' is set
            if (origin == null)
                throw new ApiException(400, "Missing required parameter 'origin' when calling AdminWaitlistApi->CloseAsCanceled");
            
            // verify the required parameter 'comment' is set
            if (comment == null)
                throw new ApiException(400, "Missing required parameter 'comment' when calling AdminWaitlistApi->CloseAsCanceled");
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/waitings/{waitingItemId}/cancel";
    
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
if (waitingItemId != null) localVarPathParams.Add("waitingItemId", Configuration.ApiClient.ParameterToString(waitingItemId)); // path parameter
            if (origin != null) localVarQueryParams.Add("origin", Configuration.ApiClient.ParameterToString(origin)); // query parameter
                                    if (comment.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(comment); // http body (model) parameter
            }
            else
            {
                localVarPostBody = comment; // byte array
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
        /// Cancel waiting item 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <param name="origin">This parameter specifies who send the message. It could be host or client.</param>
        /// <param name="comment">Free text comment, such as \&quot;Sorry but it was to long wait, we decided to go to another restaurant.\&quot;</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task CloseAsCanceledAsync (int? restaurantId, int? waitingItemId, string origin, string comment)
        {
             await CloseAsCanceledAsyncWithHttpInfo(restaurantId, waitingItemId, origin, comment);

        }

        /// <summary>
        /// Cancel waiting item 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <param name="origin">This parameter specifies who send the message. It could be host or client.</param>
        /// <param name="comment">Free text comment, such as \&quot;Sorry but it was to long wait, we decided to go to another restaurant.\&quot;</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> CloseAsCanceledAsyncWithHttpInfo (int? restaurantId, int? waitingItemId, string origin, string comment)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling CloseAsCanceled");
            // verify the required parameter 'waitingItemId' is set
            if (waitingItemId == null) throw new ApiException(400, "Missing required parameter 'waitingItemId' when calling CloseAsCanceled");
            // verify the required parameter 'origin' is set
            if (origin == null) throw new ApiException(400, "Missing required parameter 'origin' when calling CloseAsCanceled");
            // verify the required parameter 'comment' is set
            if (comment == null) throw new ApiException(400, "Missing required parameter 'comment' when calling CloseAsCanceled");
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/waitings/{waitingItemId}/cancel";
    
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
if (waitingItemId != null) localVarPathParams.Add("waitingItemId", Configuration.ApiClient.ParameterToString(waitingItemId)); // path parameter
            if (origin != null) localVarQueryParams.Add("origin", Configuration.ApiClient.ParameterToString(origin)); // query parameter
                                    if (comment.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(comment); // http body (model) parameter
            }
            else
            {
                localVarPostBody = comment; // byte array
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
        /// Set current waiting record in sited state. When person gets a table, hostess should mark current record as sited. 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param> 
        /// <param name="waitingItemId">Identifier of the waiting item</param> 
        /// <returns></returns>
        public void CloseAsSeated (int? restaurantId, int? waitingItemId)
        {
             CloseAsSeatedWithHttpInfo(restaurantId, waitingItemId);
        }

        /// <summary>
        /// Set current waiting record in sited state. When person gets a table, hostess should mark current record as sited. 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param> 
        /// <param name="waitingItemId">Identifier of the waiting item</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> CloseAsSeatedWithHttpInfo (int? restaurantId, int? waitingItemId)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminWaitlistApi->CloseAsSeated");
            
            // verify the required parameter 'waitingItemId' is set
            if (waitingItemId == null)
                throw new ApiException(400, "Missing required parameter 'waitingItemId' when calling AdminWaitlistApi->CloseAsSeated");
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/waitings/{waitingItemId}/sited";
    
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
                throw new ApiException (localVarStatusCode, "Error calling CloseAsSeated: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CloseAsSeated: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Set current waiting record in sited state. When person gets a table, hostess should mark current record as sited. 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Identifier of the waiting item</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task CloseAsSeatedAsync (int? restaurantId, int? waitingItemId)
        {
             await CloseAsSeatedAsyncWithHttpInfo(restaurantId, waitingItemId);

        }

        /// <summary>
        /// Set current waiting record in sited state. When person gets a table, hostess should mark current record as sited. 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Identifier of the waiting item</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> CloseAsSeatedAsyncWithHttpInfo (int? restaurantId, int? waitingItemId)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling CloseAsSeated");
            // verify the required parameter 'waitingItemId' is set
            if (waitingItemId == null) throw new ApiException(400, "Missing required parameter 'waitingItemId' when calling CloseAsSeated");
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/waitings/{waitingItemId}/sited";
    
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
                throw new ApiException (localVarStatusCode, "Error calling CloseAsSeated: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CloseAsSeated: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        /// <summary>
        /// Confirm waiting record from HostMe mobile application 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param> 
        /// <param name="waitingItemId">Waiting item identifier</param> 
        /// <param name="conf">Confirmation model</param> 
        /// <returns>WaitingItem</returns>
        public WaitingItem Confirm (int? restaurantId, int? waitingItemId, PanelConfirmationBindingModel conf)
        {
             ApiResponse<WaitingItem> localVarResponse = ConfirmWithHttpInfo(restaurantId, waitingItemId, conf);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Confirm waiting record from HostMe mobile application 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param> 
        /// <param name="waitingItemId">Waiting item identifier</param> 
        /// <param name="conf">Confirmation model</param> 
        /// <returns>ApiResponse of WaitingItem</returns>
        public ApiResponse< WaitingItem > ConfirmWithHttpInfo (int? restaurantId, int? waitingItemId, PanelConfirmationBindingModel conf)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminWaitlistApi->Confirm");
            
            // verify the required parameter 'waitingItemId' is set
            if (waitingItemId == null)
                throw new ApiException(400, "Missing required parameter 'waitingItemId' when calling AdminWaitlistApi->Confirm");
            
            // verify the required parameter 'conf' is set
            if (conf == null)
                throw new ApiException(400, "Missing required parameter 'conf' when calling AdminWaitlistApi->Confirm");
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/waitings/{waitingItemId}/confirm";
    
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
if (waitingItemId != null) localVarPathParams.Add("waitingItemId", Configuration.ApiClient.ParameterToString(waitingItemId)); // path parameter
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Confirm: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Confirm: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<WaitingItem>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WaitingItem) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WaitingItem)));
            
        }

        /// <summary>
        /// Confirm waiting record from HostMe mobile application 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <param name="conf">Confirmation model</param>
        /// <returns>Task of WaitingItem</returns>
        public async System.Threading.Tasks.Task<WaitingItem> ConfirmAsync (int? restaurantId, int? waitingItemId, PanelConfirmationBindingModel conf)
        {
             ApiResponse<WaitingItem> localVarResponse = await ConfirmAsyncWithHttpInfo(restaurantId, waitingItemId, conf);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Confirm waiting record from HostMe mobile application 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <param name="conf">Confirmation model</param>
        /// <returns>Task of ApiResponse (WaitingItem)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WaitingItem>> ConfirmAsyncWithHttpInfo (int? restaurantId, int? waitingItemId, PanelConfirmationBindingModel conf)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling Confirm");
            // verify the required parameter 'waitingItemId' is set
            if (waitingItemId == null) throw new ApiException(400, "Missing required parameter 'waitingItemId' when calling Confirm");
            // verify the required parameter 'conf' is set
            if (conf == null) throw new ApiException(400, "Missing required parameter 'conf' when calling Confirm");
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/waitings/{waitingItemId}/confirm";
    
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
if (waitingItemId != null) localVarPathParams.Add("waitingItemId", Configuration.ApiClient.ParameterToString(waitingItemId)); // path parameter
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Confirm: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Confirm: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WaitingItem>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WaitingItem) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WaitingItem)));
            
        }
        /// <summary>
        /// Returns all waiting items for the selecetd restaurant 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param> 
        /// <param name="queryOptions">OData query (optional)</param> 
        /// <param name="from"> (optional)</param> 
        /// <param name="to"> (optional)</param> 
        /// <returns>List&lt;WaitingItem&gt;</returns>
        public List<WaitingItem> GetAllWaitings (int? restaurantId, string queryOptions, string from, int? to)
        {
             ApiResponse<List<WaitingItem>> localVarResponse = GetAllWaitingsWithHttpInfo(restaurantId, queryOptions, from, to);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns all waiting items for the selecetd restaurant 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param> 
        /// <param name="queryOptions">OData query (optional)</param> 
        /// <param name="from"> (optional)</param> 
        /// <param name="to"> (optional)</param> 
        /// <returns>ApiResponse of List&lt;WaitingItem&gt;</returns>
        public ApiResponse< List<WaitingItem> > GetAllWaitingsWithHttpInfo (int? restaurantId, string queryOptions, string from, int? to)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminWaitlistApi->GetAllWaitings");
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/waitings";
    
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
            if (queryOptions != null) localVarQueryParams.Add("queryOptions", Configuration.ApiClient.ParameterToString(queryOptions)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling GetAllWaitings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAllWaitings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<WaitingItem>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<WaitingItem>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WaitingItem>)));
            
        }

        /// <summary>
        /// Returns all waiting items for the selecetd restaurant 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="queryOptions">OData query (optional)</param>
        /// <param name="from"> (optional)</param>
        /// <param name="to"> (optional)</param>
        /// <returns>Task of List&lt;WaitingItem&gt;</returns>
        public async System.Threading.Tasks.Task<List<WaitingItem>> GetAllWaitingsAsync (int? restaurantId, string queryOptions, string from, int? to)
        {
             ApiResponse<List<WaitingItem>> localVarResponse = await GetAllWaitingsAsyncWithHttpInfo(restaurantId, queryOptions, from, to);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns all waiting items for the selecetd restaurant 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="queryOptions">OData query (optional)</param>
        /// <param name="from"> (optional)</param>
        /// <param name="to"> (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;WaitingItem&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<WaitingItem>>> GetAllWaitingsAsyncWithHttpInfo (int? restaurantId, string queryOptions, string from, int? to)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling GetAllWaitings");
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/waitings";
    
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
            if (queryOptions != null) localVarQueryParams.Add("queryOptions", Configuration.ApiClient.ParameterToString(queryOptions)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling GetAllWaitings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAllWaitings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<WaitingItem>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<WaitingItem>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WaitingItem>)));
            
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="waitingItemId"></param> 
        /// <returns>List&lt;Message&gt;</returns>
        public List<Message> GetMessages (int? restaurantId, int? waitingItemId)
        {
             ApiResponse<List<Message>> localVarResponse = GetMessagesWithHttpInfo(restaurantId, waitingItemId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="waitingItemId"></param> 
        /// <returns>ApiResponse of List&lt;Message&gt;</returns>
        public ApiResponse< List<Message> > GetMessagesWithHttpInfo (int? restaurantId, int? waitingItemId)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminWaitlistApi->GetMessages");
            
            // verify the required parameter 'waitingItemId' is set
            if (waitingItemId == null)
                throw new ApiException(400, "Missing required parameter 'waitingItemId' when calling AdminWaitlistApi->GetMessages");
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/waitings/{waitingItemId}/messages";
    
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
if (waitingItemId != null) localVarPathParams.Add("waitingItemId", Configuration.ApiClient.ParameterToString(waitingItemId)); // path parameter
                                                

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
        /// <param name="waitingItemId"></param>
        /// <returns>Task of List&lt;Message&gt;</returns>
        public async System.Threading.Tasks.Task<List<Message>> GetMessagesAsync (int? restaurantId, int? waitingItemId)
        {
             ApiResponse<List<Message>> localVarResponse = await GetMessagesAsyncWithHttpInfo(restaurantId, waitingItemId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="waitingItemId"></param>
        /// <returns>Task of ApiResponse (List&lt;Message&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Message>>> GetMessagesAsyncWithHttpInfo (int? restaurantId, int? waitingItemId)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling GetMessages");
            // verify the required parameter 'waitingItemId' is set
            if (waitingItemId == null) throw new ApiException(400, "Missing required parameter 'waitingItemId' when calling GetMessages");
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/waitings/{waitingItemId}/messages";
    
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
if (waitingItemId != null) localVarPathParams.Add("waitingItemId", Configuration.ApiClient.ParameterToString(waitingItemId)); // path parameter
                                                

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
        /// <returns>WaitingStats</returns>
        public WaitingStats GetTodayStats (int? restaurantId)
        {
             ApiResponse<WaitingStats> localVarResponse = GetTodayStatsWithHttpInfo(restaurantId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <returns>ApiResponse of WaitingStats</returns>
        public ApiResponse< WaitingStats > GetTodayStatsWithHttpInfo (int? restaurantId)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminWaitlistApi->GetTodayStats");
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/stats";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetTodayStats: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTodayStats: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<WaitingStats>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WaitingStats) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WaitingStats)));
            
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Task of WaitingStats</returns>
        public async System.Threading.Tasks.Task<WaitingStats> GetTodayStatsAsync (int? restaurantId)
        {
             ApiResponse<WaitingStats> localVarResponse = await GetTodayStatsAsyncWithHttpInfo(restaurantId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Task of ApiResponse (WaitingStats)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WaitingStats>> GetTodayStatsAsyncWithHttpInfo (int? restaurantId)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling GetTodayStats");
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/stats";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetTodayStats: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTodayStats: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WaitingStats>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WaitingStats) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WaitingStats)));
            
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <returns>int?</returns>
        public int? GetUnreadMessagesCount (int? restaurantId)
        {
             ApiResponse<int?> localVarResponse = GetUnreadMessagesCountWithHttpInfo(restaurantId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <returns>ApiResponse of int?</returns>
        public ApiResponse< int? > GetUnreadMessagesCountWithHttpInfo (int? restaurantId)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminWaitlistApi->GetUnreadMessagesCount");
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/waitings/messages/count-unread";
    
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
        /// <returns>Task of int?</returns>
        public async System.Threading.Tasks.Task<int?> GetUnreadMessagesCountAsync (int? restaurantId)
        {
             ApiResponse<int?> localVarResponse = await GetUnreadMessagesCountAsyncWithHttpInfo(restaurantId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Task of ApiResponse (int?)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<int?>> GetUnreadMessagesCountAsyncWithHttpInfo (int? restaurantId)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling GetUnreadMessagesCount");
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/waitings/messages/count-unread";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetUnreadMessagesCount: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUnreadMessagesCount: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<int?>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (int?) Configuration.ApiClient.Deserialize(localVarResponse, typeof(int?)));
            
        }
        /// <summary>
        /// Returns waiting item by waiting item identifier 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param> 
        /// <param name="waitingItemId">Identifier of the waiting item</param> 
        /// <returns>WaitingItem</returns>
        public WaitingItem GetWaitingById (int? restaurantId, int? waitingItemId)
        {
             ApiResponse<WaitingItem> localVarResponse = GetWaitingByIdWithHttpInfo(restaurantId, waitingItemId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns waiting item by waiting item identifier 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param> 
        /// <param name="waitingItemId">Identifier of the waiting item</param> 
        /// <returns>ApiResponse of WaitingItem</returns>
        public ApiResponse< WaitingItem > GetWaitingByIdWithHttpInfo (int? restaurantId, int? waitingItemId)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminWaitlistApi->GetWaitingById");
            
            // verify the required parameter 'waitingItemId' is set
            if (waitingItemId == null)
                throw new ApiException(400, "Missing required parameter 'waitingItemId' when calling AdminWaitlistApi->GetWaitingById");
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/waitings/{waitingItemId}";
    
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
if (waitingItemId != null) localVarPathParams.Add("waitingItemId", Configuration.ApiClient.ParameterToString(waitingItemId)); // path parameter
                                                

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
                throw new ApiException (localVarStatusCode, "Error calling GetWaitingById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWaitingById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<WaitingItem>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WaitingItem) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WaitingItem)));
            
        }

        /// <summary>
        /// Returns waiting item by waiting item identifier 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Identifier of the waiting item</param>
        /// <returns>Task of WaitingItem</returns>
        public async System.Threading.Tasks.Task<WaitingItem> GetWaitingByIdAsync (int? restaurantId, int? waitingItemId)
        {
             ApiResponse<WaitingItem> localVarResponse = await GetWaitingByIdAsyncWithHttpInfo(restaurantId, waitingItemId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns waiting item by waiting item identifier 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Identifier of the waiting item</param>
        /// <returns>Task of ApiResponse (WaitingItem)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WaitingItem>> GetWaitingByIdAsyncWithHttpInfo (int? restaurantId, int? waitingItemId)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling GetWaitingById");
            // verify the required parameter 'waitingItemId' is set
            if (waitingItemId == null) throw new ApiException(400, "Missing required parameter 'waitingItemId' when calling GetWaitingById");
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/waitings/{waitingItemId}";
    
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
if (waitingItemId != null) localVarPathParams.Add("waitingItemId", Configuration.ApiClient.ParameterToString(waitingItemId)); // path parameter
                                                

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
                throw new ApiException (localVarStatusCode, "Error calling GetWaitingById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWaitingById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WaitingItem>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WaitingItem) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WaitingItem)));
            
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <returns>WaitingSettings</returns>
        public WaitingSettings GetWaitingSettings (int? restaurantId)
        {
             ApiResponse<WaitingSettings> localVarResponse = GetWaitingSettingsWithHttpInfo(restaurantId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <returns>ApiResponse of WaitingSettings</returns>
        public ApiResponse< WaitingSettings > GetWaitingSettingsWithHttpInfo (int? restaurantId)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminWaitlistApi->GetWaitingSettings");
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/settings";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetWaitingSettings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWaitingSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<WaitingSettings>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WaitingSettings) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WaitingSettings)));
            
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Task of WaitingSettings</returns>
        public async System.Threading.Tasks.Task<WaitingSettings> GetWaitingSettingsAsync (int? restaurantId)
        {
             ApiResponse<WaitingSettings> localVarResponse = await GetWaitingSettingsAsyncWithHttpInfo(restaurantId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Task of ApiResponse (WaitingSettings)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WaitingSettings>> GetWaitingSettingsAsyncWithHttpInfo (int? restaurantId)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling GetWaitingSettings");
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/settings";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetWaitingSettings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWaitingSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WaitingSettings>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WaitingSettings) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WaitingSettings)));
            
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="from"> (optional)</param> 
        /// <param name="to"> (optional)</param> 
        /// <returns>List&lt;WaitingsStatReportItem&gt;</returns>
        public List<WaitingsStatReportItem> GetWaitingTimeByGroup (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to)
        {
             ApiResponse<List<WaitingsStatReportItem>> localVarResponse = GetWaitingTimeByGroupWithHttpInfo(restaurantId, from, to);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="from"> (optional)</param> 
        /// <param name="to"> (optional)</param> 
        /// <returns>ApiResponse of List&lt;WaitingsStatReportItem&gt;</returns>
        public ApiResponse< List<WaitingsStatReportItem> > GetWaitingTimeByGroupWithHttpInfo (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminWaitlistApi->GetWaitingTimeByGroup");
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/analytics/waitings/groupby/partysize";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetWaitingTimeByGroup: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWaitingTimeByGroup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<WaitingsStatReportItem>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<WaitingsStatReportItem>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WaitingsStatReportItem>)));
            
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="from"> (optional)</param>
        /// <param name="to"> (optional)</param>
        /// <returns>Task of List&lt;WaitingsStatReportItem&gt;</returns>
        public async System.Threading.Tasks.Task<List<WaitingsStatReportItem>> GetWaitingTimeByGroupAsync (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to)
        {
             ApiResponse<List<WaitingsStatReportItem>> localVarResponse = await GetWaitingTimeByGroupAsyncWithHttpInfo(restaurantId, from, to);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="from"> (optional)</param>
        /// <param name="to"> (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;WaitingsStatReportItem&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<WaitingsStatReportItem>>> GetWaitingTimeByGroupAsyncWithHttpInfo (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling GetWaitingTimeByGroup");
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/analytics/waitings/groupby/partysize";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetWaitingTimeByGroup: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWaitingTimeByGroup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<WaitingsStatReportItem>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<WaitingsStatReportItem>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WaitingsStatReportItem>)));
            
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="from"> (optional)</param> 
        /// <param name="to"> (optional)</param> 
        /// <returns>List&lt;WaitingsStatReportItem&gt;</returns>
        public List<WaitingsStatReportItem> GetWaitingTimeByHour (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to)
        {
             ApiResponse<List<WaitingsStatReportItem>> localVarResponse = GetWaitingTimeByHourWithHttpInfo(restaurantId, from, to);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="from"> (optional)</param> 
        /// <param name="to"> (optional)</param> 
        /// <returns>ApiResponse of List&lt;WaitingsStatReportItem&gt;</returns>
        public ApiResponse< List<WaitingsStatReportItem> > GetWaitingTimeByHourWithHttpInfo (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminWaitlistApi->GetWaitingTimeByHour");
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/analytics/waitings/groupby/hour";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetWaitingTimeByHour: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWaitingTimeByHour: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<WaitingsStatReportItem>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<WaitingsStatReportItem>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WaitingsStatReportItem>)));
            
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="from"> (optional)</param>
        /// <param name="to"> (optional)</param>
        /// <returns>Task of List&lt;WaitingsStatReportItem&gt;</returns>
        public async System.Threading.Tasks.Task<List<WaitingsStatReportItem>> GetWaitingTimeByHourAsync (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to)
        {
             ApiResponse<List<WaitingsStatReportItem>> localVarResponse = await GetWaitingTimeByHourAsyncWithHttpInfo(restaurantId, from, to);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="from"> (optional)</param>
        /// <param name="to"> (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;WaitingsStatReportItem&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<WaitingsStatReportItem>>> GetWaitingTimeByHourAsyncWithHttpInfo (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling GetWaitingTimeByHour");
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/analytics/waitings/groupby/hour";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetWaitingTimeByHour: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWaitingTimeByHour: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<WaitingsStatReportItem>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<WaitingsStatReportItem>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WaitingsStatReportItem>)));
            
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="from"> (optional)</param> 
        /// <param name="to"> (optional)</param> 
        /// <returns>List&lt;WaitingsStatReportItem&gt;</returns>
        public List<WaitingsStatReportItem> GetWaitingTimeByLine (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to)
        {
             ApiResponse<List<WaitingsStatReportItem>> localVarResponse = GetWaitingTimeByLineWithHttpInfo(restaurantId, from, to);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="from"> (optional)</param> 
        /// <param name="to"> (optional)</param> 
        /// <returns>ApiResponse of List&lt;WaitingsStatReportItem&gt;</returns>
        public ApiResponse< List<WaitingsStatReportItem> > GetWaitingTimeByLineWithHttpInfo (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminWaitlistApi->GetWaitingTimeByLine");
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/analytics/waitings/groupby/line";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetWaitingTimeByLine: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWaitingTimeByLine: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<WaitingsStatReportItem>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<WaitingsStatReportItem>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WaitingsStatReportItem>)));
            
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="from"> (optional)</param>
        /// <param name="to"> (optional)</param>
        /// <returns>Task of List&lt;WaitingsStatReportItem&gt;</returns>
        public async System.Threading.Tasks.Task<List<WaitingsStatReportItem>> GetWaitingTimeByLineAsync (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to)
        {
             ApiResponse<List<WaitingsStatReportItem>> localVarResponse = await GetWaitingTimeByLineAsyncWithHttpInfo(restaurantId, from, to);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="from"> (optional)</param>
        /// <param name="to"> (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;WaitingsStatReportItem&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<WaitingsStatReportItem>>> GetWaitingTimeByLineAsyncWithHttpInfo (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling GetWaitingTimeByLine");
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/analytics/waitings/groupby/line";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetWaitingTimeByLine: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWaitingTimeByLine: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<WaitingsStatReportItem>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<WaitingsStatReportItem>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WaitingsStatReportItem>)));
            
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="from"> (optional)</param> 
        /// <param name="to"> (optional)</param> 
        /// <returns>List&lt;WaitingsStatReportItem&gt;</returns>
        public List<WaitingsStatReportItem> GetWaitingTimeByMeal (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to)
        {
             ApiResponse<List<WaitingsStatReportItem>> localVarResponse = GetWaitingTimeByMealWithHttpInfo(restaurantId, from, to);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="from"> (optional)</param> 
        /// <param name="to"> (optional)</param> 
        /// <returns>ApiResponse of List&lt;WaitingsStatReportItem&gt;</returns>
        public ApiResponse< List<WaitingsStatReportItem> > GetWaitingTimeByMealWithHttpInfo (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminWaitlistApi->GetWaitingTimeByMeal");
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/analytics/waitings/groupby/mealtype";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetWaitingTimeByMeal: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWaitingTimeByMeal: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<WaitingsStatReportItem>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<WaitingsStatReportItem>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WaitingsStatReportItem>)));
            
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="from"> (optional)</param>
        /// <param name="to"> (optional)</param>
        /// <returns>Task of List&lt;WaitingsStatReportItem&gt;</returns>
        public async System.Threading.Tasks.Task<List<WaitingsStatReportItem>> GetWaitingTimeByMealAsync (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to)
        {
             ApiResponse<List<WaitingsStatReportItem>> localVarResponse = await GetWaitingTimeByMealAsyncWithHttpInfo(restaurantId, from, to);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="from"> (optional)</param>
        /// <param name="to"> (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;WaitingsStatReportItem&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<WaitingsStatReportItem>>> GetWaitingTimeByMealAsyncWithHttpInfo (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling GetWaitingTimeByMeal");
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/analytics/waitings/groupby/mealtype";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetWaitingTimeByMeal: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWaitingTimeByMeal: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<WaitingsStatReportItem>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<WaitingsStatReportItem>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WaitingsStatReportItem>)));
            
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="from"> (optional)</param> 
        /// <param name="to"> (optional)</param> 
        /// <returns>List&lt;WaitingsStatReportItem&gt;</returns>
        public List<WaitingsStatReportItem> GetWaitingTimeByWeek (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to)
        {
             ApiResponse<List<WaitingsStatReportItem>> localVarResponse = GetWaitingTimeByWeekWithHttpInfo(restaurantId, from, to);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="from"> (optional)</param> 
        /// <param name="to"> (optional)</param> 
        /// <returns>ApiResponse of List&lt;WaitingsStatReportItem&gt;</returns>
        public ApiResponse< List<WaitingsStatReportItem> > GetWaitingTimeByWeekWithHttpInfo (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminWaitlistApi->GetWaitingTimeByWeek");
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/analytics/waitings/groupby/week";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetWaitingTimeByWeek: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWaitingTimeByWeek: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<WaitingsStatReportItem>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<WaitingsStatReportItem>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WaitingsStatReportItem>)));
            
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="from"> (optional)</param>
        /// <param name="to"> (optional)</param>
        /// <returns>Task of List&lt;WaitingsStatReportItem&gt;</returns>
        public async System.Threading.Tasks.Task<List<WaitingsStatReportItem>> GetWaitingTimeByWeekAsync (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to)
        {
             ApiResponse<List<WaitingsStatReportItem>> localVarResponse = await GetWaitingTimeByWeekAsyncWithHttpInfo(restaurantId, from, to);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="from"> (optional)</param>
        /// <param name="to"> (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;WaitingsStatReportItem&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<WaitingsStatReportItem>>> GetWaitingTimeByWeekAsyncWithHttpInfo (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling GetWaitingTimeByWeek");
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/analytics/waitings/groupby/week";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetWaitingTimeByWeek: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWaitingTimeByWeek: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<WaitingsStatReportItem>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<WaitingsStatReportItem>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WaitingsStatReportItem>)));
            
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="from"> (optional)</param> 
        /// <param name="to"> (optional)</param> 
        /// <returns>List&lt;WaitingsStatReportItem&gt;</returns>
        public List<WaitingsStatReportItem> GetWaitingTimeByWeekDay (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to)
        {
             ApiResponse<List<WaitingsStatReportItem>> localVarResponse = GetWaitingTimeByWeekDayWithHttpInfo(restaurantId, from, to);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="from"> (optional)</param> 
        /// <param name="to"> (optional)</param> 
        /// <returns>ApiResponse of List&lt;WaitingsStatReportItem&gt;</returns>
        public ApiResponse< List<WaitingsStatReportItem> > GetWaitingTimeByWeekDayWithHttpInfo (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminWaitlistApi->GetWaitingTimeByWeekDay");
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/analytics/waitings/groupby/weekday";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetWaitingTimeByWeekDay: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWaitingTimeByWeekDay: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<WaitingsStatReportItem>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<WaitingsStatReportItem>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WaitingsStatReportItem>)));
            
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="from"> (optional)</param>
        /// <param name="to"> (optional)</param>
        /// <returns>Task of List&lt;WaitingsStatReportItem&gt;</returns>
        public async System.Threading.Tasks.Task<List<WaitingsStatReportItem>> GetWaitingTimeByWeekDayAsync (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to)
        {
             ApiResponse<List<WaitingsStatReportItem>> localVarResponse = await GetWaitingTimeByWeekDayAsyncWithHttpInfo(restaurantId, from, to);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="from"> (optional)</param>
        /// <param name="to"> (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;WaitingsStatReportItem&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<WaitingsStatReportItem>>> GetWaitingTimeByWeekDayAsyncWithHttpInfo (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling GetWaitingTimeByWeekDay");
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/analytics/waitings/groupby/weekday";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetWaitingTimeByWeekDay: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWaitingTimeByWeekDay: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<WaitingsStatReportItem>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<WaitingsStatReportItem>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WaitingsStatReportItem>)));
            
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="from"> (optional)</param> 
        /// <param name="to"> (optional)</param> 
        /// <returns>List&lt;WaitingReportItem&gt;</returns>
        public List<WaitingReportItem> GetWaitingsForPeriod (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to)
        {
             ApiResponse<List<WaitingReportItem>> localVarResponse = GetWaitingsForPeriodWithHttpInfo(restaurantId, from, to);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="from"> (optional)</param> 
        /// <param name="to"> (optional)</param> 
        /// <returns>ApiResponse of List&lt;WaitingReportItem&gt;</returns>
        public ApiResponse< List<WaitingReportItem> > GetWaitingsForPeriodWithHttpInfo (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminWaitlistApi->GetWaitingsForPeriod");
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/analytics/waitings";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetWaitingsForPeriod: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWaitingsForPeriod: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<WaitingReportItem>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<WaitingReportItem>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WaitingReportItem>)));
            
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="from"> (optional)</param>
        /// <param name="to"> (optional)</param>
        /// <returns>Task of List&lt;WaitingReportItem&gt;</returns>
        public async System.Threading.Tasks.Task<List<WaitingReportItem>> GetWaitingsForPeriodAsync (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to)
        {
             ApiResponse<List<WaitingReportItem>> localVarResponse = await GetWaitingsForPeriodAsyncWithHttpInfo(restaurantId, from, to);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="from"> (optional)</param>
        /// <param name="to"> (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;WaitingReportItem&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<WaitingReportItem>>> GetWaitingsForPeriodAsyncWithHttpInfo (int? restaurantId, DateTimeOffset? from, DateTimeOffset? to)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling GetWaitingsForPeriod");
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/analytics/waitings";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetWaitingsForPeriod: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWaitingsForPeriod: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<WaitingReportItem>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<WaitingReportItem>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WaitingReportItem>)));
            
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="groupBy"></param> 
        /// <param name="from"> (optional)</param> 
        /// <param name="to"> (optional)</param> 
        /// <returns>List&lt;WaitingsStatReportItem&gt;</returns>
        public List<WaitingsStatReportItem> GetWaitingsGroupBy (int? restaurantId, string groupBy, DateTimeOffset? from, DateTimeOffset? to)
        {
             ApiResponse<List<WaitingsStatReportItem>> localVarResponse = GetWaitingsGroupByWithHttpInfo(restaurantId, groupBy, from, to);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="groupBy"></param> 
        /// <param name="from"> (optional)</param> 
        /// <param name="to"> (optional)</param> 
        /// <returns>ApiResponse of List&lt;WaitingsStatReportItem&gt;</returns>
        public ApiResponse< List<WaitingsStatReportItem> > GetWaitingsGroupByWithHttpInfo (int? restaurantId, string groupBy, DateTimeOffset? from, DateTimeOffset? to)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminWaitlistApi->GetWaitingsGroupBy");
            
            // verify the required parameter 'groupBy' is set
            if (groupBy == null)
                throw new ApiException(400, "Missing required parameter 'groupBy' when calling AdminWaitlistApi->GetWaitingsGroupBy");
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/analytics/waitings/groupby";
    
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
            if (groupBy != null) localVarQueryParams.Add("groupBy", Configuration.ApiClient.ParameterToString(groupBy)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling GetWaitingsGroupBy: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWaitingsGroupBy: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<WaitingsStatReportItem>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<WaitingsStatReportItem>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WaitingsStatReportItem>)));
            
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="groupBy"></param>
        /// <param name="from"> (optional)</param>
        /// <param name="to"> (optional)</param>
        /// <returns>Task of List&lt;WaitingsStatReportItem&gt;</returns>
        public async System.Threading.Tasks.Task<List<WaitingsStatReportItem>> GetWaitingsGroupByAsync (int? restaurantId, string groupBy, DateTimeOffset? from, DateTimeOffset? to)
        {
             ApiResponse<List<WaitingsStatReportItem>> localVarResponse = await GetWaitingsGroupByAsyncWithHttpInfo(restaurantId, groupBy, from, to);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="groupBy"></param>
        /// <param name="from"> (optional)</param>
        /// <param name="to"> (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;WaitingsStatReportItem&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<WaitingsStatReportItem>>> GetWaitingsGroupByAsyncWithHttpInfo (int? restaurantId, string groupBy, DateTimeOffset? from, DateTimeOffset? to)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling GetWaitingsGroupBy");
            // verify the required parameter 'groupBy' is set
            if (groupBy == null) throw new ApiException(400, "Missing required parameter 'groupBy' when calling GetWaitingsGroupBy");
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/analytics/waitings/groupby";
    
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
            if (groupBy != null) localVarQueryParams.Add("groupBy", Configuration.ApiClient.ParameterToString(groupBy)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling GetWaitingsGroupBy: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWaitingsGroupBy: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<WaitingsStatReportItem>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<WaitingsStatReportItem>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WaitingsStatReportItem>)));
            
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="from"></param> 
        /// <param name="to"></param> 
        /// <param name="body"></param> 
        /// <returns>Object</returns>
        public Object Incoming (string from, string to, string body)
        {
             ApiResponse<Object> localVarResponse = IncomingWithHttpInfo(from, to, body);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="from"></param> 
        /// <param name="to"></param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > IncomingWithHttpInfo (string from, string to, string body)
        {
            
            // verify the required parameter 'from' is set
            if (from == null)
                throw new ApiException(400, "Missing required parameter 'from' when calling AdminWaitlistApi->Incoming");
            
            // verify the required parameter 'to' is set
            if (to == null)
                throw new ApiException(400, "Missing required parameter 'to' when calling AdminWaitlistApi->Incoming");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AdminWaitlistApi->Incoming");
            
    
            var localVarPath = "/api/wm/admin/smsclient/incoming";
    
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
if (to != null) localVarQueryParams.Add("to", Configuration.ApiClient.ParameterToString(to)); // query parameter
if (body != null) localVarQueryParams.Add("body", Configuration.ApiClient.ParameterToString(body)); // query parameter
                                    

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
                throw new ApiException (localVarStatusCode, "Error calling Incoming: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Incoming: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="body"></param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> IncomingAsync (string from, string to, string body)
        {
             ApiResponse<Object> localVarResponse = await IncomingAsyncWithHttpInfo(from, to, body);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> IncomingAsyncWithHttpInfo (string from, string to, string body)
        {
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling Incoming");
            // verify the required parameter 'to' is set
            if (to == null) throw new ApiException(400, "Missing required parameter 'to' when calling Incoming");
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Incoming");
            
    
            var localVarPath = "/api/wm/admin/smsclient/incoming";
    
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
if (to != null) localVarQueryParams.Add("to", Configuration.ApiClient.ParameterToString(to)); // query parameter
if (body != null) localVarQueryParams.Add("body", Configuration.ApiClient.ParameterToString(body)); // query parameter
                                    

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
                throw new ApiException (localVarStatusCode, "Error calling Incoming: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Incoming: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        /// <summary>
        /// Mark all message as read. 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param> 
        /// <param name="waitingItemId">Waiting item identifier</param> 
        /// <returns></returns>
        public void MarkAllMessagesAsRead (int? restaurantId, int? waitingItemId)
        {
             MarkAllMessagesAsReadWithHttpInfo(restaurantId, waitingItemId);
        }

        /// <summary>
        /// Mark all message as read. 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param> 
        /// <param name="waitingItemId">Waiting item identifier</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> MarkAllMessagesAsReadWithHttpInfo (int? restaurantId, int? waitingItemId)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminWaitlistApi->MarkAllMessagesAsRead");
            
            // verify the required parameter 'waitingItemId' is set
            if (waitingItemId == null)
                throw new ApiException(400, "Missing required parameter 'waitingItemId' when calling AdminWaitlistApi->MarkAllMessagesAsRead");
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/waitings/{waitingItemId}/messages/readall";
    
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
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task MarkAllMessagesAsReadAsync (int? restaurantId, int? waitingItemId)
        {
             await MarkAllMessagesAsReadAsyncWithHttpInfo(restaurantId, waitingItemId);

        }

        /// <summary>
        /// Mark all message as read. 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> MarkAllMessagesAsReadAsyncWithHttpInfo (int? restaurantId, int? waitingItemId)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling MarkAllMessagesAsRead");
            // verify the required parameter 'waitingItemId' is set
            if (waitingItemId == null) throw new ApiException(400, "Missing required parameter 'waitingItemId' when calling MarkAllMessagesAsRead");
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/waitings/{waitingItemId}/messages/readall";
    
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
        /// Put waiting item, on hold manually 
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
        /// Put waiting item, on hold manually 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param> 
        /// <param name="waitingItemId">Waiting item identifier</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PutOnHoldWithHttpInfo (int? restaurantId, int? waitingItemId)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminWaitlistApi->PutOnHold");
            
            // verify the required parameter 'waitingItemId' is set
            if (waitingItemId == null)
                throw new ApiException(400, "Missing required parameter 'waitingItemId' when calling AdminWaitlistApi->PutOnHold");
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/waitings/{waitingItemId}/putonhold";
    
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
if (waitingItemId != null) localVarPathParams.Add("waitingItemId", Configuration.ApiClient.ParameterToString(waitingItemId)); // path parameter
                                                

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
                throw new ApiException (localVarStatusCode, "Error calling PutOnHold: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutOnHold: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Put waiting item, on hold manually 
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
        /// Put waiting item, on hold manually 
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
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/waitings/{waitingItemId}/putonhold";
    
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
if (waitingItemId != null) localVarPathParams.Add("waitingItemId", Configuration.ApiClient.ParameterToString(waitingItemId)); // path parameter
                                                

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
                throw new ApiException (localVarStatusCode, "Error calling PutOnHold: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutOnHold: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        /// <summary>
        /// Reopen closed waiting item 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param> 
        /// <param name="waitingItemId">Waiting item identifier</param> 
        /// <returns>WaitingItem</returns>
        public WaitingItem ReOpenWaiting (int? restaurantId, int? waitingItemId)
        {
             ApiResponse<WaitingItem> localVarResponse = ReOpenWaitingWithHttpInfo(restaurantId, waitingItemId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Reopen closed waiting item 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param> 
        /// <param name="waitingItemId">Waiting item identifier</param> 
        /// <returns>ApiResponse of WaitingItem</returns>
        public ApiResponse< WaitingItem > ReOpenWaitingWithHttpInfo (int? restaurantId, int? waitingItemId)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminWaitlistApi->ReOpenWaiting");
            
            // verify the required parameter 'waitingItemId' is set
            if (waitingItemId == null)
                throw new ApiException(400, "Missing required parameter 'waitingItemId' when calling AdminWaitlistApi->ReOpenWaiting");
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/waitings/{waitingItemId}/reopen";
    
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
if (waitingItemId != null) localVarPathParams.Add("waitingItemId", Configuration.ApiClient.ParameterToString(waitingItemId)); // path parameter
                                                

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
                throw new ApiException (localVarStatusCode, "Error calling ReOpenWaiting: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ReOpenWaiting: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<WaitingItem>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WaitingItem) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WaitingItem)));
            
        }

        /// <summary>
        /// Reopen closed waiting item 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <returns>Task of WaitingItem</returns>
        public async System.Threading.Tasks.Task<WaitingItem> ReOpenWaitingAsync (int? restaurantId, int? waitingItemId)
        {
             ApiResponse<WaitingItem> localVarResponse = await ReOpenWaitingAsyncWithHttpInfo(restaurantId, waitingItemId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Reopen closed waiting item 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <returns>Task of ApiResponse (WaitingItem)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WaitingItem>> ReOpenWaitingAsyncWithHttpInfo (int? restaurantId, int? waitingItemId)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling ReOpenWaiting");
            // verify the required parameter 'waitingItemId' is set
            if (waitingItemId == null) throw new ApiException(400, "Missing required parameter 'waitingItemId' when calling ReOpenWaiting");
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/waitings/{waitingItemId}/reopen";
    
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
if (waitingItemId != null) localVarPathParams.Add("waitingItemId", Configuration.ApiClient.ParameterToString(waitingItemId)); // path parameter
                                                

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
                throw new ApiException (localVarStatusCode, "Error calling ReOpenWaiting: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ReOpenWaiting: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WaitingItem>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WaitingItem) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WaitingItem)));
            
        }
        /// <summary>
        /// Sends a message related to specified waiting item. 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param> 
        /// <param name="waitingItemId">Waiting item identifier</param> 
        /// <param name="origin">This parameter specifies who send the message. It could be host or client.</param> 
        /// <param name="body">The body of the message</param> 
        /// <returns>Message</returns>
        public Message SendMessage (int? restaurantId, int? waitingItemId, string origin, string body)
        {
             ApiResponse<Message> localVarResponse = SendMessageWithHttpInfo(restaurantId, waitingItemId, origin, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Sends a message related to specified waiting item. 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param> 
        /// <param name="waitingItemId">Waiting item identifier</param> 
        /// <param name="origin">This parameter specifies who send the message. It could be host or client.</param> 
        /// <param name="body">The body of the message</param> 
        /// <returns>ApiResponse of Message</returns>
        public ApiResponse< Message > SendMessageWithHttpInfo (int? restaurantId, int? waitingItemId, string origin, string body)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminWaitlistApi->SendMessage");
            
            // verify the required parameter 'waitingItemId' is set
            if (waitingItemId == null)
                throw new ApiException(400, "Missing required parameter 'waitingItemId' when calling AdminWaitlistApi->SendMessage");
            
            // verify the required parameter 'origin' is set
            if (origin == null)
                throw new ApiException(400, "Missing required parameter 'origin' when calling AdminWaitlistApi->SendMessage");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AdminWaitlistApi->SendMessage");
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/waitings/{waitingItemId}/sendmessage";
    
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
if (waitingItemId != null) localVarPathParams.Add("waitingItemId", Configuration.ApiClient.ParameterToString(waitingItemId)); // path parameter
            if (origin != null) localVarQueryParams.Add("origin", Configuration.ApiClient.ParameterToString(origin)); // query parameter
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
        /// Sends a message related to specified waiting item. 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <param name="origin">This parameter specifies who send the message. It could be host or client.</param>
        /// <param name="body">The body of the message</param>
        /// <returns>Task of Message</returns>
        public async System.Threading.Tasks.Task<Message> SendMessageAsync (int? restaurantId, int? waitingItemId, string origin, string body)
        {
             ApiResponse<Message> localVarResponse = await SendMessageAsyncWithHttpInfo(restaurantId, waitingItemId, origin, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Sends a message related to specified waiting item. 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Restaurant identifier</param>
        /// <param name="waitingItemId">Waiting item identifier</param>
        /// <param name="origin">This parameter specifies who send the message. It could be host or client.</param>
        /// <param name="body">The body of the message</param>
        /// <returns>Task of ApiResponse (Message)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Message>> SendMessageAsyncWithHttpInfo (int? restaurantId, int? waitingItemId, string origin, string body)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling SendMessage");
            // verify the required parameter 'waitingItemId' is set
            if (waitingItemId == null) throw new ApiException(400, "Missing required parameter 'waitingItemId' when calling SendMessage");
            // verify the required parameter 'origin' is set
            if (origin == null) throw new ApiException(400, "Missing required parameter 'origin' when calling SendMessage");
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling SendMessage");
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/waitings/{waitingItemId}/sendmessage";
    
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
if (waitingItemId != null) localVarPathParams.Add("waitingItemId", Configuration.ApiClient.ParameterToString(waitingItemId)); // path parameter
            if (origin != null) localVarQueryParams.Add("origin", Configuration.ApiClient.ParameterToString(origin)); // query parameter
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
        /// <returns></returns>
        public void SetWaitingSettings (int? restaurantId, WaitingSettings settings)
        {
             SetWaitingSettingsWithHttpInfo(restaurantId, settings);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="settings"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> SetWaitingSettingsWithHttpInfo (int? restaurantId, WaitingSettings settings)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminWaitlistApi->SetWaitingSettings");
            
            // verify the required parameter 'settings' is set
            if (settings == null)
                throw new ApiException(400, "Missing required parameter 'settings' when calling AdminWaitlistApi->SetWaitingSettings");
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/settings";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SetWaitingSettings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SetWaitingSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="settings"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task SetWaitingSettingsAsync (int? restaurantId, WaitingSettings settings)
        {
             await SetWaitingSettingsAsyncWithHttpInfo(restaurantId, settings);

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="settings"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> SetWaitingSettingsAsyncWithHttpInfo (int? restaurantId, WaitingSettings settings)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling SetWaitingSettings");
            // verify the required parameter 'settings' is set
            if (settings == null) throw new ApiException(400, "Missing required parameter 'settings' when calling SetWaitingSettings");
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/settings";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SetWaitingSettings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SetWaitingSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
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
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminWaitlistApi->TakeOffHold");
            
            // verify the required parameter 'waitingItemId' is set
            if (waitingItemId == null)
                throw new ApiException(400, "Missing required parameter 'waitingItemId' when calling AdminWaitlistApi->TakeOffHold");
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/waitings/{waitingItemId}/takeoffhold";
    
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
if (waitingItemId != null) localVarPathParams.Add("waitingItemId", Configuration.ApiClient.ParameterToString(waitingItemId)); // path parameter
                                                

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
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/waitings/{waitingItemId}/takeoffhold";
    
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
if (waitingItemId != null) localVarPathParams.Add("waitingItemId", Configuration.ApiClient.ParameterToString(waitingItemId)); // path parameter
                                                

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
                throw new ApiException (localVarStatusCode, "Error calling TakeOffHold: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TakeOffHold: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        /// <summary>
        /// Update waitingitem 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Identifier of the restaurant registered in our system</param> 
        /// <param name="waitingItemId">Identifier of the waiting record in our system</param> 
        /// <param name="item">Update model of witing record</param> 
        /// <returns>WaitingItem</returns>
        public WaitingItem UpdateWaiting (int? restaurantId, int? waitingItemId, UpdateWaitingItemBindingModel item)
        {
             ApiResponse<WaitingItem> localVarResponse = UpdateWaitingWithHttpInfo(restaurantId, waitingItemId, item);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update waitingitem 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Identifier of the restaurant registered in our system</param> 
        /// <param name="waitingItemId">Identifier of the waiting record in our system</param> 
        /// <param name="item">Update model of witing record</param> 
        /// <returns>ApiResponse of WaitingItem</returns>
        public ApiResponse< WaitingItem > UpdateWaitingWithHttpInfo (int? restaurantId, int? waitingItemId, UpdateWaitingItemBindingModel item)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminWaitlistApi->UpdateWaiting");
            
            // verify the required parameter 'waitingItemId' is set
            if (waitingItemId == null)
                throw new ApiException(400, "Missing required parameter 'waitingItemId' when calling AdminWaitlistApi->UpdateWaiting");
            
            // verify the required parameter 'item' is set
            if (item == null)
                throw new ApiException(400, "Missing required parameter 'item' when calling AdminWaitlistApi->UpdateWaiting");
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/waitings/{waitingItemId}";
    
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
if (waitingItemId != null) localVarPathParams.Add("waitingItemId", Configuration.ApiClient.ParameterToString(waitingItemId)); // path parameter
                                                if (item.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(item); // http body (model) parameter
            }
            else
            {
                localVarPostBody = item; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateWaiting: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateWaiting: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<WaitingItem>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WaitingItem) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WaitingItem)));
            
        }

        /// <summary>
        /// Update waitingitem 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Identifier of the restaurant registered in our system</param>
        /// <param name="waitingItemId">Identifier of the waiting record in our system</param>
        /// <param name="item">Update model of witing record</param>
        /// <returns>Task of WaitingItem</returns>
        public async System.Threading.Tasks.Task<WaitingItem> UpdateWaitingAsync (int? restaurantId, int? waitingItemId, UpdateWaitingItemBindingModel item)
        {
             ApiResponse<WaitingItem> localVarResponse = await UpdateWaitingAsyncWithHttpInfo(restaurantId, waitingItemId, item);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update waitingitem 
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId">Identifier of the restaurant registered in our system</param>
        /// <param name="waitingItemId">Identifier of the waiting record in our system</param>
        /// <param name="item">Update model of witing record</param>
        /// <returns>Task of ApiResponse (WaitingItem)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WaitingItem>> UpdateWaitingAsyncWithHttpInfo (int? restaurantId, int? waitingItemId, UpdateWaitingItemBindingModel item)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling UpdateWaiting");
            // verify the required parameter 'waitingItemId' is set
            if (waitingItemId == null) throw new ApiException(400, "Missing required parameter 'waitingItemId' when calling UpdateWaiting");
            // verify the required parameter 'item' is set
            if (item == null) throw new ApiException(400, "Missing required parameter 'item' when calling UpdateWaiting");
            
    
            var localVarPath = "/api/wm/admin/restaurant/{restaurantId}/waitings/{waitingItemId}";
    
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
if (waitingItemId != null) localVarPathParams.Add("waitingItemId", Configuration.ApiClient.ParameterToString(waitingItemId)); // path parameter
                                                if (item.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(item); // http body (model) parameter
            }
            else
            {
                localVarPostBody = item; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateWaiting: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateWaiting: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WaitingItem>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WaitingItem) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WaitingItem)));
            
        }
    }
}
