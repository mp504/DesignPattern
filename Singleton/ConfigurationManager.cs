using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class ConfigurationManager
    {
        private static ConfigurationManager _instance;
        private static readonly object _instanceLock = new object();
        private static Dictionary<string, string> _config;

        private ConfigurationManager() 
        {
            _config =  new Dictionary<string, string>
            {
                { "DatabaseURL", "----------------------------" },
                { "APIKey", "123456" }

            };


        }

        public static ConfigurationManager Instance
        {
            get
            {
                lock (_instanceLock)
                {
                    if (_instance == null)
                    {
                        _instance = new ConfigurationManager();

                    }
                    return _instance;
                }
            }
        }

        public string Get (string key)
        {
            _config.TryGetValue(key, out var val);
            return val;
        }


    }
}
