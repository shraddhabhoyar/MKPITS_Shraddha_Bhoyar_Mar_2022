using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_class_base_person_der_class_empno_salary_desi
{
    public class person
    {
        public string name;
        public string address;
    }
    public class employee : person
    {
        public int empno;
        public int salary;
        public string designation;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            employee em=new employee();
            em.name = "krishna";
            em.address = "nagpur";
            em.empno = 123;
            em.salary = 25000;
            em.designation = "manager";



            Console.WriteLine("name=" + em.name);
            Console.WriteLine("address=" + em.address);
            Console.WriteLine("empno=" + em.empno);
            Console.WriteLine("salary=" + em.salary);
            Console.WriteLine("designation=" + em.designation);





        }
    }
}
