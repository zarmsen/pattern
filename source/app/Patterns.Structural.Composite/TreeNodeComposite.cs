using System;

namespace Patterns.Structural.Composite
{
    internal abstract class TreeNodeComposite
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Object"/> class.
        /// </summary>
        protected TreeNodeComposite(int id, string caption)
        {
            Id = id;
            Caption = caption;
        }

        public abstract bool HasChildren();

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        /// A string that represents the current object.
        /// </returns>
        public override string ToString()
        {
            return $"{Id} - {Caption}";
        }

        int Id { get; }

        string Caption { get; }

        public void Output()
        {
            Console.WriteLine(ToString());
        }
    }
}