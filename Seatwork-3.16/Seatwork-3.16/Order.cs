using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Seatwork_3._16
{
    public class Order
    {
        public int orderID { get; set; }
        public string employee { get; set; }
        public string customer { get; set; }
        public List<OrderItem> orderItems ;

        public Order()
        {
            orderItems = new List<OrderItem>();
        }
            public Order(int id,string Employee,string Customer)
        {
            orderID = id;
            employee = Employee;
            customer = Customer;
            orderItems = new List<OrderItem>();
        }
        public Order(Order o)
        {
            orderID = o.orderID;
            employee = o.employee;
            customer = o.customer;
            o.addOrderItems(o.orderItems);
        }

        public List<OrderItem> Items
        {
            get { return orderItems; }
        }
        //添加
        public void addOrderItems(OrderItem oi)
        {
            Items.Add(oi);
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
            var findOrder = orderItems.FirstOrDefault(t => t.orderItemID == OrderID);
            if (findOrder != null)
                orderItems.Remove(findOrder);
            return findOrder;
           
        }
        //查找
        public OrderItem searchOrderItems(int OrderID)
        {
            var findOrder = orderItems.FirstOrDefault(t => t.orderItemID == OrderID);
            return findOrder;
        }
        public override bool Equals(object obj)
        {
            var order = obj as Order;
            return order != null &&
                   orderID == order.orderID;
        }
        public override int GetHashCode()
        {
            return orderID;
        }
        public override string ToString()
        {
            string order=$"订单号:{orderID}\t订货人:{customer}\t发货人:{employee}\n";
            foreach(var oi in orderItems)
            {
                order += oi.ToString();
                order += "\n";
            }
            return order;
        }
        public Order Clone()
        {
            Order newOrder = new Order();
            newOrder.orderID = this.orderID;
            newOrder.customer = this.customer;
            newOrder.employee = this.employee;
            for (int i = 0; i < this.orderItems.Count; i++)
            {
                newOrder.addOrderItems((OrderItem)this.orderItems[i].Clone());
            }
            return newOrder;
        }
    }
}
