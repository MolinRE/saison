using System.Text.Json.Serialization;

namespace Saison.Models.Untappd;

public class UnreadCount
{
    [JsonPropertyName("comments")]
    public int Comments { get; set; }

    [JsonPropertyName("toasts")]
    public int Toasts { get; set; }

    [JsonPropertyName("friends")]
    public int Friends { get; set; }

    [JsonPropertyName("messages")]
    public int Messages { get; set; }

    [JsonPropertyName("venues")]
    public int Venues { get; set; }

    [JsonPropertyName("veunes")]
    public int Veunes { get; set; }

    [JsonPropertyName("others")]
    public int Others { get; set; }

    [JsonPropertyName("news")]
    public int News { get; set; }
}