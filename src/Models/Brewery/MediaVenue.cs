using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Saison.Models.Brewery
{
    public class MediaVenueCategory
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

    public class MediaVenueCategories
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("items")]
        public List<MediaVenueCategory> Items { get; set; }
    }

    public class VenueLocation
    {
        [JsonPropertyName("venue_address")]
        public string VenueAddress { get; set; }

        [JsonPropertyName("venue_city")]
        public string VenueCity { get; set; }

        [JsonPropertyName("venue_state")]
        public string VenueState { get; set; }

        [JsonPropertyName("lat")]
        public double Lat { get; set; }

        [JsonPropertyName("lng")]
        public double Lng { get; set; }
    }

    public class MediaVenueContact
    {
        [JsonPropertyName("twitter")]
        public string Twitter { get; set; }

        [JsonPropertyName("venue_url")]
        public string VenueUrl { get; set; }
    }

    public class MediaVenueFoursquare
    {
        [JsonPropertyName("foursquare_id")]
        public string FoursquareId { get; set; }

        [JsonPropertyName("foursquare_url")]
        public string FoursquareUrl { get; set; }
    }

    public class MediaVenueIcon
    {
        [JsonPropertyName("sm")]
        public string Sm { get; set; }

        [JsonPropertyName("md")]
        public string Md { get; set; }

        [JsonPropertyName("lg")]
        public string Lg { get; set; }
    }

    public class MediaVenue
    {
        [JsonPropertyName("venue_id")]
        public int VenueId { get; set; }

        [JsonPropertyName("venue_name")]
        public string VenueName { get; set; }

        [JsonPropertyName("venue_slug")]
        public string VenueSlug { get; set; }

        [JsonPropertyName("primary_category")]
        public string PrimaryCategory { get; set; }

        [JsonPropertyName("parent_category_id")]
        public string ParentCategoryId { get; set; }

        [JsonPropertyName("categories")]
        public MediaVenueCategories Categories { get; set; }

        [JsonPropertyName("location")]
        public VenueLocation Location { get; set; }

        [JsonPropertyName("contact")]
        public MediaVenueContact Contact { get; set; }

        [JsonPropertyName("foursquare")]
        public MediaVenueFoursquare Foursquare { get; set; }

        [JsonPropertyName("venue_icon")]
        public MediaVenueIcon VenueIcon { get; set; }

        [JsonPropertyName("is_verified")]
        public int IsVerified { get; set; }
    }
}