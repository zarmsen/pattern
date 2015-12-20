using Patterns.Core.Game;

namespace Patterns.Creational.AbstractFactory
{
    public class CounterStrikeFactory : IGameFactory
    {
        public WeaponBase CreateWeapon()
        {
            return new Gun(10);
        }

        public PlayerBase CreateFighter()
        {
            return new Soldier("Hans");
        }

        public PlayerBase CreateVictim()
        {
            return new Soldier("Paul");
        }
    }
}