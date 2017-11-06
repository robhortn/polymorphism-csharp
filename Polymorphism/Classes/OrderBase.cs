
namespace Polymorphism.Classes
{
    public class OrderBase
    {
        public decimal Subtotal { get; set; }

        public decimal GetOrderTotal {
            get {
                return Subtotal - GetDiscount;
            }
        }

        public decimal GetDiscount => Subtotal * SetDiscount();

        public virtual decimal SetDiscount() {
            return .05m;
        }
    }
}
