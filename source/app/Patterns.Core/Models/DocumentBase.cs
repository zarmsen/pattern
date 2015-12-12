namespace Patterns.Core.Models
{
    public abstract class DocumentBase
    {
        public int Number { get; private set; }

        public string Name { get; private set; }

        public DocumentBase(int number, string name)
        {
            Number = number;
            Name = name;
        }
    }
}