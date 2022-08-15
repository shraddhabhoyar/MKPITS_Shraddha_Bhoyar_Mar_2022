using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAP_display_pattern_ring_angle_traingle_with_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, rows;
                Console.Write("Input number of rows : ");
            rows = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("{0}", j);
                Console.Write("\n");
            }
        }
    }
}
    

