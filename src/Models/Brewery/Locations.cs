using System.Text.Json.Serialization;

namespace Saison.Models.Brewery
{
    public class Locations
    {
        [JsonPropertyName("brewery_address")]
        public string BreweryAddress { get; set; }

        [JsonPropertyName("brewery_city")]
        public string BreweryCity { get; set; }

        [JsonPropertyName("brewery_state")]
        public string BreweryState { get; set; }

        [JsonPropertyName("brewery_lat")]
        public double BreweryLat { get; set; }

        [JsonPropertyName("brewery_lng")]
        public double BreweryLng { get; set; }
    }
}