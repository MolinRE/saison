using System.Text.Json.Serialization;

namespace Saison.Models.User.Wishlist;

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
}