using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAP_read_value_integer_m_display_value_of_n
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m,n;
            Console.WriteLine("enter first number");
            m=Convert.ToInt32(Console.ReadLine());
            
            if (m != 0)
                if (m > 0)
                    n = 1;
                else
                    n = -1;
            else
                n = 0;
            Console.WriteLine("the value of m={0}",m);
            Console.WriteLine("the value of n={0}",n);


        }
    }
}
