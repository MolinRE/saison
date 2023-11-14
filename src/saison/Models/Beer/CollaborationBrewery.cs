using System.Text.Json.Serialization;

namespace Saison.Models.Beer
{
    public class CollaborationBrewery
    {
        [JsonPropertyName("brewery_id")]
        public int Id { get; set; }
        [JsonPropertyName("brewery_name")]
        public string Name { get; set; }
        [JsonPropertyName("brewery_type")]
        public string Type { get; set; }
        [JsonPropertyName("brewery_page_url")]
        public string PageUrl { get; set; }
        [JsonPropertyName("brewery_label")]
        public string Label { get; set; }
        [JsonPropertyName("country_name")]
        public string CountryName { get; set; }
        
        [JsonPropertyName("location")]
        public CollaborationBreweryLocation Location { get; set; }
    }
}