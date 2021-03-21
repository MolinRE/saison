using System.Text.Json.Serialization;

namespace Saison.Models
{
    public class BrewerySearchMatch
    {
        [JsonPropertyName("brewery_id")]
        public int Id { get; set; }
        
        [JsonPropertyName("beer_count")]
        public int BeerCount { get; set; }

        [JsonPropertyName("brewery_name")]
        public string Name { get; set; }

        [JsonPropertyName("brewery_slug")]
        public string Slug { get; set; }

        [JsonPropertyName("brewery_page_url")]
        public string PageUrl { get; set; }

        [JsonPropertyName("brewery_label")]
        public string Label { get; set; }

        [JsonPropertyName("country_name")]
        public string CountryName { get; set; }

        [JsonPropertyName("location")]
        public Location Location { get; set; }
    }
}