namespace Patterns.Core.Game
{
    public class Soldier : PlayerBase
    {
        public Soldier(string name, Position sartPosition)
            : base($"Soldier {name}", sartPosition) {}
    }
}