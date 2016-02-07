using Patterns.Core.Game;

namespace Patterns.Behavioral.Mediator
{
    internal abstract class Mediator
    {
        public abstract void Register(Colleague colleague);

        public abstract void Send(string message, Colleague colleague);
    }


    internal abstract class Colleague : PlayerBase
    {
        private Colleague(string name, Position sartPosition)
            : base(name, sartPosition)
        {
        }
    }
}