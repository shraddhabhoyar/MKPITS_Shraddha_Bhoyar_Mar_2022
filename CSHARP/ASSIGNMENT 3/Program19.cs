using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while_factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;

            int fact=1;
            Console.WriteLine("enter factorial");
            a = Convert.ToInt32(Console.ReadLine());
            int i = a;
            do
            {
                Console.WriteLine("fact=" + fact);
                fact = fact * i;
                i--;

            } while (i > 0);



        }
    }
}
