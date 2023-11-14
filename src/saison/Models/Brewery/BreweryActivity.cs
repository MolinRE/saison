using System.Text.Json.Serialization;

namespace Saison.Models.Brewery
{
    public class BreweryActivity
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("pagination")]
        public Pagination Pagination { get; set; }

        [JsonPropertyName("mem")]
        public bool Mem { get; set; }

        [JsonPropertyName("time")]
        public double Time { get; set; }

        [JsonPropertyName("checkins")]
        public Checkins Checkins { get; set; }
    }
}