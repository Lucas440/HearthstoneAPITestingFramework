using HearthstoneAPIClient.Services.DataHandling;
using Newtonsoft.Json.Linq;

namespace HearthstoneAPIClient.Interfaces
{
    public interface IService
    {
        #region Properties
        public CallManager Manager { get; }

        public JArray SuccessfulResponseContent { get; }

        public JObject UnSuccessfulResponseContent { get; }

        public IResponse ResponseObject { get; }
        #endregion

        public Task MakeRequestAsync(string requestString);
    }
}
