using System;
using System.Configuration;

namespace Patterns.Creational.Singleton
{
    internal sealed class ConfigurationReader
    {
        /// <summary>
        /// </summary>
        private readonly Lazy<ConfigurationReader>  _instance = new Lazy<ConfigurationReader>();

        private ConfigurationReader()
        {  
        }

        public ConfigurationReader Instance => _instance.Value;

        public string Read(ConfigKey key)
        {
            return ConfigurationManager.AppSettings[key.ToString()];
        }
    }
}