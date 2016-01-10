using Patterns.Core.Game;

namespace Patterns.Structural.Decorator
{
    internal class PlayerWithSelfHealing : PlayerDecoratorAddOn
    {
        public PlayerWithSelfHealing(string name, PlayerBase player)
            : base(name, player) {}

        public void SelfHealing()
        {
            Player.Energy = 100;
        }
    }
}