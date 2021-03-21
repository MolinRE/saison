using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Saison.Models
{
    public class ThePubResponse
    {
        [JsonPropertyName("limit")]
        public int Limit { get; set; }

        [JsonPropertyName("offset")]
        public int Offset { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("pagination")]
        public Pagination Pagination { get; set; }

        [JsonPropertyName("radius")]
        public int Radius { get; set; }

        [JsonPropertyName("dist_pref")]
        public string DistPref { get; set; }

        [JsonPropertyName("checkins")]
        public Checkins Checkins { get; set; }
    }

    public class ThePubResponseContainer : UntappdBasicResponse
    {
        [JsonPropertyName("response")]
        public ThePubResponse Response { get; set; }
    }
}