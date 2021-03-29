using System;
using System.Globalization;
using System.Text.Json;
using RestSharp;
using RestSharp.Serializers.SystemTextJson;
using Saison.Models;
using Saison.Models.Activity;
using Saison.Models.Beer;
using Saison.Models.Untappd;
using Saison.Models.Venue;
using Saison.Models.Wishlist;

namespace Saison
{
    internal class ServiceClient
    {
        private readonly RestClient _client;
        private const string Host = "https://api.untappd.com/v4";

        public ServiceClient()
        {
            _client = new RestClient(Host);
            _client.UseSystemTextJson(GetJsonSerializerOptions());
        }

        private static JsonSerializerOptions GetJsonSerializerOptions()
        {
            var options = new JsonSerializerOptions();
            options.IgnoreNullValues = true;
            options.Converters.Add(new Helpers.ArrayOrObjectConverter<Saison.Models.Activity.Venue>());
            options.Converters.Add(new Helpers.ArrayOrObjectConverter<Saison.Models.Beer.MediaVenue>());
            options.Converters.Add(new Helpers.ArrayOrObjectConverter<Saison.Models.Brewery.MediaVenue>());
            options.Converters.Add(new Helpers.ArrayOrObjectConverter<Saison.Models.Activity.BreweryDetails>());
            options.Converters.Add(new Helpers.ArrayOrObjectConverter<Saison.Models.Activity.VenueDetails>());
            return options;
        }

        private T Execute<T>(RestRequest request)
            where T : ResponseContainer, new()
        {
            if (request.Method == Method.POST)
            {
                if (request.Body.Value is IAuthentificationRequired body)
                {
                    body.AccessToken = Config.AccessToken;
                    request.AddJsonBody(body);
                }
            }
            
            request.AddQueryParameter("client_id", Config.ClientId);
            request.AddQueryParameter("client_secret", Config.ClientSecret);
            request.AddHeader("User-Agent", $"JoyTapBot ({Config.ClientId})/0.1");
            
            var response = _client.Execute<T>(request);
            if (response.Data == null)
            {
                var basicResponse = JsonSerializer.Deserialize<ResponseContainer>(response.Content);
                if (basicResponse != null)
                {
                    var result = new T();
                    result.Meta = basicResponse.Meta;
                    return result;
                }
                if (response.ErrorException != null)
                {
                    throw new Exception("Ошибка при обработке ответа API Untappd", response.ErrorException);
                }
            }
            return response.Data;
        }


        private T Execute<T, T2>(RestRequest request)
            where T : ResponseContainer<T2>, new() 
            where T2 : new()
        {
            if (request.Method == Method.POST)
            {
                if (request.Body.Value is IAuthentificationRequired body)
                {
                    body.AccessToken = Config.AccessToken;
                    request.AddJsonBody(body);
                }
            }
            
            request.AddQueryParameter("client_id", Config.ClientId);
            request.AddQueryParameter("client_secret", Config.ClientSecret);
            request.AddHeader("User-Agent", $"JoyTapBot ({Config.ClientId})/0.1");
            
            var response = _client.Execute<T>(request);
            if (response.Data == null)
            {
                var basicResponse = JsonSerializer.Deserialize<ResponseContainer<T2>>(response.Content);
                if (basicResponse != null)
                {
                    var result = new T();
                    result.Meta = basicResponse.Meta;
                    return result;
                }
                if (response.ErrorException != null)
                {
                    throw new Exception("Ошибка при обработке ответа API Untappd", response.ErrorException);
                }
            }
            return response.Data;
        }
        
        public ResponseContainer<BeerSearchResponse> SearchBeer(string q, int? offset = null, int limit = 25, string sort = "checkin")
        {
            var request = new RestRequest("search/beer", Method.GET, DataFormat.Json);
            request.AddQueryParameter("q", q);
            request.AddQueryParameter("limit", limit.ToString());
            request.AddQueryParameter("sort", sort);
            if (offset.HasValue)
            {
                request.AddQueryParameter("offset", offset.ToString());
            }

            return Execute<ResponseContainer<BeerSearchResponse>>(request);
        }

        public ResponseContainer<BeerInfoContainer> BeerInfo(int bid, bool compact = false)
        {
            var request = new RestRequest($"beer/info/{bid}", Method.GET, DataFormat.Json);
            request.AddQueryParameter("compact", compact.ToString());

            return Execute<ResponseContainer<BeerInfoContainer>>(request);
        }
        
        public ResponseContainer<BeerActivity> BeerCheckins(int bid, int? maxId = null, int? minId = null, 
            int limit = 25)
        {
            var request = new RestRequest($"beer/checkins/{bid}", Method.GET, DataFormat.Json);
            request.AddQueryParameter("limit", limit.ToString());
            if (maxId.HasValue)
            {
                request.AddQueryParameter("max_id", maxId.ToString());
            }

            if (minId.HasValue)
            {
                request.AddQueryParameter("min_id", minId.ToString());
            }

            return Execute<ResponseContainer<BeerActivity>>(request);
        }

        public ResponseContainer<FoursquareLookup> VenueFoursqaureLookup(string venueId)
        {
            var request = new RestRequest($"venue/foursquare_lookup/{venueId}", Method.GET, DataFormat.Json);

            return Execute<ResponseContainer<FoursquareLookup>>(request);
        }

        public ResponseContainer<VenueInfoContainer> VenueInfo(int venueId)
        {
            var request = new RestRequest($"venue/info/{venueId}", Method.GET, DataFormat.Json);

            return Execute<ResponseContainer<VenueInfoContainer>>(request);
        }

        public WishlistAddContainer WishlistAdd(int bid)
        {
            var request = new RestRequest("user/wishlist/add", Method.POST, DataFormat.Json);
            request.AddJsonBody(new WishlistAddRequest(bid));

            return Execute<WishlistAddContainer>(request);
        }

        public ResponseContainer<ThePub> ThePubLocal(float latitude, float longitude, int? maxId = null, int? minId = null, 
            int limit = 25, int radius = 25, DistancePreference distancePreference = DistancePreference.Miles)
        {
            var request = new RestRequest("thepub/local", Method.GET, DataFormat.Json);
            request.AddQueryParameter("lat", latitude.ToString(CultureInfo.InvariantCulture));
            request.AddQueryParameter("lng", longitude.ToString(CultureInfo.InvariantCulture));
            if (maxId.HasValue)
            {
                request.AddQueryParameter("maxId", maxId.ToString());
            }

            if (minId.HasValue)
            {
                request.AddQueryParameter("minId", minId.ToString());
            }

            request.AddQueryParameter("limit", limit.ToString());
            request.AddQueryParameter("radius", radius.ToString());
            request.AddQueryParameter("dist_pref", distancePreference == DistancePreference.Miles ? "m" : "km");

            return Execute<ResponseContainer<ThePub>>(request);
        }

        public ResponseContainer<Models.Brewery.SearchResponse> SearchBrewery(string q, int? offset = null, int limit = 25)
        {
            var request = new RestRequest("search/brewery", Method.GET, DataFormat.Json);
            request.AddQueryParameter("q", q);
            request.AddQueryParameter("limit", limit.ToString());
            if (offset.HasValue)
            {
                request.AddQueryParameter("offset", offset.ToString());   
            }
            
            return Execute<ResponseContainer<Models.Brewery.SearchResponse>>(request);
        }

        public ResponseContainer<Models.Brewery.BreweryInfoContainer> BreweryInfo(int breweryId)
        {
            var request = new RestRequest($"brewery/info/{breweryId}", Method.GET, DataFormat.Json);
            request.AddQueryParameter("compact", false.ToString());

            return Execute<ResponseContainer<Models.Brewery.BreweryInfoContainer>>(request);
        }

        public ResponseContainer<VenueActivity> VenueCheckins(int venueId, int? maxId = null, int? minId = null, int limit = 25)
        {
            var request = new RestRequest($"venue/checkins/{venueId}", Method.GET, DataFormat.Json);
            request.AddQueryParameter("limit", limit.ToString());
            if (maxId.HasValue)
            {
                request.AddQueryParameter("max_id", maxId.ToString());
            }

            if (minId.HasValue)
            {
                request.AddQueryParameter("min_id", minId.ToString());
            }

            return Execute<ResponseContainer<VenueActivity>>(request);
        }
    }
}