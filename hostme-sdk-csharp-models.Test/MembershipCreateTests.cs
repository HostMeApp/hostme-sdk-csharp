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
    ///  Class for testing MembershipCreate
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class MembershipCreateTests
    {
        private MembershipCreate instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new MembershipCreate();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of MembershipCreate
        /// </summary>
        [Test]
        public void MembershipCreateInstanceTest()
        {
            Assert.IsInstanceOf<MembershipCreate> (instance, "instance is a MembershipCreate");
        }

        /// <summary>
        /// Test the property 'FullName' 
        /// </summary>
        [Test]
        public void FullNameTest()
        {
            // TODO: unit test for the property 'FullName' 
        }
        /// <summary>
        /// Test the property 'PhoneNumber' 
        /// </summary>
        [Test]
        public void PhoneNumberTest()
        {
            // TODO: unit test for the property 'PhoneNumber' 
        }
        /// <summary>
        /// Test the property 'Note' 
        /// </summary>
        [Test]
        public void NoteTest()
        {
            // TODO: unit test for the property 'Note' 
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
