using System.Text.Json.Serialization;

namespace Saison.Models.Venue
{
    public class FoursquareLookupResponse
    {
        [JsonPropertyName("venue")]
        public VenueLookup Venue { get; set; }
    }
}