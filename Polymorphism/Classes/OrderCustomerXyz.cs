
namespace Polymorphism.Classes
{
    public class OrderCustomerXyz : OrderBase
    {
        public override decimal SetDiscount()
        {
            return .2m;
        }
    }
}
