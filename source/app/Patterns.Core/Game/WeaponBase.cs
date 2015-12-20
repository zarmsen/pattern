namespace Patterns.Core.Game
{
    public abstract class WeaponBase
    {
        public string Name { get;  private set; }

        public int Effect { get; private set; }

        public WeaponBase(string name, int effect)
        {
            Name = name;
            Effect = effect;
        }
    }
}