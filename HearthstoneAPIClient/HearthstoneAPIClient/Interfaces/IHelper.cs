using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearthstoneAPIClient.Interfaces
{
    public interface IHelper
    {
        public int GetStatusCode();
        public string GetContentType();
        public string GetConnectionType();
    }
}
