namespace HostMe.Sdk.Auth
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using HostMe.Sdk.Client;
    public static class OAuthAuthorizationExtensions
    {
        public static async Task Authorize(this Configuration config, string userName, string password)
        {
            var url = new Uri(config.ApiClient.RestClient.BaseUrl, "token").ToString();

            var token = await GetAccessTokenAsync(url, userName, password);
            config.AccessToken = token.AccessToken;
        }

       

        static async Task<AccessTokenViewModel> GetAccessTokenAsync(String tokenUrl, string userName, string password)
        {
            Contract.Requires(userName != null);
            Contract.Requires(password != null);

            
            var httpRequest = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(tokenUrl)
            };

            var keyValues = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("username", userName),
                new KeyValuePair<string, string>("password", password),
                new KeyValuePair<string, string>("grant_type", "password")
            };

            HttpClient client = new HttpClient();
            HttpResponseMessage httpResponse;
            httpRequest.Content = new FormUrlEncodedContent(keyValues);

            try {
               
                httpResponse = await client.SendAsync(httpRequest);
                
            }
            catch
            {
                throw new UnauthorizedAccessException();
            }

            var statusCode = httpResponse.StatusCode;

            string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (statusCode == HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<AccessTokenViewModel>(responseContent);
            }
            else if(statusCode == HttpStatusCode.BadRequest)
            {
                throw new UnauthorizedAccessException();
            }

            throw new InvalidOperationException();
        }
    }
}