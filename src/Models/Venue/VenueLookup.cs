using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Saison.Models.Venue
{
    public class VenueLookup
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("items")]
        public List<VenueLookupItem> Items { get; set; }
    }
}