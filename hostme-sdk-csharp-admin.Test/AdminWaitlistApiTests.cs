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
    ///  Class for testing AdminWaitlistApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AdminWaitlistApiTests
    {
        private AdminWaitlistApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new AdminWaitlistApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AdminWaitlistApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<AdminWaitlistApi> (instance, "instance is a AdminWaitlistApi");
        }

        
        /// <summary>
        /// Test AddNewWaiting
        /// </summary>
        [Test]
        public void AddNewWaitingTest()
        {
            // TODO: add unit test for the method 'AddNewWaiting'
            int? restaurantId = null; // TODO: replace null with proper value
            var response = instance.AddNewWaiting(restaurantId);
            Assert.IsInstanceOf<WaitingItem> (response, "response is WaitingItem"); 
        }
        
        /// <summary>
        /// Test CallWaitingParty
        /// </summary>
        [Test]
        public void CallWaitingPartyTest()
        {
            // TODO: add unit test for the method 'CallWaitingParty'
            int? restaurantId = null; // TODO: replace null with proper value
int? waitingItemId = null; // TODO: replace null with proper value
string tableNumber = null; // TODO: replace null with proper value
            instance.CallWaitingParty(restaurantId, waitingItemId, tableNumber);
             
        }
        
        /// <summary>
        /// Test Close
        /// </summary>
        [Test]
        public void CloseTest()
        {
            // TODO: add unit test for the method 'Close'
            int? restaurantId = null; // TODO: replace null with proper value
int? waitingItemId = null; // TODO: replace null with proper value
            instance.Close(restaurantId, waitingItemId);
             
        }
        
        /// <summary>
        /// Test CloseAsCanceled
        /// </summary>
        [Test]
        public void CloseAsCanceledTest()
        {
            // TODO: add unit test for the method 'CloseAsCanceled'
            int? restaurantId = null; // TODO: replace null with proper value
int? waitingItemId = null; // TODO: replace null with proper value
string origin = null; // TODO: replace null with proper value
string comment = null; // TODO: replace null with proper value
            instance.CloseAsCanceled(restaurantId, waitingItemId, origin, comment);
             
        }
        
        /// <summary>
        /// Test CloseAsSeated
        /// </summary>
        [Test]
        public void CloseAsSeatedTest()
        {
            // TODO: add unit test for the method 'CloseAsSeated'
            int? restaurantId = null; // TODO: replace null with proper value
int? waitingItemId = null; // TODO: replace null with proper value
            instance.CloseAsSeated(restaurantId, waitingItemId);
             
        }
        
        /// <summary>
        /// Test Confirm
        /// </summary>
        [Test]
        public void ConfirmTest()
        {
            // TODO: add unit test for the method 'Confirm'
            int? restaurantId = null; // TODO: replace null with proper value
int? waitingItemId = null; // TODO: replace null with proper value
PanelConfirmationBindingModel conf = null; // TODO: replace null with proper value
            var response = instance.Confirm(restaurantId, waitingItemId, conf);
            Assert.IsInstanceOf<WaitingItem> (response, "response is WaitingItem"); 
        }
        
        /// <summary>
        /// Test GetAllWaitings
        /// </summary>
        [Test]
        public void GetAllWaitingsTest()
        {
            // TODO: add unit test for the method 'GetAllWaitings'
            int? restaurantId = null; // TODO: replace null with proper value
string queryOptions = null; // TODO: replace null with proper value
string from = null; // TODO: replace null with proper value
int? to = null; // TODO: replace null with proper value
            var response = instance.GetAllWaitings(restaurantId, queryOptions, from, to);
            Assert.IsInstanceOf<List<WaitingItem>> (response, "response is List<WaitingItem>"); 
        }
        
        /// <summary>
        /// Test GetMessages
        /// </summary>
        [Test]
        public void GetMessagesTest()
        {
            // TODO: add unit test for the method 'GetMessages'
            int? restaurantId = null; // TODO: replace null with proper value
int? waitingItemId = null; // TODO: replace null with proper value
            var response = instance.GetMessages(restaurantId, waitingItemId);
            Assert.IsInstanceOf<List<Message>> (response, "response is List<Message>"); 
        }
        
        /// <summary>
        /// Test GetTodayStats
        /// </summary>
        [Test]
        public void GetTodayStatsTest()
        {
            // TODO: add unit test for the method 'GetTodayStats'
            int? restaurantId = null; // TODO: replace null with proper value
            var response = instance.GetTodayStats(restaurantId);
            Assert.IsInstanceOf<WaitingStats> (response, "response is WaitingStats"); 
        }
        
        /// <summary>
        /// Test GetUnreadMessagesCount
        /// </summary>
        [Test]
        public void GetUnreadMessagesCountTest()
        {
            // TODO: add unit test for the method 'GetUnreadMessagesCount'
            int? restaurantId = null; // TODO: replace null with proper value
            var response = instance.GetUnreadMessagesCount(restaurantId);
            Assert.IsInstanceOf<int?> (response, "response is int?"); 
        }
        
        /// <summary>
        /// Test GetWaitingById
        /// </summary>
        [Test]
        public void GetWaitingByIdTest()
        {
            // TODO: add unit test for the method 'GetWaitingById'
            int? restaurantId = null; // TODO: replace null with proper value
int? waitingItemId = null; // TODO: replace null with proper value
            var response = instance.GetWaitingById(restaurantId, waitingItemId);
            Assert.IsInstanceOf<WaitingItem> (response, "response is WaitingItem"); 
        }
        
        /// <summary>
        /// Test GetWaitingSettings
        /// </summary>
        [Test]
        public void GetWaitingSettingsTest()
        {
            // TODO: add unit test for the method 'GetWaitingSettings'
            int? restaurantId = null; // TODO: replace null with proper value
            var response = instance.GetWaitingSettings(restaurantId);
            Assert.IsInstanceOf<WaitingSettings> (response, "response is WaitingSettings"); 
        }
        
        /// <summary>
        /// Test GetWaitingTimeByGroup
        /// </summary>
        [Test]
        public void GetWaitingTimeByGroupTest()
        {
            // TODO: add unit test for the method 'GetWaitingTimeByGroup'
            int? restaurantId = null; // TODO: replace null with proper value
DateTimeOffset? from = null; // TODO: replace null with proper value
DateTimeOffset? to = null; // TODO: replace null with proper value
            var response = instance.GetWaitingTimeByGroup(restaurantId, from, to);
            Assert.IsInstanceOf<List<WaitingsStatReportItem>> (response, "response is List<WaitingsStatReportItem>"); 
        }
        
        /// <summary>
        /// Test GetWaitingTimeByHour
        /// </summary>
        [Test]
        public void GetWaitingTimeByHourTest()
        {
            // TODO: add unit test for the method 'GetWaitingTimeByHour'
            int? restaurantId = null; // TODO: replace null with proper value
DateTimeOffset? from = null; // TODO: replace null with proper value
DateTimeOffset? to = null; // TODO: replace null with proper value
            var response = instance.GetWaitingTimeByHour(restaurantId, from, to);
            Assert.IsInstanceOf<List<WaitingsStatReportItem>> (response, "response is List<WaitingsStatReportItem>"); 
        }
        
        /// <summary>
        /// Test GetWaitingTimeByLine
        /// </summary>
        [Test]
        public void GetWaitingTimeByLineTest()
        {
            // TODO: add unit test for the method 'GetWaitingTimeByLine'
            int? restaurantId = null; // TODO: replace null with proper value
DateTimeOffset? from = null; // TODO: replace null with proper value
DateTimeOffset? to = null; // TODO: replace null with proper value
            var response = instance.GetWaitingTimeByLine(restaurantId, from, to);
            Assert.IsInstanceOf<List<WaitingsStatReportItem>> (response, "response is List<WaitingsStatReportItem>"); 
        }
        
        /// <summary>
        /// Test GetWaitingTimeByMeal
        /// </summary>
        [Test]
        public void GetWaitingTimeByMealTest()
        {
            // TODO: add unit test for the method 'GetWaitingTimeByMeal'
            int? restaurantId = null; // TODO: replace null with proper value
DateTimeOffset? from = null; // TODO: replace null with proper value
DateTimeOffset? to = null; // TODO: replace null with proper value
            var response = instance.GetWaitingTimeByMeal(restaurantId, from, to);
            Assert.IsInstanceOf<List<WaitingsStatReportItem>> (response, "response is List<WaitingsStatReportItem>"); 
        }
        
        /// <summary>
        /// Test GetWaitingTimeByWeek
        /// </summary>
        [Test]
        public void GetWaitingTimeByWeekTest()
        {
            // TODO: add unit test for the method 'GetWaitingTimeByWeek'
            int? restaurantId = null; // TODO: replace null with proper value
DateTimeOffset? from = null; // TODO: replace null with proper value
DateTimeOffset? to = null; // TODO: replace null with proper value
            var response = instance.GetWaitingTimeByWeek(restaurantId, from, to);
            Assert.IsInstanceOf<List<WaitingsStatReportItem>> (response, "response is List<WaitingsStatReportItem>"); 
        }
        
        /// <summary>
        /// Test GetWaitingTimeByWeekDay
        /// </summary>
        [Test]
        public void GetWaitingTimeByWeekDayTest()
        {
            // TODO: add unit test for the method 'GetWaitingTimeByWeekDay'
            int? restaurantId = null; // TODO: replace null with proper value
DateTimeOffset? from = null; // TODO: replace null with proper value
DateTimeOffset? to = null; // TODO: replace null with proper value
            var response = instance.GetWaitingTimeByWeekDay(restaurantId, from, to);
            Assert.IsInstanceOf<List<WaitingsStatReportItem>> (response, "response is List<WaitingsStatReportItem>"); 
        }
        
        /// <summary>
        /// Test GetWaitingsForPeriod
        /// </summary>
        [Test]
        public void GetWaitingsForPeriodTest()
        {
            // TODO: add unit test for the method 'GetWaitingsForPeriod'
            int? restaurantId = null; // TODO: replace null with proper value
DateTimeOffset? from = null; // TODO: replace null with proper value
DateTimeOffset? to = null; // TODO: replace null with proper value
            var response = instance.GetWaitingsForPeriod(restaurantId, from, to);
            Assert.IsInstanceOf<List<WaitingReportItem>> (response, "response is List<WaitingReportItem>"); 
        }
        
        /// <summary>
        /// Test GetWaitingsGroupBy
        /// </summary>
        [Test]
        public void GetWaitingsGroupByTest()
        {
            // TODO: add unit test for the method 'GetWaitingsGroupBy'
            int? restaurantId = null; // TODO: replace null with proper value
string groupBy = null; // TODO: replace null with proper value
DateTimeOffset? from = null; // TODO: replace null with proper value
DateTimeOffset? to = null; // TODO: replace null with proper value
            var response = instance.GetWaitingsGroupBy(restaurantId, groupBy, from, to);
            Assert.IsInstanceOf<List<WaitingsStatReportItem>> (response, "response is List<WaitingsStatReportItem>"); 
        }
        
        /// <summary>
        /// Test Incoming
        /// </summary>
        [Test]
        public void IncomingTest()
        {
            // TODO: add unit test for the method 'Incoming'
            string from = null; // TODO: replace null with proper value
string to = null; // TODO: replace null with proper value
string body = null; // TODO: replace null with proper value
            var response = instance.Incoming(from, to, body);
            Assert.IsInstanceOf<Object> (response, "response is Object"); 
        }
        
        /// <summary>
        /// Test MarkAllMessagesAsRead
        /// </summary>
        [Test]
        public void MarkAllMessagesAsReadTest()
        {
            // TODO: add unit test for the method 'MarkAllMessagesAsRead'
            int? restaurantId = null; // TODO: replace null with proper value
int? waitingItemId = null; // TODO: replace null with proper value
            instance.MarkAllMessagesAsRead(restaurantId, waitingItemId);
             
        }
        
        /// <summary>
        /// Test PutOnHold
        /// </summary>
        [Test]
        public void PutOnHoldTest()
        {
            // TODO: add unit test for the method 'PutOnHold'
            int? restaurantId = null; // TODO: replace null with proper value
int? waitingItemId = null; // TODO: replace null with proper value
            instance.PutOnHold(restaurantId, waitingItemId);
             
        }
        
        /// <summary>
        /// Test ReOpenWaiting
        /// </summary>
        [Test]
        public void ReOpenWaitingTest()
        {
            // TODO: add unit test for the method 'ReOpenWaiting'
            int? restaurantId = null; // TODO: replace null with proper value
int? waitingItemId = null; // TODO: replace null with proper value
            var response = instance.ReOpenWaiting(restaurantId, waitingItemId);
            Assert.IsInstanceOf<WaitingItem> (response, "response is WaitingItem"); 
        }
        
        /// <summary>
        /// Test SendMessage
        /// </summary>
        [Test]
        public void SendMessageTest()
        {
            // TODO: add unit test for the method 'SendMessage'
            int? restaurantId = null; // TODO: replace null with proper value
int? waitingItemId = null; // TODO: replace null with proper value
string origin = null; // TODO: replace null with proper value
string body = null; // TODO: replace null with proper value
            var response = instance.SendMessage(restaurantId, waitingItemId, origin, body);
            Assert.IsInstanceOf<Message> (response, "response is Message"); 
        }
        
        /// <summary>
        /// Test SetWaitingSettings
        /// </summary>
        [Test]
        public void SetWaitingSettingsTest()
        {
            // TODO: add unit test for the method 'SetWaitingSettings'
            int? restaurantId = null; // TODO: replace null with proper value
WaitingSettings settings = null; // TODO: replace null with proper value
            instance.SetWaitingSettings(restaurantId, settings);
             
        }
        
        /// <summary>
        /// Test TakeOffHold
        /// </summary>
        [Test]
        public void TakeOffHoldTest()
        {
            // TODO: add unit test for the method 'TakeOffHold'
            int? restaurantId = null; // TODO: replace null with proper value
int? waitingItemId = null; // TODO: replace null with proper value
            instance.TakeOffHold(restaurantId, waitingItemId);
             
        }
        
        /// <summary>
        /// Test UpdateWaiting
        /// </summary>
        [Test]
        public void UpdateWaitingTest()
        {
            // TODO: add unit test for the method 'UpdateWaiting'
            int? restaurantId = null; // TODO: replace null with proper value
int? waitingItemId = null; // TODO: replace null with proper value
UpdateWaitingItemBindingModel item = null; // TODO: replace null with proper value
            var response = instance.UpdateWaiting(restaurantId, waitingItemId, item);
            Assert.IsInstanceOf<WaitingItem> (response, "response is WaitingItem"); 
        }
        
    }

}
