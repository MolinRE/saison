using System.Text.Json.Serialization;

namespace Saison.Models;

public class Source
{
    [JsonPropertyName("app_name")]
    public string AppName { get; set; }

    [JsonPropertyName("app_website")]
    public string AppWebsite { get; set; }
}