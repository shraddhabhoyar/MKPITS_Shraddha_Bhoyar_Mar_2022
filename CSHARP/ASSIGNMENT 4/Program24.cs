using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_rows_3_column
{
    internal class Program
    {
        static void Main()
        {
            int[,] num = new int[3, 3];
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    Console.WriteLine("enter number");
                    num[i, j] = Convert.ToInt32(Console.ReadLine());
                }
               
            }
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    Console.WriteLine(num[i, j] +"\t");
                }
                Console.WriteLine();
            }
        }
    }
}
