using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addition_of_three_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("enter number 1");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 2");
            b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 3");
            c=Convert.ToInt32(Console.ReadLine());
            int result = a + b + c;
            Console.WriteLine("addition of 3 numbers="+result);
            Console.ReadLine();
        }
    }
}
