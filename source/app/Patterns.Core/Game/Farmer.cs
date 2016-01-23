namespace Patterns.Core.Game
{
    public class Farmer : PlayerBase
    {
        public Farmer(string name, Position sartPosition)
            : base($"Farmer {name}", sartPosition) {}
    }
}