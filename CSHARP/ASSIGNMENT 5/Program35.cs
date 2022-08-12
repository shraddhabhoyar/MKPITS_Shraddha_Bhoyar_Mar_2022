using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hra_da_calculation_assignment
{
    class collection
    {
        public int empno;
        public float basicsal, total, HRA, DA, TA;
        public string empname;
    }
    internal class Program
    {
        static void Main()
        {
            collection cal = new collection();

            Console.WriteLine("Enter the employe number");
            cal.empno = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter the basic salary");
            cal.basicsal = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter the employe name");
            cal.empname = Console.ReadLine();

            cal.HRA = cal.basicsal * 0.32f;
            cal.DA = cal.basicsal * 0.45f;
            cal.TA = cal.basicsal * 0.43f;

            cal.total = cal.basicsal + cal.HRA + cal.DA + cal.TA;
            Console.WriteLine("name" + cal.empname);
            Console.WriteLine("id no " + cal.empno);
            Console.WriteLine("salary" + cal.basicsal);
            Console.WriteLine("HRA" + cal.HRA);
            Console.WriteLine("DA" + cal.DA);
            Console.WriteLine("TA" + cal.TA);

            Console.WriteLine("Total salary of employe" + cal.total);
            Console.ReadLine();
        }
    }
}
