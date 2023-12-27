using System;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Saison.Models.Untappd;

namespace Saison
{
    internal class ServiceClientAsync
    {
        private static readonly HttpClient Client = new()
        {
            BaseAddress = new Uri(Host)
        };

        private const string Host = "https://api.untappd.com/v4/";
        
        internal static int XRateLimitRemaining { get; private set; }

        internal static int XRateLimit { get; private set; }

        public ServiceClientAsync()
        {
            Client.DefaultRequestHeaders.UserAgent.ParseAdd($"JoyTapBot/0.2 ({Config.ClientId})");
        }

        internal async Task<T> ExecuteGetAsync<T>(string url)
            where T : ResponseContainerBase, new()
        {
            using var request = new HttpRequestMessage();
            request.Method = HttpMethod.Get;
            request.RequestUri = CreateUri(url);
            request.Headers.Add("Connection", "keep-alive");

            using var response = await Client.SendAsync(request);
            foreach (var header in response.Headers)
            {
                switch (header.Key)
                {
                    case "X-Ratelimit-Limit":
                        XRateLimit = int.Parse(header.Value.ToString());
                        break;
                    case "X-Ratelimit-Remaining":
                        XRateLimitRemaining = int.Parse(header.Value.ToString());
                        break;
                }
            }

            if (response.StatusCode == HttpStatusCode.OK)
            {
                return await ReadContentAsync<T>(response.Content);
            }

            var basicResponse = await ReadContentAsync<ResponseContainer>(response.Content);
            return new T
            {
                Meta = basicResponse.Meta
            };
        }

        private static Uri CreateUri(string url)
        {
            if (url.Contains("access_token"))
            {
                return new Uri(url, UriKind.Relative);
            }

            return new Uri(url + $"&client_id={Config.ClientId}&client_secret={Config.ClientSecret}", UriKind.RelativeOrAbsolute);
        }
        
        private static async Task<T> ReadContentAsync<T>(HttpContent content)
        {
            await using var stream = await content.ReadAsStreamAsync();
            stream.Position = 0;
#pragma warning disable CS8603 // Possible null reference return.
            return await JsonSerializer.DeserializeAsync<T>(stream, GetJsonSerializerOptions());
#pragma warning restore CS8603 // Possible null reference return.
        }

        private static JsonSerializerOptions GetJsonSerializerOptions()
        {
            var options = new JsonSerializerOptions
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            };
            options.Converters.Add(new Helpers.ArrayOrObjectConverter<Models.Activity.Venue>());
            options.Converters.Add(new Helpers.ArrayOrObjectConverter<Models.Beer.MediaVenue>());
            options.Converters.Add(new Helpers.ArrayOrObjectConverter<Models.Brewery.MediaVenue>());
            options.Converters.Add(new Helpers.ArrayOrObjectConverter<Models.Activity.BreweryDetails>());
            options.Converters.Add(new Helpers.ArrayOrObjectConverter<Models.Activity.VenueDetails>());
            options.Converters.Add(new Helpers.ArrayOrObjectConverter<Models.Feeds.Activity.ActivityFeed>());
            return options;
        }
    }
}