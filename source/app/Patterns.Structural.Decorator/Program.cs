﻿using System;

using Patterns.Core.Game;

namespace Patterns.Structural.Decorator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var godPlayer = new PlayerWithSelfHealing(new King("Arthur"));

            Status(godPlayer);

            godPlayer.GetHit(new HitResult(new Farmer("Farmer"), new Axe(3)));

            Status(godPlayer);

            Console.WriteLine("Do self healing!!!");
            godPlayer.SelfHealing();

            Status(godPlayer);

            Console.ReadKey();
        }

        private static void Status(PlayerWithSelfHealing godPlayer)
        {
            Console.WriteLine(godPlayer.ToString());
        }
    }
}