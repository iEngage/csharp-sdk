# IO.IEngage.Api.IdeaApi

All URIs are relative to *https://api.iengage.io:8243/api/2.0*

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
> VerveResponseComment DeleteComment (long? commentId, string requesterId, string clientToken, string accessToken = null)

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
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Delete comment
                VerveResponseComment result = apiInstance.DeleteComment(commentId, requesterId, clientToken, accessToken);
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
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

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
> VerveResponseIdea DeleteIdea (long? ideaId, string requesterId, string clientToken, System.IO.Stream file, string fields = null, string accessToken = null)

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
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var file = new System.IO.Stream(); // System.IO.Stream | file
            var fields = fields_example;  // string | Filter fields in result list       /_*   **A) Default values-**      1)ideaId       2)ideaTitle       3)ideaDescription       4)ideaCreationDate        **A) Available values-**        1)ideaId       2)ideaTitle       3)group       4)ideaDescription       5)ideator       6)ideaCreationDate       7)lastModifiedDate       8)ideaStage       9)domain       10)technology       11)accessType       12)videoId       13)activeStatus       14)teamStatus       15)projectStatus       16)totalFollowers       17)totalComments       18)totalBlogs       19)averageRatingScore       20)numberOfRatings       21)currentUserFollowing       22)currentUserRating       23)ideaFileURL       24)sentiment       25)entity   *_/ (optional)  (default to ideaId,ideaTitle,ideaDescription,ideaCreationDate)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Delete idea
                VerveResponseIdea result = apiInstance.DeleteIdea(ideaId, requesterId, clientToken, file, fields, accessToken);
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
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **file** | **System.IO.Stream**| file | 
 **fields** | **string**| Filter fields in result list       /_*   **A) Default values-**      1)ideaId       2)ideaTitle       3)ideaDescription       4)ideaCreationDate        **A) Available values-**        1)ideaId       2)ideaTitle       3)group       4)ideaDescription       5)ideator       6)ideaCreationDate       7)lastModifiedDate       8)ideaStage       9)domain       10)technology       11)accessType       12)videoId       13)activeStatus       14)teamStatus       15)projectStatus       16)totalFollowers       17)totalComments       18)totalBlogs       19)averageRatingScore       20)numberOfRatings       21)currentUserFollowing       22)currentUserRating       23)ideaFileURL       24)sentiment       25)entity   *_/ | [optional] [default to ideaId,ideaTitle,ideaDescription,ideaCreationDate]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

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
> VerveResponseIdea FollowIdea (long? ideaId, string requesterId, string clientToken, string fields = null, string accessToken = null)

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
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list       /_*   **A) Default values-**      1)ideaId       2)ideaTitle       3)ideaDescription       4)ideaCreationDate        **A) Available values-**        1)ideaId       2)ideaTitle       3)group       4)ideaDescription       5)ideator       6)ideaCreationDate       7)lastModifiedDate       8)ideaStage       9)domain       10)technology       11)accessType       12)videoId       13)activeStatus       14)teamStatus       15)projectStatus       16)totalFollowers       17)totalComments       18)totalBlogs       19)averageRatingScore       20)numberOfRatings       21)currentUserFollowing       22)currentUserRating       23)ideaFileURL       24)sentiment       25)entity   *_/ (optional)  (default to ideaId,ideaTitle,ideaDescription,ideaCreationDate)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Follow idea
                VerveResponseIdea result = apiInstance.FollowIdea(ideaId, requesterId, clientToken, fields, accessToken);
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
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list       /_*   **A) Default values-**      1)ideaId       2)ideaTitle       3)ideaDescription       4)ideaCreationDate        **A) Available values-**        1)ideaId       2)ideaTitle       3)group       4)ideaDescription       5)ideator       6)ideaCreationDate       7)lastModifiedDate       8)ideaStage       9)domain       10)technology       11)accessType       12)videoId       13)activeStatus       14)teamStatus       15)projectStatus       16)totalFollowers       17)totalComments       18)totalBlogs       19)averageRatingScore       20)numberOfRatings       21)currentUserFollowing       22)currentUserRating       23)ideaFileURL       24)sentiment       25)entity   *_/ | [optional] [default to ideaId,ideaTitle,ideaDescription,ideaCreationDate]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

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
> VerveResponseIdeaList GetAllIdeas (int? start, int? end, string requesterId, string clientToken, string fields = null, string accessToken = null)

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
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list       /_*   **A) Default values-**      1)ideaId       2)ideaTitle       3)ideaDescription       4)ideaCreationDate        **A) Available values-**        1)ideaId       2)ideaTitle       3)group       4)ideaDescription       5)ideator       6)ideaCreationDate       7)lastModifiedDate       8)ideaStage       9)domain       10)technology       11)accessType       12)videoId       13)activeStatus       14)teamStatus       15)projectStatus       16)totalFollowers       17)totalComments       18)totalBlogs       19)averageRatingScore       20)numberOfRatings       21)currentUserFollowing       22)currentUserRating       23)ideaFileURL       24)sentiment       25)entity   *_/ (optional)  (default to ideaId,ideaTitle,ideaDescription,ideaCreationDate)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get list of Ideas
                VerveResponseIdeaList result = apiInstance.GetAllIdeas(start, end, requesterId, clientToken, fields, accessToken);
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

<a name="getfollowingideas"></a>
# **GetFollowingIdeas**
> VerveResponseIdeaList GetFollowingIdeas (long? userId, int? start, int? end, string requesterId, string clientToken, string fields = null, string accessToken = null)

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
            var userId = 789;  // long? | User Id whose followed ideas want to get.
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list       /_*   **A) Default values-**      1)ideaId       2)ideaTitle       3)ideaDescription       4)ideaCreationDate        **A) Available values-**        1)ideaId       2)ideaTitle       3)group       4)ideaDescription       5)ideator       6)ideaCreationDate       7)lastModifiedDate       8)ideaStage       9)domain       10)technology       11)accessType       12)videoId       13)activeStatus       14)teamStatus       15)projectStatus       16)totalFollowers       17)totalComments       18)totalBlogs       19)averageRatingScore       20)numberOfRatings       21)currentUserFollowing       22)currentUserRating       23)ideaFileURL       24)sentiment       25)entity   *_/ (optional)  (default to ideaId,ideaTitle,ideaDescription,ideaCreationDate)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get list of ideas that users are following
                VerveResponseIdeaList result = apiInstance.GetFollowingIdeas(userId, start, end, requesterId, clientToken, fields, accessToken);
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
 **userId** | **long?**| User Id whose followed ideas want to get. | 
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

<a name="getgroupideas"></a>
# **GetGroupIdeas**
> VerveResponseIdeaList GetGroupIdeas (long? userId, long? groupId, int? start, int? end, string requesterId, string clientToken, string fields = null, string accessToken = null)

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
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list       /_*   **A) Default values-**      1)ideaId       2)ideaTitle       3)ideaDescription       4)ideaCreationDate        **A) Available values-**        1)ideaId       2)ideaTitle       3)group       4)ideaDescription       5)ideator       6)ideaCreationDate       7)lastModifiedDate       8)ideaStage       9)domain       10)technology       11)accessType       12)videoId       13)activeStatus       14)teamStatus       15)projectStatus       16)totalFollowers       17)totalComments       18)totalBlogs       19)averageRatingScore       20)numberOfRatings       21)currentUserFollowing       22)currentUserRating       23)ideaFileURL       24)sentiment       25)entity   *_/ (optional)  (default to ideaId,ideaTitle,ideaDescription,ideaCreationDate)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get list of ideas in group
                VerveResponseIdeaList result = apiInstance.GetGroupIdeas(userId, groupId, start, end, requesterId, clientToken, fields, accessToken);
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

<a name="getidea"></a>
# **GetIdea**
> VerveResponseIdea GetIdea (long? ideaId, string requesterId, string clientToken, string fields = null, string accessToken = null)

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
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list       /_*   **A) Default values-**      1)ideaId       2)ideaTitle       3)ideaDescription       4)ideaCreationDate        **A) Available values-**        1)ideaId       2)ideaTitle       3)group       4)ideaDescription       5)ideator       6)ideaCreationDate       7)lastModifiedDate       8)ideaStage       9)domain       10)technology       11)accessType       12)videoId       13)activeStatus       14)teamStatus       15)projectStatus       16)totalFollowers       17)totalComments       18)totalBlogs       19)averageRatingScore       20)numberOfRatings       21)currentUserFollowing       22)currentUserRating       23)ideaFileURL       24)sentiment       25)entity   *_/ (optional)  (default to ideaId,ideaTitle,ideaDescription,ideaCreationDate)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get idea by id
                VerveResponseIdea result = apiInstance.GetIdea(ideaId, requesterId, clientToken, fields, accessToken);
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
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list       /_*   **A) Default values-**      1)ideaId       2)ideaTitle       3)ideaDescription       4)ideaCreationDate        **A) Available values-**        1)ideaId       2)ideaTitle       3)group       4)ideaDescription       5)ideator       6)ideaCreationDate       7)lastModifiedDate       8)ideaStage       9)domain       10)technology       11)accessType       12)videoId       13)activeStatus       14)teamStatus       15)projectStatus       16)totalFollowers       17)totalComments       18)totalBlogs       19)averageRatingScore       20)numberOfRatings       21)currentUserFollowing       22)currentUserRating       23)ideaFileURL       24)sentiment       25)entity   *_/ | [optional] [default to ideaId,ideaTitle,ideaDescription,ideaCreationDate]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

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
> VerveResponseCommentList GetIdeaComment (long? ideaId, int? start, int? end, string requesterId, string clientToken, string accessToken = null)

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
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get list of comments on idea
                VerveResponseCommentList result = apiInstance.GetIdeaComment(ideaId, start, end, requesterId, clientToken, accessToken);
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

<a name="getideafollowers"></a>
# **GetIdeaFollowers**
> VerveResponseUserList GetIdeaFollowers (long? ideaId, int? start, int? end, string requesterId, string clientToken, string accessToken = null)

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
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get list of followers for this idea
                VerveResponseUserList result = apiInstance.GetIdeaFollowers(ideaId, start, end, requesterId, clientToken, accessToken);
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
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

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
> VerveResponseString GetIdeaRatingParameters (long? userId, string ideaStage, string requesterId, string clientToken, string accessToken = null)

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
            var ideaStage = ideaStage_example;  // string |  /_* Idea stages     1)under-consideration      2) shortlisted      3) accepted      4) prototyping  *_/
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get rating parameters of idea by user
                VerveResponseString result = apiInstance.GetIdeaRatingParameters(userId, ideaStage, requesterId, clientToken, accessToken);
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
 **ideaStage** | **string**|  /_* Idea stages     1)under-consideration      2) shortlisted      3) accepted      4) prototyping  *_/ | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

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
> VerveResponseIdeaUserRatingList GetIdeaRatings (long? userId, long? ideaId, string ideaStage, string requesterId, string clientToken, string accessToken = null)

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
            var ideaStage = ideaStage_example;  // string |  /_* Idea stages     1)under-consideration      2) shortlisted      3) accepted      4) prototyping  *_/
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get list of ideas that are rated by user 
                VerveResponseIdeaUserRatingList result = apiInstance.GetIdeaRatings(userId, ideaId, ideaStage, requesterId, clientToken, accessToken);
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
 **ideaStage** | **string**|  /_* Idea stages     1)under-consideration      2) shortlisted      3) accepted      4) prototyping  *_/ | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

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
> VerveResponseIdeaList GetRecommendIdeas (int? start, int? end, string requesterId, string clientToken, string fields = null, string accessToken = null)

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
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list       /_*   **A) Default values-**      1)ideaId       2)ideaTitle       3)ideaDescription       4)ideaCreationDate        **A) Available values-**        1)ideaId       2)ideaTitle       3)group       4)ideaDescription       5)ideator       6)ideaCreationDate       7)lastModifiedDate       8)ideaStage       9)domain       10)technology       11)accessType       12)videoId       13)activeStatus       14)teamStatus       15)projectStatus       16)totalFollowers       17)totalComments       18)totalBlogs       19)averageRatingScore       20)numberOfRatings       21)currentUserFollowing       22)currentUserRating       23)ideaFileURL       24)sentiment       25)entity   *_/ (optional)  (default to ideaId,ideaTitle,ideaDescription,ideaCreationDate)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get the list of recommended ideas
                VerveResponseIdeaList result = apiInstance.GetRecommendIdeas(start, end, requesterId, clientToken, fields, accessToken);
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

<a name="gettopideas"></a>
# **GetTopIdeas**
> VerveResponseIdeaList GetTopIdeas (int? start, int? end, string requesterId, string clientToken, string fields = null, string accessToken = null)

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
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list       /_*   **A) Default values-**      1)ideaId       2)ideaTitle       3)ideaDescription       4)ideaCreationDate        **A) Available values-**        1)ideaId       2)ideaTitle       3)group       4)ideaDescription       5)ideator       6)ideaCreationDate       7)lastModifiedDate       8)ideaStage       9)domain       10)technology       11)accessType       12)videoId       13)activeStatus       14)teamStatus       15)projectStatus       16)totalFollowers       17)totalComments       18)totalBlogs       19)averageRatingScore       20)numberOfRatings       21)currentUserFollowing       22)currentUserRating       23)ideaFileURL       24)sentiment       25)entity   *_/ (optional)  (default to ideaId,ideaTitle,ideaDescription,ideaCreationDate)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get the list of top ideas
                VerveResponseIdeaList result = apiInstance.GetTopIdeas(start, end, requesterId, clientToken, fields, accessToken);
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

<a name="getuserideas"></a>
# **GetUserIdeas**
> VerveResponseIdeaList GetUserIdeas (long? userId, int? start, int? end, string requesterId, string clientToken, string fields = null, string accessToken = null)

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
            var userId = 789;  // long? | userId whose shared ideas want to get
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list       /_*   **A) Default values-**      1)ideaId       2)ideaTitle       3)ideaDescription       4)ideaCreationDate        **A) Available values-**        1)ideaId       2)ideaTitle       3)group       4)ideaDescription       5)ideator       6)ideaCreationDate       7)lastModifiedDate       8)ideaStage       9)domain       10)technology       11)accessType       12)videoId       13)activeStatus       14)teamStatus       15)projectStatus       16)totalFollowers       17)totalComments       18)totalBlogs       19)averageRatingScore       20)numberOfRatings       21)currentUserFollowing       22)currentUserRating       23)ideaFileURL       24)sentiment       25)entity   *_/ (optional)  (default to ideaId,ideaTitle,ideaDescription,ideaCreationDate)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get list of ideas shared by user
                VerveResponseIdeaList result = apiInstance.GetUserIdeas(userId, start, end, requesterId, clientToken, fields, accessToken);
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
 **userId** | **long?**| userId whose shared ideas want to get | 
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

<a name="getuserrateideas"></a>
# **GetUserRateIdeas**
> VerveResponseIdeaList GetUserRateIdeas (long? userId, int? start, int? end, string requesterId, string clientToken, string fields = null, string accessToken = null)

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
            var userId = 789;  // long? | userId whose rated ideas want to get
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list       /_*   **A) Default values-**      1)ideaId       2)ideaTitle       3)ideaDescription       4)ideaCreationDate        **A) Available values-**        1)ideaId       2)ideaTitle       3)group       4)ideaDescription       5)ideator       6)ideaCreationDate       7)lastModifiedDate       8)ideaStage       9)domain       10)technology       11)accessType       12)videoId       13)activeStatus       14)teamStatus       15)projectStatus       16)totalFollowers       17)totalComments       18)totalBlogs       19)averageRatingScore       20)numberOfRatings       21)currentUserFollowing       22)currentUserRating       23)ideaFileURL       24)sentiment       25)entity   *_/ (optional)  (default to ideaId,ideaTitle,ideaDescription,ideaCreationDate)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get list of ideas rated by user
                VerveResponseIdeaList result = apiInstance.GetUserRateIdeas(userId, start, end, requesterId, clientToken, fields, accessToken);
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
 **userId** | **long?**| userId whose rated ideas want to get | 
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

<a name="rateidea"></a>
# **RateIdea**
> VerveResponseIdea RateIdea (long? userId, long? ideaId, string ideaStage, string requesterId, string clientToken, string fields = null, string accessToken = null)

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
            var ideaStage = ideaStage_example;  // string |  /_* Ideas stage      1)under-consideration      2) shortlisted      3) accepted      4) prototyping  *_/
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list       /_*   **A) Default values-**      1)ideaId       2)ideaTitle       3)ideaDescription       4)ideaCreationDate        **A) Available values-**        1)ideaId       2)ideaTitle       3)group       4)ideaDescription       5)ideator       6)ideaCreationDate       7)lastModifiedDate       8)ideaStage       9)domain       10)technology       11)accessType       12)videoId       13)activeStatus       14)teamStatus       15)projectStatus       16)totalFollowers       17)totalComments       18)totalBlogs       19)averageRatingScore       20)numberOfRatings       21)currentUserFollowing       22)currentUserRating       23)ideaFileURL       24)sentiment       25)entity   *_/ (optional)  (default to ideaId,ideaTitle,ideaDescription,ideaCreationDate)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Rate an idea
                VerveResponseIdea result = apiInstance.RateIdea(userId, ideaId, ideaStage, requesterId, clientToken, fields, accessToken);
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
 **ideaStage** | **string**|  /_* Ideas stage      1)under-consideration      2) shortlisted      3) accepted      4) prototyping  *_/ | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list       /_*   **A) Default values-**      1)ideaId       2)ideaTitle       3)ideaDescription       4)ideaCreationDate        **A) Available values-**        1)ideaId       2)ideaTitle       3)group       4)ideaDescription       5)ideator       6)ideaCreationDate       7)lastModifiedDate       8)ideaStage       9)domain       10)technology       11)accessType       12)videoId       13)activeStatus       14)teamStatus       15)projectStatus       16)totalFollowers       17)totalComments       18)totalBlogs       19)averageRatingScore       20)numberOfRatings       21)currentUserFollowing       22)currentUserRating       23)ideaFileURL       24)sentiment       25)entity   *_/ | [optional] [default to ideaId,ideaTitle,ideaDescription,ideaCreationDate]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

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
> VerveResponseIdea RateIdea_0 (long? userId, long? ideaId, string ideaStage, string parameter, double? rating, string requesterId, string clientToken, string fields = null, string accessToken = null)

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
            var ideaStage = ideaStage_example;  // string |  /_* Idea stages      1)under-consideration      2) shortlisted      3) accepted      4) prototyping  *_/
            var parameter = parameter_example;  // string | parameter
            var rating = 1.2;  // double? | rating
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list       /_*   **A) Default values-**      1)ideaId       2)ideaTitle       3)ideaDescription       4)ideaCreationDate        **A) Available values-**        1)ideaId       2)ideaTitle       3)group       4)ideaDescription       5)ideator       6)ideaCreationDate       7)lastModifiedDate       8)ideaStage       9)domain       10)technology       11)accessType       12)videoId       13)activeStatus       14)teamStatus       15)projectStatus       16)totalFollowers       17)totalComments       18)totalBlogs       19)averageRatingScore       20)numberOfRatings       21)currentUserFollowing       22)currentUserRating       23)ideaFileURL       24)sentiment       25)entity   *_/ (optional)  (default to ideaId,ideaTitle,ideaDescription,ideaCreationDate)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Give rating on idea
                VerveResponseIdea result = apiInstance.RateIdea_0(userId, ideaId, ideaStage, parameter, rating, requesterId, clientToken, fields, accessToken);
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
 **ideaStage** | **string**|  /_* Idea stages      1)under-consideration      2) shortlisted      3) accepted      4) prototyping  *_/ | 
 **parameter** | **string**| parameter | 
 **rating** | **double?**| rating | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list       /_*   **A) Default values-**      1)ideaId       2)ideaTitle       3)ideaDescription       4)ideaCreationDate        **A) Available values-**        1)ideaId       2)ideaTitle       3)group       4)ideaDescription       5)ideator       6)ideaCreationDate       7)lastModifiedDate       8)ideaStage       9)domain       10)technology       11)accessType       12)videoId       13)activeStatus       14)teamStatus       15)projectStatus       16)totalFollowers       17)totalComments       18)totalBlogs       19)averageRatingScore       20)numberOfRatings       21)currentUserFollowing       22)currentUserRating       23)ideaFileURL       24)sentiment       25)entity   *_/ | [optional] [default to ideaId,ideaTitle,ideaDescription,ideaCreationDate]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

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
> VerveResponseIdeaList SearchIdeas (string searchText, int? start, int? end, string requesterId, string clientToken, string fields = null, string accessToken = null)

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
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list       /_*   **A) Default values-**      1)ideaId       2)ideaTitle       3)ideaDescription       4)ideaCreationDate        **A) Available values-**        1)ideaId       2)ideaTitle       3)group       4)ideaDescription       5)ideator       6)ideaCreationDate       7)lastModifiedDate       8)ideaStage       9)domain       10)technology       11)accessType       12)videoId       13)activeStatus       14)teamStatus       15)projectStatus       16)totalFollowers       17)totalComments       18)totalBlogs       19)averageRatingScore       20)numberOfRatings       21)currentUserFollowing       22)currentUserRating       23)ideaFileURL       24)sentiment       25)entity   *_/ (optional)  (default to ideaId,ideaTitle,ideaDescription,ideaCreationDate)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get list of matching ideas
                VerveResponseIdeaList result = apiInstance.SearchIdeas(searchText, start, end, requesterId, clientToken, fields, accessToken);
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

<a name="shareformidea"></a>
# **ShareFormIdea**
> VerveResponseIdea ShareFormIdea (string title, string description, string groupId, System.IO.Stream file, string loggedInUserId, string accessToken, string clientToken)

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
            var title = title_example;  // string | title
            var description = description_example;  // string | description
            var groupId = groupId_example;  // string | groupId
            var file = new System.IO.Stream(); // System.IO.Stream | file
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs

            try
            {
                // Share Idea with attachments
                VerveResponseIdea result = apiInstance.ShareFormIdea(title, description, groupId, file, loggedInUserId, accessToken, clientToken);
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
 **title** | **string**| title | 
 **description** | **string**| description | 
 **groupId** | **string**| groupId | 
 **file** | **System.IO.Stream**| file | 
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
> VerveResponseIdea ShareIdea (string requesterId, string clientToken, Idea body = null, string accessToken = null)

Share idea  

This service allows a user to share a idea. The following fields(key:value) are required to be present in the Idea JSON object. Refer to the Model & Model Schema of the expected JSON Object for the body of this API.  /_*  **Required fields**      1. ideaTitle      2. ideaDescription      3. group: { groupId }  *_/

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
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var body = new Idea(); // Idea |  (optional) 
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Share idea  
                VerveResponseIdea result = apiInstance.ShareIdea(requesterId, clientToken, body, accessToken);
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
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **body** | [**Idea**](Idea.md)|  | [optional] 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseIdea**](VerveResponseIdea.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="shareideacomment"></a>
# **ShareIdeaComment**
> VerveResponseComment ShareIdeaComment (long? ideaId, string requesterId, string clientToken, Comment body = null, string accessToken = null)

Comment on shared idea

This service allows a user to comment on a idea. The following fields(key:value) are required to be present in the Comment JSON object. Refer to the Model & Model Schema of the expected JSON Object for the body of this API. /_* **Required fields**     1. ideaId (Path Parameter)     2. commentText  *_/

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
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var body = new Comment(); // Comment |  (optional) 
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Comment on shared idea
                VerveResponseComment result = apiInstance.ShareIdeaComment(ideaId, requesterId, clientToken, body, accessToken);
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

<a name="unfollowidea"></a>
# **UnfollowIdea**
> VerveResponseIdea UnfollowIdea (long? ideaId, string requesterId, string clientToken, string fields = null, string accessToken = null)

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
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list       /_*   **A) Default values-**      1)ideaId       2)ideaTitle       3)ideaDescription       4)ideaCreationDate        **A) Available values-**        1)ideaId       2)ideaTitle       3)group       4)ideaDescription       5)ideator       6)ideaCreationDate       7)lastModifiedDate       8)ideaStage       9)domain       10)technology       11)accessType       12)videoId       13)activeStatus       14)teamStatus       15)projectStatus       16)totalFollowers       17)totalComments       18)totalBlogs       19)averageRatingScore       20)numberOfRatings       21)currentUserFollowing       22)currentUserRating       23)ideaFileURL       24)sentiment       25)entity   *_/ (optional)  (default to ideaId,ideaTitle,ideaDescription,ideaCreationDate)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Unfollow idea
                VerveResponseIdea result = apiInstance.UnfollowIdea(ideaId, requesterId, clientToken, fields, accessToken);
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
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list       /_*   **A) Default values-**      1)ideaId       2)ideaTitle       3)ideaDescription       4)ideaCreationDate        **A) Available values-**        1)ideaId       2)ideaTitle       3)group       4)ideaDescription       5)ideator       6)ideaCreationDate       7)lastModifiedDate       8)ideaStage       9)domain       10)technology       11)accessType       12)videoId       13)activeStatus       14)teamStatus       15)projectStatus       16)totalFollowers       17)totalComments       18)totalBlogs       19)averageRatingScore       20)numberOfRatings       21)currentUserFollowing       22)currentUserRating       23)ideaFileURL       24)sentiment       25)entity   *_/ | [optional] [default to ideaId,ideaTitle,ideaDescription,ideaCreationDate]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

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
> VerveResponseComment UpdateCommet (long? commentId, string commentText, string requesterId, string clientToken, string accessToken = null)

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
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Update comment
                VerveResponseComment result = apiInstance.UpdateCommet(commentId, commentText, requesterId, clientToken, accessToken);
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
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

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
> VerveResponseIdea UpdateIdea (long? ideaId, string ideaTitle, string ideaDescription, string requesterId, string clientToken, string fields = null, string accessToken = null)

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
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list       /_*   **A) Default values-**      1)ideaId       2)ideaTitle       3)ideaDescription       4)ideaCreationDate        **A) Available values-**        1)ideaId       2)ideaTitle       3)group       4)ideaDescription       5)ideator       6)ideaCreationDate       7)lastModifiedDate       8)ideaStage       9)domain       10)technology       11)accessType       12)videoId       13)activeStatus       14)teamStatus       15)projectStatus       16)totalFollowers       17)totalComments       18)totalBlogs       19)averageRatingScore       20)numberOfRatings       21)currentUserFollowing       22)currentUserRating       23)ideaFileURL       24)sentiment       25)entity   *_/ (optional)  (default to ideaId,ideaTitle,ideaDescription,ideaCreationDate)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Update idea
                VerveResponseIdea result = apiInstance.UpdateIdea(ideaId, ideaTitle, ideaDescription, requesterId, clientToken, fields, accessToken);
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
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list       /_*   **A) Default values-**      1)ideaId       2)ideaTitle       3)ideaDescription       4)ideaCreationDate        **A) Available values-**        1)ideaId       2)ideaTitle       3)group       4)ideaDescription       5)ideator       6)ideaCreationDate       7)lastModifiedDate       8)ideaStage       9)domain       10)technology       11)accessType       12)videoId       13)activeStatus       14)teamStatus       15)projectStatus       16)totalFollowers       17)totalComments       18)totalBlogs       19)averageRatingScore       20)numberOfRatings       21)currentUserFollowing       22)currentUserRating       23)ideaFileURL       24)sentiment       25)entity   *_/ | [optional] [default to ideaId,ideaTitle,ideaDescription,ideaCreationDate]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseIdea**](VerveResponseIdea.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

