namespace Patterns.Core.Models
{
    public abstract class DocumentBase
    {
        protected DocumentBase(int number)
        {
            Number = number;
        }

        public int Number { get; }

        public string Message { get { return string.Format("Found document '{0}' with number {1}", ToString(), Number); } }

        public virtual bool IsValid()
        {
            return Number > 0;
        }

        /// <summary>
        ///     Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        ///     A string that represents the current object.
        /// </returns>
        public override string ToString()
        {
            return GetType().Name;
        }
    }
}