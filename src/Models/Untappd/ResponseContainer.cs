using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Saison.Models.Untappd
{
    public class ResponseContainer
    {
        [JsonPropertyName("meta")]
        public Meta Meta { get; set; } 

        [JsonPropertyName("notifications")]
        public List<object> Notifications { get; set; } 
    }
    
    public class ResponseContainer<T> : ResponseContainer
        where T : new()
    {
        public T Response { get; set; }
    }
}