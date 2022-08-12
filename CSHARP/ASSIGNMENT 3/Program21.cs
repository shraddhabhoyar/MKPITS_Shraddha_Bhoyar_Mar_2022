using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_or_not_for_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int count = 0;
            Console.WriteLine("enter number");
            num=Convert.ToInt32(Console.ReadLine());
            for(int i= 0; i < num; i++)
            {
                if(num%2==0)
                {
                    count++;
                }

            }
            if(count == 2)
            {
                Console.WriteLine("prime number");

            }
            else
            {
                Console.WriteLine("not a prime number");
            }
        }
    }
}
