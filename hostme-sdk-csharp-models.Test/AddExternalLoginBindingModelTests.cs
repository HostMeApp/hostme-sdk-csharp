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
    ///  Class for testing AddExternalLoginBindingModel
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class AddExternalLoginBindingModelTests
    {
        private AddExternalLoginBindingModel instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AddExternalLoginBindingModel();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of AddExternalLoginBindingModel
        /// </summary>
        [Test]
        public void AddExternalLoginBindingModelInstanceTest()
        {
            Assert.IsInstanceOf<AddExternalLoginBindingModel> (instance, "instance is a AddExternalLoginBindingModel");
        }

        /// <summary>
        /// Test the property 'ExternalAccessToken' 
        /// </summary>
        [Test]
        public void ExternalAccessTokenTest()
        {
            // TODO: unit test for the property 'ExternalAccessToken' 
        }

    }

}
