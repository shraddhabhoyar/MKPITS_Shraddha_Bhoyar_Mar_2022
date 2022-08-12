using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while_print_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, i;
            int count = 0;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            i = 1;
            do
            {
                if (num % i == 0)
                {

                    count = count + 1;


                }
                i++;

            } while (i <= num);

                if (count == 2)
            {
                Console.WriteLine("prime number");


            }
            else
            {
                Console.WriteLine("not a prime number");
            }
            Console.ReadLine();

        }
    }
}
