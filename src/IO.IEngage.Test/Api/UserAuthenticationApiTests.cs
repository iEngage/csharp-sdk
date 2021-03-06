/* 
 * iEngage 2.0 API
 *
 * This API enables Intelligent Engagement for your Business. iEngage is a platform that combines process, augmented intelligence and rewards to help you intelligently engage customers.
 *
 * OpenAPI spec version: 2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.IEngage.Client;
using IO.IEngage.Api;
using IO.IEngage.Model;

namespace IO.IEngage.Test
{
    /// <summary>
    ///  Class for testing UserAuthenticationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class UserAuthenticationApiTests
    {
        private UserAuthenticationApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {

            Configuration.Default.AccessToken = null;
            instance = new UserAuthenticationApi();
            

        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UserAuthenticationApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' UserAuthenticationApi
            //Assert.IsInstanceOfType(typeof(UserAuthenticationApi), instance, "instance is a UserAuthenticationApi");
        }

        
        /// <summary>
        /// Test AddNotificationRegisteredId
        /// </summary>
        [Test]
        public void AddNotificationRegisteredIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string registeredId = null;
            string type = null;
            string clientToken = null;
            string requesterId = null;
            string accessToken = null;
            var response = instance.AddNotificationRegisteredId(registeredId, type, clientToken, requesterId, accessToken);
            Assert.IsInstanceOf<bool?> (response, "response is bool?");
        }
        
        /// <summary>
        /// Test AddUser
        /// </summary>
        [Test]
        public void AddUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string screenName = null;
            string emailId = null;
            string password = null;
            string clientToken = null;
            string firstName = null;
            string middleName = null;
            string lastName = null;
            int? birthDay = null;
            int? birthMonth = null;
            int? birthYear = null;
            string additionInformation = null;
            var response = instance.AddUser(screenName, emailId, password, clientToken, firstName, middleName, lastName, birthDay, birthMonth, birthYear, additionInformation);
            Console.WriteLine(response);
            Assert.IsInstanceOf<VerveResponseUser> (response, "response is VerveResponseUser");
        }
        
        /// <summary>
        /// Test Authenticate
        /// </summary>
        [Test]
        public void AuthenticateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string userName = null;
            string password = null;
            string clientToken = null;
            var response = instance.Authenticate(userName, password, clientToken);
            Assert.IsInstanceOf<User> (response, "response is User");
        }
        
        /// <summary>
        /// Test ChangePassword
        /// </summary>
        [Test]
        public void ChangePasswordTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string currentPassword = null;
            string newPassword = null;
            string requesterId = null;
            string clientToken = null;
            string accessToken = null;
            var response = instance.ChangePassword(currentPassword, newPassword, requesterId, clientToken, accessToken);
            Assert.IsInstanceOf<bool?> (response, "response is bool?");
        }
        
        /// <summary>
        /// Test CreateAssociation
        /// </summary>
        [Test]
        public void CreateAssociationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = null;
            string requesterId = null;
            string clientToken = null;
            string accessToken = null;
            var response = instance.CreateAssociation(name, requesterId, clientToken, accessToken);
            Assert.IsInstanceOf<VerveResponseAssociation> (response, "response is VerveResponseAssociation");
        }
        
        /// <summary>
        /// Test DeleteUser
        /// </summary>
        [Test]
        public void DeleteUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            long? userId = null;
            string clientToken = null;
            var response = instance.DeleteUser(userId, clientToken);
            Assert.IsInstanceOf<VerveResponseUser> (response, "response is VerveResponseUser");
        }

        /// <summary>
        /// Test GetAssociations
        /// </summary>
        [Test]
        public void GetAssociationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
             string requesterId = null;
            string clientToken = null;
            string accessToken = null;
            var response = instance.GetAssociations(requesterId, clientToken, accessToken);

            string x = response.ToString();
            Console.Write(x);
            Assert.IsInstanceOf<VerveResponseAssociationList> (response, "response is VerveResponseAssociationList");
        }
        
        /// <summary>
        /// Test Logout
        /// </summary>
        [Test]
        public void LogoutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
             string requesterId = null;
            string clientToken = null;
            string accessToken = null;
            var response = instance.Logout(requesterId, clientToken, accessToken);
            string x = response.ToString();
            Console.Write(x);
            Assert.IsInstanceOf<bool?> (response, "response is bool?");
        }
        
    }

}
