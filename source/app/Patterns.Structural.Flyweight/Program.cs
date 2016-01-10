using System;
using System.Linq;

namespace Patterns.Structural.Flyweight
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var reader = new SimulateSoldierReader();

            var soldiers = reader.Read();
            
            Console.WriteLine("Instances in List: {0}!",soldiers.Count());
       

            Console.ReadKey();
        }
    }
}