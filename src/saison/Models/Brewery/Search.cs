using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Saison.Models.Brewery
{
    public class Search
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }
        
        [JsonPropertyName("items")]
        public List<SearchItem> Items { get; set; }
    }
}