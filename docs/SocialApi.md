# IO.IEngage.Api.SocialApi

All URIs are relative to *https://api.iengage.io:8243/api/2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddFriend**](SocialApi.md#addfriend) | **POST** /social/friends/add | Add Friend
[**ConfirmFriendRequest**](SocialApi.md#confirmfriendrequest) | **POST** /social/friends/request/action | confirm/ignore friend request
[**Follow**](SocialApi.md#follow) | **POST** /social/follow | Follow user
[**GetUser**](SocialApi.md#getuser) | **GET** /social/users/{userId} | Get user by id 
[**GetUserDetail**](SocialApi.md#getuserdetail) | **GET** /social/userDetail | Get user details 
[**GetUserFollowers**](SocialApi.md#getuserfollowers) | **GET** /social/followers/{userId} | Get list of followers
[**GetUserFollowing**](SocialApi.md#getuserfollowing) | **GET** /social/following/{userId} | Get list of users that are being followed
[**GetUserFriends**](SocialApi.md#getuserfriends) | **GET** /social/friends{userId} | Get list of friends
[**RemoveFriend**](SocialApi.md#removefriend) | **POST** /social/friends/remove | Remove friend 
[**RequestFriend**](SocialApi.md#requestfriend) | **POST** /social/friends/request | Send friend request
[**RequestsForMe**](SocialApi.md#requestsforme) | **GET** /social/friends/request | Get list of friend requests
[**Unfollow**](SocialApi.md#unfollow) | **POST** /social/unfollow | Unfollow user


<a name="addfriend"></a>
# **AddFriend**
> bool? AddFriend (string id1, string id2, string requesterId, string clientToken, string accessToken = null)

Add Friend

Allows the user to add friend. Returns true if successful

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class AddFriendExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SocialApi();
            var id1 = id1_example;  // string | Enter userId/mailId of the person who wants to add a friend
            var id2 = id2_example;  // string | Enter userId /mailId you want to add in friend list
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Add Friend
                bool? result = apiInstance.AddFriend(id1, id2, requesterId, clientToken, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialApi.AddFriend: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id1** | **string**| Enter userId/mailId of the person who wants to add a friend | 
 **id2** | **string**| Enter userId /mailId you want to add in friend list | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

**bool?**

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="confirmfriendrequest"></a>
# **ConfirmFriendRequest**
> bool? ConfirmFriendRequest (long? userId, int? status, string requesterId, string clientToken, string accessToken = null)

confirm/ignore friend request

Allows the user to confirm/ignore friend request. Returns true if successful

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class ConfirmFriendRequestExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SocialApi();
            var userId = 789;  // long? | userId of user who sent friend request
            var status = 56;  // int? |   /_*  Set Friend Request status      CONFIRM - 1      IGNORE - 2   *_/ 
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // confirm/ignore friend request
                bool? result = apiInstance.ConfirmFriendRequest(userId, status, requesterId, clientToken, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialApi.ConfirmFriendRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **long?**| userId of user who sent friend request | 
 **status** | **int?**|   /_*  Set Friend Request status      CONFIRM - 1      IGNORE - 2   *_/  | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

**bool?**

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="follow"></a>
# **Follow**
> bool? Follow (string follower, string followee, string requesterId, string clientToken, string accessToken = null)

Follow user

Allows to follow a user. Returns true if successful

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class FollowExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SocialApi();
            var follower = follower_example;  // string | Enter the userId/mailId of the follower
            var followee = followee_example;  // string | Enter the userId/mailId of the user the follower wants to follow
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Follow user
                bool? result = apiInstance.Follow(follower, followee, requesterId, clientToken, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialApi.Follow: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **follower** | **string**| Enter the userId/mailId of the follower | 
 **followee** | **string**| Enter the userId/mailId of the user the follower wants to follow | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

**bool?**

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuser"></a>
# **GetUser**
> VerveResponseUser GetUser (long? userId, string requesterId, string clientToken, string fields = null, string accessToken = null)

Get user by id 

Returns the user.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetUserExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SocialApi();
            var userId = 789;  // long? | User Id
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list        /_*   **A) Default values -**        1)userId       2)firstName       3)lastName       4)profileImage        **A) Available values-**       1)userId       2)firstName       3)lastName       4)emailId       5)profileImage       6)birthDate        *_/ (optional)  (default to userId,firstName,lastName,profileImage)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get user by id 
                VerveResponseUser result = apiInstance.GetUser(userId, requesterId, clientToken, fields, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialApi.GetUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **long?**| User Id | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list        /_*   **A) Default values -**        1)userId       2)firstName       3)lastName       4)profileImage        **A) Available values-**       1)userId       2)firstName       3)lastName       4)emailId       5)profileImage       6)birthDate        *_/ | [optional] [default to userId,firstName,lastName,profileImage]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseUser**](VerveResponseUser.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserdetail"></a>
# **GetUserDetail**
> VerveResponseUserDetail GetUserDetail (long? userId, string requesterId, string clientToken, string accessToken = null)

Get user details 

Returns the user details.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetUserDetailExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SocialApi();
            var userId = 789;  // long? | Enter user Id whose details you need
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get user details 
                VerveResponseUserDetail result = apiInstance.GetUserDetail(userId, requesterId, clientToken, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialApi.GetUserDetail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **long?**| Enter user Id whose details you need | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseUserDetail**](VerveResponseUserDetail.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserfollowers"></a>
# **GetUserFollowers**
> VerveResponseUserList GetUserFollowers (long? userId, string requesterId, string clientToken, string fields = null, string accessToken = null)

Get list of followers

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
    public class GetUserFollowersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SocialApi();
            var userId = 789;  // long? | User Id whose followers wants to get.
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list        /_*   **A) Default values -**        1)userId       2)firstName       3)lastName       4)profileImage        **A) Available values-**       1)userId       2)firstName       3)lastName       4)emailId       5)profileImage       6)birthDate        *_/ (optional)  (default to userId,firstName,lastName,profileImage)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get list of followers
                VerveResponseUserList result = apiInstance.GetUserFollowers(userId, requesterId, clientToken, fields, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialApi.GetUserFollowers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **long?**| User Id whose followers wants to get. | 
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

<a name="getuserfollowing"></a>
# **GetUserFollowing**
> VerveResponseUserList GetUserFollowing (long? userId, string requesterId, string clientToken, string fields = null, string accessToken = null)

Get list of users that are being followed

Returns the list of users that are being followed

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetUserFollowingExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SocialApi();
            var userId = 789;  // long? | User Id whose followed list want to get
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list        /_*   **A) Default values -**        1)userId       2)firstName       3)lastName       4)profileImage        **A) Available values-**       1)userId       2)firstName       3)lastName       4)emailId       5)profileImage       6)birthDate        *_/ (optional)  (default to userId,firstName,lastName,profileImage)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get list of users that are being followed
                VerveResponseUserList result = apiInstance.GetUserFollowing(userId, requesterId, clientToken, fields, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialApi.GetUserFollowing: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **long?**| User Id whose followed list want to get | 
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

<a name="getuserfriends"></a>
# **GetUserFriends**
> VerveResponseUserList GetUserFriends (long? userId, string requesterId, string clientToken, string fields = null, string accessToken = null)

Get list of friends

Returns the list of friends

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetUserFriendsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SocialApi();
            var userId = 789;  // long? | userId
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list        /_*   **A) Default values -**        1)userId       2)firstName       3)lastName       4)profileImage        **A) Available values-**       1)userId       2)firstName       3)lastName       4)emailId       5)profileImage       6)birthDate        *_/ (optional)  (default to userId,firstName,lastName,profileImage)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get list of friends
                VerveResponseUserList result = apiInstance.GetUserFriends(userId, requesterId, clientToken, fields, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialApi.GetUserFriends: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **long?**| userId | 
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

<a name="removefriend"></a>
# **RemoveFriend**
> bool? RemoveFriend (string id1, string id2, string requesterId, string clientToken, string accessToken = null)

Remove friend 

Allows the user to remove friend. Returns true if successful

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class RemoveFriendExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SocialApi();
            var id1 = id1_example;  // string | Enter userId/mailId of the person who wants to remove from friend
            var id2 = id2_example;  // string | Enter userId /mailId you want to remove in friend list
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Remove friend 
                bool? result = apiInstance.RemoveFriend(id1, id2, requesterId, clientToken, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialApi.RemoveFriend: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id1** | **string**| Enter userId/mailId of the person who wants to remove from friend | 
 **id2** | **string**| Enter userId /mailId you want to remove in friend list | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

**bool?**

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="requestfriend"></a>
# **RequestFriend**
> bool? RequestFriend (long? userId, string requesterId, string clientToken, string accessToken = null)

Send friend request

Allows user to send a friend request. Returns true if successful

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class RequestFriendExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SocialApi();
            var userId = 789;  // long? | Enter userId /mailId you want to send friend request
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Send friend request
                bool? result = apiInstance.RequestFriend(userId, requesterId, clientToken, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialApi.RequestFriend: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **long?**| Enter userId /mailId you want to send friend request | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

**bool?**

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="requestsforme"></a>
# **RequestsForMe**
> VerveResponseRequestForMeList RequestsForMe (string requesterId, string clientToken, string accessToken = null)

Get list of friend requests

Returns the list of friend requests

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class RequestsForMeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SocialApi();
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get list of friend requests
                VerveResponseRequestForMeList result = apiInstance.RequestsForMe(requesterId, clientToken, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialApi.RequestsForMe: " + e.Message );
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
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseRequestForMeList**](VerveResponseRequestForMeList.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unfollow"></a>
# **Unfollow**
> bool? Unfollow (string unfollower, string unfollowee, string requesterId, string clientToken, string accessToken = null)

Unfollow user

Allows to unfollow user. Returns true if successful

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class UnfollowExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SocialApi();
            var unfollower = unfollower_example;  // string | Enter the userId/mailId of the unfollower
            var unfollowee = unfollowee_example;  // string | Enter the userId/mailId of the user the unfollower wants to unfollow
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Unfollow user
                bool? result = apiInstance.Unfollow(unfollower, unfollowee, requesterId, clientToken, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialApi.Unfollow: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unfollower** | **string**| Enter the userId/mailId of the unfollower | 
 **unfollowee** | **string**| Enter the userId/mailId of the user the unfollower wants to unfollow | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

**bool?**

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

