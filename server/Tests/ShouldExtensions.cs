using System.Net;
using Newtonsoft.Json;
using PMS.Common;
using Xunit;

namespace PMS.Tests;

internal static class ShouldExtensions
{
    public static Task ShouldReturn(this HttpResponseMessage response, HttpStatusCode expectedStatusCode)
    {
        response.AssertCommonResponseParts(expectedStatusCode);
        return Task.CompletedTask;
    }
    
    public static async Task ShouldReturn<T>(this HttpResponseMessage response, HttpStatusCode expectedStatusCode, T expectedContent)
    {
        await response.ShouldReturn(expectedStatusCode);
        Assert.Equal("application/json", response.Content.Headers.ContentType?.MediaType);
        var apiResponse = JsonConvert.DeserializeObject<ApiResponse<T>>(await response.Content.ReadAsStringAsync());
        Assert.True(apiResponse.Success);
        Assert.Equal(JsonConvert.SerializeObject(expectedContent), JsonConvert.SerializeObject(apiResponse.Data));
    }

    private static void AssertCommonResponseParts(this HttpResponseMessage response, HttpStatusCode expectedStatusCode)
    {
        Assert.Equal(expectedStatusCode, response.StatusCode);
    }
}

