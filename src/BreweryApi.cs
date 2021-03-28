using Saison.Models.Brewery;
using Saison.Models.Untappd;

namespace Saison
{
    public class BreweryApi
    {
        private readonly ServiceClient _serviceClient;

        public BreweryApi()
        {
            _serviceClient = new ServiceClient();
        }

        /// <summary>
        /// This will allow you to search exclusively for breweries in the Untappd system.
        /// </summary>
        /// <param name="q">The search term that you want to search.</param>
        /// <param name="offset">The numeric offset that you what results to start</param>
        /// <param name="limit">The number of results to return, max of 50, default is 25</param>
        /// <returns></returns>
        public ResponseContainer<SearchResponse> Search(string q, int? offset = null, int limit = 25)
        {
            return _serviceClient.SearchBrewery(q, offset, limit);
        }

        /// <summary>
        /// This method will allow you to see extended information about a brewery.
        /// </summary>
        /// <param name="breweryId">The Brewery ID that you want to display checkins</param>
        /// <returns></returns>
        public ResponseContainer<BreweryInfoContainer> Info(int breweryId)
        {
            return _serviceClient.BreweryInfo(breweryId);
        }
    }
}