using System.Text.Json.Serialization;

namespace Saison.Models.Activity
{
    public class BreweryDetails
    {
        [JsonPropertyName("brewery_id")]
        public int BreweryId { get; set; }
    }
}