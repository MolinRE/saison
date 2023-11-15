using System.Text.Json.Serialization;

namespace Saison.Models.Untappd
{
    public class InitTime
    {
        [JsonPropertyName("time")]
        public float Time { get; set; }
        
        [JsonPropertyName("measure")]
        public string Measure { get; set; }
    }
}