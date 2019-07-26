# IO.IEngage.Api.BPMApi

All URIs are relative to *https://api.iengage.io:8243/api/2.0*

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
> VerveResponseWFTask AssignWFTask (long? assigneeUserId, long? taskId, string requesterId, string clientToken, string comment = null, long? dueDate = null, string fields = null, string accessToken = null)

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
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var comment = comment_example;  // string | comment (optional) 
            var dueDate = 789;  // long? | dueDate (optional) 
            var fields = fields_example;  // string | Filter fields in result list        /_*   **A) Default values -**        1)taskId       2)name       3)type        **A) Available values -**         1)taskId       2)name       3)dueDate       4)description       5)transitionList       6)type       7)entityId       8)attributes   *_/ (optional)  (default to taskId,name,type)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Assign task
                VerveResponseWFTask result = apiInstance.AssignWFTask(assigneeUserId, taskId, requesterId, clientToken, comment, dueDate, fields, accessToken);
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
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **comment** | **string**| comment | [optional] 
 **dueDate** | **long?**| dueDate | [optional] 
 **fields** | **string**| Filter fields in result list        /_*   **A) Default values -**        1)taskId       2)name       3)type        **A) Available values -**         1)taskId       2)name       3)dueDate       4)description       5)transitionList       6)type       7)entityId       8)attributes   *_/ | [optional] [default to taskId,name,type]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

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
> VerveResponseWFTask CompleteWFTask (long? userId, long? taskId, string requesterId, string clientToken, string transition = null, string comment = null, string fields = null, string accessToken = null)

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
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var transition = transition_example;  // string | transition (optional) 
            var comment = comment_example;  // string | comment (optional) 
            var fields = fields_example;  // string | Filter fields in result list        /_*   **A) Default values -**        1)taskId       2)name       3)type        **A) Available values -**         1)taskId       2)name       3)dueDate       4)description       5)transitionList       6)type       7)entityId       8)attributes   *_/ (optional)  (default to taskId,name,type)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Complete task
                VerveResponseWFTask result = apiInstance.CompleteWFTask(userId, taskId, requesterId, clientToken, transition, comment, fields, accessToken);
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
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **transition** | **string**| transition | [optional] 
 **comment** | **string**| comment | [optional] 
 **fields** | **string**| Filter fields in result list        /_*   **A) Default values -**        1)taskId       2)name       3)type        **A) Available values -**         1)taskId       2)name       3)dueDate       4)description       5)transitionList       6)type       7)entityId       8)attributes   *_/ | [optional] [default to taskId,name,type]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

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
> VerveResponseWFTask GetBPMTasks (long? userId, long? taskId, string requesterId, string clientToken, string fields = null, string accessToken = null)

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
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list        /_*   **A) Default values -**        1)taskId       2)name       3)type        **A) Available values -**         1)taskId       2)name       3)dueDate       4)description       5)transitionList       6)type       7)entityId       8)attributes   *_/ (optional)  (default to taskId,name,type)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get task by task id
                VerveResponseWFTask result = apiInstance.GetBPMTasks(userId, taskId, requesterId, clientToken, fields, accessToken);
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
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list        /_*   **A) Default values -**        1)taskId       2)name       3)type        **A) Available values -**         1)taskId       2)name       3)dueDate       4)description       5)transitionList       6)type       7)entityId       8)attributes   *_/ | [optional] [default to taskId,name,type]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

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
> VerveResponseWFTaskList GetSearchTask (long? userId, string searchString, bool? completed, bool? searchByUserRoles, int? start, int? end, string requesterId, string clientToken, string type = null, long? organizationId = null, string fields = null, string accessToken = null)

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
            var userId = 789;  // long? | User Id whose tasks want to get
            var searchString = searchString_example;  // string | searchString
            var completed = true;  // bool? |   /_*   1) true - Completed   2) false - Pending   *_/
            var searchByUserRoles = true;  // bool? |   /_*   1) true - Assigned to roles   2) false - Assigned to user   *_/
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var type = type_example;  // string | Type (optional) 
            var organizationId = 789;  // long? | organizationId (optional) 
            var fields = fields_example;  // string | Filter fields in result list        /_*   **A) Default values -**        1)taskId       2)name       3)type        **A) Available values -**         1)taskId       2)name       3)dueDate       4)description       5)transitionList       6)type       7)entityId       8)attributes   *_/ (optional)  (default to taskId,name,type)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get list of BPM task assigned to user
                VerveResponseWFTaskList result = apiInstance.GetSearchTask(userId, searchString, completed, searchByUserRoles, start, end, requesterId, clientToken, type, organizationId, fields, accessToken);
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
 **userId** | **long?**| User Id whose tasks want to get | 
 **searchString** | **string**| searchString | 
 **completed** | **bool?**|   /_*   1) true - Completed   2) false - Pending   *_/ | 
 **searchByUserRoles** | **bool?**|   /_*   1) true - Assigned to roles   2) false - Assigned to user   *_/ | 
 **start** | **int?**| start, initial value start from 0 | 
 **end** | **int?**| end | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **type** | **string**| Type | [optional] 
 **organizationId** | **long?**| organizationId | [optional] 
 **fields** | **string**| Filter fields in result list        /_*   **A) Default values -**        1)taskId       2)name       3)type        **A) Available values -**         1)taskId       2)name       3)dueDate       4)description       5)transitionList       6)type       7)entityId       8)attributes   *_/ | [optional] [default to taskId,name,type]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

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
> VerveResponseWFTaskList GetTasksByEntity (long? userId, long? entityId, bool? completed, bool? searchByUserRoles, int? start, int? end, string requesterId, string clientToken, string fields = null, string accessToken = null)

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
            var userId = 789;  // long? | User Id whose task want to see
            var entityId = 789;  // long? | entityId
            var completed = true;  // bool? |   /_*   1) true - Completed   2) false - Pending   *_/
            var searchByUserRoles = true;  // bool? |   /_*   1) true - Assigned to roles   2) false - Assigned to user   *_/
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list        /_*   **A) Default values -**        1)taskId       2)name       3)type        **A) Available values -**         1)taskId       2)name       3)dueDate       4)description       5)transitionList       6)type       7)entityId       8)attributes   *_/ (optional)  (default to taskId,name,type)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get list of BPM task assigned to user
                VerveResponseWFTaskList result = apiInstance.GetTasksByEntity(userId, entityId, completed, searchByUserRoles, start, end, requesterId, clientToken, fields, accessToken);
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
 **userId** | **long?**| User Id whose task want to see | 
 **entityId** | **long?**| entityId | 
 **completed** | **bool?**|   /_*   1) true - Completed   2) false - Pending   *_/ | 
 **searchByUserRoles** | **bool?**|   /_*   1) true - Assigned to roles   2) false - Assigned to user   *_/ | 
 **start** | **int?**| start, initial value start from 0 | 
 **end** | **int?**| end | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list        /_*   **A) Default values -**        1)taskId       2)name       3)type        **A) Available values -**         1)taskId       2)name       3)dueDate       4)description       5)transitionList       6)type       7)entityId       8)attributes   *_/ | [optional] [default to taskId,name,type]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

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
> VerveResponseWFTaskList GetUserBPMTasks (long? userId, bool? completed, int? start, int? end, string requesterId, string clientToken, string type = null, long? organizationId = null, string fields = null, string accessToken = null)

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
            var userId = 789;  // long? | User Id whose task want to see
            var completed = true;  // bool? |   /_*   Accepted Values   1) true - Completed   2) false - Pending   3) Blank - All   *_/
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var type = type_example;  // string | Type (optional) 
            var organizationId = 789;  // long? | organizationId (optional) 
            var fields = fields_example;  // string | Filter fields in result list        /_*   **A) Default values -**        1)taskId       2)name       3)type        **A) Available values -**         1)taskId       2)name       3)dueDate       4)description       5)transitionList       6)type       7)entityId       8)attributes   *_/ (optional)  (default to taskId,name,type)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get list of BPM task assigned to user
                VerveResponseWFTaskList result = apiInstance.GetUserBPMTasks(userId, completed, start, end, requesterId, clientToken, type, organizationId, fields, accessToken);
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
 **userId** | **long?**| User Id whose task want to see | 
 **completed** | **bool?**|   /_*   Accepted Values   1) true - Completed   2) false - Pending   3) Blank - All   *_/ | 
 **start** | **int?**| start, initial value start from 0 | 
 **end** | **int?**| end | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **type** | **string**| Type | [optional] 
 **organizationId** | **long?**| organizationId | [optional] 
 **fields** | **string**| Filter fields in result list        /_*   **A) Default values -**        1)taskId       2)name       3)type        **A) Available values -**         1)taskId       2)name       3)dueDate       4)description       5)transitionList       6)type       7)entityId       8)attributes   *_/ | [optional] [default to taskId,name,type]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

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
> VerveResponseWFTaskList GetUserRolesBPMTasks (long? userId, bool? completed, int? start, int? end, string requesterId, string clientToken, string type = null, long? organizationId = null, string fields = null, string accessToken = null)

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
            var userId = 789;  // long? | User Id whose task want to see
            var completed = true;  // bool? |   /_*   1) true - Completed   2) false - Pending   3) Blank - All   *_/
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var type = type_example;  // string | Type (optional) 
            var organizationId = 789;  // long? | organizationId (optional) 
            var fields = fields_example;  // string | Filter fields in result list        /_*   **A) Default values -**        1)taskId       2)name       3)type        **A) Available values -**         1)taskId       2)name       3)dueDate       4)description       5)transitionList       6)type       7)entityId       8)attributes   *_/ (optional)  (default to taskId,name,type)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get list of BPM task assigned to user roles
                VerveResponseWFTaskList result = apiInstance.GetUserRolesBPMTasks(userId, completed, start, end, requesterId, clientToken, type, organizationId, fields, accessToken);
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
 **userId** | **long?**| User Id whose task want to see | 
 **completed** | **bool?**|   /_*   1) true - Completed   2) false - Pending   3) Blank - All   *_/ | 
 **start** | **int?**| start, initial value start from 0 | 
 **end** | **int?**| end | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **type** | **string**| Type | [optional] 
 **organizationId** | **long?**| organizationId | [optional] 
 **fields** | **string**| Filter fields in result list        /_*   **A) Default values -**        1)taskId       2)name       3)type        **A) Available values -**         1)taskId       2)name       3)dueDate       4)description       5)transitionList       6)type       7)entityId       8)attributes   *_/ | [optional] [default to taskId,name,type]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseWFTaskList**](VerveResponseWFTaskList.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

