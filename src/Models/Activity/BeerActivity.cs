using System.Text.Json.Serialization;

namespace Saison.Models.Activity
{
    public class BeerActivity
    {
        [JsonPropertyName("pagination")]
        public Pagination Pagination { get; set; }

        [JsonPropertyName("checkins")]
        public Checkins Checkins { get; set; }
    }
    
    public class BreweryActivity
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("pagination")]
        public Pagination Pagination { get; set; }

        [JsonPropertyName("table")]
        public bool Table { get; set; }

        [JsonPropertyName("mem")]
        public bool Mem { get; set; }

        [JsonPropertyName("time")]
        public double Time { get; set; }

        [JsonPropertyName("checkins")]
        public Checkins Checkins { get; set; }
    }
    
    public class VenueActivity
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("pagination")]
        public Pagination Pagination { get; set; }

        [JsonPropertyName("mem")]
        public bool Mem { get; set; }

        [JsonPropertyName("checkins")]
        public Checkins Checkins { get; set; }
    }
}