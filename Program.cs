using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, x = 0;
            Console.WriteLine("please enter the first number :");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the last number :");
            n2 = int.Parse(Console.ReadLine());
            for (int i = n1; i >= 0 && i <= n2; i++)
            {
                for (int k = 1; k <= n2; k++)
                {
                    int r= (i % k);
                    if (r == 0)
                        x++;
                }
                if (x == 2)
                {
                    Console.WriteLine(i);
                }
                x = 0;
            }
        }
    }
}
