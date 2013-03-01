using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace MvcGeolocation.Helpers
{
    public static class GlobalHelper
    {
        public static string GoogleApiKey = "googleApiKey";

        public static string GetConfigVal(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
    }
}