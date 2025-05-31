using System.Text.Json.Serialization;

namespace LocationFinder.Models
{
    public class LocationResult
    {
        [JsonPropertyName("lat")]
        public string Lat { get; set; }

        [JsonPropertyName("lon")]
        public string Lon { get; set; }
    }
}
