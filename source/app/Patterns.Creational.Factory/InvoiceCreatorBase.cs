using Patterns.Core.Models;

namespace Patterns.Creational.Factory
{
    internal abstract class InvoiceCreatorBase : DocumentCreatorBase
    {
        private readonly InvoiceType _typeOfInvoice;

        protected InvoiceCreatorBase(InvoiceType typeOfInvoice)
        {
            _typeOfInvoice = typeOfInvoice;
        }

        public override DocumentBase Create()
        {
            switch (_typeOfInvoice)
            {
                case InvoiceType.PartialPayment:
                {
                    return new PartialPaymentInvoice(GenerateDocumentNumber());
                }
                case InvoiceType.Performa:
                {
                    return new PerformaInvoice(GenerateDocumentNumber());
                }

                default:
                    return null;
            }
        }
    }
}