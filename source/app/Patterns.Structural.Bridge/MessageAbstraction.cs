using System;

namespace Patterns.Structural.Bridge
{
    internal class MessageAbstraction
    {
        private readonly IMessageImplementation _implementation;

        protected MessageAbstraction(IMessageImplementation implementation)
        {
            _implementation = implementation;
        }

        public virtual void Send(string message)
        {
            Console.WriteLine(message);
            _implementation.Send();
        }
    }
}