using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Saison.Models.Brewery
{
    public class Collaborations
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("items")]
        public List<object> Items { get; set; }
    }
}