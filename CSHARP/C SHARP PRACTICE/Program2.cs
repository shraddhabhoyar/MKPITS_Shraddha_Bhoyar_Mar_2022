using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_base_keyword_example_calling_base_class_method
{
    class person
    {
        public string name = "MKPITS";

        public void display()
        {
            Console.WriteLine("base class field name=" + name);
        }
    }
    class student :person
    {
        public string name = "SOLUTIONS";

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
