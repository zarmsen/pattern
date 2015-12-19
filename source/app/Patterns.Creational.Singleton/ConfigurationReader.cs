using System.Configuration;

using Patterns.Core.Enums;

namespace Patterns.Creational.Singleton
{
    internal sealed class ConfigurationReader
    {
        private ConfigurationReader() {}

        private static ConfigurationReader _instance;

        private static readonly object lockObject = new object();

        public static ConfigurationReader Instance
        {
            get
            {
                lock(lockObject)
                {
                    return _instance ?? (_instance = new ConfigurationReader());
                }
            }
        }

        public string Read(ConfigKey key)
        {
            return ConfigurationManager.AppSettings[key.ToString()];
        }
    }
}