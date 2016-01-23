using System;

using Patterns.Core.Game;

namespace Patterns.Behavioral.Command
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var player1 = new King("Karl", new Position(1, 1));
            var player2 = new Farmer("Bernd", new Position(1, 2));

            var game = new GameClient();

            game.Move(player2, new Position(2,1));
            game.Move(player2, new Position(3,1));
            game.Move(player1, new Position(1,2));
            game.Undo();
            game.Move(player1, new Position(2,1));

            Console.ReadKey();
        }
    }
}