using System;

namespace Patterns.Structural.Adapter
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            ILoggerAdapter logger = new MyLogger();

            logger.Error("Hello World!");
            Console.ReadKey();
        }
    }
}