using System.Text.Json.Serialization;

namespace Saison.Models.Activity
{
    public class BreweryContact
    {
        [JsonPropertyName("twitter")]
        public string Twitter { get; set; }

        [JsonPropertyName("facebook")]
        public string Facebook { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}