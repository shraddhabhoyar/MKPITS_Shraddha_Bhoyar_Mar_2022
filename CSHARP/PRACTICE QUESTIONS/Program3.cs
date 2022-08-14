using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAP_to_find_whether_given_year_leap_year_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("enter year");
            year=Convert.ToInt32(Console.ReadLine());
            
            if(((year%4==0) && (year %100!=0))||(year %400==0))
                    {
                Console.WriteLine("This is a leap year");
              }
            else
            {
                Console.WriteLine("This is not a leap year");
            }
        }
    }
}
