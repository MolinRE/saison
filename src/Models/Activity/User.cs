using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Saison.Models.Activity
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

        [JsonPropertyName("user_link")]
        public string UserLink { get; set; }
    }
}