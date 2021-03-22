using System.Text.Json.Serialization;

namespace Saison.Models.Brewery
{
    public class MediaBeer
    {
        [JsonPropertyName("bid")]
        public int Bid { get; set; }

        [JsonPropertyName("beer_name")]
        public string BeerName { get; set; }

        [JsonPropertyName("beer_abv")]
        public double BeerAbv { get; set; }

        [JsonPropertyName("beer_label")]
        public string BeerLabel { get; set; }

        [JsonPropertyName("beer_style")]
        public string BeerStyle { get; set; }
    }
}