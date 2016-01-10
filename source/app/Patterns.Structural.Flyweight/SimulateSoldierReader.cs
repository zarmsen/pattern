using System;
using System.Collections.Generic;
using System.Linq;

using Patterns.Core.Game;

namespace Patterns.Structural.Flyweight
{
    internal sealed class SimulateSoldierReader
    {
        private readonly List<Weapons> _simFile;

        public SimulateSoldierReader()
        {
            _simFile = new List<Weapons> { Weapons.Axe, Weapons.Axe, Weapons.Axe, Weapons.Gun, Weapons.Sword, Weapons.Sword, Weapons.Axe };
        }

        public IEnumerable<Soldier> Read()
        {
            var flyweight = new SoldierFlyweightFactory();

            var soldiers = _simFile.Select(rowInSimulatedFile => flyweight.GetSoldier(rowInSimulatedFile)).ToList();

            Console.WriteLine("Flyweight has {0} objects!", flyweight.CountOfObjects);

            return soldiers;
        }
    }
}