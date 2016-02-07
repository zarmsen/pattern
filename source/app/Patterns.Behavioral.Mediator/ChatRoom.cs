using System.Collections.Generic;

namespace Patterns.Behavioral.Mediator
{
    internal class ChatRoom : Mediator
    {
        private readonly Dictionary<string, Colleague> _participants = new Dictionary<string, Colleague>();

        public override void Register(Colleague colleague)
        {
            if (!_participants.ContainsKey(colleague.Name))
            {
                _participants[colleague.Name] = colleague;
            }

            colleague.ChatRoom = this;
        }

        public override void Send(string message, Colleague @from, Colleague to)
        {
            Colleague participant = _participants[to.Name];

            participant?.Receive(from, message);
        }
    }
}