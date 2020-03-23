using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Seatwork_3._16;

namespace UnitTest_OrderService
{
    [TestClass]
    public class UnitTestOrderService
    {
        [TestMethod]
        public void TestMethodsort1()
        {
            OrderItem oi1 = new OrderItem(001, "书本", 1000, 5);
            OrderItem oi2 = new OrderItem(002, "钢笔", 20000, 8);
            OrderItem oi3 = new OrderItem(003, "衣服", 50, 100);
            OrderItem oi4 = new OrderItem(004, "电脑", 30, 4000);
            Order o = new Order(1, "A", "B");
            OrderItem[] list = { oi1, oi2, oi3, oi4 };
            o.addOrderItems(oi4);
            o.addOrderItems(oi3);
            o.addOrderItems(oi2);
            o.addOrderItems(oi1);
            OrderService.sort(o);

            int i = 0;

            foreach(OrderItem oi in o.orders)
            {
                if (!oi.Equals(list[i])) 
                {
                    break;
                }
                i++;
            }
            Assert.IsTrue(i == 4);
        }
        [TestMethod]
        public void TestMethodsort2()
        {
            OrderItem oi1 = new OrderItem(001, "书本", 1000, 5);
            OrderItem oi2 = new OrderItem(002, "钢笔", 20000, 8);
            OrderItem oi3 = new OrderItem(003, "衣服", 50, 100);
            OrderItem oi4 = new OrderItem(004, "电脑", 30, 4000);
            Order o = new Order(1, "A", "B");
            OrderItem[] list = { oi4, oi3, oi1, oi2 };
            o.addOrderItems(oi4);
            o.addOrderItems(oi3);
            o.addOrderItems(oi2);
            o.addOrderItems(oi1);
            OrderService.sort(o, (tempoi1, tempoi2) =>
           tempoi1.tradeNum  - tempoi2.tradeNum );

            int i = 0;

            foreach (OrderItem oi in o.orders)
            {
                if (!oi.Equals(list[i]))
                {
                    break;
                }
                i++;
            }
            Assert.IsTrue(i == 4);
           
        }
        [TestMethod]
        public void TestMethodsExport()
        {
            OrderItem oi1 = new OrderItem(001, "书本", 1000, 5);
            OrderItem oi2 = new OrderItem(002, "钢笔", 20000, 8);
            OrderItem oi3 = new OrderItem(003, "衣服", 50, 100);
            OrderItem oi4 = new OrderItem(004, "电脑", 30, 4000);
            Order o = new Order(1, "A", "B");
            o.addOrderItems(oi4);
            o.addOrderItems(oi3);
            o.addOrderItems(oi2);
            o.addOrderItems(oi1);
            OrderService.Export(o);
            Assert.IsNotNull("s.xml");
        }
        [TestMethod]
        public void TestMethodsImportt()
        {
            OrderItem oi1 = new OrderItem(001, "书本", 1000, 5);
            OrderItem oi2 = new OrderItem(002, "钢笔", 20000, 8);
            OrderItem oi3 = new OrderItem(003, "衣服", 50, 100);
            OrderItem oi4 = new OrderItem(004, "电脑", 30, 4000);
            Order o1 = new Order(1, "A", "B");
            Order o2 = new Order(1, "A", "B");
            OrderItem[] list = { oi4, oi3, oi2, oi1 };
            o1.addOrderItems(oi4);
            o1.addOrderItems(oi3);
            o1.addOrderItems(oi2);
            o1.addOrderItems(oi1);
            OrderService.Export(o1);
            OrderService.Import(o2);
            int i = 0;

            foreach (OrderItem oi in o2.orders)
            {
                if (!oi.Equals(list[i]))
                {
                    break;
                }
                i++;
            }
            Assert.IsTrue(i == 4);
        }
    }
}
