using System.Text.Json.Serialization;
using Saison.Models.Untappd;

namespace Saison.Models.Beer
{
    public class BeerInfoContainer
    {
        [JsonPropertyName("beer")]
        public BeerInfo Beer { get; set; }
    }
}