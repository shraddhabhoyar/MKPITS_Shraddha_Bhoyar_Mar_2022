using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAP_to_find_largest_of_three_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            Console.WriteLine("enter first number");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter third number");
            n3 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2)
            {
                if (n1 > n3)
                {
                    Console.WriteLine("first Number is the greatest among three");
                }
                else
                {
                    Console.WriteLine("third Number is the greatest among three");
                }
            }
            else if (n2 > n3)

                Console.WriteLine("second Number is the greatest among three");
            else
                Console.WriteLine("third Number is the greatest among three");
            
        }
    }
}
