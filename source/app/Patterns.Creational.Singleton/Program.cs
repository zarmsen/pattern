using System;

using Patterns.Core.Enums;

namespace Patterns.Creational.Singleton
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(ConfigurationReader.Instance.Read(ConfigKey.Hello));
            Console.WriteLine(ConfigurationReader.Instance.Read(ConfigKey.Singleton));
            Console.ReadKey();
        }
    }
}