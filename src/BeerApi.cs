using System;
using Saison.Models;

namespace Saison
{
    public class BeerApi
    {
        private readonly ServiceClient _client;

        public BeerApi()
        {
            _client = new ServiceClient();
        }
        
        public Beers Search(string q)
        {
            var result = _client.SearchBeer(q);
            return result;
        }
        
        public BeerInfoFull Info(int bid)
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