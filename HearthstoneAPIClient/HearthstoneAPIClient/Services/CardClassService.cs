using HearthstoneAPIClient.Interfaces;
using HearthstoneAPIClient.Services.DataHandling;
using HearthstoneAPIClient.Services.DataHandling.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace HearthstoneAPIClient.Services
{
    public class CardClassService : IService, IHelper
    {
        public ICallManager Manager { get; private set; }
        public JArray SuccessfulResponseContent { get; private set; }
        public JObject UnSuccessfulResponseContent { get; private set; }
        public IResponse ResponseObject { get; private set; }

        public string ClassResponse { get; private set; }

        //public CardClassService(CallManager manager) 
        //{
        //    Manager = manager;
        //}

        public CardClassService(ICallManager manager)
        {
            Manager = manager;
        }

        public async Task MakeRequestAsync(string requestString)
        {
            await Manager.MakeRequestAsync(requestString);
            if (Manager.Successful)
            {
                SuccessfulResponseContent = JArray.Parse(Manager.ResponseMessage.Content.ReadAsStringAsync().Result);
            }
            else
            {
                UnSuccessfulResponseContent = JObject.Parse(Manager.ResponseMessage.Content.ReadAsStringAsync().Result);
            }
        }

        public int GetStatusCode()
        {
            return Manager.GetStatusCode();
        }

        public string GetContentType()
        {
            return Manager.GetContentType();
        }
        public string GetConnectionType()
        {
            return Manager.GetConnectionType();
        }
    }
}
