using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hra_da_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string empname, designation;
            int bonus = 0;
            Console.WriteLine("enter empname ");
            empname = Console.ReadLine();
            Console.WriteLine("enter designation ");
            designation = Console.ReadLine();
            if (designation == "manager") 
            {
                bonus = 10000;
            }
            else if (designation == "clerk") 
            {
                bonus = 5000;
            }
            else if (designation == "peon") 
            {
                bonus = 2000;
            }
            Console.WriteLine("bonus="+bonus);
        }
        

    }
}
