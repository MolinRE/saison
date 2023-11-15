using System.Text.Json.Serialization;

namespace Saison.Models.Untappd
{
    public class Meta
    {
        /// <summary>
        /// Possible values:
        /// <para>
        /// <c>400</c>
        /// </para>
        /// </summary>
        [JsonPropertyName("code")]
        public int Code { get; set; }

        /// <summary>
        /// Possible values:
        /// <para>
        /// Your 'max_id' is too low, please use a valid that is closer to the most recent ID.
        /// We only allow scanning back to a max of 300 checkins.
        /// </para>
        /// </summary>
        [JsonPropertyName("error_detail")]
        public string ErrorDetail { get; set; }

        /// <summary>
        /// Possible values:
        /// <para>
        /// <c>invalid_param</c>
        /// </para>
        /// </summary>
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