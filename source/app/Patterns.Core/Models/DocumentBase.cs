namespace Patterns.Core.Models
{
    public abstract class DocumentBase
    {
        public int Number { get; private set; }

        public DocumentBase(int number)
        {
            Number = number;
           
        }
    }
}