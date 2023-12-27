using System.Text.Json.Serialization;

namespace Saison.Models.Untappd;

public class Notifications
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("unread_count")]
    public UnreadCount UnreadCount { get; set; }
}