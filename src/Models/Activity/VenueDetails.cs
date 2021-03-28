using System.Text.Json.Serialization;

namespace Saison.Models.Activity
{
    public class VenueDetails
    {
        [JsonPropertyName("venue_id")]
        public int VenueId { get; set; }
    }
}