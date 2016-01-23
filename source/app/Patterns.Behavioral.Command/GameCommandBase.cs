using Patterns.Core.Game;

namespace Patterns.Behavioral.Command
{
    internal abstract class GameCommandBase
    {
        protected GameCommandBase(PlayerBase player)
        {
            Player = player;
        }

        public PlayerBase Player { get; }

        public abstract void Execute();

        public abstract void Undo();
    }
}