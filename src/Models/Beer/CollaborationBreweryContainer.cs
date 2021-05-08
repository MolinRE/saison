using System.Text.Json.Serialization;

namespace Saison.Models.Beer
{
    public class CollaborationBreweryContainer
    {
        [JsonPropertyName("brewery")]
        public CollaborationBrewery Brewery { get; set; }
    }
}