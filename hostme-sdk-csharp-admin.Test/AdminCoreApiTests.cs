using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using HostMe.Sdk.Client;
using HostMe.Sdk.Api;
using HostMe.Sdk.Model;


namespace HostMe.Sdk.Test
{
    /// <summary>
    ///  Class for testing AdminCoreApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AdminCoreApiTests
    {
        private AdminCoreApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new AdminCoreApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AdminCoreApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<AdminCoreApi> (instance, "instance is a AdminCoreApi");
        }

        
        /// <summary>
        /// Test AddNewRestaurant
        /// </summary>
        [Test]
        public void AddNewRestaurantTest()
        {
            // TODO: add unit test for the method 'AddNewRestaurant'
            CreateRestaurant value = null; // TODO: replace null with proper value
            
            var response = instance.AddNewRestaurant(value);
            Assert.IsInstanceOf<WithAccessTokenContract1RestaurantContract> (response, "response is WithAccessTokenContract1RestaurantContract"); 
        }
        
        /// <summary>
        /// Test ChangePassword
        /// </summary>
        [Test]
        public void ChangePasswordTest()
        {
            // TODO: add unit test for the method 'ChangePassword'
            ChangePassword model = null; // TODO: replace null with proper value
            
            instance.ChangePassword(model);
             
        }
        
        /// <summary>
        /// Test CheckInvitationCode
        /// </summary>
        [Test]
        public void CheckInvitationCodeTest()
        {
            // TODO: add unit test for the method 'CheckInvitationCode'
            string invitationCode = null; // TODO: replace null with proper value
            string restaurantId = null; // TODO: replace null with proper value
            
            var response = instance.CheckInvitationCode(invitationCode, restaurantId);
            Assert.IsInstanceOf<InvitationInfo> (response, "response is InvitationInfo"); 
        }
        
        /// <summary>
        /// Test CreateInvitationCode
        /// </summary>
        [Test]
        public void CreateInvitationCodeTest()
        {
            // TODO: add unit test for the method 'CreateInvitationCode'
            int? restaurantId = null; // TODO: replace null with proper value
            Invitation invitation = null; // TODO: replace null with proper value
            
            var response = instance.CreateInvitationCode(restaurantId, invitation);
            Assert.IsInstanceOf<Token> (response, "response is Token"); 
        }
        
        /// <summary>
        /// Test CreateNewAccountWithRestaurant
        /// </summary>
        [Test]
        public void CreateNewAccountWithRestaurantTest()
        {
            // TODO: add unit test for the method 'CreateNewAccountWithRestaurant'
            CreateAccountWithRestaurant value = null; // TODO: replace null with proper value
            
            instance.CreateNewAccountWithRestaurant(value);
             
        }
        
        /// <summary>
        /// Test DeleteInvitation
        /// </summary>
        [Test]
        public void DeleteInvitationTest()
        {
            // TODO: add unit test for the method 'DeleteInvitation'
            int? restaurantId = null; // TODO: replace null with proper value
            string invitationCode = null; // TODO: replace null with proper value
            
            instance.DeleteInvitation(restaurantId, invitationCode);
             
        }
        
        /// <summary>
        /// Test DeleteRestaurant
        /// </summary>
        [Test]
        public void DeleteRestaurantTest()
        {
            // TODO: add unit test for the method 'DeleteRestaurant'
            int? restaurantId = null; // TODO: replace null with proper value
            
            instance.DeleteRestaurant(restaurantId);
             
        }
        
        /// <summary>
        /// Test DeleteUser
        /// </summary>
        [Test]
        public void DeleteUserTest()
        {
            // TODO: add unit test for the method 'DeleteUser'
            int? restaurantId = null; // TODO: replace null with proper value
            string userId = null; // TODO: replace null with proper value
            string role = null; // TODO: replace null with proper value
            
            instance.DeleteUser(restaurantId, userId, role);
             
        }
        
        /// <summary>
        /// Test FindRestaurantsByUserPhone
        /// </summary>
        [Test]
        public void FindRestaurantsByUserPhoneTest()
        {
            // TODO: add unit test for the method 'FindRestaurantsByUserPhone'
            string phone = null; // TODO: replace null with proper value
            string email = null; // TODO: replace null with proper value
            
            var response = instance.FindRestaurantsByUserPhone(phone, email);
            Assert.IsInstanceOf<List<Restaurant>> (response, "response is List<Restaurant>"); 
        }
        
        /// <summary>
        /// Test FindUserByPhoneAsync
        /// </summary>
        [Test]
        public void FindUserByPhoneAsyncTest()
        {
            // TODO: add unit test for the method 'FindUserByPhoneAsync'
            string phone = null; // TODO: replace null with proper value
            string email = null; // TODO: replace null with proper value
            
            var response = instance.FindUserByPhoneAsync(phone, email);
            Assert.IsInstanceOf<UserInfo> (response, "response is UserInfo"); 
        }
        
        /// <summary>
        /// Test GetAllUserRestaurants
        /// </summary>
        [Test]
        public void GetAllUserRestaurantsTest()
        {
            // TODO: add unit test for the method 'GetAllUserRestaurants'
            
            var response = instance.GetAllUserRestaurants();
            Assert.IsInstanceOf<List<Restaurant>> (response, "response is List<Restaurant>"); 
        }
        
        /// <summary>
        /// Test GetCustomSettings
        /// </summary>
        [Test]
        public void GetCustomSettingsTest()
        {
            // TODO: add unit test for the method 'GetCustomSettings'
            int? restaurantId = null; // TODO: replace null with proper value
            
            var response = instance.GetCustomSettings(restaurantId);
            Assert.IsInstanceOf<Object> (response, "response is Object"); 
        }
        
        /// <summary>
        /// Test GetInvitations
        /// </summary>
        [Test]
        public void GetInvitationsTest()
        {
            // TODO: add unit test for the method 'GetInvitations'
            int? restaurantId = null; // TODO: replace null with proper value
            
            var response = instance.GetInvitations(restaurantId);
            Assert.IsInstanceOf<List<InvitationInfo>> (response, "response is List<InvitationInfo>"); 
        }
        
        /// <summary>
        /// Test GetRegistrationToken
        /// </summary>
        [Test]
        public void GetRegistrationTokenTest()
        {
            // TODO: add unit test for the method 'GetRegistrationToken'
            int? restaurantId = null; // TODO: replace null with proper value
            string tableNumber = null; // TODO: replace null with proper value
            
            var response = instance.GetRegistrationToken(restaurantId, tableNumber);
            Assert.IsInstanceOf<Token> (response, "response is Token"); 
        }
        
        /// <summary>
        /// Test GetRestaurantById
        /// </summary>
        [Test]
        public void GetRestaurantByIdTest()
        {
            // TODO: add unit test for the method 'GetRestaurantById'
            int? restaurantId = null; // TODO: replace null with proper value
            
            var response = instance.GetRestaurantById(restaurantId);
            Assert.IsInstanceOf<Restaurant> (response, "response is Restaurant"); 
        }
        
        /// <summary>
        /// Test GetRestaurantConfiguration
        /// </summary>
        [Test]
        public void GetRestaurantConfigurationTest()
        {
            // TODO: add unit test for the method 'GetRestaurantConfiguration'
            int? restaurantId = null; // TODO: replace null with proper value
            
            var response = instance.GetRestaurantConfiguration(restaurantId);
            Assert.IsInstanceOf<RestaurantConfiguration> (response, "response is RestaurantConfiguration"); 
        }
        
        /// <summary>
        /// Test GetRestaurantSettings
        /// </summary>
        [Test]
        public void GetRestaurantSettingsTest()
        {
            // TODO: add unit test for the method 'GetRestaurantSettings'
            int? restaurantId = null; // TODO: replace null with proper value
            
            var response = instance.GetRestaurantSettings(restaurantId);
            Assert.IsInstanceOf<RestaurantSettings> (response, "response is RestaurantSettings"); 
        }
        
        /// <summary>
        /// Test GetUserProfile
        /// </summary>
        [Test]
        public void GetUserProfileTest()
        {
            // TODO: add unit test for the method 'GetUserProfile'
            
            var response = instance.GetUserProfile();
            Assert.IsInstanceOf<UserProfile> (response, "response is UserProfile"); 
        }
        
        /// <summary>
        /// Test GetUsers
        /// </summary>
        [Test]
        public void GetUsersTest()
        {
            // TODO: add unit test for the method 'GetUsers'
            int? restaurantId = null; // TODO: replace null with proper value
            
            var response = instance.GetUsers(restaurantId);
            Assert.IsInstanceOf<List<RestaurantUserInfo>> (response, "response is List<RestaurantUserInfo>"); 
        }
        
        /// <summary>
        /// Test Me
        /// </summary>
        [Test]
        public void MeTest()
        {
            // TODO: add unit test for the method 'Me'
            
            var response = instance.Me();
            Assert.IsInstanceOf<UserInfo> (response, "response is UserInfo"); 
        }
        
        /// <summary>
        /// Test PostProfileImage
        /// </summary>
        [Test]
        public void PostProfileImageTest()
        {
            // TODO: add unit test for the method 'PostProfileImage'
            byte[] image = null; // TODO: replace null with proper value
            
            instance.PostProfileImage(image);
             
        }
        
        /// <summary>
        /// Test ProfileImage
        /// </summary>
        [Test]
        public void ProfileImageTest()
        {
            // TODO: add unit test for the method 'ProfileImage'
            
            var response = instance.ProfileImage();
            Assert.IsInstanceOf<byte[]> (response, "response is byte[]"); 
        }
        
        /// <summary>
        /// Test Register
        /// </summary>
        [Test]
        public void RegisterTest()
        {
            // TODO: add unit test for the method 'Register'
            RegisterUser model = null; // TODO: replace null with proper value
            
            instance.Register(model);
             
        }
        
        /// <summary>
        /// Test Reinvite
        /// </summary>
        [Test]
        public void ReinviteTest()
        {
            // TODO: add unit test for the method 'Reinvite'
            int? restaurantId = null; // TODO: replace null with proper value
            string invitationCode = null; // TODO: replace null with proper value
            
            instance.Reinvite(restaurantId, invitationCode);
             
        }
        
        /// <summary>
        /// Test ResetPassword
        /// </summary>
        [Test]
        public void ResetPasswordTest()
        {
            // TODO: add unit test for the method 'ResetPassword'
            ResetPassword model = null; // TODO: replace null with proper value
            
            instance.ResetPassword(model);
             
        }
        
        /// <summary>
        /// Test SetCustomSettings
        /// </summary>
        [Test]
        public void SetCustomSettingsTest()
        {
            // TODO: add unit test for the method 'SetCustomSettings'
            int? restaurantId = null; // TODO: replace null with proper value
            ModelObject settings = null; // TODO: replace null with proper value
            
            instance.SetCustomSettings(restaurantId, settings);
             
        }
        
        /// <summary>
        /// Test SetRestaurantSettings
        /// </summary>
        [Test]
        public void SetRestaurantSettingsTest()
        {
            // TODO: add unit test for the method 'SetRestaurantSettings'
            int? restaurantId = null; // TODO: replace null with proper value
            RestaurantSettings settings = null; // TODO: replace null with proper value
            
            instance.SetRestaurantSettings(restaurantId, settings);
             
        }
        
        /// <summary>
        /// Test UpdateRestaurant
        /// </summary>
        [Test]
        public void UpdateRestaurantTest()
        {
            // TODO: add unit test for the method 'UpdateRestaurant'
            int? restaurantId = null; // TODO: replace null with proper value
            Restaurant value = null; // TODO: replace null with proper value
            
            var response = instance.UpdateRestaurant(restaurantId, value);
            Assert.IsInstanceOf<Restaurant> (response, "response is Restaurant"); 
        }
        
        /// <summary>
        /// Test UpdateUserProfile
        /// </summary>
        [Test]
        public void UpdateUserProfileTest()
        {
            // TODO: add unit test for the method 'UpdateUserProfile'
            UserProfile profile = null; // TODO: replace null with proper value
            
            instance.UpdateUserProfile(profile);
             
        }
        
    }

}
