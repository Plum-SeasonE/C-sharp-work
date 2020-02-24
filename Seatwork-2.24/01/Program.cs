using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;            //用于记录用户输入的数字
            int temp = 0;         //用于记录上一个输出的素数
            do
            {
                Console.WriteLine("请输入一个大于一的正整数：");
                num = Convert.ToInt32(Console.ReadLine());
            } while (num <= 1);
            Console.Write("该数的素数因子有：");
            for (int i = 2; i <= num; i++)
            {
                if (num % i == 0)
                {
                    if (i != temp)
                        Console.Write($"{i},");
                    temp = i;
                    num /= i;
                    i = 2;
                }
            }
            Console.WriteLine("\b。");
        }
    }
}
