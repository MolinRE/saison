using System.Text.Json.Serialization;

namespace Saison.Models.Venue
{
    public class FoursquareLookup
    {
        [JsonPropertyName("venue")]
        public VenueLookup Venue { get; set; }
    }
}