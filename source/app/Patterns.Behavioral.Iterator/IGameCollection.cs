namespace Patterns.Behavioral.Iterator
{
    internal interface IGameCollection
    {
        IGameIterator CreateIterator();
    }
}