# IO.Swagger.Api.CameraApi

All URIs are relative to *https://virtserver.swaggerhub.com/esicteam/SaridaEdgeAPI/1.2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CameraSetOriginOrientationPut**](CameraApi.md#camerasetoriginorientationput) | **PUT** /camera/setOriginOrientation | 
[**CameraStateGet**](CameraApi.md#camerastateget) | **GET** /camera/state | 
[**CameraStatePut**](CameraApi.md#camerastateput) | **PUT** /camera/state | 

<a name="camerasetoriginorientationput"></a>
# **CameraSetOriginOrientationPut**
> void CameraSetOriginOrientationPut (Orientation body)



Set given camera orientation as origin. (Physical camera orientation must be horizontal and straight)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CameraSetOriginOrientationPutExample
    {
        public void main()
        {
            var apiInstance = new CameraApi();
            var body = new Orientation(); // Orientation | 

            try
            {
                apiInstance.CameraSetOriginOrientationPut(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CameraApi.CameraSetOriginOrientationPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Orientation**](Orientation.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="camerastateget"></a>
# **CameraStateGet**
> CameraState CameraStateGet ()



Get last received camera state.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CameraStateGetExample
    {
        public void main()
        {
            var apiInstance = new CameraApi();

            try
            {
                CameraState result = apiInstance.CameraStateGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CameraApi.CameraStateGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**CameraState**](CameraState.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="camerastateput"></a>
# **CameraStatePut**
> void CameraStatePut (CameraState body)



Update camera state.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CameraStatePutExample
    {
        public void main()
        {
            var apiInstance = new CameraApi();
            var body = new CameraState(); // CameraState | 

            try
            {
                apiInstance.CameraStatePut(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CameraApi.CameraStatePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CameraState**](CameraState.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
