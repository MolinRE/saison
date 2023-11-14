using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Saison.Models.Beer
{
    public class MediaVenueCategories
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("items")]
        public List<MediaVenueCategory> Items { get; set; }
    }
}