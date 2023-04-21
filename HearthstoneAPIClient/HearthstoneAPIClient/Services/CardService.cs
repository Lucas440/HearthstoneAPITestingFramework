using HearthstoneAPIClient.Interfaces;
using HearthstoneAPIClient.Services.DataHandling;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearthstoneAPIClient.Services
{
    public class CardService : IService, IHelper
    {
        public ICallManager Manager { get; private set; }
        public JArray SuccessfulResponseContent { get; private set; }
        public JObject UnSuccessfulResponseContent { get; private set; }
        public IResponse ResponseObject { get; private set; }

        public string ClassResponse { get; private set; }

        public CardService(CallManager manager)
        {
            Manager = manager;
        }

        public async Task MakeRequestAsync(string requestString)
        {
            await Manager.MakeRequestAsync(requestString);
            try
            {
                if (Manager.Successful)
                {
                    SuccessfulResponseContent = JArray.Parse(Manager.ResponseMessage.Content.ReadAsStringAsync().Result);
                }
                else
                {
                    UnSuccessfulResponseContent = JObject.Parse(Manager.ResponseMessage.Content.ReadAsStringAsync().Result);
                }
            }
            catch (Exception)
            {
                Debug.WriteLine("Something went wrong with the JSON");
            }
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

