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

        int Id { get; }

        string Caption { get; }

        public void Output()
        {
            Console.WriteLine("{0} - {1}",Id, Caption);
        }
    }
}