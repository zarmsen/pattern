using Patterns.Core.Game;

namespace Patterns.Structural.Decorator
{
    internal class PlayerWithSelfHealing : PlayerDecoratorAddOn
    {
        public PlayerWithSelfHealing(PlayerBase player)
            : base(player.Name, player) {}

        public void SelfHealing()
        {
            Player.Energy = 100;
        }
    }
}