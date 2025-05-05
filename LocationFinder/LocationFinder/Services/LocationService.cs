using System;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using LocationFinder.Models;
using LocationFinder.Utilities;
using LocationFinder.Utilities.Exceptions;

namespace LocationFinder.Services
{
    public class LocationService : ILocationService
    {
       

        public async Task<LocationResult> FindLocationAsync(string query)
        {
            var url = $"{LocationFinder.Utilities.Enviroment.BaseUrl}?key={LocationFinder.Utilities.Enviroment.ApiKey}&q={Uri.EscapeDataString(query)}&format=json";

            var response = await ApiClient.GetAsync(url);

            if (response == null)
                throw new NullResponseException("No response from the LocationIQ API.");


            var locations = JsonSerializer.Deserialize<LocationResult[]>(response);
            if (locations == null || !locations.Any())
                throw new NullResponseException("Location Not found.");
            return locations?.First();
        }
    }
}
