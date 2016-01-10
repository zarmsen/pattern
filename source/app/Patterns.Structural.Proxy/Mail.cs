using System;

namespace Patterns.Structural.Proxy
{
    internal class Mail : IMail
    {
        public void Send()
        {
            Console.WriteLine("Send Mail.");
        }
    }
}