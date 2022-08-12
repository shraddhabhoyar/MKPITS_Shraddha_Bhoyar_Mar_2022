using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_person_employee
{
    public class Person
    {
        String name;
        String address;
        public void getPersonData(String name, String address)
        {
            this.name = name;
            this.address = address;
        }
        public void displayPersonData()
        {
            Console.WriteLine("name : " + name);
            Console.WriteLine("address : " + address);

        }
    }
    public class employee : Person
    {
        int empno;
        int salary;
        public void getStudentData(int empno, int salary)
        {
            this.empno = empno;
            this.salary = salary;
        }
        public void displayStudentData()
        {
            Console.WriteLine("empno : " + empno);
            Console.WriteLine("salary : " + salary);

        }
    }
    class TestInheritance
    {
        public static void Main(string[] args)
        {
           employee p1 = new employee();//creating object of child class\
            p1.getPersonData("krishna", "nagpur");
            p1.getStudentData(111, 25000);
            p1.displayStudentData();
            p1.displayPersonData();
        }
    }
}
