using System.Text.Json.Serialization;

namespace Saison.Models.Untappd
{
    public class ResponseTime
    {
        [JsonPropertyName("time")]
        public float Time { get; set; }

        [JsonPropertyName("measure")]
        public string Measure { get; set; }
    }
}