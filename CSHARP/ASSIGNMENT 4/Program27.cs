using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace display_tot_pr_gr
{
    internal class Program
    {
        static void display(int s1,int s2,int s3)
        {
            int total = s1 + s2 + s3;
            float per = (total / 300.0f) * 100;
            Console.WriteLine("total="+total);
            Console.WriteLine("per="+per);
            if (per >= 75)
            {
                Console.WriteLine("distinction");

            }
            else if (per >= 60 && per < 75)
            {
                Console.WriteLine("first class");
            }
            else if (per >= 40 && per < 60)
            {
                Console.WriteLine("second class");
            }

            else
            {
                Console.WriteLine("fail");
            }
 }
        static void Main(string[] args)
        {
            int s1, s2, s3;
            Console.WriteLine("enter subject 1 marks");
            s1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter subject 2 marks");
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter subject 3 marks");
            s3 = Convert.ToInt32(Console.ReadLine());
            display(s1, s2, s3);

        }
    }
}
