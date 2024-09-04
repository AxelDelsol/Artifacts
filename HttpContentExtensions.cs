using System.Net.Http.Json;
using System.Text.Json;

namespace Artifacts;
public static class HttpContentExtensions
{
    public static async Task<T?> ReadBodyAsAsync<T>(this HttpContent content)
    {
        var serializeOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
        };
        return await content.ReadFromJsonAsync<T>(serializeOptions);
    }
}
