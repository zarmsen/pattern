namespace Patterns.Core.Game
{
    public class Gun : WeaponBase
    {
        public Gun()
            : this(50) {}

        public Gun(int effect)
            : base("Gun", effect) {}
    }
}