using System.Text.Json.Serialization;

namespace Saison.Models.Brewery
{
    public class BreweryInfoContainer
    {
        [JsonPropertyName("brewery")]
        public BreweryInfo Brewery { get; set; }
    }
}