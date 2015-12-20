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
            return new King("Arthus");
        }

        public PlayerBase CreateVictim()
        {
            return new Farmer("John");
        }
    }
}