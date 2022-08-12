using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_number_programme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, i, m = 0;
            Console.WriteLine("enter number");
            num=Convert.ToInt32(Console.ReadLine());    
            for(i=1;i<=num;i++)
            {
                if(num%2==0)
                {
                    m = m + 1;
                }
            }
            if (m == 2)
                Console.WriteLine("number is prime");
            else
                Console.WriteLine("number isnot prime");
            Console.WriteLine("m=" + m);
            Console.ReadLine();
        }
    }
}
