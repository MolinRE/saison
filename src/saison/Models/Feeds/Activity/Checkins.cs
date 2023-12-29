﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Saison.Models.Feeds.Activity;

public class Checkins
{
    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("items")]
    public List<Item> Items { get; set; }
}