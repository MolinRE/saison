using Saison.Models;

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
        public BrewerySearchResponse Search(string q)
        {
            return _serviceClient.SearchBrewery(q).Response;
        }

        public object Info(int breweryId)
        {
            return _serviceClient.BreweryInfo(breweryId);
        }
    }
}