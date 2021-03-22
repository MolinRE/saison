using System.Text.Json.Serialization;

namespace Saison.Models.Brewery
{
    public class ClaimedStatus
    {
        [JsonPropertyName("is_claimed")]
        public bool IsClaimed { get; set; }

        [JsonPropertyName("claimed_slug")]
        public string ClaimedSlug { get; set; }

        [JsonPropertyName("follow_status")]
        public bool FollowStatus { get; set; }

        [JsonPropertyName("follower_count")]
        public int FollowerCount { get; set; }

        [JsonPropertyName("uid")]
        public int Uid { get; set; }

        [JsonPropertyName("mute_status")]
        public string MuteStatus { get; set; }
    }
}