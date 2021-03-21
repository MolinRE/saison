using System.Text.Json.Serialization;

namespace Saison.Models
{
    public class BrewerySearchItem
    {
        [JsonPropertyName("brewery")]
        public BrewerySearchMatch Item { get; set; }
    }
}