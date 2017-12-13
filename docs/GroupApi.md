# IO.IEngage.Api.GroupApi

All URIs are relative to *https://api.iengage.io:8243/api/1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteGroup**](GroupApi.md#deletegroup) | **DELETE** /groups/{groupId} | Delete group
[**FollowGroup**](GroupApi.md#followgroup) | **POST** /groups/{groupId}/follow | Follow group
[**GetGroupFollowers**](GroupApi.md#getgroupfollowers) | **GET** /groups/{groupId}/followers | Get the list of followers for the group
[**GetGroupIdeas**](GroupApi.md#getgroupideas) | **GET** /groups/{groupId}/ideas | Get list of all ideas in a group
[**GetUserFollowingGroups**](GroupApi.md#getuserfollowinggroups) | **GET** /groups/{userId}/following | Get list of groups that a user is following
[**UnfollowGroup**](GroupApi.md#unfollowgroup) | **POST** /groups/{groupId}/unfollow | Unfollow group
[**UpdateGroup**](GroupApi.md#updategroup) | **PUT** /groups/{groupId} | Update group


<a name="deletegroup"></a>
# **DeleteGroup**
> VerveResponseGroup DeleteGroup (long? groupId, string loggedInUserId, string accessToken, string clientToken, string fields = null)

Delete group

Allows the user to delete a group. Returns the deleted group

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class DeleteGroupExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupApi();
            var groupId = 789;  // long? | groupId
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)groupId<br/>2)groupName<br/>3)description<br/>4)startDate<br/><b>A) Available values-</b><br/>1)groupId<br/>2)groupName<br/>3)description<br/>4)startDate<br/>5)ideasCount<br/>6)followersCount<br/>7)currentUserFollowing<br/>8)dueDate<br/>9)participantsCount<br/>10)friendsParticipantsCount<br/>11)friendsIdeasCount (optional)  (default to groupId,groupName,description,startDate)

            try
            {
                // Delete group
                VerveResponseGroup result = apiInstance.DeleteGroup(groupId, loggedInUserId, accessToken, clientToken, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupApi.DeleteGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **long?**| groupId | 
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)groupId&lt;br/&gt;2)groupName&lt;br/&gt;3)description&lt;br/&gt;4)startDate&lt;br/&gt;&lt;b&gt;A) Available values-&lt;/b&gt;&lt;br/&gt;1)groupId&lt;br/&gt;2)groupName&lt;br/&gt;3)description&lt;br/&gt;4)startDate&lt;br/&gt;5)ideasCount&lt;br/&gt;6)followersCount&lt;br/&gt;7)currentUserFollowing&lt;br/&gt;8)dueDate&lt;br/&gt;9)participantsCount&lt;br/&gt;10)friendsParticipantsCount&lt;br/&gt;11)friendsIdeasCount | [optional] [default to groupId,groupName,description,startDate]

### Return type

[**VerveResponseGroup**](VerveResponseGroup.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="followgroup"></a>
# **FollowGroup**
> VerveResponseGroup FollowGroup (long? groupId, string loggedInUserId, string accessToken, string clientToken, string fields = null)

Follow group

Allows the user to follow a group. Returns the followed group

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class FollowGroupExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupApi();
            var groupId = 789;  // long? | groupId
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)groupId<br/>2)groupName<br/>3)description<br/>4)startDate<br/><b>A) Available values-</b><br/>1)groupId<br/>2)groupName<br/>3)description<br/>4)startDate<br/>5)ideasCount<br/>6)followersCount<br/>7)currentUserFollowing<br/>8)dueDate<br/>9)participantsCount<br/>10)friendsParticipantsCount<br/>11)friendsIdeasCount (optional)  (default to groupId,groupName,description,startDate)

            try
            {
                // Follow group
                VerveResponseGroup result = apiInstance.FollowGroup(groupId, loggedInUserId, accessToken, clientToken, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupApi.FollowGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **long?**| groupId | 
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)groupId&lt;br/&gt;2)groupName&lt;br/&gt;3)description&lt;br/&gt;4)startDate&lt;br/&gt;&lt;b&gt;A) Available values-&lt;/b&gt;&lt;br/&gt;1)groupId&lt;br/&gt;2)groupName&lt;br/&gt;3)description&lt;br/&gt;4)startDate&lt;br/&gt;5)ideasCount&lt;br/&gt;6)followersCount&lt;br/&gt;7)currentUserFollowing&lt;br/&gt;8)dueDate&lt;br/&gt;9)participantsCount&lt;br/&gt;10)friendsParticipantsCount&lt;br/&gt;11)friendsIdeasCount | [optional] [default to groupId,groupName,description,startDate]

### Return type

[**VerveResponseGroup**](VerveResponseGroup.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroupfollowers"></a>
# **GetGroupFollowers**
> VerveResponseUserList GetGroupFollowers (long? groupId, int? start, int? end, string loggedInUserId, string accessToken, string clientToken, string fields = null)

Get the list of followers for the group

Returns the list of followers for the group

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetGroupFollowersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupApi();
            var groupId = 789;  // long? | groupId
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)userId<br/>2)firstName<br/>3)lastName<br/>4)profileImage<br/><b>A) Available values-</b><br/>1)userId<br/>2)firstName<br/>3)lastName<br/>4)emailId<br/>5)profileImage<br/>6)birthDate<br/>7)currentUserFollowing<br/>8)currentUserFriend<br/>9)equityScore (optional)  (default to userId,firstName,lastName,profileImage)

            try
            {
                // Get the list of followers for the group
                VerveResponseUserList result = apiInstance.GetGroupFollowers(groupId, start, end, loggedInUserId, accessToken, clientToken, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupApi.GetGroupFollowers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **long?**| groupId | 
 **start** | **int?**| start, initial value start from 0 | 
 **end** | **int?**| end | 
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)userId&lt;br/&gt;2)firstName&lt;br/&gt;3)lastName&lt;br/&gt;4)profileImage&lt;br/&gt;&lt;b&gt;A) Available values-&lt;/b&gt;&lt;br/&gt;1)userId&lt;br/&gt;2)firstName&lt;br/&gt;3)lastName&lt;br/&gt;4)emailId&lt;br/&gt;5)profileImage&lt;br/&gt;6)birthDate&lt;br/&gt;7)currentUserFollowing&lt;br/&gt;8)currentUserFriend&lt;br/&gt;9)equityScore | [optional] [default to userId,firstName,lastName,profileImage]

### Return type

[**VerveResponseUserList**](VerveResponseUserList.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroupideas"></a>
# **GetGroupIdeas**
> VerveResponseIdeaList GetGroupIdeas (long? groupId, int? start, int? end, string loggedInUserId, string accessToken, string clientToken, string fields = null)

Get list of all ideas in a group

Returns the list of all ideas in a group

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetGroupIdeasExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupApi();
            var groupId = 789;  // long? | groupId
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)ideaId<br/>2)ideaTitle<br/>3)ideaDescription<br/>4)ideaCreationDate<br/><b>A) Available values-</b><br/>1)ideaId<br/>2)ideaTitle<br/>3)group<br/>4)ideaDescription<br/>5)ideator<br/>6)ideaCreationDate<br/>7)lastModifiedDate<br/>8)ideaStage<br/>9)domain<br/>10)technology<br/>11)accessType<br/>12)videoId<br/>13)activeStatus<br/>14)teamStatus<br/>15)projectStatus<br/>16)totalFollowers<br/>17)totalComments<br/>18)totalBlogs<br/>19)averageRatingScore<br/>20)numberOfRatings<br/>21)currentUserFollowing<br/>22)currentUserRating<br/>23)ideaFileURL<br/>24)sentiment</br>25)entity (optional)  (default to ideaId,ideaTitle,ideaDescription,ideaCreationDate)

            try
            {
                // Get list of all ideas in a group
                VerveResponseIdeaList result = apiInstance.GetGroupIdeas(groupId, start, end, loggedInUserId, accessToken, clientToken, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupApi.GetGroupIdeas: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **long?**| groupId | 
 **start** | **int?**| start, initial value start from 0 | 
 **end** | **int?**| end | 
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)ideaId&lt;br/&gt;2)ideaTitle&lt;br/&gt;3)ideaDescription&lt;br/&gt;4)ideaCreationDate&lt;br/&gt;&lt;b&gt;A) Available values-&lt;/b&gt;&lt;br/&gt;1)ideaId&lt;br/&gt;2)ideaTitle&lt;br/&gt;3)group&lt;br/&gt;4)ideaDescription&lt;br/&gt;5)ideator&lt;br/&gt;6)ideaCreationDate&lt;br/&gt;7)lastModifiedDate&lt;br/&gt;8)ideaStage&lt;br/&gt;9)domain&lt;br/&gt;10)technology&lt;br/&gt;11)accessType&lt;br/&gt;12)videoId&lt;br/&gt;13)activeStatus&lt;br/&gt;14)teamStatus&lt;br/&gt;15)projectStatus&lt;br/&gt;16)totalFollowers&lt;br/&gt;17)totalComments&lt;br/&gt;18)totalBlogs&lt;br/&gt;19)averageRatingScore&lt;br/&gt;20)numberOfRatings&lt;br/&gt;21)currentUserFollowing&lt;br/&gt;22)currentUserRating&lt;br/&gt;23)ideaFileURL&lt;br/&gt;24)sentiment&lt;/br&gt;25)entity | [optional] [default to ideaId,ideaTitle,ideaDescription,ideaCreationDate]

### Return type

[**VerveResponseIdeaList**](VerveResponseIdeaList.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserfollowinggroups"></a>
# **GetUserFollowingGroups**
> VerveResponseGroupList GetUserFollowingGroups (long? userId, int? start, int? end, string loggedInUserId, string accessToken, string clientToken, string fields = null)

Get list of groups that a user is following

Returns the list of groups the user is following

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetUserFollowingGroupsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupApi();
            var userId = 789;  // long? | userId
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)groupId<br/>2)groupName<br/>3)description<br/>4)startDate<br/><b>A) Available values-</b><br/>1)groupId<br/>2)groupName<br/>3)description<br/>4)startDate<br/>5)ideasCount<br/>6)followersCount<br/>7)currentUserFollowing<br/>8)dueDate<br/>9)participantsCount<br/>10)friendsParticipantsCount<br/>11)friendsIdeasCount (optional)  (default to groupId,groupName,description,startDate)

            try
            {
                // Get list of groups that a user is following
                VerveResponseGroupList result = apiInstance.GetUserFollowingGroups(userId, start, end, loggedInUserId, accessToken, clientToken, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupApi.GetUserFollowingGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **long?**| userId | 
 **start** | **int?**| start, initial value start from 0 | 
 **end** | **int?**| end | 
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)groupId&lt;br/&gt;2)groupName&lt;br/&gt;3)description&lt;br/&gt;4)startDate&lt;br/&gt;&lt;b&gt;A) Available values-&lt;/b&gt;&lt;br/&gt;1)groupId&lt;br/&gt;2)groupName&lt;br/&gt;3)description&lt;br/&gt;4)startDate&lt;br/&gt;5)ideasCount&lt;br/&gt;6)followersCount&lt;br/&gt;7)currentUserFollowing&lt;br/&gt;8)dueDate&lt;br/&gt;9)participantsCount&lt;br/&gt;10)friendsParticipantsCount&lt;br/&gt;11)friendsIdeasCount | [optional] [default to groupId,groupName,description,startDate]

### Return type

[**VerveResponseGroupList**](VerveResponseGroupList.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unfollowgroup"></a>
# **UnfollowGroup**
> VerveResponseGroup UnfollowGroup (long? groupId, string loggedInUserId, string accessToken, string clientToken, string fields = null)

Unfollow group

Allows the user to unfollow a group. Returns the unfollowed group

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class UnfollowGroupExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupApi();
            var groupId = 789;  // long? | groupId
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)groupId<br/>2)groupName<br/>3)description<br/>4)startDate<br/><b>A) Available values-</b><br/>1)groupId<br/>2)groupName<br/>3)description<br/>4)startDate<br/>5)ideasCount<br/>6)followersCount<br/>7)currentUserFollowing<br/>8)dueDate<br/>9)participantsCount<br/>10)friendsParticipantsCount<br/>11)friendsIdeasCount (optional)  (default to groupId,groupName,description,startDate)

            try
            {
                // Unfollow group
                VerveResponseGroup result = apiInstance.UnfollowGroup(groupId, loggedInUserId, accessToken, clientToken, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupApi.UnfollowGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **long?**| groupId | 
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)groupId&lt;br/&gt;2)groupName&lt;br/&gt;3)description&lt;br/&gt;4)startDate&lt;br/&gt;&lt;b&gt;A) Available values-&lt;/b&gt;&lt;br/&gt;1)groupId&lt;br/&gt;2)groupName&lt;br/&gt;3)description&lt;br/&gt;4)startDate&lt;br/&gt;5)ideasCount&lt;br/&gt;6)followersCount&lt;br/&gt;7)currentUserFollowing&lt;br/&gt;8)dueDate&lt;br/&gt;9)participantsCount&lt;br/&gt;10)friendsParticipantsCount&lt;br/&gt;11)friendsIdeasCount | [optional] [default to groupId,groupName,description,startDate]

### Return type

[**VerveResponseGroup**](VerveResponseGroup.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updategroup"></a>
# **UpdateGroup**
> VerveResponseGroup UpdateGroup (long? groupId, string title, string description, string loggedInUserId, string accessToken, string clientToken, string fields = null)

Update group

Allows the user to update the group. Returns the updated group

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class UpdateGroupExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupApi();
            var groupId = 789;  // long? | groupId
            var title = title_example;  // string | title
            var description = description_example;  // string | description
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)groupId<br/>2)groupName<br/>3)description<br/>4)startDate<br/><b>A) Available values-</b><br/>1)groupId<br/>2)groupName<br/>3)description<br/>4)startDate<br/>5)ideasCount<br/>6)followersCount<br/>7)currentUserFollowing<br/>8)dueDate<br/>9)participantsCount<br/>10)friendsParticipantsCount<br/>11)friendsIdeasCount (optional)  (default to groupId,groupName,description,startDate)

            try
            {
                // Update group
                VerveResponseGroup result = apiInstance.UpdateGroup(groupId, title, description, loggedInUserId, accessToken, clientToken, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupApi.UpdateGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **long?**| groupId | 
 **title** | **string**| title | 
 **description** | **string**| description | 
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)groupId&lt;br/&gt;2)groupName&lt;br/&gt;3)description&lt;br/&gt;4)startDate&lt;br/&gt;&lt;b&gt;A) Available values-&lt;/b&gt;&lt;br/&gt;1)groupId&lt;br/&gt;2)groupName&lt;br/&gt;3)description&lt;br/&gt;4)startDate&lt;br/&gt;5)ideasCount&lt;br/&gt;6)followersCount&lt;br/&gt;7)currentUserFollowing&lt;br/&gt;8)dueDate&lt;br/&gt;9)participantsCount&lt;br/&gt;10)friendsParticipantsCount&lt;br/&gt;11)friendsIdeasCount | [optional] [default to groupId,groupName,description,startDate]

### Return type

[**VerveResponseGroup**](VerveResponseGroup.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

