using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            int min, max, sum;
            double aver;
            int[] num = { 5, 123, 3, 7, 23, 275 };
            caculate(num, out max, out min, out aver, out sum);
            Console.WriteLine($"最大值{max}，最小值{min}，平均值{aver}，和{sum}。");
        }
        static public void caculate(int[] a, out int max, out int min, out double aver, out int sum)
        {
            if (a.Length == 0)
            {
                min = 0;
                max = 0;
                aver = 0.0;
                sum = 0;
            }
            else
            {
                max = min = a[0];
                sum = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] > max)
                        max = a[i];
                    else if (a[i] < min)
                        min = a[i];
                    sum += a[i];
                }
                aver = sum / a.Length;
            }
        }
    }
}
