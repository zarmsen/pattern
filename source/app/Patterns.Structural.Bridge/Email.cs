using System;

namespace Patterns.Structural.Bridge
{
    internal class Email : IMessageImplementation
    {
        public void Send()
        {
            Console.WriteLine("Send per Email.");
        }
    }
}