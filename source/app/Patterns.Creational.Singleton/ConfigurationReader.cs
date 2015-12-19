using System;

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
    }
}