using Patterns.Core.Game;

namespace Patterns.Behavioral.Iterator
{
    internal class GameIterator : IGameIterator
    {
        private readonly GameCollection _collection;

        private readonly int _step = 1;

        private int _current;

        public GameIterator(GameCollection collection)
        {
            _collection = collection;
        }

        public PlayerBase CurrentItem => _collection[_current];

        public PlayerBase First()
        {
            _current = 0;
            return _collection[_current];
        }

        public PlayerBase Next()
        {
            _current += _step;

            var isDone = _current >= _collection.Count;
            if (!isDone)
            {
                return _collection[_current];
            }
            return null;
        }
    }
}