using Saison.Models.Untappd;
using System.Text.Json.Serialization;

namespace Saison.Models.User.Wishlist;

public class WishlistAction : ResponseContainer
{
    /// <summary>
    /// Action result
    /// </summary>
    [JsonPropertyName("result")]
    public string Result { get; set; }

    /// <summary>
    /// Action name
    /// </summary>
    [JsonPropertyName("action")]
    public string Action { get; set; }
}