using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAP_read_rollno_name_mrks_calculate_tot_per_div
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double rno, phy, che, ma, tot,per;
            string name, div;
            Console.WriteLine("enter roll no");
            rno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter name of student");
            name = Console.ReadLine();
            Console.WriteLine("enter physics marks");
            phy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter chemistry marks");
            che = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter maths marks");
            ma = Convert.ToInt32(Console.ReadLine());
            tot = phy + che + ma;
            per = tot / 3.0;
            if (per >= 75)
                div = "Distinction";
            else if (per < 75 && per >= 60)
                div = "first class";
            else if (per < 60 && per >= 45)
                div = "second class";
            else
                div = "fail";

            Console.WriteLine("rno and name:{0}{1}", rno, name);
            Console.WriteLine("phy,che,ma:{0}{1}{2}",phy,che,ma);
            Console.WriteLine("tot,div,per:{0}{1}{2}", tot, div, per);


        }
    }
}
