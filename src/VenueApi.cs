using System.Linq;
using Saison.Models;
using Saison.Models.Activity;
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

        /// <summary>
        /// This method will allow you to pass in a foursquare v2 ID and return a Untappd Venue ID to be used for <see cref="VenueApi"/>.
        /// </summary>
        /// <param name="foursquareVenueId"></param>
        /// <returns></returns>
        public ResponseContainer<FoursquareLookup> FoursquareLookup(string foursquareVenueId)
        {
            return _client.VenueFoursqaureLookup(foursquareVenueId);
        }

        /// <summary>
        /// This method will allow you to see extended information about a venue.
        /// </summary>
        /// <param name="venueId"></param>
        /// <returns></returns>
        public ResponseContainer<VenueInfo> Info(int venueId)
        {
            return _client.VenueInfo(venueId);
        }

        /// <summary>
        /// This method allows you the obtain an activity feed for a single venue for Untappd. By default it will return at max 25 records.
        /// </summary>
        /// <param name="venueId"></param>
        /// <param name="maxId"></param>
        /// <param name="minId"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public ResponseContainer<VenueActivity> Checkins(int venueId, int? maxId = null, int? minId = null, int limit = 25)
        {
            return _client.VenueCheckins(venueId, maxId, minId, limit);
        }
    }
}