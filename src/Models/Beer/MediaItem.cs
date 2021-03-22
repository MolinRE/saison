using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Saison.Models.Beer
{
    public class Media
    {
        [JsonPropertyName("photo_id")]
        public int PhotoId { get; set; }

        [JsonPropertyName("photo")]
        public Photo Photo { get; set; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }

        [JsonPropertyName("checkin_id")]
        public int CheckinId { get; set; }

        [JsonPropertyName("beer")]
        public MediaBeer Beer { get; set; }

        [JsonPropertyName("brewery")]
        public MediaBrewery Brewery { get; set; }

        [JsonPropertyName("user")]
        public MediaUser User { get; set; }

        [JsonPropertyName("venue")]
        public List<MediaVenue> Venue { get; set; }
    }
}