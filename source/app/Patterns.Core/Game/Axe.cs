namespace Patterns.Core.Game
{
    public class Axe : WeaponBase
    {
        public Axe()
            : this(10) {}

        public Axe(int effect)
            : base("Axe", effect) {}
    }
}