using Patterns.Core.Game;

namespace Patterns.Structural.Decorator
{
    internal abstract class PlayerDecoratorAddOn : PlayerBase
    {
        protected readonly PlayerBase Player;

        protected PlayerDecoratorAddOn(string name, PlayerBase player)
            : base(name, new Position(2, 4))
        {
            Player = player;
        }

        public sealed override void GetHit(HitResult result)
        {
            Player.GetHit(result);
            Energy = Player.Energy;
        }
    }
}