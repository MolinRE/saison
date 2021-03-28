using System.Text.Json.Serialization;

namespace Saison.Models.Activity
{
    public class VenueFoursquare
    {
        [JsonPropertyName("foursquare_id")]
        public string FoursquareId { get; set; }

        [JsonPropertyName("foursquare_url")]
        public string FoursquareUrl { get; set; }
    }
}