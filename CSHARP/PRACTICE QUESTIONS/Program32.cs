using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAP_pattern_like_right_angle_traingle_with_num_increased_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, rows, m= 1;
           Console.Write("Input number of rows : ");
            rows = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("{0} ", m++);
                Console.Write("\n");
            }
        }
    }
}
    

