using Saison.Models.Beer;
using Saison.Models.Untappd;

namespace Saison
{
    public class BeerApi
    {
        private readonly ServiceClient _client;

        public BeerApi()
        {
            _client = new ServiceClient();
        }
        
        /// <summary>
        /// This will allow you to search across the Untappd database for beers and breweries.
        /// <para>Note: The best way to search is always "Brewery Name + Beer Name", such as "Dogfish 60 Minute".</para>
        /// </summary>
        /// <param name="q">The search term that you want to search.</param>
        /// <param name="offset">The numeric offset that you what results to start</param>
        /// <param name="limit">The number of results to return, max of 50, default is 25</param>
        /// <param name="sorting">Your can sort the results using these values: checkin - sorts by checkin count
        /// (default), name - sorted by alphabetic beer name</param>
        /// <returns></returns>
        public ResponseContainer<BeerSearchResponse> Search(string q, int? offset = null, int limit = 25, 
            SearchBeerSorting sorting = SearchBeerSorting.Checkin, string accessToken = null)
        {
            return _client.SearchBeer(q, offset, limit, sorting.ToString().ToLower(), accessToken);
        }
        
        /// <summary>
        /// This method will allow you to see extended information about a beer.
        /// </summary>
        /// <param name="bid"></param>
        /// <returns></returns>
        public ResponseContainer<BeerInfoContainer> Info(int bid, string accessToken = null)
        {
            return _client.BeerInfo(bid, false, accessToken);
        }

        /// <summary>
        /// This method allows you the obtain an activity feed for a single beer for Untappd. By default it will return at max 25 records
        /// </summary>
        /// <param name="bid">The beer ID that you want to display checkins</param>
        /// <param name="maxId">The checkin ID that you want the results to start with</param>
        /// <param name="minId">Returns only checkins that are newer than this value</param>
        /// <param name="limit">The number of results to return, max of 25, default is 25</param>
        /// <returns></returns>
        public ResponseContainer<BeerActivity> Checkins(int bid, int? maxId = null, int? minId = null, int limit = 25, string accessToken = null)
        {
            return _client.BeerCheckins(bid, maxId, minId, limit, accessToken);
        }
    }
}