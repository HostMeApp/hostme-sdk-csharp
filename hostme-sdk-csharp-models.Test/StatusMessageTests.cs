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
    ///  Class for testing StatusMessage
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class StatusMessageTests
    {
        private StatusMessage instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new StatusMessage();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of StatusMessage
        /// </summary>
        [Test]
        public void StatusMessageInstanceTest()
        {
            Assert.IsInstanceOf<StatusMessage> (instance, "instance is a StatusMessage");
        }

        /// <summary>
        /// Test the property 'FromStatus' 
        /// </summary>
        [Test]
        public void FromStatusTest()
        {
            // TODO: unit test for the property 'FromStatus' 
        }
        /// <summary>
        /// Test the property 'ToStatus' 
        /// </summary>
        [Test]
        public void ToStatusTest()
        {
            // TODO: unit test for the property 'ToStatus' 
        }
        /// <summary>
        /// Test the property 'MessageTemplate' 
        /// </summary>
        [Test]
        public void MessageTemplateTest()
        {
            // TODO: unit test for the property 'MessageTemplate' 
        }

    }

}
