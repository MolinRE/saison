using System.Text.Json.Serialization;

namespace Saison.Models.Brewery
{
    public class SearchItem
    {
        [JsonPropertyName("brewery")]
        public SearchMatch Item { get; set; }
    }
}