using System.Text.Json.Serialization;

namespace Saison.Models.Feeds.Activity;

public class Pagination
{
    [JsonPropertyName("since_url")]
    public string SinceUrl { get; set; }

    [JsonPropertyName("next_url")]
    public string NextUrl { get; set; }

    [JsonPropertyName("max_id")]
    public int MaxId { get; set; }
}