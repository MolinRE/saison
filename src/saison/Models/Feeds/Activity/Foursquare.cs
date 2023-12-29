using System.Text.Json.Serialization;

namespace Saison.Models.Feeds.Activity;

public class Foursquare
{
    [JsonPropertyName("foursquare_id")]
    public string FoursquareId { get; set; }

    [JsonPropertyName("foursquare_url")]
    public string FoursquareUrl { get; set; }
}