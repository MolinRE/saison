using System;
using RestSharp;
using RestSharp.Serializers.SystemTextJson;
using Saison.Models;
using Saison.Models.Untappd;

namespace Saison
{
    public class AuthApi
    {
        /// <summary>
        /// Returns the URL which will ask user to authentificate the app upon accessing it.
        /// </summary>
        /// <param name="callback">Return URL of the app.</param>
        /// <param name="state">Optional. Parameter that can be used to prevent Cross-site Request Forgery.</param>
        /// <returns></returns>
        public string GetAuthenticationUrl(string callback, string state = null)
        {
            var result = $"https://untappd.com/oauth/authenticate/" +
                         $"?client_id={Config.ClientId}" +
                         $"&response_type=code" +
                         $"&redirect_url={callback}";

            if (!string.IsNullOrEmpty(state))
            {
                result += $"&state={state}";
            }

            return result;
        }

        /// <summary>
        /// Gets the access token after the user has authenticated and authorized the application.
        /// This token doesn't expire.
        /// </summary>
        /// <param name="callback">Return URL of the app.</param>
        /// <param name="code">The code you've received on the backend after user
        /// has authenticated and authorized the application.</param>
        /// <returns></returns>
        public ResponseContainer<AuthResponse> GetAccessToken(string callback, string code)
        {
            var client = new RestClient("https://untappd.com");
            client.UseSystemTextJson();
            var request = new RestRequest($"oauth/authorize/" +
                                          $"?client_id={Config.ClientId}" +
                                          $"&client_secret={Config.ClientSecret}" +
                                          $"&response_type=code" +
                                          $"&redirect_url={callback}" +
                                          $"&code={code}", Method.GET, DataFormat.Json);

            var response = client.Execute<ResponseContainer<AuthResponse>>(request);
            return response.Data;
        }
    }
}