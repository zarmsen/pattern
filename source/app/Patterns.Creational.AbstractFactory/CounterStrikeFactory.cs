using Patterns.Core.Game;

namespace Patterns.Creational.AbstractFactory
{
    internal class CounterStrikeFactory : IGameFactory
    {
        public WeaponBase CreateWeapon()
        {
            return new Gun(10);
        }

        public PlayerBase CreateFighter()
        {
            return new Soldier("Hans", new Position(2, 4));
        }

        public PlayerBase CreateVictim()
        {
            return new Soldier("Paul", new Position(3, 4));
        }
    }
}