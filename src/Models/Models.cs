using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Saison.Models
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class ResponseTime    {
        [JsonPropertyName("time")]
        public double Time { get; set; } 

        [JsonPropertyName("measure")]
        public string Measure { get; set; } 
    }

    public class InitTime    {
        [JsonPropertyName("time")]
        public int Time { get; set; } 

        [JsonPropertyName("measure")]
        public string Measure { get; set; } 
    }

    public class Contact    {
        [JsonPropertyName("twitter")]
        public string Twitter { get; set; } 

        [JsonPropertyName("facebook")]
        public string Facebook { get; set; } 

        [JsonPropertyName("instagram")]
        public string Instagram { get; set; } 

        [JsonPropertyName("url")]
        public string Url { get; set; } 
    }

    public class Location    {
        [JsonPropertyName("brewery_city")]
        public string BreweryCity { get; set; } 

        [JsonPropertyName("brewery_state")]
        public string BreweryState { get; set; } 

        [JsonPropertyName("lat")]
        public double Lat { get; set; } 

        [JsonPropertyName("lng")]
        public double Lng { get; set; } 
    }

    public class Item    {
        [JsonPropertyName("checkin_count")]
        public int CheckinCount { get; set; } 

        [JsonPropertyName("have_had")]
        public bool HaveHad { get; set; } 

        [JsonPropertyName("your_count")]
        public int YourCount { get; set; } 

        [JsonPropertyName("beer")]
        public Beer Beer { get; set; } 

        [JsonPropertyName("brewery")]
        public Brewery Brewery { get; set; } 
    }

    public class Beers    {
        [JsonPropertyName("count")]
        public int Count { get; set; } 

        [JsonPropertyName("items")]
        public List<Item> Items { get; set; } 
    }

    public class Homebrew    {
        [JsonPropertyName("count")]
        public int Count { get; set; } 

        [JsonPropertyName("items")]
        public List<object> Items { get; set; } 
    }

    public class Breweries    {
        [JsonPropertyName("items")]
        public List<object> Items { get; set; } 

        [JsonPropertyName("count")]
        public int Count { get; set; } 
    }

    public class BeerSearchInfo    {
        [JsonPropertyName("message")]
        public string Message { get; set; } 

        [JsonPropertyName("time_taken")]
        public double TimeTaken { get; set; } 

        [JsonPropertyName("brewery_id")]
        public int BreweryId { get; set; } 

        [JsonPropertyName("search_type")]
        public string SearchType { get; set; } 

        [JsonPropertyName("type_id")]
        public int TypeId { get; set; } 

        [JsonPropertyName("search_version")]
        public int SearchVersion { get; set; } 

        [JsonPropertyName("found")]
        public int Found { get; set; } 

        [JsonPropertyName("offset")]
        public int Offset { get; set; } 

        [JsonPropertyName("limit")]
        public int Limit { get; set; } 

        [JsonPropertyName("term")]
        public string Term { get; set; } 

        [JsonPropertyName("parsed_term")]
        public string ParsedTerm { get; set; } 

        [JsonPropertyName("beers")]
        public Beers Beers { get; set; } 

        [JsonPropertyName("homebrew")]
        public Homebrew Homebrew { get; set; } 

        [JsonPropertyName("breweries")]
        public Breweries Breweries { get; set; } 
    }

    public class BeerSearchResponse  : UntappdBasicResponse  {
        [JsonPropertyName("meta")]
        public Meta Meta { get; set; } 

        [JsonPropertyName("notifications")]
        public List<object> Notifications { get; set; } 

        [JsonPropertyName("response")]
        public BeerSearchInfo Response { get; set; } 
    }
}