using System.Collections.Generic;
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

    public class MediaCheckin<TBeer, TBrewery, TVenue> : MediaBase
    {
        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }

        [JsonPropertyName("checkin_id")]
        public int CheckinId { get; set; }
        
        [JsonPropertyName("beer")]
        public TBeer Beer { get; set; }
        
        [JsonPropertyName("brewery")]
        public TBrewery Brewery { get; set; }
        
        [JsonPropertyName("venue")]
        public TVenue Venue { get; set; }

        [JsonPropertyName("user")]
        public User User { get; set; }
    }
    
    public class MediaCollection<TMedia> 
        where TMedia : MediaBase
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("items")]
        public List<TMedia> Items { get; set; }
    }

    public class User
    {
        
    }

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