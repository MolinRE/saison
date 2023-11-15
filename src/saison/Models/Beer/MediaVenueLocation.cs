using System.Text.Json.Serialization;

namespace Saison.Models.Beer
{
    public class MediaVenueLocation
    {
        [JsonPropertyName("venue_address")]
        public string VenueAddress { get; set; }

        [JsonPropertyName("venue_city")]
        public string VenueCity { get; set; }

        [JsonPropertyName("venue_state")]
        public string VenueState { get; set; }

        [JsonPropertyName("lat")]
        public double Lat { get; set; }

        [JsonPropertyName("lng")]
        public double Lng { get; set; }
    }
}