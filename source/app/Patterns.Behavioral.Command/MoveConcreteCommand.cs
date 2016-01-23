using System;

using Patterns.Core.Game;

namespace Patterns.Behavioral.Command
{
    internal class MoveConcreteCommand : GameCommandBase
    {
        private readonly Position _position;

        private Position _oldPosition;

        public MoveConcreteCommand(PlayerBase player, Position position)
            : base(player)
        {
            _position = position;
        }

        public override void Execute()
        {
            _oldPosition = Player.CurrentPosition;
            Player.Move(_position);
            Console.WriteLine("MOVE: Player {1} from position '{2}' to position '{0}'", _position, Player.Name, _oldPosition);
        }

        public override void Undo()
        {
            if (_oldPosition != null)
            {
                Player.Move(_oldPosition);
                Console.WriteLine("UNDO: Player {1} from old position '{2}' to new position '{0}'", _oldPosition, Player.Name, _position);
            }
        }
    }
}