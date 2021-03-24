using Saison.Models.Activity;
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
        
        public ResponseContainer<BeerSearchResponse> Search(string q)
        {
            return _client.SearchBeer(q);
        }
        
        public ResponseContainer<BeerInfo> Info(int bid)
        {
            return _client.BeerInfo(bid);
        }

        public ResponseContainer<BeerActivity> Checkins(int bid)
        {
            return _client.BeerCheckins(bid);
        }
    }
}