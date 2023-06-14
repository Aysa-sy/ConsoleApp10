using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a number :");
            int m = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            if (0 <= n && n <= 483000)
                Console.WriteLine("nothing");
            if (483001 <= n && n <= 600000)
            {
                m = (10 * n) / 100;
                Console.WriteLine("your tax is:" + m);
            }
            if (600001 <= n && n <= 1000000)
            {
                m = (15 * n) / 100;
                Console.WriteLine("your tax is:" + m);
            }
            if (1000001 <= n && n <= 20000000)
            {
                m = (20 * n) / 100;
                Console.WriteLine("your tax is:" + m);
            }
        }
    }
}
