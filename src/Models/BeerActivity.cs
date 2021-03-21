using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Saison.Models
{
    public class User
    {
        [JsonPropertyName("uid")]
        public int Uid { get; set; }

        [JsonPropertyName("user_name")]
        public string UserName { get; set; }

        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        [JsonPropertyName("location")]
        public string Location { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("is_supporter")]
        public int IsSupporter { get; set; }

        [JsonPropertyName("bio")]
        public string Bio { get; set; }

        [JsonPropertyName("relationship")]
        public object Relationship { get; set; }

        [JsonPropertyName("user_avatar")]
        public string UserAvatar { get; set; }

        [JsonPropertyName("is_private")]
        public int IsPrivate { get; set; }

        [JsonPropertyName("account_type")]
        public string AccountType { get; set; }

        [JsonPropertyName("venue_details")]
        public List<object> VenueDetails { get; set; }

        [JsonPropertyName("brewery_details")]
        public List<object> BreweryDetails { get; set; }
    }

    public class BeerPhotoItems
    {
        [JsonPropertyName("items")]
        public List<BeerPhoto> Items { get; set; }
    }

    public class BeerPhoto
    {
        [JsonPropertyName("photo_id")]
        public int PhotoId { get; set; }
        
        [JsonPropertyName("photo")]
        public PhotoUrls PhotoUrls { get; set; }
    }

    public class Comments
    {
        [JsonPropertyName("total_count")]
        public int TotalCount { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("items")]
        public List<Comment> Items { get; set; }
    }

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
    
    public class Toasts
    {
        [JsonPropertyName("total_count")]
        public int TotalCount { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("auth_toast")]
        public bool? AuthToast { get; set; }

        [JsonPropertyName("items")]
        public List<Item> Items { get; set; }
    }

    public class PhotoUrls
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
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("items")]
        public List<BeerPhoto> Items { get; set; }
    }

    public class BadgeImage
    {
        [JsonPropertyName("sm")]
        public string Sm { get; set; }

        [JsonPropertyName("md")]
        public string Md { get; set; }

        [JsonPropertyName("lg")]
        public string Lg { get; set; }
    }

    public class Badges
    {
        [JsonPropertyName("retro_status")]
        public bool RetroStatus { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("items")]
        public List<Badge> Items { get; set; }
    }

    public class Badge
    {
        [JsonPropertyName("badge_id")]
        public int BadgeId { get; set; }

        [JsonPropertyName("user_badge_id")]
        public int UserBadgeId { get; set; }

        [JsonPropertyName("badge_name")]
        public string BadgeName { get; set; }

        [JsonPropertyName("badge_description")]
        public string BadgeDescription { get; set; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }

        [JsonPropertyName("badge_image")]
        public BadgeImage BadgeImage { get; set; }
    }

    public class BeerActivityResponse
    {
        [JsonPropertyName("pagination")]
        public Pagination Pagination { get; set; }

        [JsonPropertyName("checkins")]
        public Checkins Checkins { get; set; }
    }

    public class BeerActivityResponseContainer : UntappdBasicResponse
    {
        [JsonPropertyName("response")]
        public BeerActivityResponse Response { get; set; }
    }
}