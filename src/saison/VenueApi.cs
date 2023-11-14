using System.Text;
using System.Threading.Tasks;
using Saison.Extensions;
using Saison.Models.Activity;
using Saison.Models.Untappd;
using Saison.Models.Venue;

namespace Saison
{
    public class VenueApi
    {
        private readonly ServiceClientAsync _client;

        public VenueApi()
        {
            _client = new ServiceClientAsync();
        }

        /// <summary>
        /// This method will allow you to pass in a foursquare v2 ID and return a Untappd Venue ID to be used for <see cref="VenueApi"/>.
        /// </summary>
        /// <param name="foursquareVenueId"></param>
        /// <param name="accessToken"></param>
        /// <returns></returns>
        public async Task<ResponseContainer<FoursquareLookup>> FoursquareLookup(string foursquareVenueId, string? accessToken = null)
        {
            var builder = new StringBuilder();
            builder.Append($"venue/foursquare_lookup/{foursquareVenueId}?");
            builder.AppendAccessToken(accessToken);
            
            return await _client.ExecuteGetAsync<ResponseContainer<FoursquareLookup>>(builder.ToString());
        }

        /// <summary>
        /// This method will allow you to see extended information about a venue.
        /// </summary>
        /// <param name="venueId"></param>
        /// <param name="accessToken"></param>
        /// <returns></returns>
        public async Task<ResponseContainer<VenueInfoContainer>> Info(int venueId, string? accessToken = null)
        {
            var builder = new StringBuilder();
            builder.Append($"venue/info/{venueId}?");
            builder.AppendAccessToken(accessToken);
            
            return await _client.ExecuteGetAsync<ResponseContainer<VenueInfoContainer>>(builder.ToString());
        }

        /// <summary>
        /// This method allows you the obtain an activity feed for a single venue for Untappd. By default it will return at max 25 records.
        /// </summary>
        /// <param name="venueId"></param>
        /// <param name="maxId"></param>
        /// <param name="minId"></param>
        /// <param name="limit"></param>
        /// <param name="accessToken"></param>
        /// <returns></returns>
        public async Task<ResponseContainer<VenueActivity>> Checkins(int venueId, int? maxId = null, int? minId = null, int limit = 25, string accessToken = null)
        {
            var builder = new StringBuilder();
            builder.Append($"venue/checkins/{venueId}?limit={limit}");
            if (maxId.HasValue)
            {
                builder.Append($"&maxId={maxId}");
            }

            if (minId.HasValue)
            {
                builder.Append($"&minId={minId}");
            }
            builder.AppendAccessToken(accessToken);
            
            return await _client.ExecuteGetAsync<ResponseContainer<VenueActivity>>(builder.ToString());
        }
    }
}