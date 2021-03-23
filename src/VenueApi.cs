using System.Linq;
using Saison.Models;
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

        public VenueLookupItem FoursquareLookup(string foursquareVenueId)
        {
            var result = _client.VenueFoursqaureLookup(foursquareVenueId);
            if (result.Meta.Code == 500)
            {
                if (result.Meta.ErrorDetail.Contains("There is no Untappd venue match"))
                {
                    return null;
                }
            }
            
            return result.Response.Venue.Items.FirstOrDefault();
        }

        public VenueInfo Info(int venueId)
        {
            var result = _client.VenueInfo(venueId);
            return result;
        }
    }
}