using System.Text.Json.Serialization;

namespace Saison.Models.Activity
{
    public class Badge
    {
        [JsonPropertyName("badge_id")]
        public int BadgeId { get; set; }

        [JsonPropertyName("user_badge_id")]
        public int UserBadgeId { get; set; }

        [JsonPropertyName("badge_name")]
        public string BadgeName { get; set; }

        [JsonPropertyName("badge_description")]
        public string BadgeDescription { get; set; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }

        [JsonPropertyName("badge_image")]
        public BadgeImage BadgeImage { get; set; }
    }
}