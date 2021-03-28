using Saison.Models;
using Saison.Models.Untappd;

namespace Saison
{
    public class ThePubApi
    {
        private readonly ServiceClient _serviceClient;

        public ThePubApi()
        {
            _serviceClient = new ServiceClient();
        }
        
        /// <summary>
        /// This method allows you the obtain all the public feed for Untappd, within a certain location. By default it will return at max 25 records.
        /// </summary>
        /// <param name="latitude">The latitude of the query</param>
        /// <param name="longitude">The longitude of the query</param>
        /// <param name="maxId">The checkin ID that you want the results to start with</param>
        /// <param name="minId">Returns only checkins that are newer than this value</param>
        /// <param name="limit">The number of results to return, max of 25, default is 25</param>
        /// <param name="radius">The max radius you would like the check-ins to start within, max of 25, default is 25</param>
        /// <param name="distancePreference">If you want the results returned in miles or km. Available options: "m", or "km". Default is "m"</param>
        /// <returns></returns>
        public ResponseContainer<ThePub> Local(float latitude, float longitude, int? maxId = null, int? minId = null, 
            int limit = 25, int radius = 25, DistancePreference distancePreference = DistancePreference.Miles)
        {
            return _serviceClient.ThePubLocal(latitude, longitude, maxId, minId, limit, radius, 
                distancePreference);
        }
    }
}