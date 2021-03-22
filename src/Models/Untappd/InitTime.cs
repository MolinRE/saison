using System.Text.Json.Serialization;

namespace Saison.Models.Untappd
{
    public class InitTime
    {
        [JsonPropertyName("init_time")]
        public float Time { get; set; }
        
        [JsonPropertyName("init_time")]
        public string Measure { get; set; }
    }
}