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
{
    public partial class Form2 : Form
    {
        private bool mode;//true 为新增，false为修改
        public Order cOrder { get; set; }//目前的订单

        //窗口初始化
        public Form2(bool mode,Order o)
        {
            InitializeComponent();
            this.mode = mode;
             cOrder = o.Clone();
   
        }
         private void Form2_Load(object sender, EventArgs e)
        {
            orderBindingSource.DataSource = cOrder; 
            textBoxID.DataBindings.Add("Text", cOrder, "orderID");
            textBoxCustomer.DataBindings.Add("Text", cOrder, "customer");
            textBoxemployee.DataBindings.Add("Text", cOrder, "employee");
            
        }
        private void buttonCreat_Click(object sender, EventArgs e)
        {
            if (mode)
                Form1.orderService.AddOrder(cOrder);
            else Form1.orderService.UpdateOrder(cOrder);
            DialogResult = DialogResult.OK;
        }

        
    }
}
