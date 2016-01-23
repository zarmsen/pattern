using Patterns.Core.Game;

namespace Patterns.Behavioral.Command
{
    public class GameClient
    {
        private readonly PlayingFieldInvoker _invoker;

        public GameClient()
        {
            _invoker = new PlayingFieldInvoker();
        }

        public void Move(PlayerBase player, Position position)
        {
            var move = new MoveConcreteCommand(player, position);
            _invoker.Move(move);
            _invoker.Play();
        }

        public void Undo()
        {
            _invoker.Undo();
        }
    }
}