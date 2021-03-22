using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Saison.Models.Brewery
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

    public class Media
    {
        [JsonPropertyName("photo_id")]
        public int PhotoId { get; set; }

        [JsonPropertyName("photo")]
        public Photo Photo { get; set; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }

        [JsonPropertyName("checkin_id")]
        public int CheckinId { get; set; }

        [JsonPropertyName("beer")]
        public MediaBeer Beer { get; set; }

        [JsonPropertyName("brewery")]
        public MediaBrewery Brewery { get; set; }

        [JsonPropertyName("user")]
        public MediaUser User { get; set; }

        [JsonPropertyName("venue")]
        public MediaVenue Venue { get; set; }
    }

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

    public class MediaCollection
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("items")]
        public List<Media> Items { get; set; }
    }
}