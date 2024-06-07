using System;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Saison.Models.Untappd;
using System.Linq;

namespace Saison;

internal class ServiceClientAsync
{
    private static readonly HttpClient Client = new()
    {
        BaseAddress = new(Host)
    };

    private const string Host = "https://api.untappd.com/v4/";

    public ServiceClientAsync()
    {
        Client.DefaultRequestHeaders.UserAgent.ParseAdd($"Saison/0.3 ({Config.ClientId})");
    }

    internal async Task<T> ExecuteGetAsync<T>(string url)
        where T : ResponseContainerBase, new()
    {
        using var request = new HttpRequestMessage();
        request.Method = HttpMethod.Get;
        request.RequestUri = CreateUri(url);
        request.Headers.Add("Connection", "keep-alive");

        using var response = await Client.SendAsync(request);

        T result;

        if (response.StatusCode == HttpStatusCode.OK)
        {
            result = await ReadContentAsync<T>(response.Content);
        }
        else
        {
            var basicResponse = await ReadContentAsync<ResponseContainer>(response.Content);
            result = new() { Meta = basicResponse.Meta };
        }

        foreach (var header in response.Headers)
        {
            switch (header.Key.ToLower())
            {
                case "x-ratelimit-limit":
                    result.XRateLimit = int.Parse(header.Value.First());
                    break;
                case "x-ratelimit-remaining":
                    result.XRateLimitRemaining = int.Parse(header.Value.First());
                    break;
                case "x-auth-type":
                    result.XAuthType = header.Value.First();
                    break;
                case "x-ratelimit-expired":
                    result.XRateLimitExpired = DateTime.Parse(header.Value.First());
                    break;
            }
        }

        return result;
    }

    private static Uri CreateUri(string url)
    {
        if (url.Contains("access_token"))
        {
            return new(url, UriKind.Relative);
        }

        return new(url + $"&client_id={Config.ClientId}&client_secret={Config.ClientSecret}",
            UriKind.RelativeOrAbsolute);
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
        options.Converters.Add(new Helpers.ArrayOrObjectConverter<Models.Feeds.Activity.Venue>());
        options.Converters.Add(new Helpers.ArrayOrObjectConverter<Models.AuthResponse>());
        return options;
    }
}