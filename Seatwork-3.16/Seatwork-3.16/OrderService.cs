using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seatwork_3._16
{
    class OrderService
    {
        public static void sort(Order o)
        {
            o.orders.Sort((oi1,oi2)=>oi1.orderItemID-oi2.orderItemID);
        }
        public  static void sort(Order o,Func<OrderItem,OrderItem,int> f)
        {
            o.orders.Sort((o1, o2) => f(o1, o2));
        }
    } 
}
