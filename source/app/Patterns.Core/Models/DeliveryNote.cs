namespace Patterns.Core.Models
{
    public class DeliveryNote : DocumentBase
    {
        public DeliveryNote(int number)
            : base(number) {}

        public override bool IsValid()
        {
            return Number < 5;
        }
    }
}