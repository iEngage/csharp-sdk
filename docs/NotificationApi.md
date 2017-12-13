# IO.IEngage.Api.NotificationApi

All URIs are relative to *https://api.iengage.io:8243/api/1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddNotification**](NotificationApi.md#addnotification) | **POST** /notifications | Create custom notification
[**GetNotifications**](NotificationApi.md#getnotifications) | **GET** /notifications | Get list of notifications
[**MarkAllNotificationAsRead**](NotificationApi.md#markallnotificationasread) | **POST** /notifications/read/all | Mark all notification as read
[**MarkNotificationAsRead**](NotificationApi.md#marknotificationasread) | **POST** /notifications/read/{notificationId} | Mark notification as read
[**NotificationCount**](NotificationApi.md#notificationcount) | **GET** /notifications/count | Get notifications count


<a name="addnotification"></a>
# **AddNotification**
> bool? AddNotification (string title, string body, string extraData, string loggedInUserId, string accessToken, string clientToken, string role = null, string emailAddress = null)

Create custom notification

Allows the user to mark the notification as read

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class AddNotificationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationApi();
            var title = title_example;  // string | notification title
            var body = body_example;  // string | notification body
            var extraData = extraData_example;  // string | Extra information. You can send json string if want to store more than one parameter
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var role = role_example;  // string | Role/Group name (optional) 
            var emailAddress = emailAddress_example;  // string | EmailAddress of user (optional) 

            try
            {
                // Create custom notification
                bool? result = apiInstance.AddNotification(title, body, extraData, loggedInUserId, accessToken, clientToken, role, emailAddress);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationApi.AddNotification: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **title** | **string**| notification title | 
 **body** | **string**| notification body | 
 **extraData** | **string**| Extra information. You can send json string if want to store more than one parameter | 
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **role** | **string**| Role/Group name | [optional] 
 **emailAddress** | **string**| EmailAddress of user | [optional] 

### Return type

**bool?**

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnotifications"></a>
# **GetNotifications**
> VerveResponseNotificationList GetNotifications (string type, int? start, int? end, string loggedInUserId, string accessToken, string clientToken, string fields = null)

Get list of notifications

Return the list of notifications

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetNotificationsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationApi();
            var type = type_example;  // string | Type of count<br/> 1) UNREAD <br/> 2) READ <br/> 3)ALL (default to ALL)
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)notificationId<br/>2)message<br/>3)isRead<br/>4)date<br/><b>A) Available values-</b><br/>1)notificationId<br/>2)message<br/>3)isRead<br/>4)date<br/>5)type<br/>6)byUser<br/>7)entity<br/>8)parentEntity (optional)  (default to notificationId,message,isRead,date)

            try
            {
                // Get list of notifications
                VerveResponseNotificationList result = apiInstance.GetNotifications(type, start, end, loggedInUserId, accessToken, clientToken, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationApi.GetNotifications: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| Type of count&lt;br/&gt; 1) UNREAD &lt;br/&gt; 2) READ &lt;br/&gt; 3)ALL | [default to ALL]
 **start** | **int?**| start, initial value start from 0 | 
 **end** | **int?**| end | 
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)notificationId&lt;br/&gt;2)message&lt;br/&gt;3)isRead&lt;br/&gt;4)date&lt;br/&gt;&lt;b&gt;A) Available values-&lt;/b&gt;&lt;br/&gt;1)notificationId&lt;br/&gt;2)message&lt;br/&gt;3)isRead&lt;br/&gt;4)date&lt;br/&gt;5)type&lt;br/&gt;6)byUser&lt;br/&gt;7)entity&lt;br/&gt;8)parentEntity | [optional] [default to notificationId,message,isRead,date]

### Return type

[**VerveResponseNotificationList**](VerveResponseNotificationList.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="markallnotificationasread"></a>
# **MarkAllNotificationAsRead**
> bool? MarkAllNotificationAsRead (string loggedInUserId, string accessToken, string clientToken)

Mark all notification as read

Allows the user to mark all the notification as read

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class MarkAllNotificationAsReadExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationApi();
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs

            try
            {
                // Mark all notification as read
                bool? result = apiInstance.MarkAllNotificationAsRead(loggedInUserId, accessToken, clientToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationApi.MarkAllNotificationAsRead: " + e.Message );
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

### Return type

**bool?**

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="marknotificationasread"></a>
# **MarkNotificationAsRead**
> bool? MarkNotificationAsRead (long? notificationId, string loggedInUserId, string accessToken, string clientToken)

Mark notification as read

Allows the user to mark the notification as read

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class MarkNotificationAsReadExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationApi();
            var notificationId = 789;  // long? | notification Id
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs

            try
            {
                // Mark notification as read
                bool? result = apiInstance.MarkNotificationAsRead(notificationId, loggedInUserId, accessToken, clientToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationApi.MarkNotificationAsRead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **notificationId** | **long?**| notification Id | 
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 

### Return type

**bool?**

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notificationcount"></a>
# **NotificationCount**
> long? NotificationCount (string type, string loggedInUserId, string accessToken, string clientToken)

Get notifications count

Returns the notification count

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class NotificationCountExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationApi();
            var type = type_example;  // string | Type of count<br/> 1) UNREAD <br/> 2) READ <br/> 3)ALL (default to ALL)
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs

            try
            {
                // Get notifications count
                long? result = apiInstance.NotificationCount(type, loggedInUserId, accessToken, clientToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationApi.NotificationCount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| Type of count&lt;br/&gt; 1) UNREAD &lt;br/&gt; 2) READ &lt;br/&gt; 3)ALL | [default to ALL]
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 

### Return type

**long?**

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

