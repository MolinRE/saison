using System.Text.Json.Serialization;

namespace Saison.Models.Venue
{
    public class Stats
    {
        [JsonPropertyName("total_count")]
        public int TotalCount { get; set; }

        [JsonPropertyName("user_count")]
        public int UserCount { get; set; }

        [JsonPropertyName("total_user_count")]
        public int TotalUserCount { get; set; }

        [JsonPropertyName("monthly_count")]
        public int MonthlyCount { get; set; }

        [JsonPropertyName("weekly_count")]
        public int WeeklyCount { get; set; }
    }
}