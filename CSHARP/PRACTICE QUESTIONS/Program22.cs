using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAP_menu_driven_program_perform_simple_calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, opt;
            Console.Write("Enter the first Integer :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second Integer :");
            num2 = Convert.ToInt32(Console.ReadLine());


            Console.Write("options:");
            
            opt = Convert.ToInt32(Console.ReadLine());

            switch (opt)
            {
                case 1:
                    Console.Write("The Addition of  {0} and {1} is: {2}\n", num1, num2, num1 + num2);
                    break;

                case 2:
                    Console.Write("The Substraction of {0}  and {1} is: {2}\n", num1, num2, num1 - num2);
                    break;

                case 3:
                    Console.Write("The Multiplication of {0}  and {1} is: {2}\n", num1, num2, num1 * num2);
                    break;

                case 4:
                   
                    
                        Console.Write("The Division of {0}  and {1} is : {2}\n", num1, num2, num1 / num2);
                    
                    break;

                case 5:
                    break;

                default:
                    Console.Write("Input correct option\n");
                    break;
            }
        }
    }
}
    

