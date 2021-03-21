using System.Text.Json.Serialization;

namespace Saison.Models
{
    public class BrewerySearchResponse
    {
        [JsonPropertyName("engine")]
        public string Engine { get; set; }

        [JsonPropertyName("page")]
        public int Page { get; set; }

        [JsonPropertyName("search_type")]
        public string SearchType { get; set; }

        [JsonPropertyName("sort")]
        public string Sort { get; set; }

        [JsonPropertyName("term")]
        public string Term { get; set; }

        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("found")]
        public int Found { get; set; }

        [JsonPropertyName("brewery")]
        public BrewerySearch Result { get; set; }
    }
}