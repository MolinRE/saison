using System.Text.Json.Serialization;

namespace Saison.Models.Beer
{
    public class SearchItem
    {
        [JsonPropertyName("checkin_count")]
        public int CheckinCount { get; set; } 

        [JsonPropertyName("have_had")]
        public bool HaveHad { get; set; } 

        [JsonPropertyName("your_count")]
        public int YourCount { get; set; } 

        [JsonPropertyName("beer")]
        public Beer Beer { get; set; } 

        [JsonPropertyName("brewery")]
        public Brewery Brewery { get; set; } 
    }
}