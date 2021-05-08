namespace Saison
{
    /// <summary>
    /// Main class for using Untappd API.
    /// </summary>
    public class Untappd
    {
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

        /// <summary>
        /// Creates new instance of Untappd API wrapper. You need to provide either <see cref="clientId"/>
        /// and <see cref="clientSecret"/> or <see cref="accessToken"/>. <see cref="accessToken"/> is required action methods.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="accessToken"></param>
        public Untappd(string clientId, string clientSecret)
        {
            Config.ClientId = clientId;
            Config.ClientSecret = clientSecret;

            Beer = new BeerApi();
            Venue = new VenueApi();
            Wishlist = new WishlistApi();
            ThePub = new ThePubApi();
            Brewery = new BreweryApi();
        }
    }
}