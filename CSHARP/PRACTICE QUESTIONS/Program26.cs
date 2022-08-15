using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAP_read_10numbers_find_sum_average
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0;
            double avg;
            Console.Write("Input the 10 numbers : \n");
            for (i = 1; i <= 10; i++)
            {
                Console.Write("number{0} :", i);

                n = Convert.ToInt32(Console.ReadLine());
                sum += n;
            }
            avg = sum / 10.0;
            Console.Write("{0}:{1}\n", sum, avg);
        }
    }
}
    

