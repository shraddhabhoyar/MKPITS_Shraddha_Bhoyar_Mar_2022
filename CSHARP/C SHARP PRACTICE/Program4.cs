using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calling_base_class_method_constructor_internally
{
    class person
    {
        string name = "MKPITS";

        public person()
        {
            Console.WriteLine("person class constructor called");
        }

        public void display()
        {
            Console.WriteLine(" base class field name=" + name);
        }

    }
    class student : person
    {
        string name = "SOLUTIONS";

        public student()
        {
            Console.WriteLine("student class constructor called");
        }
        public void display()
        {
            base.display();
            Console.WriteLine("child class field name=" + name);
        }
        

        }



    
    internal class Program
    {
        static void Main(string[] args)
        {
            student s=new student();
            s.display();
        }
    }
}
