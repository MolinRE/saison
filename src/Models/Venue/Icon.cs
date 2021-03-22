using System.Text.Json.Serialization;

namespace Saison.Models.Venue
{
    public class Icon
    {
        [JsonPropertyName("sm")]
        public string Sm { get; set; }

        [JsonPropertyName("md")]
        public string Md { get; set; }

        [JsonPropertyName("lg")]
        public string Lg { get; set; }
    }
}