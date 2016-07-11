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
    ///  Class for testing ZoneCreate
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ZoneCreateTests
    {
        private ZoneCreate instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ZoneCreate();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ZoneCreate
        /// </summary>
        [Test]
        public void ZoneCreateInstanceTest()
        {
            Assert.IsInstanceOf<ZoneCreate> (instance, "instance is a ZoneCreate");
        }

        /// <summary>
        /// Test the property 'Name' 
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO: unit test for the property 'Name' 
        }
        /// <summary>
        /// Test the property 'TableNumbers' 
        /// </summary>
        [Test]
        public void TableNumbersTest()
        {
            // TODO: unit test for the property 'TableNumbers' 
        }
        /// <summary>
        /// Test the property 'Days' 
        /// </summary>
        [Test]
        public void DaysTest()
        {
            // TODO: unit test for the property 'Days' 
        }

    }

}