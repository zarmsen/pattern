namespace Patterns.Core.Game
{
    public class PlayerBase
    {
        public string Name { get; private set; }

        public PlayerBase(string name)
        {
            Energy = 100;
            Name = name;
        }

        public int Energy { get; set; }
    }
}