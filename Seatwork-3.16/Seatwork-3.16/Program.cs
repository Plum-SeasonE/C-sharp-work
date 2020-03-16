using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 写一个订单管理的控制台程序，能够实现添加订单、删除订单、修改订单、
 查询订单（按照订单号、商品名称、客户等字段进行查询）功能。
提示：主要的类有Order（订单）、OrderItem（订单明细项），OrderService（订单服务），
订单数据可以保存在OrderService中一个List中。在Program里面可以调用OrderService的方法完成各种订单操作。
要求：
（1）使用LINQ语言实现各种查询功能，查询结果按照订单总金额排序返回。
（2）在订单删除、修改失败时，能够产生异常并显示给客户错误信息。
（3）作业的订单和订单明细类需要重写Equals方法，确保添加的订单不重复，每个订单的订单明细不重复。
（4）订单、订单明细、客户、货物等类添加ToString方法，用来显示订单信息。
（5）OrderService提供排序方法对保存的订单进行排序。默认按照订单号排序，也可以使用Lambda表达式进行自定义排序。
 */
namespace Seatwork_3._16
{
    
   
    class Program
    {
        static void Main(string[] args)
        {
            OrderItem oi1 = new OrderItem(001, "书本", "A", "B", 1000, 5);
            OrderItem oi2 = new OrderItem(002, "钢笔", "A", "D", 20000, 8);
            OrderItem oi3 = new OrderItem(003, "衣服", "A", "F", 50, 100);
            OrderItem oi4 = new OrderItem(004, "电脑", "G", "H", 30, 4000);
            Console.WriteLine(oi1.ToString());
            Console.WriteLine(oi1.Equals(oi1));
            Console.WriteLine(oi1.Equals(oi2));
            Order o1 = new Order(1);
            Order o2 = new Order(2);
            Console.WriteLine(o1.Equals(o1));
            Console.WriteLine(o1.Equals(o2));
            o1.addOrderItems(oi4);
            o1.addOrderItems(oi3);
            o1.addOrderItems(oi2);
            o1.addOrderItems(oi1);
            var query = o1.orders.Where(s => s.employee == "A").OrderBy(s => s.tradeNum * s.pricePerTrade);
            Console.WriteLine("按照订单小项总金额排序:");
            foreach(var x in query)
            {
                Console.WriteLine(x.ToString());
            }
            Console.WriteLine(o1.ToString());
            o1.deleteOrderItems(1);
            Console.WriteLine(o1.ToString());
            if(o1.deleteOrderItems(1)==null)
                Console.WriteLine("删除失败，订单中不存在这一项。");
            if(o1.searchOrderItems(1)==null)
                Console.WriteLine("查找失败，订单中不存在这一项。");
            Console.WriteLine("查找：");
            Console.WriteLine(o1.searchOrderItems(2).ToString());
            Console.WriteLine("按订单号排序：");
            OrderService.sort(o1);
            Console.WriteLine(o1.ToString());
            OrderService.sort(o1, (tempoi1, tempoi2) =>
            tempoi1.tradeNum * tempoi1.pricePerTrade - tempoi2.tradeNum * tempoi2.pricePerTrade);
            Console.WriteLine("按总金额排序：");
            Console.WriteLine(o1.ToString());

        }
    }
}
