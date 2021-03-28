using System.Text.Json.Serialization;

namespace Saison.Models.Activity
{
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