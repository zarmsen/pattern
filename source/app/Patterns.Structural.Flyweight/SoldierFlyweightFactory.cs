using System;
using System.Collections.Generic;

using Patterns.Core.Game;

namespace Patterns.Structural.Flyweight
{
    internal class SoldierFlyweightFactory
    {

        private readonly Dictionary<Weapons, Soldier> _cache = new Dictionary<Weapons, Soldier>();

        public int CountOfObjects => _cache.Count;

        public Soldier GetSoldier(Weapons weapon)
        {
            var isAvailable = _cache.ContainsKey(weapon);
            if (isAvailable)
            {

                Console.WriteLine("Read Cache!");
                return _cache[weapon];
            }

            Console.WriteLine("Create Soldier with weapon '{0}'", weapon);

            var soldier = new Soldier("Soldier", new Position(2, 4));
            soldier.SetWeapon(weapon);
            _cache.Add(weapon, soldier);
            return soldier;
        }
    }
}