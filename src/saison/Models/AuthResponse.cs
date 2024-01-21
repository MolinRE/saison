using System.Text.Json.Serialization;

namespace Saison.Models
{
    public class AuthResponse
    {
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }
    }
}