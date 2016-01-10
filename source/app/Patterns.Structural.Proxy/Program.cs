using System;

namespace Patterns.Structural.Proxy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var proxy = new MailLogProxy();

            proxy.Send();

            Console.ReadKey();
        }
    }
}