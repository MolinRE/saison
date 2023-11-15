using System.Text.Json.Serialization;
using Saison.Models.Brewery;

namespace Saison.Models.Brewery
{
    public class BeerListItem
    {
        [JsonPropertyName("total_user_count")]
        public int TotalUserCount { get; set; }
        
        [JsonPropertyName("has_had")]
        public int? HasHad { get; set; }
        
        [JsonPropertyName("total_count")]
        public int TotalCount { get; set; }
        
        [JsonPropertyName("beer")]
        public Beer Beer { get; set; }
        
        [JsonPropertyName("brewery")]
        public Brewery Brewery { get; set; }
        
        [JsonPropertyName("count")]
        public Friends BreweryFriends { get; set; }
    }
}