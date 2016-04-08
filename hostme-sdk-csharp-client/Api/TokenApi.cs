using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace HostMe.Sdk.Auth
{
    public class TokenApi
    {
        private Uri tokenUri;

        public TokenApi(String baseUri)
        {
            tokenUri = new Uri(new Uri(baseUri), "token");
        }

        public async Task<AccessTokenViewModel> GetAccessTokenAsync(string userName, string password)
        {
            Contract.Requires(userName != null);
            Contract.Requires(password != null);


            var httpRequest = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = tokenUri
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

            try
            {

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

            return null;
        }

    }
}
