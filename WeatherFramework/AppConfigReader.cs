using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkCreation
{
    class AppConfigReader
    {
        public static readonly string BaseUrl = ConfigurationManager.AppSettings["base_url"];
        public static readonly string ApiKey = ConfigurationManager.AppSettings["api_key"];
        public static readonly string Location = ConfigurationManager.AppSettings["location"];
        public static readonly string ApiUrlMod = ConfigurationManager.AppSettings["access_key_url_mod"];
    }
}

