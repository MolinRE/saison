using System.Text.Json.Serialization;

namespace Saison.Models.Activity
{
    public class Toast
    {
        [JsonPropertyName("uid")]
        public int Uid { get; set; }

        [JsonPropertyName("user")]
        public User User { get; set; }

        [JsonPropertyName("like_id")]
        public int LikeId { get; set; }

        [JsonPropertyName("like_owner")]
        public bool LikeOwner { get; set; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }
    }
}