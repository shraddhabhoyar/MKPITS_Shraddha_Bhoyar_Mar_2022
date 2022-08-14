using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAP_to_check_whether_given_number_is_positive_or_negative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            if(num>=0)
            {
                Console.WriteLine("number is positive");

            }
            else
            {
                Console.WriteLine("number is negative");
            }
        }
    }
}
