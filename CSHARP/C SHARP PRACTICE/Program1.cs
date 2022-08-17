using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base_keyword_csharp_which_access_field_base_class
{

    namespace ConsoleApp19
    {
        class person
        {
            public string name = "mkpits";
        }
        class student : person
        {
            public string name = "roshan";
            public void display()
            {
                Console.WriteLine("name = " + name); //roshan
                Console.WriteLine(" base class field name = " + base.name);
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                student s = new student();
                s.display();
            }
        }
    }
}
