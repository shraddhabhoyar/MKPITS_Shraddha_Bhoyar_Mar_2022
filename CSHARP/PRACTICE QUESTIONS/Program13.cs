using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAP_check_triangle_value_for_the_angles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anga, angb, angc, sum;   
            Console.Write("Input angle1 of triangle");
            anga = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input angle 2 of triangle");
            angb = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input angle 3 of triangle");
            angc = Convert.ToInt32(Console.ReadLine());

            sum = anga + angb + angc;

            
            if (sum == 180)
            {
                Console.Write("The triangle is valid");
            }
            else
            {
                Console.Write("The triangle is not valid");
            }
        }

    }

}
    
