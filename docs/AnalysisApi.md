# IO.Swagger.Api.AnalysisApi

All URIs are relative to *https://virtserver.swaggerhub.com/esicteam/SaridaEdgeAPI/1.2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AnalysisResultsCurrentGet**](AnalysisApi.md#analysisresultscurrentget) | **GET** /analysis/results/current | 
[**AnalysisResultsInspectionLogGet**](AnalysisApi.md#analysisresultsinspectionlogget) | **GET** /analysis/results/inspectionLog | 

<a name="analysisresultscurrentget"></a>
# **AnalysisResultsCurrentGet**
> AnalysisResult AnalysisResultsCurrentGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AnalysisResultsCurrentGetExample
    {
        public void main()
        {
            var apiInstance = new AnalysisApi();

            try
            {
                AnalysisResult result = apiInstance.AnalysisResultsCurrentGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalysisApi.AnalysisResultsCurrentGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**AnalysisResult**](AnalysisResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="analysisresultsinspectionlogget"></a>
# **AnalysisResultsInspectionLogGet**
> AnalysisResults AnalysisResultsInspectionLogGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AnalysisResultsInspectionLogGetExample
    {
        public void main()
        {
            var apiInstance = new AnalysisApi();

            try
            {
                AnalysisResults result = apiInstance.AnalysisResultsInspectionLogGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalysisApi.AnalysisResultsInspectionLogGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**AnalysisResults**](AnalysisResults.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
