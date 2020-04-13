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
        public static OrderService orderService;
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
        }
        //更新
        private void QueryAll()
        {
            orderBindingSource.DataSource = orderService.Orders;
            orderBindingSource.ResetBindings(false);
            itemsBindingSource.ResetBindings(false);
        }
        //增
        private void button_new_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(true,new Order());
            if (form2.ShowDialog() == DialogResult.OK)
            {
                
                QueryAll();
            }
        }
        //删
        private void button_delete_Click(object sender, EventArgs e)
        {
            Order order = orderBindingSource.Current as Order;
            if (order == null)
            {
                MessageBox.Show("请选择一个订单进行删除");
                return;
            }
            orderService.RemoveOrder(order.orderID);
            QueryAll();
        }
        //改
        private void button_set_Click(object sender, EventArgs e)
        {
            Order order = orderBindingSource.Current as Order;
            if (order == null)
            {
                MessageBox.Show("请选择一个订单进行修改");
                return;
            }
            Form2 form2 = new Form2(false,order);
            if (form2.ShowDialog() == DialogResult.OK)
            {
                orderService.UpdateOrder(form2.cOrder);
                QueryAll();
            }
        }
        //查
        private void button_get_Click(object sender, EventArgs e)
        {
            Keyword = textBox1.Text;
            switch (comboBox1.SelectedIndex)
            {
                case 0://所有订单
                    orderBindingSource.DataSource = orderService.Orders;
                    break;
                case 1://根据ID查询
                    int.TryParse(Keyword, out int id);
                    Order order = orderService.GetOrder((int)id);
                    List<Order> result = new List<Order>();
                    if (order != null) result.Add(order);
                    orderBindingSource.DataSource = result;
                    break;
                case 2://根据订货人查询
                    orderBindingSource.DataSource = orderService.QueryOrdersByCustomerName(Keyword);
                    break;
                case 3://根据发货人查询
                    orderBindingSource.DataSource = orderService.QueryOrdersByEmployeeName(Keyword);
                    break;
            }
            orderBindingSource.ResetBindings(true);
        }

        private void 导出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export";
            saveFileDialog.Filter = "XML File|*.xml";
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = System.IO.Path.GetFullPath(saveFileDialog.FileName);
                orderService.Export(path);
                MessageBox.Show("Successfully Exported!");
            }
        }

        private void 导入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open";
            openFileDialog.Filter = "XML File|*.xml";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = System.IO.Path.GetFullPath(openFileDialog.FileName);
                orderService.Import(path);
                orderBindingSource.ResetBindings(false);
            }
        }
    }
}
