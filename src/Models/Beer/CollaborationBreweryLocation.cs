using System.Text.Json.Serialization;

namespace Saison.Models.Beer
{
    public class CollaborationBreweryLocation
    {
        [JsonPropertyName("brewery_city")]
        public string City { get; set; }
        [JsonPropertyName("brewery_state")]
        public string State { get; set; }
    }
}