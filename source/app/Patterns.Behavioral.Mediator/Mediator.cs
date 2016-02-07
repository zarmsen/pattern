namespace Patterns.Behavioral.Mediator
{
    internal abstract class Mediator
    {
        public abstract void Register(Colleague colleague);

        public abstract void Send(string message, Colleague @from, Colleague to);
    }
}