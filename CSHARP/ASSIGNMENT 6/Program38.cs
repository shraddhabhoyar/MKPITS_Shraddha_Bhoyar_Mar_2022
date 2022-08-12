using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_employee_no_para_assignment
{
    class employee
    {
        int  empno;
        string  empname;
        string  designation;
        int  salary;

        public  employee()
        {
            empno = 123;
            empname = "shraddha";
            designation = "customer relations manager";
            salary = 25000;
        }
       
         public void display()
        {
            Console.WriteLine("empno=" + empno);
            Console.WriteLine("empname=" + empname);
            Console.WriteLine("designation=" + designation);

            Console.WriteLine("salary=" + salary);



        }


    }
    internal class Program
    {

        static void Main(string[] args)
        {
            employee emp=new employee();
            emp.display();

            Console.ReadLine();




        }
    }
}
