using System.Text;
using System.Threading.Tasks;
using System.Web;
using Saison.Models.Brewery;
using Saison.Models.Untappd;

namespace Saison;

public class BreweryApi
{
    private readonly ServiceClientAsync _serviceClient;

    public BreweryApi()
    {
        _serviceClient = new ServiceClientAsync();
    }

    /// <summary>
    /// This will allow you to search exclusively for breweries in the Untappd system.
    /// </summary>
    /// <param name="q">The search term that you want to search.</param>
    /// <param name="offset">The numeric offset that you what results to start</param>
    /// <param name="limit">The number of results to return, max of 50, default is 25</param>
    /// <param name="accessToken"></param>
    /// <returns></returns>
    public async Task<ResponseContainer<SearchResponse>> Search(string q, int? offset = null, int limit = 25, string? accessToken = null)
    {
        var builder = new StringBuilder();
        builder.Append($"search/brewery?q={HttpUtility.UrlEncode(q)}&limit={limit}");
        if (offset.HasValue)
        {
            builder.Append($"&offset={offset}");   
        }
        if (accessToken != null)
        {
            builder.Append($"&accessToken={accessToken}");   
        }
            
        return await _serviceClient.ExecuteGetAsync<ResponseContainer<Models.Brewery.SearchResponse>>(builder.ToString());
    }

    /// <summary>
    /// This method will allow you to see extended information about a brewery.
    /// </summary>
    /// <param name="breweryId">The Brewery ID that you want to display checkins</param>
    /// <param name="accessToken"></param>
    /// <returns></returns>
    public async Task<ResponseContainer<BreweryInfoContainer>> InfoAsync(int breweryId, string? accessToken = null)
    {
        var builder = new StringBuilder();
        // question mark at the end to safely add tokens later (see CreateUri())
        builder.Append($"brewery/info/{breweryId}?");

        if (accessToken != null)
        {
            builder.Append($"&access_token={accessToken}");
        }

        return await _serviceClient.ExecuteGetAsync<ResponseContainer<BreweryInfoContainer>>(builder.ToString());
    }
        
    /// <summary>
    /// This method allows you the obtain an activity feed for a single brewery for Untappd. By default it will return at max 25 records. 
    /// </summary>
    /// <param name="breweryId">The Brewery ID that you want to display checkins</param>
    /// <param name="maxId">The checkin ID that you want the results to start with</param>
    /// <param name="minId">Returns only checkins that are newer than this value</param>
    /// <param name="limit">The number of results to return, max of 25, default is 25</param>
    /// <param name="accessToken"></param>
    /// <returns></returns>
    public async Task<ResponseContainer<BreweryActivity>> Checkins(int breweryId, int? maxId = null, int? minId = null, int limit = 25, string? accessToken = null)
    {
        var builder = new StringBuilder();
        builder.Append($"brewery/checkins/{breweryId}?limit={limit}");
        if (maxId.HasValue)
        {
            builder.Append($"&max_id={maxId}");
        }

        if (minId.HasValue)
        {
            builder.Append($"&min_id={minId}");
        }

        if (accessToken != null)
        {
            builder.Append($"&access_token={accessToken}");
        }

        return await _serviceClient.ExecuteGetAsync<ResponseContainer<BreweryActivity>>(builder.ToString());
    }
}