using System;

namespace Patterns.Structural.Composite
{
    internal class TreeNodeComposite
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Object"/> class.
        /// </summary>
        public TreeNodeComposite(int id, string caption)
        {
            Id = id;
            Caption = caption;
        }

        int Id { get; }

        string Caption { get; }

        public void Output()
        {
            Console.WriteLine("{0} - {1}",Id, Caption);
        }
    }
}