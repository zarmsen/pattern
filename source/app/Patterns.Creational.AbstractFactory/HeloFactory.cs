using Patterns.Core.Game;

namespace Patterns.Creational.AbstractFactory
{
    public class HeloFactory : IGameFactory
    {
        public WeaponBase CreateWeapon()
        {
            return null;
        }

        public PlayerBase CreatePlayer()
        {
            return null;
        }
    }
}