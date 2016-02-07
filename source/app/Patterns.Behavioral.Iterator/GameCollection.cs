using System.Collections.Generic;

using Patterns.Core.Game;

namespace Patterns.Behavioral.Iterator
{
    internal sealed class GameCollection : IGameCollection
    {
        private readonly Dictionary<int, PlayerBase> _items = new Dictionary<int, PlayerBase>();

        public int Count => _items.Count;

        public PlayerBase this[int index] { get { return _items[index]; } set { _items[index] = value; } }

        public IGameIterator CreateIterator()
        {
            return new GameIterator(this);
        }
    }
}