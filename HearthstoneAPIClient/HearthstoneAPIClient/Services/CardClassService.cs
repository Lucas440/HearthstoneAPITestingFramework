using HearthstoneAPIClient.Interfaces;
using HearthstoneAPIClient.Services.DataHandling;
using HearthstoneAPIClient.Services.DataHandling.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HearthstoneAPIClient.Services
{
    public class CardClassService : IService
    {
        public CallManager Manager { get; private set; }
        public JArray ResponseContent { get; private set; }
        public IResponse ResponseObject { get; private set; }

        public string ClassResponse { get; private set; }

        public CardClassService(CallManager manager) 
        {
            Manager = manager;
        }

        public async Task MakeRequestAsync(string requestString)
        {
            await Manager.MakeRequestAsync(requestString);
            ResponseContent = JArray.Parse(Manager.ResponseMessage.Content.ReadAsStringAsync().Result);
        }

        public int GetStatusCode()
        {
            return (int)Manager.ResponseMessage.StatusCode;
        }

        public string GetContentType()
        {
            return Manager.ResponseMessage.Content.Headers.ContentType.MediaType;
        }
        public string GetConnectionType()
        {
            return Manager.ResponseMessage.Headers.Connection.ToString();
        }
    }
}
