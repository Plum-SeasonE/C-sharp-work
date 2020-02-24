using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> num = new HashSet<int> { };
            for (int i = 2; i <= 100; i++)
                num.Add(i);
            do
            {
                Console.Write($"{num.Min()},");
                int max = num.Max();
                int min = num.Min();
                for (int i = min; i <= max; i++)
                    if (i % min == 0)
                        num.Remove(i);
            } while (num.Count != 0);
            Console.WriteLine("\b。");
        }
    }
}
