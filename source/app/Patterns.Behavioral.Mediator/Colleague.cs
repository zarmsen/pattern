using System;

using Patterns.Core.Game;

namespace Patterns.Behavioral.Mediator
{
    internal abstract class Colleague : PlayerBase
    {
        protected Colleague(string name)
            : base(name, new Position(1, 1)) {}

        public Mediator ChatRoom { get; set; }

        public void Send(string message, Colleague colleague)
        {
            ChatRoom?.Send(message, colleague);
        }

        public virtual void Receive(Colleague from, string message)
        {
            Console.WriteLine("{0} to {1}: '{2}'", from, Name, message);
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}