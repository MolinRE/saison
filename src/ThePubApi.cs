using Saison.Models;

namespace Saison
{
    public class ThePubApi
    {
        private readonly ServiceClient _serviceClient;

        public ThePubApi()
        {
            _serviceClient = new ServiceClient();
        }
        
        public ThePub Local(float latitude, float longitude, int? maxId = null, int? minId = null, 
            int limit = 25, int radius = 25, DistancePreference distancePreference = DistancePreference.Miles)
        {
            var result = _serviceClient.ThePubLocal(latitude, longitude, maxId, minId, limit, radius, 
                distancePreference);
            return result;
        }
    }
}