namespace Patterns.Core.Models
{
    public class Invoice : DocumentBase
    {
        public Invoice(int number): base(number) {}
    }

    public class PartialPaymentInvoice : Invoice
    {
        public PartialPaymentInvoice(int number)
            : base(number) {}
    }

    public class PerformaInvoice : Invoice
    {
        public PerformaInvoice(int number)
            : base(number) {}
    }
}