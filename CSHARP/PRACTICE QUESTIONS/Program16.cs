using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAP_accept_grade_declare_equivalent_description
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string point;
            char grd;
           Console.Write("input the grade:");
            grd = Convert.ToChar(Console.ReadLine());

            switch (grd)
            {
                case 'E':
                    point = " Excellent";
                    break;
                case 'V':
                    point = " Very Good";
                    break;
                case 'G':
                    point = " Good ";
                    break;
                case 'A':
                    point = " Average";
                    break;
                case 'F':
                    point = " Fails";
                    break;
                default:
                    point = "Invalid Grade Found.";
                    break;
            }
            Console.Write("You have chosen:{0}\n", point);
        }
    }
}
    
