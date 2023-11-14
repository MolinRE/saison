using System.Text.Json.Serialization;

namespace Saison.Models.Beer
{
    public class MediaVenueCategory
    {
        [JsonPropertyName("category_key")]
        public string CategoryKey { get; set; }

        [JsonPropertyName("category_name")]
        public string CategoryName { get; set; }

        [JsonPropertyName("category_id")]
        public string CategoryId { get; set; }

        [JsonPropertyName("is_primary")]
        public bool IsPrimary { get; set; }
    }
}