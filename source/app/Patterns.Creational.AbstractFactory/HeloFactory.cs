using Patterns.Core.Game;

namespace Patterns.Creational.AbstractFactory
{
    internal class HeloFactory : IGameFactory
    {
        public WeaponBase CreateWeapon()
        {
            return new Axe(1);
        }

        public PlayerBase CreateFighter()
        {
            return new King("Arthus", new Position(2, 4));
        }

        public PlayerBase CreateVictim()
        {
            return new Farmer("John", new Position(3, 4));
        }
    }
}