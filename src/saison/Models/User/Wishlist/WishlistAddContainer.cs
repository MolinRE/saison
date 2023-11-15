using System.Text.Json.Serialization;
using Saison.Models.Untappd;

namespace Saison.Models
{
    public class WishlistAddContainer : ResponseContainer
    {
        [JsonPropertyName("result")]
        public string Result { get; set; }
        
        [JsonPropertyName("action")]
        public string Action { get; set; }
    }
}