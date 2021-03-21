using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Saison.Models
{
    public class BeerInfoResponseContainer : UntappdBasicResponse
    {
        [JsonPropertyName("response")]
        public BeerInfoResponse Response { get; set; } 
    }

    public class BeerInfoResponse
    {
        [JsonPropertyName("beer")]
        public BeerInfoFull Beer { get; set; } 
    }

    public class BeerInfoFull    {
        [JsonPropertyName("bid")]
        public int Bid { get; set; } 

        [JsonPropertyName("beer_name")]
        public string BeerName { get; set; } 

        [JsonPropertyName("beer_label")]
        public string BeerLabel { get; set; } 

        [JsonPropertyName("beer_abv")]
        public double BeerAbv { get; set; } 

        [JsonPropertyName("beer_ibu")]
        public int BeerIbu { get; set; } 

        [JsonPropertyName("beer_slug")]
        public string BeerSlug { get; set; } 

        [JsonPropertyName("beer_description")]
        public string BeerDescription { get; set; } 

        [JsonPropertyName("is_in_production")]
        public int IsInProduction { get; set; } 

        [JsonPropertyName("beer_style_id")]
        public int BeerStyleId { get; set; } 

        [JsonPropertyName("beer_style")]
        public string BeerStyle { get; set; } 

        [JsonPropertyName("rating_score")]
        public double RatingScore { get; set; } 

        [JsonPropertyName("rating_count")]
        public int RatingCount { get; set; } 

        [JsonPropertyName("count")]
        public int Count { get; set; } 

        [JsonPropertyName("beer_active")]
        public int BeerActive { get; set; } 

        [JsonPropertyName("on_list")]
        public bool OnList { get; set; } 

        [JsonPropertyName("has_had")]
        public bool HasHad { get; set; } 

        [JsonPropertyName("auth_rating")]
        public int AuthRating { get; set; } 

        [JsonPropertyName("wish_list")]
        public bool WishList { get; set; } 

        [JsonPropertyName("is_vintage")]
        public int IsVintage { get; set; } 

        [JsonPropertyName("is_variant")]
        public int IsVariant { get; set; } 

        [JsonPropertyName("beer_label_hd")]
        public string BeerLabelHd { get; set; } 

        [JsonPropertyName("is_homebrew")]
        public int IsHomebrew { get; set; } 

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; } 

        // [JsonPropertyName("stats")]
        // public Stats Stats { get; set; } 

        [JsonPropertyName("brewery")]
        public Brewery Brewery { get; set; } 

        // [JsonPropertyName("media")]
        // public Media Media { get; set; } 
        //
        // [JsonPropertyName("checkins")]
        // public Checkins Checkins { get; set; } 
        //
        // [JsonPropertyName("similar")]
        // public Similar Similar { get; set; } 
        //
        // [JsonPropertyName("friends")]
        // public Friends Friends { get; set; } 

        [JsonPropertyName("weighted_rating_score")]
        public double WeightedRatingScore { get; set; } 

        // [JsonPropertyName("vintages")]
        // public Vintages Vintages { get; set; } 
        //
        // [JsonPropertyName("brewed_by")]
        // public BrewedBy BrewedBy { get; set; } 
    }
}