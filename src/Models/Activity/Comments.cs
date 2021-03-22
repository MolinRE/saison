using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Saison.Models.Activity
{
    public class Comments
    {
        [JsonPropertyName("total_count")]
        public int TotalCount { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("items")]
        public List<Comment> Items { get; set; }
    }
}