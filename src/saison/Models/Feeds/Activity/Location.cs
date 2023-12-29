using System.Text.Json.Serialization;

namespace Saison.Models.Feeds.Activity;

public class Location
{
    [JsonPropertyName("brewery_city")]
    public string BreweryCity { get; set; }

    [JsonPropertyName("brewery_state")]
    public string BreweryState { get; set; }

    [JsonPropertyName("lat")]
    public double Lat { get; set; }

    [JsonPropertyName("lng")]
    public double Lng { get; set; }

    [JsonPropertyName("venue_address")]
    public string VenueAddress { get; set; }

    [JsonPropertyName("venue_city")]
    public string VenueCity { get; set; }

    [JsonPropertyName("venue_state")]
    public string VenueState { get; set; }

    [JsonPropertyName("venue_country")]
    public string VenueCountry { get; set; }
}