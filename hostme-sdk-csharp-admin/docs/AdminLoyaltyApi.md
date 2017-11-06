# HostMe.Sdk.Api.AdminLoyaltyApi

All URIs are relative to *http://hostme-services-dev.azurewebsites.net*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddMember**](AdminLoyaltyApi.md#addmember) | **POST** /api/loyalty/admin/restaurants/{restaurantId}/members | 
[**AddNewReward**](AdminLoyaltyApi.md#addnewreward) | **POST** /api/loyalty/admin/restaurants/{restaurantId}/rewards | 
[**ApproveRedeemRequest**](AdminLoyaltyApi.md#approveredeemrequest) | **POST** /api/loyalty/admin/restaurants/{restaurantId}/redeems/{redeemId}/approve | 
[**CloseMembership**](AdminLoyaltyApi.md#closemembership) | **PUT** /api/loyalty/admin/restaurants/{restaurantId}/members/{memberId}/close | 
[**DeleteMembership**](AdminLoyaltyApi.md#deletemembership) | **DELETE** /api/loyalty/admin/restaurants/{restaurantId}/members/{memberId} | 
[**DeleteReward**](AdminLoyaltyApi.md#deletereward) | **DELETE** /api/loyalty/admin/restaurants/{restaurantId}/rewards/{rewardId} | 
[**ExportMembers**](AdminLoyaltyApi.md#exportmembers) | **POST** /api/loyalty/admin/restaurants/{restaurantId}/members/export | 
[**Filter**](AdminLoyaltyApi.md#filter) | **GET** /api/loyalty/admin/restaurants/{restaurantId}/members/filter | 
[**FindMemberByPhoneNumber**](AdminLoyaltyApi.md#findmemberbyphonenumber) | **GET** /api/loyalty/admin/restaurants/{restaurantId}/members/find | 
[**GetAlRewards**](AdminLoyaltyApi.md#getalrewards) | **GET** /api/loyalty/admin/restaurants/{restaurantId}/rewards | 
[**GetAllMembers**](AdminLoyaltyApi.md#getallmembers) | **GET** /api/loyalty/admin/restaurants/{restaurantId}/members | 
[**GetAllRedeemRequests**](AdminLoyaltyApi.md#getallredeemrequests) | **GET** /api/loyalty/admin/restaurants/{restaurantId}/redeems | 
[**GetDefaultLoyaltySettings**](AdminLoyaltyApi.md#getdefaultloyaltysettings) | **GET** /api/loyalty/admin/restaurants/{restaurantId}/settings/default | 
[**GetLoyaltySettings**](AdminLoyaltyApi.md#getloyaltysettings) | **GET** /api/loyalty/admin/restaurants/{restaurantId}/settings | 
[**GetMemberTransactions**](AdminLoyaltyApi.md#getmembertransactions) | **GET** /api/loyalty/admin/restaurants/{restaurantId}/members/{memberId}/transactions | 
[**GetMemberVisits**](AdminLoyaltyApi.md#getmembervisits) | **GET** /api/loyalty/admin/restaurants/{restaurantId}/members/{memberId}/visits | 
[**GetMembershipInfo**](AdminLoyaltyApi.md#getmembershipinfo) | **GET** /api/loyalty/admin/restaurants/{restaurantId}/members/{memberId} | 
[**GetRewardById**](AdminLoyaltyApi.md#getrewardbyid) | **GET** /api/loyalty/admin/restaurants/{restaurantId}/rewards/{rewardId} | 
[**IncomingCall**](AdminLoyaltyApi.md#incomingcall) | **POST** /api/loyalty/admin/restaurants/{restaurantId}/call | 
[**PublishReward**](AdminLoyaltyApi.md#publishreward) | **PUT** /api/loyalty/admin/restaurants/{restaurantId}/rewards/{rewardId}/publish | 
[**RejectRedeemRequest**](AdminLoyaltyApi.md#rejectredeemrequest) | **POST** /api/loyalty/admin/restaurants/{restaurantId}/redeems/{redeemId}/reject | 
[**SetLoyaltySettings**](AdminLoyaltyApi.md#setloyaltysettings) | **PUT** /api/loyalty/admin/restaurants/{restaurantId}/settings | 
[**UnpublishReward**](AdminLoyaltyApi.md#unpublishreward) | **PUT** /api/loyalty/admin/restaurants/{restaurantId}/rewards/{rewardId}/unpublish | 
[**UpdateMember**](AdminLoyaltyApi.md#updatemember) | **PUT** /api/loyalty/admin/restaurants/{restaurantId}/members/{memberId} | 
[**UpdateReward**](AdminLoyaltyApi.md#updatereward) | **PUT** /api/loyalty/admin/restaurants/{restaurantId}/rewards/{rewardId} | 


<a name="addmember"></a>
# **AddMember**
> Object AddMember (int? restaurantId, MembershipCreate contract)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class AddMemberExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminLoyaltyApi();
            var restaurantId = 56;  // int? | 
            var contract = new MembershipCreate(); // MembershipCreate | 

            try
            {
                Object result = apiInstance.AddMember(restaurantId, contract);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminLoyaltyApi.AddMember: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **contract** | [**MembershipCreate**](MembershipCreate.md)|  | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addnewreward"></a>
# **AddNewReward**
> Reward AddNewReward (int? restaurantId, Reward reward)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class AddNewRewardExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminLoyaltyApi();
            var restaurantId = 56;  // int? | 
            var reward = new Reward(); // Reward | 

            try
            {
                Reward result = apiInstance.AddNewReward(restaurantId, reward);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminLoyaltyApi.AddNewReward: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **reward** | [**Reward**](Reward.md)|  | 

### Return type

[**Reward**](Reward.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="approveredeemrequest"></a>
# **ApproveRedeemRequest**
> RedeemRequest ApproveRedeemRequest (int? restaurantId, string redeemId)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class ApproveRedeemRequestExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminLoyaltyApi();
            var restaurantId = 56;  // int? | 
            var redeemId = redeemId_example;  // string | 

            try
            {
                RedeemRequest result = apiInstance.ApproveRedeemRequest(restaurantId, redeemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminLoyaltyApi.ApproveRedeemRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **redeemId** | **string**|  | 

### Return type

[**RedeemRequest**](RedeemRequest.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="closemembership"></a>
# **CloseMembership**
> Member CloseMembership (int? restaurantId, int? memberId)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class CloseMembershipExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminLoyaltyApi();
            var restaurantId = 56;  // int? | 
            var memberId = 56;  // int? | 

            try
            {
                Member result = apiInstance.CloseMembership(restaurantId, memberId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminLoyaltyApi.CloseMembership: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **memberId** | **int?**|  | 

### Return type

[**Member**](Member.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletemembership"></a>
# **DeleteMembership**
> Object DeleteMembership (int? restaurantId, int? memberId)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class DeleteMembershipExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminLoyaltyApi();
            var restaurantId = 56;  // int? | 
            var memberId = 56;  // int? | 

            try
            {
                Object result = apiInstance.DeleteMembership(restaurantId, memberId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminLoyaltyApi.DeleteMembership: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **memberId** | **int?**|  | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletereward"></a>
# **DeleteReward**
> void DeleteReward (int? restaurantId, string rewardId)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class DeleteRewardExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminLoyaltyApi();
            var restaurantId = 56;  // int? | 
            var rewardId = rewardId_example;  // string | 

            try
            {
                apiInstance.DeleteReward(restaurantId, rewardId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminLoyaltyApi.DeleteReward: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **rewardId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="exportmembers"></a>
# **ExportMembers**
> Object ExportMembers (int? restaurantId)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class ExportMembersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminLoyaltyApi();
            var restaurantId = 56;  // int? | 

            try
            {
                Object result = apiInstance.ExportMembers(restaurantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminLoyaltyApi.ExportMembers: " + e.Message );
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

<a name="filter"></a>
# **Filter**
> List<CustomerProfile> Filter (int? restaurantId, int? take, string token)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class FilterExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminLoyaltyApi();
            var restaurantId = 56;  // int? | 
            var take = 56;  // int? | 
            var token = token_example;  // string | 

            try
            {
                List&lt;CustomerProfile&gt; result = apiInstance.Filter(restaurantId, take, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminLoyaltyApi.Filter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **take** | **int?**|  | 
 **token** | **string**|  | 

### Return type

[**List<CustomerProfile>**](CustomerProfile.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findmemberbyphonenumber"></a>
# **FindMemberByPhoneNumber**
> Member FindMemberByPhoneNumber (int? restaurantId, string phoneNumber)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class FindMemberByPhoneNumberExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminLoyaltyApi();
            var restaurantId = 56;  // int? | 
            var phoneNumber = phoneNumber_example;  // string | 

            try
            {
                Member result = apiInstance.FindMemberByPhoneNumber(restaurantId, phoneNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminLoyaltyApi.FindMemberByPhoneNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **phoneNumber** | **string**|  | 

### Return type

[**Member**](Member.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getalrewards"></a>
# **GetAlRewards**
> List<Reward> GetAlRewards (int? restaurantId)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class GetAlRewardsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminLoyaltyApi();
            var restaurantId = 56;  // int? | 

            try
            {
                List&lt;Reward&gt; result = apiInstance.GetAlRewards(restaurantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminLoyaltyApi.GetAlRewards: " + e.Message );
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

[**List<Reward>**](Reward.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallmembers"></a>
# **GetAllMembers**
> ODataPagedResult1MemberContract GetAllMembers (int? restaurantId)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class GetAllMembersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminLoyaltyApi();
            var restaurantId = 56;  // int? | 

            try
            {
                ODataPagedResult1MemberContract result = apiInstance.GetAllMembers(restaurantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminLoyaltyApi.GetAllMembers: " + e.Message );
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

[**ODataPagedResult1MemberContract**](ODataPagedResult1MemberContract.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallredeemrequests"></a>
# **GetAllRedeemRequests**
> List<RedeemRequest> GetAllRedeemRequests (int? restaurantId)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class GetAllRedeemRequestsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminLoyaltyApi();
            var restaurantId = 56;  // int? | 

            try
            {
                List&lt;RedeemRequest&gt; result = apiInstance.GetAllRedeemRequests(restaurantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminLoyaltyApi.GetAllRedeemRequests: " + e.Message );
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

[**List<RedeemRequest>**](RedeemRequest.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdefaultloyaltysettings"></a>
# **GetDefaultLoyaltySettings**
> LoyaltySettings GetDefaultLoyaltySettings (int? restaurantId)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class GetDefaultLoyaltySettingsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminLoyaltyApi();
            var restaurantId = 56;  // int? | 

            try
            {
                LoyaltySettings result = apiInstance.GetDefaultLoyaltySettings(restaurantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminLoyaltyApi.GetDefaultLoyaltySettings: " + e.Message );
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

[**LoyaltySettings**](LoyaltySettings.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getloyaltysettings"></a>
# **GetLoyaltySettings**
> LoyaltySettings GetLoyaltySettings (int? restaurantId)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class GetLoyaltySettingsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminLoyaltyApi();
            var restaurantId = 56;  // int? | 

            try
            {
                LoyaltySettings result = apiInstance.GetLoyaltySettings(restaurantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminLoyaltyApi.GetLoyaltySettings: " + e.Message );
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

[**LoyaltySettings**](LoyaltySettings.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmembertransactions"></a>
# **GetMemberTransactions**
> ODataPagedResult1TransactionContract GetMemberTransactions (int? restaurantId, int? memberId)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class GetMemberTransactionsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminLoyaltyApi();
            var restaurantId = 56;  // int? | 
            var memberId = 56;  // int? | 

            try
            {
                ODataPagedResult1TransactionContract result = apiInstance.GetMemberTransactions(restaurantId, memberId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminLoyaltyApi.GetMemberTransactions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **memberId** | **int?**|  | 

### Return type

[**ODataPagedResult1TransactionContract**](ODataPagedResult1TransactionContract.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmembervisits"></a>
# **GetMemberVisits**
> ODataPagedResult1MembershipVisitItemContract GetMemberVisits (int? restaurantId, int? memberId)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class GetMemberVisitsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminLoyaltyApi();
            var restaurantId = 56;  // int? | 
            var memberId = 56;  // int? | 

            try
            {
                ODataPagedResult1MembershipVisitItemContract result = apiInstance.GetMemberVisits(restaurantId, memberId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminLoyaltyApi.GetMemberVisits: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **memberId** | **int?**|  | 

### Return type

[**ODataPagedResult1MembershipVisitItemContract**](ODataPagedResult1MembershipVisitItemContract.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmembershipinfo"></a>
# **GetMembershipInfo**
> Member GetMembershipInfo (int? restaurantId, int? memberId)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class GetMembershipInfoExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminLoyaltyApi();
            var restaurantId = 56;  // int? | 
            var memberId = 56;  // int? | 

            try
            {
                Member result = apiInstance.GetMembershipInfo(restaurantId, memberId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminLoyaltyApi.GetMembershipInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **memberId** | **int?**|  | 

### Return type

[**Member**](Member.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrewardbyid"></a>
# **GetRewardById**
> Reward GetRewardById (int? restaurantId, string rewardId)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class GetRewardByIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminLoyaltyApi();
            var restaurantId = 56;  // int? | 
            var rewardId = rewardId_example;  // string | 

            try
            {
                Reward result = apiInstance.GetRewardById(restaurantId, rewardId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminLoyaltyApi.GetRewardById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **rewardId** | **string**|  | 

### Return type

[**Reward**](Reward.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="incomingcall"></a>
# **IncomingCall**
> Object IncomingCall (int? restaurantId, IncomingCall callContract)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class IncomingCallExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminLoyaltyApi();
            var restaurantId = 56;  // int? | 
            var callContract = new IncomingCall(); // IncomingCall | 

            try
            {
                Object result = apiInstance.IncomingCall(restaurantId, callContract);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminLoyaltyApi.IncomingCall: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **callContract** | [**IncomingCall**](IncomingCall.md)|  | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="publishreward"></a>
# **PublishReward**
> Reward PublishReward (int? restaurantId, string rewardId)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class PublishRewardExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminLoyaltyApi();
            var restaurantId = 56;  // int? | 
            var rewardId = rewardId_example;  // string | 

            try
            {
                Reward result = apiInstance.PublishReward(restaurantId, rewardId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminLoyaltyApi.PublishReward: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **rewardId** | **string**|  | 

### Return type

[**Reward**](Reward.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rejectredeemrequest"></a>
# **RejectRedeemRequest**
> RedeemRequest RejectRedeemRequest (int? restaurantId, string redeemId, RedeemRequestReject reject)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class RejectRedeemRequestExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminLoyaltyApi();
            var restaurantId = 56;  // int? | 
            var redeemId = redeemId_example;  // string | 
            var reject = new RedeemRequestReject(); // RedeemRequestReject | 

            try
            {
                RedeemRequest result = apiInstance.RejectRedeemRequest(restaurantId, redeemId, reject);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminLoyaltyApi.RejectRedeemRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **redeemId** | **string**|  | 
 **reject** | [**RedeemRequestReject**](RedeemRequestReject.md)|  | 

### Return type

[**RedeemRequest**](RedeemRequest.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setloyaltysettings"></a>
# **SetLoyaltySettings**
> void SetLoyaltySettings (int? restaurantId, LoyaltySettings settings)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class SetLoyaltySettingsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminLoyaltyApi();
            var restaurantId = 56;  // int? | 
            var settings = new LoyaltySettings(); // LoyaltySettings | 

            try
            {
                apiInstance.SetLoyaltySettings(restaurantId, settings);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminLoyaltyApi.SetLoyaltySettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **settings** | [**LoyaltySettings**](LoyaltySettings.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unpublishreward"></a>
# **UnpublishReward**
> Reward UnpublishReward (int? restaurantId, string rewardId)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class UnpublishRewardExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminLoyaltyApi();
            var restaurantId = 56;  // int? | 
            var rewardId = rewardId_example;  // string | 

            try
            {
                Reward result = apiInstance.UnpublishReward(restaurantId, rewardId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminLoyaltyApi.UnpublishReward: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **rewardId** | **string**|  | 

### Return type

[**Reward**](Reward.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemember"></a>
# **UpdateMember**
> Member UpdateMember (int? restaurantId, int? memberId, MembershipUpdate contract)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class UpdateMemberExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminLoyaltyApi();
            var restaurantId = 56;  // int? | 
            var memberId = 56;  // int? | 
            var contract = new MembershipUpdate(); // MembershipUpdate | 

            try
            {
                Member result = apiInstance.UpdateMember(restaurantId, memberId, contract);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminLoyaltyApi.UpdateMember: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **memberId** | **int?**|  | 
 **contract** | [**MembershipUpdate**](MembershipUpdate.md)|  | 

### Return type

[**Member**](Member.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatereward"></a>
# **UpdateReward**
> Reward UpdateReward (int? restaurantId, string rewardId, Reward reward)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class UpdateRewardExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminLoyaltyApi();
            var restaurantId = 56;  // int? | 
            var rewardId = rewardId_example;  // string | 
            var reward = new Reward(); // Reward | 

            try
            {
                Reward result = apiInstance.UpdateReward(restaurantId, rewardId, reward);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminLoyaltyApi.UpdateReward: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **rewardId** | **string**|  | 
 **reward** | [**Reward**](Reward.md)|  | 

### Return type

[**Reward**](Reward.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

