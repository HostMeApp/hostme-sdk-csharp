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
    ///  Class for testing IEdmTerm
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class IEdmTermTests
    {
        private IEdmTerm instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new IEdmTerm();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of IEdmTerm
        /// </summary>
        [Test]
        public void IEdmTermInstanceTest()
        {
            Assert.IsInstanceOf<IEdmTerm> (instance, "instance is a IEdmTerm");
        }

        /// <summary>
        /// Test the property 'TermKind' 
        /// </summary>
        [Test]
        public void TermKindTest()
        {
            // TODO: unit test for the property 'TermKind' 
        }
        /// <summary>
        /// Test the property 'SchemaElementKind' 
        /// </summary>
        [Test]
        public void SchemaElementKindTest()
        {
            // TODO: unit test for the property 'SchemaElementKind' 
        }
        /// <summary>
        /// Test the property '_Namespace' 
        /// </summary>
        [Test]
        public void _NamespaceTest()
        {
            // TODO: unit test for the property '_Namespace' 
        }
        /// <summary>
        /// Test the property 'Name' 
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO: unit test for the property 'Name' 
        }

    }

}
