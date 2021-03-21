namespace Saison
{
    public class Untappd
    {
        public BeerApi Beer { get; set; }
        public VenueApi Venue { get; set; }
        public WishlistApi Wishlist { get; set; }
        public ThePubApi ThePub { get; set; }

        public Untappd(string clientId, string clientSecret, string accessToken = null)
        {
            Config.ClientId = clientId;
            Config.ClientSecret = clientSecret;
            Config.AccessToken = accessToken;

            Beer = new BeerApi();
            Venue = new VenueApi();
            Wishlist = new WishlistApi();
            ThePub = new ThePubApi();
        }
    }
}