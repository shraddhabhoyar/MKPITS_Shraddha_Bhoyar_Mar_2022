using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_employee_no_para_4constructor_assigment
{
    class employee
    {
        int empid;
        string empname;
        string designation;
        int salary;
        //creating  a constructor with no parameters
        public employee()
        {
            Console.WriteLine("constructor with no parameters called");
            empid = 123;
            empname = "akash";
            designation = "manager";
            salary = 25000;
        }
        //creating a  parameterized constructor with 4 parameters
        public employee(int empid, string empname, string designation, int salary)
        {
            Console.WriteLine("constructor with  parameters called");
            this.empid = empid;
            this.empname = empname;
            this.designation = designation;
            this.salary = salary;

        }
        public void display()
        {
            Console.WriteLine("empid : " + empid);
            Console.WriteLine("empname : " + empname);
            Console.WriteLine("designation: " + designation);
            Console.WriteLine("salary : " + salary);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            employee b1 = new employee(); //this will call constructor with no parameter automatically
            b1.display();


            employee b2 = new employee(200, "shra", "clerk", 24000); //this will call parameterized constructor
            b2.display();
        }
    }
}
