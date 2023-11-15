using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Saison.Models.Beer
{
    public class Homebrew
    {
        [JsonPropertyName("count")]
        public int Count { get; set; } 

        [JsonPropertyName("items")]
        public List<object> Items { get; set; } 
    }
}