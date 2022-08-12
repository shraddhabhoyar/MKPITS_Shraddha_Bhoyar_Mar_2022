using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product_display_totalamount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rate, qty,result;
            string name;
            Console.WriteLine("enter productrate");
            rate=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter quantity");
            qty=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            name=Console.ReadLine();
            result = rate * qty;
            Console.WriteLine("result="+result);
            
        }
    
    }
}
