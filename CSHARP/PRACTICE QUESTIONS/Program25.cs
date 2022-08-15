using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAP_display_n_terms_natural_numbers_and_their_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0;
            Console.Write("Input Value of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nThe first {0} natural number are :\n", n);
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}\n ", i);
                sum += i;
            }
            Console.WriteLine("{0}:{1} \n", n, sum);
        }
    }
}
    



