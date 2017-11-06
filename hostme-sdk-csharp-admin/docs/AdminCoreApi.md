# HostMe.Sdk.Api.AdminCoreApi

All URIs are relative to *http://hostme-services-dev.azurewebsites.net*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddNewRestaurant**](AdminCoreApi.md#addnewrestaurant) | **POST** /api/core/admin/restaurants | 
[**AddRestaurantZone**](AdminCoreApi.md#addrestaurantzone) | **POST** /api/core/admin/restaurants/{restaurantId}/zones | 
[**AddWaiter**](AdminCoreApi.md#addwaiter) | **POST** /api/core/admin/restaurants/{restaurantId}/waiters | 
[**AddWaiterToZone**](AdminCoreApi.md#addwaitertozone) | **PUT** /api/core/admin/restaurants/{restaurantId}/zones/{zoneId}/waiter | 
[**AssignWaiterToTable**](AdminCoreApi.md#assignwaitertotable) | **PUT** /api/core/admin/restaurants/{restaurantId}/tables/{tableNumber}/waiter | 
[**ChangePassword**](AdminCoreApi.md#changepassword) | **POST** /api/core/admin/account/password/change | 
[**CheckInvitationCode**](AdminCoreApi.md#checkinvitationcode) | **GET** /api/core/admin/restaurants/{restaurantId}/invitations/{invitationCode} | 
[**CreateInvitationCode**](AdminCoreApi.md#createinvitationcode) | **POST** /api/core/admin/restaurants/{restaurantId}/invitations | 
[**DeleteInvitation**](AdminCoreApi.md#deleteinvitation) | **DELETE** /api/core/admin/restaurants/{restaurantId}/invitations/{invitationCode} | 
[**DeleteRestaurant**](AdminCoreApi.md#deleterestaurant) | **DELETE** /api/core/admin/restaurants/{restaurantId} | 
[**DeleteUser**](AdminCoreApi.md#deleteuser) | **DELETE** /api/core/admin/restaurants/{restaurantId}/users/{userId} | 
[**DeleteWaiter**](AdminCoreApi.md#deletewaiter) | **DELETE** /api/core/admin/restaurants/{restaurantId}/waiters/{waiterId} | 
[**DeleteZone**](AdminCoreApi.md#deletezone) | **DELETE** /api/core/admin/restaurants/{restaurantId}/zones/{zoneId} | 
[**EmbedReport**](AdminCoreApi.md#embedreport) | **GET** /api/core/admin/restaurants/{restaurantId}/powerbi/embedreport | 
[**GetAllUserRestaurants**](AdminCoreApi.md#getalluserrestaurants) | **GET** /api/core/admin/restaurants | 
[**GetInvitations**](AdminCoreApi.md#getinvitations) | **GET** /api/core/admin/restaurants/{restaurantId}/invitations | 
[**GetRegistrationToken**](AdminCoreApi.md#getregistrationtoken) | **PUT** /api/core/admin/restaurants/{restaurantId}/loyalty/token | 
[**GetRestaurantById**](AdminCoreApi.md#getrestaurantbyid) | **GET** /api/core/admin/restaurants/{restaurantId} | 
[**GetRestaurantConfiguration**](AdminCoreApi.md#getrestaurantconfiguration) | **GET** /api/core/admin/restaurants/{restaurantId}/config | 
[**GetRestaurantSettings**](AdminCoreApi.md#getrestaurantsettings) | **GET** /api/core/admin/restaurants/{restaurantId}/settings | 
[**GetRestaurantZones**](AdminCoreApi.md#getrestaurantzones) | **GET** /api/core/admin/restaurants/{restaurantId}/zones | 
[**GetRestaurantsByEmail**](AdminCoreApi.md#getrestaurantsbyemail) | **GET** /api/core/admin/restaurants/query | 
[**GetUserProfile**](AdminCoreApi.md#getuserprofile) | **GET** /api/core/admin/account/profile | 
[**GetUsers**](AdminCoreApi.md#getusers) | **GET** /api/core/admin/restaurants/{restaurantId}/users | 
[**GetWaiterZones**](AdminCoreApi.md#getwaiterzones) | **GET** /api/core/admin/restaurants/{restaurantId}/waiters/{waiterId}/zones | 
[**GetWaiters**](AdminCoreApi.md#getwaiters) | **GET** /api/core/admin/restaurants/{restaurantId}/waiters | 
[**Me**](AdminCoreApi.md#me) | **GET** /api/core/admin/account/me | 
[**Register**](AdminCoreApi.md#register) | **POST** /api/core/admin/account/register | 
[**Reinvite**](AdminCoreApi.md#reinvite) | **GET** /api/core/admin/restaurants/{restaurantId}/invitations/{invitationCode}/reinvite | 
[**RemoveWaiterFromZone**](AdminCoreApi.md#removewaiterfromzone) | **DELETE** /api/core/admin/restaurants/{restaurantId}/zones/{zoneId}/waiter | 
[**ResetPassword**](AdminCoreApi.md#resetpassword) | **POST** /api/core/admin/account/password/reset | 
[**SetRestaurantSettings**](AdminCoreApi.md#setrestaurantsettings) | **PUT** /api/core/admin/restaurants/{restaurantId}/settings | 
[**UpdateRestaurant**](AdminCoreApi.md#updaterestaurant) | **PUT** /api/core/admin/restaurants/{restaurantId} | 
[**UpdateRestaurantZone**](AdminCoreApi.md#updaterestaurantzone) | **PUT** /api/core/admin/restaurants/{restaurantId}/zones/{zoneId} | 
[**UpdateUserProfile**](AdminCoreApi.md#updateuserprofile) | **PUT** /api/core/admin/account/profile | 
[**UpdateWaiter**](AdminCoreApi.md#updatewaiter) | **PUT** /api/core/admin/restaurants/{restaurantId}/waiters/{waiterId} | 
[**UpdateWaiterZone**](AdminCoreApi.md#updatewaiterzone) | **PUT** /api/core/admin/restaurants/{restaurantId}/waiters/{waiterId}/zones | 


<a name="addnewrestaurant"></a>
# **AddNewRestaurant**
> WithAccessTokenContract1RestaurantContract AddNewRestaurant (CreateRestaurant value)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class AddNewRestaurantExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminCoreApi();
            var value = new CreateRestaurant(); // CreateRestaurant | 

            try
            {
                WithAccessTokenContract1RestaurantContract result = apiInstance.AddNewRestaurant(value);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminCoreApi.AddNewRestaurant: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **value** | [**CreateRestaurant**](CreateRestaurant.md)|  | 

### Return type

[**WithAccessTokenContract1RestaurantContract**](WithAccessTokenContract1RestaurantContract.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addrestaurantzone"></a>
# **AddRestaurantZone**
> void AddRestaurantZone (int? restaurantId, ZoneCreate contract)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class AddRestaurantZoneExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminCoreApi();
            var restaurantId = 56;  // int? | 
            var contract = new ZoneCreate(); // ZoneCreate | 

            try
            {
                apiInstance.AddRestaurantZone(restaurantId, contract);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminCoreApi.AddRestaurantZone: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **contract** | [**ZoneCreate**](ZoneCreate.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addwaiter"></a>
# **AddWaiter**
> void AddWaiter (int? restaurantId, WaiterCreate contract)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class AddWaiterExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminCoreApi();
            var restaurantId = 56;  // int? | 
            var contract = new WaiterCreate(); // WaiterCreate | 

            try
            {
                apiInstance.AddWaiter(restaurantId, contract);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminCoreApi.AddWaiter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **contract** | [**WaiterCreate**](WaiterCreate.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addwaitertozone"></a>
# **AddWaiterToZone**
> void AddWaiterToZone (int? restaurantId, int? zoneId, WaiterAssign contract)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class AddWaiterToZoneExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminCoreApi();
            var restaurantId = 56;  // int? | 
            var zoneId = 56;  // int? | 
            var contract = new WaiterAssign(); // WaiterAssign | 

            try
            {
                apiInstance.AddWaiterToZone(restaurantId, zoneId, contract);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminCoreApi.AddWaiterToZone: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **zoneId** | **int?**|  | 
 **contract** | [**WaiterAssign**](WaiterAssign.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="assignwaitertotable"></a>
# **AssignWaiterToTable**
> void AssignWaiterToTable (int? restaurantId, string tableNumber, WaiterAssign contract)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class AssignWaiterToTableExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminCoreApi();
            var restaurantId = 56;  // int? | 
            var tableNumber = tableNumber_example;  // string | 
            var contract = new WaiterAssign(); // WaiterAssign | 

            try
            {
                apiInstance.AssignWaiterToTable(restaurantId, tableNumber, contract);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminCoreApi.AssignWaiterToTable: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **tableNumber** | **string**|  | 
 **contract** | [**WaiterAssign**](WaiterAssign.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="changepassword"></a>
# **ChangePassword**
> void ChangePassword (ChangePassword model)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class ChangePasswordExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminCoreApi();
            var model = new ChangePassword(); // ChangePassword | 

            try
            {
                apiInstance.ChangePassword(model);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminCoreApi.ChangePassword: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**ChangePassword**](ChangePassword.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkinvitationcode"></a>
# **CheckInvitationCode**
> InvitationInfo CheckInvitationCode (string invitationCode, string restaurantId)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class CheckInvitationCodeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminCoreApi();
            var invitationCode = invitationCode_example;  // string | 
            var restaurantId = restaurantId_example;  // string | 

            try
            {
                InvitationInfo result = apiInstance.CheckInvitationCode(invitationCode, restaurantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminCoreApi.CheckInvitationCode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invitationCode** | **string**|  | 
 **restaurantId** | **string**|  | 

### Return type

[**InvitationInfo**](InvitationInfo.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createinvitationcode"></a>
# **CreateInvitationCode**
> Token CreateInvitationCode (int? restaurantId, Invitation invitation)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class CreateInvitationCodeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminCoreApi();
            var restaurantId = 56;  // int? | 
            var invitation = new Invitation(); // Invitation | 

            try
            {
                Token result = apiInstance.CreateInvitationCode(restaurantId, invitation);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminCoreApi.CreateInvitationCode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **invitation** | [**Invitation**](Invitation.md)|  | 

### Return type

[**Token**](Token.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteinvitation"></a>
# **DeleteInvitation**
> void DeleteInvitation (int? restaurantId, string invitationCode)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class DeleteInvitationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminCoreApi();
            var restaurantId = 56;  // int? | 
            var invitationCode = invitationCode_example;  // string | 

            try
            {
                apiInstance.DeleteInvitation(restaurantId, invitationCode);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminCoreApi.DeleteInvitation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **invitationCode** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleterestaurant"></a>
# **DeleteRestaurant**
> void DeleteRestaurant (int? restaurantId)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class DeleteRestaurantExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminCoreApi();
            var restaurantId = 56;  // int? | 

            try
            {
                apiInstance.DeleteRestaurant(restaurantId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminCoreApi.DeleteRestaurant: " + e.Message );
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

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteuser"></a>
# **DeleteUser**
> void DeleteUser (int? restaurantId, string userId, string role)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class DeleteUserExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminCoreApi();
            var restaurantId = 56;  // int? | 
            var userId = userId_example;  // string | 
            var role = role_example;  // string | 

            try
            {
                apiInstance.DeleteUser(restaurantId, userId, role);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminCoreApi.DeleteUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **userId** | **string**|  | 
 **role** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletewaiter"></a>
# **DeleteWaiter**
> void DeleteWaiter (int? restaurantId, int? waiterId)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class DeleteWaiterExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminCoreApi();
            var restaurantId = 56;  // int? | 
            var waiterId = 56;  // int? | 

            try
            {
                apiInstance.DeleteWaiter(restaurantId, waiterId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminCoreApi.DeleteWaiter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **waiterId** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletezone"></a>
# **DeleteZone**
> void DeleteZone (int? restaurantId, int? zoneId)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class DeleteZoneExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminCoreApi();
            var restaurantId = 56;  // int? | 
            var zoneId = 56;  // int? | 

            try
            {
                apiInstance.DeleteZone(restaurantId, zoneId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminCoreApi.DeleteZone: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **zoneId** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="embedreport"></a>
# **EmbedReport**
> EmbedConfig EmbedReport (int? restaurantId, string reportName = null)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class EmbedReportExample
    {
        public void main()
        {
            
            var apiInstance = new AdminCoreApi();
            var restaurantId = 56;  // int? | 
            var reportName = reportName_example;  // string |  (optional) 

            try
            {
                EmbedConfig result = apiInstance.EmbedReport(restaurantId, reportName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminCoreApi.EmbedReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **reportName** | **string**|  | [optional] 

### Return type

[**EmbedConfig**](EmbedConfig.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getalluserrestaurants"></a>
# **GetAllUserRestaurants**
> List<Restaurant> GetAllUserRestaurants ()



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class GetAllUserRestaurantsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminCoreApi();

            try
            {
                List&lt;Restaurant&gt; result = apiInstance.GetAllUserRestaurants();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminCoreApi.GetAllUserRestaurants: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Restaurant>**](Restaurant.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinvitations"></a>
# **GetInvitations**
> List<InvitationInfo> GetInvitations (int? restaurantId)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class GetInvitationsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminCoreApi();
            var restaurantId = 56;  // int? | 

            try
            {
                List&lt;InvitationInfo&gt; result = apiInstance.GetInvitations(restaurantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminCoreApi.GetInvitations: " + e.Message );
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

[**List<InvitationInfo>**](InvitationInfo.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getregistrationtoken"></a>
# **GetRegistrationToken**
> Token GetRegistrationToken (int? restaurantId, string tableNumber = null)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class GetRegistrationTokenExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminCoreApi();
            var restaurantId = 56;  // int? | 
            var tableNumber = tableNumber_example;  // string |  (optional) 

            try
            {
                Token result = apiInstance.GetRegistrationToken(restaurantId, tableNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminCoreApi.GetRegistrationToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **tableNumber** | **string**|  | [optional] 

### Return type

[**Token**](Token.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrestaurantbyid"></a>
# **GetRestaurantById**
> Restaurant GetRestaurantById (int? restaurantId)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class GetRestaurantByIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminCoreApi();
            var restaurantId = 56;  // int? | 

            try
            {
                Restaurant result = apiInstance.GetRestaurantById(restaurantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminCoreApi.GetRestaurantById: " + e.Message );
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

[**Restaurant**](Restaurant.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrestaurantconfiguration"></a>
# **GetRestaurantConfiguration**
> RestaurantConfiguration GetRestaurantConfiguration (int? restaurantId)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class GetRestaurantConfigurationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminCoreApi();
            var restaurantId = 56;  // int? | 

            try
            {
                RestaurantConfiguration result = apiInstance.GetRestaurantConfiguration(restaurantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminCoreApi.GetRestaurantConfiguration: " + e.Message );
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

[**RestaurantConfiguration**](RestaurantConfiguration.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrestaurantsettings"></a>
# **GetRestaurantSettings**
> RestaurantSettings GetRestaurantSettings (int? restaurantId)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class GetRestaurantSettingsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminCoreApi();
            var restaurantId = 56;  // int? | 

            try
            {
                RestaurantSettings result = apiInstance.GetRestaurantSettings(restaurantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminCoreApi.GetRestaurantSettings: " + e.Message );
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

[**RestaurantSettings**](RestaurantSettings.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrestaurantzones"></a>
# **GetRestaurantZones**
> List<Zone> GetRestaurantZones (int? restaurantId)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class GetRestaurantZonesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminCoreApi();
            var restaurantId = 56;  // int? | 

            try
            {
                List&lt;Zone&gt; result = apiInstance.GetRestaurantZones(restaurantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminCoreApi.GetRestaurantZones: " + e.Message );
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

[**List<Zone>**](Zone.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrestaurantsbyemail"></a>
# **GetRestaurantsByEmail**
> List<Restaurant> GetRestaurantsByEmail (string email)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class GetRestaurantsByEmailExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminCoreApi();
            var email = email_example;  // string | 

            try
            {
                List&lt;Restaurant&gt; result = apiInstance.GetRestaurantsByEmail(email);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminCoreApi.GetRestaurantsByEmail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **string**|  | 

### Return type

[**List<Restaurant>**](Restaurant.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserprofile"></a>
# **GetUserProfile**
> UserProfile GetUserProfile ()



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class GetUserProfileExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminCoreApi();

            try
            {
                UserProfile result = apiInstance.GetUserProfile();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminCoreApi.GetUserProfile: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**UserProfile**](UserProfile.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusers"></a>
# **GetUsers**
> List<RestaurantUserInfo> GetUsers (int? restaurantId)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class GetUsersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminCoreApi();
            var restaurantId = 56;  // int? | 

            try
            {
                List&lt;RestaurantUserInfo&gt; result = apiInstance.GetUsers(restaurantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminCoreApi.GetUsers: " + e.Message );
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

[**List<RestaurantUserInfo>**](RestaurantUserInfo.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwaiterzones"></a>
# **GetWaiterZones**
> List<Zone> GetWaiterZones (int? restaurantId, int? waiterId)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class GetWaiterZonesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminCoreApi();
            var restaurantId = 56;  // int? | 
            var waiterId = 56;  // int? | 

            try
            {
                List&lt;Zone&gt; result = apiInstance.GetWaiterZones(restaurantId, waiterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminCoreApi.GetWaiterZones: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **waiterId** | **int?**|  | 

### Return type

[**List<Zone>**](Zone.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwaiters"></a>
# **GetWaiters**
> List<Waiter> GetWaiters (int? restaurantId)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class GetWaitersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminCoreApi();
            var restaurantId = 56;  // int? | 

            try
            {
                List&lt;Waiter&gt; result = apiInstance.GetWaiters(restaurantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminCoreApi.GetWaiters: " + e.Message );
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

[**List<Waiter>**](Waiter.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="me"></a>
# **Me**
> UserInfo Me ()



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class MeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminCoreApi();

            try
            {
                UserInfo result = apiInstance.Me();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminCoreApi.Me: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**UserInfo**](UserInfo.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="register"></a>
# **Register**
> void Register (RegisterUser model)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class RegisterExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminCoreApi();
            var model = new RegisterUser(); // RegisterUser | 

            try
            {
                apiInstance.Register(model);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminCoreApi.Register: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**RegisterUser**](RegisterUser.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reinvite"></a>
# **Reinvite**
> void Reinvite (int? restaurantId, string invitationCode)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class ReinviteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminCoreApi();
            var restaurantId = 56;  // int? | 
            var invitationCode = invitationCode_example;  // string | 

            try
            {
                apiInstance.Reinvite(restaurantId, invitationCode);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminCoreApi.Reinvite: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **invitationCode** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removewaiterfromzone"></a>
# **RemoveWaiterFromZone**
> void RemoveWaiterFromZone (int? restaurantId, int? zoneId)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class RemoveWaiterFromZoneExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminCoreApi();
            var restaurantId = 56;  // int? | 
            var zoneId = 56;  // int? | 

            try
            {
                apiInstance.RemoveWaiterFromZone(restaurantId, zoneId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminCoreApi.RemoveWaiterFromZone: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **zoneId** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="resetpassword"></a>
# **ResetPassword**
> void ResetPassword (ResetPassword model)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class ResetPasswordExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminCoreApi();
            var model = new ResetPassword(); // ResetPassword | 

            try
            {
                apiInstance.ResetPassword(model);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminCoreApi.ResetPassword: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**ResetPassword**](ResetPassword.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setrestaurantsettings"></a>
# **SetRestaurantSettings**
> void SetRestaurantSettings (int? restaurantId, RestaurantSettings settings)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class SetRestaurantSettingsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminCoreApi();
            var restaurantId = 56;  // int? | 
            var settings = new RestaurantSettings(); // RestaurantSettings | 

            try
            {
                apiInstance.SetRestaurantSettings(restaurantId, settings);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminCoreApi.SetRestaurantSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **settings** | [**RestaurantSettings**](RestaurantSettings.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterestaurant"></a>
# **UpdateRestaurant**
> Restaurant UpdateRestaurant (int? restaurantId, Restaurant value)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class UpdateRestaurantExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminCoreApi();
            var restaurantId = 56;  // int? | 
            var value = new Restaurant(); // Restaurant | 

            try
            {
                Restaurant result = apiInstance.UpdateRestaurant(restaurantId, value);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminCoreApi.UpdateRestaurant: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **value** | [**Restaurant**](Restaurant.md)|  | 

### Return type

[**Restaurant**](Restaurant.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterestaurantzone"></a>
# **UpdateRestaurantZone**
> void UpdateRestaurantZone (int? restaurantId, int? zoneId, ZoneCreate contract)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class UpdateRestaurantZoneExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminCoreApi();
            var restaurantId = 56;  // int? | 
            var zoneId = 56;  // int? | 
            var contract = new ZoneCreate(); // ZoneCreate | 

            try
            {
                apiInstance.UpdateRestaurantZone(restaurantId, zoneId, contract);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminCoreApi.UpdateRestaurantZone: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **zoneId** | **int?**|  | 
 **contract** | [**ZoneCreate**](ZoneCreate.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateuserprofile"></a>
# **UpdateUserProfile**
> void UpdateUserProfile (UserProfile profile)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class UpdateUserProfileExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminCoreApi();
            var profile = new UserProfile(); // UserProfile | 

            try
            {
                apiInstance.UpdateUserProfile(profile);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminCoreApi.UpdateUserProfile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **profile** | [**UserProfile**](UserProfile.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatewaiter"></a>
# **UpdateWaiter**
> void UpdateWaiter (int? restaurantId, int? waiterId, WaiterUpdate contract)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class UpdateWaiterExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminCoreApi();
            var restaurantId = 56;  // int? | 
            var waiterId = 56;  // int? | 
            var contract = new WaiterUpdate(); // WaiterUpdate | 

            try
            {
                apiInstance.UpdateWaiter(restaurantId, waiterId, contract);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminCoreApi.UpdateWaiter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **waiterId** | **int?**|  | 
 **contract** | [**WaiterUpdate**](WaiterUpdate.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatewaiterzone"></a>
# **UpdateWaiterZone**
> void UpdateWaiterZone (int? restaurantId, int? waiterId, ZoneCreate contract)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class UpdateWaiterZoneExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminCoreApi();
            var restaurantId = 56;  // int? | 
            var waiterId = 56;  // int? | 
            var contract = new ZoneCreate(); // ZoneCreate | 

            try
            {
                apiInstance.UpdateWaiterZone(restaurantId, waiterId, contract);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminCoreApi.UpdateWaiterZone: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **waiterId** | **int?**|  | 
 **contract** | [**ZoneCreate**](ZoneCreate.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

