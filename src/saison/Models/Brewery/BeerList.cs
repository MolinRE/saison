using System.Collections.Generic;
using System.Text.Json.Serialization;
using Saison.Models.Brewery;

namespace Saison.Models.Brewery
{
    public class BeerList
    {
        [JsonPropertyName("show_all_beers")]
        public bool ShowAllBeers { get; set; }

        [JsonPropertyName("has_not_had_before")]
        public bool HasNotHadBefore { get; set; }

        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonPropertyName("total_count")]
        public int TotalCount { get; set; }

        [JsonPropertyName("is_search")]
        public bool IsSearch { get; set; }

        [JsonPropertyName("type_id")]
        public bool TypeId { get; set; }

        [JsonPropertyName("sort")]
        public bool Sort { get; set; }

        [JsonPropertyName("is_multi_type")]
        public bool IsMultiType { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("items")]
        public List<BeerListItem> Items { get; set; }

        [JsonPropertyName("collaborations")]
        public Collaborations BreweryCollaborations { get; set; }

        [JsonPropertyName("sort_name")]
        public string SortName { get; set; }

        [JsonPropertyName("sort_key")]
        public string SortKey { get; set; }
    }
}