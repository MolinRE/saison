namespace Saison.Models.Wishlist
{
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
}