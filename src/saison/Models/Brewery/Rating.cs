using System.Text.Json.Serialization;

namespace Saison.Models.Brewery
{
    public class Rating
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("rating_score")]
        public float RatingScore { get; set; }
    }
}