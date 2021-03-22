using System.Text.Json.Serialization;

namespace Saison.Models.Activity
{
    public class MediaItem
    {
        [JsonPropertyName("photo_id")]
        public int PhotoId { get; set; }

        [JsonPropertyName("photo")]
        public Photo Photo { get; set; }
    }
}