﻿using System.Text.Json.Serialization;

namespace Saison.Models.Feeds.Activity;

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