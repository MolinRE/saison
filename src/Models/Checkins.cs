using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Saison.Models
{
    public class Checkins
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("items")]
        public List<Checkin> Items { get; set; }
    }
}