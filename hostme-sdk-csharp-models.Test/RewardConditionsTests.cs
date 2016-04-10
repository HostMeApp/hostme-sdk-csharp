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
    ///  Class for testing RewardConditions
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class RewardConditionsTests
    {
        private RewardConditions instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new RewardConditions();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of RewardConditions
        /// </summary>
        [Test]
        public void RewardConditionsInstanceTest()
        {
            Assert.IsInstanceOf<RewardConditions> (instance, "instance is a RewardConditions");
        }

        /// <summary>
        /// Test the property 'AvailableHours' 
        /// </summary>
        [Test]
        public void AvailableHoursTest()
        {
            // TODO: unit test for the property 'AvailableHours' 
        }
        /// <summary>
        /// Test the property 'MembershipLevel' 
        /// </summary>
        [Test]
        public void MembershipLevelTest()
        {
            // TODO: unit test for the property 'MembershipLevel' 
        }

    }

}
