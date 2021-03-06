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
    ///  Class for testing InteractionApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class InteractionApiTests
    {
        private InteractionApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            Configuration.Default.AccessToken = null;
            instance = new InteractionApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of InteractionApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' InteractionApi
            //Assert.IsInstanceOfType(typeof(InteractionApi), instance, "instance is a InteractionApi");
        }

        
        /// <summary>
        /// Test AddInteraction
        /// </summary>
        [Test]
        public void AddInteractionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string requesterId = null;
            string clientToken = null;
            InteractionInputModel body = null;
            string accessToken = null;
            var response = instance.AddInteraction(requesterId, clientToken, body, accessToken);

            Console.Write(response.ToString());
            Assert.IsInstanceOf<VerveResponseInteraction> (response, "response is VerveResponseInteraction");
        }
        
        /// <summary>
        /// Test AddInteraction_0
        /// </summary>
        [Test]
        public void AddInteraction_0Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string interactionTitle = null;
            //System.IO.Stream file = null;
            //string requesterId = null;
            //string clientToken = null;
            //string categoryId = null;;
            //string interactionType = null;
            //string interactionDescription = null;
            //string association = null;
            //string accessToken = null;
            //var response = instance.AddInteraction_0(interactionTitle, file, requesterId, clientToken, categoryId, interactionType, interactionDescription, association, accessToken);
            //Assert.IsInstanceOf<VerveResponseInteraction> (response, "response is VerveResponseInteraction");
        }
        
        /// <summary>
        /// Test AddResponse
        /// </summary>
        [Test]
        public void AddResponseTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            long? interactionId = null;
            string requesterId = null;
            string clientToken = null;
            InteractionResponse body = null;
			
            string accessToken = null;
            var response = instance.AddResponse(interactionId, requesterId, clientToken, body, accessToken);
            Console.Write(response.ToString());
            Assert.IsInstanceOf<VerveResponseInteractionResponse> (response, "response is VerveResponseInteractionResponse");
        }

        /// <summary>
        /// Test AddResponse_0
        /// </summary>
        [Test]
        public void AddResponse_0Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? body = null;
            //string body2 = null;
            //string loggedInuserId = null;
            //string accessToken = null;
            //string clientToken = null;
            //string body3 = null;
            //List<Attachment> body4 = null;
            //var response = instance.AddResponse_0(body, body2, loggedInUserId, accessToken, clientToken, body3, body4);
            //Assert.IsInstanceOf<VerveResponseInteractionResponse> (response, "response is VerveResponseInteractionResponse");
        }
        
        /// <summary>
        /// Test ChangeInteractionCategory
        /// </summary>
        [Test]
        public void ChangeInteractionCategoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            long? interactionId = null;
            long? categoryId = null;;
            string requesterId = null;
            string clientToken = null;
            string fields = null;
            string accessToken = null;
            var response = instance.ChangeInteractionCategory(interactionId, categoryId, requesterId, clientToken, fields, accessToken);
            Console.Write(response.ToString());
            Assert.IsInstanceOf<VerveResponseInteraction> (response, "response is VerveResponseInteraction");
        }
        
        /// <summary>
        /// Test ChangeInteractionType
        /// </summary>
        [Test]
        public void ChangeInteractionTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            long? interactionId = null;
            string interactionType = null;
            string requesterId = null;
            string clientToken = null;
            string fields = null;
            string accessToken = null;
            var response = instance.ChangeInteractionType(interactionId, interactionType, requesterId, clientToken, fields, accessToken);
            Console.Write(response.ToString());
            Assert.IsInstanceOf<VerveResponseInteraction> (response, "response is VerveResponseInteraction");
        }
        
        /// <summary>
        /// Test CreateInteractionCategory
        /// </summary>
        [Test]
        public void CreateInteractionCategoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string requesterId = null;
            string clientToken = null;
            InteractionCategory body =  null;
            string accessToken = null;

            var response = instance.CreateInteractionCategory(requesterId, clientToken, body, accessToken);
            Console.Write(response.ToString());
            Assert.IsInstanceOf<VerveResponseInteractionCategory> (response, "response is VerveResponseInteractionCategory");
        }
        
        /// <summary>
        /// Test DeleteInteraction
        /// </summary>
        [Test]
        public void DeleteInteractionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            long? interactionId = null;
            string requesterId = null;
            string clientToken = null;
            string fields = null;
            string accessToken = null;
            var response = instance.DeleteInteraction(interactionId, requesterId, clientToken, fields, accessToken);
            Console.Write(response.ToString());
            Assert.IsInstanceOf<VerveResponseInteraction> (response, "response is VerveResponseInteraction");
        }
        
        /// <summary>
        /// Test DeleteInteractionCategory
        /// </summary>
        [Test]
        public void DeleteInteractionCategoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            long? categoryId = null;;
            string requesterId = null;
            string clientToken = null;
            string fields = null;
            string accessToken = null;
            var response = instance.DeleteInteractionCategory(categoryId, requesterId, clientToken, fields, accessToken);
            Console.Write(response.ToString());
            Assert.IsInstanceOf<VerveResponseInteractionCategory> (response, "response is VerveResponseInteractionCategory");
        }
        
        /// <summary>
        /// Test DeleteResponse
        /// </summary>
        [Test]
        public void DeleteResponseTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            long? responseId = null;
            string requesterId = null;
            string clientToken = null;
            string fields = null;
            string accessToken = null;

            var response = instance.DeleteResponse(responseId, requesterId, clientToken, fields, accessToken);
            Console.Write(response.ToString());
            Assert.IsInstanceOf<VerveResponseInteractionResponse> (response, "response is VerveResponseInteractionResponse");
        }
        
        /// <summary>
        /// Test DislikeResponse
        /// </summary>
        [Test]
        public void DislikeResponseTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            long? interactionId = null;
            long? responseId = null;
            string requesterId = null;
            string clientToken = null;
            string fields = null;
            string accessToken = null;
            var response = instance.DislikeResponse(interactionId, responseId, requesterId, clientToken, fields, accessToken);
            Console.Write(response.ToString());
            Assert.IsInstanceOf<VerveResponseInteractionResponse> (response, "response is VerveResponseInteractionResponse");
        }
        
        /// <summary>
        /// Test GetFriendsInteractions
        /// </summary>
        [Test]
        public void GetFriendsInteractionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string interactionStatus = null;
            int? start = 0;;
            int? end = 10;
            string requesterId = null;
            string clientToken = null;
            string interactionType = null;
            long? categoryId = null;
            string association = null;
            string fields = null;
            string accessToken = null;
            var response = instance.GetFriendsInteractions(interactionStatus, start, end, requesterId, clientToken, interactionType, categoryId, association, fields, accessToken);
            Console.Write(response.ToString());
            Assert.IsInstanceOf<VerveResponseInteractionList> (response, "response is VerveResponseInteractionList");
        }
        
        /// <summary>
        /// Test GetInteraction
        /// </summary>
        [Test]
        public void GetInteractionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            long? interactionId = null;
            string requesterId = null;
            string clientToken = null;
            string fields = null;
            string accessToken = null;
            var response = instance.GetInteraction(interactionId, requesterId, clientToken, fields, accessToken);
            Console.Write(response.ToString());
            Assert.IsInstanceOf<VerveResponseInteraction> (response, "response is VerveResponseInteraction");
        }
        
        /// <summary>
        /// Test GetInteractionCategories
        /// </summary>
        [Test]
        public void GetInteractionCategoriesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            int? start = 0;;
            int? end = 10;
            string requesterId = null;
            string clientToken = null;
            string interactionType = null;
            string association = null;
            string fields = null;
            string accessToken = null;

            var response = instance.GetInteractionCategories(start, end, requesterId, clientToken, interactionType, association, fields, accessToken);
            List<QuestionCategory> a = response.List;
            for(int i = 0; i < a.Count(); i++)
            {
                Console.Write(a.ElementAt(i));
            }
            Assert.IsInstanceOf<VerveResponseInteractionCategoryList> (response, "response is VerveResponseInteractionCategoryList");
        }
        
        /// <summary>
        /// Test GetInteractionsForUser
        /// </summary>
        [Test]
        public void GetInteractionsForUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string interactionStatus = null;
            int? start = 0;;
            int? end = 10;
            string requesterId = null;
            string clientToken = null;
            long? categoryId = null;
            string interactionType = null;
            string association = null;
            string fields = null;
            string accessToken = null;
            var response = instance.GetInteractionsForUser(interactionStatus, start, end, requesterId, clientToken, categoryId, interactionType, association, fields, accessToken);
            List<Interaction> list = response.List;
            for(int i = 0; i < list.Count(); i++)
            {
                Console.Write(list.ElementAt(i));
            }

            Assert.IsInstanceOf<VerveResponseInteractionList> (response, "response is VerveResponseInteractionList");
        }
        
        /// <summary>
        /// Test GetRecommendInteractions
        /// </summary>
        [Test]
        public void GetRecommendInteractionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            int? start = 0;;
            int? end = 10;
            string requesterId = null;
            string clientToken = null;
            string interactionType = null;
            string association = null;
            string fields = null;
            string accessToken = null;
            var response = instance.GetRecommendInteractions(start, end, requesterId, clientToken, interactionType, association, fields, accessToken);
            Assert.IsInstanceOf<VerveResponseInteractionList>(response, "response is VerveResponseInteractionList");
        }
        
        /// <summary>
        /// Test GetRecommendedInteractinsFromDB
        /// </summary>
        [Test]
        public void GetRecommendedInteractinsFromDBTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            long? userId = null;
            int? start = 0;;
            int? end = 10;
            string requesterId = null;
            string clientToken = null;
            string interactionType = null;
            string association = null;
            string fields = null;
            string accessToken = null;
            var response = instance.GetRecommendedInteractinsFromDB(userId, start, end, requesterId, clientToken, interactionType, association, fields, accessToken);
            Console.Write(response.ToString());
            Assert.IsInstanceOf<VerveResponseInteractionList> (response, "response is VerveResponseInteractionList");
        }

        /// <summary>
        /// Test GetRecommendedUsersFromDB
        /// </summary>
        [Test]
        public void GetRecommendedUsersFromDBTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            long? interactionId = null;
            int? start = 0;;
            int? end = 10;
            string requesterId = null;
            string clientToken = null;
            string association = null;
            string fields = null;
            string accessToken = null;
            var response = instance.GetRecommendedUsersFromDB(interactionId, start, end, requesterId, clientToken, association, fields, accessToken);

            Console.Write(response.ToString());
            Assert.IsInstanceOf<VerveResponseUserList> (response, "response is VerveResponseUserList");
        }
        
        /// <summary>
        /// Test GetResponses
        /// </summary>
        [Test]
        public void GetResponsesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            long? interactionId = null;
            int? start = 0;;
            int? end = 10;
            string requesterId = null;
            string clientToken = null;
            string fields = null;
            string accessToken = null;
            var response = instance.GetResponses(interactionId, start, end, requesterId, clientToken, fields, accessToken);
            Console.Write(response.ToString());
            Assert.IsInstanceOf<VerveResponseInteractionResponseList> (response, "response is VerveResponseInteractionResponseList");
        }
        
        /// <summary>
        /// Test GetUserInteractions
        /// </summary>
        [Test]
        public void GetUserInteractionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            long? userId = null;
            string interactionStatus = null;
            int? start = 0;;
            int? end = 10;
            string requesterId = null;
            string clientToken = null;
            long? categoryId = null;;
            string interactionType = null;
            string association = null;
            string fields = null;
            string accessToken = null;
            var response = instance.GetUserInteractions(userId, interactionStatus, start, end, requesterId, clientToken, categoryId, interactionType, association, fields, accessToken);
            Console.Write(response.ToString());
            Assert.IsInstanceOf<VerveResponseInteractionList> (response, "response is VerveResponseInteractionList");
        }

        /// <summary>
        /// Test GetUserSubscribedInteractionCategories
        /// </summary>
        [Test]
        public void GetUserSubscribedInteractionCategoriesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            long? userId = null;
            int? start = 0;;
            int? end = 10;
            string requesterId = null;
            string clientToken = null;
            string interactionType = null;
            string association = null;
            string fields = null;
            string accessToken = null;
            var response = instance.GetUserSubscribedInteractionCategories(userId, start, end, requesterId, clientToken, interactionType, association, fields, accessToken);
            Console.Write(response.ToString());
            Assert.IsInstanceOf<VerveResponseInteractionCategoryList> (response, "response is VerveResponseInteractionCategoryList");
        }
        
        /// <summary>
        /// Test GetUserSubscribedInteractions
        /// </summary>
        [Test]
        public void GetUserSubscribedInteractionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            long? userId = null;
            string interactionStatus = null;
            int? start = 0;;
            int? end = 10;
            string requesterId = null;
            string clientToken = null;
            long? categoryId = null;
            string interactionType = null;
            string association = null;
            string fields = null;
            string accessToken = null;
            var response = instance.GetUserSubscribedInteractions(userId, interactionStatus, start, end, requesterId, clientToken, categoryId, interactionType, association, fields, accessToken);
            Console.Write(response.ToString());
            Assert.IsInstanceOf<VerveResponseInteractionList> (response, "response is VerveResponseInteractionList");
        }
        
        /// <summary>
        /// Test LikeResponse
        /// </summary>
        [Test]
        public void LikeResponseTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            long? interactionId = null;
            long? responseId = null;
            string requesterId = null;
            string clientToken = null;
            string fields = null;
            string accessToken = null;
            var response = instance.LikeResponse(interactionId, responseId, requesterId, clientToken, fields, accessToken);
            Console.Write(response.ToString());
            Assert.IsInstanceOf<VerveResponseInteractionResponse> (response, "response is VerveResponseInteractionResponse");
        }
        
        /// <summary>
        /// Test MarkAsAnResponse
        /// </summary>
        [Test]
        public void MarkAsAnResponseTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            long? interactionId = null;
            long? responseId = null;
            string requesterId = null;
            string clientToken = null;
            string fields = null;
            string accessToken = null;
            var response = instance.MarkAsAnResponse(interactionId, responseId, requesterId, clientToken, fields, accessToken);
            Console.Write(response.ToString());
            Assert.IsInstanceOf<VerveResponseInteractionResponse> (response, "response is VerveResponseInteractionResponse");
        }
        
        /// <summary>
        /// Test SearchInteractions
        /// </summary>
        [Test]
        public void SearchInteractionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string searchText = null;
            string interactionStatus = null;
            int? start = 0;;
            int? end = 10;
            string requesterId = null;
            string clientToken = null;
            string interactionType = null;
            string association = null;
            string fields = null;
            string accessToken = null;
            var response = instance.SearchInteractions(searchText, interactionStatus, start, end, requesterId, clientToken, interactionType, association, fields, accessToken);
            Console.Write(response.ToString());
            Assert.IsInstanceOf<VerveResponseInteractionList> (response, "response is VerveResponseInteractionList");
        }
        
        /// <summary>
        /// Test SubscribeInteractinCategory
        /// </summary>
        [Test]
        public void SubscribeInteractinCategoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            long? categoryId = null;
            string requesterId = null;
            string clientToken = null;
            string fields = null;
            string accessToken = null;
            var response = instance.SubscribeInteractinCategory(categoryId, requesterId, clientToken, fields, accessToken);
            Console.Write(response.ToString());
            Assert.IsInstanceOf<VerveResponseInteractionCategory> (response, "response is VerveResponseInteractionCategory");
        }
        
        /// <summary>
        /// Test SubscribeInteraction
        /// </summary>
        [Test]
        public void SubscribeInteractionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            long? interactionId = null;
            string requesterId = null;
            string clientToken = null;
            string fields = null;
            string accessToken = null;
            var response = instance.SubscribeInteraction(interactionId, requesterId, clientToken, fields, accessToken);
            Console.Write(response.ToString());
            Assert.IsInstanceOf<VerveResponseInteraction> (response, "response is VerveResponseInteraction");
        }
        
        /// <summary>
        /// Test UnmarkAsAnResponse
        /// </summary>
        [Test]
        public void UnmarkAsAnResponseTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            long? interactionId = null;
            long? responseId = null;
            string requesterId = null;
            string clientToken = null;
            string fields = null;
            string accessToken = null;
            var response = instance.UnmarkAsAnResponse(interactionId, responseId, requesterId, clientToken, fields, accessToken);
            Console.Write(response.ToString());
            Assert.IsInstanceOf<VerveResponseInteractionResponse> (response, "response is VerveResponseInteractionResponse");
        }
        
        /// <summary>
        /// Test UnsubscribeInteractinCategory
        /// </summary>
        [Test]
        public void UnsubscribeInteractinCategoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            long? categoryId = null;;
            string requesterId = null;
            string clientToken = null;
            string fields = null;
            string accessToken = null;
            var response = instance.UnsubscribeInteractinCategory(categoryId, requesterId, clientToken, fields, accessToken);
            Console.Write(response.ToString());
            Assert.IsInstanceOf<VerveResponseInteractionCategory> (response, "response is VerveResponseInteractionCategory");
        }
        
        /// <summary>
        /// Test UnsubscribeInteraction
        /// </summary>
        [Test]
        public void UnsubscribeInteractionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            long? interactionId = null;
            string requesterId = null;
            string clientToken = null;
            string fields = null;
            string accessToken = null;
            var response = instance.UnsubscribeInteraction(interactionId, requesterId, clientToken, fields, accessToken);
            Console.Write(response.ToString());
            Assert.IsInstanceOf<VerveResponseInteraction> (response, "response is VerveResponseInteraction");
        }
        
        /// <summary>
        /// Test UpdateInteraction
        /// </summary>
        [Test]
        public void UpdateInteractionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            long? interactionId = null;
            string interactionTitle = "New Dotnet Interaction";
            string requesterId = null;
            string clientToken = null;
            string interactionDescription = "Interaction description is new";
            string fields = null;
            string accessToken = null;
            var response = instance.UpdateInteraction(interactionId, interactionTitle, requesterId, clientToken, interactionDescription, fields, accessToken);

            Console.Write(response.ToString());
            Assert.IsInstanceOf<VerveResponseInteraction> (response, "response is VerveResponseInteraction");
        }

        /// <summary>
        /// Test UpdateInteractionCategory
        /// </summary>
        [Test]
        public void UpdateInteractionCategoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            long? categoryId = null;;
            string categoryName = null;
            string requesterId = null;
            string clientToken = null;
            string categoryDescription = null;
            string fields = null;
            string accessToken = null;
            var response = instance.UpdateInteractionCategory(categoryId, categoryName, requesterId, clientToken, categoryDescription, fields, accessToken);
            Assert.IsInstanceOf<VerveResponseInteractionCategory> (response, "response is VerveResponseInteractionCategory");
        }
        
        /// <summary>
        /// Test UpdateResponse
        /// </summary>
        [Test]
        public void UpdateResponseTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            long? responseId = null;
            string response = "New Interaction Response Description 1";
            string requesterId = null;
            string clientToken = null;
            string fields = null;
            string accessToken = null;
            var resp = instance.UpdateResponse(responseId, response, requesterId, clientToken, fields, accessToken);
            Console.Write(resp.ToString());
            Assert.IsInstanceOf<VerveResponseInteractionResponse> (resp, "response is VerveResponseInteractionResponse");
        }

    }

}
