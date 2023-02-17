using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace MTMConnect.SDK.HttpUtility
{
    public class HttpUtility
    {
        public HttpResponseMessage GetHttpResponse(string baseUrl, string bearerToken, string queryString)
        {
            HttpResponseMessage response;
            HttpClient client = new HttpClient();
            client = CreateMTMApiClient(bearerToken);
            return client.GetAsync(baseUrl + queryString).Result;
        }
        public HttpClient CreateMTMApiClient(string authToken)
        {
            HttpClient mtmClient = new HttpClient();
            mtmClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("*/*"));
            mtmClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authToken);
            return mtmClient;
        }

        public string PostHttpRequest<Response>(string body, string url, string bearerToken, string inputType)
        {
            HttpResponseMessage response;
            var httpContent = new StringContent(body, Encoding.UTF8, inputType);
            httpContent.Headers.ContentType.CharSet = string.Empty;
            HttpClient client = new HttpClient();
            if (bearerToken != null)
            {
                client = CreateMTMApiClient(bearerToken);
            }
            response = client.PostAsync(url, httpContent).Result;
            response.EnsureSuccessStatusCode();
            var responseContent = response.Content.ReadAsStringAsync().Result;
            return responseContent;
        }
        public string DeleteHttpRequest<Response>(string baseUrl, string bearerToken, string queryString)
        {
            HttpResponseMessage response;
            HttpClient client = new HttpClient();
            client = CreateMTMApiClient(bearerToken);
            response = client.DeleteAsync(baseUrl + queryString).Result;
            response.EnsureSuccessStatusCode();
            var responseContent = response.Content.ReadAsStringAsync().Result;
            return responseContent;
        }
    }
}
