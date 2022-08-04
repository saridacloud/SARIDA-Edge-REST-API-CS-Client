# IO.Swagger.Api.InspectionApi

All URIs are relative to *https://virtserver.swaggerhub.com/esicteam/SaridaEdgeAPI/1.2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**InspectionDamageAddedPost**](InspectionApi.md#inspectiondamageaddedpost) | **POST** /inspection/damageAdded | 
[**InspectionRunBeginPausePut**](InspectionApi.md#inspectionrunbeginpauseput) | **PUT** /inspection/run/beginPause | 
[**InspectionRunEndPausePut**](InspectionApi.md#inspectionrunendpauseput) | **PUT** /inspection/run/endPause | 
[**InspectionRunGet**](InspectionApi.md#inspectionrunget) | **GET** /inspection/run | 
[**InspectionRunStartPut**](InspectionApi.md#inspectionrunstartput) | **PUT** /inspection/run/start | 
[**InspectionRunStopPut**](InspectionApi.md#inspectionrunstopput) | **PUT** /inspection/run/stop | 
[**InspectionSectionDataGet**](InspectionApi.md#inspectionsectiondataget) | **GET** /inspection/sectionData | 
[**InspectionSectionDataPut**](InspectionApi.md#inspectionsectiondataput) | **PUT** /inspection/sectionData | 

<a name="inspectiondamageaddedpost"></a>
# **InspectionDamageAddedPost**
> void InspectionDamageAddedPost (DamageData body)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InspectionDamageAddedPostExample
    {
        public void main()
        {
            var apiInstance = new InspectionApi();
            var body = new DamageData(); // DamageData | 

            try
            {
                apiInstance.InspectionDamageAddedPost(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InspectionApi.InspectionDamageAddedPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DamageData**](DamageData.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="inspectionrunbeginpauseput"></a>
# **InspectionRunBeginPausePut**
> void InspectionRunBeginPausePut (FrameTime body)



Pause inspection

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InspectionRunBeginPausePutExample
    {
        public void main()
        {
            var apiInstance = new InspectionApi();
            var body = new FrameTime(); // FrameTime | 

            try
            {
                apiInstance.InspectionRunBeginPausePut(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InspectionApi.InspectionRunBeginPausePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FrameTime**](FrameTime.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="inspectionrunendpauseput"></a>
# **InspectionRunEndPausePut**
> void InspectionRunEndPausePut (FrameTime body)



Resume inspection

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InspectionRunEndPausePutExample
    {
        public void main()
        {
            var apiInstance = new InspectionApi();
            var body = new FrameTime(); // FrameTime | 

            try
            {
                apiInstance.InspectionRunEndPausePut(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InspectionApi.InspectionRunEndPausePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FrameTime**](FrameTime.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="inspectionrunget"></a>
# **InspectionRunGet**
> InspectionRunStatus InspectionRunGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InspectionRunGetExample
    {
        public void main()
        {
            var apiInstance = new InspectionApi();

            try
            {
                InspectionRunStatus result = apiInstance.InspectionRunGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InspectionApi.InspectionRunGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InspectionRunStatus**](InspectionRunStatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="inspectionrunstartput"></a>
# **InspectionRunStartPut**
> void InspectionRunStartPut (FrameTime body)



Start inspection

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InspectionRunStartPutExample
    {
        public void main()
        {
            var apiInstance = new InspectionApi();
            var body = new FrameTime(); // FrameTime | 

            try
            {
                apiInstance.InspectionRunStartPut(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InspectionApi.InspectionRunStartPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FrameTime**](FrameTime.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="inspectionrunstopput"></a>
# **InspectionRunStopPut**
> void InspectionRunStopPut ()



Stop inspection

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InspectionRunStopPutExample
    {
        public void main()
        {
            var apiInstance = new InspectionApi();

            try
            {
                apiInstance.InspectionRunStopPut();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InspectionApi.InspectionRunStopPut: " + e.Message );
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
<a name="inspectionsectiondataget"></a>
# **InspectionSectionDataGet**
> SectionBaseData InspectionSectionDataGet ()



Get last received section data.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InspectionSectionDataGetExample
    {
        public void main()
        {
            var apiInstance = new InspectionApi();

            try
            {
                SectionBaseData result = apiInstance.InspectionSectionDataGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InspectionApi.InspectionSectionDataGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**SectionBaseData**](SectionBaseData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="inspectionsectiondataput"></a>
# **InspectionSectionDataPut**
> void InspectionSectionDataPut (SectionBaseData body)



Update section data.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InspectionSectionDataPutExample
    {
        public void main()
        {
            var apiInstance = new InspectionApi();
            var body = new SectionBaseData(); // SectionBaseData | 

            try
            {
                apiInstance.InspectionSectionDataPut(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InspectionApi.InspectionSectionDataPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SectionBaseData**](SectionBaseData.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
