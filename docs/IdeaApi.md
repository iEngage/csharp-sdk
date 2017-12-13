# IO.IEngage.Api.IdeaApi

All URIs are relative to *https://api.iengage.io:8243/api/1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteComment**](IdeaApi.md#deletecomment) | **DELETE** /ideas/comments/{commentId} | Delete comment
[**DeleteIdea**](IdeaApi.md#deleteidea) | **DELETE** /ideas/{ideaId} | Delete idea
[**FollowIdea**](IdeaApi.md#followidea) | **POST** /ideas/{ideaId}/follow | Follow idea
[**GetAllIdeas**](IdeaApi.md#getallideas) | **GET** /ideas | Get list of Ideas
[**GetFollowingIdeas**](IdeaApi.md#getfollowingideas) | **GET** /ideas/{userId}/following | Get list of ideas that users are following
[**GetGroupIdeas**](IdeaApi.md#getgroupideas) | **GET** /ideas/getGroupIdeas | Get list of ideas in group
[**GetIdea**](IdeaApi.md#getidea) | **GET** /ideas/{ideaId} | Get idea by id
[**GetIdeaComment**](IdeaApi.md#getideacomment) | **GET** /ideas/{ideaId}/comments | Get list of comments on idea
[**GetIdeaFollowers**](IdeaApi.md#getideafollowers) | **GET** /ideas/{ideaId}/followers | Get list of followers for this idea
[**GetIdeaRatingParameters**](IdeaApi.md#getidearatingparameters) | **GET** /ideas/getIdeaRatingParameters | Get rating parameters of idea by user
[**GetIdeaRatings**](IdeaApi.md#getidearatings) | **GET** /ideas/getIdeaUserRating | Get list of ideas that are rated by user 
[**GetRecommendIdeas**](IdeaApi.md#getrecommendideas) | **GET** /ideas/recommend | Get the list of recommended ideas
[**GetTopIdeas**](IdeaApi.md#gettopideas) | **GET** /ideas/top | Get the list of top ideas
[**GetUserIdeas**](IdeaApi.md#getuserideas) | **GET** /ideas/{userId}/shared | Get list of ideas shared by user
[**GetUserRateIdeas**](IdeaApi.md#getuserrateideas) | **GET** /ideas/{userId}/rated | Get list of ideas rated by user
[**RateIdea**](IdeaApi.md#rateidea) | **POST** /ideas/rateIdea | Rate an idea
[**RateIdea_0**](IdeaApi.md#rateidea_0) | **GET** /ideas/rateIdeaByParameter | Give rating on idea
[**SearchIdeas**](IdeaApi.md#searchideas) | **GET** /ideas/search | Get list of matching ideas
[**ShareFormIdea**](IdeaApi.md#shareformidea) | **POST** /ideas/attachment | Share Idea with attachments
[**ShareIdea**](IdeaApi.md#shareidea) | **POST** /ideas | Share idea  
[**ShareIdeaComment**](IdeaApi.md#shareideacomment) | **POST** /ideas/{ideaId}/comments | Comment on shared idea
[**UnfollowIdea**](IdeaApi.md#unfollowidea) | **POST** /ideas/{ideaId}/unfollow | Unfollow idea
[**UpdateCommet**](IdeaApi.md#updatecommet) | **PUT** /ideas/comments/{commentId} | Update comment
[**UpdateIdea**](IdeaApi.md#updateidea) | **PUT** /ideas/{ideaId} | Update idea


<a name="deletecomment"></a>
# **DeleteComment**
> VerveResponseComment DeleteComment (long? commentId, string loggedInUserId, string accessToken, string clientToken)

Delete comment

Allows the user to delete comment. Returns the deleted comment

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class DeleteCommentExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdeaApi();
            var commentId = 789;  // long? | Comment Id
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs

            try
            {
                // Delete comment
                VerveResponseComment result = apiInstance.DeleteComment(commentId, loggedInUserId, accessToken, clientToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdeaApi.DeleteComment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **commentId** | **long?**| Comment Id | 
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

<a name="deleteidea"></a>
# **DeleteIdea**
> VerveResponseIdea DeleteIdea (long? ideaId, string loggedInUserId, string accessToken, string clientToken, string fields = null)

Delete idea

Allows the user to delete idea. Returns the deleted idea

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class DeleteIdeaExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdeaApi();
            var ideaId = 789;  // long? | ideaId
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)ideaId<br/>2)ideaTitle<br/>3)ideaDescription<br/>4)ideaCreationDate<br/><b>A) Available values-</b><br/>1)ideaId<br/>2)ideaTitle<br/>3)group<br/>4)ideaDescription<br/>5)ideator<br/>6)ideaCreationDate<br/>7)lastModifiedDate<br/>8)ideaStage<br/>9)domain<br/>10)technology<br/>11)accessType<br/>12)videoId<br/>13)activeStatus<br/>14)teamStatus<br/>15)projectStatus<br/>16)totalFollowers<br/>17)totalComments<br/>18)totalBlogs<br/>19)averageRatingScore<br/>20)numberOfRatings<br/>21)currentUserFollowing<br/>22)currentUserRating<br/>23)ideaFileURL<br/>24)sentiment</br>25)entity (optional)  (default to ideaId,ideaTitle,ideaDescription,ideaCreationDate)

            try
            {
                // Delete idea
                VerveResponseIdea result = apiInstance.DeleteIdea(ideaId, loggedInUserId, accessToken, clientToken, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdeaApi.DeleteIdea: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ideaId** | **long?**| ideaId | 
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)ideaId&lt;br/&gt;2)ideaTitle&lt;br/&gt;3)ideaDescription&lt;br/&gt;4)ideaCreationDate&lt;br/&gt;&lt;b&gt;A) Available values-&lt;/b&gt;&lt;br/&gt;1)ideaId&lt;br/&gt;2)ideaTitle&lt;br/&gt;3)group&lt;br/&gt;4)ideaDescription&lt;br/&gt;5)ideator&lt;br/&gt;6)ideaCreationDate&lt;br/&gt;7)lastModifiedDate&lt;br/&gt;8)ideaStage&lt;br/&gt;9)domain&lt;br/&gt;10)technology&lt;br/&gt;11)accessType&lt;br/&gt;12)videoId&lt;br/&gt;13)activeStatus&lt;br/&gt;14)teamStatus&lt;br/&gt;15)projectStatus&lt;br/&gt;16)totalFollowers&lt;br/&gt;17)totalComments&lt;br/&gt;18)totalBlogs&lt;br/&gt;19)averageRatingScore&lt;br/&gt;20)numberOfRatings&lt;br/&gt;21)currentUserFollowing&lt;br/&gt;22)currentUserRating&lt;br/&gt;23)ideaFileURL&lt;br/&gt;24)sentiment&lt;/br&gt;25)entity | [optional] [default to ideaId,ideaTitle,ideaDescription,ideaCreationDate]

### Return type

[**VerveResponseIdea**](VerveResponseIdea.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="followidea"></a>
# **FollowIdea**
> VerveResponseIdea FollowIdea (long? ideaId, string loggedInUserId, string accessToken, string clientToken, string fields = null)

Follow idea

Allows the user to follow idea. Returns the followed idea

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class FollowIdeaExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdeaApi();
            var ideaId = 789;  // long? | idea Id
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)ideaId<br/>2)ideaTitle<br/>3)ideaDescription<br/>4)ideaCreationDate<br/><b>A) Available values-</b><br/>1)ideaId<br/>2)ideaTitle<br/>3)group<br/>4)ideaDescription<br/>5)ideator<br/>6)ideaCreationDate<br/>7)lastModifiedDate<br/>8)ideaStage<br/>9)domain<br/>10)technology<br/>11)accessType<br/>12)videoId<br/>13)activeStatus<br/>14)teamStatus<br/>15)projectStatus<br/>16)totalFollowers<br/>17)totalComments<br/>18)totalBlogs<br/>19)averageRatingScore<br/>20)numberOfRatings<br/>21)currentUserFollowing<br/>22)currentUserRating<br/>23)ideaFileURL<br/>24)sentiment</br>25)entity (optional)  (default to ideaId,ideaTitle,ideaDescription,ideaCreationDate)

            try
            {
                // Follow idea
                VerveResponseIdea result = apiInstance.FollowIdea(ideaId, loggedInUserId, accessToken, clientToken, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdeaApi.FollowIdea: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ideaId** | **long?**| idea Id | 
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)ideaId&lt;br/&gt;2)ideaTitle&lt;br/&gt;3)ideaDescription&lt;br/&gt;4)ideaCreationDate&lt;br/&gt;&lt;b&gt;A) Available values-&lt;/b&gt;&lt;br/&gt;1)ideaId&lt;br/&gt;2)ideaTitle&lt;br/&gt;3)group&lt;br/&gt;4)ideaDescription&lt;br/&gt;5)ideator&lt;br/&gt;6)ideaCreationDate&lt;br/&gt;7)lastModifiedDate&lt;br/&gt;8)ideaStage&lt;br/&gt;9)domain&lt;br/&gt;10)technology&lt;br/&gt;11)accessType&lt;br/&gt;12)videoId&lt;br/&gt;13)activeStatus&lt;br/&gt;14)teamStatus&lt;br/&gt;15)projectStatus&lt;br/&gt;16)totalFollowers&lt;br/&gt;17)totalComments&lt;br/&gt;18)totalBlogs&lt;br/&gt;19)averageRatingScore&lt;br/&gt;20)numberOfRatings&lt;br/&gt;21)currentUserFollowing&lt;br/&gt;22)currentUserRating&lt;br/&gt;23)ideaFileURL&lt;br/&gt;24)sentiment&lt;/br&gt;25)entity | [optional] [default to ideaId,ideaTitle,ideaDescription,ideaCreationDate]

### Return type

[**VerveResponseIdea**](VerveResponseIdea.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallideas"></a>
# **GetAllIdeas**
> VerveResponseIdeaList GetAllIdeas (int? start, int? end, string loggedInUserId, string accessToken, string clientToken, string fields = null)

Get list of Ideas

Returns the list of ideas

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetAllIdeasExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdeaApi();
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)ideaId<br/>2)ideaTitle<br/>3)ideaDescription<br/>4)ideaCreationDate<br/><b>A) Available values-</b><br/>1)ideaId<br/>2)ideaTitle<br/>3)group<br/>4)ideaDescription<br/>5)ideator<br/>6)ideaCreationDate<br/>7)lastModifiedDate<br/>8)ideaStage<br/>9)domain<br/>10)technology<br/>11)accessType<br/>12)videoId<br/>13)activeStatus<br/>14)teamStatus<br/>15)projectStatus<br/>16)totalFollowers<br/>17)totalComments<br/>18)totalBlogs<br/>19)averageRatingScore<br/>20)numberOfRatings<br/>21)currentUserFollowing<br/>22)currentUserRating<br/>23)ideaFileURL<br/>24)sentiment</br>25)entity (optional)  (default to ideaId,ideaTitle,ideaDescription,ideaCreationDate)

            try
            {
                // Get list of Ideas
                VerveResponseIdeaList result = apiInstance.GetAllIdeas(start, end, loggedInUserId, accessToken, clientToken, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdeaApi.GetAllIdeas: " + e.Message );
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

<a name="getfollowingideas"></a>
# **GetFollowingIdeas**
> VerveResponseIdeaList GetFollowingIdeas (long? userId, int? start, int? end, string loggedInUserId, string accessToken, string clientToken, string fields = null)

Get list of ideas that users are following

Returns the list of ideas being followed

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetFollowingIdeasExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdeaApi();
            var userId = 789;  // long? | userId
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)ideaId<br/>2)ideaTitle<br/>3)ideaDescription<br/>4)ideaCreationDate<br/><b>A) Available values-</b><br/>1)ideaId<br/>2)ideaTitle<br/>3)group<br/>4)ideaDescription<br/>5)ideator<br/>6)ideaCreationDate<br/>7)lastModifiedDate<br/>8)ideaStage<br/>9)domain<br/>10)technology<br/>11)accessType<br/>12)videoId<br/>13)activeStatus<br/>14)teamStatus<br/>15)projectStatus<br/>16)totalFollowers<br/>17)totalComments<br/>18)totalBlogs<br/>19)averageRatingScore<br/>20)numberOfRatings<br/>21)currentUserFollowing<br/>22)currentUserRating<br/>23)ideaFileURL<br/>24)sentiment</br>25)entity (optional)  (default to ideaId,ideaTitle,ideaDescription,ideaCreationDate)

            try
            {
                // Get list of ideas that users are following
                VerveResponseIdeaList result = apiInstance.GetFollowingIdeas(userId, start, end, loggedInUserId, accessToken, clientToken, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdeaApi.GetFollowingIdeas: " + e.Message );
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
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)ideaId&lt;br/&gt;2)ideaTitle&lt;br/&gt;3)ideaDescription&lt;br/&gt;4)ideaCreationDate&lt;br/&gt;&lt;b&gt;A) Available values-&lt;/b&gt;&lt;br/&gt;1)ideaId&lt;br/&gt;2)ideaTitle&lt;br/&gt;3)group&lt;br/&gt;4)ideaDescription&lt;br/&gt;5)ideator&lt;br/&gt;6)ideaCreationDate&lt;br/&gt;7)lastModifiedDate&lt;br/&gt;8)ideaStage&lt;br/&gt;9)domain&lt;br/&gt;10)technology&lt;br/&gt;11)accessType&lt;br/&gt;12)videoId&lt;br/&gt;13)activeStatus&lt;br/&gt;14)teamStatus&lt;br/&gt;15)projectStatus&lt;br/&gt;16)totalFollowers&lt;br/&gt;17)totalComments&lt;br/&gt;18)totalBlogs&lt;br/&gt;19)averageRatingScore&lt;br/&gt;20)numberOfRatings&lt;br/&gt;21)currentUserFollowing&lt;br/&gt;22)currentUserRating&lt;br/&gt;23)ideaFileURL&lt;br/&gt;24)sentiment&lt;/br&gt;25)entity | [optional] [default to ideaId,ideaTitle,ideaDescription,ideaCreationDate]

### Return type

[**VerveResponseIdeaList**](VerveResponseIdeaList.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroupideas"></a>
# **GetGroupIdeas**
> VerveResponseIdeaList GetGroupIdeas (long? userId, long? groupId, int? start, int? end, string loggedInUserId, string accessToken, string clientToken, string fields = null)

Get list of ideas in group

Return the ideas list on group

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

            var apiInstance = new IdeaApi();
            var userId = 789;  // long? | user Id
            var groupId = 789;  // long? | group Id
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)ideaId<br/>2)ideaTitle<br/>3)ideaDescription<br/>4)ideaCreationDate<br/><b>A) Available values-</b><br/>1)ideaId<br/>2)ideaTitle<br/>3)group<br/>4)ideaDescription<br/>5)ideator<br/>6)ideaCreationDate<br/>7)lastModifiedDate<br/>8)ideaStage<br/>9)domain<br/>10)technology<br/>11)accessType<br/>12)videoId<br/>13)activeStatus<br/>14)teamStatus<br/>15)projectStatus<br/>16)totalFollowers<br/>17)totalComments<br/>18)totalBlogs<br/>19)averageRatingScore<br/>20)numberOfRatings<br/>21)currentUserFollowing<br/>22)currentUserRating<br/>23)ideaFileURL<br/>24)sentiment</br>25)entity (optional)  (default to ideaId,ideaTitle,ideaDescription,ideaCreationDate)

            try
            {
                // Get list of ideas in group
                VerveResponseIdeaList result = apiInstance.GetGroupIdeas(userId, groupId, start, end, loggedInUserId, accessToken, clientToken, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdeaApi.GetGroupIdeas: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **long?**| user Id | 
 **groupId** | **long?**| group Id | 
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

<a name="getidea"></a>
# **GetIdea**
> VerveResponseIdea GetIdea (long? ideaId, string loggedInUserId, string accessToken, string clientToken, string fields = null)

Get idea by id

Returns the idea by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetIdeaExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdeaApi();
            var ideaId = 789;  // long? | idea Id
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)ideaId<br/>2)ideaTitle<br/>3)ideaDescription<br/>4)ideaCreationDate<br/><b>A) Available values-</b><br/>1)ideaId<br/>2)ideaTitle<br/>3)group<br/>4)ideaDescription<br/>5)ideator<br/>6)ideaCreationDate<br/>7)lastModifiedDate<br/>8)ideaStage<br/>9)domain<br/>10)technology<br/>11)accessType<br/>12)videoId<br/>13)activeStatus<br/>14)teamStatus<br/>15)projectStatus<br/>16)totalFollowers<br/>17)totalComments<br/>18)totalBlogs<br/>19)averageRatingScore<br/>20)numberOfRatings<br/>21)currentUserFollowing<br/>22)currentUserRating<br/>23)ideaFileURL<br/>24)sentiment</br>25)entity (optional)  (default to ideaId,ideaTitle,ideaDescription,ideaCreationDate)

            try
            {
                // Get idea by id
                VerveResponseIdea result = apiInstance.GetIdea(ideaId, loggedInUserId, accessToken, clientToken, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdeaApi.GetIdea: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ideaId** | **long?**| idea Id | 
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)ideaId&lt;br/&gt;2)ideaTitle&lt;br/&gt;3)ideaDescription&lt;br/&gt;4)ideaCreationDate&lt;br/&gt;&lt;b&gt;A) Available values-&lt;/b&gt;&lt;br/&gt;1)ideaId&lt;br/&gt;2)ideaTitle&lt;br/&gt;3)group&lt;br/&gt;4)ideaDescription&lt;br/&gt;5)ideator&lt;br/&gt;6)ideaCreationDate&lt;br/&gt;7)lastModifiedDate&lt;br/&gt;8)ideaStage&lt;br/&gt;9)domain&lt;br/&gt;10)technology&lt;br/&gt;11)accessType&lt;br/&gt;12)videoId&lt;br/&gt;13)activeStatus&lt;br/&gt;14)teamStatus&lt;br/&gt;15)projectStatus&lt;br/&gt;16)totalFollowers&lt;br/&gt;17)totalComments&lt;br/&gt;18)totalBlogs&lt;br/&gt;19)averageRatingScore&lt;br/&gt;20)numberOfRatings&lt;br/&gt;21)currentUserFollowing&lt;br/&gt;22)currentUserRating&lt;br/&gt;23)ideaFileURL&lt;br/&gt;24)sentiment&lt;/br&gt;25)entity | [optional] [default to ideaId,ideaTitle,ideaDescription,ideaCreationDate]

### Return type

[**VerveResponseIdea**](VerveResponseIdea.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getideacomment"></a>
# **GetIdeaComment**
> VerveResponseCommentList GetIdeaComment (long? ideaId, int? start, int? end, string loggedInUserId, string accessToken, string clientToken)

Get list of comments on idea

Returns the list of comments on idea

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetIdeaCommentExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdeaApi();
            var ideaId = 789;  // long? | idea Id
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs

            try
            {
                // Get list of comments on idea
                VerveResponseCommentList result = apiInstance.GetIdeaComment(ideaId, start, end, loggedInUserId, accessToken, clientToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdeaApi.GetIdeaComment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ideaId** | **long?**| idea Id | 
 **start** | **int?**| start, initial value start from 0 | 
 **end** | **int?**| end | 
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

<a name="getideafollowers"></a>
# **GetIdeaFollowers**
> VerveResponseUserList GetIdeaFollowers (long? ideaId, int? start, int? end, string loggedInUserId, string accessToken, string clientToken)

Get list of followers for this idea

Returns the list of followers

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetIdeaFollowersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdeaApi();
            var ideaId = 789;  // long? | ideaId
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs

            try
            {
                // Get list of followers for this idea
                VerveResponseUserList result = apiInstance.GetIdeaFollowers(ideaId, start, end, loggedInUserId, accessToken, clientToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdeaApi.GetIdeaFollowers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ideaId** | **long?**| ideaId | 
 **start** | **int?**| start, initial value start from 0 | 
 **end** | **int?**| end | 
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 

### Return type

[**VerveResponseUserList**](VerveResponseUserList.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getidearatingparameters"></a>
# **GetIdeaRatingParameters**
> VerveResponseString GetIdeaRatingParameters (long? userId, string ideaStage, string loggedInUserId, string accessToken, string clientToken)

Get rating parameters of idea by user

Return the rating parameters of idea by user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetIdeaRatingParametersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdeaApi();
            var userId = 789;  // long? | user Id
            var ideaStage = ideaStage_example;  // string | Idea stages<br/>1)under-consideration <br/>2) shortlisted <br/>3) accepted <br/>4) prototyping
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs

            try
            {
                // Get rating parameters of idea by user
                VerveResponseString result = apiInstance.GetIdeaRatingParameters(userId, ideaStage, loggedInUserId, accessToken, clientToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdeaApi.GetIdeaRatingParameters: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **long?**| user Id | 
 **ideaStage** | **string**| Idea stages&lt;br/&gt;1)under-consideration &lt;br/&gt;2) shortlisted &lt;br/&gt;3) accepted &lt;br/&gt;4) prototyping | 
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 

### Return type

[**VerveResponseString**](VerveResponseString.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getidearatings"></a>
# **GetIdeaRatings**
> VerveResponseIdeaUserRatingList GetIdeaRatings (long? userId, long? ideaId, string ideaStage, string loggedInUserId, string accessToken, string clientToken)

Get list of ideas that are rated by user 

Return the rated ideas list

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetIdeaRatingsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdeaApi();
            var userId = 789;  // long? | user Id
            var ideaId = 789;  // long? | idea Id
            var ideaStage = ideaStage_example;  // string | Idea stages<br/>1)under-consideration <br/>2) shortlisted <br/>3) accepted <br/>4) prototyping
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs

            try
            {
                // Get list of ideas that are rated by user 
                VerveResponseIdeaUserRatingList result = apiInstance.GetIdeaRatings(userId, ideaId, ideaStage, loggedInUserId, accessToken, clientToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdeaApi.GetIdeaRatings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **long?**| user Id | 
 **ideaId** | **long?**| idea Id | 
 **ideaStage** | **string**| Idea stages&lt;br/&gt;1)under-consideration &lt;br/&gt;2) shortlisted &lt;br/&gt;3) accepted &lt;br/&gt;4) prototyping | 
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 

### Return type

[**VerveResponseIdeaUserRatingList**](VerveResponseIdeaUserRatingList.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrecommendideas"></a>
# **GetRecommendIdeas**
> VerveResponseIdeaList GetRecommendIdeas (int? start, int? end, string loggedInUserId, string accessToken, string clientToken, string fields = null)

Get the list of recommended ideas

Returns the list of recommended ideas 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetRecommendIdeasExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdeaApi();
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)ideaId<br/>2)ideaTitle<br/>3)ideaDescription<br/>4)ideaCreationDate<br/><b>A) Available values-</b><br/>1)ideaId<br/>2)ideaTitle<br/>3)group<br/>4)ideaDescription<br/>5)ideator<br/>6)ideaCreationDate<br/>7)lastModifiedDate<br/>8)ideaStage<br/>9)domain<br/>10)technology<br/>11)accessType<br/>12)videoId<br/>13)activeStatus<br/>14)teamStatus<br/>15)projectStatus<br/>16)totalFollowers<br/>17)totalComments<br/>18)totalBlogs<br/>19)averageRatingScore<br/>20)numberOfRatings<br/>21)currentUserFollowing<br/>22)currentUserRating<br/>23)ideaFileURL<br/>24)sentiment</br>25)entity (optional)  (default to ideaId,ideaTitle,ideaDescription,ideaCreationDate)

            try
            {
                // Get the list of recommended ideas
                VerveResponseIdeaList result = apiInstance.GetRecommendIdeas(start, end, loggedInUserId, accessToken, clientToken, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdeaApi.GetRecommendIdeas: " + e.Message );
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

<a name="gettopideas"></a>
# **GetTopIdeas**
> VerveResponseIdeaList GetTopIdeas (int? start, int? end, string loggedInUserId, string accessToken, string clientToken, string fields = null)

Get the list of top ideas

Return the list of top ideas

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetTopIdeasExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdeaApi();
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)ideaId<br/>2)ideaTitle<br/>3)ideaDescription<br/>4)ideaCreationDate<br/><b>A) Available values-</b><br/>1)ideaId<br/>2)ideaTitle<br/>3)group<br/>4)ideaDescription<br/>5)ideator<br/>6)ideaCreationDate<br/>7)lastModifiedDate<br/>8)ideaStage<br/>9)domain<br/>10)technology<br/>11)accessType<br/>12)videoId<br/>13)activeStatus<br/>14)teamStatus<br/>15)projectStatus<br/>16)totalFollowers<br/>17)totalComments<br/>18)totalBlogs<br/>19)averageRatingScore<br/>20)numberOfRatings<br/>21)currentUserFollowing<br/>22)currentUserRating<br/>23)ideaFileURL<br/>24)sentiment</br>25)entity (optional)  (default to ideaId,ideaTitle,ideaDescription,ideaCreationDate)

            try
            {
                // Get the list of top ideas
                VerveResponseIdeaList result = apiInstance.GetTopIdeas(start, end, loggedInUserId, accessToken, clientToken, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdeaApi.GetTopIdeas: " + e.Message );
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

<a name="getuserideas"></a>
# **GetUserIdeas**
> VerveResponseIdeaList GetUserIdeas (long? userId, int? start, int? end, string loggedInUserId, string accessToken, string clientToken, string fields = null)

Get list of ideas shared by user

Returns the list of ideas shared by user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetUserIdeasExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdeaApi();
            var userId = 789;  // long? | userId whose ideas you need
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)ideaId<br/>2)ideaTitle<br/>3)ideaDescription<br/>4)ideaCreationDate<br/><b>A) Available values-</b><br/>1)ideaId<br/>2)ideaTitle<br/>3)group<br/>4)ideaDescription<br/>5)ideator<br/>6)ideaCreationDate<br/>7)lastModifiedDate<br/>8)ideaStage<br/>9)domain<br/>10)technology<br/>11)accessType<br/>12)videoId<br/>13)activeStatus<br/>14)teamStatus<br/>15)projectStatus<br/>16)totalFollowers<br/>17)totalComments<br/>18)totalBlogs<br/>19)averageRatingScore<br/>20)numberOfRatings<br/>21)currentUserFollowing<br/>22)currentUserRating<br/>23)ideaFileURL<br/>24)sentiment</br>25)entity (optional)  (default to ideaId,ideaTitle,ideaDescription,ideaCreationDate)

            try
            {
                // Get list of ideas shared by user
                VerveResponseIdeaList result = apiInstance.GetUserIdeas(userId, start, end, loggedInUserId, accessToken, clientToken, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdeaApi.GetUserIdeas: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **long?**| userId whose ideas you need | 
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

<a name="getuserrateideas"></a>
# **GetUserRateIdeas**
> VerveResponseIdeaList GetUserRateIdeas (long? userId, int? start, int? end, string loggedInUserId, string accessToken, string clientToken, string fields = null)

Get list of ideas rated by user

Return the list of ideas rated by user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetUserRateIdeasExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdeaApi();
            var userId = 789;  // long? | userId whose ideas you need
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)ideaId<br/>2)ideaTitle<br/>3)ideaDescription<br/>4)ideaCreationDate<br/><b>A) Available values-</b><br/>1)ideaId<br/>2)ideaTitle<br/>3)group<br/>4)ideaDescription<br/>5)ideator<br/>6)ideaCreationDate<br/>7)lastModifiedDate<br/>8)ideaStage<br/>9)domain<br/>10)technology<br/>11)accessType<br/>12)videoId<br/>13)activeStatus<br/>14)teamStatus<br/>15)projectStatus<br/>16)totalFollowers<br/>17)totalComments<br/>18)totalBlogs<br/>19)averageRatingScore<br/>20)numberOfRatings<br/>21)currentUserFollowing<br/>22)currentUserRating<br/>23)ideaFileURL<br/>24)sentiment</br>25)entity (optional)  (default to ideaId,ideaTitle,ideaDescription,ideaCreationDate)

            try
            {
                // Get list of ideas rated by user
                VerveResponseIdeaList result = apiInstance.GetUserRateIdeas(userId, start, end, loggedInUserId, accessToken, clientToken, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdeaApi.GetUserRateIdeas: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **long?**| userId whose ideas you need | 
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

<a name="rateidea"></a>
# **RateIdea**
> VerveResponseIdea RateIdea (long? userId, long? ideaId, string ideaStage, string loggedInUserId, string accessToken, string clientToken, string fields = null)

Rate an idea

Allows the user to rate an idea. Returns the rated idea

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class RateIdeaExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdeaApi();
            var userId = 789;  // long? | user Id
            var ideaId = 789;  // long? | idea Id
            var ideaStage = ideaStage_example;  // string | Ideas stage<br/>1)under-consideration <br/>2) shortlisted <br/>3) accepted <br/>4) prototyping
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)ideaId<br/>2)ideaTitle<br/>3)ideaDescription<br/>4)ideaCreationDate<br/><b>A) Available values-</b><br/>1)ideaId<br/>2)ideaTitle<br/>3)group<br/>4)ideaDescription<br/>5)ideator<br/>6)ideaCreationDate<br/>7)lastModifiedDate<br/>8)ideaStage<br/>9)domain<br/>10)technology<br/>11)accessType<br/>12)videoId<br/>13)activeStatus<br/>14)teamStatus<br/>15)projectStatus<br/>16)totalFollowers<br/>17)totalComments<br/>18)totalBlogs<br/>19)averageRatingScore<br/>20)numberOfRatings<br/>21)currentUserFollowing<br/>22)currentUserRating<br/>23)ideaFileURL<br/>24)sentiment</br>25)entity (optional)  (default to ideaId,ideaTitle,ideaDescription,ideaCreationDate)

            try
            {
                // Rate an idea
                VerveResponseIdea result = apiInstance.RateIdea(userId, ideaId, ideaStage, loggedInUserId, accessToken, clientToken, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdeaApi.RateIdea: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **long?**| user Id | 
 **ideaId** | **long?**| idea Id | 
 **ideaStage** | **string**| Ideas stage&lt;br/&gt;1)under-consideration &lt;br/&gt;2) shortlisted &lt;br/&gt;3) accepted &lt;br/&gt;4) prototyping | 
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)ideaId&lt;br/&gt;2)ideaTitle&lt;br/&gt;3)ideaDescription&lt;br/&gt;4)ideaCreationDate&lt;br/&gt;&lt;b&gt;A) Available values-&lt;/b&gt;&lt;br/&gt;1)ideaId&lt;br/&gt;2)ideaTitle&lt;br/&gt;3)group&lt;br/&gt;4)ideaDescription&lt;br/&gt;5)ideator&lt;br/&gt;6)ideaCreationDate&lt;br/&gt;7)lastModifiedDate&lt;br/&gt;8)ideaStage&lt;br/&gt;9)domain&lt;br/&gt;10)technology&lt;br/&gt;11)accessType&lt;br/&gt;12)videoId&lt;br/&gt;13)activeStatus&lt;br/&gt;14)teamStatus&lt;br/&gt;15)projectStatus&lt;br/&gt;16)totalFollowers&lt;br/&gt;17)totalComments&lt;br/&gt;18)totalBlogs&lt;br/&gt;19)averageRatingScore&lt;br/&gt;20)numberOfRatings&lt;br/&gt;21)currentUserFollowing&lt;br/&gt;22)currentUserRating&lt;br/&gt;23)ideaFileURL&lt;br/&gt;24)sentiment&lt;/br&gt;25)entity | [optional] [default to ideaId,ideaTitle,ideaDescription,ideaCreationDate]

### Return type

[**VerveResponseIdea**](VerveResponseIdea.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rateidea_0"></a>
# **RateIdea_0**
> VerveResponseIdea RateIdea_0 (long? userId, long? ideaId, string ideaStage, string _parameter, double? rating, string loggedInUserId, string accessToken, string clientToken, string fields = null)

Give rating on idea

Allows the user to give a rating on idea. Returns the rated idea

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class RateIdea_0Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdeaApi();
            var userId = 789;  // long? | user Id
            var ideaId = 789;  // long? | idea Id
            var ideaStage = ideaStage_example;  // string | Idea stages<br/>1)under-consideration <br/>2) shortlisted <br/>3) accepted <br/>4) prototyping
            var _parameter = _parameter_example;  // string | parameter
            var rating = 1.2;  // double? | rating
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)ideaId<br/>2)ideaTitle<br/>3)ideaDescription<br/>4)ideaCreationDate<br/><b>A) Available values-</b><br/>1)ideaId<br/>2)ideaTitle<br/>3)group<br/>4)ideaDescription<br/>5)ideator<br/>6)ideaCreationDate<br/>7)lastModifiedDate<br/>8)ideaStage<br/>9)domain<br/>10)technology<br/>11)accessType<br/>12)videoId<br/>13)activeStatus<br/>14)teamStatus<br/>15)projectStatus<br/>16)totalFollowers<br/>17)totalComments<br/>18)totalBlogs<br/>19)averageRatingScore<br/>20)numberOfRatings<br/>21)currentUserFollowing<br/>22)currentUserRating<br/>23)ideaFileURL<br/>24)sentiment</br>25)entity (optional)  (default to ideaId,ideaTitle,ideaDescription,ideaCreationDate)

            try
            {
                // Give rating on idea
                VerveResponseIdea result = apiInstance.RateIdea_0(userId, ideaId, ideaStage, _parameter, rating, loggedInUserId, accessToken, clientToken, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdeaApi.RateIdea_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **long?**| user Id | 
 **ideaId** | **long?**| idea Id | 
 **ideaStage** | **string**| Idea stages&lt;br/&gt;1)under-consideration &lt;br/&gt;2) shortlisted &lt;br/&gt;3) accepted &lt;br/&gt;4) prototyping | 
 **_parameter** | **string**| parameter | 
 **rating** | **double?**| rating | 
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)ideaId&lt;br/&gt;2)ideaTitle&lt;br/&gt;3)ideaDescription&lt;br/&gt;4)ideaCreationDate&lt;br/&gt;&lt;b&gt;A) Available values-&lt;/b&gt;&lt;br/&gt;1)ideaId&lt;br/&gt;2)ideaTitle&lt;br/&gt;3)group&lt;br/&gt;4)ideaDescription&lt;br/&gt;5)ideator&lt;br/&gt;6)ideaCreationDate&lt;br/&gt;7)lastModifiedDate&lt;br/&gt;8)ideaStage&lt;br/&gt;9)domain&lt;br/&gt;10)technology&lt;br/&gt;11)accessType&lt;br/&gt;12)videoId&lt;br/&gt;13)activeStatus&lt;br/&gt;14)teamStatus&lt;br/&gt;15)projectStatus&lt;br/&gt;16)totalFollowers&lt;br/&gt;17)totalComments&lt;br/&gt;18)totalBlogs&lt;br/&gt;19)averageRatingScore&lt;br/&gt;20)numberOfRatings&lt;br/&gt;21)currentUserFollowing&lt;br/&gt;22)currentUserRating&lt;br/&gt;23)ideaFileURL&lt;br/&gt;24)sentiment&lt;/br&gt;25)entity | [optional] [default to ideaId,ideaTitle,ideaDescription,ideaCreationDate]

### Return type

[**VerveResponseIdea**](VerveResponseIdea.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchideas"></a>
# **SearchIdeas**
> VerveResponseIdeaList SearchIdeas (string searchText, int? start, int? end, string loggedInUserId, string accessToken, string clientToken, string fields = null)

Get list of matching ideas

Returns the list of matching ideas

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class SearchIdeasExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdeaApi();
            var searchText = searchText_example;  // string | Enter text to be searched
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)ideaId<br/>2)ideaTitle<br/>3)ideaDescription<br/>4)ideaCreationDate<br/><b>A) Available values-</b><br/>1)ideaId<br/>2)ideaTitle<br/>3)group<br/>4)ideaDescription<br/>5)ideator<br/>6)ideaCreationDate<br/>7)lastModifiedDate<br/>8)ideaStage<br/>9)domain<br/>10)technology<br/>11)accessType<br/>12)videoId<br/>13)activeStatus<br/>14)teamStatus<br/>15)projectStatus<br/>16)totalFollowers<br/>17)totalComments<br/>18)totalBlogs<br/>19)averageRatingScore<br/>20)numberOfRatings<br/>21)currentUserFollowing<br/>22)currentUserRating<br/>23)ideaFileURL<br/>24)sentiment</br>25)entity (optional)  (default to ideaId,ideaTitle,ideaDescription,ideaCreationDate)

            try
            {
                // Get list of matching ideas
                VerveResponseIdeaList result = apiInstance.SearchIdeas(searchText, start, end, loggedInUserId, accessToken, clientToken, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdeaApi.SearchIdeas: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchText** | **string**| Enter text to be searched | 
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

<a name="shareformidea"></a>
# **ShareFormIdea**
> VerveResponseIdea ShareFormIdea (string body, string body2, long? body3, List<Attachment> body4, string loggedInUserId, string accessToken, string clientToken)

Share Idea with attachments

Allows the user to share idea with attachments

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class ShareFormIdeaExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdeaApi();
            var body = body_example;  // string | title
            var body2 = body_example;  // string | description
            var body3 = 789;  // long? | groupId
            var body4 = new List<Attachment>(); // List<Attachment> | attachments
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs

            try
            {
                // Share Idea with attachments
                VerveResponseIdea result = apiInstance.ShareFormIdea(body, body2, body3, body4, loggedInUserId, accessToken, clientToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdeaApi.ShareFormIdea: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**| title | 
 **body2** | **string**| description | 
 **body3** | **long?**| groupId | 
 **body4** | [**List&lt;Attachment&gt;**](Attachment.md)| attachments | 
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 

### Return type

[**VerveResponseIdea**](VerveResponseIdea.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="shareidea"></a>
# **ShareIdea**
> VerveResponseIdea ShareIdea (string title, string description, long? groupId, string loggedInUserId, string accessToken, string clientToken)

Share idea  

Allows the user to share idea. Returns the shared idea

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class ShareIdeaExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdeaApi();
            var title = title_example;  // string | title
            var description = description_example;  // string | description
            var groupId = 789;  // long? | group Id
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs

            try
            {
                // Share idea  
                VerveResponseIdea result = apiInstance.ShareIdea(title, description, groupId, loggedInUserId, accessToken, clientToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdeaApi.ShareIdea: " + e.Message );
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
 **groupId** | **long?**| group Id | 
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 

### Return type

[**VerveResponseIdea**](VerveResponseIdea.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="shareideacomment"></a>
# **ShareIdeaComment**
> VerveResponseComment ShareIdeaComment (long? ideaId, string commentText, string loggedInUserId, string accessToken, string clientToken)

Comment on shared idea

Allows the user to comment on shared idea. Returns the comment

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class ShareIdeaCommentExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdeaApi();
            var ideaId = 789;  // long? | idea Id
            var commentText = commentText_example;  // string | comment text
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs

            try
            {
                // Comment on shared idea
                VerveResponseComment result = apiInstance.ShareIdeaComment(ideaId, commentText, loggedInUserId, accessToken, clientToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdeaApi.ShareIdeaComment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ideaId** | **long?**| idea Id | 
 **commentText** | **string**| comment text | 
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

<a name="unfollowidea"></a>
# **UnfollowIdea**
> VerveResponseIdea UnfollowIdea (long? ideaId, string loggedInUserId, string accessToken, string clientToken, string fields = null)

Unfollow idea

Allows the user to unfollow idea. Returns the unfollowed idea

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class UnfollowIdeaExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdeaApi();
            var ideaId = 789;  // long? | idea Id
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)ideaId<br/>2)ideaTitle<br/>3)ideaDescription<br/>4)ideaCreationDate<br/><b>A) Available values-</b><br/>1)ideaId<br/>2)ideaTitle<br/>3)group<br/>4)ideaDescription<br/>5)ideator<br/>6)ideaCreationDate<br/>7)lastModifiedDate<br/>8)ideaStage<br/>9)domain<br/>10)technology<br/>11)accessType<br/>12)videoId<br/>13)activeStatus<br/>14)teamStatus<br/>15)projectStatus<br/>16)totalFollowers<br/>17)totalComments<br/>18)totalBlogs<br/>19)averageRatingScore<br/>20)numberOfRatings<br/>21)currentUserFollowing<br/>22)currentUserRating<br/>23)ideaFileURL<br/>24)sentiment</br>25)entity (optional)  (default to ideaId,ideaTitle,ideaDescription,ideaCreationDate)

            try
            {
                // Unfollow idea
                VerveResponseIdea result = apiInstance.UnfollowIdea(ideaId, loggedInUserId, accessToken, clientToken, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdeaApi.UnfollowIdea: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ideaId** | **long?**| idea Id | 
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)ideaId&lt;br/&gt;2)ideaTitle&lt;br/&gt;3)ideaDescription&lt;br/&gt;4)ideaCreationDate&lt;br/&gt;&lt;b&gt;A) Available values-&lt;/b&gt;&lt;br/&gt;1)ideaId&lt;br/&gt;2)ideaTitle&lt;br/&gt;3)group&lt;br/&gt;4)ideaDescription&lt;br/&gt;5)ideator&lt;br/&gt;6)ideaCreationDate&lt;br/&gt;7)lastModifiedDate&lt;br/&gt;8)ideaStage&lt;br/&gt;9)domain&lt;br/&gt;10)technology&lt;br/&gt;11)accessType&lt;br/&gt;12)videoId&lt;br/&gt;13)activeStatus&lt;br/&gt;14)teamStatus&lt;br/&gt;15)projectStatus&lt;br/&gt;16)totalFollowers&lt;br/&gt;17)totalComments&lt;br/&gt;18)totalBlogs&lt;br/&gt;19)averageRatingScore&lt;br/&gt;20)numberOfRatings&lt;br/&gt;21)currentUserFollowing&lt;br/&gt;22)currentUserRating&lt;br/&gt;23)ideaFileURL&lt;br/&gt;24)sentiment&lt;/br&gt;25)entity | [optional] [default to ideaId,ideaTitle,ideaDescription,ideaCreationDate]

### Return type

[**VerveResponseIdea**](VerveResponseIdea.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecommet"></a>
# **UpdateCommet**
> VerveResponseComment UpdateCommet (long? commentId, string commentText, string loggedInUserId, string accessToken, string clientToken)

Update comment

Allows the user to update comment. Returns the updated comment

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class UpdateCommetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdeaApi();
            var commentId = 789;  // long? | commentId
            var commentText = commentText_example;  // string | Comment text
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs

            try
            {
                // Update comment
                VerveResponseComment result = apiInstance.UpdateCommet(commentId, commentText, loggedInUserId, accessToken, clientToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdeaApi.UpdateCommet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **commentId** | **long?**| commentId | 
 **commentText** | **string**| Comment text | 
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

<a name="updateidea"></a>
# **UpdateIdea**
> VerveResponseIdea UpdateIdea (long? ideaId, string ideaTitle, string ideaDescription, string loggedInUserId, string accessToken, string clientToken, string fields = null)

Update idea

Allows the user to update idea. Returns the updated idea

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class UpdateIdeaExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdeaApi();
            var ideaId = 789;  // long? | ideaId
            var ideaTitle = ideaTitle_example;  // string | Idea Title
            var ideaDescription = ideaDescription_example;  // string | Describe Idea
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)ideaId<br/>2)ideaTitle<br/>3)ideaDescription<br/>4)ideaCreationDate<br/><b>A) Available values-</b><br/>1)ideaId<br/>2)ideaTitle<br/>3)group<br/>4)ideaDescription<br/>5)ideator<br/>6)ideaCreationDate<br/>7)lastModifiedDate<br/>8)ideaStage<br/>9)domain<br/>10)technology<br/>11)accessType<br/>12)videoId<br/>13)activeStatus<br/>14)teamStatus<br/>15)projectStatus<br/>16)totalFollowers<br/>17)totalComments<br/>18)totalBlogs<br/>19)averageRatingScore<br/>20)numberOfRatings<br/>21)currentUserFollowing<br/>22)currentUserRating<br/>23)ideaFileURL<br/>24)sentiment</br>25)entity (optional)  (default to ideaId,ideaTitle,ideaDescription,ideaCreationDate)

            try
            {
                // Update idea
                VerveResponseIdea result = apiInstance.UpdateIdea(ideaId, ideaTitle, ideaDescription, loggedInUserId, accessToken, clientToken, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdeaApi.UpdateIdea: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ideaId** | **long?**| ideaId | 
 **ideaTitle** | **string**| Idea Title | 
 **ideaDescription** | **string**| Describe Idea | 
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)ideaId&lt;br/&gt;2)ideaTitle&lt;br/&gt;3)ideaDescription&lt;br/&gt;4)ideaCreationDate&lt;br/&gt;&lt;b&gt;A) Available values-&lt;/b&gt;&lt;br/&gt;1)ideaId&lt;br/&gt;2)ideaTitle&lt;br/&gt;3)group&lt;br/&gt;4)ideaDescription&lt;br/&gt;5)ideator&lt;br/&gt;6)ideaCreationDate&lt;br/&gt;7)lastModifiedDate&lt;br/&gt;8)ideaStage&lt;br/&gt;9)domain&lt;br/&gt;10)technology&lt;br/&gt;11)accessType&lt;br/&gt;12)videoId&lt;br/&gt;13)activeStatus&lt;br/&gt;14)teamStatus&lt;br/&gt;15)projectStatus&lt;br/&gt;16)totalFollowers&lt;br/&gt;17)totalComments&lt;br/&gt;18)totalBlogs&lt;br/&gt;19)averageRatingScore&lt;br/&gt;20)numberOfRatings&lt;br/&gt;21)currentUserFollowing&lt;br/&gt;22)currentUserRating&lt;br/&gt;23)ideaFileURL&lt;br/&gt;24)sentiment&lt;/br&gt;25)entity | [optional] [default to ideaId,ideaTitle,ideaDescription,ideaCreationDate]

### Return type

[**VerveResponseIdea**](VerveResponseIdea.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

