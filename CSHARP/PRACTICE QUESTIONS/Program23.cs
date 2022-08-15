using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAP_to_display_first_10_natural_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("The first 10 natural number are:");

            for (i = 1; i <= 10; i++)
            {
                Console.Write("{0}", i);
            }
            
        }
    }
}
    

