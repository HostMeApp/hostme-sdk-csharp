# HostMe.Sdk.Api.AdminWaitingManagementApi

All URIs are relative to *http://hostme-services-dev.azurewebsites.net*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CallWaitingParty**](AdminWaitingManagementApi.md#callwaitingparty) | **PUT** /api/wm/admin/restaurant/{restaurantId}/waitings/{waitingItemId}/call | Calls waiting party.
[**Close**](AdminWaitingManagementApi.md#close) | **PUT** /api/wm/admin/restaurant/{restaurantId}/waitings/{waitingItemId}/close | Closes current waiting position.
[**CloseAsCanceled**](AdminWaitingManagementApi.md#closeascanceled) | **PUT** /api/wm/admin/restaurant/{restaurantId}/waitings/{waitingItemId}/cancel | Cancels waiting item
[**CloseAsSeated**](AdminWaitingManagementApi.md#closeasseated) | **PUT** /api/wm/admin/restaurant/{restaurantId}/waitings/{waitingItemId}/sited | Sets current waiting record in sited state. When person gets a table, hostess should mark current record as sited.
[**Create**](AdminWaitingManagementApi.md#create) | **POST** /api/wm/admin/restaurant/{restaurantId}/waitings | 
[**GetAllWaitings**](AdminWaitingManagementApi.md#getallwaitings) | **GET** /api/wm/admin/restaurant/{restaurantId}/waitings | Returns all waiting items for the selected restaurant
[**GetMessages**](AdminWaitingManagementApi.md#getmessages) | **GET** /api/wm/admin/restaurant/{restaurantId}/waitings/{waitingItemId}/messages | 
[**GetRestaurantWaitingsStatistic**](AdminWaitingManagementApi.md#getrestaurantwaitingsstatistic) | **GET** /api/wm/admin/restaurant/{restaurantId}/waitings/stats | 
[**GetUnreadMessagesCount**](AdminWaitingManagementApi.md#getunreadmessagescount) | **GET** /api/wm/admin/restaurant/{restaurantId}/waitings/messages/unread/count | 
[**GetWaitingById**](AdminWaitingManagementApi.md#getwaitingbyid) | **GET** /api/wm/admin/restaurant/{restaurantId}/waitings/{waitingItemId} | Returns waiting item by waiting item identifier
[**GetWaitingSettings**](AdminWaitingManagementApi.md#getwaitingsettings) | **GET** /api/wm/admin/restaurant/{restaurantId}/settings | 
[**Incoming**](AdminWaitingManagementApi.md#incoming) | **GET** /api/wm/admin/smsclient/incoming | 
[**MarkAllMessagesAsRead**](AdminWaitingManagementApi.md#markallmessagesasread) | **POST** /api/wm/admin/restaurant/{restaurantId}/waitings/{waitingItemId}/messages/readall | Marks all message as read.
[**ReOpenWaiting**](AdminWaitingManagementApi.md#reopenwaiting) | **PUT** /api/wm/admin/restaurant/{restaurantId}/waitings/{waitingItemId}/reopen | Reopens closed waiting item
[**SendMessage**](AdminWaitingManagementApi.md#sendmessage) | **POST** /api/wm/admin/restaurant/{restaurantId}/waitings/{waitingItemId}/sendmessage | Sends a message related to specified waiting item.
[**SetWaitingSettings**](AdminWaitingManagementApi.md#setwaitingsettings) | **PUT** /api/wm/admin/restaurant/{restaurantId}/settings | 
[**UpdateWaiting**](AdminWaitingManagementApi.md#updatewaiting) | **PUT** /api/wm/admin/restaurant/{restaurantId}/waitings/{waitingItemId} | Updates waitingitem


<a name="callwaitingparty"></a>
# **CallWaitingParty**
> void CallWaitingParty (int? restaurantId, string waitingItemId, string tableNumber = null)

Calls waiting party.

When table is ready hostess originates Call event. It notifies client that table is ready.

### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class CallWaitingPartyExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminWaitingManagementApi();
            var restaurantId = 56;  // int? | Restaurant identifier
            var waitingItemId = waitingItemId_example;  // string | Waiting item identifier
            var tableNumber = tableNumber_example;  // string | Number of the table (optional) 

            try
            {
                // Calls waiting party.
                apiInstance.CallWaitingParty(restaurantId, waitingItemId, tableNumber);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminWaitingManagementApi.CallWaitingParty: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**| Restaurant identifier | 
 **waitingItemId** | **string**| Waiting item identifier | 
 **tableNumber** | **string**| Number of the table | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="close"></a>
# **Close**
> void Close (int? restaurantId, string waitingItemId)

Closes current waiting position.

When person gets a table, hostess should close current position.

### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class CloseExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminWaitingManagementApi();
            var restaurantId = 56;  // int? | Restaurant identifier
            var waitingItemId = waitingItemId_example;  // string | Identifier of the waiting item

            try
            {
                // Closes current waiting position.
                apiInstance.Close(restaurantId, waitingItemId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminWaitingManagementApi.Close: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**| Restaurant identifier | 
 **waitingItemId** | **string**| Identifier of the waiting item | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="closeascanceled"></a>
# **CloseAsCanceled**
> void CloseAsCanceled (int? restaurantId, string waitingItemId, string origin = null)

Cancels waiting item

### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class CloseAsCanceledExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminWaitingManagementApi();
            var restaurantId = 56;  // int? | Restaurant identifier
            var waitingItemId = waitingItemId_example;  // string | Waiting item identifier
            var origin = origin_example;  // string |  (optional) 

            try
            {
                // Cancels waiting item
                apiInstance.CloseAsCanceled(restaurantId, waitingItemId, origin);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminWaitingManagementApi.CloseAsCanceled: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**| Restaurant identifier | 
 **waitingItemId** | **string**| Waiting item identifier | 
 **origin** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="closeasseated"></a>
# **CloseAsSeated**
> void CloseAsSeated (int? restaurantId, string waitingItemId, string tableNumber = null)

Sets current waiting record in sited state. When person gets a table, hostess should mark current record as sited.

### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class CloseAsSeatedExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminWaitingManagementApi();
            var restaurantId = 56;  // int? | Restaurant identifier
            var waitingItemId = waitingItemId_example;  // string | Identifier of the waiting item
            var tableNumber = tableNumber_example;  // string |  (optional) 

            try
            {
                // Sets current waiting record in sited state. When person gets a table, hostess should mark current record as sited.
                apiInstance.CloseAsSeated(restaurantId, waitingItemId, tableNumber);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminWaitingManagementApi.CloseAsSeated: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**| Restaurant identifier | 
 **waitingItemId** | **string**| Identifier of the waiting item | 
 **tableNumber** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="create"></a>
# **Create**
> Booking Create (int? restaurantId, UpdateWaitingItem contract)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class CreateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminWaitingManagementApi();
            var restaurantId = 56;  // int? | 
            var contract = new UpdateWaitingItem(); // UpdateWaitingItem | 

            try
            {
                Booking result = apiInstance.Create(restaurantId, contract);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminWaitingManagementApi.Create: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **contract** | [**UpdateWaitingItem**](UpdateWaitingItem.md)|  | 

### Return type

[**Booking**](Booking.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallwaitings"></a>
# **GetAllWaitings**
> List<Waiting> GetAllWaitings (int? restaurantId)

Returns all waiting items for the selected restaurant

### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class GetAllWaitingsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminWaitingManagementApi();
            var restaurantId = 56;  // int? | Restaurant identifier

            try
            {
                // Returns all waiting items for the selected restaurant
                List&lt;Waiting&gt; result = apiInstance.GetAllWaitings(restaurantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminWaitingManagementApi.GetAllWaitings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**| Restaurant identifier | 

### Return type

[**List<Waiting>**](Waiting.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmessages"></a>
# **GetMessages**
> List<Message> GetMessages (int? restaurantId, string waitingItemId)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class GetMessagesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminWaitingManagementApi();
            var restaurantId = 56;  // int? | 
            var waitingItemId = waitingItemId_example;  // string | 

            try
            {
                List&lt;Message&gt; result = apiInstance.GetMessages(restaurantId, waitingItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminWaitingManagementApi.GetMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **waitingItemId** | **string**|  | 

### Return type

[**List<Message>**](Message.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrestaurantwaitingsstatistic"></a>
# **GetRestaurantWaitingsStatistic**
> WaitingsStatistic GetRestaurantWaitingsStatistic (int? restaurantId)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class GetRestaurantWaitingsStatisticExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminWaitingManagementApi();
            var restaurantId = 56;  // int? | 

            try
            {
                WaitingsStatistic result = apiInstance.GetRestaurantWaitingsStatistic(restaurantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminWaitingManagementApi.GetRestaurantWaitingsStatistic: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 

### Return type

[**WaitingsStatistic**](WaitingsStatistic.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getunreadmessagescount"></a>
# **GetUnreadMessagesCount**
> Count GetUnreadMessagesCount (int? restaurantId)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class GetUnreadMessagesCountExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminWaitingManagementApi();
            var restaurantId = 56;  // int? | 

            try
            {
                Count result = apiInstance.GetUnreadMessagesCount(restaurantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminWaitingManagementApi.GetUnreadMessagesCount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 

### Return type

[**Count**](Count.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwaitingbyid"></a>
# **GetWaitingById**
> Waiting GetWaitingById (int? restaurantId, string waitingItemId)

Returns waiting item by waiting item identifier

### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class GetWaitingByIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminWaitingManagementApi();
            var restaurantId = 56;  // int? | Restaurant identifier
            var waitingItemId = waitingItemId_example;  // string | Identifier of the waiting item

            try
            {
                // Returns waiting item by waiting item identifier
                Waiting result = apiInstance.GetWaitingById(restaurantId, waitingItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminWaitingManagementApi.GetWaitingById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**| Restaurant identifier | 
 **waitingItemId** | **string**| Identifier of the waiting item | 

### Return type

[**Waiting**](Waiting.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwaitingsettings"></a>
# **GetWaitingSettings**
> WaitingSettings GetWaitingSettings (int? restaurantId)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class GetWaitingSettingsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminWaitingManagementApi();
            var restaurantId = 56;  // int? | 

            try
            {
                WaitingSettings result = apiInstance.GetWaitingSettings(restaurantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminWaitingManagementApi.GetWaitingSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 

### Return type

[**WaitingSettings**](WaitingSettings.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="incoming"></a>
# **Incoming**
> Object Incoming (string from, string to, string body)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class IncomingExample
    {
        public void main()
        {
            
            var apiInstance = new AdminWaitingManagementApi();
            var from = from_example;  // string | 
            var to = to_example;  // string | 
            var body = body_example;  // string | 

            try
            {
                Object result = apiInstance.Incoming(from, to, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminWaitingManagementApi.Incoming: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **string**|  | 
 **to** | **string**|  | 
 **body** | **string**|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="markallmessagesasread"></a>
# **MarkAllMessagesAsRead**
> void MarkAllMessagesAsRead (int? restaurantId, string waitingItemId)

Marks all message as read.

### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class MarkAllMessagesAsReadExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminWaitingManagementApi();
            var restaurantId = 56;  // int? | Restaurant identifier
            var waitingItemId = waitingItemId_example;  // string | Waiting item identifier

            try
            {
                // Marks all message as read.
                apiInstance.MarkAllMessagesAsRead(restaurantId, waitingItemId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminWaitingManagementApi.MarkAllMessagesAsRead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**| Restaurant identifier | 
 **waitingItemId** | **string**| Waiting item identifier | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reopenwaiting"></a>
# **ReOpenWaiting**
> Object ReOpenWaiting (int? restaurantId, string waitingItemId)

Reopens closed waiting item

### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class ReOpenWaitingExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminWaitingManagementApi();
            var restaurantId = 56;  // int? | Restaurant identifier
            var waitingItemId = waitingItemId_example;  // string | Waiting item identifier

            try
            {
                // Reopens closed waiting item
                Object result = apiInstance.ReOpenWaiting(restaurantId, waitingItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminWaitingManagementApi.ReOpenWaiting: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**| Restaurant identifier | 
 **waitingItemId** | **string**| Waiting item identifier | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendmessage"></a>
# **SendMessage**
> Object SendMessage (int? restaurantId, string waitingItemId, string origin, CreateMessage createMessage)

Sends a message related to specified waiting item.

### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class SendMessageExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminWaitingManagementApi();
            var restaurantId = 56;  // int? | Restaurant identifier
            var waitingItemId = waitingItemId_example;  // string | Waiting item identifier
            var origin = origin_example;  // string | This parameter specifies who send the message. It could be host or client.
            var createMessage = new CreateMessage(); // CreateMessage | The message with body

            try
            {
                // Sends a message related to specified waiting item.
                Object result = apiInstance.SendMessage(restaurantId, waitingItemId, origin, createMessage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminWaitingManagementApi.SendMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**| Restaurant identifier | 
 **waitingItemId** | **string**| Waiting item identifier | 
 **origin** | **string**| This parameter specifies who send the message. It could be host or client. | 
 **createMessage** | [**CreateMessage**](CreateMessage.md)| The message with body | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setwaitingsettings"></a>
# **SetWaitingSettings**
> void SetWaitingSettings (int? restaurantId, WaitingSettings settings)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class SetWaitingSettingsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminWaitingManagementApi();
            var restaurantId = 56;  // int? | 
            var settings = new WaitingSettings(); // WaitingSettings | 

            try
            {
                apiInstance.SetWaitingSettings(restaurantId, settings);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminWaitingManagementApi.SetWaitingSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **settings** | [**WaitingSettings**](WaitingSettings.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatewaiting"></a>
# **UpdateWaiting**
> Waiting UpdateWaiting (int? restaurantId, string waitingItemId, UpdateWaitingItem item)

Updates waitingitem

### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class UpdateWaitingExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminWaitingManagementApi();
            var restaurantId = 56;  // int? | Identifier of the restaurant registered in our system
            var waitingItemId = waitingItemId_example;  // string | Identifier of the waiting record in our system
            var item = new UpdateWaitingItem(); // UpdateWaitingItem | Update model of waiting record

            try
            {
                // Updates waitingitem
                Waiting result = apiInstance.UpdateWaiting(restaurantId, waitingItemId, item);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminWaitingManagementApi.UpdateWaiting: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**| Identifier of the restaurant registered in our system | 
 **waitingItemId** | **string**| Identifier of the waiting record in our system | 
 **item** | [**UpdateWaitingItem**](UpdateWaitingItem.md)| Update model of waiting record | 

### Return type

[**Waiting**](Waiting.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

