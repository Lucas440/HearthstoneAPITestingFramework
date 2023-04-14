using HearthstoneAPIClient.Services.DataHandling;
using Newtonsoft.Json.Linq;

namespace HearthstoneAPIClient.Interfaces
{
    public interface IService
    {
        #region Properties
        public CallManager Manager { get; }

        public JArray ResponseContent { get; }

        public IResponse ResponseObject { get; }
        #endregion

        public Task MakeRequestAsync(string requestString);
    }
}
