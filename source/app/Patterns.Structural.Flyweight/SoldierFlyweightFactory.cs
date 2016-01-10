using System.Collections.Generic;

using Patterns.Core.Game;

namespace Patterns.Structural.Flyweight
{
    internal class SoldierFlyweightFactory
    {

        private Dictionary<Weapons, Soldier> _cache = new Dictionary<Weapons, Soldier>();

        public int CountOfObjects => _cache.Count;

        public Soldier GetSoldier(Weapons weapon)
        {
            var isAvailable = _cache.ContainsKey(weapon);
            if (isAvailable)
            {
                return _cache[weapon];
            }

            var soldier = new Soldier("Soldier");
            soldier.SetWeapon(weapon);
            _cache.Add(weapon, soldier);
            return soldier;
        }
    }
}