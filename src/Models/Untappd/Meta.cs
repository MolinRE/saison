using System.Text.Json.Serialization;

namespace Saison.Models.Untappd
{
    public class Meta
    {
        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("error_detail")]
        public string ErrorDetail { get; set; }

        [JsonPropertyName("error_type")]
        public string ErrorType { get; set; }
        
        [JsonPropertyName("developer_friendly")]
        public string DeveloperFriendly { get; set; }

        [JsonPropertyName("response_time")]
        public ResponseTime ResponseTime { get; set; } 

        [JsonPropertyName("init_time")]
        public InitTime InitTime { get; set; } 
    }
}