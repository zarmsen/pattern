using System.Collections.Generic;
using System.Linq;

namespace Patterns.Behavioral.Command
{
    internal class PlayingFieldInvoker
    {
        private readonly Queue<GameCommandBase> _moves;

        private readonly Stack<GameCommandBase> _undos;

        public PlayingFieldInvoker()
        {
            _moves = new Queue<GameCommandBase>();
            _undos = new Stack<GameCommandBase>();
        }

        public void Move(GameCommandBase move)
        {
            _moves.Enqueue(move);
        }

        public void Play()
        {
            while (_moves.Any())
            {
                var move = _moves.Dequeue();
                move.Execute();
                _undos.Push(move);
            }
        }

        public void Undo()
        {
            if (_undos.Any())
            {
                var move = _undos.Pop();
                move.Undo();
            }
        }
    }
}