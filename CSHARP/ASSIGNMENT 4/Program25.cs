using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_table_using_method
{
    internal class Program
    {
        static void Main(int a)
        {
            for(int i=0;i<=10;i++)
            {
                Console.WriteLine("{0}*{1}={2}",i, a, (i * a) );
            }
        }
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("enter any number");
            a=Convert.ToInt32(Console.ReadLine());
            Main(a);
       }
    }
}
