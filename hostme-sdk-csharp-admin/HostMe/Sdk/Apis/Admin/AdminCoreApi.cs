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
    public interface IAdminCoreApi
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
        /// <returns>WithAccessTokenContract1RestaurantContract</returns>
        WithAccessTokenContract1RestaurantContract AddNewRestaurant (CreateRestaurant value);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value"></param>
        /// <returns>ApiResponse of WithAccessTokenContract1RestaurantContract</returns>
        ApiResponse<WithAccessTokenContract1RestaurantContract> AddNewRestaurantWithHttpInfo (CreateRestaurant value);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns></returns>
        void ChangePassword (ChangePassword model);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ChangePasswordWithHttpInfo (ChangePassword model);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invitationCode"></param>
        /// <param name="restaurantId"></param>
        /// <returns>InvitationInfo</returns>
        InvitationInfo CheckInvitationCode (string invitationCode, string restaurantId);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invitationCode"></param>
        /// <param name="restaurantId"></param>
        /// <returns>ApiResponse of InvitationInfo</returns>
        ApiResponse<InvitationInfo> CheckInvitationCodeWithHttpInfo (string invitationCode, string restaurantId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="invitation"></param>
        /// <returns>Token</returns>
        Token CreateInvitationCode (int? restaurantId, Invitation invitation);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="invitation"></param>
        /// <returns>ApiResponse of Token</returns>
        ApiResponse<Token> CreateInvitationCodeWithHttpInfo (int? restaurantId, Invitation invitation);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value"></param>
        /// <returns></returns>
        void CreateNewAccountWithRestaurant (CreateAccountWithRestaurant value);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CreateNewAccountWithRestaurantWithHttpInfo (CreateAccountWithRestaurant value);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="invitationCode"></param>
        /// <returns></returns>
        void DeleteInvitation (int? restaurantId, string invitationCode);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="invitationCode"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteInvitationWithHttpInfo (int? restaurantId, string invitationCode);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns></returns>
        void DeleteRestaurant (int? restaurantId);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteRestaurantWithHttpInfo (int? restaurantId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="userId"></param>
        /// <param name="role"></param>
        /// <returns></returns>
        void DeleteUser (int? restaurantId, string userId, string role);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="userId"></param>
        /// <param name="role"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteUserWithHttpInfo (int? restaurantId, string userId, string role);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phone"> (optional)</param>
        /// <param name="email"> (optional)</param>
        /// <returns>List&lt;Restaurant&gt;</returns>
        List<Restaurant> FindRestaurantsByUserPhone (string phone = null, string email = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phone"> (optional)</param>
        /// <param name="email"> (optional)</param>
        /// <returns>ApiResponse of List&lt;Restaurant&gt;</returns>
        ApiResponse<List<Restaurant>> FindRestaurantsByUserPhoneWithHttpInfo (string phone = null, string email = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phone"> (optional)</param>
        /// <param name="email"> (optional)</param>
        /// <returns>UserInfo</returns>
        UserInfo FindUserByPhoneAsync (string phone = null, string email = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phone"> (optional)</param>
        /// <param name="email"> (optional)</param>
        /// <returns>ApiResponse of UserInfo</returns>
        ApiResponse<UserInfo> FindUserByPhoneAsyncWithHttpInfo (string phone = null, string email = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Restaurant&gt;</returns>
        List<Restaurant> GetAllUserRestaurants ();
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Restaurant&gt;</returns>
        ApiResponse<List<Restaurant>> GetAllUserRestaurantsWithHttpInfo ();
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Object</returns>
        Object GetCustomSettings (int? restaurantId);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> GetCustomSettingsWithHttpInfo (int? restaurantId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>List&lt;InvitationInfo&gt;</returns>
        List<InvitationInfo> GetInvitations (int? restaurantId);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>ApiResponse of List&lt;InvitationInfo&gt;</returns>
        ApiResponse<List<InvitationInfo>> GetInvitationsWithHttpInfo (int? restaurantId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="tableNumber"> (optional)</param>
        /// <returns>Token</returns>
        Token GetRegistrationToken (int? restaurantId, string tableNumber = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="tableNumber"> (optional)</param>
        /// <returns>ApiResponse of Token</returns>
        ApiResponse<Token> GetRegistrationTokenWithHttpInfo (int? restaurantId, string tableNumber = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Restaurant</returns>
        Restaurant GetRestaurantById (int? restaurantId);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>ApiResponse of Restaurant</returns>
        ApiResponse<Restaurant> GetRestaurantByIdWithHttpInfo (int? restaurantId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>RestaurantConfiguration</returns>
        RestaurantConfiguration GetRestaurantConfiguration (int? restaurantId);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>ApiResponse of RestaurantConfiguration</returns>
        ApiResponse<RestaurantConfiguration> GetRestaurantConfigurationWithHttpInfo (int? restaurantId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>RestaurantSettings</returns>
        RestaurantSettings GetRestaurantSettings (int? restaurantId);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>ApiResponse of RestaurantSettings</returns>
        ApiResponse<RestaurantSettings> GetRestaurantSettingsWithHttpInfo (int? restaurantId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>UserProfile</returns>
        UserProfile GetUserProfile ();
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of UserProfile</returns>
        ApiResponse<UserProfile> GetUserProfileWithHttpInfo ();
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>List&lt;RestaurantUserInfo&gt;</returns>
        List<RestaurantUserInfo> GetUsers (int? restaurantId);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>ApiResponse of List&lt;RestaurantUserInfo&gt;</returns>
        ApiResponse<List<RestaurantUserInfo>> GetUsersWithHttpInfo (int? restaurantId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>UserInfo</returns>
        UserInfo Me ();
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of UserInfo</returns>
        ApiResponse<UserInfo> MeWithHttpInfo ();
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="image"></param>
        /// <returns></returns>
        void PostProfileImage (byte[] image);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="image"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostProfileImageWithHttpInfo (byte[] image);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>byte[]</returns>
        byte[] ProfileImage ();
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of byte[]</returns>
        ApiResponse<byte[]> ProfileImageWithHttpInfo ();
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns></returns>
        void Register (RegisterUser model);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> RegisterWithHttpInfo (RegisterUser model);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="invitationCode"></param>
        /// <returns></returns>
        void Reinvite (int? restaurantId, string invitationCode);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="invitationCode"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ReinviteWithHttpInfo (int? restaurantId, string invitationCode);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns></returns>
        void ResetPassword (ResetPassword model);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ResetPasswordWithHttpInfo (ResetPassword model);
        
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
        void SetCustomSettings (int? restaurantId, ModelObject settings);
  
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
        ApiResponse<Object> SetCustomSettingsWithHttpInfo (int? restaurantId, ModelObject settings);
        
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
        void SetRestaurantSettings (int? restaurantId, RestaurantSettings settings);
  
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
        ApiResponse<Object> SetRestaurantSettingsWithHttpInfo (int? restaurantId, RestaurantSettings settings);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="value"></param>
        /// <returns>Restaurant</returns>
        Restaurant UpdateRestaurant (int? restaurantId, Restaurant value);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="value"></param>
        /// <returns>ApiResponse of Restaurant</returns>
        ApiResponse<Restaurant> UpdateRestaurantWithHttpInfo (int? restaurantId, Restaurant value);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profile"></param>
        /// <returns></returns>
        void UpdateUserProfile (UserProfile profile);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profile"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateUserProfileWithHttpInfo (UserProfile profile);
        
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
        /// <returns>Task of WithAccessTokenContract1RestaurantContract</returns>
        System.Threading.Tasks.Task<WithAccessTokenContract1RestaurantContract> AddNewRestaurantAsync (CreateRestaurant value);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value"></param>
        /// <returns>Task of ApiResponse (WithAccessTokenContract1RestaurantContract)</returns>
        System.Threading.Tasks.Task<ApiResponse<WithAccessTokenContract1RestaurantContract>> AddNewRestaurantAsyncWithHttpInfo (CreateRestaurant value);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ChangePasswordAsync (ChangePassword model);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ChangePasswordAsyncWithHttpInfo (ChangePassword model);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invitationCode"></param>
        /// <param name="restaurantId"></param>
        /// <returns>Task of InvitationInfo</returns>
        System.Threading.Tasks.Task<InvitationInfo> CheckInvitationCodeAsync (string invitationCode, string restaurantId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invitationCode"></param>
        /// <param name="restaurantId"></param>
        /// <returns>Task of ApiResponse (InvitationInfo)</returns>
        System.Threading.Tasks.Task<ApiResponse<InvitationInfo>> CheckInvitationCodeAsyncWithHttpInfo (string invitationCode, string restaurantId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="invitation"></param>
        /// <returns>Task of Token</returns>
        System.Threading.Tasks.Task<Token> CreateInvitationCodeAsync (int? restaurantId, Invitation invitation);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="invitation"></param>
        /// <returns>Task of ApiResponse (Token)</returns>
        System.Threading.Tasks.Task<ApiResponse<Token>> CreateInvitationCodeAsyncWithHttpInfo (int? restaurantId, Invitation invitation);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task CreateNewAccountWithRestaurantAsync (CreateAccountWithRestaurant value);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CreateNewAccountWithRestaurantAsyncWithHttpInfo (CreateAccountWithRestaurant value);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="invitationCode"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteInvitationAsync (int? restaurantId, string invitationCode);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="invitationCode"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteInvitationAsyncWithHttpInfo (int? restaurantId, string invitationCode);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteRestaurantAsync (int? restaurantId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteRestaurantAsyncWithHttpInfo (int? restaurantId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="userId"></param>
        /// <param name="role"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteUserAsync (int? restaurantId, string userId, string role);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="userId"></param>
        /// <param name="role"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteUserAsyncWithHttpInfo (int? restaurantId, string userId, string role);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phone"> (optional)</param>
        /// <param name="email"> (optional)</param>
        /// <returns>Task of List&lt;Restaurant&gt;</returns>
        System.Threading.Tasks.Task<List<Restaurant>> FindRestaurantsByUserPhoneAsync (string phone = null, string email = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phone"> (optional)</param>
        /// <param name="email"> (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Restaurant&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Restaurant>>> FindRestaurantsByUserPhoneAsyncWithHttpInfo (string phone = null, string email = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phone"> (optional)</param>
        /// <param name="email"> (optional)</param>
        /// <returns>Task of UserInfo</returns>
        System.Threading.Tasks.Task<UserInfo> FindUserByPhoneAsyncAsync (string phone = null, string email = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phone"> (optional)</param>
        /// <param name="email"> (optional)</param>
        /// <returns>Task of ApiResponse (UserInfo)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserInfo>> FindUserByPhoneAsyncAsyncWithHttpInfo (string phone = null, string email = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Restaurant&gt;</returns>
        System.Threading.Tasks.Task<List<Restaurant>> GetAllUserRestaurantsAsync ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Restaurant&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Restaurant>>> GetAllUserRestaurantsAsyncWithHttpInfo ();
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> GetCustomSettingsAsync (int? restaurantId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetCustomSettingsAsyncWithHttpInfo (int? restaurantId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Task of List&lt;InvitationInfo&gt;</returns>
        System.Threading.Tasks.Task<List<InvitationInfo>> GetInvitationsAsync (int? restaurantId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Task of ApiResponse (List&lt;InvitationInfo&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<InvitationInfo>>> GetInvitationsAsyncWithHttpInfo (int? restaurantId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="tableNumber"> (optional)</param>
        /// <returns>Task of Token</returns>
        System.Threading.Tasks.Task<Token> GetRegistrationTokenAsync (int? restaurantId, string tableNumber = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="tableNumber"> (optional)</param>
        /// <returns>Task of ApiResponse (Token)</returns>
        System.Threading.Tasks.Task<ApiResponse<Token>> GetRegistrationTokenAsyncWithHttpInfo (int? restaurantId, string tableNumber = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Task of Restaurant</returns>
        System.Threading.Tasks.Task<Restaurant> GetRestaurantByIdAsync (int? restaurantId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Task of ApiResponse (Restaurant)</returns>
        System.Threading.Tasks.Task<ApiResponse<Restaurant>> GetRestaurantByIdAsyncWithHttpInfo (int? restaurantId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Task of RestaurantConfiguration</returns>
        System.Threading.Tasks.Task<RestaurantConfiguration> GetRestaurantConfigurationAsync (int? restaurantId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Task of ApiResponse (RestaurantConfiguration)</returns>
        System.Threading.Tasks.Task<ApiResponse<RestaurantConfiguration>> GetRestaurantConfigurationAsyncWithHttpInfo (int? restaurantId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Task of RestaurantSettings</returns>
        System.Threading.Tasks.Task<RestaurantSettings> GetRestaurantSettingsAsync (int? restaurantId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Task of ApiResponse (RestaurantSettings)</returns>
        System.Threading.Tasks.Task<ApiResponse<RestaurantSettings>> GetRestaurantSettingsAsyncWithHttpInfo (int? restaurantId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of UserProfile</returns>
        System.Threading.Tasks.Task<UserProfile> GetUserProfileAsync ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (UserProfile)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserProfile>> GetUserProfileAsyncWithHttpInfo ();
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Task of List&lt;RestaurantUserInfo&gt;</returns>
        System.Threading.Tasks.Task<List<RestaurantUserInfo>> GetUsersAsync (int? restaurantId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Task of ApiResponse (List&lt;RestaurantUserInfo&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<RestaurantUserInfo>>> GetUsersAsyncWithHttpInfo (int? restaurantId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of UserInfo</returns>
        System.Threading.Tasks.Task<UserInfo> MeAsync ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (UserInfo)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserInfo>> MeAsyncWithHttpInfo ();
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="image"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostProfileImageAsync (byte[] image);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="image"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostProfileImageAsyncWithHttpInfo (byte[] image);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of byte[]</returns>
        System.Threading.Tasks.Task<byte[]> ProfileImageAsync ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (byte[])</returns>
        System.Threading.Tasks.Task<ApiResponse<byte[]>> ProfileImageAsyncWithHttpInfo ();
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task RegisterAsync (RegisterUser model);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> RegisterAsyncWithHttpInfo (RegisterUser model);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="invitationCode"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ReinviteAsync (int? restaurantId, string invitationCode);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="invitationCode"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ReinviteAsyncWithHttpInfo (int? restaurantId, string invitationCode);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ResetPasswordAsync (ResetPassword model);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ResetPasswordAsyncWithHttpInfo (ResetPassword model);
        
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
        System.Threading.Tasks.Task SetCustomSettingsAsync (int? restaurantId, ModelObject settings);

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
        System.Threading.Tasks.Task<ApiResponse<Object>> SetCustomSettingsAsyncWithHttpInfo (int? restaurantId, ModelObject settings);
        
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
        System.Threading.Tasks.Task SetRestaurantSettingsAsync (int? restaurantId, RestaurantSettings settings);

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
        System.Threading.Tasks.Task<ApiResponse<Object>> SetRestaurantSettingsAsyncWithHttpInfo (int? restaurantId, RestaurantSettings settings);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="value"></param>
        /// <returns>Task of Restaurant</returns>
        System.Threading.Tasks.Task<Restaurant> UpdateRestaurantAsync (int? restaurantId, Restaurant value);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="value"></param>
        /// <returns>Task of ApiResponse (Restaurant)</returns>
        System.Threading.Tasks.Task<ApiResponse<Restaurant>> UpdateRestaurantAsyncWithHttpInfo (int? restaurantId, Restaurant value);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profile"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateUserProfileAsync (UserProfile profile);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profile"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateUserProfileAsyncWithHttpInfo (UserProfile profile);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AdminCoreApi : IAdminCoreApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdminCoreApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AdminCoreApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AdminCoreApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AdminCoreApi(Configuration configuration = null)
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
        /// <returns>WithAccessTokenContract1RestaurantContract</returns>
        public WithAccessTokenContract1RestaurantContract AddNewRestaurant (CreateRestaurant value)
        {
             ApiResponse<WithAccessTokenContract1RestaurantContract> localVarResponse = AddNewRestaurantWithHttpInfo(value);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value"></param> 
        /// <returns>ApiResponse of WithAccessTokenContract1RestaurantContract</returns>
        public ApiResponse< WithAccessTokenContract1RestaurantContract > AddNewRestaurantWithHttpInfo (CreateRestaurant value)
        {
            
            // verify the required parameter 'value' is set
            if (value == null)
                throw new ApiException(400, "Missing required parameter 'value' when calling AdminCoreApi->AddNewRestaurant");
            
    
            var localVarPath = "/api/core/admin/restaurants";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddNewRestaurant: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddNewRestaurant: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<WithAccessTokenContract1RestaurantContract>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WithAccessTokenContract1RestaurantContract) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WithAccessTokenContract1RestaurantContract)));
            
        }

        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value"></param>
        /// <returns>Task of WithAccessTokenContract1RestaurantContract</returns>
        public async System.Threading.Tasks.Task<WithAccessTokenContract1RestaurantContract> AddNewRestaurantAsync (CreateRestaurant value)
        {
             ApiResponse<WithAccessTokenContract1RestaurantContract> localVarResponse = await AddNewRestaurantAsyncWithHttpInfo(value);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value"></param>
        /// <returns>Task of ApiResponse (WithAccessTokenContract1RestaurantContract)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WithAccessTokenContract1RestaurantContract>> AddNewRestaurantAsyncWithHttpInfo (CreateRestaurant value)
        {
            // verify the required parameter 'value' is set
            if (value == null) throw new ApiException(400, "Missing required parameter 'value' when calling AddNewRestaurant");
            
    
            var localVarPath = "/api/core/admin/restaurants";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddNewRestaurant: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddNewRestaurant: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WithAccessTokenContract1RestaurantContract>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WithAccessTokenContract1RestaurantContract) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WithAccessTokenContract1RestaurantContract)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param> 
        /// <returns></returns>
        public void ChangePassword (ChangePassword model)
        {
             ChangePasswordWithHttpInfo(model);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ChangePasswordWithHttpInfo (ChangePassword model)
        {
            
            // verify the required parameter 'model' is set
            if (model == null)
                throw new ApiException(400, "Missing required parameter 'model' when calling AdminCoreApi->ChangePassword");
            
    
            var localVarPath = "/api/core/admin/account/password/change";
    
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
            
            
            
            
            if (model.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(model); // http body (model) parameter
            }
            else
            {
                localVarPostBody = model; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling ChangePassword: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ChangePassword: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ChangePasswordAsync (ChangePassword model)
        {
             await ChangePasswordAsyncWithHttpInfo(model);

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ChangePasswordAsyncWithHttpInfo (ChangePassword model)
        {
            // verify the required parameter 'model' is set
            if (model == null) throw new ApiException(400, "Missing required parameter 'model' when calling ChangePassword");
            
    
            var localVarPath = "/api/core/admin/account/password/change";
    
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
            
            
            
            
            if (model.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(model); // http body (model) parameter
            }
            else
            {
                localVarPostBody = model; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling ChangePassword: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ChangePassword: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invitationCode"></param> 
        /// <param name="restaurantId"></param> 
        /// <returns>InvitationInfo</returns>
        public InvitationInfo CheckInvitationCode (string invitationCode, string restaurantId)
        {
             ApiResponse<InvitationInfo> localVarResponse = CheckInvitationCodeWithHttpInfo(invitationCode, restaurantId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invitationCode"></param> 
        /// <param name="restaurantId"></param> 
        /// <returns>ApiResponse of InvitationInfo</returns>
        public ApiResponse< InvitationInfo > CheckInvitationCodeWithHttpInfo (string invitationCode, string restaurantId)
        {
            
            // verify the required parameter 'invitationCode' is set
            if (invitationCode == null)
                throw new ApiException(400, "Missing required parameter 'invitationCode' when calling AdminCoreApi->CheckInvitationCode");
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminCoreApi->CheckInvitationCode");
            
    
            var localVarPath = "/api/core/admin/restaurants/{restaurantId}/invitations/{invitationCode}";
    
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
            if (invitationCode != null) localVarPathParams.Add("invitationCode", Configuration.ApiClient.ParameterToString(invitationCode)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling CheckInvitationCode: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CheckInvitationCode: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<InvitationInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InvitationInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InvitationInfo)));
            
        }

        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invitationCode"></param>
        /// <param name="restaurantId"></param>
        /// <returns>Task of InvitationInfo</returns>
        public async System.Threading.Tasks.Task<InvitationInfo> CheckInvitationCodeAsync (string invitationCode, string restaurantId)
        {
             ApiResponse<InvitationInfo> localVarResponse = await CheckInvitationCodeAsyncWithHttpInfo(invitationCode, restaurantId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invitationCode"></param>
        /// <param name="restaurantId"></param>
        /// <returns>Task of ApiResponse (InvitationInfo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InvitationInfo>> CheckInvitationCodeAsyncWithHttpInfo (string invitationCode, string restaurantId)
        {
            // verify the required parameter 'invitationCode' is set
            if (invitationCode == null) throw new ApiException(400, "Missing required parameter 'invitationCode' when calling CheckInvitationCode");
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling CheckInvitationCode");
            
    
            var localVarPath = "/api/core/admin/restaurants/{restaurantId}/invitations/{invitationCode}";
    
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
            if (invitationCode != null) localVarPathParams.Add("invitationCode", Configuration.ApiClient.ParameterToString(invitationCode)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling CheckInvitationCode: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CheckInvitationCode: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InvitationInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InvitationInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InvitationInfo)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="invitation"></param> 
        /// <returns>Token</returns>
        public Token CreateInvitationCode (int? restaurantId, Invitation invitation)
        {
             ApiResponse<Token> localVarResponse = CreateInvitationCodeWithHttpInfo(restaurantId, invitation);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="invitation"></param> 
        /// <returns>ApiResponse of Token</returns>
        public ApiResponse< Token > CreateInvitationCodeWithHttpInfo (int? restaurantId, Invitation invitation)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminCoreApi->CreateInvitationCode");
            
            // verify the required parameter 'invitation' is set
            if (invitation == null)
                throw new ApiException(400, "Missing required parameter 'invitation' when calling AdminCoreApi->CreateInvitationCode");
            
    
            var localVarPath = "/api/core/admin/restaurants/{restaurantId}/invitations";
    
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
            
            
            
            
            if (invitation.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(invitation); // http body (model) parameter
            }
            else
            {
                localVarPostBody = invitation; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling CreateInvitationCode: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CreateInvitationCode: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Token>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Token) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Token)));
            
        }

        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="invitation"></param>
        /// <returns>Task of Token</returns>
        public async System.Threading.Tasks.Task<Token> CreateInvitationCodeAsync (int? restaurantId, Invitation invitation)
        {
             ApiResponse<Token> localVarResponse = await CreateInvitationCodeAsyncWithHttpInfo(restaurantId, invitation);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="invitation"></param>
        /// <returns>Task of ApiResponse (Token)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Token>> CreateInvitationCodeAsyncWithHttpInfo (int? restaurantId, Invitation invitation)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling CreateInvitationCode");
            // verify the required parameter 'invitation' is set
            if (invitation == null) throw new ApiException(400, "Missing required parameter 'invitation' when calling CreateInvitationCode");
            
    
            var localVarPath = "/api/core/admin/restaurants/{restaurantId}/invitations";
    
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
            
            
            
            
            if (invitation.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(invitation); // http body (model) parameter
            }
            else
            {
                localVarPostBody = invitation; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling CreateInvitationCode: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CreateInvitationCode: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Token>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Token) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Token)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value"></param> 
        /// <returns></returns>
        public void CreateNewAccountWithRestaurant (CreateAccountWithRestaurant value)
        {
             CreateNewAccountWithRestaurantWithHttpInfo(value);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> CreateNewAccountWithRestaurantWithHttpInfo (CreateAccountWithRestaurant value)
        {
            
            // verify the required parameter 'value' is set
            if (value == null)
                throw new ApiException(400, "Missing required parameter 'value' when calling AdminCoreApi->CreateNewAccountWithRestaurant");
            
    
            var localVarPath = "/api/core/admin/tenant/restaurants";
    
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
                throw new ApiException (localVarStatusCode, "Error calling CreateNewAccountWithRestaurant: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CreateNewAccountWithRestaurant: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task CreateNewAccountWithRestaurantAsync (CreateAccountWithRestaurant value)
        {
             await CreateNewAccountWithRestaurantAsyncWithHttpInfo(value);

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> CreateNewAccountWithRestaurantAsyncWithHttpInfo (CreateAccountWithRestaurant value)
        {
            // verify the required parameter 'value' is set
            if (value == null) throw new ApiException(400, "Missing required parameter 'value' when calling CreateNewAccountWithRestaurant");
            
    
            var localVarPath = "/api/core/admin/tenant/restaurants";
    
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
                throw new ApiException (localVarStatusCode, "Error calling CreateNewAccountWithRestaurant: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CreateNewAccountWithRestaurant: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="invitationCode"></param> 
        /// <returns></returns>
        public void DeleteInvitation (int? restaurantId, string invitationCode)
        {
             DeleteInvitationWithHttpInfo(restaurantId, invitationCode);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="invitationCode"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteInvitationWithHttpInfo (int? restaurantId, string invitationCode)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminCoreApi->DeleteInvitation");
            
            // verify the required parameter 'invitationCode' is set
            if (invitationCode == null)
                throw new ApiException(400, "Missing required parameter 'invitationCode' when calling AdminCoreApi->DeleteInvitation");
            
    
            var localVarPath = "/api/core/admin/restaurants/{restaurantId}/invitations/{invitationCode}";
    
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
            if (invitationCode != null) localVarPathParams.Add("invitationCode", Configuration.ApiClient.ParameterToString(invitationCode)); // path parameter
            
            
            
            
            

            // authentication (oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteInvitation: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteInvitation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="invitationCode"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteInvitationAsync (int? restaurantId, string invitationCode)
        {
             await DeleteInvitationAsyncWithHttpInfo(restaurantId, invitationCode);

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="invitationCode"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteInvitationAsyncWithHttpInfo (int? restaurantId, string invitationCode)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling DeleteInvitation");
            // verify the required parameter 'invitationCode' is set
            if (invitationCode == null) throw new ApiException(400, "Missing required parameter 'invitationCode' when calling DeleteInvitation");
            
    
            var localVarPath = "/api/core/admin/restaurants/{restaurantId}/invitations/{invitationCode}";
    
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
            if (invitationCode != null) localVarPathParams.Add("invitationCode", Configuration.ApiClient.ParameterToString(invitationCode)); // path parameter
            
            
            
            
            

            
            // authentication (oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteInvitation: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteInvitation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <returns></returns>
        public void DeleteRestaurant (int? restaurantId)
        {
             DeleteRestaurantWithHttpInfo(restaurantId);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteRestaurantWithHttpInfo (int? restaurantId)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminCoreApi->DeleteRestaurant");
            
    
            var localVarPath = "/api/core/admin/restaurants/{restaurantId}";
    
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
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteRestaurant: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteRestaurant: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteRestaurantAsync (int? restaurantId)
        {
             await DeleteRestaurantAsyncWithHttpInfo(restaurantId);

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteRestaurantAsyncWithHttpInfo (int? restaurantId)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling DeleteRestaurant");
            
    
            var localVarPath = "/api/core/admin/restaurants/{restaurantId}";
    
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
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteRestaurant: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteRestaurant: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="userId"></param> 
        /// <param name="role"></param> 
        /// <returns></returns>
        public void DeleteUser (int? restaurantId, string userId, string role)
        {
             DeleteUserWithHttpInfo(restaurantId, userId, role);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="userId"></param> 
        /// <param name="role"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteUserWithHttpInfo (int? restaurantId, string userId, string role)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminCoreApi->DeleteUser");
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling AdminCoreApi->DeleteUser");
            
            // verify the required parameter 'role' is set
            if (role == null)
                throw new ApiException(400, "Missing required parameter 'role' when calling AdminCoreApi->DeleteUser");
            
    
            var localVarPath = "/api/core/admin/restaurants/{restaurantId}/users/{userId}";
    
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
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            if (role != null) localVarQueryParams.Add("role", Configuration.ApiClient.ParameterToString(role)); // query parameter
            
            
            
            

            // authentication (oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteUser: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="userId"></param>
        /// <param name="role"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteUserAsync (int? restaurantId, string userId, string role)
        {
             await DeleteUserAsyncWithHttpInfo(restaurantId, userId, role);

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="userId"></param>
        /// <param name="role"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteUserAsyncWithHttpInfo (int? restaurantId, string userId, string role)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling DeleteUser");
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling DeleteUser");
            // verify the required parameter 'role' is set
            if (role == null) throw new ApiException(400, "Missing required parameter 'role' when calling DeleteUser");
            
    
            var localVarPath = "/api/core/admin/restaurants/{restaurantId}/users/{userId}";
    
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
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            if (role != null) localVarQueryParams.Add("role", Configuration.ApiClient.ParameterToString(role)); // query parameter
            
            
            
            

            
            // authentication (oauth2) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteUser: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phone"> (optional)</param> 
        /// <param name="email"> (optional)</param> 
        /// <returns>List&lt;Restaurant&gt;</returns>
        public List<Restaurant> FindRestaurantsByUserPhone (string phone = null, string email = null)
        {
             ApiResponse<List<Restaurant>> localVarResponse = FindRestaurantsByUserPhoneWithHttpInfo(phone, email);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phone"> (optional)</param> 
        /// <param name="email"> (optional)</param> 
        /// <returns>ApiResponse of List&lt;Restaurant&gt;</returns>
        public ApiResponse< List<Restaurant> > FindRestaurantsByUserPhoneWithHttpInfo (string phone = null, string email = null)
        {
            
    
            var localVarPath = "/api/core/admin/tenant/restaurants/find";
    
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
            
            if (phone != null) localVarQueryParams.Add("phone", Configuration.ApiClient.ParameterToString(phone)); // query parameter
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling FindRestaurantsByUserPhone: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling FindRestaurantsByUserPhone: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<Restaurant>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Restaurant>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Restaurant>)));
            
        }

        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phone"> (optional)</param>
        /// <param name="email"> (optional)</param>
        /// <returns>Task of List&lt;Restaurant&gt;</returns>
        public async System.Threading.Tasks.Task<List<Restaurant>> FindRestaurantsByUserPhoneAsync (string phone = null, string email = null)
        {
             ApiResponse<List<Restaurant>> localVarResponse = await FindRestaurantsByUserPhoneAsyncWithHttpInfo(phone, email);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phone"> (optional)</param>
        /// <param name="email"> (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Restaurant&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Restaurant>>> FindRestaurantsByUserPhoneAsyncWithHttpInfo (string phone = null, string email = null)
        {
            
    
            var localVarPath = "/api/core/admin/tenant/restaurants/find";
    
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
            
            if (phone != null) localVarQueryParams.Add("phone", Configuration.ApiClient.ParameterToString(phone)); // query parameter
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling FindRestaurantsByUserPhone: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling FindRestaurantsByUserPhone: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Restaurant>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Restaurant>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Restaurant>)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phone"> (optional)</param> 
        /// <param name="email"> (optional)</param> 
        /// <returns>UserInfo</returns>
        public UserInfo FindUserByPhoneAsync (string phone = null, string email = null)
        {
             ApiResponse<UserInfo> localVarResponse = FindUserByPhoneAsyncWithHttpInfo(phone, email);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phone"> (optional)</param> 
        /// <param name="email"> (optional)</param> 
        /// <returns>ApiResponse of UserInfo</returns>
        public ApiResponse< UserInfo > FindUserByPhoneAsyncWithHttpInfo (string phone = null, string email = null)
        {
            
    
            var localVarPath = "/api/core/admin/tenant/users/find";
    
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
            
            if (phone != null) localVarQueryParams.Add("phone", Configuration.ApiClient.ParameterToString(phone)); // query parameter
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling FindUserByPhoneAsync: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling FindUserByPhoneAsync: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<UserInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserInfo)));
            
        }

        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phone"> (optional)</param>
        /// <param name="email"> (optional)</param>
        /// <returns>Task of UserInfo</returns>
        public async System.Threading.Tasks.Task<UserInfo> FindUserByPhoneAsyncAsync (string phone = null, string email = null)
        {
             ApiResponse<UserInfo> localVarResponse = await FindUserByPhoneAsyncAsyncWithHttpInfo(phone, email);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phone"> (optional)</param>
        /// <param name="email"> (optional)</param>
        /// <returns>Task of ApiResponse (UserInfo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserInfo>> FindUserByPhoneAsyncAsyncWithHttpInfo (string phone = null, string email = null)
        {
            
    
            var localVarPath = "/api/core/admin/tenant/users/find";
    
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
            
            if (phone != null) localVarQueryParams.Add("phone", Configuration.ApiClient.ParameterToString(phone)); // query parameter
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling FindUserByPhoneAsync: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling FindUserByPhoneAsync: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserInfo)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Restaurant&gt;</returns>
        public List<Restaurant> GetAllUserRestaurants ()
        {
             ApiResponse<List<Restaurant>> localVarResponse = GetAllUserRestaurantsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Restaurant&gt;</returns>
        public ApiResponse< List<Restaurant> > GetAllUserRestaurantsWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/core/admin/restaurants";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetAllUserRestaurants: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAllUserRestaurants: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<Restaurant>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Restaurant>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Restaurant>)));
            
        }

        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Restaurant&gt;</returns>
        public async System.Threading.Tasks.Task<List<Restaurant>> GetAllUserRestaurantsAsync ()
        {
             ApiResponse<List<Restaurant>> localVarResponse = await GetAllUserRestaurantsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Restaurant&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Restaurant>>> GetAllUserRestaurantsAsyncWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/core/admin/restaurants";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetAllUserRestaurants: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAllUserRestaurants: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Restaurant>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Restaurant>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Restaurant>)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <returns>Object</returns>
        public Object GetCustomSettings (int? restaurantId)
        {
             ApiResponse<Object> localVarResponse = GetCustomSettingsWithHttpInfo(restaurantId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > GetCustomSettingsWithHttpInfo (int? restaurantId)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminCoreApi->GetCustomSettings");
            
    
            var localVarPath = "/api/core/admin/restaurants/{restaurantId}/settings/custom";
    
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
                "application/json", "text/json"
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
                throw new ApiException (localVarStatusCode, "Error calling GetCustomSettings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCustomSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> GetCustomSettingsAsync (int? restaurantId)
        {
             ApiResponse<Object> localVarResponse = await GetCustomSettingsAsyncWithHttpInfo(restaurantId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetCustomSettingsAsyncWithHttpInfo (int? restaurantId)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling GetCustomSettings");
            
    
            var localVarPath = "/api/core/admin/restaurants/{restaurantId}/settings/custom";
    
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
                "application/json", "text/json"
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
                throw new ApiException (localVarStatusCode, "Error calling GetCustomSettings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCustomSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <returns>List&lt;InvitationInfo&gt;</returns>
        public List<InvitationInfo> GetInvitations (int? restaurantId)
        {
             ApiResponse<List<InvitationInfo>> localVarResponse = GetInvitationsWithHttpInfo(restaurantId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <returns>ApiResponse of List&lt;InvitationInfo&gt;</returns>
        public ApiResponse< List<InvitationInfo> > GetInvitationsWithHttpInfo (int? restaurantId)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminCoreApi->GetInvitations");
            
    
            var localVarPath = "/api/core/admin/restaurants/{restaurantId}/invitations";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetInvitations: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInvitations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<InvitationInfo>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<InvitationInfo>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<InvitationInfo>)));
            
        }

        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Task of List&lt;InvitationInfo&gt;</returns>
        public async System.Threading.Tasks.Task<List<InvitationInfo>> GetInvitationsAsync (int? restaurantId)
        {
             ApiResponse<List<InvitationInfo>> localVarResponse = await GetInvitationsAsyncWithHttpInfo(restaurantId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Task of ApiResponse (List&lt;InvitationInfo&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<InvitationInfo>>> GetInvitationsAsyncWithHttpInfo (int? restaurantId)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling GetInvitations");
            
    
            var localVarPath = "/api/core/admin/restaurants/{restaurantId}/invitations";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetInvitations: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInvitations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<InvitationInfo>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<InvitationInfo>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<InvitationInfo>)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="tableNumber"> (optional)</param> 
        /// <returns>Token</returns>
        public Token GetRegistrationToken (int? restaurantId, string tableNumber = null)
        {
             ApiResponse<Token> localVarResponse = GetRegistrationTokenWithHttpInfo(restaurantId, tableNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="tableNumber"> (optional)</param> 
        /// <returns>ApiResponse of Token</returns>
        public ApiResponse< Token > GetRegistrationTokenWithHttpInfo (int? restaurantId, string tableNumber = null)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminCoreApi->GetRegistrationToken");
            
    
            var localVarPath = "/api/core/admin/restaurants/{restaurantId}/loyalty/token";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetRegistrationToken: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRegistrationToken: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Token>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Token) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Token)));
            
        }

        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="tableNumber"> (optional)</param>
        /// <returns>Task of Token</returns>
        public async System.Threading.Tasks.Task<Token> GetRegistrationTokenAsync (int? restaurantId, string tableNumber = null)
        {
             ApiResponse<Token> localVarResponse = await GetRegistrationTokenAsyncWithHttpInfo(restaurantId, tableNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="tableNumber"> (optional)</param>
        /// <returns>Task of ApiResponse (Token)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Token>> GetRegistrationTokenAsyncWithHttpInfo (int? restaurantId, string tableNumber = null)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling GetRegistrationToken");
            
    
            var localVarPath = "/api/core/admin/restaurants/{restaurantId}/loyalty/token";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetRegistrationToken: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRegistrationToken: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Token>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Token) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Token)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <returns>Restaurant</returns>
        public Restaurant GetRestaurantById (int? restaurantId)
        {
             ApiResponse<Restaurant> localVarResponse = GetRestaurantByIdWithHttpInfo(restaurantId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <returns>ApiResponse of Restaurant</returns>
        public ApiResponse< Restaurant > GetRestaurantByIdWithHttpInfo (int? restaurantId)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminCoreApi->GetRestaurantById");
            
    
            var localVarPath = "/api/core/admin/restaurants/{restaurantId}";
    
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
    
            return new ApiResponse<Restaurant>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Restaurant) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Restaurant)));
            
        }

        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Task of Restaurant</returns>
        public async System.Threading.Tasks.Task<Restaurant> GetRestaurantByIdAsync (int? restaurantId)
        {
             ApiResponse<Restaurant> localVarResponse = await GetRestaurantByIdAsyncWithHttpInfo(restaurantId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Task of ApiResponse (Restaurant)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Restaurant>> GetRestaurantByIdAsyncWithHttpInfo (int? restaurantId)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling GetRestaurantById");
            
    
            var localVarPath = "/api/core/admin/restaurants/{restaurantId}";
    
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

            return new ApiResponse<Restaurant>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Restaurant) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Restaurant)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <returns>RestaurantConfiguration</returns>
        public RestaurantConfiguration GetRestaurantConfiguration (int? restaurantId)
        {
             ApiResponse<RestaurantConfiguration> localVarResponse = GetRestaurantConfigurationWithHttpInfo(restaurantId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <returns>ApiResponse of RestaurantConfiguration</returns>
        public ApiResponse< RestaurantConfiguration > GetRestaurantConfigurationWithHttpInfo (int? restaurantId)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminCoreApi->GetRestaurantConfiguration");
            
    
            var localVarPath = "/api/core/admin/restaurants/{restaurantId}/config";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetRestaurantConfiguration: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRestaurantConfiguration: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<RestaurantConfiguration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RestaurantConfiguration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestaurantConfiguration)));
            
        }

        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Task of RestaurantConfiguration</returns>
        public async System.Threading.Tasks.Task<RestaurantConfiguration> GetRestaurantConfigurationAsync (int? restaurantId)
        {
             ApiResponse<RestaurantConfiguration> localVarResponse = await GetRestaurantConfigurationAsyncWithHttpInfo(restaurantId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Task of ApiResponse (RestaurantConfiguration)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RestaurantConfiguration>> GetRestaurantConfigurationAsyncWithHttpInfo (int? restaurantId)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling GetRestaurantConfiguration");
            
    
            var localVarPath = "/api/core/admin/restaurants/{restaurantId}/config";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetRestaurantConfiguration: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRestaurantConfiguration: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RestaurantConfiguration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RestaurantConfiguration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestaurantConfiguration)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <returns>RestaurantSettings</returns>
        public RestaurantSettings GetRestaurantSettings (int? restaurantId)
        {
             ApiResponse<RestaurantSettings> localVarResponse = GetRestaurantSettingsWithHttpInfo(restaurantId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <returns>ApiResponse of RestaurantSettings</returns>
        public ApiResponse< RestaurantSettings > GetRestaurantSettingsWithHttpInfo (int? restaurantId)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminCoreApi->GetRestaurantSettings");
            
    
            var localVarPath = "/api/core/admin/restaurants/{restaurantId}/settings";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetRestaurantSettings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRestaurantSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<RestaurantSettings>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RestaurantSettings) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestaurantSettings)));
            
        }

        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Task of RestaurantSettings</returns>
        public async System.Threading.Tasks.Task<RestaurantSettings> GetRestaurantSettingsAsync (int? restaurantId)
        {
             ApiResponse<RestaurantSettings> localVarResponse = await GetRestaurantSettingsAsyncWithHttpInfo(restaurantId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Task of ApiResponse (RestaurantSettings)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RestaurantSettings>> GetRestaurantSettingsAsyncWithHttpInfo (int? restaurantId)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling GetRestaurantSettings");
            
    
            var localVarPath = "/api/core/admin/restaurants/{restaurantId}/settings";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetRestaurantSettings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRestaurantSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RestaurantSettings>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RestaurantSettings) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestaurantSettings)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>UserProfile</returns>
        public UserProfile GetUserProfile ()
        {
             ApiResponse<UserProfile> localVarResponse = GetUserProfileWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of UserProfile</returns>
        public ApiResponse< UserProfile > GetUserProfileWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/core/admin/account/profile";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetUserProfile: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserProfile: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<UserProfile>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserProfile) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserProfile)));
            
        }

        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of UserProfile</returns>
        public async System.Threading.Tasks.Task<UserProfile> GetUserProfileAsync ()
        {
             ApiResponse<UserProfile> localVarResponse = await GetUserProfileAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (UserProfile)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserProfile>> GetUserProfileAsyncWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/core/admin/account/profile";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetUserProfile: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserProfile: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserProfile>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserProfile) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserProfile)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <returns>List&lt;RestaurantUserInfo&gt;</returns>
        public List<RestaurantUserInfo> GetUsers (int? restaurantId)
        {
             ApiResponse<List<RestaurantUserInfo>> localVarResponse = GetUsersWithHttpInfo(restaurantId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <returns>ApiResponse of List&lt;RestaurantUserInfo&gt;</returns>
        public ApiResponse< List<RestaurantUserInfo> > GetUsersWithHttpInfo (int? restaurantId)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminCoreApi->GetUsers");
            
    
            var localVarPath = "/api/core/admin/restaurants/{restaurantId}/users";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetUsers: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUsers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<RestaurantUserInfo>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<RestaurantUserInfo>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<RestaurantUserInfo>)));
            
        }

        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Task of List&lt;RestaurantUserInfo&gt;</returns>
        public async System.Threading.Tasks.Task<List<RestaurantUserInfo>> GetUsersAsync (int? restaurantId)
        {
             ApiResponse<List<RestaurantUserInfo>> localVarResponse = await GetUsersAsyncWithHttpInfo(restaurantId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <returns>Task of ApiResponse (List&lt;RestaurantUserInfo&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<RestaurantUserInfo>>> GetUsersAsyncWithHttpInfo (int? restaurantId)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling GetUsers");
            
    
            var localVarPath = "/api/core/admin/restaurants/{restaurantId}/users";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetUsers: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUsers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<RestaurantUserInfo>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<RestaurantUserInfo>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<RestaurantUserInfo>)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>UserInfo</returns>
        public UserInfo Me ()
        {
             ApiResponse<UserInfo> localVarResponse = MeWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of UserInfo</returns>
        public ApiResponse< UserInfo > MeWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/core/admin/account/me";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Me: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Me: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<UserInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserInfo)));
            
        }

        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of UserInfo</returns>
        public async System.Threading.Tasks.Task<UserInfo> MeAsync ()
        {
             ApiResponse<UserInfo> localVarResponse = await MeAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (UserInfo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserInfo>> MeAsyncWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/core/admin/account/me";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Me: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Me: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserInfo)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="image"></param> 
        /// <returns></returns>
        public void PostProfileImage (byte[] image)
        {
             PostProfileImageWithHttpInfo(image);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="image"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostProfileImageWithHttpInfo (byte[] image)
        {
            
            // verify the required parameter 'image' is set
            if (image == null)
                throw new ApiException(400, "Missing required parameter 'image' when calling AdminCoreApi->PostProfileImage");
            
    
            var localVarPath = "/api/core/admin/account/profile/image";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded", "application/octet-stream"
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
            
            
            
            
            if (image.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(image); // http body (model) parameter
            }
            else
            {
                localVarPostBody = image; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling PostProfileImage: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostProfileImage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="image"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PostProfileImageAsync (byte[] image)
        {
             await PostProfileImageAsyncWithHttpInfo(image);

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="image"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostProfileImageAsyncWithHttpInfo (byte[] image)
        {
            // verify the required parameter 'image' is set
            if (image == null) throw new ApiException(400, "Missing required parameter 'image' when calling PostProfileImage");
            
    
            var localVarPath = "/api/core/admin/account/profile/image";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded", "application/octet-stream"
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
            
            
            
            
            if (image.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(image); // http body (model) parameter
            }
            else
            {
                localVarPostBody = image; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling PostProfileImage: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostProfileImage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>byte[]</returns>
        public byte[] ProfileImage ()
        {
             ApiResponse<byte[]> localVarResponse = ProfileImageWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of byte[]</returns>
        public ApiResponse< byte[] > ProfileImageWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/core/admin/account/profile/image";
    
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
                "application/json", "text/json", "application/xml", "text/xml", "application/octet-stream"
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
                throw new ApiException (localVarStatusCode, "Error calling ProfileImage: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ProfileImage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<byte[]>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (byte[]) Configuration.ApiClient.Deserialize(localVarResponse, typeof(byte[])));
            
        }

        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of byte[]</returns>
        public async System.Threading.Tasks.Task<byte[]> ProfileImageAsync ()
        {
             ApiResponse<byte[]> localVarResponse = await ProfileImageAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (byte[])</returns>
        public async System.Threading.Tasks.Task<ApiResponse<byte[]>> ProfileImageAsyncWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/core/admin/account/profile/image";
    
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
                "application/json", "text/json", "application/xml", "text/xml", "application/octet-stream"
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
                throw new ApiException (localVarStatusCode, "Error calling ProfileImage: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ProfileImage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<byte[]>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (byte[]) Configuration.ApiClient.Deserialize(localVarResponse, typeof(byte[])));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param> 
        /// <returns></returns>
        public void Register (RegisterUser model)
        {
             RegisterWithHttpInfo(model);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> RegisterWithHttpInfo (RegisterUser model)
        {
            
            // verify the required parameter 'model' is set
            if (model == null)
                throw new ApiException(400, "Missing required parameter 'model' when calling AdminCoreApi->Register");
            
    
            var localVarPath = "/api/core/admin/account/register";
    
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
            
            
            
            
            if (model.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(model); // http body (model) parameter
            }
            else
            {
                localVarPostBody = model; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling Register: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Register: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task RegisterAsync (RegisterUser model)
        {
             await RegisterAsyncWithHttpInfo(model);

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> RegisterAsyncWithHttpInfo (RegisterUser model)
        {
            // verify the required parameter 'model' is set
            if (model == null) throw new ApiException(400, "Missing required parameter 'model' when calling Register");
            
    
            var localVarPath = "/api/core/admin/account/register";
    
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
            
            
            
            
            if (model.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(model); // http body (model) parameter
            }
            else
            {
                localVarPostBody = model; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling Register: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Register: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="invitationCode"></param> 
        /// <returns></returns>
        public void Reinvite (int? restaurantId, string invitationCode)
        {
             ReinviteWithHttpInfo(restaurantId, invitationCode);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="invitationCode"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ReinviteWithHttpInfo (int? restaurantId, string invitationCode)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminCoreApi->Reinvite");
            
            // verify the required parameter 'invitationCode' is set
            if (invitationCode == null)
                throw new ApiException(400, "Missing required parameter 'invitationCode' when calling AdminCoreApi->Reinvite");
            
    
            var localVarPath = "/api/core/admin/restaurants/{restaurantId}/invitations/{invitationCode}/reinvite";
    
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
            if (invitationCode != null) localVarPathParams.Add("invitationCode", Configuration.ApiClient.ParameterToString(invitationCode)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling Reinvite: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Reinvite: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="invitationCode"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ReinviteAsync (int? restaurantId, string invitationCode)
        {
             await ReinviteAsyncWithHttpInfo(restaurantId, invitationCode);

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="invitationCode"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ReinviteAsyncWithHttpInfo (int? restaurantId, string invitationCode)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling Reinvite");
            // verify the required parameter 'invitationCode' is set
            if (invitationCode == null) throw new ApiException(400, "Missing required parameter 'invitationCode' when calling Reinvite");
            
    
            var localVarPath = "/api/core/admin/restaurants/{restaurantId}/invitations/{invitationCode}/reinvite";
    
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
            if (invitationCode != null) localVarPathParams.Add("invitationCode", Configuration.ApiClient.ParameterToString(invitationCode)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling Reinvite: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Reinvite: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param> 
        /// <returns></returns>
        public void ResetPassword (ResetPassword model)
        {
             ResetPasswordWithHttpInfo(model);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ResetPasswordWithHttpInfo (ResetPassword model)
        {
            
            // verify the required parameter 'model' is set
            if (model == null)
                throw new ApiException(400, "Missing required parameter 'model' when calling AdminCoreApi->ResetPassword");
            
    
            var localVarPath = "/api/core/admin/account/password/reset";
    
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
            
            
            
            
            if (model.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(model); // http body (model) parameter
            }
            else
            {
                localVarPostBody = model; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling ResetPassword: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ResetPassword: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ResetPasswordAsync (ResetPassword model)
        {
             await ResetPasswordAsyncWithHttpInfo(model);

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ResetPasswordAsyncWithHttpInfo (ResetPassword model)
        {
            // verify the required parameter 'model' is set
            if (model == null) throw new ApiException(400, "Missing required parameter 'model' when calling ResetPassword");
            
    
            var localVarPath = "/api/core/admin/account/password/reset";
    
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
            
            
            
            
            if (model.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(model); // http body (model) parameter
            }
            else
            {
                localVarPostBody = model; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling ResetPassword: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ResetPassword: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
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
        /// <returns></returns>
        public void SetCustomSettings (int? restaurantId, ModelObject settings)
        {
             SetCustomSettingsWithHttpInfo(restaurantId, settings);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="settings"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> SetCustomSettingsWithHttpInfo (int? restaurantId, ModelObject settings)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminCoreApi->SetCustomSettings");
            
            // verify the required parameter 'settings' is set
            if (settings == null)
                throw new ApiException(400, "Missing required parameter 'settings' when calling AdminCoreApi->SetCustomSettings");
            
    
            var localVarPath = "/api/core/admin/restaurants/{restaurantId}/setting/custom";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SetCustomSettings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SetCustomSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
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
        public async System.Threading.Tasks.Task SetCustomSettingsAsync (int? restaurantId, ModelObject settings)
        {
             await SetCustomSettingsAsyncWithHttpInfo(restaurantId, settings);

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="settings"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> SetCustomSettingsAsyncWithHttpInfo (int? restaurantId, ModelObject settings)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling SetCustomSettings");
            // verify the required parameter 'settings' is set
            if (settings == null) throw new ApiException(400, "Missing required parameter 'settings' when calling SetCustomSettings");
            
    
            var localVarPath = "/api/core/admin/restaurants/{restaurantId}/setting/custom";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SetCustomSettings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SetCustomSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
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
        /// <returns></returns>
        public void SetRestaurantSettings (int? restaurantId, RestaurantSettings settings)
        {
             SetRestaurantSettingsWithHttpInfo(restaurantId, settings);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="settings"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> SetRestaurantSettingsWithHttpInfo (int? restaurantId, RestaurantSettings settings)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminCoreApi->SetRestaurantSettings");
            
            // verify the required parameter 'settings' is set
            if (settings == null)
                throw new ApiException(400, "Missing required parameter 'settings' when calling AdminCoreApi->SetRestaurantSettings");
            
    
            var localVarPath = "/api/core/admin/restaurants/{restaurantId}/settings";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SetRestaurantSettings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SetRestaurantSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
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
        public async System.Threading.Tasks.Task SetRestaurantSettingsAsync (int? restaurantId, RestaurantSettings settings)
        {
             await SetRestaurantSettingsAsyncWithHttpInfo(restaurantId, settings);

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="settings"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> SetRestaurantSettingsAsyncWithHttpInfo (int? restaurantId, RestaurantSettings settings)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling SetRestaurantSettings");
            // verify the required parameter 'settings' is set
            if (settings == null) throw new ApiException(400, "Missing required parameter 'settings' when calling SetRestaurantSettings");
            
    
            var localVarPath = "/api/core/admin/restaurants/{restaurantId}/settings";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SetRestaurantSettings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SetRestaurantSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="value"></param> 
        /// <returns>Restaurant</returns>
        public Restaurant UpdateRestaurant (int? restaurantId, Restaurant value)
        {
             ApiResponse<Restaurant> localVarResponse = UpdateRestaurantWithHttpInfo(restaurantId, value);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param> 
        /// <param name="value"></param> 
        /// <returns>ApiResponse of Restaurant</returns>
        public ApiResponse< Restaurant > UpdateRestaurantWithHttpInfo (int? restaurantId, Restaurant value)
        {
            
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null)
                throw new ApiException(400, "Missing required parameter 'restaurantId' when calling AdminCoreApi->UpdateRestaurant");
            
            // verify the required parameter 'value' is set
            if (value == null)
                throw new ApiException(400, "Missing required parameter 'value' when calling AdminCoreApi->UpdateRestaurant");
            
    
            var localVarPath = "/api/core/admin/restaurants/{restaurantId}";
    
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UpdateRestaurant: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateRestaurant: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Restaurant>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Restaurant) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Restaurant)));
            
        }

        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="value"></param>
        /// <returns>Task of Restaurant</returns>
        public async System.Threading.Tasks.Task<Restaurant> UpdateRestaurantAsync (int? restaurantId, Restaurant value)
        {
             ApiResponse<Restaurant> localVarResponse = await UpdateRestaurantAsyncWithHttpInfo(restaurantId, value);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="restaurantId"></param>
        /// <param name="value"></param>
        /// <returns>Task of ApiResponse (Restaurant)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Restaurant>> UpdateRestaurantAsyncWithHttpInfo (int? restaurantId, Restaurant value)
        {
            // verify the required parameter 'restaurantId' is set
            if (restaurantId == null) throw new ApiException(400, "Missing required parameter 'restaurantId' when calling UpdateRestaurant");
            // verify the required parameter 'value' is set
            if (value == null) throw new ApiException(400, "Missing required parameter 'value' when calling UpdateRestaurant");
            
    
            var localVarPath = "/api/core/admin/restaurants/{restaurantId}";
    
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UpdateRestaurant: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateRestaurant: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Restaurant>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Restaurant) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Restaurant)));
            
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profile"></param> 
        /// <returns></returns>
        public void UpdateUserProfile (UserProfile profile)
        {
             UpdateUserProfileWithHttpInfo(profile);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profile"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateUserProfileWithHttpInfo (UserProfile profile)
        {
            
            // verify the required parameter 'profile' is set
            if (profile == null)
                throw new ApiException(400, "Missing required parameter 'profile' when calling AdminCoreApi->UpdateUserProfile");
            
    
            var localVarPath = "/api/core/admin/account/profile";
    
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
            
            
            
            
            if (profile.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(profile); // http body (model) parameter
            }
            else
            {
                localVarPostBody = profile; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateUserProfile: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateUserProfile: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profile"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateUserProfileAsync (UserProfile profile)
        {
             await UpdateUserProfileAsyncWithHttpInfo(profile);

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HostMe.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profile"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateUserProfileAsyncWithHttpInfo (UserProfile profile)
        {
            // verify the required parameter 'profile' is set
            if (profile == null) throw new ApiException(400, "Missing required parameter 'profile' when calling UpdateUserProfile");
            
    
            var localVarPath = "/api/core/admin/account/profile";
    
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
            
            
            
            
            if (profile.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(profile); // http body (model) parameter
            }
            else
            {
                localVarPostBody = profile; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateUserProfile: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateUserProfile: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
