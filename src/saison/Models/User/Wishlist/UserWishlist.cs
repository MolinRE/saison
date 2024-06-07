using Saison.Models.Beer;
using System.Text.Json.Serialization;

namespace Saison.Models.User.Wishlist;

public class UserWishlist
{
    [JsonPropertyName("total_count")]
    public int TotalCount { get; set; }

    [JsonPropertyName("is_search")]
    public bool IsSearch { get; set; }

    /// <summary>
    /// Can be string or boolean depening on <see cref="WishlistSorting"/>
    /// </summary>
    [JsonPropertyName("sort")]
    public object Sort { get; set; }

    [JsonPropertyName("type_id")]
    public bool TypeId { get; set; }

    [JsonPropertyName("is_multi_type")]
    public bool IsMultiType { get; set; }

    [JsonPropertyName("country_id")]
    public bool CountryId { get; set; }

    [JsonPropertyName("brewery_id")]
    public bool BreweryId { get; set; }

    [JsonPropertyName("beers")]
    public Beers Beers { get; set; }

    [JsonPropertyName("updated_at")]
    public string UpdatedAt { get; set; }

    [JsonPropertyName("created_at")]
    public string CreatedAt { get; set; }

    [JsonPropertyName("sort_english")]
    public string SortEnglish { get; set; }

    [JsonPropertyName("sort_name")]
    public string SortName { get; set; }

    [JsonPropertyName("sort_key")]
    public string SortKey { get; set; }
}

