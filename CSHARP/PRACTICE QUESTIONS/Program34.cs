using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAP_display_even_natural_numbers_and_their_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0;
            Console.WriteLine("enter number: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" even numbers:");
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine("{0} ", 2 * i);
                sum+= 2 * i;
            }
            Console.Write(" {0}: {1} \n", n, sum);
        }
    }
}
    

