using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearthstoneAPIClient.Services.DataHandling
{
    public class CallManager
    {
        private readonly HttpClient _client;

        public HttpResponseMessage ResponseMessage { get; private set; }

        public CallManager(HttpClient client) 
        {
            _client = client;
        }

        public async Task MakeRequestAsync(string requestString) 
        {
            using (_client) 
            {
                HttpRequestMessage request = new HttpRequestMessage();

                request.RequestUri = new Uri(AppConfigReader.BaseUrl + requestString);

                request.Headers.Add("X-RapidAPI-Key", AppConfigReader.ApiKey);
                request.Headers.Add("X-RapidAPI-Host", AppConfigReader.ApiHost);
                request.Headers.Add("Cookie", AppConfigReader.ApiCookie);

                ResponseMessage = await _client.SendAsync(request);
            }
        }
    }
}
