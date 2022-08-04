# IO.Swagger.Api.GUIApi

All URIs are relative to *https://virtserver.swaggerhub.com/esicteam/SaridaEdgeAPI/1.2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ControlGuiDetectionAreaVisibilityGet**](GUIApi.md#controlguidetectionareavisibilityget) | **GET** /control/gui/detectionAreaVisibility | 
[**ControlGuiDetectionAreaVisibilityPost**](GUIApi.md#controlguidetectionareavisibilitypost) | **POST** /control/gui/detectionAreaVisibility | 
[**ControlGuiDetectionBoundingBoxVisibilityGet**](GUIApi.md#controlguidetectionboundingboxvisibilityget) | **GET** /control/gui/detectionBoundingBoxVisibility | 
[**ControlGuiDetectionBoundingBoxVisibilityPost**](GUIApi.md#controlguidetectionboundingboxvisibilitypost) | **POST** /control/gui/detectionBoundingBoxVisibility | 
[**ControlGuiDetectionColorGet**](GUIApi.md#controlguidetectioncolorget) | **GET** /control/gui/detectionColor | 
[**ControlGuiDetectionColorPost**](GUIApi.md#controlguidetectioncolorpost) | **POST** /control/gui/detectionColor | 
[**ControlGuiDetectionPolygonVisibilityGet**](GUIApi.md#controlguidetectionpolygonvisibilityget) | **GET** /control/gui/detectionPolygonVisibility | 
[**ControlGuiDetectionPolygonVisibilityPost**](GUIApi.md#controlguidetectionpolygonvisibilitypost) | **POST** /control/gui/detectionPolygonVisibility | 
[**ControlGuiDetectionTextVisibilityGet**](GUIApi.md#controlguidetectiontextvisibilityget) | **GET** /control/gui/detectionTextVisibility | 
[**ControlGuiDetectionTextVisibilityPost**](GUIApi.md#controlguidetectiontextvisibilitypost) | **POST** /control/gui/detectionTextVisibility | 
[**ControlGuiDetectionsVisibilityGet**](GUIApi.md#controlguidetectionsvisibilityget) | **GET** /control/gui/detectionsVisibility | 
[**ControlGuiDetectionsVisibilityPost**](GUIApi.md#controlguidetectionsvisibilitypost) | **POST** /control/gui/detectionsVisibility | 

<a name="controlguidetectionareavisibilityget"></a>
# **ControlGuiDetectionAreaVisibilityGet**
> bool? ControlGuiDetectionAreaVisibilityGet ()



'Return if detection areas are currently visible in edge GUI' 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ControlGuiDetectionAreaVisibilityGetExample
    {
        public void main()
        {
            var apiInstance = new GUIApi();

            try
            {
                bool? result = apiInstance.ControlGuiDetectionAreaVisibilityGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GUIApi.ControlGuiDetectionAreaVisibilityGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**bool?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="controlguidetectionareavisibilitypost"></a>
# **ControlGuiDetectionAreaVisibilityPost**
> void ControlGuiDetectionAreaVisibilityPost (bool? setVisible)



Set visibility of detection areas in edge GUI

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ControlGuiDetectionAreaVisibilityPostExample
    {
        public void main()
        {
            var apiInstance = new GUIApi();
            var setVisible = true;  // bool? | 

            try
            {
                apiInstance.ControlGuiDetectionAreaVisibilityPost(setVisible);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GUIApi.ControlGuiDetectionAreaVisibilityPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **setVisible** | **bool?**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="controlguidetectionboundingboxvisibilityget"></a>
# **ControlGuiDetectionBoundingBoxVisibilityGet**
> bool? ControlGuiDetectionBoundingBoxVisibilityGet ()



'Return if detection bounding boxes are currently visible in ' 'edge GUI' 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ControlGuiDetectionBoundingBoxVisibilityGetExample
    {
        public void main()
        {
            var apiInstance = new GUIApi();

            try
            {
                bool? result = apiInstance.ControlGuiDetectionBoundingBoxVisibilityGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GUIApi.ControlGuiDetectionBoundingBoxVisibilityGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**bool?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="controlguidetectionboundingboxvisibilitypost"></a>
# **ControlGuiDetectionBoundingBoxVisibilityPost**
> void ControlGuiDetectionBoundingBoxVisibilityPost (bool? setVisible)



'Set visibility of detection bounding boxes in edge GUI' 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ControlGuiDetectionBoundingBoxVisibilityPostExample
    {
        public void main()
        {
            var apiInstance = new GUIApi();
            var setVisible = true;  // bool? | 

            try
            {
                apiInstance.ControlGuiDetectionBoundingBoxVisibilityPost(setVisible);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GUIApi.ControlGuiDetectionBoundingBoxVisibilityPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **setVisible** | **bool?**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="controlguidetectioncolorget"></a>
# **ControlGuiDetectionColorGet**
> Color ControlGuiDetectionColorGet (DetectionClasses detectionClass)



Return color of detection class in edge GUI

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ControlGuiDetectionColorGetExample
    {
        public void main()
        {
            var apiInstance = new GUIApi();
            var detectionClass = new DetectionClasses(); // DetectionClasses | 

            try
            {
                Color result = apiInstance.ControlGuiDetectionColorGet(detectionClass);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GUIApi.ControlGuiDetectionColorGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **detectionClass** | [**DetectionClasses**](DetectionClasses.md)|  | 

### Return type

[**Color**](Color.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="controlguidetectioncolorpost"></a>
# **ControlGuiDetectionColorPost**
> void ControlGuiDetectionColorPost (GuiDetectionColorBody body)



Set color of detection class in edge GUI

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ControlGuiDetectionColorPostExample
    {
        public void main()
        {
            var apiInstance = new GUIApi();
            var body = new GuiDetectionColorBody(); // GuiDetectionColorBody | 

            try
            {
                apiInstance.ControlGuiDetectionColorPost(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GUIApi.ControlGuiDetectionColorPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GuiDetectionColorBody**](GuiDetectionColorBody.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="controlguidetectionpolygonvisibilityget"></a>
# **ControlGuiDetectionPolygonVisibilityGet**
> bool? ControlGuiDetectionPolygonVisibilityGet ()



'Return if detection polygons are currently visible in edge '  'GUI' 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ControlGuiDetectionPolygonVisibilityGetExample
    {
        public void main()
        {
            var apiInstance = new GUIApi();

            try
            {
                bool? result = apiInstance.ControlGuiDetectionPolygonVisibilityGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GUIApi.ControlGuiDetectionPolygonVisibilityGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**bool?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="controlguidetectionpolygonvisibilitypost"></a>
# **ControlGuiDetectionPolygonVisibilityPost**
> void ControlGuiDetectionPolygonVisibilityPost (bool? setVisible)



Set visibility of detection polygons in edge GUI

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ControlGuiDetectionPolygonVisibilityPostExample
    {
        public void main()
        {
            var apiInstance = new GUIApi();
            var setVisible = true;  // bool? | 

            try
            {
                apiInstance.ControlGuiDetectionPolygonVisibilityPost(setVisible);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GUIApi.ControlGuiDetectionPolygonVisibilityPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **setVisible** | **bool?**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="controlguidetectiontextvisibilityget"></a>
# **ControlGuiDetectionTextVisibilityGet**
> bool? ControlGuiDetectionTextVisibilityGet ()



'Return if detection texts are currently visible in edge GUI' 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ControlGuiDetectionTextVisibilityGetExample
    {
        public void main()
        {
            var apiInstance = new GUIApi();

            try
            {
                bool? result = apiInstance.ControlGuiDetectionTextVisibilityGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GUIApi.ControlGuiDetectionTextVisibilityGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**bool?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="controlguidetectiontextvisibilitypost"></a>
# **ControlGuiDetectionTextVisibilityPost**
> void ControlGuiDetectionTextVisibilityPost (bool? setVisible)



Set visibility of detection texts in edge GUI

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ControlGuiDetectionTextVisibilityPostExample
    {
        public void main()
        {
            var apiInstance = new GUIApi();
            var setVisible = true;  // bool? | 

            try
            {
                apiInstance.ControlGuiDetectionTextVisibilityPost(setVisible);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GUIApi.ControlGuiDetectionTextVisibilityPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **setVisible** | **bool?**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="controlguidetectionsvisibilityget"></a>
# **ControlGuiDetectionsVisibilityGet**
> bool? ControlGuiDetectionsVisibilityGet ()



'Return if detections are currently visible in edge GUI' 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ControlGuiDetectionsVisibilityGetExample
    {
        public void main()
        {
            var apiInstance = new GUIApi();

            try
            {
                bool? result = apiInstance.ControlGuiDetectionsVisibilityGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GUIApi.ControlGuiDetectionsVisibilityGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**bool?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="controlguidetectionsvisibilitypost"></a>
# **ControlGuiDetectionsVisibilityPost**
> void ControlGuiDetectionsVisibilityPost (bool? setVisible)



Set detections visibility in edge GUI

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ControlGuiDetectionsVisibilityPostExample
    {
        public void main()
        {
            var apiInstance = new GUIApi();
            var setVisible = true;  // bool? | 

            try
            {
                apiInstance.ControlGuiDetectionsVisibilityPost(setVisible);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GUIApi.ControlGuiDetectionsVisibilityPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **setVisible** | **bool?**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
