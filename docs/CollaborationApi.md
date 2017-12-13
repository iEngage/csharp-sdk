# IO.IEngage.Api.CollaborationApi

All URIs are relative to *https://api.iengage.io:8243/api/1.0*

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
> VerveResponseComment AddCommentBlog (long? blogId, string commentText, string loggedInUserId, string accessToken, string clientToken)

Comment on posted blog

Allows the user to give comment on posted Blog. Returns the comment

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
            var commentText = commentText_example;  // string | Comment Text
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs

            try
            {
                // Comment on posted blog
                VerveResponseComment result = apiInstance.AddCommentBlog(blogId, commentText, loggedInUserId, accessToken, clientToken);
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
 **commentText** | **string**| Comment Text | 
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

<a name="addcommentdiscussion"></a>
# **AddCommentDiscussion**
> VerveResponseComment AddCommentDiscussion (long? discussionId, string commentText, string loggedInUserId, string accessToken, string clientToken)

Comment on discussion

Allows the user to comment on discussion. Returns the comment

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
            var commentText = commentText_example;  // string | Comment Text
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs

            try
            {
                // Comment on discussion
                VerveResponseComment result = apiInstance.AddCommentDiscussion(discussionId, commentText, loggedInUserId, accessToken, clientToken);
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
 **commentText** | **string**| Comment Text | 
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

<a name="deleteblog"></a>
# **DeleteBlog**
> VerveResponseBlog DeleteBlog (long? blogId, string loggedInUserId, string accessToken, string clientToken)

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
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs

            try
            {
                // Delete blog
                VerveResponseBlog result = apiInstance.DeleteBlog(blogId, loggedInUserId, accessToken, clientToken);
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
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 

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
> VerveResponseComment DeleteBlogComment (long? commentId, string loggedInUserId, string accessToken, string clientToken)

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
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs

            try
            {
                // Delete blog comment
                VerveResponseComment result = apiInstance.DeleteBlogComment(commentId, loggedInUserId, accessToken, clientToken);
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

<a name="deletediscussion"></a>
# **DeleteDiscussion**
> VerveResponseDiscussion DeleteDiscussion (long? discussionId, string loggedInUserId, string accessToken, string clientToken)

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
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs

            try
            {
                // Delete discussion
                VerveResponseDiscussion result = apiInstance.DeleteDiscussion(discussionId, loggedInUserId, accessToken, clientToken);
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
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 

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
> VerveResponseComment DeleteDiscussionComment (long? commentId, string loggedInUserId, string accessToken, string clientToken)

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
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs

            try
            {
                // Delete discussion comment
                VerveResponseComment result = apiInstance.DeleteDiscussionComment(commentId, loggedInUserId, accessToken, clientToken);
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

<a name="getblogcomments"></a>
# **GetBlogComments**
> VerveResponseCommentList GetBlogComments (long? blogId, int? start, int? end, string loggedInUserId, string accessToken, string clientToken)

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
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs

            try
            {
                // Get list of comments on blog
                VerveResponseCommentList result = apiInstance.GetBlogComments(blogId, start, end, loggedInUserId, accessToken, clientToken);
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

<a name="getblogs"></a>
# **GetBlogs**
> VerveResponseBlogList GetBlogs (long? organizationId, int? start, int? end, string loggedInUserId, string accessToken, string clientToken, string fields = null)

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
            var organizationId = 789;  // long? | organizationId
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)blogId<br/>2)blogTitle<br/>3)blogDescription<br/>4)createdDate<br/><b>A )Available values-</b><br/>1)blogId<br/>2)blogTitle<br/>3)blogDescription<br/>4)createdDate<br/>5)user<br/>6)sentiment</br>7)entity (optional)  (default to blogId,blogTitle,blogDescription,createdDate)

            try
            {
                // Get list of blogs
                VerveResponseBlogList result = apiInstance.GetBlogs(organizationId, start, end, loggedInUserId, accessToken, clientToken, fields);
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
 **organizationId** | **long?**| organizationId | 
 **start** | **int?**| start, initial value start from 0 | 
 **end** | **int?**| end | 
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)blogId&lt;br/&gt;2)blogTitle&lt;br/&gt;3)blogDescription&lt;br/&gt;4)createdDate&lt;br/&gt;&lt;b&gt;A )Available values-&lt;/b&gt;&lt;br/&gt;1)blogId&lt;br/&gt;2)blogTitle&lt;br/&gt;3)blogDescription&lt;br/&gt;4)createdDate&lt;br/&gt;5)user&lt;br/&gt;6)sentiment&lt;/br&gt;7)entity | [optional] [default to blogId,blogTitle,blogDescription,createdDate]

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
> VerveResponseCommentList GetDiscussionComments (long? discussionId, int? start, int? end, string loggedInUserId, string accessToken, string clientToken)

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
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs

            try
            {
                // Get list of comments on discussion
                VerveResponseCommentList result = apiInstance.GetDiscussionComments(discussionId, start, end, loggedInUserId, accessToken, clientToken);
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

<a name="getdiscussions"></a>
# **GetDiscussions**
> VerveResponseDiscussionList GetDiscussions (long? organizationId, int? start, int? end, string loggedInUserId, string accessToken, string clientToken, string fields = null)

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
            var organizationId = 789;  // long? | organizationId
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)discussionId<br/>2)discussionSubject<br/>3)discussionDescription<br/>4)createdDate<br/><b>A) Available values-</b><br/>1)discussionId<br/>2)discussionSubject<br/>3)discussionDescription<br/>4)createdDate<br/>5)user<br/>6)sentiment</br>7)entity (optional)  (default to discussionId,discussionSubject,discussionDescription,createdDate )

            try
            {
                // Get list of discussions
                VerveResponseDiscussionList result = apiInstance.GetDiscussions(organizationId, start, end, loggedInUserId, accessToken, clientToken, fields);
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
 **organizationId** | **long?**| organizationId | 
 **start** | **int?**| start, initial value start from 0 | 
 **end** | **int?**| end | 
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)discussionId&lt;br/&gt;2)discussionSubject&lt;br/&gt;3)discussionDescription&lt;br/&gt;4)createdDate&lt;br/&gt;&lt;b&gt;A) Available values-&lt;/b&gt;&lt;br/&gt;1)discussionId&lt;br/&gt;2)discussionSubject&lt;br/&gt;3)discussionDescription&lt;br/&gt;4)createdDate&lt;br/&gt;5)user&lt;br/&gt;6)sentiment&lt;/br&gt;7)entity | [optional] [default to discussionId,discussionSubject,discussionDescription,createdDate ]

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
> VerveResponseBlog GetUserSubscribedBlogs (long? userId, int? start, int? end, string loggedInUserId, string accessToken, string clientToken, string fields = null)

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
            var userId = 789;  // long? | userId
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)blogId<br/>2)blogTitle<br/>3)blogDescription<br/>4)createdDate<br/><b>A )Available values-</b><br/>1)blogId<br/>2)blogTitle<br/>3)blogDescription<br/>4)createdDate<br/>5)user<br/>6)sentiment</br>7)entity (optional)  (default to blogId,blogTitle,blogDescription,createdDate)

            try
            {
                // Get list of blogs subscribed by user
                VerveResponseBlog result = apiInstance.GetUserSubscribedBlogs(userId, start, end, loggedInUserId, accessToken, clientToken, fields);
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
 **userId** | **long?**| userId | 
 **start** | **int?**| start, initial value start from 0 | 
 **end** | **int?**| end | 
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)blogId&lt;br/&gt;2)blogTitle&lt;br/&gt;3)blogDescription&lt;br/&gt;4)createdDate&lt;br/&gt;&lt;b&gt;A )Available values-&lt;/b&gt;&lt;br/&gt;1)blogId&lt;br/&gt;2)blogTitle&lt;br/&gt;3)blogDescription&lt;br/&gt;4)createdDate&lt;br/&gt;5)user&lt;br/&gt;6)sentiment&lt;/br&gt;7)entity | [optional] [default to blogId,blogTitle,blogDescription,createdDate]

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
> VerveResponseGroupList GetUserSubscribedDiscussions (long? userId, int? start, int? end, string loggedInUserId, string accessToken, string clientToken, string fields = null)

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
            var userId = 789;  // long? | userId
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)discussionId<br/>2)discussionSubject<br/>3)discussionDescdescription<br/>4)startDate<br/><b>A) Available values-</b><br/>1)groupId<br/>2)groupName<br/>3)description<br/>4)startDate<br/>5)ideasCount<br/>6)followersCount<br/>7)currentUserFollowing<br/>8)dueDate<br/>9)participantsCount<br/>10)friendsParticipantsCount<br/>11)friendsIdeasCount (optional)  (default to groupId,groupName,description,startDate)

            try
            {
                // Get list of discussions subscribed by user
                VerveResponseGroupList result = apiInstance.GetUserSubscribedDiscussions(userId, start, end, loggedInUserId, accessToken, clientToken, fields);
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
 **userId** | **long?**| userId | 
 **start** | **int?**| start, initial value start from 0 | 
 **end** | **int?**| end | 
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)discussionId&lt;br/&gt;2)discussionSubject&lt;br/&gt;3)discussionDescdescription&lt;br/&gt;4)startDate&lt;br/&gt;&lt;b&gt;A) Available values-&lt;/b&gt;&lt;br/&gt;1)groupId&lt;br/&gt;2)groupName&lt;br/&gt;3)description&lt;br/&gt;4)startDate&lt;br/&gt;5)ideasCount&lt;br/&gt;6)followersCount&lt;br/&gt;7)currentUserFollowing&lt;br/&gt;8)dueDate&lt;br/&gt;9)participantsCount&lt;br/&gt;10)friendsParticipantsCount&lt;br/&gt;11)friendsIdeasCount | [optional] [default to groupId,groupName,description,startDate]

### Return type

[**VerveResponseGroupList**](VerveResponseGroupList.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postblog"></a>
# **PostBlog**
> VerveResponseBlog PostBlog (long? organizationId, string blogTitle, string blogDescription, string loggedInUserId, string accessToken, string clientToken)

Post blog

Allows the user to post a blog. Returns the posted blog

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
            var organizationId = 789;  // long? | organizationId
            var blogTitle = blogTitle_example;  // string | blogTitle
            var blogDescription = blogDescription_example;  // string | blogDescription
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs

            try
            {
                // Post blog
                VerveResponseBlog result = apiInstance.PostBlog(organizationId, blogTitle, blogDescription, loggedInUserId, accessToken, clientToken);
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
 **organizationId** | **long?**| organizationId | 
 **blogTitle** | **string**| blogTitle | 
 **blogDescription** | **string**| blogDescription | 
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 

### Return type

[**VerveResponseBlog**](VerveResponseBlog.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="startdiscussion"></a>
# **StartDiscussion**
> VerveResponseDiscussion StartDiscussion (long? organizationId, string subject, string description, string loggedInUserId, string accessToken, string clientToken)

Start discussion

Allows the user to start discussion. Returns the started discussion

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
            var organizationId = 789;  // long? | organizationId
            var subject = subject_example;  // string | subject
            var description = description_example;  // string | description
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs

            try
            {
                // Start discussion
                VerveResponseDiscussion result = apiInstance.StartDiscussion(organizationId, subject, description, loggedInUserId, accessToken, clientToken);
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
 **organizationId** | **long?**| organizationId | 
 **subject** | **string**| subject | 
 **description** | **string**| description | 
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 

### Return type

[**VerveResponseDiscussion**](VerveResponseDiscussion.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscribeblog"></a>
# **SubscribeBlog**
> VerveResponseBlog SubscribeBlog (long? blogId, string loggedInUserId, string accessToken, string clientToken)

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
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs

            try
            {
                // Subscribe blog
                VerveResponseBlog result = apiInstance.SubscribeBlog(blogId, loggedInUserId, accessToken, clientToken);
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
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 

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
> VerveResponseDiscussion SubscribeDiscussion (long? discussionId, string loggedInUserId, string accessToken, string clientToken)

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
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs

            try
            {
                // Subscribe discussion
                VerveResponseDiscussion result = apiInstance.SubscribeDiscussion(discussionId, loggedInUserId, accessToken, clientToken);
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
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 

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
> VerveResponseBlog UnsubscribeBlog (long? blogId, string loggedInUserId, string accessToken, string clientToken)

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
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs

            try
            {
                // Unsubscribe blog
                VerveResponseBlog result = apiInstance.UnsubscribeBlog(blogId, loggedInUserId, accessToken, clientToken);
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
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 

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
> VerveResponseDiscussion UnsubscribeDiscussion (long? discussionId, string loggedInUserId, string accessToken, string clientToken)

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
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs

            try
            {
                // Unsubscribe discussion
                VerveResponseDiscussion result = apiInstance.UnsubscribeDiscussion(discussionId, loggedInUserId, accessToken, clientToken);
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
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 

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
> VerveResponseBlog UpdateBlog (long? blogId, string blogTitle, string blogDescription, string loggedInUserId, string accessToken, string clientToken)

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
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs

            try
            {
                // Update blog
                VerveResponseBlog result = apiInstance.UpdateBlog(blogId, blogTitle, blogDescription, loggedInUserId, accessToken, clientToken);
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
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 

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
> VerveResponseComment UpdateBlogComment (long? commentId, string commentText, string loggedInUserId, string accessToken, string clientToken)

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
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs

            try
            {
                // Update blog comment
                VerveResponseComment result = apiInstance.UpdateBlogComment(commentId, commentText, loggedInUserId, accessToken, clientToken);
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

<a name="updatediscussion"></a>
# **UpdateDiscussion**
> VerveResponseDiscussion UpdateDiscussion (long? discussionId, string subject, string discussionDescription, string loggedInUserId, string accessToken, string clientToken)

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
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs

            try
            {
                // Update discussion
                VerveResponseDiscussion result = apiInstance.UpdateDiscussion(discussionId, subject, discussionDescription, loggedInUserId, accessToken, clientToken);
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
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 

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
> VerveResponseDiscussion UpdateDiscussionComment (long? commentId, string commentText, string loggedInUserId, string accessToken, string clientToken)

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
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs

            try
            {
                // Update discussion comment
                VerveResponseDiscussion result = apiInstance.UpdateDiscussionComment(commentId, commentText, loggedInUserId, accessToken, clientToken);
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
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 

### Return type

[**VerveResponseDiscussion**](VerveResponseDiscussion.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

