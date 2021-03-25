﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Saison.Models.Brewery
{
    public class Checkins
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("items")]
        public List<Activity.Checkin> Items { get; set; }

        [JsonPropertyName("pagination")]
        public Pagination Pagination { get; set; }
        
        [JsonPropertyName("mem")]
        public bool Mem { get; set; }
        
        [JsonPropertyName("time")]
        public float Time { get; set; }
        
        [JsonPropertyName("table")]
        public bool Table { get; set; }
    }
}