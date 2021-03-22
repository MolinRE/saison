using System.Text.Json.Serialization;

namespace Saison.Models.Beer
{
    public class BeerSearchResponse
    {
        [JsonPropertyName("message")]
        public string Message { get; set; } 

        [JsonPropertyName("time_taken")]
        public double TimeTaken { get; set; } 

        [JsonPropertyName("brewery_id")]
        public int BreweryId { get; set; } 

        [JsonPropertyName("search_type")]
        public string SearchType { get; set; } 

        [JsonPropertyName("type_id")]
        public int TypeId { get; set; } 

        [JsonPropertyName("search_version")]
        public int SearchVersion { get; set; } 

        [JsonPropertyName("found")]
        public int Found { get; set; } 

        [JsonPropertyName("offset")]
        public int Offset { get; set; } 

        [JsonPropertyName("limit")]
        public int Limit { get; set; } 

        [JsonPropertyName("term")]
        public string Term { get; set; } 

        [JsonPropertyName("parsed_term")]
        public string ParsedTerm { get; set; } 

        [JsonPropertyName("beers")]
        public Search Beers { get; set; } 

        [JsonPropertyName("homebrew")]
        public Homebrew Homebrew { get; set; } 

        [JsonPropertyName("breweries")]
        public Breweries Breweries { get; set; } 
    }
}