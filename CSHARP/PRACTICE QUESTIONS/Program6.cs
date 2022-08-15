using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAP_accept_height_categorize_according_height
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float height;
            Console.WriteLine("enter the height of person");
            height = Convert.ToInt32(Console.ReadLine());

            if (height < 150)
            {
                Console.WriteLine("the person is dwarf");
            }
            else if ((height >= 150) && (height <= 170))
            {
                Console.WriteLine("the person is average");
            }
            else if ((height >= 170) && (height <= 190))
            {
                Console.WriteLine("the person is taller");
            }
            else
            {
                Console.WriteLine("not accepted");
            }

             
        }
    }
}
