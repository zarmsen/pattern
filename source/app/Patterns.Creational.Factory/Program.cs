using System;

namespace Patterns.Creational.Factory
{
    internal class Program
    {
        private static void Main(string[] args) {}
    }

    internal abstract class DocumentCreator
    {
        public abstract DocumentCreator Create();

        public void Validate()
        {
            var document = Create();
            if (IsNotValid(document))
            {
                throw new InvalidOperationException("There is not a valid document found.");
            }
        }

        private bool IsNotValid(DocumentCreator document)
        {
            return document == null;
        }
    }
}