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
    ///  Class for testing TableUser
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class TableUserTests
    {
        private TableUser instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TableUser();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of TableUser
        /// </summary>
        [Test]
        public void TableUserInstanceTest()
        {
            Assert.IsInstanceOf<TableUser> (instance, "instance is a TableUser");
        }

        /// <summary>
        /// Test the property 'Table' 
        /// </summary>
        [Test]
        public void TableTest()
        {
            // TODO: unit test for the property 'Table' 
        }
        /// <summary>
        /// Test the property 'User' 
        /// </summary>
        [Test]
        public void UserTest()
        {
            // TODO: unit test for the property 'User' 
        }
        /// <summary>
        /// Test the property 'RegistrationTime' 
        /// </summary>
        [Test]
        public void RegistrationTimeTest()
        {
            // TODO: unit test for the property 'RegistrationTime' 
        }
        /// <summary>
        /// Test the property 'EstimatedReleaseTime' 
        /// </summary>
        [Test]
        public void EstimatedReleaseTimeTest()
        {
            // TODO: unit test for the property 'EstimatedReleaseTime' 
        }

    }

}
