using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Saison.Models.Common.Media
{
    public class MediaCollection<TMedia> 
        where TMedia : MediaBase
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("items")]
        public List<TMedia> Items { get; set; }
    }
}