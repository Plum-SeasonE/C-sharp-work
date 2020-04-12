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
        private Order cOrder;//目前的订单
        public string orderID{ get; set; }
        public string customer { get; set; }
        public string empolyee { get; set; }
        public Form2(bool mode,Order o)
        {
            InitializeComponent();
            this.mode = mode;
            if(mode)
            {
                cOrder = o.Clone();      //深克隆，避免直接操作原数据           
            }
            else
            {
                cOrder = new Order();
            }
        }

        private void button_creat_Click(object sender, EventArgs e)
        {

            /*if (mode)
            {
                Form1.OrderList.Add(cOrder);
            }
            else
            {
                Form1.OrderList.Remove();
            }
            /*private void btnComfirm_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case 0:
                    service.UpdateOrder(currentOrder.OrderCode, currentOrder);              //模式代码为0更新订单
                    break;
                default:
                    service.AddOrder(currentOrder);                                         //其他值新增订单
                    break;
            }
            DialogResult = DialogResult.OK;
        }*/

        }
    }
}
