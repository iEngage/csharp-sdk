# IO.IEngage.Api.GroupApi

All URIs are relative to *https://api.iengage.io:8243/api/2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateGroup**](GroupApi.md#creategroup) | **POST** /groups | Create group
[**DeleteGroup**](GroupApi.md#deletegroup) | **DELETE** /groups/{groupId} | Delete group
[**FollowGroup**](GroupApi.md#followgroup) | **POST** /groups/{groupId}/follow | Follow group
[**GetGroupFollowers**](GroupApi.md#getgroupfollowers) | **GET** /groups/{groupId}/followers | Get the list of followers for the group
[**GetGroupIdeas**](GroupApi.md#getgroupideas) | **GET** /groups/{groupId}/ideas | Get list of all ideas in a group
[**GetGroups**](GroupApi.md#getgroups) | **GET** /groups | Get the list of groups visible for user
[**GetRecommendationGroup**](GroupApi.md#getrecommendationgroup) | **GET** /groups/recommend | Get list of recommended groups
[**GetUserFollowingGroups**](GroupApi.md#getuserfollowinggroups) | **GET** /groups/{userId}/following | Get list of groups that a user is following
[**SearchGroups**](GroupApi.md#searchgroups) | **GET** /groups/search | Get list of matching groups
[**UnfollowGroup**](GroupApi.md#unfollowgroup) | **POST** /groups/{groupId}/unfollow | Unfollow group
[**UpdateGroup**](GroupApi.md#updategroup) | **PUT** /groups/{groupId} | Update group


<a name="creategroup"></a>
# **CreateGroup**
> VerveResponseGroup CreateGroup (string requesterId, string clientToken, Group body = null, string accessToken = null)

Create group

This service allows a user to create a group. The following fields(key:value) are required to be present in the Group JSON object. Refer to the Model & Model Schema of the expected JSON Object for the body of this API. **Required fields**      1. association      2. groupName      3. description      4. managerId [1,2,..]      5. accessType

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class CreateGroupExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupApi();
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var body = new Group(); // Group |  (optional) 
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Create group
                VerveResponseGroup result = apiInstance.CreateGroup(requesterId, clientToken, body, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupApi.CreateGroup: " + e.Message );
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
 **body** | [**Group**](Group.md)|  | [optional] 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseGroup**](VerveResponseGroup.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletegroup"></a>
# **DeleteGroup**
> VerveResponseGroup DeleteGroup (long? groupId, string requesterId, string clientToken, string fields = null, string accessToken = null)

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
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list        /_*   **A) Default values -**        1)groupId       2)groupName       3)description       4)startDate        **A) Available values-**        1)groupId       2)groupName       3)description       4)startDate       5)ideasCount       6)followersCount       7)currentUserFollowing       8)dueDate       9)participantsCount       10)friendsParticipantsCount       11)friendsIdeasCount   *_/ (optional)  (default to groupId,groupName,description,startDate)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Delete group
                VerveResponseGroup result = apiInstance.DeleteGroup(groupId, requesterId, clientToken, fields, accessToken);
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
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list        /_*   **A) Default values -**        1)groupId       2)groupName       3)description       4)startDate        **A) Available values-**        1)groupId       2)groupName       3)description       4)startDate       5)ideasCount       6)followersCount       7)currentUserFollowing       8)dueDate       9)participantsCount       10)friendsParticipantsCount       11)friendsIdeasCount   *_/ | [optional] [default to groupId,groupName,description,startDate]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

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
> VerveResponseGroup FollowGroup (long? groupId, string requesterId, string clientToken, string fields = null, string accessToken = null)

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
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list        /_*   **A) Default values -**        1)groupId       2)groupName       3)description       4)startDate        **A) Available values-**        1)groupId       2)groupName       3)description       4)startDate       5)ideasCount       6)followersCount       7)currentUserFollowing       8)dueDate       9)participantsCount       10)friendsParticipantsCount       11)friendsIdeasCount   *_/ (optional)  (default to groupId,groupName,description,startDate)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Follow group
                VerveResponseGroup result = apiInstance.FollowGroup(groupId, requesterId, clientToken, fields, accessToken);
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
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list        /_*   **A) Default values -**        1)groupId       2)groupName       3)description       4)startDate        **A) Available values-**        1)groupId       2)groupName       3)description       4)startDate       5)ideasCount       6)followersCount       7)currentUserFollowing       8)dueDate       9)participantsCount       10)friendsParticipantsCount       11)friendsIdeasCount   *_/ | [optional] [default to groupId,groupName,description,startDate]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

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
> VerveResponseUserList GetGroupFollowers (long? groupId, int? start, int? end, string requesterId, string clientToken, string fields = null, string accessToken = null)

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
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list        /_*   **A) Default values -**        1)userId       2)firstName       3)lastName       4)profileImage        **A) Available values-**       1)userId       2)firstName       3)lastName       4)emailId       5)profileImage       6)birthDate        *_/ (optional)  (default to userId,firstName,lastName,profileImage)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get the list of followers for the group
                VerveResponseUserList result = apiInstance.GetGroupFollowers(groupId, start, end, requesterId, clientToken, fields, accessToken);
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
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list        /_*   **A) Default values -**        1)userId       2)firstName       3)lastName       4)profileImage        **A) Available values-**       1)userId       2)firstName       3)lastName       4)emailId       5)profileImage       6)birthDate        *_/ | [optional] [default to userId,firstName,lastName,profileImage]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

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
> VerveResponseIdeaList GetGroupIdeas (long? groupId, int? start, int? end, string requesterId, string clientToken, string fields = null, string accessToken = null)

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
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list       /_*   **A) Default values-**      1)ideaId       2)ideaTitle       3)ideaDescription       4)ideaCreationDate        **A) Available values-**        1)ideaId       2)ideaTitle       3)group       4)ideaDescription       5)ideator       6)ideaCreationDate       7)lastModifiedDate       8)ideaStage       9)domain       10)technology       11)accessType       12)videoId       13)activeStatus       14)teamStatus       15)projectStatus       16)totalFollowers       17)totalComments       18)totalBlogs       19)averageRatingScore       20)numberOfRatings       21)currentUserFollowing       22)currentUserRating       23)ideaFileURL       24)sentiment       25)entity   *_/ (optional)  (default to ideaId,ideaTitle,ideaDescription,ideaCreationDate)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get list of all ideas in a group
                VerveResponseIdeaList result = apiInstance.GetGroupIdeas(groupId, start, end, requesterId, clientToken, fields, accessToken);
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
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list       /_*   **A) Default values-**      1)ideaId       2)ideaTitle       3)ideaDescription       4)ideaCreationDate        **A) Available values-**        1)ideaId       2)ideaTitle       3)group       4)ideaDescription       5)ideator       6)ideaCreationDate       7)lastModifiedDate       8)ideaStage       9)domain       10)technology       11)accessType       12)videoId       13)activeStatus       14)teamStatus       15)projectStatus       16)totalFollowers       17)totalComments       18)totalBlogs       19)averageRatingScore       20)numberOfRatings       21)currentUserFollowing       22)currentUserRating       23)ideaFileURL       24)sentiment       25)entity   *_/ | [optional] [default to ideaId,ideaTitle,ideaDescription,ideaCreationDate]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseIdeaList**](VerveResponseIdeaList.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroups"></a>
# **GetGroups**
> VerveResponseGroupList GetGroups (int? start, int? end, string requesterId, string clientToken, string fields = null, string accessToken = null)

Get the list of groups visible for user

Returns the list of groups

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetGroupsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupApi();
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list        /_*   **A) Default values -**        1)groupId       2)groupName       3)description       4)startDate        **A) Available values-**        1)groupId       2)groupName       3)description       4)startDate       5)ideasCount       6)followersCount       7)currentUserFollowing       8)dueDate       9)participantsCount       10)friendsParticipantsCount       11)friendsIdeasCount   *_/ (optional)  (default to groupId,groupName,description,startDate)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get the list of groups visible for user
                VerveResponseGroupList result = apiInstance.GetGroups(start, end, requesterId, clientToken, fields, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupApi.GetGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **start** | **int?**| start, initial value start from 0 | 
 **end** | **int?**| end | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list        /_*   **A) Default values -**        1)groupId       2)groupName       3)description       4)startDate        **A) Available values-**        1)groupId       2)groupName       3)description       4)startDate       5)ideasCount       6)followersCount       7)currentUserFollowing       8)dueDate       9)participantsCount       10)friendsParticipantsCount       11)friendsIdeasCount   *_/ | [optional] [default to groupId,groupName,description,startDate]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseGroupList**](VerveResponseGroupList.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrecommendationgroup"></a>
# **GetRecommendationGroup**
> VerveResponseGroupList GetRecommendationGroup (int? start, int? end, string requesterId, string clientToken, string fields = null, string accessToken = null)

Get list of recommended groups

Returns the list of recommended groups

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetRecommendationGroupExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupApi();
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list        /_*   **A) Default values -**        1)groupId       2)groupName       3)description       4)startDate        **A) Available values-**        1)groupId       2)groupName       3)description       4)startDate       5)ideasCount       6)followersCount       7)currentUserFollowing       8)dueDate       9)participantsCount       10)friendsParticipantsCount       11)friendsIdeasCount   *_/ (optional)  (default to groupId,groupName,description,startDate)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get list of recommended groups
                VerveResponseGroupList result = apiInstance.GetRecommendationGroup(start, end, requesterId, clientToken, fields, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupApi.GetRecommendationGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **start** | **int?**| start, initial value start from 0 | 
 **end** | **int?**| end | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list        /_*   **A) Default values -**        1)groupId       2)groupName       3)description       4)startDate        **A) Available values-**        1)groupId       2)groupName       3)description       4)startDate       5)ideasCount       6)followersCount       7)currentUserFollowing       8)dueDate       9)participantsCount       10)friendsParticipantsCount       11)friendsIdeasCount   *_/ | [optional] [default to groupId,groupName,description,startDate]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseGroupList**](VerveResponseGroupList.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserfollowinggroups"></a>
# **GetUserFollowingGroups**
> VerveResponseGroupList GetUserFollowingGroups (long? userId, int? start, int? end, string requesterId, string clientToken, string fields = null, string accessToken = null)

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
            var userId = 789;  // long? | User Id whose groups want to get.
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list        /_*   **A) Default values -**        1)groupId       2)groupName       3)description       4)startDate        **A) Available values-**        1)groupId       2)groupName       3)description       4)startDate       5)ideasCount       6)followersCount       7)currentUserFollowing       8)dueDate       9)participantsCount       10)friendsParticipantsCount       11)friendsIdeasCount   *_/ (optional)  (default to groupId,groupName,description,startDate)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get list of groups that a user is following
                VerveResponseGroupList result = apiInstance.GetUserFollowingGroups(userId, start, end, requesterId, clientToken, fields, accessToken);
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
 **userId** | **long?**| User Id whose groups want to get. | 
 **start** | **int?**| start, initial value start from 0 | 
 **end** | **int?**| end | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list        /_*   **A) Default values -**        1)groupId       2)groupName       3)description       4)startDate        **A) Available values-**        1)groupId       2)groupName       3)description       4)startDate       5)ideasCount       6)followersCount       7)currentUserFollowing       8)dueDate       9)participantsCount       10)friendsParticipantsCount       11)friendsIdeasCount   *_/ | [optional] [default to groupId,groupName,description,startDate]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseGroupList**](VerveResponseGroupList.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchgroups"></a>
# **SearchGroups**
> VerveResponseGroupList SearchGroups (string query, int? start, int? end, string requesterId, string clientToken, string fields = null, string accessToken = null)

Get list of matching groups

Returns the list of matching group

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class SearchGroupsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupApi();
            var query = query_example;  // string | query
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list        /_*   **A) Default values -**        1)groupId       2)groupName       3)description       4)startDate        **A) Available values-**        1)groupId       2)groupName       3)description       4)startDate       5)ideasCount       6)followersCount       7)currentUserFollowing       8)dueDate       9)participantsCount       10)friendsParticipantsCount       11)friendsIdeasCount   *_/ (optional)  (default to groupId,groupName,description,startDate)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get list of matching groups
                VerveResponseGroupList result = apiInstance.SearchGroups(query, start, end, requesterId, clientToken, fields, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupApi.SearchGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **query** | **string**| query | 
 **start** | **int?**| start, initial value start from 0 | 
 **end** | **int?**| end | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list        /_*   **A) Default values -**        1)groupId       2)groupName       3)description       4)startDate        **A) Available values-**        1)groupId       2)groupName       3)description       4)startDate       5)ideasCount       6)followersCount       7)currentUserFollowing       8)dueDate       9)participantsCount       10)friendsParticipantsCount       11)friendsIdeasCount   *_/ | [optional] [default to groupId,groupName,description,startDate]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

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
> VerveResponseGroup UnfollowGroup (long? groupId, string requesterId, string clientToken, string fields = null, string accessToken = null)

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
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list        /_*   **A) Default values -**        1)groupId       2)groupName       3)description       4)startDate        **A) Available values-**        1)groupId       2)groupName       3)description       4)startDate       5)ideasCount       6)followersCount       7)currentUserFollowing       8)dueDate       9)participantsCount       10)friendsParticipantsCount       11)friendsIdeasCount   *_/ (optional)  (default to groupId,groupName,description,startDate)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Unfollow group
                VerveResponseGroup result = apiInstance.UnfollowGroup(groupId, requesterId, clientToken, fields, accessToken);
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
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list        /_*   **A) Default values -**        1)groupId       2)groupName       3)description       4)startDate        **A) Available values-**        1)groupId       2)groupName       3)description       4)startDate       5)ideasCount       6)followersCount       7)currentUserFollowing       8)dueDate       9)participantsCount       10)friendsParticipantsCount       11)friendsIdeasCount   *_/ | [optional] [default to groupId,groupName,description,startDate]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

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
> VerveResponseGroup UpdateGroup (long? groupId, string title, string description, string requesterId, string clientToken, string fields = null, string accessToken = null)

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
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list        /_*   **A) Default values -**        1)groupId       2)groupName       3)description       4)startDate        **A) Available values-**        1)groupId       2)groupName       3)description       4)startDate       5)ideasCount       6)followersCount       7)currentUserFollowing       8)dueDate       9)participantsCount       10)friendsParticipantsCount       11)friendsIdeasCount   *_/ (optional)  (default to groupId,groupName,description,startDate)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Update group
                VerveResponseGroup result = apiInstance.UpdateGroup(groupId, title, description, requesterId, clientToken, fields, accessToken);
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
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list        /_*   **A) Default values -**        1)groupId       2)groupName       3)description       4)startDate        **A) Available values-**        1)groupId       2)groupName       3)description       4)startDate       5)ideasCount       6)followersCount       7)currentUserFollowing       8)dueDate       9)participantsCount       10)friendsParticipantsCount       11)friendsIdeasCount   *_/ | [optional] [default to groupId,groupName,description,startDate]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseGroup**](VerveResponseGroup.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

