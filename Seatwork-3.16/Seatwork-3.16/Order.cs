using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Seatwork_3._16
{
    class Order
    {
        public Order(int id)
        {
            orderID = id;
        }
        public int orderID;
        public List<OrderItem> orders = new List<OrderItem>();
        //添加
        public void addOrderItems(OrderItem oi)
        {
            orders.Add(oi);
        }
        //删除
        public OrderItem deleteOrderItems(int OrderID)
        {
            var findOrder = orders.FirstOrDefault(t => t.orderItemID == OrderID);
            if (findOrder != null)
                orders.Remove(findOrder);
            return findOrder;
           
        }
        //查找
        public OrderItem searchOrderItems(int OrderID)
        {
            var findOrder = orders.FirstOrDefault(t => t.orderItemID == OrderID);
            return findOrder;
        }
        public override bool Equals(object obj)
        {
            Order o = obj as Order;
            return orderID==o.orderID;
        }
        public override int GetHashCode()
        {
            return orderID;
        }
        public override string ToString()
        {
            string order="订单项目:\n";
            foreach(var oi in orders)
            {
                order += oi.ToString();
                order += "\n";
            }
            return order;
        }
    }
}
