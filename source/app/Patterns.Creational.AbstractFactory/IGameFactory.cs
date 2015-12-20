using Patterns.Core.Game;

namespace Patterns.Creational.AbstractFactory
{
    public interface IGameFactory
    {
        WeaponBase CreateWeapon();

        PlayerBase CreatePlayer();
    }
}