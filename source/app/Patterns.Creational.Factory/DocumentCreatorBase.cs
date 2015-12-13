using System;

using Patterns.Core.Models;

namespace Patterns.Creational.Factory
{
    internal abstract class DocumentCreatorBase
    {
        public abstract DocumentBase Create();

        public void Validate()
        {
            var document = Create();
            if (!document.IsValid())
            {
                throw new InvalidOperationException(string.Format("The number '{0}' is not valid for document '{1}'", document.Number, document));
            }

            Console.WriteLine(document.Message);
        }

        protected int GenerateDocumentNumber()
        {
            var random = new Random(10);
            return random.Next(0, 10);
        }


    }
}