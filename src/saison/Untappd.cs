using Saison.Api;

namespace Saison;

/// <summary>
/// Main class for using Untappd API.ф
/// </summary>
public class Untappd
{
    /// <summary>
    /// Authentication methods. Authentication is handled via OAuth 2.0, so you must setup your own server to authenticate a user.
    /// </summary>
    public AuthApi Auth { get; set; }

    /// <summary>
    /// Beer methods
    /// </summary>
    public BeerApi Beer { get; set; }

    /// <summary>
    /// Brewery methods
    /// </summary>
    public BreweryApi Brewery { get; set; }

    /// <summary>
    /// Venue methods
    /// </summary>
    public VenueApi Venue { get; set; }

    /// <summary>
    /// Activity feed methods
    /// </summary>
    public FeedApi Feed { get; set; }

    /// <summary>
    /// User methods
    /// </summary>
    public UserApi User { get; set; }

    /// <summary>
    /// Creates new instance of Untappd API wrapper.
    /// </summary>
    /// <param name="clientId">Public API key.</param>
    /// <param name="clientSecret">Secret API key.</param>
    public Untappd(string clientId, string clientSecret)
    {
        Config.ClientId = clientId;
        Config.ClientSecret = clientSecret;

        Beer = new();
        Venue = new();
        Feed = new();
        Brewery = new();
        Auth = new();
        User = new();
    }
}