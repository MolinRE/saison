using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Saison.Models.Activity
{
    public class Media
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("items")]
        public List<MediaItem> Items { get; set; }
    }
}