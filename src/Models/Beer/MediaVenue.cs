using System.Text.Json.Serialization;

namespace Saison.Models.Beer
{
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
        public MediaVenueLocation Location { get; set; }

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