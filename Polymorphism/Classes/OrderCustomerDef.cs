
namespace Polymorphism.Classes
{
    public class OrderCustomerDef : OrderBase
    {
        public override decimal SetDiscount()
        {
            return .15m;
        }
    }
}
