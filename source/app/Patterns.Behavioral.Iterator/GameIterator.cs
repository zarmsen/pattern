using Patterns.Core.Game;

namespace Patterns.Behavioral.Iterator
{
    internal class GameIterator : IGameIterator
    {
        public PlayerBase CurrentItem { get; }

        public PlayerBase First()
        {
            return null;
        }

        public PlayerBase Next()
        {
            return null;
        }
    }
}