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
            if (IsValid(document) == false)
            {
                throw new InvalidOperationException("There is not a valid document found.");
            }
        }

        protected int GenerateDocumentNumber()
        {
            var random = new Random();
            return random.Next(0, 10);
        }

        public virtual bool IsValid(DocumentBase document)
        {
            return document.Number == 0 || document.Number > 0;
        }
    }
}