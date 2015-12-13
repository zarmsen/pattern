using Patterns.Core.Models;

namespace Patterns.Creational.Factory
{
    internal class DeliveryNoteCreator : DocumentCreatorBase
    {
        public static DeliveryNoteCreator Factory { get; } = new DeliveryNoteCreator();

        public override DocumentBase Create()
        {
            return new DeliveryNote(GenerateDocumentNumber());
        }
    }
}