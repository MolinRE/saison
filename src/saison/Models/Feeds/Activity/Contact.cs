using System.Text.Json.Serialization;

namespace Saison.Models.Feeds.Activity;

public class Contact
{
    [JsonPropertyName("twitter")]
    public string Twitter { get; set; }

    [JsonPropertyName("facebook")]
    public string Facebook { get; set; }

    [JsonPropertyName("instagram")]
    public string Instagram { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }

    [JsonPropertyName("venue_url")]
    public string VenueUrl { get; set; }
}