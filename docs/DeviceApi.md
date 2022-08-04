# IO.Swagger.Api.DeviceApi

All URIs are relative to *https://virtserver.swaggerhub.com/esicteam/SaridaEdgeAPI/1.2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ControlDeviceRestartPost**](DeviceApi.md#controldevicerestartpost) | **POST** /control/device/restart | 
[**ControlDeviceShutdownPost**](DeviceApi.md#controldeviceshutdownpost) | **POST** /control/device/shutdown | 
[**WebHookDelete**](DeviceApi.md#webhookdelete) | **DELETE** /webHook | 
[**WebHookDetectionUpdatesPost**](DeviceApi.md#webhookdetectionupdatespost) | **POST** /webHook/detectionUpdates | 
[**WebHookGet**](DeviceApi.md#webhookget) | **GET** /webHook | 

<a name="controldevicerestartpost"></a>
# **ControlDeviceRestartPost**
> void ControlDeviceRestartPost ()



Restart the edge device

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ControlDeviceRestartPostExample
    {
        public void main()
        {
            var apiInstance = new DeviceApi();

            try
            {
                apiInstance.ControlDeviceRestartPost();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceApi.ControlDeviceRestartPost: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="controldeviceshutdownpost"></a>
# **ControlDeviceShutdownPost**
> void ControlDeviceShutdownPost ()



Shut down the edge device

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ControlDeviceShutdownPostExample
    {
        public void main()
        {
            var apiInstance = new DeviceApi();

            try
            {
                apiInstance.ControlDeviceShutdownPost();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceApi.ControlDeviceShutdownPost: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="webhookdelete"></a>
# **WebHookDelete**
> void WebHookDelete (string webhookID)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WebHookDeleteExample
    {
        public void main()
        {
            var apiInstance = new DeviceApi();
            var webhookID = webhookID_example;  // string | 'Web hook name created by requester (ID), to identify ' 'the registered web hook for later calls.' 

            try
            {
                apiInstance.WebHookDelete(webhookID);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceApi.WebHookDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **webhookID** | **string**| &#x27;Web hook name created by requester (ID), to identify &#x27; &#x27;the registered web hook for later calls.&#x27;  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="webhookdetectionupdatespost"></a>
# **WebHookDetectionUpdatesPost**
> void WebHookDetectionUpdatesPost (WebHookProperties body, string webhookID)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WebHookDetectionUpdatesPostExample
    {
        public void main()
        {
            var apiInstance = new DeviceApi();
            var body = new WebHookProperties(); // WebHookProperties | 
            var webhookID = webhookID_example;  // string | 'Web hook name created by requester (ID), to identify ' 'the registered web hook for later calls.' '(e.g.: Generate a new GUID and use it as web hook name)' 

            try
            {
                apiInstance.WebHookDetectionUpdatesPost(body, webhookID);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceApi.WebHookDetectionUpdatesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WebHookProperties**](WebHookProperties.md)|  | 
 **webhookID** | **string**| &#x27;Web hook name created by requester (ID), to identify &#x27; &#x27;the registered web hook for later calls.&#x27; &#x27;(e.g.: Generate a new GUID and use it as web hook name)&#x27;  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="webhookget"></a>
# **WebHookGet**
> WebHookProperties WebHookGet (string webhookID)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WebHookGetExample
    {
        public void main()
        {
            var apiInstance = new DeviceApi();
            var webhookID = webhookID_example;  // string | 'Web hook name created by requester (ID), to identify ' 'the registered web hook for later calls.' 

            try
            {
                WebHookProperties result = apiInstance.WebHookGet(webhookID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceApi.WebHookGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **webhookID** | **string**| &#x27;Web hook name created by requester (ID), to identify &#x27; &#x27;the registered web hook for later calls.&#x27;  | 

### Return type

[**WebHookProperties**](WebHookProperties.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
