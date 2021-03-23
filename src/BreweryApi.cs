using Saison.Models.Brewery;

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
        /// <returns></returns>
        public SearchResponse Search(string q)
        {
            return _serviceClient.SearchBrewery(q);
        }

        /// <summary>
        /// This method will allow you to see extended information about a brewery.
        /// </summary>
        /// <param name="breweryId">The Brewery ID that you want to display checkins</param>
        /// <returns></returns>
        public BreweryInfo Info(int breweryId)
        {
            return _serviceClient.BreweryInfo(breweryId);
        }
    }
}