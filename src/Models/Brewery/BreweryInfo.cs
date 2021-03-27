using System.Text.Json.Serialization;
using Saison.Models.Common.Media;

namespace Saison.Models.Brewery
{
    public class BreweryInfoContainer
    {
        [JsonPropertyName("brewery")]
        public BreweryInfo Brewery { get; set; }
    }
    
    public class BreweryInfo
    {
        [JsonPropertyName("brewery_id")]
        public int BreweryId { get; set; }

        [JsonPropertyName("brewery_name")]
        public string BreweryName { get; set; }

        [JsonPropertyName("brewery_slug")]
        public string BrewerySlug { get; set; }

        [JsonPropertyName("brewery_page_url")]
        public string BreweryPageUrl { get; set; }
        
        [JsonPropertyName("brewery_label")]
        public string BreweryLabel { get; set; }
        
        [JsonPropertyName("brewery_label_hd")]
        public string BreweryLabelHd { get; set; }
        
        [JsonPropertyName("country_name")]
        public string CountryName { get; set; }

        [JsonPropertyName("brewery_in_production")]
        public int BreweryInProduction { get; set; }
        
        [JsonPropertyName("is_independent")]
        public int IsIndependent { get; set; }

        [JsonPropertyName("claimed_status")]
        public ClaimedStatus ClaimedStatus { get; set; }
        
        [JsonPropertyName("beer_count")]
        public int BeerCount { get; set; }

        [JsonPropertyName("contact")]
        public Contact Contact { get; set; }

        [JsonPropertyName("brewery_type")]
        public string BreweryType { get; set; }

        [JsonPropertyName("brewery_type_id")]
        public int BreweryTypeId { get; set; }

        [JsonPropertyName("location")]
        public Location Location { get; set; }
        
        [JsonPropertyName("rating")]
        public Rating Rating { get; set; }

        [JsonPropertyName("brewery_description")]
        public string BreweryDescription { get; set; }

        [JsonPropertyName("stats")]
        public Stats Stats { get; set; }
        
        [JsonPropertyName("owners")]
        public Owners Owners { get; set; }

        [JsonPropertyName("media")]
        public MediaCollection<MediaCheckin<MediaBeer, MediaBrewery, MediaVenue>> Media { get; set; }

        [JsonPropertyName("checkins")]
        public Checkins Checkins { get; set; }

        [JsonPropertyName("beer_list")]
        public BeerList BeerList { get; set; }

        [JsonPropertyName("locations")]
        public Location Locations { get; set; }
    }
}