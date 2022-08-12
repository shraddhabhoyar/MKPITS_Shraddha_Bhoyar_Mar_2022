using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_loop_factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            
            int fact = 1;
            Console.WriteLine("enter factorial");
            a = Convert.ToInt32(Console.ReadLine());
            int i = a;
            while (i > 0)
            {
                fact = fact * i;
                i--;

            }
            Console.WriteLine("fact=" + fact);

        }
    }
}
