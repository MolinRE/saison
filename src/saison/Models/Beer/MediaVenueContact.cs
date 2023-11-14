using System.Text.Json.Serialization;

namespace Saison.Models.Beer
{
    public class MediaVenueContact
    {
        [JsonPropertyName("twitter")]
        public string Twitter { get; set; }

        [JsonPropertyName("venue_url")]
        public string VenueUrl { get; set; }
    }
}