using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Saison.Models
{
    public class VenueCategory
    {
        [JsonPropertyName("category_key")]
        public string CategoryKey { get; set; }

        [JsonPropertyName("category_name")]
        public string CategoryName { get; set; }

        [JsonPropertyName("category_id")]
        public string CategoryId { get; set; }

        [JsonPropertyName("is_primary")]
        public bool IsPrimary { get; set; }
    }

    public class VenueCategories
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("items")]
        public List<VenueCategory> Items { get; set; }
    }

    public class VenueStats
    {
        [JsonPropertyName("total_count")]
        public int TotalCount { get; set; }

        [JsonPropertyName("user_count")]
        public int UserCount { get; set; }

        [JsonPropertyName("total_user_count")]
        public int TotalUserCount { get; set; }

        [JsonPropertyName("monthly_count")]
        public int MonthlyCount { get; set; }

        [JsonPropertyName("weekly_count")]
        public int WeeklyCount { get; set; }
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

    public class VenueLocation
    {
        [JsonPropertyName("venue_address")]
        public string VenueAddress { get; set; }

        [JsonPropertyName("venue_city")]
        public string VenueCity { get; set; }

        [JsonPropertyName("venue_state")]
        public string VenueState { get; set; }

        [JsonPropertyName("venue_country")]
        public string VenueCountry { get; set; }

        [JsonPropertyName("lat")]
        public double Lat { get; set; }

        [JsonPropertyName("lng")]
        public double Lng { get; set; }

        [JsonPropertyName("brewery_city")]
        public string BreweryCity { get; set; }

        [JsonPropertyName("brewery_state")]
        public string BreweryState { get; set; }
    }

    public class VenueContact
    {
        [JsonPropertyName("twitter")]
        public string Twitter { get; set; }

        [JsonPropertyName("venue_url")]
        public string VenueUrl { get; set; }

        [JsonPropertyName("facebook")]
        public string Facebook { get; set; }

        [JsonPropertyName("yelp")]
        public string Yelp { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("instagram")]
        public string Instagram { get; set; }
    }

    public class Foursquare
    {
        [JsonPropertyName("foursquare_id")]
        public string FoursquareId { get; set; }

        [JsonPropertyName("foursquare_url")]
        public string FoursquareUrl { get; set; }
    }

    public class VenueFull
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
        public VenueCategories Categories { get; set; }

        [JsonPropertyName("location")]
        public VenueLocation Location { get; set; }

        [JsonPropertyName("contact")]
        public VenueContact Contact { get; set; }

        [JsonPropertyName("foursquare")]
        public Foursquare Foursquare { get; set; }

        [JsonPropertyName("venue_icon")]
        public VenueIcon VenueIcon { get; set; }

        [JsonPropertyName("is_verified")]
        public bool IsVerified { get; set; }

        [JsonPropertyName("last_updated")]
        public string LastUpdated { get; set; }

        [JsonPropertyName("stats")]
        public VenueStats Stats { get; set; }

        [JsonPropertyName("public_venue")]
        public bool PublicVenue { get; set; }

        [JsonPropertyName("is_closed")]
        public bool IsClosed { get; set; }
    }
    
    public class VenueInfoResponse
    {
        [JsonPropertyName("venue")]
        public VenueFull Venue { get; set; }
    }

    public class VenueInfoResponseContainer : UntappdBasicResponse
    {
        [JsonPropertyName("response")]
        public VenueInfoResponse Response { get; set; }
    }
}