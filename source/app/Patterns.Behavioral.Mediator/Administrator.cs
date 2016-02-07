using System;

namespace Patterns.Behavioral.Mediator
{
    internal class Administrator : Colleague
    {
        public Administrator(string name)
            : base($"Admin:{name}") {}

        public override void Receive(Colleague @from, string message)
        {
            Console.WriteLine("{0} says to {1}: '{2}'", @from, Name, message);
        }
    }
}