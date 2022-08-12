using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_loop_factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int fact = 1;
            Console.WriteLine("enter factorial");
            a = Convert.ToInt32(Console.ReadLine());
            for(int i = a; i > 0; i--)
            {
                fact = fact * i;

            }
            Console.WriteLine("fact="+fact);
        }
    }
}
