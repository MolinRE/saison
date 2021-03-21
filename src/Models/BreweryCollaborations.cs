using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Saison.Models
{
    public class BreweryCollaborations
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("items")]
        public List<object> Items { get; set; }
    }
}