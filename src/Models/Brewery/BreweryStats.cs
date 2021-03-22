using System.Text.Json.Serialization;

namespace Saison.Models.Brewery
{
    public class Stats
    {
        [JsonPropertyName("total_count")]
        public int TotalCount { get; set; }

        [JsonPropertyName("unique_count")]
        public int UniqueCount { get; set; }

        [JsonPropertyName("monthly_count")]
        public int MonthlyCount { get; set; }

        [JsonPropertyName("weekly_count")]
        public int WeeklyCount { get; set; }

        [JsonPropertyName("user_count")]
        public int UserCount { get; set; }

        [JsonPropertyName("age_on_service")]
        public double AgeOnService { get; set; }
    }
}