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
    ///  Class for testing ProjectManagementApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ProjectManagementApiTests
    {
        private ProjectManagementApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            Configuration.Default.AccessToken = null;
            instance = new ProjectManagementApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ProjectManagementApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ProjectManagementApi
            //Assert.IsInstanceOfType(typeof(ProjectManagementApi), instance, "instance is a ProjectManagementApi");
        }

        
        /// <summary>
        /// Test AddMilestoneComment
        /// </summary>
        [Test]
        public void AddMilestoneCommentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            long? milestoneId = null;
            string requesterId = null;
            string clientToken = null;
            Comment body = null;
            
            string accessToken = null;
            var response = instance.AddMilestoneComment(milestoneId, requesterId, clientToken, body, accessToken);
            Console.Write(response.ToString());
            Assert.IsInstanceOf<VerveResponseComment> (response, "response is VerveResponseComment");
        }
        
        /// <summary>
        /// Test AddTaskComment
        /// </summary>
        [Test]
        public void AddTaskCommentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            long? taskId = null;
            string requesterId = null;
            string clientToken = null;
            Comment body = null;
            
            string accessToken = null;
            var response = instance.AddTaskComment(taskId, requesterId, clientToken, body, accessToken);
            Console.Write(response.ToString());
            Assert.IsInstanceOf<VerveResponseComment> (response, "response is VerveResponseComment");
        }
        
        /// <summary>
        /// Test CreateMilestone
        /// </summary>
        [Test]
        public void CreateMilestoneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string requesterId = null;
            string clientToken = null;
            Milestone body = null;
            
            string accessToken = null;
            var response = instance.CreateMilestone(requesterId, clientToken, body, accessToken);
            Console.Write(response.ToString());
            Assert.IsInstanceOf<VerveResponseMilestone> (response, "response is VerveResponseMilestone");
        }
        
        /// <summary>
        /// Test CreateTask
        /// </summary>
        [Test]
        public void CreateTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            long? milestoneId = null;
            string requesterId = null;
            string clientToken = null;
            Task body = null;
            string accessToken = null;
            
			var response = instance.CreateTask(milestoneId, requesterId, clientToken, body, accessToken);
            Console.Write(response.ToString());
            Assert.IsInstanceOf<VerveResponseTask> (response, "response is VerveResponseTask");
        }

        /// <summary>
        /// Test DeleteMilestone
        /// </summary>
        [Test]
        public void DeleteMilestoneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            long? milestoneId = null;
            string requesterId = null;
            string clientToken = null;
            string fields = null;
            string accessToken = null;
            var response = instance.DeleteMilestone(milestoneId, requesterId, clientToken, fields, accessToken);
            Console.Write(response.ToString());
            Assert.IsInstanceOf<VerveResponseMilestone> (response, "response is VerveResponseMilestone");
        }
        
        /// <summary>
        /// Test DeleteTask
        /// </summary>
        [Test]
        public void DeleteTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            long? taskId = null;
            string requesterId = null;
            string clientToken = null;
            string fields = null;
            string accessToken = null;
            var response = instance.DeleteTask(taskId, requesterId, clientToken, fields, accessToken);
            Console.Write(response.ToString());
            Assert.IsInstanceOf<VerveResponseTask> (response, "response is VerveResponseTask");
        }
        
        /// <summary>
        /// Test GetMilestones
        /// </summary>
        [Test]
        public void GetMilestonesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string requesterId = null;
            string clientToken = null;
            long? organizationId = null;
            string fields = null;
            string accessToken = null;
            var response = instance.GetMilestones(requesterId, clientToken, organizationId, fields, accessToken);
            List<Milestone> list = response.List;
            for(int i = 0; i < list.Count(); i++)
            {
                Console.Write(list.ElementAt(i));
            }
            Console.Write(response.ToString());
            Assert.IsInstanceOf<VerveResponseMilestoneList> (response, "response is VerveResponseMilestoneList");
        }
        
        /// <summary>
        /// Test GetMilestonesComments
        /// </summary>
        [Test]
        public void GetMilestonesCommentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            long? milestoneId = null;
            string requesterId = null;
            string clientToken = null;
            string accessToken = null;
            var response = instance.GetMilestonesComments(milestoneId, requesterId, clientToken, accessToken);
            Console.Write(response.ToString());
            Assert.IsInstanceOf<VerveResponseCommentList> (response, "response is VerveResponseCommentList");
        }
        
        /// <summary>
        /// Test GetTaskComments
        /// </summary>
        [Test]
        public void GetTaskCommentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            long? taskId = null;
            string requesterId = null;
            string clientToken = null;
            string accessToken = null;
            var response = instance.GetTaskComments(taskId, requesterId, clientToken, accessToken);
            Console.Write(response.ToString());
            Assert.IsInstanceOf<VerveResponseCommentList> (response, "response is VerveResponseCommentList");
        }
        
        /// <summary>
        /// Test GetUserTasks
        /// </summary>
        [Test]
        public void GetUserTasksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            long? userId = null;
            int? status = null;
            string requesterId = null;
            string clientToken = null;
            string fields = null;
            string accessToken = null;
            var response = instance.GetUserTasks(userId, status, requesterId, clientToken, fields, accessToken);
            Console.Write(response.ToString());
            Assert.IsInstanceOf<VerveResponseTaskList> (response, "response is VerveResponseTaskList");
        }
        
        /// <summary>
        /// Test UpdateMilestone
        /// </summary>
        [Test]
        public void UpdateMilestoneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            long? milestoneId = null;
            string title = null;
            string description = null;
            
            string dueDate = null;
            string requesterId = null;
            string clientToken = null;
            string fields = null;
            string accessToken = null;
            var response = instance.UpdateMilestone(milestoneId, title, description, dueDate, requesterId, clientToken, fields, accessToken);
            Console.Write(response.ToString());
            Assert.IsInstanceOf<VerveResponseMilestone> (response, "response is VerveResponseMilestone");
        }
        
        /// <summary>
        /// Test UpdateTask
        /// </summary>
        [Test]
        public void UpdateTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            long? taskId = null;
            string title = null;
            string description = null;
            string dueDate = null;
            int? status = null;
            long? reAssigneeUserId = null;
            string requesterId = null;
            string clientToken = null;
            string fields = null;
            string accessToken = null;
            var response = instance.UpdateTask(taskId, title, description, dueDate, status, reAssigneeUserId, requesterId, clientToken, fields, accessToken);
            Console.Write(response.ToString());
            Assert.IsInstanceOf<VerveResponseTask> (response, "response is VerveResponseTask");
        }
        
        /// <summary>
        /// Test UpdateTaskStatus
        /// </summary>
        [Test]
        public void UpdateTaskStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            long? taskId = null;
            int? status = null;
            string requesterId = null;
            string clientToken = null;
            string fields = null;
            string accessToken = null;
            var response = instance.UpdateTaskStatus(taskId, status, requesterId, clientToken, fields, accessToken);
            Console.Write(response.ToString());
            Assert.IsInstanceOf<VerveResponseTask> (response, "response is VerveResponseTask");
        }
        
    }

}
