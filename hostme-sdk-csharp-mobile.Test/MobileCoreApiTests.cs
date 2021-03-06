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
    ///  Class for testing MobileCoreApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class MobileCoreApiTests
    {
        private MobileCoreApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new MobileCoreApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MobileCoreApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<MobileCoreApi> (instance, "instance is a MobileCoreApi");
        }

        
        /// <summary>
        /// Test AddExternalLogin
        /// </summary>
        [Test]
        public void AddExternalLoginTest()
        {
            // TODO: add unit test for the method 'AddExternalLogin'
            AddExternalLogin model = null; // TODO: replace null with proper value
            instance.AddExternalLogin(model);
             
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
        /// Test CheckIn
        /// </summary>
        [Test]
        public void CheckInTest()
        {
            // TODO: add unit test for the method 'CheckIn'
            TransactionCheckin checkinContract = null; // TODO: replace null with proper value
            var response = instance.CheckIn(checkinContract);
            Assert.IsInstanceOf<Transaction> (response, "response is Transaction"); 
        }
        
        /// <summary>
        /// Test FindRestaurants
        /// </summary>
        [Test]
        public void FindRestaurantsTest()
        {
            // TODO: add unit test for the method 'FindRestaurants'
            double? lat = null; // TODO: replace null with proper value
double? lon = null; // TODO: replace null with proper value
string name = null; // TODO: replace null with proper value
string city = null; // TODO: replace null with proper value
            var response = instance.FindRestaurants(lat, lon, name, city);
            Assert.IsInstanceOf<List<RestaurantInfo>> (response, "response is List<RestaurantInfo>"); 
        }
        
        /// <summary>
        /// Test GetAllRestaurants
        /// </summary>
        [Test]
        public void GetAllRestaurantsTest()
        {
            // TODO: add unit test for the method 'GetAllRestaurants'
                        var response = instance.GetAllRestaurants();
            Assert.IsInstanceOf<List<RestaurantInfo>> (response, "response is List<RestaurantInfo>"); 
        }
        
        /// <summary>
        /// Test GetListOfLocations
        /// </summary>
        [Test]
        public void GetListOfLocationsTest()
        {
            // TODO: add unit test for the method 'GetListOfLocations'
                        var response = instance.GetListOfLocations();
            Assert.IsInstanceOf<List<Location>> (response, "response is List<Location>"); 
        }
        
        /// <summary>
        /// Test GetManageInfo
        /// </summary>
        [Test]
        public void GetManageInfoTest()
        {
            // TODO: add unit test for the method 'GetManageInfo'
            string returnUrl = null; // TODO: replace null with proper value
bool? generateState = null; // TODO: replace null with proper value
            var response = instance.GetManageInfo(returnUrl, generateState);
            Assert.IsInstanceOf<ManageInfo> (response, "response is ManageInfo"); 
        }
        
        /// <summary>
        /// Test GetRegistrationToken
        /// </summary>
        [Test]
        public void GetRegistrationTokenTest()
        {
            // TODO: add unit test for the method 'GetRegistrationToken'
            string token = null; // TODO: replace null with proper value
            var response = instance.GetRegistrationToken(token);
            Assert.IsInstanceOf<CampaignInfo> (response, "response is CampaignInfo"); 
        }
        
        /// <summary>
        /// Test GetReservationAvailability
        /// </summary>
        [Test]
        public void GetReservationAvailabilityTest()
        {
            // TODO: add unit test for the method 'GetReservationAvailability'
            int? restaurantId = null; // TODO: replace null with proper value
DateTimeOffset? date = null; // TODO: replace null with proper value
int? partySize = null; // TODO: replace null with proper value
int? rangeInMinutes = null; // TODO: replace null with proper value
string areas = null; // TODO: replace null with proper value
            var response = instance.GetReservationAvailability(restaurantId, date, partySize, rangeInMinutes, areas);
            Assert.IsInstanceOf<List<OnlineAvailability>> (response, "response is List<OnlineAvailability>"); 
        }
        
        /// <summary>
        /// Test GetRestaurantById
        /// </summary>
        [Test]
        public void GetRestaurantByIdTest()
        {
            // TODO: add unit test for the method 'GetRestaurantById'
            int? id = null; // TODO: replace null with proper value
            var response = instance.GetRestaurantById(id);
            Assert.IsInstanceOf<RestaurantInfo> (response, "response is RestaurantInfo"); 
        }
        
        /// <summary>
        /// Test GetUserInfo
        /// </summary>
        [Test]
        public void GetUserInfoTest()
        {
            // TODO: add unit test for the method 'GetUserInfo'
                        var response = instance.GetUserInfo();
            Assert.IsInstanceOf<UserExternal> (response, "response is UserExternal"); 
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
        /// Test PostProfileImage
        /// </summary>
        [Test]
        public void PostProfileImageTest()
        {
            // TODO: add unit test for the method 'PostProfileImage'
            string image = null; // TODO: replace null with proper value
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
        /// Test RegisterExternal
        /// </summary>
        [Test]
        public void RegisterExternalTest()
        {
            // TODO: add unit test for the method 'RegisterExternal'
            RegisterExternalUser model = null; // TODO: replace null with proper value
            instance.RegisterExternal(model);
             
        }
        
        /// <summary>
        /// Test RemoveLogin
        /// </summary>
        [Test]
        public void RemoveLoginTest()
        {
            // TODO: add unit test for the method 'RemoveLogin'
            RemoveLogin model = null; // TODO: replace null with proper value
            instance.RemoveLogin(model);
             
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
        /// Test SetPassword
        /// </summary>
        [Test]
        public void SetPasswordTest()
        {
            // TODO: add unit test for the method 'SetPassword'
            SetPassword model = null; // TODO: replace null with proper value
            instance.SetPassword(model);
             
        }
        
        /// <summary>
        /// Test SetPushChannelAsync
        /// </summary>
        [Test]
        public void SetPushChannelAsyncTest()
        {
            // TODO: add unit test for the method 'SetPushChannelAsync'
            SetPushChannel channel = null; // TODO: replace null with proper value
            instance.SetPushChannelAsync(channel);
             
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
