using System.Text.Json.Serialization;

namespace Saison.Models.Common.Media
{
    public class MediaCheckin<TBeer, TBrewery, TVenue> : MediaBase
    {
        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }

        [JsonPropertyName("checkin_id")]
        public int CheckinId { get; set; }
        
        [JsonPropertyName("beer")]
        public TBeer Beer { get; set; }
        
        [JsonPropertyName("brewery")]
        public TBrewery Brewery { get; set; }
        
        [JsonPropertyName("venue")]
        public TVenue Venue { get; set; }

        [JsonPropertyName("user")]
        public User User { get; set; }
    }
}