namespace Patterns.Core.Models
{
    public class PartialPaymentInvoice : Invoice
    {
        public PartialPaymentInvoice(int number)
            : base(number) {}

        public override bool IsValid()
        {
            return Number > 8;
        }
    }
}