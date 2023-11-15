using System.Collections.Generic;
using System.Text.Json.Serialization;
using Saison.Models.Activity;

namespace Saison.Models.Beer
{
    public class Checkins
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("items")]
        public List<Checkin> Items { get; set; }

        [JsonPropertyName("pagination")]
        public Pagination Pagination { get; set; }
    }
}