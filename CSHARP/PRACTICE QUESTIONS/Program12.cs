using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAP_check_triangle_equilateral_isosceles_scalene
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sidea, sideb, sidec;
            Console.Write("Input side 1 of triangle ");
            sidea = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input side 2 of triangle ");
            sideb = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input side 3 of triangle");
            sidec = Convert.ToInt32(Console.ReadLine());



            if (sidea == sideb && sideb == sidec)
            {
                Console.Write("This is an equilateral triangle");
            }
            else if (sidea == sideb || sidea == sidec || sideb == sidec)
            {
                Console.Write("This is an isosceles triangle");
            }
            else
            {
                Console.Write("This is a scalene triangle");
            }
        }
    }

}
   
