using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAP_sum_of_10_natural_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, sum = 0;
            Console.Write("The first 10 natural number are:\n");
            for (i = 1; i <= 10; i++)
            {
                sum = sum + i;
                Console.Write("{0}", i);
            }
            Console.Write(" \nSum: {0}\n", sum);
        }
    }
}
    

