using System.Text.Json.Serialization;

namespace Saison.Models.Feeds.Activity;

public class ActivityFeed
{
    [JsonPropertyName("is_offset_checkin_id")]
    public bool IsOffsetCheckinId { get; set; }

    [JsonPropertyName("offset")]
    public int Offset { get; set; }

    [JsonPropertyName("limit")]
    public int Limit { get; set; }

    [JsonPropertyName("index")]
    public string Index { get; set; }

    [JsonPropertyName("time")]
    public double Time { get; set; }

    [JsonPropertyName("checkins")]
    public Checkins Checkins { get; set; }

    [JsonPropertyName("pagination")]
    public Pagination Pagination { get; set; }
}