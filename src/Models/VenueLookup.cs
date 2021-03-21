using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Saison.Models
{
    public class Venue
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

    public class VenueLookup
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("items")]
        public List<Venue> Items { get; set; }
    }

    public class FoursquareLookupResponse
    {
        [JsonPropertyName("venue")]
        public VenueLookup Venue { get; set; }
    }

    public class FoursquareLookupResponseContainer : UntappdBasicResponse
    {
        [JsonPropertyName("response")]
        public FoursquareLookupResponse Response { get; set; }
    }
}