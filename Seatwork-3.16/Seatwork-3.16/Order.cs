using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Seatwork_3._16
{
    public class Order
    {
        public int orderID;
        public string employee { get; set; }
        public string custom { get; set; }
        public Order() { }
        public Order(int id,string Employee,string Custom)
        {
            orderID = id;
            employee = Employee;
            custom = Custom;
        }
        public Order(Order o)
        {
            orderID = o.orderID;
            employee = o.employee;
            custom = o.custom;
            o.addOrderItems(o.orders);
        }

        public List<OrderItem> orders = new List<OrderItem>();
        //添加
        public void addOrderItems(OrderItem oi)
        {
            orders.Add(oi);
        }
        public void addOrderItems(List<OrderItem> oi)
        {
            foreach(OrderItem oitem in oi)
            {
                this.addOrderItems(oitem);
            }
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
            string order=$"订单号:{orderID}\t订货人:{custom}\t发货人:{employee}\n";
            foreach(var oi in orders)
            {
                order += oi.ToString();
                order += "\n";
            }
            return order;
        }
    }
}
