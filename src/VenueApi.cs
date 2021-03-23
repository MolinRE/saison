using System.Linq;
using Saison.Models;
using Saison.Models.Untappd;
using Saison.Models.Venue;

namespace Saison
{
    public class VenueApi
    {
        private readonly ServiceClient _client;

        public VenueApi()
        {
            _client = new ServiceClient();
        }

        public ResponseContainer<FoursquareLookup> FoursquareLookup(string foursquareVenueId)
        {
            return _client.VenueFoursqaureLookup(foursquareVenueId);
        }

        public ResponseContainer<VenueInfo> Info(int venueId)
        {
            return _client.VenueInfo(venueId);
        }
    }
}