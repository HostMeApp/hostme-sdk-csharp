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
    ///  Class for testing Membership
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class MembershipTests
    {
        private Membership instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Membership();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Membership
        /// </summary>
        [Test]
        public void MembershipInstanceTest()
        {
            Assert.IsInstanceOf<Membership> (instance, "instance is a Membership");
        }

        /// <summary>
        /// Test the property 'Id' 
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO: unit test for the property 'Id' 
        }
        /// <summary>
        /// Test the property 'MembershipLevel' 
        /// </summary>
        [Test]
        public void MembershipLevelTest()
        {
            // TODO: unit test for the property 'MembershipLevel' 
        }
        /// <summary>
        /// Test the property 'Points' 
        /// </summary>
        [Test]
        public void PointsTest()
        {
            // TODO: unit test for the property 'Points' 
        }
        /// <summary>
        /// Test the property 'JoinDate' 
        /// </summary>
        [Test]
        public void JoinDateTest()
        {
            // TODO: unit test for the property 'JoinDate' 
        }
        /// <summary>
        /// Test the property 'Status' 
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO: unit test for the property 'Status' 
        }
        /// <summary>
        /// Test the property 'Restaurant' 
        /// </summary>
        [Test]
        public void RestaurantTest()
        {
            // TODO: unit test for the property 'Restaurant' 
        }
        /// <summary>
        /// Test the property 'IsMember' 
        /// </summary>
        [Test]
        public void IsMemberTest()
        {
            // TODO: unit test for the property 'IsMember' 
        }
        /// <summary>
        /// Test the property 'Profile' 
        /// </summary>
        [Test]
        public void ProfileTest()
        {
            // TODO: unit test for the property 'Profile' 
        }

    }

}
