using Patterns.Core.Game;

namespace Patterns.Structural.Decorator
{
    internal abstract class PlayerDecoratorAddOn : PlayerBase
    {
        private readonly PlayerBase _player;

        protected PlayerDecoratorAddOn(string name, PlayerBase player)
            : base(name)
        {
            _player = player;
        }

        public sealed override void GetHit(HitResult result)
        {
            _player.GetHit(result);
        }
    }
}