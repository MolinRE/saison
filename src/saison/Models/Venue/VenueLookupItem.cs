using System.Text.Json.Serialization;

namespace Saison.Models.Venue
{
    public class VenueLookupItem
    {
        [JsonPropertyName("venue_name")]
        public string VenueName { get; set; }

        [JsonPropertyName("venue_id")]
        public int VenueId { get; set; }

        [JsonPropertyName("foursquare_id")]
        public string FoursquareId { get; set; }

        [JsonPropertyName("last_updated")]
        public string LastUpdated { get; set; }
    }
}