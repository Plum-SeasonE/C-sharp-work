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
        public static void sort(Order o)
        {
            o.orders.Sort((oi1,oi2)=>oi1.orderItemID-oi2.orderItemID);
        }
        public  static void sort(Order o,Func<OrderItem,OrderItem,int> f)
        {
            o.orders.Sort((o1, o2) => f(o1, o2));
        }
        public static void Export(Order o)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<OrderItem>));
            using (FileStream fs=new FileStream("s.xml", FileMode.Create))
            {
                xs.Serialize(fs, o.orders);
               
            }
        }
        public  static void Import(Order o)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<OrderItem>));
            using (FileStream fs = new FileStream("s.xml", FileMode.Open))
            {
                o.addOrderItems((List<OrderItem>)xs.Deserialize(fs));   
            }
            
        }
    } 
}
