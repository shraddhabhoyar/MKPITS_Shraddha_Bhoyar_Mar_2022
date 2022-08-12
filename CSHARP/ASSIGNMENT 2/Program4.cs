using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smallest_number_programme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, smallest;
            Console.WriteLine("enter number 1");
            n1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 2");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 3");
            n3 = Convert.ToInt32(Console.ReadLine());
            if (n1 < n2 && n1 < n3)
                smallest = n1;
            else if(n2<n3 && n2 < n1)
                smallest = n2;
            else
                smallest = n3;
            Console.WriteLine("smallest=" + smallest);
            Console.ReadLine();


        }
    }
}
