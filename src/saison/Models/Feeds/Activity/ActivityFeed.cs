using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Saison.Models.Feeds.Activity;

// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
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
    public List<Item> Items { get; set; }
}

public class Beer
{
    [JsonPropertyName("bid")]
    public int Bid { get; set; }

    [JsonPropertyName("beer_name")]
    public string BeerName { get; set; }

    [JsonPropertyName("beer_label")]
    public string BeerLabel { get; set; }

    [JsonPropertyName("beer_label_hd")]
    public string BeerLabelHd { get; set; }

    [JsonPropertyName("beer_style")]
    public string BeerStyle { get; set; }

    [JsonPropertyName("beer_abv")]
    public double BeerAbv { get; set; }

    [JsonPropertyName("has_had")]
    public bool HasHad { get; set; }

    [JsonPropertyName("beer_active")]
    public int BeerActive { get; set; }
}

public class Brewery
{
    [JsonPropertyName("brewery_id")]
    public int BreweryId { get; set; }

    [JsonPropertyName("brewery_name")]
    public string BreweryName { get; set; }

    [JsonPropertyName("brewery_slug")]
    public string BrewerySlug { get; set; }

    [JsonPropertyName("brewery_page_url")]
    public string BreweryPageUrl { get; set; }

    [JsonPropertyName("brewery_type")]
    public string BreweryType { get; set; }

    [JsonPropertyName("brewery_label")]
    public string BreweryLabel { get; set; }

    [JsonPropertyName("country_name")]
    public string CountryName { get; set; }

    [JsonPropertyName("contact")]
    public Contact Contact { get; set; }

    [JsonPropertyName("location")]
    public Location Location { get; set; }

    [JsonPropertyName("brewery_active")]
    public int BreweryActive { get; set; }
}

public class Categories
{
    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("items")]
    public List<Item> Items { get; set; }
}

public class Checkins
{
    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("items")]
    public List<Item> Items { get; set; }
}

public class Comments
{
    [JsonPropertyName("total_count")]
    public int TotalCount { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("items")]
    public List<Item> Items { get; set; }
}

public class Contact
{
    [JsonPropertyName("twitter")]
    public string Twitter { get; set; }

    [JsonPropertyName("facebook")]
    public string Facebook { get; set; }

    [JsonPropertyName("instagram")]
    public string Instagram { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }

    [JsonPropertyName("venue_url")]
    public string VenueUrl { get; set; }
}

public class Foursquare
{
    [JsonPropertyName("foursquare_id")]
    public string FoursquareId { get; set; }

    [JsonPropertyName("foursquare_url")]
    public string FoursquareUrl { get; set; }
}

public class InitTime
{
    [JsonPropertyName("time")]
    public int Time { get; set; }

    [JsonPropertyName("measure")]
    public string Measure { get; set; }
}

public class Item
{
    [JsonPropertyName("checkin_id")]
    public int CheckinId { get; set; }

    [JsonPropertyName("created_at")]
    public string CreatedAt { get; set; }

    [JsonPropertyName("rating_score")]
    public double RatingScore { get; set; }

    [JsonPropertyName("checkin_comment")]
    public string CheckinComment { get; set; }

    [JsonPropertyName("user")]
    public User User { get; set; }

    [JsonPropertyName("beer")]
    public Beer Beer { get; set; }

    [JsonPropertyName("brewery")]
    public Brewery Brewery { get; set; }

    [JsonPropertyName("venue")]
    public Venue Venue { get; set; }

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

    [JsonPropertyName("category_key")]
    public string CategoryKey { get; set; }

    [JsonPropertyName("category_name")]
    public string CategoryName { get; set; }

    [JsonPropertyName("category_id")]
    public string CategoryId { get; set; }

    [JsonPropertyName("is_primary")]
    public bool IsPrimary { get; set; }

    [JsonPropertyName("comment_id")]
    public int CommentId { get; set; }

    [JsonPropertyName("comment_owner")]
    public bool CommentOwner { get; set; }

    [JsonPropertyName("comment_editor")]
    public bool CommentEditor { get; set; }

    [JsonPropertyName("comment")]
    public string Comment { get; set; }

    [JsonPropertyName("comment_source")]
    public string CommentSource { get; set; }

    [JsonPropertyName("uid")]
    public int Uid { get; set; }

    [JsonPropertyName("like_id")]
    public int LikeId { get; set; }

    [JsonPropertyName("like_owner")]
    public bool LikeOwner { get; set; }

    [JsonPropertyName("photo_id")]
    public int PhotoId { get; set; }

    [JsonPropertyName("photo")]
    public Photo Photo { get; set; }

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
}

public class Location
{
    [JsonPropertyName("brewery_city")]
    public string BreweryCity { get; set; }

    [JsonPropertyName("brewery_state")]
    public string BreweryState { get; set; }

    [JsonPropertyName("lat")]
    public double Lat { get; set; }

    [JsonPropertyName("lng")]
    public double Lng { get; set; }

    [JsonPropertyName("venue_address")]
    public string VenueAddress { get; set; }

    [JsonPropertyName("venue_city")]
    public string VenueCity { get; set; }

    [JsonPropertyName("venue_state")]
    public string VenueState { get; set; }

    [JsonPropertyName("venue_country")]
    public string VenueCountry { get; set; }
}

public class Media
{
    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("items")]
    public List<Item> Items { get; set; }
}

public class Pagination
{
    [JsonPropertyName("since_url")]
    public string SinceUrl { get; set; }

    [JsonPropertyName("next_url")]
    public string NextUrl { get; set; }

    [JsonPropertyName("max_id")]
    public int MaxId { get; set; }
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

public class ActivityFeed
{
    [JsonPropertyName("is_offset_checkin_id")]
    public bool IsOffsetCheckinId { get; set; }

    [JsonPropertyName("offset")]
    public int Offset { get; set; }

    [JsonPropertyName("limit")]
    public int Limit { get; set; }

    [JsonPropertyName("index")]
    public string Index { get; set; }

    [JsonPropertyName("time")]
    public double Time { get; set; }

    [JsonPropertyName("checkins")]
    public Checkins Checkins { get; set; }

    [JsonPropertyName("pagination")]
    public Pagination Pagination { get; set; }
}

public class ResponseTime
{
    [JsonPropertyName("time")]
    public double Time { get; set; }

    [JsonPropertyName("measure")]
    public string Measure { get; set; }
}



public class Source
{
    [JsonPropertyName("app_name")]
    public string AppName { get; set; }

    [JsonPropertyName("app_website")]
    public string AppWebsite { get; set; }
}

public class Toasts
{
    [JsonPropertyName("total_count")]
    public int TotalCount { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("auth_toast")]
    public bool AuthToast { get; set; }

    [JsonPropertyName("items")]
    public List<Item> Items { get; set; }
}

public class UnreadCount
{
    [JsonPropertyName("comments")]
    public int Comments { get; set; }

    [JsonPropertyName("toasts")]
    public int Toasts { get; set; }

    [JsonPropertyName("friends")]
    public int Friends { get; set; }

    [JsonPropertyName("messages")]
    public int Messages { get; set; }

    [JsonPropertyName("venues")]
    public int Venues { get; set; }

    [JsonPropertyName("veunes")]
    public int Veunes { get; set; }

    [JsonPropertyName("others")]
    public int Others { get; set; }

    [JsonPropertyName("news")]
    public int News { get; set; }
}

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

    [JsonPropertyName("relationship")]
    public string Relationship { get; set; }

    [JsonPropertyName("location")]
    public string Location { get; set; }

    [JsonPropertyName("is_supporter")]
    public int IsSupporter { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }

    [JsonPropertyName("bio")]
    public string Bio { get; set; }

    [JsonPropertyName("user_avatar")]
    public string UserAvatar { get; set; }

    [JsonPropertyName("is_private")]
    public int IsPrivate { get; set; }

    [JsonPropertyName("public_toasts")]
    public int PublicToasts { get; set; }

    [JsonPropertyName("account_type")]
    public string AccountType { get; set; }

    [JsonPropertyName("user_link")]
    public string UserLink { get; set; }
}

public class Venue
{
    [JsonPropertyName("venue_id")]
    public int VenueId { get; set; }

    [JsonPropertyName("venue_name")]
    public string VenueName { get; set; }

    [JsonPropertyName("venue_slug")]
    public string VenueSlug { get; set; }

    [JsonPropertyName("primary_category_key")]
    public string PrimaryCategoryKey { get; set; }

    [JsonPropertyName("primary_category")]
    public string PrimaryCategory { get; set; }

    [JsonPropertyName("parent_category_id")]
    public string ParentCategoryId { get; set; }

    [JsonPropertyName("categories")]
    public Categories Categories { get; set; }

    [JsonPropertyName("location")]
    public Location Location { get; set; }

    [JsonPropertyName("contact")]
    public Contact Contact { get; set; }

    [JsonPropertyName("foursquare")]
    public Foursquare Foursquare { get; set; }

    [JsonPropertyName("venue_icon")]
    public VenueIcon VenueIcon { get; set; }

    [JsonPropertyName("is_verified")]
    public bool IsVerified { get; set; }
}

public class VenueIcon
{
    [JsonPropertyName("sm")]
    public string Sm { get; set; }

    [JsonPropertyName("md")]
    public string Md { get; set; }

    [JsonPropertyName("lg")]
    public string Lg { get; set; }
}