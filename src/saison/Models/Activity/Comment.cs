using System.Text.Json.Serialization;

namespace Saison.Models.Activity
{
    public class Comment
    {
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
        public string Text { get; set; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }

        [JsonPropertyName("comment_source")]
        public string CommentSource { get; set; }
    }
}