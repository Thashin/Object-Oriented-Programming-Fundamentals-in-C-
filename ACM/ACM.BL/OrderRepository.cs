using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);

            if(orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(2014, 10, 1, 1, 2, 3, new TimeSpan(1, 0, 0));
            }
            return order;
        }
    }
}
