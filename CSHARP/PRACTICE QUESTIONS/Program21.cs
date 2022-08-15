using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAP_to_compute_area_of_various_geometrical_shape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice, r, l, w, b, h;
            double area = 0;
            Console.Write(" area of circle\n");
            Console.Write("area of rectangle\n");
            Console.Write("area of triangle\n");
            Console.Write("Input your choice : ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("radius of the circle : ");
                    r = Convert.ToInt32(Console.ReadLine());
                    area = 3.14 * r * r;
                    break;
                case 2:
                    Console.Write("length  of the rectangle : ");
                    l = Convert.ToInt32(Console.ReadLine());
                    Console.Write("width of the rectangle : ");
                    w = Convert.ToInt32(Console.ReadLine());
                    area = l * w;
                    break;
                case 3:
                    Console.Write("base of the triangle :");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.Write("height of the triangle :");
                    h = Convert.ToInt32(Console.ReadLine());
                    area = 0.5 * b * h;
                    break;
            }
            Console.Write("The area is:{0}\n", area);
        }
    }
}
    

