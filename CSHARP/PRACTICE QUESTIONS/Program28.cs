using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAP_display_multiplication_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, r;
            Console.Write("enter the number:");
            r = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= 10; i++)
            {
                Console.Write("{0} * {1} = {2} \n", r, i, r * i);
            }
        }
    }
}
    

