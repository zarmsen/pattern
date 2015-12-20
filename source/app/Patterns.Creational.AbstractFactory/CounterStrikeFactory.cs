using Patterns.Core.Game;

namespace Patterns.Creational.AbstractFactory
{
    public class CounterStrikeFactory : IGameFactory
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