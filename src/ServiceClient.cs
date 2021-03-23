using System;
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
            _client.UseSystemTextJson(new JsonSerializerOptions()
            {
                IgnoreNullValues = true
            });
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
        
        public Search SearchBeer(string q, int? offset = null, int? limit = null, string sort = null)
        {
            var request = new RestRequest("search/beer", Method.GET, DataFormat.Json);
            request.AddQueryParameter("q", q);

            var result = Execute<ResponseContainer<BeerSearchResponse>>(request);
            return result.Response.Beers;
        }

        public BeerInfo BeerInfo(int bid, bool compact = false)
        {
            var request = new RestRequest($"beer/info/{bid}", Method.GET, DataFormat.Json);
            request.AddQueryParameter("compact", compact.ToString());

            var result = Execute<ResponseContainer<BeerInfo>>(request);
            return result.Response;
        }
        
        public BeerActivity BeerCheckins(int bid, int limit = 25, int? maxId = null, int? minId = null)
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

            var result = Execute<ResponseContainer<BeerActivity>>(request);
            return result.Response;
        }

        public ResponseContainer<FoursquareLookup> VenueFoursqaureLookup(string venueId)
        {
            var request = new RestRequest($"venue/foursquare_lookup/{venueId}", Method.GET, DataFormat.Json);

            var result = Execute<ResponseContainer<FoursquareLookup>>(request);
            return result;
        }

        public VenueInfo VenueInfo(int venueId)
        {
            var request = new RestRequest($"venue/info/{venueId}", Method.GET, DataFormat.Json);

            var result = Execute<ResponseContainer<VenueInfo>>(request);
            return result.Response;
        }

        public WishlistAddContainer WishlistAdd(int bid)
        {
            var request = new RestRequest("user/wishlist/add", Method.POST, DataFormat.Json);
            request.AddJsonBody(new WishlistAddRequest(bid));

            var result = Execute<WishlistAddContainer>(request);
            return result;
        }

        public ThePub ThePubLocal(float latitude, float longitude, int? maxId = null, int? minId = null, 
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

            var result = Execute<ResponseContainer<ThePub>>(request);
            return result.Response;
        }

        public Models.Brewery.SearchResponse SearchBrewery(string q)
        {
            var request = new RestRequest("search/brewery", Method.GET, DataFormat.Json);
            request.AddQueryParameter("q", q);

            var result = Execute<ResponseContainer<Models.Brewery.SearchResponse>>(request);
            return result.Response;
        }

        public Models.Brewery.BreweryInfo BreweryInfo(int breweryId)
        {
            var request = new RestRequest($"brewery/info/{breweryId}", Method.GET, DataFormat.Json);
            request.AddQueryParameter("compact", false.ToString());

            var result = Execute<ResponseContainer<Models.Brewery.BreweryInfo>>(request);
            return result.Response;
        }
    }
}