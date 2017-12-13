# IO.IEngage.Api.AugmentedIntelligenceApi

All URIs are relative to *https://api.iengage.io:8243/api/1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetInteraction**](AugmentedIntelligenceApi.md#getinteraction) | **GET** /machineLearning/interactionType | Get the type of interaction
[**GetPopularTag**](AugmentedIntelligenceApi.md#getpopulartag) | **GET** /analytics/popular/tags | Get list of popular tag of interactions
[**GetSentiment**](AugmentedIntelligenceApi.md#getsentiment) | **GET** /analytics/sentiments | Get sentiment count of interactions
[**GetTagEntitySentiments**](AugmentedIntelligenceApi.md#gettagentitysentiments) | **GET** /analytics/tag/entitySentiment | Get list of tag entity sentiment


<a name="getinteraction"></a>
# **GetInteraction**
> VerveResponseFlowFinder GetInteraction (string text, string loggedInUserId, string accessToken, string clientToken)

Get the type of interaction

Classifies text to question, complaint or suggestion

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetInteractionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AugmentedIntelligenceApi();
            var text = text_example;  // string | Text to be classified
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs

            try
            {
                // Get the type of interaction
                VerveResponseFlowFinder result = apiInstance.GetInteraction(text, loggedInUserId, accessToken, clientToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AugmentedIntelligenceApi.GetInteraction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **text** | **string**| Text to be classified | 
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 

### Return type

[**VerveResponseFlowFinder**](VerveResponseFlowFinder.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpopulartag"></a>
# **GetPopularTag**
> VerveResponseTagList GetPopularTag (long? startTime, long? endTime, int? start, int? end, string loggedInUserId, string accessToken, string clientToken, string interactionType = null, string sentimentType = null, string additionalInformation = null, string association = null, long? categoryId = null)

Get list of popular tag of interactions

Return the most popular tag of given interaction type

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetPopularTagExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AugmentedIntelligenceApi();
            var startTime = 789;  // long? | start time
            var endTime = 789;  // long? | end time
            var start = 56;  // int? | start
            var end = 56;  // int? | end
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var interactionType = interactionType_example;  // string | Interaction Type <br/>1)Question<br/>2)Complaint<br/>3)Idea<br/>4)Blog<br/>5)Discussion (optional) 
            var sentimentType = sentimentType_example;  // string | Sentiment Type <br/>1)Positive<br/>2)Negative<br/> 3)Neutral (optional) 
            var additionalInformation = additionalInformation_example;  // string | additional information (optional) 
            var association = association_example;  // string | association (optional) 
            var categoryId = 789;  // long? | categoryId (optional) 

            try
            {
                // Get list of popular tag of interactions
                VerveResponseTagList result = apiInstance.GetPopularTag(startTime, endTime, start, end, loggedInUserId, accessToken, clientToken, interactionType, sentimentType, additionalInformation, association, categoryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AugmentedIntelligenceApi.GetPopularTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startTime** | **long?**| start time | 
 **endTime** | **long?**| end time | 
 **start** | **int?**| start | 
 **end** | **int?**| end | 
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **interactionType** | **string**| Interaction Type &lt;br/&gt;1)Question&lt;br/&gt;2)Complaint&lt;br/&gt;3)Idea&lt;br/&gt;4)Blog&lt;br/&gt;5)Discussion | [optional] 
 **sentimentType** | **string**| Sentiment Type &lt;br/&gt;1)Positive&lt;br/&gt;2)Negative&lt;br/&gt; 3)Neutral | [optional] 
 **additionalInformation** | **string**| additional information | [optional] 
 **association** | **string**| association | [optional] 
 **categoryId** | **long?**| categoryId | [optional] 

### Return type

[**VerveResponseTagList**](VerveResponseTagList.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsentiment"></a>
# **GetSentiment**
> VerveResponseSentimentAnalytics GetSentiment (long? startTime, long? endTime, string loggedInUserId, string accessToken, string clientToken, string interactionType = null, string additionalInformation = null, string association = null, long? categoryId = null)

Get sentiment count of interactions

Returns the sum of the sentiment count of given interaction type

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetSentimentExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AugmentedIntelligenceApi();
            var startTime = 789;  // long? | start time
            var endTime = 789;  // long? | end time
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var interactionType = interactionType_example;  // string | Interaction Type <br/>1)Question<br/>2)Complaint<br/>3)Idea<br/>4)Blog<br/>5)Discussion (optional) 
            var additionalInformation = additionalInformation_example;  // string | additional information (optional) 
            var association = association_example;  // string | association (optional) 
            var categoryId = 789;  // long? | categoryId (optional) 

            try
            {
                // Get sentiment count of interactions
                VerveResponseSentimentAnalytics result = apiInstance.GetSentiment(startTime, endTime, loggedInUserId, accessToken, clientToken, interactionType, additionalInformation, association, categoryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AugmentedIntelligenceApi.GetSentiment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startTime** | **long?**| start time | 
 **endTime** | **long?**| end time | 
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **interactionType** | **string**| Interaction Type &lt;br/&gt;1)Question&lt;br/&gt;2)Complaint&lt;br/&gt;3)Idea&lt;br/&gt;4)Blog&lt;br/&gt;5)Discussion | [optional] 
 **additionalInformation** | **string**| additional information | [optional] 
 **association** | **string**| association | [optional] 
 **categoryId** | **long?**| categoryId | [optional] 

### Return type

[**VerveResponseSentimentAnalytics**](VerveResponseSentimentAnalytics.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettagentitysentiments"></a>
# **GetTagEntitySentiments**
> VerveResponseEntitySentimentList GetTagEntitySentiments (string tagName, long? startTime, long? endTime, int? start, int? end, string loggedInUserId, string accessToken, string clientToken, string sentimentType = null, string additionalInformation = null, string association = null, string interactionType = null, long? categoryId = null)

Get list of tag entity sentiment

Return the list of tag entity sentiments

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetTagEntitySentimentsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AugmentedIntelligenceApi();
            var tagName = tagName_example;  // string | tag name
            var startTime = 789;  // long? | start time
            var endTime = 789;  // long? | end time
            var start = 56;  // int? | start
            var end = 56;  // int? | end
            var loggedInUserId = loggedInUserId_example;  // string | User id of logged / authenticated user
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var sentimentType = sentimentType_example;  // string | Sentiment Type <br/>1)Positive<br/>2)Negative<br/>3)Neutral (optional) 
            var additionalInformation = additionalInformation_example;  // string | additional information (optional) 
            var association = association_example;  // string | association (optional) 
            var interactionType = interactionType_example;  // string | Interaction Type <br/>1)Question<br/>2)Complaint<br/>3)Idea<br/>4)Blog<br/>5)Discussion (optional) 
            var categoryId = 789;  // long? | categoryId (optional) 

            try
            {
                // Get list of tag entity sentiment
                VerveResponseEntitySentimentList result = apiInstance.GetTagEntitySentiments(tagName, startTime, endTime, start, end, loggedInUserId, accessToken, clientToken, sentimentType, additionalInformation, association, interactionType, categoryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AugmentedIntelligenceApi.GetTagEntitySentiments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tagName** | **string**| tag name | 
 **startTime** | **long?**| start time | 
 **endTime** | **long?**| end time | 
 **start** | **int?**| start | 
 **end** | **int?**| end | 
 **loggedInUserId** | **string**| User id of logged / authenticated user | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **sentimentType** | **string**| Sentiment Type &lt;br/&gt;1)Positive&lt;br/&gt;2)Negative&lt;br/&gt;3)Neutral | [optional] 
 **additionalInformation** | **string**| additional information | [optional] 
 **association** | **string**| association | [optional] 
 **interactionType** | **string**| Interaction Type &lt;br/&gt;1)Question&lt;br/&gt;2)Complaint&lt;br/&gt;3)Idea&lt;br/&gt;4)Blog&lt;br/&gt;5)Discussion | [optional] 
 **categoryId** | **long?**| categoryId | [optional] 

### Return type

[**VerveResponseEntitySentimentList**](VerveResponseEntitySentimentList.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

