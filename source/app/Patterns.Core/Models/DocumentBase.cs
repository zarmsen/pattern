namespace Patterns.Core.Models
{
    public abstract class DocumentBase
    {
        public string Name { get; private set; }

        public DocumentBase(string name)
        {
            Name = name;
        }
    }
}