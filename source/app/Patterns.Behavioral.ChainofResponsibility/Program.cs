using System;

namespace Patterns.Behavioral.ChainofResponsibility
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var game = new Game();
            game.Execute("stop");
            game.Execute("run");
            game.Execute("end");

            Console.ReadKey();
        }
    }
}