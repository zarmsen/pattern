using Patterns.Core.Game;

namespace Patterns.Behavioral.Iterator
{
    internal interface IGameIterator
    {
        PlayerBase CurrentItem { get; }

        PlayerBase First();

        PlayerBase Next();
    }
}