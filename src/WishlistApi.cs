namespace Saison
{
    public class WishlistApi
    {
        private readonly ServiceClient _client;

        public WishlistApi()
        {
            _client = new ServiceClient();
        }
        
        /// <summary>
        /// This method will allow you to add a beer to your wish list.
        /// </summary>
        /// <param name="bid">The numeric BID of the beer you want to add your list</param>
        public void Add(int bid)
        {
            _client.WishlistAdd(bid);
        }
    }
}