using System.Text.Json.Serialization;

namespace Saison.Models.Activity
{
    public class VenueIcon
    {
        [JsonPropertyName("sm")]
        public string Sm { get; set; }

        [JsonPropertyName("md")]
        public string Md { get; set; }

        [JsonPropertyName("lg")]
        public string Lg { get; set; }
    }
}