using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] array = new int[10];
            Console.WriteLine("enter elements");
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0}:", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0} ", array[i]);

            }
        }
    }
}
