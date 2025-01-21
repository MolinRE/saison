using System.Text.Json.Serialization;

namespace Saison.Models.Beer
{
    public class Beer
    {
        [JsonPropertyName("bid")]
        public int Bid { get; set; }

        [JsonPropertyName("beer_name")]
        public string BeerName { get; set; }

        [JsonPropertyName("beer_label")]
        public string BeerLabel { get; set; }

        [JsonPropertyName("beer_style")]
        public string BeerStyle { get; set; }

        [JsonPropertyName("beer_abv")]
        public float BeerAbv { get; set; }

        [JsonPropertyName("beer_slug")]
        public string BeerSlug { get; set; }

        [JsonPropertyName("beer_ibu")]
        public int BeerIbu { get; set; }

        [JsonPropertyName("beer_description")]
        public string BeerDescription { get; set; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }

        [JsonPropertyName("in_production")]
        public int InProduction { get; set; }

        [JsonPropertyName("auth_rating")]
        public float AuthRating { get; set; }

        [JsonPropertyName("wish_list")]
        public bool WishList { get; set; }
    }
}