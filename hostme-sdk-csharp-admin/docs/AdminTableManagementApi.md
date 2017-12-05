# HostMe.Sdk.Api.AdminTableManagementApi

All URIs are relative to *http://hostme-services-dev.azurewebsites.net*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateNewFloor**](AdminTableManagementApi.md#createnewfloor) | **POST** /api/tm/admin/restaurants/{restaurantId}/floors | 
[**DeleteFloor**](AdminTableManagementApi.md#deletefloor) | **DELETE** /api/tm/admin/restaurants/{restaurantId}/floors/{floorId} | 
[**GetFloorDetails**](AdminTableManagementApi.md#getfloordetails) | **GET** /api/tm/admin/restaurants/{restaurantId}/floors/{floorId} | 
[**GetRestaurantFloors**](AdminTableManagementApi.md#getrestaurantfloors) | **GET** /api/tm/admin/restaurants/{restaurantId}/floors | 
[**GetTableMonitors**](AdminTableManagementApi.md#gettablemonitors) | **GET** /api/tm/admin/restaurants/{restaurantId}/tables/monitors | 
[**GetTableUsersList**](AdminTableManagementApi.md#gettableuserslist) | **GET** /api/tm/admin/restaurants/{restaurantId}/tables/users | 
[**GetTables**](AdminTableManagementApi.md#gettables) | **GET** /api/tm/admin/restaurants/{restaurantId}/tables | 
[**GetTablesSettings**](AdminTableManagementApi.md#gettablessettings) | **GET** /api/tm/admin/restaurants/{restaurantId}/tables/settings | 
[**ReleaseTable**](AdminTableManagementApi.md#releasetable) | **PUT** /api/tm/admin/restaurants/{restaurantId}/tables/{bookingId}/release | 
[**SetTableState**](AdminTableManagementApi.md#settablestate) | **PUT** /api/tm/admin/restaurants/{restaurantId}/tables/state | 
[**SetTablesSettings**](AdminTableManagementApi.md#settablessettings) | **PUT** /api/tm/admin/restaurants/{restaurantId}/tables/settings | 
[**UpdateFloor**](AdminTableManagementApi.md#updatefloor) | **PUT** /api/tm/admin/restaurants/{restaurantId}/floors/{floorId} | 
[**UpdateSeatedParty**](AdminTableManagementApi.md#updateseatedparty) | **PUT** /api/tm/admin/restaurants/{restaurantId}/seat/{registrationId} | 


<a name="createnewfloor"></a>
# **CreateNewFloor**
> Floor CreateNewFloor (int? restaurantId, Floor floor)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class CreateNewFloorExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminTableManagementApi();
            var restaurantId = 56;  // int? | 
            var floor = new Floor(); // Floor | 

            try
            {
                Floor result = apiInstance.CreateNewFloor(restaurantId, floor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminTableManagementApi.CreateNewFloor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **floor** | [**Floor**](Floor.md)|  | 

### Return type

[**Floor**](Floor.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletefloor"></a>
# **DeleteFloor**
> void DeleteFloor (int? restaurantId, string floorId)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class DeleteFloorExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminTableManagementApi();
            var restaurantId = 56;  // int? | 
            var floorId = floorId_example;  // string | 

            try
            {
                apiInstance.DeleteFloor(restaurantId, floorId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminTableManagementApi.DeleteFloor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **floorId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfloordetails"></a>
# **GetFloorDetails**
> Floor GetFloorDetails (int? restaurantId, string floorId)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class GetFloorDetailsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminTableManagementApi();
            var restaurantId = 56;  // int? | 
            var floorId = floorId_example;  // string | 

            try
            {
                Floor result = apiInstance.GetFloorDetails(restaurantId, floorId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminTableManagementApi.GetFloorDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **floorId** | **string**|  | 

### Return type

[**Floor**](Floor.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrestaurantfloors"></a>
# **GetRestaurantFloors**
> List<FloorInfo> GetRestaurantFloors (int? restaurantId)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class GetRestaurantFloorsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminTableManagementApi();
            var restaurantId = 56;  // int? | 

            try
            {
                List&lt;FloorInfo&gt; result = apiInstance.GetRestaurantFloors(restaurantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminTableManagementApi.GetRestaurantFloors: " + e.Message );
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

[**List<FloorInfo>**](FloorInfo.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettablemonitors"></a>
# **GetTableMonitors**
> RestaurantState GetTableMonitors (int? restaurantId, DateTimeOffset? time = null, int? tableTurnOver = null)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class GetTableMonitorsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminTableManagementApi();
            var restaurantId = 56;  // int? | 
            var time = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? |  (optional) 
            var tableTurnOver = 56;  // int? |  (optional) 

            try
            {
                RestaurantState result = apiInstance.GetTableMonitors(restaurantId, time, tableTurnOver);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminTableManagementApi.GetTableMonitors: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **time** | **DateTimeOffset?**|  | [optional] 
 **tableTurnOver** | **int?**|  | [optional] 

### Return type

[**RestaurantState**](RestaurantState.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettableuserslist"></a>
# **GetTableUsersList**
> List<Booking> GetTableUsersList (int? restaurantId)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class GetTableUsersListExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminTableManagementApi();
            var restaurantId = 56;  // int? | 

            try
            {
                List&lt;Booking&gt; result = apiInstance.GetTableUsersList(restaurantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminTableManagementApi.GetTableUsersList: " + e.Message );
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

[**List<Booking>**](Booking.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettables"></a>
# **GetTables**
> List<Table> GetTables (int? restaurantId)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class GetTablesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminTableManagementApi();
            var restaurantId = 56;  // int? | 

            try
            {
                List&lt;Table&gt; result = apiInstance.GetTables(restaurantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminTableManagementApi.GetTables: " + e.Message );
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

[**List<Table>**](Table.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettablessettings"></a>
# **GetTablesSettings**
> TablesSettings GetTablesSettings (int? restaurantId)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class GetTablesSettingsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminTableManagementApi();
            var restaurantId = 56;  // int? | 

            try
            {
                TablesSettings result = apiInstance.GetTablesSettings(restaurantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminTableManagementApi.GetTablesSettings: " + e.Message );
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

[**TablesSettings**](TablesSettings.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="releasetable"></a>
# **ReleaseTable**
> Object ReleaseTable (int? restaurantId, string bookingId)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class ReleaseTableExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminTableManagementApi();
            var restaurantId = 56;  // int? | 
            var bookingId = bookingId_example;  // string | 

            try
            {
                Object result = apiInstance.ReleaseTable(restaurantId, bookingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminTableManagementApi.ReleaseTable: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **bookingId** | **string**|  | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="settablestate"></a>
# **SetTableState**
> void SetTableState (int? restaurantId, ChangeTableState contract)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class SetTableStateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminTableManagementApi();
            var restaurantId = 56;  // int? | 
            var contract = new ChangeTableState(); // ChangeTableState | 

            try
            {
                apiInstance.SetTableState(restaurantId, contract);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminTableManagementApi.SetTableState: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **contract** | [**ChangeTableState**](ChangeTableState.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="settablessettings"></a>
# **SetTablesSettings**
> void SetTablesSettings (int? restaurantId, TablesSettings settings)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class SetTablesSettingsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminTableManagementApi();
            var restaurantId = 56;  // int? | 
            var settings = new TablesSettings(); // TablesSettings | 

            try
            {
                apiInstance.SetTablesSettings(restaurantId, settings);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminTableManagementApi.SetTablesSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **settings** | [**TablesSettings**](TablesSettings.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatefloor"></a>
# **UpdateFloor**
> Floor UpdateFloor (int? restaurantId, string floorId, Floor floor)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class UpdateFloorExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminTableManagementApi();
            var restaurantId = 56;  // int? | 
            var floorId = floorId_example;  // string | 
            var floor = new Floor(); // Floor | 

            try
            {
                Floor result = apiInstance.UpdateFloor(restaurantId, floorId, floor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminTableManagementApi.UpdateFloor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **floorId** | **string**|  | 
 **floor** | [**Floor**](Floor.md)|  | 

### Return type

[**Floor**](Floor.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateseatedparty"></a>
# **UpdateSeatedParty**
> Object UpdateSeatedParty (int? restaurantId, string registrationId, RegisterAtTable contract)



### Example
```csharp
using System;
using System.Diagnostics;
using HostMe.Sdk.Api;
using HostMe.Sdk.Client;
using HostMe.Sdk.Model;

namespace Example
{
    public class UpdateSeatedPartyExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdminTableManagementApi();
            var restaurantId = 56;  // int? | 
            var registrationId = registrationId_example;  // string | 
            var contract = new RegisterAtTable(); // RegisterAtTable | 

            try
            {
                Object result = apiInstance.UpdateSeatedParty(restaurantId, registrationId, contract);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminTableManagementApi.UpdateSeatedParty: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restaurantId** | **int?**|  | 
 **registrationId** | **string**|  | 
 **contract** | [**RegisterAtTable**](RegisterAtTable.md)|  | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

