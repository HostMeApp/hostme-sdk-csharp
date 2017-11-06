# HostMe.Sdk.Api.MobileReservationsApi

All URIs are relative to *http://hostme-services-dev.azurewebsites.net*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GuestAddNewReservation**](MobileReservationsApi.md#guestaddnewreservation) | **POST** /api/rsv/mb/guest/reservations | 
[**GuestCloseAsCanceled**](MobileReservationsApi.md#guestcloseascanceled) | **PUT** /api/rsv/mb/guest/reservations/{reservationId}/cancel | 
[**GuestGetInvitation**](MobileReservationsApi.md#guestgetinvitation) | **GET** /api/rsv/mb/guest/reservations/invitations/{code} | 
[**GuestGetReservationById**](MobileReservationsApi.md#guestgetreservationbyid) | **GET** /api/rsv/mb/guest/reservations/{reservationId} | 
[**GuestInvitePartyMembers**](MobileReservationsApi.md#guestinvitepartymembers) | **POST** /api/rsv/mb/guest/reservations/{reservationId}/invitations | 
[**GuestRedeemInvitation**](MobileReservationsApi.md#guestredeeminvitation) | **POST** /api/rsv/mb/guest/reservations/invitations/{code} | 
[**GuestUpdateReservation**](MobileReservationsApi.md#guestupdatereservation) | **PUT** /api/rsv/mb/guest/reservations/{reservationId} | 


<a name="guestaddnewreservation"></a>
# **GuestAddNewReservation**
> ReservationGuest GuestAddNewReservation (CreateMobileReservation item)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class GuestAddNewReservationExample
    {
        public void main()
        {
            
            var apiInstance = new MobileReservationsApi();
            var item = new CreateMobileReservation(); // CreateMobileReservation | 

            try
            {
                ReservationGuest result = apiInstance.GuestAddNewReservation(item);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileReservationsApi.GuestAddNewReservation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **item** | [**CreateMobileReservation**](CreateMobileReservation.md)|  | 

### Return type

[**ReservationGuest**](ReservationGuest.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="guestcloseascanceled"></a>
# **GuestCloseAsCanceled**
> void GuestCloseAsCanceled (string reservationId, CancelReservation cancelReservationContract)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class GuestCloseAsCanceledExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MobileReservationsApi();
            var reservationId = reservationId_example;  // string | 
            var cancelReservationContract = new CancelReservation(); // CancelReservation | 

            try
            {
                apiInstance.GuestCloseAsCanceled(reservationId, cancelReservationContract);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileReservationsApi.GuestCloseAsCanceled: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reservationId** | **string**|  | 
 **cancelReservationContract** | [**CancelReservation**](CancelReservation.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="guestgetinvitation"></a>
# **GuestGetInvitation**
> ReservationInvitation GuestGetInvitation (string code)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class GuestGetInvitationExample
    {
        public void main()
        {
            
            var apiInstance = new MobileReservationsApi();
            var code = code_example;  // string | 

            try
            {
                ReservationInvitation result = apiInstance.GuestGetInvitation(code);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileReservationsApi.GuestGetInvitation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **code** | **string**|  | 

### Return type

[**ReservationInvitation**](ReservationInvitation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="guestgetreservationbyid"></a>
# **GuestGetReservationById**
> ReservationGuest GuestGetReservationById (string reservationId)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class GuestGetReservationByIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MobileReservationsApi();
            var reservationId = reservationId_example;  // string | 

            try
            {
                ReservationGuest result = apiInstance.GuestGetReservationById(reservationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileReservationsApi.GuestGetReservationById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reservationId** | **string**|  | 

### Return type

[**ReservationGuest**](ReservationGuest.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="guestinvitepartymembers"></a>
# **GuestInvitePartyMembers**
> Object GuestInvitePartyMembers (string reservationId, PartyMembersInvitation invitationContract)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class GuestInvitePartyMembersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MobileReservationsApi();
            var reservationId = reservationId_example;  // string | 
            var invitationContract = new PartyMembersInvitation(); // PartyMembersInvitation | 

            try
            {
                Object result = apiInstance.GuestInvitePartyMembers(reservationId, invitationContract);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileReservationsApi.GuestInvitePartyMembers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reservationId** | **string**|  | 
 **invitationContract** | [**PartyMembersInvitation**](PartyMembersInvitation.md)|  | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="guestredeeminvitation"></a>
# **GuestRedeemInvitation**
> void GuestRedeemInvitation (RedeemReservationInvitation redeemInvitationContract, string code)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class GuestRedeemInvitationExample
    {
        public void main()
        {
            
            var apiInstance = new MobileReservationsApi();
            var redeemInvitationContract = new RedeemReservationInvitation(); // RedeemReservationInvitation | 
            var code = code_example;  // string | 

            try
            {
                apiInstance.GuestRedeemInvitation(redeemInvitationContract, code);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileReservationsApi.GuestRedeemInvitation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **redeemInvitationContract** | [**RedeemReservationInvitation**](RedeemReservationInvitation.md)|  | 
 **code** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="guestupdatereservation"></a>
# **GuestUpdateReservation**
> void GuestUpdateReservation (string reservationId, CreateMobileReservation value)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class GuestUpdateReservationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MobileReservationsApi();
            var reservationId = reservationId_example;  // string | 
            var value = new CreateMobileReservation(); // CreateMobileReservation | 

            try
            {
                apiInstance.GuestUpdateReservation(reservationId, value);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileReservationsApi.GuestUpdateReservation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reservationId** | **string**|  | 
 **value** | [**CreateMobileReservation**](CreateMobileReservation.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

