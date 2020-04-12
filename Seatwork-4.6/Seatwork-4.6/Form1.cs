using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seatwork_3._16;

namespace Seatwork_4._6
{   /*
    为订单管理的程序添加一个WinForm的界面。
    通过这个界面，调用OrderService的各个方法，实现创建订单、删除订单、修改订单、查询订单、导出订单、导入订单等功能。
    要求：
    （1）WinForm的界面部分单独写一个项目，依赖于原来的项目。
    （2）可以使用两个窗口。主窗口实现查询展示功能，以及放置各种功能按钮。新建/修改订单功能使用弹出窗口。
    （3）注意窗口的布局，在窗口尺寸变化时，不出现错位挤压等情况。
    （4）尽量通过数据绑定来实现功能。订单和订单明细各使用一个bindingsource，通过DataMember来实现主从对象绑定。
    */

    public partial class Form1 : Form
    {
        OrderService orderService;
        BindingSource fieldsBS = new BindingSource();
        public String Keyword { get; set; }
        public Form1()
        {
            InitializeComponent();

            orderService = new OrderService();
            Order o1 = new Order(1,"张三","李四");
            Order o2 = new Order(2, "张三", "王五");
            Order o3 = new Order(3, "李四", "王五");
            orderService.AddOrder(o1);
            orderService.AddOrder(o2);
            orderService.AddOrder(o3);
            OrderItem oi1 = new OrderItem(001, "书本", 1000, 5);
            OrderItem oi2 = new OrderItem(002, "钢笔", 20000, 8);
            OrderItem oi3 = new OrderItem(003, "衣服", 50, 100);
            OrderItem oi4 = new OrderItem(004, "电脑", 30, 4000);
            o1.addOrderItems(oi1);
            o1.addOrderItems(oi2);
            o2.addOrderItems(oi3);
            o3.addOrderItems(oi4);
            orderBindingSource.DataSource = orderService.Orders;
            orderItemBindingSource = orderBindingSource;
            orderItemBindingSource.DataMember = "orderItems";


        }

        private void button_new_Click(object sender, EventArgs e)
        {

        }
    }
}
