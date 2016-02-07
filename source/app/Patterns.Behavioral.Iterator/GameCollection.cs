using System.Collections;

namespace Patterns.Behavioral.Iterator
{
    internal class GameCollection : IGameCollection
    {
        private readonly ArrayList _items = new ArrayList();

        public int Count => _items.Count;

        public object this[int index] { get { return _items[index]; } set { _items.Add(index); } }

        public IGameIterator CreateIterator()
        {
            return new GameIterator(this);
        }
    }
}