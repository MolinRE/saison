using System.Text.Json.Serialization;

namespace Saison.Models.Beer
{
    public class Contact
    {
        [JsonPropertyName("twitter")]
        public string Twitter { get; set; }

        [JsonPropertyName("facebook")]
        public string Facebook { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("instagram")]
        public string Instagram { get; set; }
    }
}