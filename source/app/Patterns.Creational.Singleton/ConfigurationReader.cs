using System.Configuration;

namespace Patterns.Creational.Singleton
{
    internal sealed class ConfigurationReader
    {
        private ConfigurationReader() {}

        /// <summary>
        /// </summary>
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