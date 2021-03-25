using System.Text.Json.Serialization;

namespace Saison.Models.Brewery
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

        [JsonPropertyName("beer_ibu")]
        public int BeerIbu { get; set; }

        [JsonPropertyName("beer_slug")]
        public string BeerSlug { get; set; }

        [JsonPropertyName("beer_description")]
        public string BeerDescription { get; set; }

        [JsonPropertyName("is_in_production")]
        public int IsInProduction { get; set; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }

        [JsonPropertyName("user_rating_score")]
        public int UserRatingScore { get; set; }

        [JsonPropertyName("rating_score")]
        public double RatingScore { get; set; }

        [JsonPropertyName("rating_count")]
        public int RatingCount { get; set; }

        [JsonPropertyName("has_had")]
        public object HasHad { get; set; }

        [JsonPropertyName("on_list")]
        public bool OnList { get; set; }

        [JsonPropertyName("auth_rating")]
        public int AuthRating { get; set; }

        [JsonPropertyName("wish_list")]
        public bool WishList { get; set; }
    }
}