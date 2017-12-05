# HostMe.Sdk.Api.MobileCoreApi

All URIs are relative to *http://hostme-services-dev.azurewebsites.net*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ChangePassword**](MobileCoreApi.md#changepassword) | **POST** /api/core/mb/account/changePassword | 
[**GetAllRestaurants**](MobileCoreApi.md#getallrestaurants) | **GET** /api/core/mb/restaurants | 
[**GetManageInfo**](MobileCoreApi.md#getmanageinfo) | **GET** /api/core/mb/account/manageInfo | 
[**GetReservationAvailability**](MobileCoreApi.md#getreservationavailability) | **GET** /api/core/mb/restaurants/{restaurantId}/availability | 
[**GetRestaurantById**](MobileCoreApi.md#getrestaurantbyid) | **GET** /api/core/mb/restaurants/{id} | 
[**GetUserInfo**](MobileCoreApi.md#getuserinfo) | **GET** /api/core/mb/account/userInfo | 
[**GetUserProfile**](MobileCoreApi.md#getuserprofile) | **GET** /api/core/mb/account/profile | 
[**PostProfileImage**](MobileCoreApi.md#postprofileimage) | **POST** /api/core/mb/account/profile/image | 
[**ProfileImage**](MobileCoreApi.md#profileimage) | **GET** /api/core/mb/account/profile/image | 
[**Register**](MobileCoreApi.md#register) | **POST** /api/core/mb/account/register | 
[**ResetPassword**](MobileCoreApi.md#resetpassword) | **POST** /api/core/mb/account/resetPassword | 
[**SetPassword**](MobileCoreApi.md#setpassword) | **POST** /api/core/mb/account/setPassword | 
[**UpdateUserProfile**](MobileCoreApi.md#updateuserprofile) | **PUT** /api/core/mb/account/profile | 


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

            var apiInstance = new MobileCoreApi();
            var model = new ChangePassword(); // ChangePassword | 

            try
            {
                apiInstance.ChangePassword(model);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileCoreApi.ChangePassword: " + e.Message );
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

<a name="getallrestaurants"></a>
# **GetAllRestaurants**
> List<RestaurantInfo> GetAllRestaurants ()



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class GetAllRestaurantsExample
    {
        public void main()
        {
            
            var apiInstance = new MobileCoreApi();

            try
            {
                List&lt;RestaurantInfo&gt; result = apiInstance.GetAllRestaurants();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileCoreApi.GetAllRestaurants: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<RestaurantInfo>**](RestaurantInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmanageinfo"></a>
# **GetManageInfo**
> ManageInfo GetManageInfo (string returnUrl, bool? generateState = null)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class GetManageInfoExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MobileCoreApi();
            var returnUrl = returnUrl_example;  // string | 
            var generateState = true;  // bool? |  (optional) 

            try
            {
                ManageInfo result = apiInstance.GetManageInfo(returnUrl, generateState);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileCoreApi.GetManageInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **returnUrl** | **string**|  | 
 **generateState** | **bool?**|  | [optional] 

### Return type

[**ManageInfo**](ManageInfo.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreservationavailability"></a>
# **GetReservationAvailability**
> List<OnlineAvailability> GetReservationAvailability (int? restaurantId, DateTimeOffset? date, int? partySize, int? rangeInMinutes, string areas = null)



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
            
            var apiInstance = new MobileCoreApi();
            var restaurantId = 56;  // int? | 
            var date = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | 
            var partySize = 56;  // int? | 
            var rangeInMinutes = 56;  // int? | 
            var areas = areas_example;  // string |  (optional) 

            try
            {
                List&lt;OnlineAvailability&gt; result = apiInstance.GetReservationAvailability(restaurantId, date, partySize, rangeInMinutes, areas);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileCoreApi.GetReservationAvailability: " + e.Message );
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
 **partySize** | **int?**|  | 
 **rangeInMinutes** | **int?**|  | 
 **areas** | **string**|  | [optional] 

### Return type

[**List<OnlineAvailability>**](OnlineAvailability.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrestaurantbyid"></a>
# **GetRestaurantById**
> RestaurantInfo GetRestaurantById (int? id)



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
            
            var apiInstance = new MobileCoreApi();
            var id = 56;  // int? | 

            try
            {
                RestaurantInfo result = apiInstance.GetRestaurantById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileCoreApi.GetRestaurantById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**|  | 

### Return type

[**RestaurantInfo**](RestaurantInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserinfo"></a>
# **GetUserInfo**
> UserExternal GetUserInfo ()



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class GetUserInfoExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MobileCoreApi();

            try
            {
                UserExternal result = apiInstance.GetUserInfo();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileCoreApi.GetUserInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**UserExternal**](UserExternal.md)

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

            var apiInstance = new MobileCoreApi();

            try
            {
                UserProfile result = apiInstance.GetUserProfile();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileCoreApi.GetUserProfile: " + e.Message );
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

<a name="postprofileimage"></a>
# **PostProfileImage**
> void PostProfileImage (UserImage imageContract)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class PostProfileImageExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MobileCoreApi();
            var imageContract = new UserImage(); // UserImage | 

            try
            {
                apiInstance.PostProfileImage(imageContract);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileCoreApi.PostProfileImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **imageContract** | [**UserImage**](UserImage.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="profileimage"></a>
# **ProfileImage**
> UserImage ProfileImage ()



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class ProfileImageExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MobileCoreApi();

            try
            {
                UserImage result = apiInstance.ProfileImage();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileCoreApi.ProfileImage: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**UserImage**](UserImage.md)

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

            var apiInstance = new MobileCoreApi();
            var model = new RegisterUser(); // RegisterUser | 

            try
            {
                apiInstance.Register(model);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileCoreApi.Register: " + e.Message );
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

            var apiInstance = new MobileCoreApi();
            var model = new ResetPassword(); // ResetPassword | 

            try
            {
                apiInstance.ResetPassword(model);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileCoreApi.ResetPassword: " + e.Message );
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

<a name="setpassword"></a>
# **SetPassword**
> void SetPassword (SetPassword model)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class SetPasswordExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MobileCoreApi();
            var model = new SetPassword(); // SetPassword | 

            try
            {
                apiInstance.SetPassword(model);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileCoreApi.SetPassword: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**SetPassword**](SetPassword.md)|  | 

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

            var apiInstance = new MobileCoreApi();
            var profile = new UserProfile(); // UserProfile | 

            try
            {
                apiInstance.UpdateUserProfile(profile);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileCoreApi.UpdateUserProfile: " + e.Message );
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

