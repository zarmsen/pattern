using Patterns.Core.Game;

namespace Patterns.Creational.AbstractFactory
{
    internal interface IGameFactory
    {
        WeaponBase CreateWeapon();

        PlayerBase CreateFighter();

        PlayerBase CreateVictim();
    }
}