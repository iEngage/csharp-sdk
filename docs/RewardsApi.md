# IO.IEngage.Api.RewardsApi

All URIs are relative to *https://api.iengage.io:8243/api/1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetTopFriends**](RewardsApi.md#gettopfriends) | **GET** /rewards/points/top/friends | Get list of top friends
[**GetTopUsers**](RewardsApi.md#gettopusers) | **GET** /rewards/points/top | Get list of top users
[**GetUserPoints**](RewardsApi.md#getuserpoints) | **GET** /rewards/points/{userId} | Get list of user points


<a name="gettopfriends"></a>
# **GetTopFriends**
> VerveResponseUserPointsList GetTopFriends (long? userId, int? start, int? end, string loggedInUserId, string accessToken, string clientToken)

Get list of top friends

Returns the list top friends

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetTopFriendsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RewardsApi();
            var userId = 789;  // long? | userId
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs

            try
            {
                // Get list of top friends
                VerveResponseUserPointsList result = apiInstance.GetTopFriends(userId, start, end, loggedInUserId, accessToken, clientToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RewardsApi.GetTopFriends: " + e.Message );
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

### Return type

[**VerveResponseUserPointsList**](VerveResponseUserPointsList.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettopusers"></a>
# **GetTopUsers**
> VerveResponseUserPointsList GetTopUsers (int? start, int? end, string loggedInUserId, string accessToken, string clientToken)

Get list of top users

Returns the list of top users

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetTopUsersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RewardsApi();
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs

            try
            {
                // Get list of top users
                VerveResponseUserPointsList result = apiInstance.GetTopUsers(start, end, loggedInUserId, accessToken, clientToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RewardsApi.GetTopUsers: " + e.Message );
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

### Return type

[**VerveResponseUserPointsList**](VerveResponseUserPointsList.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserpoints"></a>
# **GetUserPoints**
> VerveResponseUserPoints GetUserPoints (long? userId, string loggedInUserId, string accessToken, string clientToken)

Get list of user points

Returns the list of user points

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetUserPointsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RewardsApi();
            var userId = 789;  // long? | userId
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs

            try
            {
                // Get list of user points
                VerveResponseUserPoints result = apiInstance.GetUserPoints(userId, loggedInUserId, accessToken, clientToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RewardsApi.GetUserPoints: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **long?**| userId | 
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 

### Return type

[**VerveResponseUserPoints**](VerveResponseUserPoints.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

