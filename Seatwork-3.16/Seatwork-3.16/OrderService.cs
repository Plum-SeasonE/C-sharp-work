     using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Seatwork_3._16
{
    //1、在OrderService中添加一个Export方法，可以将所有的订单序列化为XML文件；添加一个Import方法可以从XML文件中载入订单。
    //2、对订单程序中OrderService的各个Public方法添加测试用例
    public class OrderService
    {
        //订单集合
        private List<Order> orders;
        //构造函数
        public OrderService()
        {
            orders = new List<Order>();
        }
        //用于外界获取orders
        public List<Order> Orders
        {
            get => orders;
        }
        //通过订单ID获取订单
        public Order GetOrder(int id)
        {
            return orders.Where(o => o.orderID== id).FirstOrDefault();
        }
        //添加订单
        public void AddOrder(Order order)
        {
            if (orders.Contains(order))
                throw new ApplicationException($"添加错误: 订单{order.orderID} 已经存在了!");
            orders.Add(order);
        }
        //删除订单
        public void RemoveOrder(int orderId)
        {
            Order order = GetOrder(orderId);
            if (order != null)
            {
                orders.Remove(order);
            }
        }
        //更新订单
        public void UpdateOrder(Order newOrder)
        {
            Order oldOrder = GetOrder(newOrder.orderID);
            if (oldOrder == null)
                throw new ApplicationException($"修改错误：订单 {newOrder.orderID} 不存在!");
            orders.Remove(oldOrder);
            orders.Add(newOrder);
        }
        //查询订单
        public List<Order> QueryOrdersByOrderID(int orderId)
        {
            var query = orders
                    .Where(order => order.orderID == orderId);
            return query.ToList();
        }
        public List<Order> QueryOrdersByCustomerName(string customerName)
        {
            return orders
                .Where(order => order.customer.Equals( customerName))
                .OrderBy(o => o.orderID)
                .ToList();
        }
        public List<Order> QueryOrdersByEmployeeName(string employeeName)
        {
            return orders
                .Where(order => order.employee.Equals( employeeName))
                .OrderBy(o => o.orderID)
                .ToList();
        }
        //默认排序
        public void Sort()
        {
            orders.Sort();
        }
        //通过指定函数来排序
        public void Sort(Func<Order, Order, int> func)
        {
            Orders.Sort((o1, o2) => func(o1, o2));
        }
        //导出为xml文件
        public void Export(String fileName)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                xs.Serialize(fs, Orders);
            }
        }
        //由xml文件导入
        public void Import(string path)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                List<Order> temp = (List<Order>)xs.Deserialize(fs);
                temp.ForEach(order => {
                    if (!orders.Contains(order))
                    {
                        orders.Add(order);
                    }
                });
            }
        }
    } 
}
