using System.Text;
using System.Threading.Tasks;
using Saison.Models;
using Saison.Models.Untappd;

namespace Saison
{
    public class AuthApi
    {
        private readonly ServiceClientAsync _client;

        public AuthApi()
        {
            _client = new ServiceClientAsync();
        }
        
        /// <summary>
        /// Returns the URL which will ask user to authentificate the app upon accessing it.
        /// </summary>
        /// <param name="callback">Return URL of the app.</param>
        /// <param name="state">Optional. Parameter that can be used to prevent Cross-site Request Forgery.</param>
        /// <returns></returns>
        public string GetAuthenticationUrl(string callback, string? state = null)
        {
            return $"https://untappd.com/oauth/authenticate/?response_type=code" +
                   $"&client_id={Config.ClientId}" +
                   $"&redirect_url={callback}" +
                   (string.IsNullOrEmpty(state) ? string.Empty : $"&state={state}");
        }

        /// <summary>
        /// Gets the access token after the user has authenticated and authorized the application.
        /// This token doesn't expire.
        /// </summary>
        /// <param name="callback">Return URL of the app.</param>
        /// <param name="code">The code you've received on the backend after user
        /// has authenticated and authorized the application.</param>
        /// <returns></returns>
        public async Task<ResponseContainer<AuthResponse>> GetAccessToken(string callback, string code)
        {
            var url = $"https://untappd.com/oauth/authorize/?response_type=code" +
                      $"&client_id={Config.ClientId}" +
                      $"&client_secret={Config.ClientSecret}" +
                      $"&redirect_url={callback}" +
                      $"&code={code}";

            return await _client.ExecuteGetAsync<ResponseContainer<AuthResponse>>(url);
        }
    }
}