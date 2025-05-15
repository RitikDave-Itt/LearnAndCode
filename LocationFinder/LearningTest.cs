using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

class Program
{
    private const string ApiKey = "";
    private const string BaseUrl = "https://us1.locationiq.com/v1";

    static async Task Main()
    {
        await ForwardGeocoding("1600 Amphitheatre Parkway, Mountain View, CA");
    }

    static async Task ForwardGeocoding(string address)
    {
        using var client = new HttpClient();

        var url = $"{BaseUrl}/search?key={ApiKey}&q={Uri.EscapeDataString(address)}&format=json";

        Console.WriteLine($"Requesting: {url}");
        var response = await client.GetStringAsync(url);

        Console.WriteLine("Raw Response:");
        Console.WriteLine(response);

        var data = JsonDocument.Parse(response).RootElement;

        if (data.ValueKind == JsonValueKind.Array && data.GetArrayLength() > 0)
        {
            var firstResult = data[0];
            var lat = firstResult.GetProperty("lat").GetString();
            var lon = firstResult.GetProperty("lon").GetString();

             Console.WriteLine($"Latitude: {lat}");
            Console.WriteLine($"Longitude: {lon}");
        }
        else
        {
            Console.WriteLine("No results found.");
        }
    }
}
