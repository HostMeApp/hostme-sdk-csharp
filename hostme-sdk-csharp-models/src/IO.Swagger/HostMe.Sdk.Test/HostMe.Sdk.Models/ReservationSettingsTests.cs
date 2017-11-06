/* 
 * Qa full api
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: all
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


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using HostMe.Sdk.Api;
using HostMe.Sdk.Model;
using HostMe.Sdk.Client;
using System.Reflection;

namespace HostMe.Sdk.Test
{
    /// <summary>
    ///  Class for testing ReservationSettings
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ReservationSettingsTests
    {
        // TODO uncomment below to declare an instance variable for ReservationSettings
        //private ReservationSettings instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ReservationSettings
            //instance = new ReservationSettings();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ReservationSettings
        /// </summary>
        [Test]
        public void ReservationSettingsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ReservationSettings
            //Assert.IsInstanceOfType<ReservationSettings> (instance, "variable 'instance' is a ReservationSettings");
        }

        /// <summary>
        /// Test the property 'AvailabilityMethod'
        /// </summary>
        [Test]
        public void AvailabilityMethodTest()
        {
            // TODO unit test for the property 'AvailabilityMethod'
        }
        /// <summary>
        /// Test the property 'ServersRotationType'
        /// </summary>
        [Test]
        public void ServersRotationTypeTest()
        {
            // TODO unit test for the property 'ServersRotationType'
        }
        /// <summary>
        /// Test the property 'ConfirmationMessageRequestTemplate'
        /// </summary>
        [Test]
        public void ConfirmationMessageRequestTemplateTest()
        {
            // TODO unit test for the property 'ConfirmationMessageRequestTemplate'
        }
        /// <summary>
        /// Test the property 'CoversAvailableForWait'
        /// </summary>
        [Test]
        public void CoversAvailableForWaitTest()
        {
            // TODO unit test for the property 'CoversAvailableForWait'
        }
        /// <summary>
        /// Test the property 'CoversAvaliableForReservation'
        /// </summary>
        [Test]
        public void CoversAvaliableForReservationTest()
        {
            // TODO unit test for the property 'CoversAvaliableForReservation'
        }
        /// <summary>
        /// Test the property 'DefaultMaxCoversPerSlot'
        /// </summary>
        [Test]
        public void DefaultMaxCoversPerSlotTest()
        {
            // TODO unit test for the property 'DefaultMaxCoversPerSlot'
        }
        /// <summary>
        /// Test the property 'EnableAutoScheduling'
        /// </summary>
        [Test]
        public void EnableAutoSchedulingTest()
        {
            // TODO unit test for the property 'EnableAutoScheduling'
        }
        /// <summary>
        /// Test the property 'ApprovalRequired'
        /// </summary>
        [Test]
        public void ApprovalRequiredTest()
        {
            // TODO unit test for the property 'ApprovalRequired'
        }
        /// <summary>
        /// Test the property 'SkipConfirmDialog'
        /// </summary>
        [Test]
        public void SkipConfirmDialogTest()
        {
            // TODO unit test for the property 'SkipConfirmDialog'
        }
        /// <summary>
        /// Test the property 'IsEnabled'
        /// </summary>
        [Test]
        public void IsEnabledTest()
        {
            // TODO unit test for the property 'IsEnabled'
        }
        /// <summary>
        /// Test the property 'GuestReservationNote'
        /// </summary>
        [Test]
        public void GuestReservationNoteTest()
        {
            // TODO unit test for the property 'GuestReservationNote'
        }
        /// <summary>
        /// Test the property 'ChargeIfCancelledBefore'
        /// </summary>
        [Test]
        public void ChargeIfCancelledBeforeTest()
        {
            // TODO unit test for the property 'ChargeIfCancelledBefore'
        }
        /// <summary>
        /// Test the property 'AvailableOnlineAreas'
        /// </summary>
        [Test]
        public void AvailableOnlineAreasTest()
        {
            // TODO unit test for the property 'AvailableOnlineAreas'
        }
        /// <summary>
        /// Test the property 'UseManagersEmailForToSendFrom'
        /// </summary>
        [Test]
        public void UseManagersEmailForToSendFromTest()
        {
            // TODO unit test for the property 'UseManagersEmailForToSendFrom'
        }
        /// <summary>
        /// Test the property 'GroupSizeValidation'
        /// </summary>
        [Test]
        public void GroupSizeValidationTest()
        {
            // TODO unit test for the property 'GroupSizeValidation'
        }
        /// <summary>
        /// Test the property 'Currency'
        /// </summary>
        [Test]
        public void CurrencyTest()
        {
            // TODO unit test for the property 'Currency'
        }
        /// <summary>
        /// Test the property 'MaxCoversPerSlotExceptions'
        /// </summary>
        [Test]
        public void MaxCoversPerSlotExceptionsTest()
        {
            // TODO unit test for the property 'MaxCoversPerSlotExceptions'
        }
        /// <summary>
        /// Test the property 'MaxMinutesLate'
        /// </summary>
        [Test]
        public void MaxMinutesLateTest()
        {
            // TODO unit test for the property 'MaxMinutesLate'
        }
        /// <summary>
        /// Test the property 'MaxPartySize'
        /// </summary>
        [Test]
        public void MaxPartySizeTest()
        {
            // TODO unit test for the property 'MaxPartySize'
        }
        /// <summary>
        /// Test the property 'MinutesToBlockTable'
        /// </summary>
        [Test]
        public void MinutesToBlockTableTest()
        {
            // TODO unit test for the property 'MinutesToBlockTable'
        }
        /// <summary>
        /// Test the property 'MiniutesToConfirm'
        /// </summary>
        [Test]
        public void MiniutesToConfirmTest()
        {
            // TODO unit test for the property 'MiniutesToConfirm'
        }
        /// <summary>
        /// Test the property 'MinPartySize'
        /// </summary>
        [Test]
        public void MinPartySizeTest()
        {
            // TODO unit test for the property 'MinPartySize'
        }
        /// <summary>
        /// Test the property 'OptionalTableAssignment'
        /// </summary>
        [Test]
        public void OptionalTableAssignmentTest()
        {
            // TODO unit test for the property 'OptionalTableAssignment'
        }
        /// <summary>
        /// Test the property 'NotifyPhoneNumber'
        /// </summary>
        [Test]
        public void NotifyPhoneNumberTest()
        {
            // TODO unit test for the property 'NotifyPhoneNumber'
        }
        /// <summary>
        /// Test the property 'StripeConnected'
        /// </summary>
        [Test]
        public void StripeConnectedTest()
        {
            // TODO unit test for the property 'StripeConnected'
        }
        /// <summary>
        /// Test the property 'BookingMinimumNoticeMinutes'
        /// </summary>
        [Test]
        public void BookingMinimumNoticeMinutesTest()
        {
            // TODO unit test for the property 'BookingMinimumNoticeMinutes'
        }
        /// <summary>
        /// Test the property 'MinutesToNotifyManager'
        /// </summary>
        [Test]
        public void MinutesToNotifyManagerTest()
        {
            // TODO unit test for the property 'MinutesToNotifyManager'
        }
        /// <summary>
        /// Test the property 'RequireReservationConfirmation'
        /// </summary>
        [Test]
        public void RequireReservationConfirmationTest()
        {
            // TODO unit test for the property 'RequireReservationConfirmation'
        }
        /// <summary>
        /// Test the property 'AutoTableAssignment'
        /// </summary>
        [Test]
        public void AutoTableAssignmentTest()
        {
            // TODO unit test for the property 'AutoTableAssignment'
        }
        /// <summary>
        /// Test the property 'ReservationEmail'
        /// </summary>
        [Test]
        public void ReservationEmailTest()
        {
            // TODO unit test for the property 'ReservationEmail'
        }
        /// <summary>
        /// Test the property 'ReservationHours'
        /// </summary>
        [Test]
        public void ReservationHoursTest()
        {
            // TODO unit test for the property 'ReservationHours'
        }
        /// <summary>
        /// Test the property 'ReservationHoursStep'
        /// </summary>
        [Test]
        public void ReservationHoursStepTest()
        {
            // TODO unit test for the property 'ReservationHoursStep'
        }
        /// <summary>
        /// Test the property 'StatusMessages'
        /// </summary>
        [Test]
        public void StatusMessagesTest()
        {
            // TODO unit test for the property 'StatusMessages'
        }
        /// <summary>
        /// Test the property 'TableStates'
        /// </summary>
        [Test]
        public void TableStatesTest()
        {
            // TODO unit test for the property 'TableStates'
        }
        /// <summary>
        /// Test the property 'AdditionalInfo'
        /// </summary>
        [Test]
        public void AdditionalInfoTest()
        {
            // TODO unit test for the property 'AdditionalInfo'
        }
        /// <summary>
        /// Test the property 'NoShowFeeEnabled'
        /// </summary>
        [Test]
        public void NoShowFeeEnabledTest()
        {
            // TODO unit test for the property 'NoShowFeeEnabled'
        }
        /// <summary>
        /// Test the property 'DepositRules'
        /// </summary>
        [Test]
        public void DepositRulesTest()
        {
            // TODO unit test for the property 'DepositRules'
        }
        /// <summary>
        /// Test the property 'CreditCardChargeEnabled'
        /// </summary>
        [Test]
        public void CreditCardChargeEnabledTest()
        {
            // TODO unit test for the property 'CreditCardChargeEnabled'
        }
        /// <summary>
        /// Test the property 'TableTurnOver'
        /// </summary>
        [Test]
        public void TableTurnOverTest()
        {
            // TODO unit test for the property 'TableTurnOver'
        }
        /// <summary>
        /// Test the property 'TableTurnOverByGroup'
        /// </summary>
        [Test]
        public void TableTurnOverByGroupTest()
        {
            // TODO unit test for the property 'TableTurnOverByGroup'
        }
        /// <summary>
        /// Test the property 'TotalCovers'
        /// </summary>
        [Test]
        public void TotalCoversTest()
        {
            // TODO unit test for the property 'TotalCovers'
        }

    }

}
