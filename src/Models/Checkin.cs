using System;
using System.Text.Json.Serialization;

namespace Saison.Models
{
    public class Checkin
    {
        [JsonPropertyName("beer")]
        public Beer Beer { get; set; }

        [JsonPropertyName("user")]
        public User User { get; set; }

        [JsonPropertyName("checkin_id")]
        public int CheckinId { get; set; }

        [JsonPropertyName("comment_id")]
        public int CommentId { get; set; }

        [JsonPropertyName("comment_owner")]
        public bool CommentOwner { get; set; }

        [JsonPropertyName("comment_editor")]
        public bool CommentEditor { get; set; }

        [JsonPropertyName("comment")]
        public string Comment { get; set; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }

        [JsonPropertyName("comment_source")]
        public string CommentSource { get; set; }

        [JsonPropertyName("uid")]
        public int Uid { get; set; }

        [JsonPropertyName("like_id")]
        public int LikeId { get; set; }

        [JsonPropertyName("like_owner")]
        public bool LikeOwner { get; set; }

        [JsonPropertyName("badge_id")]
        public int BadgeId { get; set; }

        [JsonPropertyName("user_badge_id")]
        public int UserBadgeId { get; set; }

        [JsonPropertyName("badge_name")]
        public string BadgeName { get; set; }

        [JsonPropertyName("badge_description")]
        public string BadgeDescription { get; set; }

        [JsonPropertyName("badge_image")]
        public BadgeImage BadgeImage { get; set; }

        [JsonPropertyName("checkin_comment")]
        public string CheckinComment { get; set; }

        [JsonPropertyName("rating_score")]
        public float RatingScore { get; set; }

        [JsonPropertyName("venue")]
        public VenueFull Venue { get; set; }

        [JsonPropertyName("comments")]
        public Comments Comments { get; set; }

        [JsonPropertyName("toasts")]
        public Toasts Toasts { get; set; }

        [JsonPropertyName("media")]
        public Media Media { get; set; }

        [JsonPropertyName("source")]
        public Source Source { get; set; }

        [JsonPropertyName("badges")]
        public Badges Badges { get; set; }
    }
}