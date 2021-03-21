using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Saison.Models
{
    public class BrewerySearch
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }
        
        [JsonPropertyName("items")]
        public List<BrewerySearchItem> Items { get; set; }
    }
}