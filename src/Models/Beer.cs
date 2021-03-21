using System.Text.Json.Serialization;

namespace Saison.Models
{
    public class Beer
    {
        [JsonPropertyName("bid")]
        public int Bid { get; set; }

        [JsonPropertyName("beer_name")]
        public string Name { get; set; }
        
        [JsonPropertyName("beer_slug")]
        public string Slug { get; set; }

        [JsonPropertyName("beer_label")]
        public string Label { get; set; }

        [JsonPropertyName("beer_label_hd")]
        public string LabelHd { get; set; }

        [JsonPropertyName("beer_style")]
        public string Style { get; set; }

        [JsonPropertyName("beer_abv")]
        public double Abv { get; set; }

        [JsonPropertyName("has_had")]
        public bool HasHad { get; set; }

        [JsonPropertyName("beer_active")]
        public int Active { get; set; }
    }
}