using System.Text.Json.Serialization;

namespace Saison.Models.Activity
{
    public class VenueContact
    {
        [JsonPropertyName("twitter")]
        public string Twitter { get; set; }

        [JsonPropertyName("venue_url")]
        public string VenueUrl { get; set; }
    }
}