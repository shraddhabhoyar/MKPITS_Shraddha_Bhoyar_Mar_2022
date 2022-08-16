using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace values_array_display_reverse_order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            int[] array = new int[50];


            Console.Write("enter element :");
            n = Convert.ToInt32(Console.ReadLine());


            Console.Write("Input-{0} ", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}\n", array[i]);
            }

            
            for (i = n - 1; i >= 0; i--)
            {
                Console.Write("{0} ", array[i]);
            }
           
        }
    }
}