using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Saison.Models.User.Wishlist;

public class Beers
{
    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("items")]
    public List<Item> Items { get; set; }
}