using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_student_name_store_assignment
{
    internal class Program
    {
        static void Main()
        {
            //creating a num array of 5 elements
            string[] name = new string[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("enter name");
                name[i] =Console.ReadLine();
            }
            //display the values of array
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("name [ {0} ] = {1}", i, name[i]);
            }


        }
    }
}
