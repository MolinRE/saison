using System.Text.Json.Serialization;

namespace Saison.Models.Common.Media
{
    public class Photo
    {
        [JsonPropertyName("photo_img_sm")]
        public string PhotoImgSm { get; set; }

        [JsonPropertyName("photo_img_md")]
        public string PhotoImgMd { get; set; }

        [JsonPropertyName("photo_img_lg")]
        public string PhotoImgLg { get; set; }

        [JsonPropertyName("photo_img_og")]
        public string PhotoImgOg { get; set; }
    }
}