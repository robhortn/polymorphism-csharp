
namespace Polymorphism.Classes
{
    public class OrderCustomerAbc : OrderBase
    {
        public override decimal SetDiscount() {
            return .1m;
        }
    }
}
