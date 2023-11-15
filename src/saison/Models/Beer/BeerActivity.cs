using System.Text.Json.Serialization;

namespace Saison.Models.Beer
{
    public class BeerActivity
    {
        [JsonPropertyName("pagination")]
        public Pagination Pagination { get; set; }

        [JsonPropertyName("checkins")]
        public Models.Activity.Checkins Checkins { get; set; }
    }
}