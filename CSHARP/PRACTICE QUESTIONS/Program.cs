using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAP_accept_2_int_chk_whether_they_are_equal_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("enter first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            num2 = Convert.ToInt32(Console.ReadLine());

            if(num1== num2)
            {
                Console.WriteLine("{0}and{1} are equal", num1, num2);
            }
            else
            {
                Console.WriteLine("{0} and{1} are not equal", num1, num2);
            }
        }
    }
}
