namespace Patterns.Core.Models
{
    public abstract class DocumentBase
    {
        public DocumentBase(int number)
        {
            Number = number;
        }

        public int Number { get; }

        public string Message { get { return string.Format("Found document '{0}' with number {1}", ToString(), Number); } }
    }
}