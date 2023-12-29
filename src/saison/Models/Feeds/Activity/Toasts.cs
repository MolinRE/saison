using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Saison.Models.Feeds.Activity;

public class Toasts
{
    [JsonPropertyName("total_count")]
    public int TotalCount { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("auth_toast")]
    public bool AuthToast { get; set; }

    [JsonPropertyName("items")]
    public List<Item> Items { get; set; }
}