using HearthstoneAPIClient.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearthstoneAPIClient.Services.DataHandling
{
    public class CallManager : IHelper
    {
        private readonly HttpClient _client = new HttpClient();

        public HttpResponseMessage ResponseMessage { get; private set; }

        public bool Successful { get; private set; }

        public CallManager() { }

        public CallManager(HttpClient client) 
        {
            _client = client;
        }

        public virtual async Task MakeRequestAsync(string requestString)
        {

            HttpRequestMessage request = new HttpRequestMessage();

            request.RequestUri = new Uri(AppConfigReader.BaseUrl + requestString);

            request.Headers.Add("X-RapidAPI-Key", AppConfigReader.ApiKey);
            request.Headers.Add("X-RapidAPI-Host", AppConfigReader.ApiHost);
            request.Headers.Add("Cookie", AppConfigReader.ApiCookie);

            request.Headers.Add("Accept", "application/json");

            ResponseMessage = _client.SendAsync(request).Result;

            if ((int)ResponseMessage.StatusCode != 404) 
            {
                Successful = true;
            }
            else
            {
                Successful = false;
            }
        }

        public virtual int GetStatusCode()
        {
            return (int)ResponseMessage.StatusCode;
        }

        public virtual string GetContentType()
        {
            return ResponseMessage.Content.Headers.ContentType.MediaType;
        }
        public virtual string GetConnectionType()
        {
            return ResponseMessage.Headers.Connection.ToString();
        }
    }
}
