using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Saison.Models.Venue
{
    public class Categories
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("items")]
        public List<Category> Items { get; set; }
    }
}