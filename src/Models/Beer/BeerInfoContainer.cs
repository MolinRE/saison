using System.Text.Json.Serialization;

namespace Saison.Models.Beer
{
    public class BeerInfoContainer
    {
        [JsonPropertyName("beer")]
        public BeerInfo Beer { get; set; }
    }
}