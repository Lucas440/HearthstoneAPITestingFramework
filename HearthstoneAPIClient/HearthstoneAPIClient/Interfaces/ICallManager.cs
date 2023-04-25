using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearthstoneAPIClient.Interfaces
{
    public interface ICallManager
    {
        public HttpResponseMessage ResponseMessage { get; }
        public bool Successful { get; }
        public Task MakeRequestAsync(string requestString);
    }
}
