using System.Configuration;

namespace HearthstoneAPITests
{
    public static class AppConfigReader
    {
        public static readonly string BaseUrl = ConfigurationManager.AppSettings["base_url"];
        public static readonly string ApiKey = ConfigurationManager.AppSettings["api_key"];
        public static readonly string ApiHost = ConfigurationManager.AppSettings["api_host"];
        public static readonly string ApiCookie = ConfigurationManager.AppSettings["api_cookie"];
    }
}
