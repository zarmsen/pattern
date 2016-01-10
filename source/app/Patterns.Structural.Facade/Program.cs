using System;

namespace Patterns.Structural.Facade
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var system = new OurSystemFacade();

            system.Read(1);
            system.Read(2);

            Console.ReadKey();
        }
    }
}