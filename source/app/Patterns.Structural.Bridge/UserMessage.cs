using System;

namespace Patterns.Structural.Bridge
{
    internal class UserMessage : MessageAbstraction
    {
        public UserMessage(IMessageImplementation implementation)
            : base(implementation) {}

        public override void Send(string message)
        {
            Console.WriteLine("User message:");
            base.Send(message);
        }
    }
}