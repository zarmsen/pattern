using Patterns.Core.Models;

namespace Patterns.Creational.Factory
{
    internal class DeliveryNoteCreator : DocumentCreatorBase
    {
        public override DocumentBase Create()
        {
            return new DeliveryNote(GenerateDocumentNumber());
        }
    }
}