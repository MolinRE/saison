using System.Text.Json.Serialization;

namespace Saison.Models.Feeds.Activity;

public class Beer
{
    [JsonPropertyName("bid")]
    public int Bid { get; set; }

    [JsonPropertyName("beer_name")]
    public string BeerName { get; set; }

    [JsonPropertyName("beer_label")]
    public string BeerLabel { get; set; }

    [JsonPropertyName("beer_label_hd")]
    public string BeerLabelHd { get; set; }

    [JsonPropertyName("beer_style")]
    public string BeerStyle { get; set; }

    [JsonPropertyName("beer_abv")]
    public double BeerAbv { get; set; }

    [JsonPropertyName("has_had")]
    public bool HasHad { get; set; }

    [JsonPropertyName("beer_active")]
    public int BeerActive { get; set; }
}