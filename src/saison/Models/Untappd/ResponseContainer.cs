using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Saison.Models.Untappd
{
    public class ResponseContainerBase
    {
        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }

        [JsonIgnore]
        public int XRateLimit { get; set; }

        [JsonIgnore]
        public int XRateLimitRemaining { get; set; }

        [JsonIgnore]
        public DateTime? XRateLimitExpired { get; set; }
        
        [JsonIgnore]
        public string XAuthType { get; set; }
    }
    
    public class ResponseContainer : ResponseContainerBase
    {
        [JsonPropertyName("notifications")]
        public List<object> Notifications { get; set; } 
    }
    
    public class ResponseContainer<T> : ResponseContainer
        where T : new()
    {
        [JsonPropertyName("response")]
        public T Response { get; set; }
    }
    
    public class ResponseContainerNotifications : ResponseContainerBase
    {
        [JsonPropertyName("notifications")]
        public Notifications Notifications { get; set; } 
    }
    
    public class ResponseContainerNotifications<T> : ResponseContainerNotifications
        where T : new()
    {
        [JsonPropertyName("response")]
        public T Response { get; set; }
    }
}