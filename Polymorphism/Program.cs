
using System;
using System.Collections.Generic;

using Polymorphism.Classes;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderlist = OrderProcessingQueueSetup();

            foreach (var order in orderlist)
            {
                Console.WriteLine($"Order subtotal: ${order.Subtotal}, the discount is: ${order.GetDiscount}, and the final total is: ${order.GetOrderTotal}");
            }

            Console.ReadLine();

        }

        private static List<OrderBase> OrderProcessingQueueSetup()
        {
            List<OrderBase> orderlist = new List<OrderBase>();

            OrderBase order1 = new OrderBase { Subtotal = 100 };
            OrderCustomerAbc order2 = new OrderCustomerAbc { Subtotal = 100 };
            OrderCustomerDef order3 = new OrderCustomerDef { Subtotal = 100 };
            OrderCustomerXyz order4 = new OrderCustomerXyz { Subtotal = 100 };

            orderlist.Add(order1);
            orderlist.Add(order2);
            orderlist.Add(order3);
            orderlist.Add(order4);

            return orderlist;
        }
    }
}
