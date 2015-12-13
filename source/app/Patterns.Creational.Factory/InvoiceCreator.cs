using Patterns.Core.Models;

namespace Patterns.Creational.Factory
{
    internal class InvoiceCreator : InvoiceCreatorBase
    {
        public InvoiceCreator(InvoiceType typeOfInvoice)
            : base(typeOfInvoice) {}
    }
}