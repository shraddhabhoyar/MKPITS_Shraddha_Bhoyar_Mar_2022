using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAP_accept_coordinate_point_xy_determine_xy_lies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x,y;
            Console.WriteLine("enter first number");
            x=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            y = Convert.ToInt32(Console.ReadLine());

            if (x > 0 && y > 0)

                Console.WriteLine("the coordinate point lies in first quadrent");

            else if (x < 0 && y > 0)
                Console.WriteLine("the coordinate point lies in second quadrent");
            else if(x < 0 && y < 0)
                Console.WriteLine("the coordinate point lies in third quadrent");
            else if (x > 0 && y < 0)
                Console.WriteLine("the coordinate point lies in fourth quadrent");
            else if(x==0 && y==0)
                Console.WriteLine("the coordinate point lies in origin");









        }
    }
}
