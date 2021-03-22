using System.Text.Json.Serialization;

namespace Saison.Models.Beer
{
    public class MediaUser
    {
        [JsonPropertyName("uid")]
        public int Uid { get; set; }

        [JsonPropertyName("user_name")]
        public string UserName { get; set; }

        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        [JsonPropertyName("user_avatar")]
        public string UserAvatar { get; set; }

        [JsonPropertyName("is_private")]
        public int IsPrivate { get; set; }
    }
}