# IO.IEngage.Api.ProjectManagementApi

All URIs are relative to *https://api.iengage.io:8243/api/1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddMilestoneComment**](ProjectManagementApi.md#addmilestonecomment) | **POST** /milestones/{milestoneId}/comments | Comment on milestone
[**AddTaskComment**](ProjectManagementApi.md#addtaskcomment) | **POST** /milestones/tasks/{taskId}/comments | Comment on task
[**CreateMilestone**](ProjectManagementApi.md#createmilestone) | **POST** /milestones | Create milestone
[**CreateTask**](ProjectManagementApi.md#createtask) | **POST** /milestones/{milestoneId}/tasks | Create task
[**DeleteMilestone**](ProjectManagementApi.md#deletemilestone) | **DELETE** /milestones/{milestoneId} | Delete milestone
[**DeleteTask**](ProjectManagementApi.md#deletetask) | **DELETE** /milestones/tasks/{taskId} | Delete task
[**GetMilestones**](ProjectManagementApi.md#getmilestones) | **GET** /milestones | Get list of milestones
[**GetMilestonesComments**](ProjectManagementApi.md#getmilestonescomments) | **GET** /milestones/{milestoneId}/comments | Get list of comments written on Milestones
[**GetTaskComments**](ProjectManagementApi.md#gettaskcomments) | **GET** /milestones/tasks/{taskId}/comments | Get list of Comments written on task
[**GetUserTasks**](ProjectManagementApi.md#getusertasks) | **GET** /milestones/tasks/{userId}/assigned | Get list of task assigned to user
[**UpdateMilestone**](ProjectManagementApi.md#updatemilestone) | **PUT** /milestones/{milestoneId} | Update milestone
[**UpdateTask**](ProjectManagementApi.md#updatetask) | **PUT** /milestones/tasks/{taskId} | Update task
[**UpdateTaskStatus**](ProjectManagementApi.md#updatetaskstatus) | **PUT** /milestones/tasks/{taskId}/status | Update task status


<a name="addmilestonecomment"></a>
# **AddMilestoneComment**
> VerveResponseComment AddMilestoneComment (long? milestoneId, string commentText, string loggedInUserId, string accessToken, string clientToken)

Comment on milestone

Allows the user to comment on milestone. Returns the comments

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class AddMilestoneCommentExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProjectManagementApi();
            var milestoneId = 789;  // long? | milestoneId
            var commentText = commentText_example;  // string | commentText
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs

            try
            {
                // Comment on milestone
                VerveResponseComment result = apiInstance.AddMilestoneComment(milestoneId, commentText, loggedInUserId, accessToken, clientToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectManagementApi.AddMilestoneComment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **milestoneId** | **long?**| milestoneId | 
 **commentText** | **string**| commentText | 
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 

### Return type

[**VerveResponseComment**](VerveResponseComment.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addtaskcomment"></a>
# **AddTaskComment**
> VerveResponseComment AddTaskComment (long? taskId, string commentText, string loggedInUserId, string accessToken, string clientToken)

Comment on task

Allows  the user to comment on task. Returns the task comment

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class AddTaskCommentExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProjectManagementApi();
            var taskId = 789;  // long? | taskId
            var commentText = commentText_example;  // string | commentText
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs

            try
            {
                // Comment on task
                VerveResponseComment result = apiInstance.AddTaskComment(taskId, commentText, loggedInUserId, accessToken, clientToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectManagementApi.AddTaskComment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskId** | **long?**| taskId | 
 **commentText** | **string**| commentText | 
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 

### Return type

[**VerveResponseComment**](VerveResponseComment.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createmilestone"></a>
# **CreateMilestone**
> VerveResponseMilestone CreateMilestone (string title, string description, string dueDate, bool? neverDue, string loggedInUserId, string accessToken, string clientToken, long? organizationId = null, string fields = null)

Create milestone

Allows the user to create milestone. Returns the created milestone

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class CreateMilestoneExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProjectManagementApi();
            var title = title_example;  // string | title
            var description = description_example;  // string | description
            var dueDate = dueDate_example;  // string | Due date(Format: MM-dd-yyyy HH:mm:ss a)
            var neverDue = true;  // bool? | neverDue. If neverDue is true, it takes higher priority than dueDate
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var organizationId = 789;  // long? | organizationId (optional) 
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)milestoneId<br/>2)milestoneTitle<br/>3)milestoneDescription<br/>4)createdDate<br/><b>A) Available values-</b><br/>1)milestoneId<br/>2)milestoneTitle<br/>3)milestoneDescription<br/>4)createdDate<br/>5)status<br/>6)priority<br/>7)dueDate (optional)  (default to milestoneId,milestoneTitle,milestoneDescription,createdDate)

            try
            {
                // Create milestone
                VerveResponseMilestone result = apiInstance.CreateMilestone(title, description, dueDate, neverDue, loggedInUserId, accessToken, clientToken, organizationId, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectManagementApi.CreateMilestone: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **title** | **string**| title | 
 **description** | **string**| description | 
 **dueDate** | **string**| Due date(Format: MM-dd-yyyy HH:mm:ss a) | 
 **neverDue** | **bool?**| neverDue. If neverDue is true, it takes higher priority than dueDate | 
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **organizationId** | **long?**| organizationId | [optional] 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)milestoneId&lt;br/&gt;2)milestoneTitle&lt;br/&gt;3)milestoneDescription&lt;br/&gt;4)createdDate&lt;br/&gt;&lt;b&gt;A) Available values-&lt;/b&gt;&lt;br/&gt;1)milestoneId&lt;br/&gt;2)milestoneTitle&lt;br/&gt;3)milestoneDescription&lt;br/&gt;4)createdDate&lt;br/&gt;5)status&lt;br/&gt;6)priority&lt;br/&gt;7)dueDate | [optional] [default to milestoneId,milestoneTitle,milestoneDescription,createdDate]

### Return type

[**VerveResponseMilestone**](VerveResponseMilestone.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createtask"></a>
# **CreateTask**
> VerveResponseTask CreateTask (string title, string description, int? priority, long? assigneeUserId, string dueDate, bool? neverDue, long? milestoneId, string loggedInUserId, string accessToken, string clientToken, string fields = null)

Create task

Allows user to create task. Returns the created task

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class CreateTaskExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProjectManagementApi();
            var title = title_example;  // string | title
            var description = description_example;  // string | description
            var priority = 56;  // int? | Task priority <br/> 1 - HIGH <br/> 2 - LOW <br/> 3 - NORMAL
            var assigneeUserId = 789;  // long? | assignee User Id
            var dueDate = dueDate_example;  // string | Due date (Format: MM-dd-yyyy HH:mm:ss a)
            var neverDue = true;  // bool? | neverDue. If neverDue is true, it takes higher priority than dueDate
            var milestoneId = 789;  // long? | Milestone Id
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)taskId<br/>2)taskTitle<br/>3)taskDescription<br/>4)dueDate<br/><b>A) Available values-</b><br/>1)taskId<br/>2)taskTitle<br/>3)taskDescription<br/>4)status<br/>5)priority<br/>6)dueDate<br/>7)milestoneName<br/>8)groupType<br/>9)groupName (optional)  (default to taskId,taskTitle,taskDescription,dueDate)

            try
            {
                // Create task
                VerveResponseTask result = apiInstance.CreateTask(title, description, priority, assigneeUserId, dueDate, neverDue, milestoneId, loggedInUserId, accessToken, clientToken, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectManagementApi.CreateTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **title** | **string**| title | 
 **description** | **string**| description | 
 **priority** | **int?**| Task priority &lt;br/&gt; 1 - HIGH &lt;br/&gt; 2 - LOW &lt;br/&gt; 3 - NORMAL | 
 **assigneeUserId** | **long?**| assignee User Id | 
 **dueDate** | **string**| Due date (Format: MM-dd-yyyy HH:mm:ss a) | 
 **neverDue** | **bool?**| neverDue. If neverDue is true, it takes higher priority than dueDate | 
 **milestoneId** | **long?**| Milestone Id | 
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)taskId&lt;br/&gt;2)taskTitle&lt;br/&gt;3)taskDescription&lt;br/&gt;4)dueDate&lt;br/&gt;&lt;b&gt;A) Available values-&lt;/b&gt;&lt;br/&gt;1)taskId&lt;br/&gt;2)taskTitle&lt;br/&gt;3)taskDescription&lt;br/&gt;4)status&lt;br/&gt;5)priority&lt;br/&gt;6)dueDate&lt;br/&gt;7)milestoneName&lt;br/&gt;8)groupType&lt;br/&gt;9)groupName | [optional] [default to taskId,taskTitle,taskDescription,dueDate]

### Return type

[**VerveResponseTask**](VerveResponseTask.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletemilestone"></a>
# **DeleteMilestone**
> VerveResponseMilestone DeleteMilestone (long? milestoneId, string loggedInUserId, string accessToken, string clientToken, string fields = null)

Delete milestone

Allows the user to delete milestone. Returns the deleted milestone

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class DeleteMilestoneExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProjectManagementApi();
            var milestoneId = 789;  // long? | milestoneId
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)milestoneId<br/>2)milestoneTitle<br/>3)milestoneDescription<br/>4)createdDate<br/><b>A) Available values-</b><br/>1)milestoneId<br/>2)milestoneTitle<br/>3)milestoneDescription<br/>4)createdDate<br/>5)status<br/>6)priority<br/>7)dueDate (optional)  (default to milestoneId,milestoneTitle,milestoneDescription,createdDate)

            try
            {
                // Delete milestone
                VerveResponseMilestone result = apiInstance.DeleteMilestone(milestoneId, loggedInUserId, accessToken, clientToken, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectManagementApi.DeleteMilestone: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **milestoneId** | **long?**| milestoneId | 
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)milestoneId&lt;br/&gt;2)milestoneTitle&lt;br/&gt;3)milestoneDescription&lt;br/&gt;4)createdDate&lt;br/&gt;&lt;b&gt;A) Available values-&lt;/b&gt;&lt;br/&gt;1)milestoneId&lt;br/&gt;2)milestoneTitle&lt;br/&gt;3)milestoneDescription&lt;br/&gt;4)createdDate&lt;br/&gt;5)status&lt;br/&gt;6)priority&lt;br/&gt;7)dueDate | [optional] [default to milestoneId,milestoneTitle,milestoneDescription,createdDate]

### Return type

[**VerveResponseMilestone**](VerveResponseMilestone.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetask"></a>
# **DeleteTask**
> VerveResponseTask DeleteTask (long? taskId, string loggedInUserId, string accessToken, string clientToken, string fields = null)

Delete task

Allows the user to delete task. Returns the deleted task

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class DeleteTaskExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProjectManagementApi();
            var taskId = 789;  // long? | taskId
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)taskId<br/>2)taskTitle<br/>3)taskDescription<br/>4)dueDate<br/><b>A) Available values-</b><br/>1)taskId<br/>2)taskTitle<br/>3)taskDescription<br/>4)status<br/>5)priority<br/>6)dueDate<br/>7)milestoneName<br/>8)groupType<br/>9)groupName (optional)  (default to taskId,taskTitle,taskDescription,dueDate)

            try
            {
                // Delete task
                VerveResponseTask result = apiInstance.DeleteTask(taskId, loggedInUserId, accessToken, clientToken, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectManagementApi.DeleteTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskId** | **long?**| taskId | 
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)taskId&lt;br/&gt;2)taskTitle&lt;br/&gt;3)taskDescription&lt;br/&gt;4)dueDate&lt;br/&gt;&lt;b&gt;A) Available values-&lt;/b&gt;&lt;br/&gt;1)taskId&lt;br/&gt;2)taskTitle&lt;br/&gt;3)taskDescription&lt;br/&gt;4)status&lt;br/&gt;5)priority&lt;br/&gt;6)dueDate&lt;br/&gt;7)milestoneName&lt;br/&gt;8)groupType&lt;br/&gt;9)groupName | [optional] [default to taskId,taskTitle,taskDescription,dueDate]

### Return type

[**VerveResponseTask**](VerveResponseTask.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmilestones"></a>
# **GetMilestones**
> VerveResponseMilestoneList GetMilestones (string loggedInUserId, string accessToken, string clientToken, long? organizationId = null, string fields = null)

Get list of milestones

Returns the list of milestones

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetMilestonesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProjectManagementApi();
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var organizationId = 789;  // long? | organizationId (optional) 
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)milestoneId<br/>2)milestoneTitle<br/>3)milestoneDescription<br/>4)createdDate<br/><b>A) Available values-</b><br/>1)milestoneId<br/>2)milestoneTitle<br/>3)milestoneDescription<br/>4)createdDate<br/>5)status<br/>6)priority<br/>7)dueDate (optional)  (default to milestoneId,milestoneTitle,milestoneDescription,createdDate)

            try
            {
                // Get list of milestones
                VerveResponseMilestoneList result = apiInstance.GetMilestones(loggedInUserId, accessToken, clientToken, organizationId, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectManagementApi.GetMilestones: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **organizationId** | **long?**| organizationId | [optional] 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)milestoneId&lt;br/&gt;2)milestoneTitle&lt;br/&gt;3)milestoneDescription&lt;br/&gt;4)createdDate&lt;br/&gt;&lt;b&gt;A) Available values-&lt;/b&gt;&lt;br/&gt;1)milestoneId&lt;br/&gt;2)milestoneTitle&lt;br/&gt;3)milestoneDescription&lt;br/&gt;4)createdDate&lt;br/&gt;5)status&lt;br/&gt;6)priority&lt;br/&gt;7)dueDate | [optional] [default to milestoneId,milestoneTitle,milestoneDescription,createdDate]

### Return type

[**VerveResponseMilestoneList**](VerveResponseMilestoneList.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmilestonescomments"></a>
# **GetMilestonesComments**
> VerveResponseCommentList GetMilestonesComments (long? milestoneId, string loggedInUserId, string accessToken, string clientToken)

Get list of comments written on Milestones

Returns the list comments written on milestone

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetMilestonesCommentsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProjectManagementApi();
            var milestoneId = 789;  // long? | milestoneId
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs

            try
            {
                // Get list of comments written on Milestones
                VerveResponseCommentList result = apiInstance.GetMilestonesComments(milestoneId, loggedInUserId, accessToken, clientToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectManagementApi.GetMilestonesComments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **milestoneId** | **long?**| milestoneId | 
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 

### Return type

[**VerveResponseCommentList**](VerveResponseCommentList.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettaskcomments"></a>
# **GetTaskComments**
> VerveResponseCommentList GetTaskComments (long? taskId, string loggedInUserId, string accessToken, string clientToken)

Get list of Comments written on task

Returns the list of comments written on task

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetTaskCommentsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProjectManagementApi();
            var taskId = 789;  // long? | taskId
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs

            try
            {
                // Get list of Comments written on task
                VerveResponseCommentList result = apiInstance.GetTaskComments(taskId, loggedInUserId, accessToken, clientToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectManagementApi.GetTaskComments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskId** | **long?**| taskId | 
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 

### Return type

[**VerveResponseCommentList**](VerveResponseCommentList.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusertasks"></a>
# **GetUserTasks**
> VerveResponseTaskList GetUserTasks (long? userId, int? status, string loggedInUserId, string accessToken, string clientToken, string fields = null)

Get list of task assigned to user

Returns the list of task assigned to user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetUserTasksExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProjectManagementApi();
            var userId = 789;  // long? | userId
            var status = 56;  // int? | Task status <br/> 0 - ALL <br/> 1 - OPEN <br/> 2 - PERCENT_TWENTY <br/> 3 - PERCENT_FORTY <br/> 4 - PERCENT_SIXTY <br/> 5 - PERCENT_EIGHTY <br/> 6 - RESOLVED <br/> 7 - REOPENED
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)taskId<br/>2)taskTitle<br/>3)taskDescription<br/>4)dueDate<br/><b>A) Available values-</b><br/>1)taskId<br/>2)taskTitle<br/>3)taskDescription<br/>4)status<br/>5)priority<br/>6)dueDate<br/>7)milestoneName<br/>8)groupType<br/>9)groupName (optional)  (default to taskId,taskTitle,taskDescription,dueDate)

            try
            {
                // Get list of task assigned to user
                VerveResponseTaskList result = apiInstance.GetUserTasks(userId, status, loggedInUserId, accessToken, clientToken, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectManagementApi.GetUserTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **long?**| userId | 
 **status** | **int?**| Task status &lt;br/&gt; 0 - ALL &lt;br/&gt; 1 - OPEN &lt;br/&gt; 2 - PERCENT_TWENTY &lt;br/&gt; 3 - PERCENT_FORTY &lt;br/&gt; 4 - PERCENT_SIXTY &lt;br/&gt; 5 - PERCENT_EIGHTY &lt;br/&gt; 6 - RESOLVED &lt;br/&gt; 7 - REOPENED | 
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)taskId&lt;br/&gt;2)taskTitle&lt;br/&gt;3)taskDescription&lt;br/&gt;4)dueDate&lt;br/&gt;&lt;b&gt;A) Available values-&lt;/b&gt;&lt;br/&gt;1)taskId&lt;br/&gt;2)taskTitle&lt;br/&gt;3)taskDescription&lt;br/&gt;4)status&lt;br/&gt;5)priority&lt;br/&gt;6)dueDate&lt;br/&gt;7)milestoneName&lt;br/&gt;8)groupType&lt;br/&gt;9)groupName | [optional] [default to taskId,taskTitle,taskDescription,dueDate]

### Return type

[**VerveResponseTaskList**](VerveResponseTaskList.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemilestone"></a>
# **UpdateMilestone**
> VerveResponseMilestone UpdateMilestone (long? milestoneId, string title, string description, string dueDate, string loggedInUserId, string accessToken, string clientToken, string fields = null)

Update milestone

Allows the user to update milestone. Returns the updated milestone

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class UpdateMilestoneExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProjectManagementApi();
            var milestoneId = 789;  // long? | milestoneId
            var title = title_example;  // string | title
            var description = description_example;  // string | description
            var dueDate = dueDate_example;  // string | Due date (Format: MM-dd-yyyy HH:mm:ss a)
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)milestoneId<br/>2)milestoneTitle<br/>3)milestoneDescription<br/>4)createdDate<br/><b>A) Available values-</b><br/>1)milestoneId<br/>2)milestoneTitle<br/>3)milestoneDescription<br/>4)createdDate<br/>5)status<br/>6)priority<br/>7)dueDate (optional)  (default to milestoneId,milestoneTitle,milestoneDescription,createdDate)

            try
            {
                // Update milestone
                VerveResponseMilestone result = apiInstance.UpdateMilestone(milestoneId, title, description, dueDate, loggedInUserId, accessToken, clientToken, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectManagementApi.UpdateMilestone: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **milestoneId** | **long?**| milestoneId | 
 **title** | **string**| title | 
 **description** | **string**| description | 
 **dueDate** | **string**| Due date (Format: MM-dd-yyyy HH:mm:ss a) | 
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)milestoneId&lt;br/&gt;2)milestoneTitle&lt;br/&gt;3)milestoneDescription&lt;br/&gt;4)createdDate&lt;br/&gt;&lt;b&gt;A) Available values-&lt;/b&gt;&lt;br/&gt;1)milestoneId&lt;br/&gt;2)milestoneTitle&lt;br/&gt;3)milestoneDescription&lt;br/&gt;4)createdDate&lt;br/&gt;5)status&lt;br/&gt;6)priority&lt;br/&gt;7)dueDate | [optional] [default to milestoneId,milestoneTitle,milestoneDescription,createdDate]

### Return type

[**VerveResponseMilestone**](VerveResponseMilestone.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetask"></a>
# **UpdateTask**
> VerveResponseTask UpdateTask (long? taskId, string title, string description, string dueDate, int? status, long? reAssigneeUserId, string loggedInUserId, string accessToken, string clientToken, string fields = null)

Update task

Allows the user to update task. Returns the updated task

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class UpdateTaskExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProjectManagementApi();
            var taskId = 789;  // long? | taskId
            var title = title_example;  // string | title
            var description = description_example;  // string | description
            var dueDate = dueDate_example;  // string | Due date
            var status = 56;  // int? | Task status <br/> 1 - OPEN <br/> 2 - PERCENT_TWENTY <br/> 3 - PERCENT_FORTY <br/> 4 - PERCENT_SIXTY <br/> 5 - PERCENT_EIGHTY <br/> 6 - RESOLVED <br/> 7 - REOPENED
            var reAssigneeUserId = 789;  // long? | re-assignee User Id
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)taskId<br/>2)taskTitle<br/>3)taskDescription<br/>4)dueDate<br/><b>A) Available values-</b><br/>1)taskId<br/>2)taskTitle<br/>3)taskDescription<br/>4)status<br/>5)priority<br/>6)dueDate<br/>7)milestoneName<br/>8)groupType<br/>9)groupName (optional)  (default to taskId,taskTitle,taskDescription,dueDate)

            try
            {
                // Update task
                VerveResponseTask result = apiInstance.UpdateTask(taskId, title, description, dueDate, status, reAssigneeUserId, loggedInUserId, accessToken, clientToken, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectManagementApi.UpdateTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskId** | **long?**| taskId | 
 **title** | **string**| title | 
 **description** | **string**| description | 
 **dueDate** | **string**| Due date | 
 **status** | **int?**| Task status &lt;br/&gt; 1 - OPEN &lt;br/&gt; 2 - PERCENT_TWENTY &lt;br/&gt; 3 - PERCENT_FORTY &lt;br/&gt; 4 - PERCENT_SIXTY &lt;br/&gt; 5 - PERCENT_EIGHTY &lt;br/&gt; 6 - RESOLVED &lt;br/&gt; 7 - REOPENED | 
 **reAssigneeUserId** | **long?**| re-assignee User Id | 
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)taskId&lt;br/&gt;2)taskTitle&lt;br/&gt;3)taskDescription&lt;br/&gt;4)dueDate&lt;br/&gt;&lt;b&gt;A) Available values-&lt;/b&gt;&lt;br/&gt;1)taskId&lt;br/&gt;2)taskTitle&lt;br/&gt;3)taskDescription&lt;br/&gt;4)status&lt;br/&gt;5)priority&lt;br/&gt;6)dueDate&lt;br/&gt;7)milestoneName&lt;br/&gt;8)groupType&lt;br/&gt;9)groupName | [optional] [default to taskId,taskTitle,taskDescription,dueDate]

### Return type

[**VerveResponseTask**](VerveResponseTask.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetaskstatus"></a>
# **UpdateTaskStatus**
> VerveResponseTask UpdateTaskStatus (long? taskId, int? status, string loggedInUserId, string accessToken, string clientToken, string fields = null)

Update task status

Allows the user to update task status. Returns the updated task status

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class UpdateTaskStatusExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProjectManagementApi();
            var taskId = 789;  // long? | taskId
            var status = 56;  // int? | Task status <br/> 1 - OPEN <br/> 2 - PERCENT_TWENTY <br/> 3 - PERCENT_FORTY <br/> 4 - PERCENT_SIXTY <br/> 5 - PERCENT_EIGHTY <br/> 6 - RESOLVED <br/> 7 - REOPENED
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)taskId<br/>2)taskTitle<br/>3)taskDescription<br/>4)dueDate<br/><b>A) Available values-</b><br/>1)taskId<br/>2)taskTitle<br/>3)taskDescription<br/>4)status<br/>5)priority<br/>6)dueDate<br/>7)milestoneName<br/>8)groupType<br/>9)groupName (optional)  (default to taskId,taskTitle,taskDescription,dueDate)

            try
            {
                // Update task status
                VerveResponseTask result = apiInstance.UpdateTaskStatus(taskId, status, loggedInUserId, accessToken, clientToken, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectManagementApi.UpdateTaskStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskId** | **long?**| taskId | 
 **status** | **int?**| Task status &lt;br/&gt; 1 - OPEN &lt;br/&gt; 2 - PERCENT_TWENTY &lt;br/&gt; 3 - PERCENT_FORTY &lt;br/&gt; 4 - PERCENT_SIXTY &lt;br/&gt; 5 - PERCENT_EIGHTY &lt;br/&gt; 6 - RESOLVED &lt;br/&gt; 7 - REOPENED | 
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)taskId&lt;br/&gt;2)taskTitle&lt;br/&gt;3)taskDescription&lt;br/&gt;4)dueDate&lt;br/&gt;&lt;b&gt;A) Available values-&lt;/b&gt;&lt;br/&gt;1)taskId&lt;br/&gt;2)taskTitle&lt;br/&gt;3)taskDescription&lt;br/&gt;4)status&lt;br/&gt;5)priority&lt;br/&gt;6)dueDate&lt;br/&gt;7)milestoneName&lt;br/&gt;8)groupType&lt;br/&gt;9)groupName | [optional] [default to taskId,taskTitle,taskDescription,dueDate]

### Return type

[**VerveResponseTask**](VerveResponseTask.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

