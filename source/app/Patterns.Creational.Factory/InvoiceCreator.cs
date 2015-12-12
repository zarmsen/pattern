using Patterns.Core.Models;

namespace Patterns.Creational.Factory
{
    internal class InvoiceCreator : DocumentCreatorBase
    {
        public override DocumentBase Create()
        {
            return new DeliveryNote(GenerateDocumentNumber());
        }
    }
}