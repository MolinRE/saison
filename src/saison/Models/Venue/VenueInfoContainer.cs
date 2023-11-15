using System.Text.Json.Serialization;

namespace Saison.Models.Venue
{
    public class VenueInfoContainer
    {
        [JsonPropertyName("venue")]
        public VenueInfo Venue { get; set; }
    }
}