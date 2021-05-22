namespace Saison
{
    /// <summary>
    /// Main class for using Untappd API.
    /// </summary>
    public class Untappd
    {
        /// <summary>
        /// Authentication methods. Authentication is handled via OAuth 2.0, so you must setup your own server to authetificate a user.
        /// </summary>
        public AuthApi Auth { get; set; }

        /// <summary>
        /// Beer methods
        /// </summary>
        public BeerApi Beer { get; set; }
        /// <summary>
        /// Brewery methods
        /// </summary>
        public BreweryApi Brewery { get; set; }
        /// <summary>
        /// Venue methods
        /// </summary>
        public VenueApi Venue { get; set; }
        /// <summary>
        /// User's wishlist methods
        /// </summary>
        public WishlistApi Wishlist { get; set; }
        
        /// <summary>
        /// The Pub methods
        /// </summary>
        public ThePubApi ThePub { get; set; }
        
        public static int XRatelimit => ServiceClient.XRatelimit;
        public static int XRatelimitRemaining => ServiceClient.XRatelimitRemaining;

        /// <summary>
        /// Creates new instance of Untappd API wrapper.
        /// </summary>
        /// <param name="clientId">Public API key.</param>
        /// <param name="clientSecret">Secret API key.</param>
        public Untappd(string clientId, string clientSecret)
        {
            Config.ClientId = clientId;
            Config.ClientSecret = clientSecret;

            Beer = new BeerApi();
            Venue = new VenueApi();
            Wishlist = new WishlistApi();
            ThePub = new ThePubApi();
            Brewery = new BreweryApi();
            Auth = new AuthApi();
        }
    }
}