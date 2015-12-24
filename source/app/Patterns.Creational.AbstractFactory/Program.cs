using System;

namespace Patterns.Creational.AbstractFactory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            
            var gameController = new GameController(new CounterStrikeFactory());

            gameController.Run();
       

            Console.ReadKey();

        }
    }
}