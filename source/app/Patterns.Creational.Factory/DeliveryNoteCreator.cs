using Patterns.Core.Models;

namespace Patterns.Creational.Factory
{
    internal class DeliveryNoteCreator : DocumentCreatorBase
    {
        public override DocumentBase Create()
        {
            return new DeliveryNote(GenerateDocumentNumber());
        }

        public override bool IsValid(DocumentBase document)
        {
            return base.IsValid(document) && document.Number < 5;
        }
    }
}