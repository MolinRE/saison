using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Saison.Models.Beer
{
    public class SimilarBeers
    {
        [JsonPropertyName("method")]
        public string Method { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("items")]
        public List<SimilarBeer> Items { get; set; }
    }
}