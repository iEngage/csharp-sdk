# IO.IEngage.Api.CollaborationApi

All URIs are relative to *https://api.iengage.io:8243/api/2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddCommentBlog**](CollaborationApi.md#addcommentblog) | **POST** /collaborations/blogs/{blogId}/comments | Comment on posted blog
[**AddCommentDiscussion**](CollaborationApi.md#addcommentdiscussion) | **POST** /collaborations/discussions/{discussionId}/comments | Comment on discussion
[**DeleteBlog**](CollaborationApi.md#deleteblog) | **DELETE** /collaborations/blogs/{blogId} | Delete blog
[**DeleteBlogComment**](CollaborationApi.md#deleteblogcomment) | **DELETE** /collaborations/blogs/comments/{commentId} | Delete blog comment
[**DeleteDiscussion**](CollaborationApi.md#deletediscussion) | **DELETE** /collaborations/discussions/{discussionId} | Delete discussion
[**DeleteDiscussionComment**](CollaborationApi.md#deletediscussioncomment) | **DELETE** /collaborations/discussions/comments/{commentId} | Delete discussion comment
[**GetBlogComments**](CollaborationApi.md#getblogcomments) | **GET** /collaborations/blogs/{blogId}/comments | Get list of comments on blog
[**GetBlogs**](CollaborationApi.md#getblogs) | **GET** /collaborations/blogs | Get list of blogs
[**GetDiscussionComments**](CollaborationApi.md#getdiscussioncomments) | **GET** /collaborations/discussions/{discussionId}/comments | Get list of comments on discussion
[**GetDiscussions**](CollaborationApi.md#getdiscussions) | **GET** /collaborations/discussions | Get list of discussions
[**GetUserSubscribedBlogs**](CollaborationApi.md#getusersubscribedblogs) | **GET** /collaborations/blogs/{userId}/subscribe | Get list of blogs subscribed by user
[**GetUserSubscribedDiscussions**](CollaborationApi.md#getusersubscribeddiscussions) | **GET** /collaborations/discussions/{userId}/subscribe | Get list of discussions subscribed by user
[**PostBlog**](CollaborationApi.md#postblog) | **POST** /collaborations/blogs | Post blog
[**StartDiscussion**](CollaborationApi.md#startdiscussion) | **POST** /collaborations/discussions | Start discussion
[**SubscribeBlog**](CollaborationApi.md#subscribeblog) | **POST** /collaborations/blogs/{blogId}/subscribe | Subscribe blog
[**SubscribeDiscussion**](CollaborationApi.md#subscribediscussion) | **POST** /collaborations/discussions/{discussionId}/subscribe | Subscribe discussion
[**UnsubscribeBlog**](CollaborationApi.md#unsubscribeblog) | **POST** /collaborations/blogs/{blogId}/unsubscribe | Unsubscribe blog
[**UnsubscribeDiscussion**](CollaborationApi.md#unsubscribediscussion) | **POST** /collaborations/discussions/{discussionId}/unsubscribe | Unsubscribe discussion
[**UpdateBlog**](CollaborationApi.md#updateblog) | **PUT** /collaborations/blogs/{blogId} | Update blog
[**UpdateBlogComment**](CollaborationApi.md#updateblogcomment) | **PUT** /collaborations/blogs/comments/{commentId} | Update blog comment
[**UpdateDiscussion**](CollaborationApi.md#updatediscussion) | **PUT** /collaborations/discussions/{discussionId} | Update discussion
[**UpdateDiscussionComment**](CollaborationApi.md#updatediscussioncomment) | **PUT** /collaborations/discussions/comments/{commentId} | Update discussion comment


<a name="addcommentblog"></a>
# **AddCommentBlog**
> VerveResponseComment AddCommentBlog (long? blogId, string requesterId, string clientToken, Comment body = null, string accessToken = null)

Comment on posted blog

This service allows a user to comment on a blog. The following fields(key:value) are required to be present in the Comment JSON object. Refer to the Model & Model Schema of the expected JSON Object for the body of this API. **Required fields**      1. blogId (Path Parameter)     2. commentText

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class AddCommentBlogExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CollaborationApi();
            var blogId = 789;  // long? | blogId
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var body = new Comment(); // Comment |  (optional) 
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Comment on posted blog
                VerveResponseComment result = apiInstance.AddCommentBlog(blogId, requesterId, clientToken, body, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollaborationApi.AddCommentBlog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **blogId** | **long?**| blogId | 
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

<a name="addcommentdiscussion"></a>
# **AddCommentDiscussion**
> VerveResponseComment AddCommentDiscussion (long? discussionId, string requesterId, string clientToken, Comment body = null, string accessToken = null)

Comment on discussion

This service allows a user to comment on a discussion. The following fields(key:value) are required to be present in the Comment JSON object. Refer to the Model & Model Schema of the expected JSON Object for the body of this API. **Required fields**      1. discussionId (Path Parameter)     2. commentText

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class AddCommentDiscussionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CollaborationApi();
            var discussionId = 789;  // long? | discussionId
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var body = new Comment(); // Comment |  (optional) 
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Comment on discussion
                VerveResponseComment result = apiInstance.AddCommentDiscussion(discussionId, requesterId, clientToken, body, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollaborationApi.AddCommentDiscussion: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **discussionId** | **long?**| discussionId | 
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

<a name="deleteblog"></a>
# **DeleteBlog**
> VerveResponseBlog DeleteBlog (long? blogId, string requesterId, string clientToken, string accessToken = null)

Delete blog

Allows the user to delete blog. Returns the deleted blog

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class DeleteBlogExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CollaborationApi();
            var blogId = 789;  // long? | blog Id
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Delete blog
                VerveResponseBlog result = apiInstance.DeleteBlog(blogId, requesterId, clientToken, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollaborationApi.DeleteBlog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **blogId** | **long?**| blog Id | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseBlog**](VerveResponseBlog.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteblogcomment"></a>
# **DeleteBlogComment**
> VerveResponseComment DeleteBlogComment (long? commentId, string requesterId, string clientToken, string accessToken = null)

Delete blog comment

Allows the user to delete blog comment.  Returns the deleted blog comment

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class DeleteBlogCommentExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CollaborationApi();
            var commentId = 789;  // long? | comment Id
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Delete blog comment
                VerveResponseComment result = apiInstance.DeleteBlogComment(commentId, requesterId, clientToken, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollaborationApi.DeleteBlogComment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **commentId** | **long?**| comment Id | 
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

<a name="deletediscussion"></a>
# **DeleteDiscussion**
> VerveResponseDiscussion DeleteDiscussion (long? discussionId, string requesterId, string clientToken, string accessToken = null)

Delete discussion

Allows the user to delete discussion. Returns the deleted discussion

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class DeleteDiscussionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CollaborationApi();
            var discussionId = 789;  // long? | discussion Id
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Delete discussion
                VerveResponseDiscussion result = apiInstance.DeleteDiscussion(discussionId, requesterId, clientToken, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollaborationApi.DeleteDiscussion: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **discussionId** | **long?**| discussion Id | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseDiscussion**](VerveResponseDiscussion.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletediscussioncomment"></a>
# **DeleteDiscussionComment**
> VerveResponseComment DeleteDiscussionComment (long? commentId, string requesterId, string clientToken, string accessToken = null)

Delete discussion comment

Allows the user to delete discussion comment. Returns the deleted discussion comment

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class DeleteDiscussionCommentExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CollaborationApi();
            var commentId = 789;  // long? | comment Id
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Delete discussion comment
                VerveResponseComment result = apiInstance.DeleteDiscussionComment(commentId, requesterId, clientToken, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollaborationApi.DeleteDiscussionComment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **commentId** | **long?**| comment Id | 
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

<a name="getblogcomments"></a>
# **GetBlogComments**
> VerveResponseCommentList GetBlogComments (long? blogId, int? start, int? end, string requesterId, string clientToken, string accessToken = null)

Get list of comments on blog

Returns the list of comments on blog

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetBlogCommentsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CollaborationApi();
            var blogId = 789;  // long? | blogId
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get list of comments on blog
                VerveResponseCommentList result = apiInstance.GetBlogComments(blogId, start, end, requesterId, clientToken, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollaborationApi.GetBlogComments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **blogId** | **long?**| blogId | 
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

<a name="getblogs"></a>
# **GetBlogs**
> VerveResponseBlogList GetBlogs (long? association, int? start, int? end, string requesterId, string clientToken, string fields = null, string accessToken = null)

Get list of blogs

Returns the list of blogs

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetBlogsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CollaborationApi();
            var association = 789;  // long? | association
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list       /_*   **A) Default values -**        1)blogId       2)blogTitle       3)blogDescription       4)createdDate        **A )Available values-**        1)blogId       2)blogTitle       3)blogDescription       4)createdDate       5)user       6)sentiment       7)entity   *_/ (optional)  (default to blogId,blogTitle,blogDescription,createdDate)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get list of blogs
                VerveResponseBlogList result = apiInstance.GetBlogs(association, start, end, requesterId, clientToken, fields, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollaborationApi.GetBlogs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **association** | **long?**| association | 
 **start** | **int?**| start, initial value start from 0 | 
 **end** | **int?**| end | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list       /_*   **A) Default values -**        1)blogId       2)blogTitle       3)blogDescription       4)createdDate        **A )Available values-**        1)blogId       2)blogTitle       3)blogDescription       4)createdDate       5)user       6)sentiment       7)entity   *_/ | [optional] [default to blogId,blogTitle,blogDescription,createdDate]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseBlogList**](VerveResponseBlogList.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdiscussioncomments"></a>
# **GetDiscussionComments**
> VerveResponseCommentList GetDiscussionComments (long? discussionId, int? start, int? end, string requesterId, string clientToken, string accessToken = null)

Get list of comments on discussion

Returns the list of comments on discussion

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetDiscussionCommentsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CollaborationApi();
            var discussionId = 789;  // long? | discussionId
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get list of comments on discussion
                VerveResponseCommentList result = apiInstance.GetDiscussionComments(discussionId, start, end, requesterId, clientToken, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollaborationApi.GetDiscussionComments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **discussionId** | **long?**| discussionId | 
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

<a name="getdiscussions"></a>
# **GetDiscussions**
> VerveResponseDiscussionList GetDiscussions (long? association, int? start, int? end, string requesterId, string clientToken, string fields = null, string accessToken = null)

Get list of discussions

Returns the list of discussions

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetDiscussionsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CollaborationApi();
            var association = 789;  // long? | association
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list        /_*   **A) Default values -**        1)discussionId       2)discussionSubject       3)discussionDescription       4)createdDate        **A) Available values-**        1)discussionId       2)discussionSubject       3)discussionDescription       4)createdDate       5)user       6)sentiment       7)entity   *_/ (optional)  (default to discussionId,discussionSubject,discussionDescription,createdDate )
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get list of discussions
                VerveResponseDiscussionList result = apiInstance.GetDiscussions(association, start, end, requesterId, clientToken, fields, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollaborationApi.GetDiscussions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **association** | **long?**| association | 
 **start** | **int?**| start, initial value start from 0 | 
 **end** | **int?**| end | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list        /_*   **A) Default values -**        1)discussionId       2)discussionSubject       3)discussionDescription       4)createdDate        **A) Available values-**        1)discussionId       2)discussionSubject       3)discussionDescription       4)createdDate       5)user       6)sentiment       7)entity   *_/ | [optional] [default to discussionId,discussionSubject,discussionDescription,createdDate ]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseDiscussionList**](VerveResponseDiscussionList.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusersubscribedblogs"></a>
# **GetUserSubscribedBlogs**
> VerveResponseBlog GetUserSubscribedBlogs (long? userId, int? start, int? end, string requesterId, string clientToken, string fields = null, string accessToken = null)

Get list of blogs subscribed by user

Returns the list of blogs subscribed by user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetUserSubscribedBlogsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CollaborationApi();
            var userId = 789;  // long? | User Id whose subcribtions want tp get. 
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list       /_*   **A) Default values -**        1)blogId       2)blogTitle       3)blogDescription       4)createdDate        **A )Available values-**        1)blogId       2)blogTitle       3)blogDescription       4)createdDate       5)user       6)sentiment       7)entity   *_/ (optional)  (default to blogId,blogTitle,blogDescription,createdDate)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get list of blogs subscribed by user
                VerveResponseBlog result = apiInstance.GetUserSubscribedBlogs(userId, start, end, requesterId, clientToken, fields, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollaborationApi.GetUserSubscribedBlogs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **long?**| User Id whose subcribtions want tp get.  | 
 **start** | **int?**| start, initial value start from 0 | 
 **end** | **int?**| end | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list       /_*   **A) Default values -**        1)blogId       2)blogTitle       3)blogDescription       4)createdDate        **A )Available values-**        1)blogId       2)blogTitle       3)blogDescription       4)createdDate       5)user       6)sentiment       7)entity   *_/ | [optional] [default to blogId,blogTitle,blogDescription,createdDate]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseBlog**](VerveResponseBlog.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusersubscribeddiscussions"></a>
# **GetUserSubscribedDiscussions**
> VerveResponseDiscussionList GetUserSubscribedDiscussions (long? userId, int? start, int? end, string requesterId, string clientToken, string fields = null, string accessToken = null)

Get list of discussions subscribed by user

Returns the list of discussions subscribed by user 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetUserSubscribedDiscussionsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CollaborationApi();
            var userId = 789;  // long? | User Id whose subcribtions want tp get.
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list        /_*   **A) Default values -**        1)discussionId       2)discussionSubject       3)discussionDescription       4)createdDate        **A) Available values-**        1)discussionId       2)discussionSubject       3)discussionDescription       4)createdDate       5)user       6)sentiment       7)entity   *_/ (optional)  (default to discussionId,discussionSubject,discussionDescription,createdDate )
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get list of discussions subscribed by user
                VerveResponseDiscussionList result = apiInstance.GetUserSubscribedDiscussions(userId, start, end, requesterId, clientToken, fields, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollaborationApi.GetUserSubscribedDiscussions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **long?**| User Id whose subcribtions want tp get. | 
 **start** | **int?**| start, initial value start from 0 | 
 **end** | **int?**| end | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list        /_*   **A) Default values -**        1)discussionId       2)discussionSubject       3)discussionDescription       4)createdDate        **A) Available values-**        1)discussionId       2)discussionSubject       3)discussionDescription       4)createdDate       5)user       6)sentiment       7)entity   *_/ | [optional] [default to discussionId,discussionSubject,discussionDescription,createdDate ]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseDiscussionList**](VerveResponseDiscussionList.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postblog"></a>
# **PostBlog**
> VerveResponseBlog PostBlog (string requesterId, string clientToken, Blog body = null, string accessToken = null)

Post blog

This service allows a user to post a blog. The following fields(key:value) are required to be present in the Blog JSON object. Refer to the Model & Model Schema of the expected JSON Object for the body of this API. **Required fields** 1. association      2. title      3. description

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class PostBlogExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CollaborationApi();
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var body = new Blog(); // Blog |  (optional) 
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Post blog
                VerveResponseBlog result = apiInstance.PostBlog(requesterId, clientToken, body, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollaborationApi.PostBlog: " + e.Message );
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
 **body** | [**Blog**](Blog.md)|  | [optional] 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseBlog**](VerveResponseBlog.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="startdiscussion"></a>
# **StartDiscussion**
> VerveResponseDiscussion StartDiscussion (string requesterId, string clientToken, Discussion body = null, string accessToken = null)

Start discussion

This service allows a user to post a discussion. The following fields(key:value) are required to be present in the Discussion JSON object. Refer to the Model & Model Schema of the expected JSON Object for the body of this API. **Required fields**      1. association      2. subject      3. description

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class StartDiscussionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CollaborationApi();
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var body = new Discussion(); // Discussion |  (optional) 
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Start discussion
                VerveResponseDiscussion result = apiInstance.StartDiscussion(requesterId, clientToken, body, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollaborationApi.StartDiscussion: " + e.Message );
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
 **body** | [**Discussion**](Discussion.md)|  | [optional] 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseDiscussion**](VerveResponseDiscussion.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscribeblog"></a>
# **SubscribeBlog**
> VerveResponseBlog SubscribeBlog (long? blogId, string requesterId, string clientToken, string accessToken = null)

Subscribe blog

Allows the user to subscribe to blog. Returns the subscribed blog

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class SubscribeBlogExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CollaborationApi();
            var blogId = 789;  // long? | blogId
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Subscribe blog
                VerveResponseBlog result = apiInstance.SubscribeBlog(blogId, requesterId, clientToken, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollaborationApi.SubscribeBlog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **blogId** | **long?**| blogId | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseBlog**](VerveResponseBlog.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscribediscussion"></a>
# **SubscribeDiscussion**
> VerveResponseDiscussion SubscribeDiscussion (long? discussionId, string requesterId, string clientToken, string accessToken = null)

Subscribe discussion

Allows the user to subscribe to a discussion. Returns the subscribed discussion

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class SubscribeDiscussionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CollaborationApi();
            var discussionId = 789;  // long? | discussionId
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Subscribe discussion
                VerveResponseDiscussion result = apiInstance.SubscribeDiscussion(discussionId, requesterId, clientToken, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollaborationApi.SubscribeDiscussion: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **discussionId** | **long?**| discussionId | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseDiscussion**](VerveResponseDiscussion.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unsubscribeblog"></a>
# **UnsubscribeBlog**
> VerveResponseBlog UnsubscribeBlog (long? blogId, string requesterId, string clientToken, string accessToken = null)

Unsubscribe blog

Allows the user to unsubscribe blog. Returns the unsubscribed blog

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class UnsubscribeBlogExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CollaborationApi();
            var blogId = 789;  // long? | blogId
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Unsubscribe blog
                VerveResponseBlog result = apiInstance.UnsubscribeBlog(blogId, requesterId, clientToken, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollaborationApi.UnsubscribeBlog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **blogId** | **long?**| blogId | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseBlog**](VerveResponseBlog.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unsubscribediscussion"></a>
# **UnsubscribeDiscussion**
> VerveResponseDiscussion UnsubscribeDiscussion (long? discussionId, string requesterId, string clientToken, string accessToken = null)

Unsubscribe discussion

Allows the user to unsubscribe to a discussion. Returns the unsubscribed discussion

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class UnsubscribeDiscussionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CollaborationApi();
            var discussionId = 789;  // long? | discussionId
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Unsubscribe discussion
                VerveResponseDiscussion result = apiInstance.UnsubscribeDiscussion(discussionId, requesterId, clientToken, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollaborationApi.UnsubscribeDiscussion: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **discussionId** | **long?**| discussionId | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseDiscussion**](VerveResponseDiscussion.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateblog"></a>
# **UpdateBlog**
> VerveResponseBlog UpdateBlog (long? blogId, string blogTitle, string blogDescription, string requesterId, string clientToken, string accessToken = null)

Update blog

Allows the user to update blog. Returns the updated blog

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class UpdateBlogExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CollaborationApi();
            var blogId = 789;  // long? | blogId
            var blogTitle = blogTitle_example;  // string | blog title
            var blogDescription = blogDescription_example;  // string | blog description
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Update blog
                VerveResponseBlog result = apiInstance.UpdateBlog(blogId, blogTitle, blogDescription, requesterId, clientToken, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollaborationApi.UpdateBlog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **blogId** | **long?**| blogId | 
 **blogTitle** | **string**| blog title | 
 **blogDescription** | **string**| blog description | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseBlog**](VerveResponseBlog.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateblogcomment"></a>
# **UpdateBlogComment**
> VerveResponseComment UpdateBlogComment (long? commentId, string commentText, string requesterId, string clientToken, string accessToken = null)

Update blog comment

Allows the user to update blog comment. Returns the updated blog comment

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class UpdateBlogCommentExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CollaborationApi();
            var commentId = 789;  // long? | commentId
            var commentText = commentText_example;  // string | comment text
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Update blog comment
                VerveResponseComment result = apiInstance.UpdateBlogComment(commentId, commentText, requesterId, clientToken, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollaborationApi.UpdateBlogComment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **commentId** | **long?**| commentId | 
 **commentText** | **string**| comment text | 
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

<a name="updatediscussion"></a>
# **UpdateDiscussion**
> VerveResponseDiscussion UpdateDiscussion (long? discussionId, string subject, string discussionDescription, string requesterId, string clientToken, string accessToken = null)

Update discussion

Allows the user to update discussion. Returns the updated discussion

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class UpdateDiscussionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CollaborationApi();
            var discussionId = 789;  // long? | discussionId
            var subject = subject_example;  // string | subject
            var discussionDescription = discussionDescription_example;  // string | discussion Description
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Update discussion
                VerveResponseDiscussion result = apiInstance.UpdateDiscussion(discussionId, subject, discussionDescription, requesterId, clientToken, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollaborationApi.UpdateDiscussion: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **discussionId** | **long?**| discussionId | 
 **subject** | **string**| subject | 
 **discussionDescription** | **string**| discussion Description | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseDiscussion**](VerveResponseDiscussion.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatediscussioncomment"></a>
# **UpdateDiscussionComment**
> VerveResponseDiscussion UpdateDiscussionComment (long? commentId, string commentText, string requesterId, string clientToken, string accessToken = null)

Update discussion comment

Allows the user to update discussion comment. Returns the updated discussion comment

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class UpdateDiscussionCommentExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CollaborationApi();
            var commentId = 789;  // long? | commentId
            var commentText = commentText_example;  // string | comment text
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Update discussion comment
                VerveResponseDiscussion result = apiInstance.UpdateDiscussionComment(commentId, commentText, requesterId, clientToken, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollaborationApi.UpdateDiscussionComment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **commentId** | **long?**| commentId | 
 **commentText** | **string**| comment text | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseDiscussion**](VerveResponseDiscussion.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

