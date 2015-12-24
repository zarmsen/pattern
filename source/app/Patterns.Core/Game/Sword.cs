namespace Patterns.Core.Game
{
    public class Sword : WeaponBase
    {
        public Sword()
            : this(20) {}

        public Sword(int effect)
            : base("Sword", effect) {}
    }
}