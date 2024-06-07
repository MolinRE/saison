using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Saison.Models.User.Wishlist;

public class Item
{
    [JsonPropertyName("created_at")]
    public string CreatedAt { get; set; }

    [JsonPropertyName("beer")]
    public Beer Beer { get; set; }

    [JsonPropertyName("brewery")]
    public Brewery Brewery { get; set; }

    [JsonPropertyName("friends")]
    public List<object> Friends { get; set; }
}