using System;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using Saison.Models;
using Saison.Models.Untappd;

namespace Saison
{
    public class ThePubApi
    {
        private static readonly IFormatProvider Format = CultureInfo.InvariantCulture;
        
        private readonly ServiceClientAsync _serviceClient;

        public ThePubApi()
        {
            _serviceClient = new ServiceClientAsync();
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
        /// <param name="distancePreference">If you want the results returned in miles or km. Available options: <see cref="DistancePreference"/>. Default is "m"</param>
        /// <param name="accessToken"></param>
        /// <returns></returns>
        public async Task<ResponseContainer<ThePub>> Local(float latitude, float longitude, int? maxId = null, int? minId = null, int limit = 25, int radius = 25, string distancePreference = DistancePreference.Miles, string? accessToken = null)
        {
            var builder = new StringBuilder();
            builder.Append($"thepub/local?lat={latitude.ToString(Format)}&lng={longitude.ToString(Format)}&limit={limit}&radius={radius}&dist_pref={distancePreference}");
            if (maxId.HasValue)
            {
                builder.Append($"&maxId={maxId}");
            }

            if (minId.HasValue)
            {
                builder.Append($"&minId={minId}");
            }
            
            if (accessToken != null)
            {
                builder.Append($"&access_token={accessToken}");
            }

            return await _serviceClient.ExecuteGetAsync<ResponseContainer<ThePub>>(builder.ToString());
        }
    }
}