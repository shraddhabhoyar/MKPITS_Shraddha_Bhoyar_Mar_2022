using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace display_the_area_of_a_rectangle_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("enter length");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter breadth");
            b = Convert.ToInt32(Console.ReadLine());
            int result = a * b;
            Console.WriteLine("area of rectangle=" + result);
            Console.ReadLine();



        }
    }
}
