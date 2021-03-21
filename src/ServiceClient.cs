using System;
using System.Text.Json;
using RestSharp;
using RestSharp.Serializers.SystemTextJson;
using Saison.Models;

namespace Saison
{
    internal class ServiceClient
    {
        private readonly RestClient _client;
        private const string Host = "https://api.untappd.com/v4";

        public ServiceClient()
        {
            _client = new RestClient(Host);
            _client.UseSystemTextJson(new JsonSerializerOptions()
            {
                IgnoreNullValues = true
            });
        }

        private T Execute<T>(RestRequest request)
            where T : UntappdBasicResponse, new()
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
                var basicResponse = JsonSerializer.Deserialize<UntappdBasicResponse>(response.Content);
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
            where T : UntappdBasicResponse<T2>, new() 
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
                var basicResponse = JsonSerializer.Deserialize<UntappdBasicResponse>(response.Content);
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
        
        public Beers SearchBeer(string q, int? offset = null, int? limit = null, string sort = null)
        {
            var request = new RestRequest("search/beer", Method.GET, DataFormat.Json);
            request.AddQueryParameter("q", q);

            var result = Execute<BeerSearchResponse>(request);
            return result.Response.Beers;
        }

        public BeerInfoFull BeerInfo(int bid, bool compact = false)
        {
            var request = new RestRequest($"beer/info/{bid}", Method.GET, DataFormat.Json);
            request.AddQueryParameter("compact", compact.ToString());

            BeerInfoResponseContainer result = Execute<BeerInfoResponseContainer>(request);
            return result.Response.Beer;
        }
        
        public BeerActivityResponse BeerCheckins(int bid, int limit = 25, int? maxId = null, int? minId = null)
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

            var result = Execute<BeerActivityResponseContainer>(request);
            return result.Response;
        }

        public FoursquareLookupResponseContainer VenueFoursqaureLookup(string venueId)
        {
            var request = new RestRequest($"venue/foursquare_lookup/{venueId}", Method.GET, DataFormat.Json);

            var result = Execute<FoursquareLookupResponseContainer>(request);
            return result;
        }

        public VenueInfoResponseContainer VenueInfo(int venueId)
        {
            var request = new RestRequest($"venue/info/{venueId}", Method.GET, DataFormat.Json);

            var result = Execute<VenueInfoResponseContainer>(request);
            return result;
        }

        public WishlistAddContainer WishlistAdd(int bid)
        {
            var request = new RestRequest("user/wishlist/add", Method.POST, DataFormat.Json);
            request.AddJsonBody(new WishlistAddRequest(bid));

            var result = Execute<WishlistAddContainer>(request);
            return result;
        }

        public ThePubResponseContainer ThePubLocal(float latitude, float longitude, int? maxId = null, int? minId = null, 
            int limit = 25, int radius = 25, DistancePreference distancePreference = DistancePreference.Miles)
        {
            var request = new RestRequest("thepub/local", Method.GET, DataFormat.Json);
            request.AddQueryParameter("lat", latitude.ToString());
            request.AddQueryParameter("lng", longitude.ToString());
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

            var result = Execute<ThePubResponseContainer>(request);
            return result;
        }

        public UntappdBasicResponse<BrewerySearchResponse> SearchBrewery(string q)
        {
            var request = new RestRequest("search/brewery", Method.GET, DataFormat.Json);
            request.AddQueryParameter("q", q);

            var result = Execute<UntappdBasicResponse<BrewerySearchResponse>, BrewerySearchResponse>(request);
            return result;
        }
    }
}