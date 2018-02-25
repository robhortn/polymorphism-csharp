
using System;
using System.Collections.Generic;

using Polymorphism.Classes;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderlist = OrderProcessingQueueSetup();  // Get our mocked up queue of orders.

            // Simulate processing each order in the list, getting the order type and calculating the discount
            // based on that type.
            foreach (var order in orderlist)
            {
                Console.WriteLine($"Order type is: {order.Type}. Order subtotal: ${order.Subtotal}, the discount is: ${order.GetDiscount}, and the final total is: ${order.GetOrderTotal}");
            }
            Console.ReadLine();
        }

        // This method mocks up a queue of orders that should be processed.  The discount will 
        // need to be applied to each order as their are processed in Main.
        private static List<OrderBase> OrderProcessingQueueSetup()
        {
            List<OrderBase> orderlist = new List<OrderBase>();

            OrderBase order1 = new OrderBase { Subtotal = 275 };
            OrderCustomerAbc order2 = new OrderCustomerAbc { Subtotal = 380 };
            OrderCustomerDef order3 = new OrderCustomerDef { Subtotal = 1233 };
            OrderCustomerXyz order4 = new OrderCustomerXyz { Subtotal = 899 };

            orderlist.Add(order1);
            orderlist.Add(order2);
            orderlist.Add(order3);
            orderlist.Add(order4);

            return orderlist;
        }
    }
}
