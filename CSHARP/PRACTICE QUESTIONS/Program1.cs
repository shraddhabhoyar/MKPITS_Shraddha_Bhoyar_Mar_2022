using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAP_check_whether_given_number_is_even_or_odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num,result;
            Console.WriteLine("enter number");
            num=Convert.ToInt32(Console.ReadLine());
            result = num % 2;
            if(result == 0)
            {
                Console.WriteLine("{0}Number is even",num);

            }
            else
            {
                Console.WriteLine("{0}Number is odd",num);
            }

        }
    }
}
