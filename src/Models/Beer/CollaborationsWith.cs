using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Saison.Models.Beer
{
    public class CollaborationsWith
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("items")]
        public List<CollaborationBreweryContainer> Items { get; set; }
    }
}