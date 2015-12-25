using System;

namespace Patterns.Structural.Bridge
{
    internal class WebService : IMessageImplementation
    {
        public void Send()
        {
            Console.WriteLine("Send per WebService.");
        }
    }
}