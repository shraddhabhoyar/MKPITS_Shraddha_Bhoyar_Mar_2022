using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_table_for_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, i=0;
            int res = 1;

            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
        
            while (i<= 10)
            {
                res = num * i;
               
                Console.WriteLine("res="+res);
                 i++;
               
            }
            

        }
    }
}

