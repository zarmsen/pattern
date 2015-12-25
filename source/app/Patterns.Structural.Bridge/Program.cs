using System;

namespace Patterns.Structural.Bridge
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            var message = new UserMessage(new Email());

            message.Send("Hello World");

            Console.ReadKey();
        }
    }
}