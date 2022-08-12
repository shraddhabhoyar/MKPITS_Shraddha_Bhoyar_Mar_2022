using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while_print_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, i = 0;
            int res = 1;

            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());

            do
            {
                res = num * i;

                Console.WriteLine("res=" + res);
                i++;

            } while (i <= 10);
        }
    }
}

