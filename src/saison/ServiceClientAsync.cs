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

        private string? _debugLastResponse;

        private const string Host = "https://api.untappd.com/v4/";
        
        public static int XRateLimitRemaining { get; private set; }

        public static int XRateLimit { get; private set; }

        public ServiceClientAsync()
        {
            Client.DefaultRequestHeaders.UserAgent.ParseAdd($"JoyTapBot/0.1 ({Config.ClientId})");
            _debugLastResponse = null;
        }
        
        internal async Task<T> ExecuteGetAsync<T>(string url)
            where T : ResponseContainer, new()
        {
            try
            {
                Console.WriteLine("========== DEBUG START ==========");
                using (var request = new HttpRequestMessage())
                {
                    request.Method = HttpMethod.Get;
                    request.RequestUri = CreateUri(url);;
                    Console.WriteLine("request.RequestUri:");
                    request.Headers.Add("Connection", "keep-alive");

                    using (var response = await Client.SendAsync(request))
                    {
                        Console.WriteLine("\t" + request.RequestUri);
                        Console.WriteLine("response.RequestMessage.Headers:");
                        foreach (var h in response.RequestMessage.Headers)
                        {
                            Console.WriteLine($"\t- {h.Key}: {string.Join(", ", h.Value)}");
                        }

                        Console.WriteLine("response.Headers:");
                        foreach (var h in response.Headers)
                        {
                            Console.WriteLine($"\t- {h.Key}: {string.Join(", ", h.Value)}");
                        }

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

                        _debugLastResponse = await response.Content.ReadAsStringAsync();
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
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                Console.WriteLine("========== DEBUG END ==========");
            }
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
            return await JsonSerializer.DeserializeAsync<T>(stream, GetJsonSerializerOptions()) 
                   ?? throw new Exception("Чё за хуйня, там под капотом код не возвращет nullable. Это меня Rider заставил поставить.");
        }

        private static JsonSerializerOptions GetJsonSerializerOptions()
        {
            var options = new JsonSerializerOptions
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            };
            options.Converters.Add(new Helpers.ArrayOrObjectConverter<Saison.Models.Activity.Venue>());
            options.Converters.Add(new Helpers.ArrayOrObjectConverter<Saison.Models.Beer.MediaVenue>());
            options.Converters.Add(new Helpers.ArrayOrObjectConverter<Saison.Models.Brewery.MediaVenue>());
            options.Converters.Add(new Helpers.ArrayOrObjectConverter<Saison.Models.Activity.BreweryDetails>());
            options.Converters.Add(new Helpers.ArrayOrObjectConverter<Saison.Models.Activity.VenueDetails>());
            return options;
        }
    }
}