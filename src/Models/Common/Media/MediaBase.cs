using System.Text.Json.Serialization;

namespace Saison.Models.Common.Media
{
    public class MediaBase
    {
        [JsonPropertyName("photo_id")]
        public int PhotoId { get; set; }

        [JsonPropertyName("photo")]
        public Photo Photo { get; set; }
    }
}