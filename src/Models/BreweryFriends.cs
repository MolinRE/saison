using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Saison.Models
{
    public class BreweryFriends
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("items")]
        public List<object> Items { get; set; }
    }
}