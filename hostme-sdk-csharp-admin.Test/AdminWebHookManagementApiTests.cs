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
    ///  Class for testing AdminWebHookManagementApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AdminWebHookManagementApiTests
    {
        private AdminWebHookManagementApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new AdminWebHookManagementApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AdminWebHookManagementApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<AdminWebHookManagementApi> (instance, "instance is a AdminWebHookManagementApi");
        }

        
        /// <summary>
        /// Test Delete
        /// </summary>
        [Test]
        public void DeleteTest()
        {
            // TODO: add unit test for the method 'Delete'
            string id = null; // TODO: replace null with proper value
            var response = instance.Delete(id);
            Assert.IsInstanceOf<Object> (response, "response is Object"); 
        }
        
        /// <summary>
        /// Test DeleteAll
        /// </summary>
        [Test]
        public void DeleteAllTest()
        {
            // TODO: add unit test for the method 'DeleteAll'
                        var response = instance.DeleteAll();
            Assert.IsInstanceOf<Object> (response, "response is Object"); 
        }
        
        /// <summary>
        /// Test Get
        /// </summary>
        [Test]
        public void GetTest()
        {
            // TODO: add unit test for the method 'Get'
                        var response = instance.Get();
            Assert.IsInstanceOf<List<WebHookFilter>> (response, "response is List<WebHookFilter>"); 
        }
        
        /// <summary>
        /// Test Get_0
        /// </summary>
        [Test]
        public void Get_0Test()
        {
            // TODO: add unit test for the method 'Get_0'
                        var response = instance.Get_0();
            Assert.IsInstanceOf<List<WebHook>> (response, "response is List<WebHook>"); 
        }
        
        /// <summary>
        /// Test Lookup
        /// </summary>
        [Test]
        public void LookupTest()
        {
            // TODO: add unit test for the method 'Lookup'
            string id = null; // TODO: replace null with proper value
            var response = instance.Lookup(id);
            Assert.IsInstanceOf<WebHook> (response, "response is WebHook"); 
        }
        
        /// <summary>
        /// Test Post
        /// </summary>
        [Test]
        public void PostTest()
        {
            // TODO: add unit test for the method 'Post'
            WebHook webHook = null; // TODO: replace null with proper value
            var response = instance.Post(webHook);
            Assert.IsInstanceOf<WebHook> (response, "response is WebHook"); 
        }
        
        /// <summary>
        /// Test Put
        /// </summary>
        [Test]
        public void PutTest()
        {
            // TODO: add unit test for the method 'Put'
            string id = null; // TODO: replace null with proper value
WebHook webHook = null; // TODO: replace null with proper value
            var response = instance.Put(id, webHook);
            Assert.IsInstanceOf<Object> (response, "response is Object"); 
        }
        
    }

}
