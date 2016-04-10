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
    ///  Class for testing ReservationInfo
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ReservationInfoTests
    {
        private ReservationInfo instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ReservationInfo();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ReservationInfo
        /// </summary>
        [Test]
        public void ReservationInfoInstanceTest()
        {
            Assert.IsInstanceOf<ReservationInfo> (instance, "instance is a ReservationInfo");
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
        /// Test the property 'ReservationTime' 
        /// </summary>
        [Test]
        public void ReservationTimeTest()
        {
            // TODO: unit test for the property 'ReservationTime' 
        }

    }

}
