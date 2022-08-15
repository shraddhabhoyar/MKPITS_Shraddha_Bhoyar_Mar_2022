using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAP_to_display_cube
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, cube;
             Console.Write("Input number of terms : ");
            cube = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= cube; i++)
            {
                Console.Write("Number is : {0} and cube of the {1} is :{2} \n", i, i, (i * i * i));
            }
        }
    }

}
    

