using HearthstoneAPIClient.Interfaces;
using HearthstoneAPIClient.Services.DataHandling;
using Newtonsoft.Json.Linq;

namespace HearthstoneAPIClient.Services
{
    public class CardRaceService : IService
    {
        public CallManager Manager { get; private set; }
        public JObject ResponseContent { get; private set; }
        public IResponse ResponseObject { get; private set; }

        public CardRaceService(CallManager manager) 
        {
            Manager = manager;
        }

        public async Task MakeRequestAsync(string requestString)
        {
            throw new NotImplementedException();
        }
    }
}
