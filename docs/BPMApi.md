# IO.IEngage.Api.BPMApi

All URIs are relative to *https://api.iengage.io:8243/api/1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AssignWFTask**](BPMApi.md#assignwftask) | **POST** /bpm/tasks/{taskId}/assign | Assign task
[**CompleteWFTask**](BPMApi.md#completewftask) | **POST** /bpm/tasks/{taskId}/complete | Complete task
[**GetBPMTasks**](BPMApi.md#getbpmtasks) | **GET** /bpm/tasks/{taskId} | Get task by task id
[**GetSearchTask**](BPMApi.md#getsearchtask) | **GET** /bpm/{userId}/tasks/name | Get list of BPM task assigned to user
[**GetTasksByEntity**](BPMApi.md#gettasksbyentity) | **GET** /bpm/{userId}/tasks/{entityId} | Get list of BPM task assigned to user
[**GetUserBPMTasks**](BPMApi.md#getuserbpmtasks) | **GET** /bpm/{userId}/tasks | Get list of BPM task assigned to user
[**GetUserRolesBPMTasks**](BPMApi.md#getuserrolesbpmtasks) | **GET** /bpm/{userId}/roles/tasks | Get list of BPM task assigned to user roles


<a name="assignwftask"></a>
# **AssignWFTask**
> VerveResponseWFTask AssignWFTask (long? assigneeUserId, long? taskId, string loggedInUserId, string accessToken, string clientToken, string comment = null, long? dueDate = null, string fields = null)

Assign task

Assign BPM task, It will return task object

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class AssignWFTaskExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BPMApi();
            var assigneeUserId = 789;  // long? | assigneeUserId - assign to this user
            var taskId = 789;  // long? | taskId
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var comment = comment_example;  // string | comment (optional) 
            var dueDate = 789;  // long? | dueDate (optional) 
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)taskId<br/>2)name<br/>3)type<br/><b>A) Available values -</b> <br/>1)taskId<br/>2)name<br/>3)dueDate<br/>4)description<br/>5)transitionList<br/>6)type<br/>7)entityId<br/>8)attributes (optional)  (default to taskId,name,type)

            try
            {
                // Assign task
                VerveResponseWFTask result = apiInstance.AssignWFTask(assigneeUserId, taskId, loggedInUserId, accessToken, clientToken, comment, dueDate, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BPMApi.AssignWFTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assigneeUserId** | **long?**| assigneeUserId - assign to this user | 
 **taskId** | **long?**| taskId | 
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **comment** | **string**| comment | [optional] 
 **dueDate** | **long?**| dueDate | [optional] 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)taskId&lt;br/&gt;2)name&lt;br/&gt;3)type&lt;br/&gt;&lt;b&gt;A) Available values -&lt;/b&gt; &lt;br/&gt;1)taskId&lt;br/&gt;2)name&lt;br/&gt;3)dueDate&lt;br/&gt;4)description&lt;br/&gt;5)transitionList&lt;br/&gt;6)type&lt;br/&gt;7)entityId&lt;br/&gt;8)attributes | [optional] [default to taskId,name,type]

### Return type

[**VerveResponseWFTask**](VerveResponseWFTask.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="completewftask"></a>
# **CompleteWFTask**
> VerveResponseWFTask CompleteWFTask (long? userId, long? taskId, string loggedInUserId, string accessToken, string clientToken, string transition = null, string comment = null, string fields = null)

Complete task

Complete BPM task, It will return task object

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class CompleteWFTaskExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BPMApi();
            var userId = 789;  // long? | userId whose task want to complete
            var taskId = 789;  // long? | taskId
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var transition = transition_example;  // string | transition (optional) 
            var comment = comment_example;  // string | comment (optional) 
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)taskId<br/>2)name<br/>3)type<br/><b>A) Available values -</b> <br/>1)taskId<br/>2)name<br/>3)dueDate<br/>4)description<br/>5)transitionList<br/>6)type<br/>7)entityId<br/>8)attributes (optional)  (default to taskId,name,type)

            try
            {
                // Complete task
                VerveResponseWFTask result = apiInstance.CompleteWFTask(userId, taskId, loggedInUserId, accessToken, clientToken, transition, comment, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BPMApi.CompleteWFTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **long?**| userId whose task want to complete | 
 **taskId** | **long?**| taskId | 
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **transition** | **string**| transition | [optional] 
 **comment** | **string**| comment | [optional] 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)taskId&lt;br/&gt;2)name&lt;br/&gt;3)type&lt;br/&gt;&lt;b&gt;A) Available values -&lt;/b&gt; &lt;br/&gt;1)taskId&lt;br/&gt;2)name&lt;br/&gt;3)dueDate&lt;br/&gt;4)description&lt;br/&gt;5)transitionList&lt;br/&gt;6)type&lt;br/&gt;7)entityId&lt;br/&gt;8)attributes | [optional] [default to taskId,name,type]

### Return type

[**VerveResponseWFTask**](VerveResponseWFTask.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbpmtasks"></a>
# **GetBPMTasks**
> VerveResponseWFTask GetBPMTasks (long? userId, long? taskId, string loggedInUserId, string accessToken, string clientToken, string fields = null)

Get task by task id

Return the BPM task

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetBPMTasksExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BPMApi();
            var userId = 789;  // long? | userId
            var taskId = 789;  // long? | taskId
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)taskId<br/>2)name<br/>3)type<br/><b>A) Available values -</b> <br/>1)taskId<br/>2)name<br/>3)dueDate<br/>4)description<br/>5)transitionList<br/>6)type<br/>7)entityId<br/>8)attributes (optional)  (default to taskId,name,type)

            try
            {
                // Get task by task id
                VerveResponseWFTask result = apiInstance.GetBPMTasks(userId, taskId, loggedInUserId, accessToken, clientToken, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BPMApi.GetBPMTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **long?**| userId | 
 **taskId** | **long?**| taskId | 
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)taskId&lt;br/&gt;2)name&lt;br/&gt;3)type&lt;br/&gt;&lt;b&gt;A) Available values -&lt;/b&gt; &lt;br/&gt;1)taskId&lt;br/&gt;2)name&lt;br/&gt;3)dueDate&lt;br/&gt;4)description&lt;br/&gt;5)transitionList&lt;br/&gt;6)type&lt;br/&gt;7)entityId&lt;br/&gt;8)attributes | [optional] [default to taskId,name,type]

### Return type

[**VerveResponseWFTask**](VerveResponseWFTask.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsearchtask"></a>
# **GetSearchTask**
> VerveResponseWFTaskList GetSearchTask (long? userId, string searchString, bool? completed, bool? searchByUserRoles, int? start, int? end, string loggedInUserId, string accessToken, string clientToken, string type = null, long? organizationId = null, string fields = null)

Get list of BPM task assigned to user

Return the list of BPM task

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetSearchTaskExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BPMApi();
            var userId = 789;  // long? | userId
            var searchString = searchString_example;  // string | searchString
            var completed = true;  // bool? | 1) true - Completed <br/> 2) false - Pending <br/>
            var searchByUserRoles = true;  // bool? | 1) true - Assigned to roles <br/> 2) false - Assigned to user
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var type = type_example;  // string | Type (optional) 
            var organizationId = 789;  // long? | organizationId (optional) 
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)taskId<br/>2)name<br/>3)type<br/><b>A) Available values -</b> <br/>1)taskId<br/>2)name<br/>3)dueDate<br/>4)description<br/>5)transitionList<br/>6)type<br/>7)entityId<br/>8)attributes (optional)  (default to taskId,name,type)

            try
            {
                // Get list of BPM task assigned to user
                VerveResponseWFTaskList result = apiInstance.GetSearchTask(userId, searchString, completed, searchByUserRoles, start, end, loggedInUserId, accessToken, clientToken, type, organizationId, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BPMApi.GetSearchTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **long?**| userId | 
 **searchString** | **string**| searchString | 
 **completed** | **bool?**| 1) true - Completed &lt;br/&gt; 2) false - Pending &lt;br/&gt; | 
 **searchByUserRoles** | **bool?**| 1) true - Assigned to roles &lt;br/&gt; 2) false - Assigned to user | 
 **start** | **int?**| start, initial value start from 0 | 
 **end** | **int?**| end | 
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **type** | **string**| Type | [optional] 
 **organizationId** | **long?**| organizationId | [optional] 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)taskId&lt;br/&gt;2)name&lt;br/&gt;3)type&lt;br/&gt;&lt;b&gt;A) Available values -&lt;/b&gt; &lt;br/&gt;1)taskId&lt;br/&gt;2)name&lt;br/&gt;3)dueDate&lt;br/&gt;4)description&lt;br/&gt;5)transitionList&lt;br/&gt;6)type&lt;br/&gt;7)entityId&lt;br/&gt;8)attributes | [optional] [default to taskId,name,type]

### Return type

[**VerveResponseWFTaskList**](VerveResponseWFTaskList.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettasksbyentity"></a>
# **GetTasksByEntity**
> VerveResponseWFTaskList GetTasksByEntity (long? userId, long? entityId, bool? completed, bool? searchByUserRoles, int? start, int? end, string loggedInUserId, string accessToken, string clientToken, string fields = null)

Get list of BPM task assigned to user

Return the list of BPM task

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetTasksByEntityExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BPMApi();
            var userId = 789;  // long? | userId whose task want to see
            var entityId = 789;  // long? | entityId
            var completed = true;  // bool? | 1) true - Completed <br/> 2) false - Pending <br/>
            var searchByUserRoles = true;  // bool? | 1) true - Assigned to roles <br/> 2) false - Assigned to user
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)taskId<br/>2)name<br/>3)type<br/><b>A) Available values -</b> <br/>1)taskId<br/>2)name<br/>3)dueDate<br/>4)description<br/>5)transitionList<br/>6)type<br/>7)entityId<br/>8)attributes (optional)  (default to taskId,name,type)

            try
            {
                // Get list of BPM task assigned to user
                VerveResponseWFTaskList result = apiInstance.GetTasksByEntity(userId, entityId, completed, searchByUserRoles, start, end, loggedInUserId, accessToken, clientToken, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BPMApi.GetTasksByEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **long?**| userId whose task want to see | 
 **entityId** | **long?**| entityId | 
 **completed** | **bool?**| 1) true - Completed &lt;br/&gt; 2) false - Pending &lt;br/&gt; | 
 **searchByUserRoles** | **bool?**| 1) true - Assigned to roles &lt;br/&gt; 2) false - Assigned to user | 
 **start** | **int?**| start, initial value start from 0 | 
 **end** | **int?**| end | 
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)taskId&lt;br/&gt;2)name&lt;br/&gt;3)type&lt;br/&gt;&lt;b&gt;A) Available values -&lt;/b&gt; &lt;br/&gt;1)taskId&lt;br/&gt;2)name&lt;br/&gt;3)dueDate&lt;br/&gt;4)description&lt;br/&gt;5)transitionList&lt;br/&gt;6)type&lt;br/&gt;7)entityId&lt;br/&gt;8)attributes | [optional] [default to taskId,name,type]

### Return type

[**VerveResponseWFTaskList**](VerveResponseWFTaskList.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserbpmtasks"></a>
# **GetUserBPMTasks**
> VerveResponseWFTaskList GetUserBPMTasks (long? userId, bool? completed, int? start, int? end, string loggedInUserId, string accessToken, string clientToken, string type = null, long? organizationId = null, string fields = null)

Get list of BPM task assigned to user

Return the list of BPM task

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetUserBPMTasksExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BPMApi();
            var userId = 789;  // long? | userId whose task want to see
            var completed = true;  // bool? | 1) true - Completed <br/> 2) false - Pending <br/> 3) Blank - All
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var type = type_example;  // string | Type (optional) 
            var organizationId = 789;  // long? | organizationId (optional) 
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)taskId<br/>2)name<br/>3)type<br/><b>A) Available values -</b> <br/>1)taskId<br/>2)name<br/>3)dueDate<br/>4)description<br/>5)transitionList<br/>6)type<br/>7)entityId<br/>8)attributes (optional)  (default to taskId,name,type)

            try
            {
                // Get list of BPM task assigned to user
                VerveResponseWFTaskList result = apiInstance.GetUserBPMTasks(userId, completed, start, end, loggedInUserId, accessToken, clientToken, type, organizationId, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BPMApi.GetUserBPMTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **long?**| userId whose task want to see | 
 **completed** | **bool?**| 1) true - Completed &lt;br/&gt; 2) false - Pending &lt;br/&gt; 3) Blank - All | 
 **start** | **int?**| start, initial value start from 0 | 
 **end** | **int?**| end | 
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **type** | **string**| Type | [optional] 
 **organizationId** | **long?**| organizationId | [optional] 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)taskId&lt;br/&gt;2)name&lt;br/&gt;3)type&lt;br/&gt;&lt;b&gt;A) Available values -&lt;/b&gt; &lt;br/&gt;1)taskId&lt;br/&gt;2)name&lt;br/&gt;3)dueDate&lt;br/&gt;4)description&lt;br/&gt;5)transitionList&lt;br/&gt;6)type&lt;br/&gt;7)entityId&lt;br/&gt;8)attributes | [optional] [default to taskId,name,type]

### Return type

[**VerveResponseWFTaskList**](VerveResponseWFTaskList.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserrolesbpmtasks"></a>
# **GetUserRolesBPMTasks**
> VerveResponseWFTaskList GetUserRolesBPMTasks (long? userId, bool? completed, int? start, int? end, string loggedInUserId, string accessToken, string clientToken, string type = null, long? organizationId = null, string fields = null)

Get list of BPM task assigned to user roles

Return the list of BPM task

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetUserRolesBPMTasksExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BPMApi();
            var userId = 789;  // long? | userId whose task want to see
            var completed = true;  // bool? | 1) true - Completed <br/> 2) false - Pending <br/> 3) Blank - All
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var type = type_example;  // string | Type (optional) 
            var organizationId = 789;  // long? | organizationId (optional) 
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)taskId<br/>2)name<br/>3)type<br/><b>A) Available values -</b> <br/>1)taskId<br/>2)name<br/>3)dueDate<br/>4)description<br/>5)transitionList<br/>6)type<br/>7)entityId<br/>8)attributes (optional)  (default to taskId,name,type)

            try
            {
                // Get list of BPM task assigned to user roles
                VerveResponseWFTaskList result = apiInstance.GetUserRolesBPMTasks(userId, completed, start, end, loggedInUserId, accessToken, clientToken, type, organizationId, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BPMApi.GetUserRolesBPMTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **long?**| userId whose task want to see | 
 **completed** | **bool?**| 1) true - Completed &lt;br/&gt; 2) false - Pending &lt;br/&gt; 3) Blank - All | 
 **start** | **int?**| start, initial value start from 0 | 
 **end** | **int?**| end | 
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **type** | **string**| Type | [optional] 
 **organizationId** | **long?**| organizationId | [optional] 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)taskId&lt;br/&gt;2)name&lt;br/&gt;3)type&lt;br/&gt;&lt;b&gt;A) Available values -&lt;/b&gt; &lt;br/&gt;1)taskId&lt;br/&gt;2)name&lt;br/&gt;3)dueDate&lt;br/&gt;4)description&lt;br/&gt;5)transitionList&lt;br/&gt;6)type&lt;br/&gt;7)entityId&lt;br/&gt;8)attributes | [optional] [default to taskId,name,type]

### Return type

[**VerveResponseWFTaskList**](VerveResponseWFTaskList.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

