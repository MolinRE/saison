using System.Text.Json.Serialization;

namespace Saison.Models.Feeds.Activity;

public class BadgeImage
{
    [JsonPropertyName("sm")]
    public string Small { get; set; }

    [JsonPropertyName("md")]
    public string Medium { get; set; }

    [JsonPropertyName("lg")]
    public string Large { get; set; }
}