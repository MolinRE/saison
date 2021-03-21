using System.Text.Json.Serialization;

namespace Saison.Models
{
    public interface IAuthentificationRequired
    {
        string AccessToken { get; set; }
    }

    public abstract class AbstractAuthentificationRequired
    {
        public string AccessToken { get; set; }
    }

    public class WishlistAddRequest : AbstractAuthentificationRequired
    {
        public int Bid { get; set; }

        public WishlistAddRequest()
        {
            
        }

        public WishlistAddRequest(int bid)
        {
            Bid = bid;
        }
    }

    public class WishlistAddContainer : UntappdBasicResponse
    {
        [JsonPropertyName("result")]
        public string Result { get; set; }
        
        [JsonPropertyName("action")]
        public string Action { get; set; }
    }
}