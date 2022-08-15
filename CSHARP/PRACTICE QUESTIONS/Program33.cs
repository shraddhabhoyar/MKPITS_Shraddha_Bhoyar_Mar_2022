using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAP_calculate_factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, fact = 1, num;
              Console.WriteLine("enter number :");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
                fact = fact * i;

            Console.WriteLine("{0} : {1}\n", num, fact);
        }
    }

}
   

