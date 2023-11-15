using System.Text.Json.Serialization;

namespace Saison.Models.Activity
{
    public class VenueCategory
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