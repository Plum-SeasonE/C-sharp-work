using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using   System.Text.RegularExpressions;
namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {


            bool b = false;
            double num1 = 0;
            double num2 = 0;
            double result = 0;
            string s = "";
            string op = "";
            Regex reg1 = new Regex("^[-]{0,1}[0-9]*([.]{0,1}[0-9]*)$");
            Regex reg2 = new Regex("[-,+,*,/]");//如果把加号和减号调换一个位置，输入减号会出现错误。

            Console.WriteLine("这是一个计算器。\n");
            Console.WriteLine("请输入第一个数字：");
            while (b == false)
            {
                s= Console.ReadLine();
                Match ma = reg1.Match(s);
                b = ma.Success;
                if (b == false)
                    Console.WriteLine("格式错误，请重新输入：");
            } 
            num1 = Convert.ToDouble(s);

            Console.WriteLine("请输入运算符号(+,-,*,/):");
            b = false;
            while (b == false)
            {
                s = Console.ReadLine();
                Match ma = reg2.Match(s);
                b = ma.Success;
                if (b == false)
                    Console.WriteLine("格式错误，请重新输入：");
            }
            op = s;

            Console.WriteLine("请输入第二个数字：");
            b = false;
            for (; ; )// 判断是否出现了除数为0 的状况
            {
                while (b == false)//  判断输入的是否为数字
                {
                    s = Console.ReadLine();
                    Match ma = reg1.Match(s);
                    b = ma.Success;
                    if (b == false)
                        Console.WriteLine("格式错误，请重新输入：");
                }
                num2 = Convert.ToDouble(s);
                if (num2 == 0 && op == "/")
                {
                    Console.WriteLine("除数为0！请重新输入第二个数字：");
                    b = false;
                }  
                else break;
             }

            switch(op)
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

            Console.WriteLine($"{num1}{op}{num2}={result}");
        }
    }
}
