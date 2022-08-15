using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAP_repeat_pattern_traingle_angle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, rows;
                Console.Write("Input number of rows");
            rows = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("{0}", i);
                Console.Write("\n");
            }
        }
    }
}
