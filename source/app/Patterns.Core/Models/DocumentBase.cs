namespace Patterns.Core.Models
{
    public abstract class DocumentBase
    {
        public DocumentBase(int number)
        {
            Number = number;
        }

        public virtual bool IsValid()
        {
            return Number > 0;
        }


        public int Number { get; }

        public string Message { get { return string.Format("Found document '{0}' with number {1}", ToString(), Number); } }
    }
}