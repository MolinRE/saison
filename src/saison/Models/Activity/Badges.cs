using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Saison.Models.Activity
{
    public class Badges
    {
        [JsonPropertyName("retro_status")]
        public bool RetroStatus { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("items")]
        public List<Badge> Items { get; set; }
    }
}