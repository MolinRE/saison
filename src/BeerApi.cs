using System;
using Saison.Models;
using Saison.Models.Beer;

namespace Saison
{
    public class BeerApi
    {
        private readonly ServiceClient _client;

        public BeerApi()
        {
            _client = new ServiceClient();
        }
        
        public object Search(string q)
        {
            var result = _client.SearchBeer(q);
            return result;
        }
        
        public BeerInfo Info(int bid)
        {
            var result = _client.BeerInfo(bid);
            return result;
        }

        public BeerActivityResponse Checkins(int bid)
        {
            var result = _client.BeerCheckins(bid);
            return result;
        }
    }
}