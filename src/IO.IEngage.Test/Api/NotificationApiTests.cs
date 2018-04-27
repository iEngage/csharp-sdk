/* 
 * iEngage 2.0 API
 *
 * This API enables Intelligent Engagement for your Business. iEngage is a platform that combines process, augmented intelligence and rewards to help you intelligently engage customers.
 *
 * OpenAPI spec version: 2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
    ///  Class for testing NotificationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class NotificationApiTests
    {
        private NotificationApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new NotificationApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of NotificationApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' NotificationApi
            //Assert.IsInstanceOfType(typeof(NotificationApi), instance, "instance is a NotificationApi");
        }

        
        /// <summary>
        /// Test AddNotification
        /// </summary>
        [Test]
        public void AddNotificationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string requesterId = null;
            //string clientToken = null;
            //Notification body = null;
            //string accessToken = null;
            //var response = instance.AddNotification(requesterId, clientToken, body, accessToken);
            //Assert.IsInstanceOf<bool?> (response, "response is bool?");
        }
        
        /// <summary>
        /// Test GetNotifications
        /// </summary>
        [Test]
        public void GetNotificationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string type = null;
            //int? start = null;
            //int? end = null;
            //string requesterId = null;
            //string clientToken = null;
            //string fields = null;
            //string accessToken = null;
            //var response = instance.GetNotifications(type, start, end, requesterId, clientToken, fields, accessToken);
            //Assert.IsInstanceOf<VerveResponseNotificationList> (response, "response is VerveResponseNotificationList");
        }
        
        /// <summary>
        /// Test MarkAllNotificationAsRead
        /// </summary>
        [Test]
        public void MarkAllNotificationAsReadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string requesterId = null;
            //string clientToken = null;
            //string accessToken = null;
            //var response = instance.MarkAllNotificationAsRead(requesterId, clientToken, accessToken);
            //Assert.IsInstanceOf<bool?> (response, "response is bool?");
        }
        
        /// <summary>
        /// Test MarkNotificationAsRead
        /// </summary>
        [Test]
        public void MarkNotificationAsReadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? notificationId = null;
            //string requesterId = null;
            //string clientToken = null;
            //string accessToken = null;
            //var response = instance.MarkNotificationAsRead(notificationId, requesterId, clientToken, accessToken);
            //Assert.IsInstanceOf<bool?> (response, "response is bool?");
        }
        
        /// <summary>
        /// Test NotificationCount
        /// </summary>
        [Test]
        public void NotificationCountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string type = null;
            //string requesterId = null;
            //string clientToken = null;
            //string accessToken = null;
            //var response = instance.NotificationCount(type, requesterId, clientToken, accessToken);
            //Assert.IsInstanceOf<long?> (response, "response is long?");
        }
        
    }

}
