# IO.IEngage.Api.UserAuthenticationApi

All URIs are relative to *https://api.iengage.io:8243/api/2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddNotificationRegisteredId**](UserAuthenticationApi.md#addnotificationregisteredid) | **POST** /devices | Add device token
[**AddUser**](UserAuthenticationApi.md#adduser) | **POST** /users | Add/Register new user
[**Authenticate**](UserAuthenticationApi.md#authenticate) | **GET** /authenticate | Authenticate User
[**ChangePassword**](UserAuthenticationApi.md#changepassword) | **PUT** /users/password | Change password
[**CreateAssociation**](UserAuthenticationApi.md#createassociation) | **POST** /associations | Create association
[**DeleteUser**](UserAuthenticationApi.md#deleteuser) | **DELETE** /users/{userId} | Delete user
[**GetAssociations**](UserAuthenticationApi.md#getassociations) | **GET** /associations | Get list of associations
[**Logout**](UserAuthenticationApi.md#logout) | **GET** /logout | Logout


<a name="addnotificationregisteredid"></a>
# **AddNotificationRegisteredId**
> bool? AddNotificationRegisteredId (string registeredId, string type, string clientToken, string requesterId = null, string accessToken = null)

Add device token

Add device token to push notification from server

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class AddNotificationRegisteredIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserAuthenticationApi();
            var registeredId = registeredId_example;  // string | Registered device token to be added
            var type = type_example;  // string | Type of device android, ios
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address. (optional) 
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Add device token
                bool? result = apiInstance.AddNotificationRegisteredId(registeredId, type, clientToken, requesterId, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserAuthenticationApi.AddNotificationRegisteredId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **registeredId** | **string**| Registered device token to be added | 
 **type** | **string**| Type of device android, ios | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **requesterId** | **string**| requesterId can be user id OR email address. | [optional] 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

**bool?**

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="adduser"></a>
# **AddUser**
> VerveResponseUser AddUser (string screenName, string emailId, string password, string clientToken, string firstName = null, string middleName = null, string lastName = null, int? birthDay = null, int? birthMonth = null, int? birthYear = null, string additionInformation = null)

Add/Register new user

Add/Register new user. Returns the user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class AddUserExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserAuthenticationApi();
            var screenName = screenName_example;  // string | unique ID of user
            var emailId = emailId_example;  // string | email ID
            var password = password_example;  // string | password
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var firstName = firstName_example;  // string | first name (optional) 
            var middleName = middleName_example;  // string | middle name (optional) 
            var lastName = lastName_example;  // string | last name (optional) 
            var birthDay = 56;  // int? | birth day (optional) 
            var birthMonth = 56;  // int? | birth month (optional) 
            var birthYear = 56;  // int? | birth year (optional) 
            var additionInformation = additionInformation_example;  // string | addition information (optional) 

            try
            {
                // Add/Register new user
                VerveResponseUser result = apiInstance.AddUser(screenName, emailId, password, clientToken, firstName, middleName, lastName, birthDay, birthMonth, birthYear, additionInformation);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserAuthenticationApi.AddUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **screenName** | **string**| unique ID of user | 
 **emailId** | **string**| email ID | 
 **password** | **string**| password | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **firstName** | **string**| first name | [optional] 
 **middleName** | **string**| middle name | [optional] 
 **lastName** | **string**| last name | [optional] 
 **birthDay** | **int?**| birth day | [optional] 
 **birthMonth** | **int?**| birth month | [optional] 
 **birthYear** | **int?**| birth year | [optional] 
 **additionInformation** | **string**| addition information | [optional] 

### Return type

[**VerveResponseUser**](VerveResponseUser.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="authenticate"></a>
# **Authenticate**
> User Authenticate (string userName, string password, string clientToken)

Authenticate User

Authenticate with username & password

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class AuthenticateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserAuthenticationApi();
            var userName = userName_example;  // string | User name
            var password = password_example;  // string | Password
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs

            try
            {
                // Authenticate User
                User result = apiInstance.Authenticate(userName, password, clientToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserAuthenticationApi.Authenticate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userName** | **string**| User name | 
 **password** | **string**| Password | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 

### Return type

[**User**](User.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="changepassword"></a>
# **ChangePassword**
> bool? ChangePassword (string currentPassword, string newPassword, string requesterId, string clientToken, string accessToken = null)

Change password

Allows the user to change password. Returns true if successful

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class ChangePasswordExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserAuthenticationApi();
            var currentPassword = currentPassword_example;  // string | Current password
            var newPassword = newPassword_example;  // string | New password
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Change password
                bool? result = apiInstance.ChangePassword(currentPassword, newPassword, requesterId, clientToken, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserAuthenticationApi.ChangePassword: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currentPassword** | **string**| Current password | 
 **newPassword** | **string**| New password | 
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

<a name="createassociation"></a>
# **CreateAssociation**
> VerveResponseAssociation CreateAssociation (string name, string requesterId, string clientToken, string accessToken = null)

Create association

Create association. Returns the association

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class CreateAssociationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserAuthenticationApi();
            var name = name_example;  // string | association name
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Create association
                VerveResponseAssociation result = apiInstance.CreateAssociation(name, requesterId, clientToken, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserAuthenticationApi.CreateAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| association name | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseAssociation**](VerveResponseAssociation.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteuser"></a>
# **DeleteUser**
> VerveResponseUser DeleteUser (long? userId, string clientToken)

Delete user

Allows the user to delete user. Returns the deleted user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class DeleteUserExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserAuthenticationApi();
            var userId = 789;  // long? | userId
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs

            try
            {
                // Delete user
                VerveResponseUser result = apiInstance.DeleteUser(userId, clientToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserAuthenticationApi.DeleteUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **long?**| userId | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 

### Return type

[**VerveResponseUser**](VerveResponseUser.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getassociations"></a>
# **GetAssociations**
> VerveResponseAssociationList GetAssociations (string requesterId, string clientToken, string accessToken = null)

Get list of associations

Return the list of association

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetAssociationsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserAuthenticationApi();
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get list of associations
                VerveResponseAssociationList result = apiInstance.GetAssociations(requesterId, clientToken, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserAuthenticationApi.GetAssociations: " + e.Message );
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

[**VerveResponseAssociationList**](VerveResponseAssociationList.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="logout"></a>
# **Logout**
> bool? Logout (string requesterId, string clientToken, string accessToken = null)

Logout

Logout rest api session. Returns true if successful

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class LogoutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserAuthenticationApi();
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Logout
                bool? result = apiInstance.Logout(requesterId, clientToken, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserAuthenticationApi.Logout: " + e.Message );
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

**bool?**

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

