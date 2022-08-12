using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even_odd_programme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, result;
            Console.WriteLine("enter number");
            a=Convert.ToInt32(Console.ReadLine());
            if(a%2==0)
            {
                Console.WriteLine("number is even");
            }
            else
            {
                Console.WriteLine("number is odd");
            }
            Console.ReadLine();


        }
    }
}
