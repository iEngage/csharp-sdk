# IO.IEngage.Api.AugmentedIntelligenceApi

All URIs are relative to *https://api.iengage.io:8243/api/2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Classify**](AugmentedIntelligenceApi.md#classify) | **POST** /ml/classifier/classify | Classifies using your classifier
[**GetEntities**](AugmentedIntelligenceApi.md#getentities) | **POST** /ml/ner/classify | Extracts entities from text
[**GetInteractionType**](AugmentedIntelligenceApi.md#getinteractiontype) | **POST** /ml/interactionType | Returns the type of interaction
[**GetKeywords**](AugmentedIntelligenceApi.md#getkeywords) | **POST** /ml/keywords | Returns the keywords of the sentence
[**GetPopularTag**](AugmentedIntelligenceApi.md#getpopulartag) | **GET** /analytics/popular/tags | Get list of popular tag of interactions
[**GetSentiment**](AugmentedIntelligenceApi.md#getsentiment) | **GET** /analytics/sentiments | Get sentiment count of interactions
[**GetTagEntitySentiments**](AugmentedIntelligenceApi.md#gettagentitysentiments) | **GET** /analytics/tag/entitySentiment | Get list of tag entity sentiment
[**Sentiment**](AugmentedIntelligenceApi.md#sentiment) | **POST** /ml/sentiment | Analyzes the sentiment of the content


<a name="classify"></a>
# **Classify**
> VerveResponseTextClassificationList Classify (string text, long? id, string clientToken)

Classifies using your classifier

Returns a classification based on your training in the Classifier Admin Panel. More than one classifier may be trained. Use the correct ID from the Admin Panel to get the corresponding classification

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class ClassifyExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AugmentedIntelligenceApi();
            var text = text_example;  // string | Text you want classified
            var id = 789;  // long? | Classifier ID from the Admin Panel
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs

            try
            {
                // Classifies using your classifier
                VerveResponseTextClassificationList result = apiInstance.Classify(text, id, clientToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AugmentedIntelligenceApi.Classify: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **text** | **string**| Text you want classified | 
 **id** | **long?**| Classifier ID from the Admin Panel | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 

### Return type

[**VerveResponseTextClassificationList**](VerveResponseTextClassificationList.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getentities"></a>
# **GetEntities**
> VerveResponseEntitiesClassifiedList GetEntities (long? id, string text, string clientToken)

Extracts entities from text

Classifies each word of the text as an entity based on your training in the NER Admin panel. More than one classifier may be trained. Use the correct ID from the Admin Panel to get the corresponding classification

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetEntitiesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AugmentedIntelligenceApi();
            var id = 789;  // long? | NER ID present from the Admin Panel
            var text = text_example;  // string | Text from which to extract entities
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs

            try
            {
                // Extracts entities from text
                VerveResponseEntitiesClassifiedList result = apiInstance.GetEntities(id, text, clientToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AugmentedIntelligenceApi.GetEntities: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| NER ID present from the Admin Panel | 
 **text** | **string**| Text from which to extract entities | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 

### Return type

[**VerveResponseEntitiesClassifiedList**](VerveResponseEntitiesClassifiedList.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinteractiontype"></a>
# **GetInteractionType**
> VerveResponseFlowFinder GetInteractionType (string text, string clientToken)

Returns the type of interaction

Classifies text to question, complaint, appreciation, suggestion or comment. This is the default classification we assign to the type field of an Interaction

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetInteractionTypeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AugmentedIntelligenceApi();
            var text = text_example;  // string | Text that is to be classified by type
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs

            try
            {
                // Returns the type of interaction
                VerveResponseFlowFinder result = apiInstance.GetInteractionType(text, clientToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AugmentedIntelligenceApi.GetInteractionType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **text** | **string**| Text that is to be classified by type | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 

### Return type

[**VerveResponseFlowFinder**](VerveResponseFlowFinder.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getkeywords"></a>
# **GetKeywords**
> VerveResponseKeyword GetKeywords (string text, string clientToken)

Returns the keywords of the sentence

Extracts the keywords of a sentence. This could be used for example as tags.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetKeywordsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AugmentedIntelligenceApi();
            var text = text_example;  // string | Content whose keywords are to be found out
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs

            try
            {
                // Returns the keywords of the sentence
                VerveResponseKeyword result = apiInstance.GetKeywords(text, clientToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AugmentedIntelligenceApi.GetKeywords: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **text** | **string**| Content whose keywords are to be found out | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 

### Return type

[**VerveResponseKeyword**](VerveResponseKeyword.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpopulartag"></a>
# **GetPopularTag**
> VerveResponseTagList GetPopularTag (long? startTime, long? endTime, int? start, int? end, string requesterId, string clientToken, string interactionType = null, string sentimentType = null, string additionalInformation = null, string association = null, long? categoryId = null, string accessToken = null)

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
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var interactionType = interactionType_example;  // string | Interaction Type <br/>1)Question<br/>2)Complaint<br/>3)Idea<br/>4)Blog<br/>5)Discussion (optional) 
            var sentimentType = sentimentType_example;  // string | Sentiment Type <br/>1)Positive<br/>2)Negative<br/> 3)Neutral (optional) 
            var additionalInformation = additionalInformation_example;  // string | additional information (optional) 
            var association = association_example;  // string | association (optional) 
            var categoryId = 789;  // long? | categoryId (optional) 
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get list of popular tag of interactions
                VerveResponseTagList result = apiInstance.GetPopularTag(startTime, endTime, start, end, requesterId, clientToken, interactionType, sentimentType, additionalInformation, association, categoryId, accessToken);
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
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **interactionType** | **string**| Interaction Type &lt;br/&gt;1)Question&lt;br/&gt;2)Complaint&lt;br/&gt;3)Idea&lt;br/&gt;4)Blog&lt;br/&gt;5)Discussion | [optional] 
 **sentimentType** | **string**| Sentiment Type &lt;br/&gt;1)Positive&lt;br/&gt;2)Negative&lt;br/&gt; 3)Neutral | [optional] 
 **additionalInformation** | **string**| additional information | [optional] 
 **association** | **string**| association | [optional] 
 **categoryId** | **long?**| categoryId | [optional] 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

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
> VerveResponseSentimentAnalytics GetSentiment (long? startTime, long? endTime, string requesterId, string clientToken, string interactionType = null, string additionalInformation = null, string association = null, long? categoryId = null, string accessToken = null)

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
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var interactionType = interactionType_example;  // string | Interaction Type <br/>1)Question<br/>2)Complaint<br/>3)Idea<br/>4)Blog<br/>5)Discussion (optional) 
            var additionalInformation = additionalInformation_example;  // string | additional information (optional) 
            var association = association_example;  // string | association (optional) 
            var categoryId = 789;  // long? | categoryId (optional) 
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get sentiment count of interactions
                VerveResponseSentimentAnalytics result = apiInstance.GetSentiment(startTime, endTime, requesterId, clientToken, interactionType, additionalInformation, association, categoryId, accessToken);
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
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **interactionType** | **string**| Interaction Type &lt;br/&gt;1)Question&lt;br/&gt;2)Complaint&lt;br/&gt;3)Idea&lt;br/&gt;4)Blog&lt;br/&gt;5)Discussion | [optional] 
 **additionalInformation** | **string**| additional information | [optional] 
 **association** | **string**| association | [optional] 
 **categoryId** | **long?**| categoryId | [optional] 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

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
> VerveResponseEntitySentimentList GetTagEntitySentiments (string tagName, long? startTime, long? endTime, int? start, int? end, string requesterId, string clientToken, string sentimentType = null, string additionalInformation = null, string association = null, string interactionType = null, long? categoryId = null, string accessToken = null)

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
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var sentimentType = sentimentType_example;  // string | Sentiment Type <br/>1)Positive<br/>2)Negative<br/>3)Neutral (optional) 
            var additionalInformation = additionalInformation_example;  // string | additional information (optional) 
            var association = association_example;  // string | association (optional) 
            var interactionType = interactionType_example;  // string | Interaction Type <br/>1)Question<br/>2)Complaint<br/>3)Idea<br/>4)Blog<br/>5)Discussion (optional) 
            var categoryId = 789;  // long? | categoryId (optional) 
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get list of tag entity sentiment
                VerveResponseEntitySentimentList result = apiInstance.GetTagEntitySentiments(tagName, startTime, endTime, start, end, requesterId, clientToken, sentimentType, additionalInformation, association, interactionType, categoryId, accessToken);
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
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **sentimentType** | **string**| Sentiment Type &lt;br/&gt;1)Positive&lt;br/&gt;2)Negative&lt;br/&gt;3)Neutral | [optional] 
 **additionalInformation** | **string**| additional information | [optional] 
 **association** | **string**| association | [optional] 
 **interactionType** | **string**| Interaction Type &lt;br/&gt;1)Question&lt;br/&gt;2)Complaint&lt;br/&gt;3)Idea&lt;br/&gt;4)Blog&lt;br/&gt;5)Discussion | [optional] 
 **categoryId** | **long?**| categoryId | [optional] 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseEntitySentimentList**](VerveResponseEntitySentimentList.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sentiment"></a>
# **Sentiment**
> VerveResponseSentiment Sentiment (string text, string clientToken)

Analyzes the sentiment of the content

The response will be a Sentiment Weightage. -1 is most negative and +1 is most positive. 0 will be neutral

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class SentimentExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AugmentedIntelligenceApi();
            var text = text_example;  // string | Sentence whose sentiment is to be found out
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs

            try
            {
                // Analyzes the sentiment of the content
                VerveResponseSentiment result = apiInstance.Sentiment(text, clientToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AugmentedIntelligenceApi.Sentiment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **text** | **string**| Sentence whose sentiment is to be found out | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 

### Return type

[**VerveResponseSentiment**](VerveResponseSentiment.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

