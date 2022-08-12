using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_4_Q_5_addition_of_3_by_3_matrix
{
    internal class Program
    {
        static void Main()
        {
            int[,] num1 = new int[3, 3];
            int[,] num2 = new int[3, 3];
            int[,] sum = new int[3, 3];
            Console.WriteLine("Enter Array Element");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    num1[i, j] = Convert.ToInt16(Console.ReadLine());
                }

            }
            Console.WriteLine();


            Console.WriteLine("Enter Array Element");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    num2[i, j] = Convert.ToInt16(Console.ReadLine());
                }

            }
            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sum[i, j] = num1[i, j] + num2[i, j];
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(sum[i, j] + "\t");
                }

            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}