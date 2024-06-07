using System.Text.Json.Serialization;
using Saison.Models.Activity;

namespace Saison.Models;

public class ThePub
{
    [JsonPropertyName("limit")]
    public int Limit { get; set; }

    [JsonPropertyName("offset")]
    public int Offset { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("pagination")]
    public Pagination Pagination { get; set; }

    [JsonPropertyName("radius")]
    public int Radius { get; set; }

    [JsonPropertyName("dist_pref")]
    public string DistPref { get; set; }

    [JsonPropertyName("checkins")]
    public Checkins Checkins { get; set; }
}