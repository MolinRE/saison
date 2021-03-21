namespace Saison
{
    public class WishlistApi
    {
        private readonly ServiceClient _client;

        public WishlistApi()
        {
            _client = new ServiceClient();
        }
        
        public void Add(int bid)
        {
            _client.WishlistAdd(bid);
        }
    }
}