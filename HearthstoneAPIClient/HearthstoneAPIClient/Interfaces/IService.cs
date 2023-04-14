using HearthstoneAPIClient.Services.DataHandling;
using Newtonsoft.Json.Linq;

namespace HearthstoneAPIClient.Interfaces
{
    public interface IService
    {
        #region Properties
        public CallManager Manager { get; set; }

        public JObject ResponseContent { get; set; }

        public IResponse ResponseObject { get; set; }
        #endregion

        public Task MakeRequestAsync(string requestString);
    }
}
