using System.Text.Json.Serialization;

namespace Saison.Models.Beer
{
    public class MediaVenueFoursquare
    {
        [JsonPropertyName("foursquare_id")]
        public string FoursquareId { get; set; }

        [JsonPropertyName("foursquare_url")]
        public string FoursquareUrl { get; set; }
    }
}