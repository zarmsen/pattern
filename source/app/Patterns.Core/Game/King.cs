namespace Patterns.Core.Game
{
    public class King : PlayerBase
    {
        public King(string name, Position sartPosition)
            : base($"King {name}", sartPosition) {}
    }
}