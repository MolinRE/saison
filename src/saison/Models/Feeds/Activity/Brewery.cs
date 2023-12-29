using System.Text.Json.Serialization;

namespace Saison.Models.Feeds.Activity;

public class Brewery
{
    [JsonPropertyName("brewery_id")]
    public int BreweryId { get; set; }

    [JsonPropertyName("brewery_name")]
    public string BreweryName { get; set; }

    [JsonPropertyName("brewery_slug")]
    public string BrewerySlug { get; set; }

    [JsonPropertyName("brewery_page_url")]
    public string BreweryPageUrl { get; set; }

    [JsonPropertyName("brewery_type")]
    public string BreweryType { get; set; }

    [JsonPropertyName("brewery_label")]
    public string BreweryLabel { get; set; }

    [JsonPropertyName("country_name")]
    public string CountryName { get; set; }

    [JsonPropertyName("contact")]
    public Contact Contact { get; set; }

    [JsonPropertyName("location")]
    public Location Location { get; set; }

    [JsonPropertyName("brewery_active")]
    public int BreweryActive { get; set; }
}