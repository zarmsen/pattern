using System;

using Patterns.Core.Game;

namespace Patterns.Creational.AbstractFactory
{
    internal class GameController
    {
        private readonly PlayerBase _fighter;

        private readonly Random _random;

        private readonly PlayerBase _victim;

        private readonly WeaponBase _weapon;

        public GameController(IGameFactory game)
        {
            _random = new Random(10);
            _fighter = game.CreateFighter();
            _victim = game.CreateVictim();
            _weapon = game.CreateWeapon();
        }

        public void Run()
        {

            while (_fighter.Energy != 0 || _victim.Energy != 0)
            {


                if (_fighter.Energy == 0)
                {
                    Console.WriteLine("The fighter {0} is death.", _fighter);
                    return;
                }

                if (_victim.Energy == 0)
                {
                    Console.WriteLine("The fighter {0} is death.", _victim);
                    return;
                }

                var isFighterHit = _random.Next(1, 2) == 1;

                if (isFighterHit)
                {
                    var hitResult = _weapon.Hit(_victim);
                    _victim.GetHit(hitResult);
                }
                else
                {
                    var hitResult = _weapon.Hit(_fighter);
                    _fighter.GetHit(hitResult);
                }

                Console.WriteLine("The energy of fighter is {0} and the energy of victim is {1}.", _fighter.Energy, _victim.Energy);
            }
        }
    }
}