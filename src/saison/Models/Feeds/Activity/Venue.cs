using System.Text.Json.Serialization;

namespace Saison.Models.Feeds.Activity;

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