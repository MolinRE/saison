using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Saison.Models.Beer
{
    public class Friends
    {
        [JsonPropertyName("items")]
        public List<object> Items { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }
    }
}