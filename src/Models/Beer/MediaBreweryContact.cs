using System.Text.Json.Serialization;

namespace Saison.Models.Beer
{
    public class MediaBreweryContact
    {
        [JsonPropertyName("twitter")]
        public string Twitter { get; set; }

        [JsonPropertyName("facebook")]
        public string Facebook { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}