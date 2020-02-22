using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace caculator_2
{
    public partial class Form1 : Form
    {
       
        Regex reg1 = new Regex("^[-]{0,1}[0-9]*([.]{0,1}[0-9]*)$");
        Regex reg2 = new Regex("^[-,+,*,/]$");//如果把加号和减号调换一个位置，输入减号会出现错误

        public Form1()
        {
            InitializeComponent();
          
        }


        private void button_e_Click(object sender, EventArgs e)
        {
            bool b = true;//判断该次是否出现了错误
            double num1 = 0;
            double num2 = 0;
            double result = 0;
            string s = "";
            string op = "";


            if(textBox_num1.Text==""||textBox_num2.Text==""||textBox2_op.Text=="")
            {
               MessageBox.Show("请输入完整的算式!", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                b = false;
            }

            //若完整的输入了算式，则进行第一个数字的判断
            if (b)
            {
                s = textBox_num1.Text;
                if (!reg1.Match(s).Success)
                {
                    MessageBox.Show("第一个数字输入错误！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    b = false;
                }
                if (b)
                    num1 = Convert.ToDouble(s);
            }
            
            


            //若上一步没出错则进行，运算符号的判断
            if (b)
            {
                s = textBox2_op.Text;
                if (!reg2.Match(s).Success)
                {
                    MessageBox.Show("运算符号输入错误！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    b = false;
                }
                if (b)
                    op = s;
            }


            //若上两个空都没出错，则进行第三个数字的判断
            if (b)
            {
                s = textBox_num2.Text;
                if (!reg1.Match(s).Success)
                {
                    MessageBox.Show("第二个数字输入错误！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    b = false;
                }
                if (b)
                    num2 = Convert.ToDouble(s);
                if (num2 == 0 && op == "/")
                {
                    MessageBox.Show("除数为0！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    b = false;
                }
            }
           
            //若输入没有错误则进行计算
            if (b)
            {   switch (op)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        break;
                    default:
                        break;
                }
            textBox_result.Text = result.ToString();
             }
        }
    }
}
