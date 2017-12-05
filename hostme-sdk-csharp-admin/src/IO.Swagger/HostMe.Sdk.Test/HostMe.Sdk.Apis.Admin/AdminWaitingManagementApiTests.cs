/* 
 * Qa admin api
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: admin
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

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
    ///  Class for testing AdminWaitingManagementApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AdminWaitingManagementApiTests
    {
        private AdminWaitingManagementApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AdminWaitingManagementApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AdminWaitingManagementApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AdminWaitingManagementApi
            //Assert.IsInstanceOfType(typeof(AdminWaitingManagementApi), instance, "instance is a AdminWaitingManagementApi");
        }

        
        /// <summary>
        /// Test CallWaitingParty
        /// </summary>
        [Test]
        public void CallWaitingPartyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? restaurantId = null;
            //int? waitingItemId = null;
            //string tableNumber = null;
            //instance.CallWaitingParty(restaurantId, waitingItemId, tableNumber);
            
        }
        
        /// <summary>
        /// Test Close
        /// </summary>
        [Test]
        public void CloseTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? restaurantId = null;
            //int? waitingItemId = null;
            //instance.Close(restaurantId, waitingItemId);
            
        }
        
        /// <summary>
        /// Test CloseAsCanceled
        /// </summary>
        [Test]
        public void CloseAsCanceledTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? restaurantId = null;
            //int? waitingItemId = null;
            //string origin = null;
            //instance.CloseAsCanceled(restaurantId, waitingItemId, origin);
            
        }
        
        /// <summary>
        /// Test CloseAsSeated
        /// </summary>
        [Test]
        public void CloseAsSeatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? restaurantId = null;
            //string waitingItemId = null;
            //string tableNumber = null;
            //instance.CloseAsSeated(restaurantId, waitingItemId, tableNumber);
            
        }
        
        /// <summary>
        /// Test Create
        /// </summary>
        [Test]
        public void CreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? restaurantId = null;
            //UpdateWaitingItem contract = null;
            //var response = instance.Create(restaurantId, contract);
            //Assert.IsInstanceOf<Waiting> (response, "response is Waiting");
        }
        
        /// <summary>
        /// Test GetAllWaitings
        /// </summary>
        [Test]
        public void GetAllWaitingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? restaurantId = null;
            //var response = instance.GetAllWaitings(restaurantId);
            //Assert.IsInstanceOf<List<Waiting>> (response, "response is List<Waiting>");
        }
        
        /// <summary>
        /// Test GetMessages
        /// </summary>
        [Test]
        public void GetMessagesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? restaurantId = null;
            //string waitingItemId = null;
            //var response = instance.GetMessages(restaurantId, waitingItemId);
            //Assert.IsInstanceOf<List<Message>> (response, "response is List<Message>");
        }
        
        /// <summary>
        /// Test GetPartiesGroupBy
        /// </summary>
        [Test]
        public void GetPartiesGroupByTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? restaurantId = null;
            //string groupBy = null;
            //DateTimeOffset? from = null;
            //DateTimeOffset? to = null;
            //var response = instance.GetPartiesGroupBy(restaurantId, groupBy, from, to);
            //Assert.IsInstanceOf<List<PartiesStatReportItem>> (response, "response is List<PartiesStatReportItem>");
        }
        
        /// <summary>
        /// Test GetRestaurantWaitingsStatistic
        /// </summary>
        [Test]
        public void GetRestaurantWaitingsStatisticTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? restaurantId = null;
            //var response = instance.GetRestaurantWaitingsStatistic(restaurantId);
            //Assert.IsInstanceOf<WaitingsStatistic> (response, "response is WaitingsStatistic");
        }
        
        /// <summary>
        /// Test GetTodayStats
        /// </summary>
        [Test]
        public void GetTodayStatsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? restaurantId = null;
            //var response = instance.GetTodayStats(restaurantId);
            //Assert.IsInstanceOf<WaitingStats> (response, "response is WaitingStats");
        }
        
        /// <summary>
        /// Test GetUnreadMessagesCount
        /// </summary>
        [Test]
        public void GetUnreadMessagesCountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? restaurantId = null;
            //var response = instance.GetUnreadMessagesCount(restaurantId);
            //Assert.IsInstanceOf<Count> (response, "response is Count");
        }
        
        /// <summary>
        /// Test GetWaitingById
        /// </summary>
        [Test]
        public void GetWaitingByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? restaurantId = null;
            //string waitingItemId = null;
            //var response = instance.GetWaitingById(restaurantId, waitingItemId);
            //Assert.IsInstanceOf<Waiting> (response, "response is Waiting");
        }
        
        /// <summary>
        /// Test GetWaitingSettings
        /// </summary>
        [Test]
        public void GetWaitingSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? restaurantId = null;
            //var response = instance.GetWaitingSettings(restaurantId);
            //Assert.IsInstanceOf<WaitingSettings> (response, "response is WaitingSettings");
        }
        
        /// <summary>
        /// Test GetWaitingTimeByGroup
        /// </summary>
        [Test]
        public void GetWaitingTimeByGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? restaurantId = null;
            //DateTimeOffset? from = null;
            //DateTimeOffset? to = null;
            //var response = instance.GetWaitingTimeByGroup(restaurantId, from, to);
            //Assert.IsInstanceOf<List<WaitingsStatReportItem>> (response, "response is List<WaitingsStatReportItem>");
        }
        
        /// <summary>
        /// Test GetWaitingTimeByHour
        /// </summary>
        [Test]
        public void GetWaitingTimeByHourTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? restaurantId = null;
            //DateTimeOffset? from = null;
            //DateTimeOffset? to = null;
            //var response = instance.GetWaitingTimeByHour(restaurantId, from, to);
            //Assert.IsInstanceOf<List<WaitingsStatReportItem>> (response, "response is List<WaitingsStatReportItem>");
        }
        
        /// <summary>
        /// Test GetWaitingTimeByLine
        /// </summary>
        [Test]
        public void GetWaitingTimeByLineTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? restaurantId = null;
            //DateTimeOffset? from = null;
            //DateTimeOffset? to = null;
            //var response = instance.GetWaitingTimeByLine(restaurantId, from, to);
            //Assert.IsInstanceOf<List<WaitingsStatReportItem>> (response, "response is List<WaitingsStatReportItem>");
        }
        
        /// <summary>
        /// Test GetWaitingTimeByMeal
        /// </summary>
        [Test]
        public void GetWaitingTimeByMealTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? restaurantId = null;
            //DateTimeOffset? from = null;
            //DateTimeOffset? to = null;
            //var response = instance.GetWaitingTimeByMeal(restaurantId, from, to);
            //Assert.IsInstanceOf<List<WaitingsStatReportItem>> (response, "response is List<WaitingsStatReportItem>");
        }
        
        /// <summary>
        /// Test GetWaitingTimeByWeek
        /// </summary>
        [Test]
        public void GetWaitingTimeByWeekTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? restaurantId = null;
            //DateTimeOffset? from = null;
            //DateTimeOffset? to = null;
            //var response = instance.GetWaitingTimeByWeek(restaurantId, from, to);
            //Assert.IsInstanceOf<List<WaitingsStatReportItem>> (response, "response is List<WaitingsStatReportItem>");
        }
        
        /// <summary>
        /// Test GetWaitingTimeByWeekDay
        /// </summary>
        [Test]
        public void GetWaitingTimeByWeekDayTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? restaurantId = null;
            //DateTimeOffset? from = null;
            //DateTimeOffset? to = null;
            //var response = instance.GetWaitingTimeByWeekDay(restaurantId, from, to);
            //Assert.IsInstanceOf<List<WaitingsStatReportItem>> (response, "response is List<WaitingsStatReportItem>");
        }
        
        /// <summary>
        /// Test GetWaitingsForPeriod
        /// </summary>
        [Test]
        public void GetWaitingsForPeriodTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? restaurantId = null;
            //DateTimeOffset? from = null;
            //DateTimeOffset? to = null;
            //var response = instance.GetWaitingsForPeriod(restaurantId, from, to);
            //Assert.IsInstanceOf<List<WaitingReportItem>> (response, "response is List<WaitingReportItem>");
        }
        
        /// <summary>
        /// Test GetWaitingsGroupBy
        /// </summary>
        [Test]
        public void GetWaitingsGroupByTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? restaurantId = null;
            //string groupBy = null;
            //DateTimeOffset? from = null;
            //DateTimeOffset? to = null;
            //var response = instance.GetWaitingsGroupBy(restaurantId, groupBy, from, to);
            //Assert.IsInstanceOf<List<WaitingsStatReportItem>> (response, "response is List<WaitingsStatReportItem>");
        }
        
        /// <summary>
        /// Test Incoming
        /// </summary>
        [Test]
        public void IncomingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string from = null;
            //string to = null;
            //string body = null;
            //var response = instance.Incoming(from, to, body);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test MarkAllMessagesAsRead
        /// </summary>
        [Test]
        public void MarkAllMessagesAsReadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? restaurantId = null;
            //int? waitingItemId = null;
            //instance.MarkAllMessagesAsRead(restaurantId, waitingItemId);
            
        }
        
        /// <summary>
        /// Test ReOpenWaiting
        /// </summary>
        [Test]
        public void ReOpenWaitingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? restaurantId = null;
            //int? waitingItemId = null;
            //var response = instance.ReOpenWaiting(restaurantId, waitingItemId);
            //Assert.IsInstanceOf<Waiting> (response, "response is Waiting");
        }
        
        /// <summary>
        /// Test SendMessage
        /// </summary>
        [Test]
        public void SendMessageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? restaurantId = null;
            //int? waitingItemId = null;
            //string origin = null;
            //CreateMessage createMessage = null;
            //var response = instance.SendMessage(restaurantId, waitingItemId, origin, createMessage);
            //Assert.IsInstanceOf<Message> (response, "response is Message");
        }
        
        /// <summary>
        /// Test SetWaitingSettings
        /// </summary>
        [Test]
        public void SetWaitingSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? restaurantId = null;
            //WaitingSettings settings = null;
            //instance.SetWaitingSettings(restaurantId, settings);
            
        }
        
        /// <summary>
        /// Test UpdateWaiting
        /// </summary>
        [Test]
        public void UpdateWaitingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? restaurantId = null;
            //int? waitingItemId = null;
            //UpdateWaitingItem item = null;
            //var response = instance.UpdateWaiting(restaurantId, waitingItemId, item);
            //Assert.IsInstanceOf<Waiting> (response, "response is Waiting");
        }
        
    }

}