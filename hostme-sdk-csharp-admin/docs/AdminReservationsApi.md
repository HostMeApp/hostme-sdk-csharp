# HostMe.Sdk.Api.AdminReservationsApi

All URIs are relative to *http://hostme-services-dev.azurewebsites.net*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Approve**](AdminReservationsApi.md#approve) | **PUT** /api/rsv/admin/restaurants/{restaurantId}/reservations/{reservationId}/approve | 
[**Cancel**](AdminReservationsApi.md#cancel) | **PUT** /api/rsv/admin/restaurants/{restaurantId}/reservations/{reservationId}/cancel | 
[**Create**](AdminReservationsApi.md#create) | **POST** /api/rsv/admin/restaurants/{restaurantId}/reservations | 
[**Export**](AdminReservationsApi.md#export) | **POST** /api/rsv/admin/restaurants/{restaurantId}/reservations/export | 
[**Get**](AdminReservationsApi.md#get) | **GET** /api/rsv/admin/restaurants/{restaurantId}/reservations/{reservationId} | 
[**GetForPeriod**](AdminReservationsApi.md#getforperiod) | **GET** /api/rsv/admin/restaurants/{restaurantId}/reservations | 
[**GetMessages**](AdminReservationsApi.md#getmessages) | **GET** /api/rsv/admin/restaurants/{restaurantId}/reservations/{reservationId}/messages | 
[**GetReservationAvailability**](AdminReservationsApi.md#getreservationavailability) | **GET** /api/rsv/admin/restaurants/{restaurantId}/availability | 
[**GetReservationSettings**](AdminReservationsApi.md#getreservationsettings) | **GET** /api/rsv/admin/restaurants/{restaurantId}/settings | 
[**GetStatistic**](AdminReservationsApi.md#getstatistic) | **GET** /api/rsv/admin/restaurants/{restaurantId}/reservations/stats | 
[**GetUnreadMessagesCount**](AdminReservationsApi.md#getunreadmessagescount) | **GET** /api/rsv/admin/restaurants/{restaurantId}/reservations/messages/unread/count | 
[**NoShow**](AdminReservationsApi.md#noshow) | **PUT** /api/rsv/admin/restaurants/{restaurantId}/reservations/{reservationId}/noshow | 
[**ReadAllMessage**](AdminReservationsApi.md#readallmessage) | **POST** /api/rsv/admin/restaurants/{restaurantId}/reservations/{reservationId}/messages/readall | Mark all message as read.
[**RejectReservation**](AdminReservationsApi.md#rejectreservation) | **PUT** /api/rsv/admin/restaurants/{restaurantId}/reservations/{reservationId}/reject | 
[**Reopen**](AdminReservationsApi.md#reopen) | **PUT** /api/rsv/admin/restaurants/{restaurantId}/reservations/{reservationId}/reopen | 
[**Seat**](AdminReservationsApi.md#seat) | **PUT** /api/rsv/admin/restaurants/{restaurantId}/reservations/{reservationId}/seat | 
[**SendMessage**](AdminReservationsApi.md#sendmessage) | **POST** /api/rsv/admin/restaurants/{restaurantId}/reservations/{reservationId}/messages | Sends a message related to specified reservation.
[**SetReservationSettings**](AdminReservationsApi.md#setreservationsettings) | **PUT** /api/rsv/admin/restaurants/{restaurantId}/settings | 
[**Update**](AdminReservationsApi.md#update) | **PUT** /api/rsv/admin/restaurants/{restaurantId}/reservations/{reservationId} | 


<a name="approve"></a>
# **Approve**
> Reservation Approve (int? restaurantId, string reservationId, ApproveReservation contract)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class ApproveExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminReservationsApi();
            var restaurantId = 56;  // int? | 
            var reservationId = reservationId_example;  // string | 
            var contract = new ApproveReservation(); // ApproveReservation | 

            try
            {
                Reservation result = apiInstance.Approve(restaurantId, reservationId, contract);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminReservationsApi.Approve: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **reservationId** | **string**|  | 
 **contract** | [**ApproveReservation**](ApproveReservation.md)|  | 

### Return type

[**Reservation**](Reservation.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancel"></a>
# **Cancel**
> Reservation Cancel (int? restaurantId, string reservationId, CancelReservation cancelReservationContract)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class CancelExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminReservationsApi();
            var restaurantId = 56;  // int? | 
            var reservationId = reservationId_example;  // string | 
            var cancelReservationContract = new CancelReservation(); // CancelReservation | 

            try
            {
                Reservation result = apiInstance.Cancel(restaurantId, reservationId, cancelReservationContract);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminReservationsApi.Cancel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **reservationId** | **string**|  | 
 **cancelReservationContract** | [**CancelReservation**](CancelReservation.md)|  | 

### Return type

[**Reservation**](Reservation.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="create"></a>
# **Create**
> Reservation Create (int? restaurantId, CreateReservation contract)



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

            var apiInstance = new AdminReservationsApi();
            var restaurantId = 56;  // int? | 
            var contract = new CreateReservation(); // CreateReservation | 

            try
            {
                Reservation result = apiInstance.Create(restaurantId, contract);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminReservationsApi.Create: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **contract** | [**CreateReservation**](CreateReservation.md)|  | 

### Return type

[**Reservation**](Reservation.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="export"></a>
# **Export**
> Object Export (int? restaurantId)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class ExportExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminReservationsApi();
            var restaurantId = 56;  // int? | 

            try
            {
                Object result = apiInstance.Export(restaurantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminReservationsApi.Export: " + e.Message );
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

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="get"></a>
# **Get**
> ReservationHost Get (int? restaurantId, string reservationId)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class GetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminReservationsApi();
            var restaurantId = 56;  // int? | 
            var reservationId = reservationId_example;  // string | 

            try
            {
                ReservationHost result = apiInstance.Get(restaurantId, reservationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminReservationsApi.Get: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **reservationId** | **string**|  | 

### Return type

[**ReservationHost**](ReservationHost.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getforperiod"></a>
# **GetForPeriod**
> List<ReservationHostList> GetForPeriod (int? restaurantId, DateTimeOffset? from = null)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class GetForPeriodExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminReservationsApi();
            var restaurantId = 56;  // int? | 
            var from = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? |  (optional) 

            try
            {
                List&lt;ReservationHostList&gt; result = apiInstance.GetForPeriod(restaurantId, from);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminReservationsApi.GetForPeriod: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **from** | **DateTimeOffset?**|  | [optional] 

### Return type

[**List<ReservationHostList>**](ReservationHostList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmessages"></a>
# **GetMessages**
> List<Message> GetMessages (int? restaurantId, string reservationId)



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

            var apiInstance = new AdminReservationsApi();
            var restaurantId = 56;  // int? | 
            var reservationId = reservationId_example;  // string | 

            try
            {
                List&lt;Message&gt; result = apiInstance.GetMessages(restaurantId, reservationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminReservationsApi.GetMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **reservationId** | **string**|  | 

### Return type

[**List<Message>**](Message.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreservationavailability"></a>
# **GetReservationAvailability**
> AvailabilityResponse GetReservationAvailability (int? restaurantId, DateTimeOffset? date, int? groupSize, int? rangeInMinutes)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class GetReservationAvailabilityExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminReservationsApi();
            var restaurantId = 56;  // int? | 
            var date = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | 
            var groupSize = 56;  // int? | 
            var rangeInMinutes = 56;  // int? | 

            try
            {
                AvailabilityResponse result = apiInstance.GetReservationAvailability(restaurantId, date, groupSize, rangeInMinutes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminReservationsApi.GetReservationAvailability: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **date** | **DateTimeOffset?**|  | 
 **groupSize** | **int?**|  | 
 **rangeInMinutes** | **int?**|  | 

### Return type

[**AvailabilityResponse**](AvailabilityResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreservationsettings"></a>
# **GetReservationSettings**
> ReservationSettings GetReservationSettings (int? restaurantId)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class GetReservationSettingsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminReservationsApi();
            var restaurantId = 56;  // int? | 

            try
            {
                ReservationSettings result = apiInstance.GetReservationSettings(restaurantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminReservationsApi.GetReservationSettings: " + e.Message );
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

[**ReservationSettings**](ReservationSettings.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstatistic"></a>
# **GetStatistic**
> ReservationsStatistic GetStatistic (int? restaurantId)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class GetStatisticExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminReservationsApi();
            var restaurantId = 56;  // int? | 

            try
            {
                ReservationsStatistic result = apiInstance.GetStatistic(restaurantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminReservationsApi.GetStatistic: " + e.Message );
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

[**ReservationsStatistic**](ReservationsStatistic.md)

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

            var apiInstance = new AdminReservationsApi();
            var restaurantId = 56;  // int? | 

            try
            {
                Count result = apiInstance.GetUnreadMessagesCount(restaurantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminReservationsApi.GetUnreadMessagesCount: " + e.Message );
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

<a name="noshow"></a>
# **NoShow**
> Reservation NoShow (int? restaurantId, string reservationId)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class NoShowExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminReservationsApi();
            var restaurantId = 56;  // int? | 
            var reservationId = reservationId_example;  // string | 

            try
            {
                Reservation result = apiInstance.NoShow(restaurantId, reservationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminReservationsApi.NoShow: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **reservationId** | **string**|  | 

### Return type

[**Reservation**](Reservation.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readallmessage"></a>
# **ReadAllMessage**
> void ReadAllMessage (int? restaurantId, string reservationId)

Mark all message as read.

### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class ReadAllMessageExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminReservationsApi();
            var restaurantId = 56;  // int? | Restaurant identifier
            var reservationId = reservationId_example;  // string | Reservation identifier

            try
            {
                // Mark all message as read.
                apiInstance.ReadAllMessage(restaurantId, reservationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminReservationsApi.ReadAllMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**| Restaurant identifier | 
 **reservationId** | **string**| Reservation identifier | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rejectreservation"></a>
# **RejectReservation**
> Reservation RejectReservation (int? restaurantId, string reservationId, RejectReservation contract)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class RejectReservationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminReservationsApi();
            var restaurantId = 56;  // int? | 
            var reservationId = reservationId_example;  // string | 
            var contract = new RejectReservation(); // RejectReservation | 

            try
            {
                Reservation result = apiInstance.RejectReservation(restaurantId, reservationId, contract);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminReservationsApi.RejectReservation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **reservationId** | **string**|  | 
 **contract** | [**RejectReservation**](RejectReservation.md)|  | 

### Return type

[**Reservation**](Reservation.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reopen"></a>
# **Reopen**
> Reservation Reopen (int? restaurantId, string reservationId)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class ReopenExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminReservationsApi();
            var restaurantId = 56;  // int? | 
            var reservationId = reservationId_example;  // string | 

            try
            {
                Reservation result = apiInstance.Reopen(restaurantId, reservationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminReservationsApi.Reopen: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **reservationId** | **string**|  | 

### Return type

[**Reservation**](Reservation.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="seat"></a>
# **Seat**
> Reservation Seat (int? restaurantId, string reservationId, string tableNumber = null)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class SeatExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminReservationsApi();
            var restaurantId = 56;  // int? | 
            var reservationId = reservationId_example;  // string | 
            var tableNumber = tableNumber_example;  // string |  (optional) 

            try
            {
                Reservation result = apiInstance.Seat(restaurantId, reservationId, tableNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminReservationsApi.Seat: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **reservationId** | **string**|  | 
 **tableNumber** | **string**|  | [optional] 

### Return type

[**Reservation**](Reservation.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendmessage"></a>
# **SendMessage**
> Object SendMessage (int? restaurantId, string reservationId, CreateMessage createMessageContract)

Sends a message related to specified reservation.

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

            var apiInstance = new AdminReservationsApi();
            var restaurantId = 56;  // int? | Restaurant identifier
            var reservationId = reservationId_example;  // string | Reservation identifier
            var createMessageContract = new CreateMessage(); // CreateMessage | The message with body

            try
            {
                // Sends a message related to specified reservation.
                Object result = apiInstance.SendMessage(restaurantId, reservationId, createMessageContract);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminReservationsApi.SendMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**| Restaurant identifier | 
 **reservationId** | **string**| Reservation identifier | 
 **createMessageContract** | [**CreateMessage**](CreateMessage.md)| The message with body | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setreservationsettings"></a>
# **SetReservationSettings**
> void SetReservationSettings (int? restaurantId, ReservationSettings settings)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class SetReservationSettingsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminReservationsApi();
            var restaurantId = 56;  // int? | 
            var settings = new ReservationSettings(); // ReservationSettings | 

            try
            {
                apiInstance.SetReservationSettings(restaurantId, settings);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminReservationsApi.SetReservationSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **settings** | [**ReservationSettings**](ReservationSettings.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="update"></a>
# **Update**
> void Update (int? restaurantId, string reservationId, CreateReservation contract)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class UpdateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminReservationsApi();
            var restaurantId = 56;  // int? | 
            var reservationId = reservationId_example;  // string | 
            var contract = new CreateReservation(); // CreateReservation | 

            try
            {
                apiInstance.Update(restaurantId, reservationId, contract);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminReservationsApi.Update: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **reservationId** | **string**|  | 
 **contract** | [**CreateReservation**](CreateReservation.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

