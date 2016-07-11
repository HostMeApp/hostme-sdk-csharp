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
    ///  Class for testing TableState
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class TableStateTests
    {
        private TableState instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TableState();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of TableState
        /// </summary>
        [Test]
        public void TableStateInstanceTest()
        {
            Assert.IsInstanceOf<TableState> (instance, "instance is a TableState");
        }

        /// <summary>
        /// Test the property 'Title' 
        /// </summary>
        [Test]
        public void TitleTest()
        {
            // TODO: unit test for the property 'Title' 
        }
        /// <summary>
        /// Test the property 'Percents' 
        /// </summary>
        [Test]
        public void PercentsTest()
        {
            // TODO: unit test for the property 'Percents' 
        }
        /// <summary>
        /// Test the property 'Color' 
        /// </summary>
        [Test]
        public void ColorTest()
        {
            // TODO: unit test for the property 'Color' 
        }
        /// <summary>
        /// Test the property 'IsCustom' 
        /// </summary>
        [Test]
        public void IsCustomTest()
        {
            // TODO: unit test for the property 'IsCustom' 
        }
        /// <summary>
        /// Test the property 'IsActive' 
        /// </summary>
        [Test]
        public void IsActiveTest()
        {
            // TODO: unit test for the property 'IsActive' 
        }

    }

}
