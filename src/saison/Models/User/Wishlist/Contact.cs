using System.Text.Json.Serialization;

namespace Saison.Models.User.Wishlist;

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
}