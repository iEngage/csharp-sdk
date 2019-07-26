# IO.IEngage.Api.ProjectManagementApi

All URIs are relative to *https://api.iengage.io:8243/api/2.0*

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
> VerveResponseComment AddMilestoneComment (long? milestoneId, string requesterId, string clientToken, Comment body = null, string accessToken = null)

Comment on milestone

This service allows a user to comment on a milestone. The following fields(key:value) are required to be present in the Comment JSON object. Refer to the Model & Model Schema of the expected JSON Object for the body of this API.  **Required fields**  1. milestoneId (Path Parameter) 2. commentText  

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
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var body = new Comment(); // Comment |  (optional) 
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Comment on milestone
                VerveResponseComment result = apiInstance.AddMilestoneComment(milestoneId, requesterId, clientToken, body, accessToken);
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
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **body** | [**Comment**](Comment.md)|  | [optional] 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseComment**](VerveResponseComment.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addtaskcomment"></a>
# **AddTaskComment**
> VerveResponseComment AddTaskComment (long? taskId, string requesterId, string clientToken, Comment body = null, string accessToken = null)

Comment on task

This service allows a user to comment on a task. The following fields(key:value) are required to be present in the Comment JSON object. Refer to the Model & Model Schema of the expected JSON Object for the body of this API.  **Required fields**  1. **taskId (Path Parameter)**  2. **commentText**  

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
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var body = new Comment(); // Comment |  (optional) 
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Comment on task
                VerveResponseComment result = apiInstance.AddTaskComment(taskId, requesterId, clientToken, body, accessToken);
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
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **body** | [**Comment**](Comment.md)|  | [optional] 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseComment**](VerveResponseComment.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createmilestone"></a>
# **CreateMilestone**
> VerveResponseMilestone CreateMilestone (string requesterId, string clientToken, Milestone body = null, string accessToken = null)

Create milestone

This service allows a user to create a milestone. The following fields(key:value) are required to be present in the Milestone JSON object. Refer to the Model & Model Schema of the expected JSON Object for the body of this API.  **Required fields**  1. **milestoneTitle**  2. **milestoneDescription**  3. **dueDate**  4. **neverDue**  

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
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var body = new Milestone(); // Milestone |  (optional) 
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Create milestone
                VerveResponseMilestone result = apiInstance.CreateMilestone(requesterId, clientToken, body, accessToken);
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
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **body** | [**Milestone**](Milestone.md)|  | [optional] 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseMilestone**](VerveResponseMilestone.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createtask"></a>
# **CreateTask**
> VerveResponseTask CreateTask (long? milestoneId, string requesterId, string clientToken, Task body = null, string accessToken = null)

Create task

This service allows a user to create a task. The following fields(key:value) are required to be present in the Task JSON object. Refer to the Model & Model Schema of the expected JSON Object for the body of this API.   **Required fields**  1. **taskTitle**  2. **taskDescription**  3. **priority**  4. **dueDate**  5. **assigneeUserId**  6. **neverDue**  7. **user: { userId }**

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
            var milestoneId = 789;  // long? | Milestone Id
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var body = new Task(); // Task |  (optional) 
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Create task
                VerveResponseTask result = apiInstance.CreateTask(milestoneId, requesterId, clientToken, body, accessToken);
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
 **milestoneId** | **long?**| Milestone Id | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **body** | [**Task**](Task.md)|  | [optional] 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseTask**](VerveResponseTask.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletemilestone"></a>
# **DeleteMilestone**
> VerveResponseMilestone DeleteMilestone (long? milestoneId, string requesterId, string clientToken, string fields = null, string accessToken = null)

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
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list      /_*   **A) Default values -**        1)milestoneId       2)milestoneTitle       3)milestoneDescription       4)createdDate        **A) Available values-**        1)milestoneId       2)milestoneTitle       3)milestoneDescription       4)createdDate       5)status       6)priority       7)dueDate   *_/ (optional)  (default to milestoneId,milestoneTitle,milestoneDescription,createdDate)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Delete milestone
                VerveResponseMilestone result = apiInstance.DeleteMilestone(milestoneId, requesterId, clientToken, fields, accessToken);
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
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list      /_*   **A) Default values -**        1)milestoneId       2)milestoneTitle       3)milestoneDescription       4)createdDate        **A) Available values-**        1)milestoneId       2)milestoneTitle       3)milestoneDescription       4)createdDate       5)status       6)priority       7)dueDate   *_/ | [optional] [default to milestoneId,milestoneTitle,milestoneDescription,createdDate]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

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
> VerveResponseTask DeleteTask (long? taskId, string requesterId, string clientToken, string fields = null, string accessToken = null)

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
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list        /_*   **A) Default values -**        1)taskId       2)taskTitle       3)taskDescription       4)dueDate        **A) Available values-**        1)taskId       2)taskTitle       3)taskDescription       4)status       5)priority       6)dueDate       7)milestoneName       8)groupType       9)groupName   *_/ (optional)  (default to taskId,taskTitle,taskDescription,dueDate)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Delete task
                VerveResponseTask result = apiInstance.DeleteTask(taskId, requesterId, clientToken, fields, accessToken);
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
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list        /_*   **A) Default values -**        1)taskId       2)taskTitle       3)taskDescription       4)dueDate        **A) Available values-**        1)taskId       2)taskTitle       3)taskDescription       4)status       5)priority       6)dueDate       7)milestoneName       8)groupType       9)groupName   *_/ | [optional] [default to taskId,taskTitle,taskDescription,dueDate]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

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
> VerveResponseMilestoneList GetMilestones (string requesterId, string clientToken, long? organizationId = null, string fields = null, string accessToken = null)

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
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var organizationId = 789;  // long? | organizationId (optional) 
            var fields = fields_example;  // string | Filter fields in result list      /_*   **A) Default values -**        1)milestoneId       2)milestoneTitle       3)milestoneDescription       4)createdDate        **A) Available values-**        1)milestoneId       2)milestoneTitle       3)milestoneDescription       4)createdDate       5)status       6)priority       7)dueDate   *_/ (optional)  (default to milestoneId,milestoneTitle,milestoneDescription,createdDate)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get list of milestones
                VerveResponseMilestoneList result = apiInstance.GetMilestones(requesterId, clientToken, organizationId, fields, accessToken);
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
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **organizationId** | **long?**| organizationId | [optional] 
 **fields** | **string**| Filter fields in result list      /_*   **A) Default values -**        1)milestoneId       2)milestoneTitle       3)milestoneDescription       4)createdDate        **A) Available values-**        1)milestoneId       2)milestoneTitle       3)milestoneDescription       4)createdDate       5)status       6)priority       7)dueDate   *_/ | [optional] [default to milestoneId,milestoneTitle,milestoneDescription,createdDate]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

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
> VerveResponseCommentList GetMilestonesComments (long? milestoneId, string requesterId, string clientToken, string accessToken = null)

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
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get list of comments written on Milestones
                VerveResponseCommentList result = apiInstance.GetMilestonesComments(milestoneId, requesterId, clientToken, accessToken);
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
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

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
> VerveResponseCommentList GetTaskComments (long? taskId, string requesterId, string clientToken, string accessToken = null)

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
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get list of Comments written on task
                VerveResponseCommentList result = apiInstance.GetTaskComments(taskId, requesterId, clientToken, accessToken);
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
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

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
> VerveResponseTaskList GetUserTasks (long? userId, int? status, string requesterId, string clientToken, string fields = null, string accessToken = null)

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
            var userId = 789;  // long? | User Id whose assinged task want to get
            var status = 56;  // int? |   /_*   Task status   0 - ALL   1 - OPEN   2 - PERCENT_TWENTY   3 - PERCENT_FORTY   4 - PERCENT_SIXTY   5 - PERCENT_EIGHTY   6 - RESOLVED   7 - REOPENED   *_/
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list        /_*   **A) Default values -**        1)taskId       2)taskTitle       3)taskDescription       4)dueDate        **A) Available values-**        1)taskId       2)taskTitle       3)taskDescription       4)status       5)priority       6)dueDate       7)milestoneName       8)groupType       9)groupName   *_/ (optional)  (default to taskId,taskTitle,taskDescription,dueDate)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get list of task assigned to user
                VerveResponseTaskList result = apiInstance.GetUserTasks(userId, status, requesterId, clientToken, fields, accessToken);
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
 **userId** | **long?**| User Id whose assinged task want to get | 
 **status** | **int?**|   /_*   Task status   0 - ALL   1 - OPEN   2 - PERCENT_TWENTY   3 - PERCENT_FORTY   4 - PERCENT_SIXTY   5 - PERCENT_EIGHTY   6 - RESOLVED   7 - REOPENED   *_/ | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list        /_*   **A) Default values -**        1)taskId       2)taskTitle       3)taskDescription       4)dueDate        **A) Available values-**        1)taskId       2)taskTitle       3)taskDescription       4)status       5)priority       6)dueDate       7)milestoneName       8)groupType       9)groupName   *_/ | [optional] [default to taskId,taskTitle,taskDescription,dueDate]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

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
> VerveResponseMilestone UpdateMilestone (long? milestoneId, string title, string description, string dueDate, string requesterId, string clientToken, string fields = null, string accessToken = null)

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
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list      /_*   **A) Default values -**        1)milestoneId       2)milestoneTitle       3)milestoneDescription       4)createdDate        **A) Available values-**        1)milestoneId       2)milestoneTitle       3)milestoneDescription       4)createdDate       5)status       6)priority       7)dueDate   *_/ (optional)  (default to milestoneId,milestoneTitle,milestoneDescription,createdDate)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Update milestone
                VerveResponseMilestone result = apiInstance.UpdateMilestone(milestoneId, title, description, dueDate, requesterId, clientToken, fields, accessToken);
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
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list      /_*   **A) Default values -**        1)milestoneId       2)milestoneTitle       3)milestoneDescription       4)createdDate        **A) Available values-**        1)milestoneId       2)milestoneTitle       3)milestoneDescription       4)createdDate       5)status       6)priority       7)dueDate   *_/ | [optional] [default to milestoneId,milestoneTitle,milestoneDescription,createdDate]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

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
> VerveResponseTask UpdateTask (long? taskId, string title, string description, string dueDate, int? status, long? reAssigneeUserId, string requesterId, string clientToken, string fields = null, string accessToken = null)

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
            var status = 56;  // int? |   /_*   Task status   1 - OPEN   2 - PERCENT_TWENTY   3 - PERCENT_FORTY   4 - PERCENT_SIXTY   5 - PERCENT_EIGHTY   6 - RESOLVED   7 - REOPENED   *_/
            var reAssigneeUserId = 789;  // long? | re-assignee User Id
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list        /_*   **A) Default values -**        1)taskId       2)taskTitle       3)taskDescription       4)dueDate        **A) Available values-**        1)taskId       2)taskTitle       3)taskDescription       4)status       5)priority       6)dueDate       7)milestoneName       8)groupType       9)groupName   *_/ (optional)  (default to taskId,taskTitle,taskDescription,dueDate)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Update task
                VerveResponseTask result = apiInstance.UpdateTask(taskId, title, description, dueDate, status, reAssigneeUserId, requesterId, clientToken, fields, accessToken);
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
 **status** | **int?**|   /_*   Task status   1 - OPEN   2 - PERCENT_TWENTY   3 - PERCENT_FORTY   4 - PERCENT_SIXTY   5 - PERCENT_EIGHTY   6 - RESOLVED   7 - REOPENED   *_/ | 
 **reAssigneeUserId** | **long?**| re-assignee User Id | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list        /_*   **A) Default values -**        1)taskId       2)taskTitle       3)taskDescription       4)dueDate        **A) Available values-**        1)taskId       2)taskTitle       3)taskDescription       4)status       5)priority       6)dueDate       7)milestoneName       8)groupType       9)groupName   *_/ | [optional] [default to taskId,taskTitle,taskDescription,dueDate]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

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
> VerveResponseTask UpdateTaskStatus (long? taskId, int? status, string requesterId, string clientToken, string fields = null, string accessToken = null)

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
            var status = 56;  // int? |   /_*  Task status   1 - OPEN   2 - PERCENT_TWENTY   3 - PERCENT_FORTY   4 - PERCENT_SIXTY   5 - PERCENT_EIGHTY   6 - RESOLVED   7 - REOPENED   *_/
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list        /_*   **A) Default values -**        1)taskId       2)taskTitle       3)taskDescription       4)dueDate        **A) Available values-**        1)taskId       2)taskTitle       3)taskDescription       4)status       5)priority       6)dueDate       7)milestoneName       8)groupType       9)groupName   *_/ (optional)  (default to taskId,taskTitle,taskDescription,dueDate)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Update task status
                VerveResponseTask result = apiInstance.UpdateTaskStatus(taskId, status, requesterId, clientToken, fields, accessToken);
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
 **status** | **int?**|   /_*  Task status   1 - OPEN   2 - PERCENT_TWENTY   3 - PERCENT_FORTY   4 - PERCENT_SIXTY   5 - PERCENT_EIGHTY   6 - RESOLVED   7 - REOPENED   *_/ | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list        /_*   **A) Default values -**        1)taskId       2)taskTitle       3)taskDescription       4)dueDate        **A) Available values-**        1)taskId       2)taskTitle       3)taskDescription       4)status       5)priority       6)dueDate       7)milestoneName       8)groupType       9)groupName   *_/ | [optional] [default to taskId,taskTitle,taskDescription,dueDate]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseTask**](VerveResponseTask.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

