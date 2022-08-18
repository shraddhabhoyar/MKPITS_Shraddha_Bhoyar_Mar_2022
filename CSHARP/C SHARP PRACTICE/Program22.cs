using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_static
{
    class student
    {
        public static void display()
        {
            Console.WriteLine("hello");
        }
        public void display2()
        {
            Console.WriteLine("hello mkpits");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student.display();
            student s = new student();
            s.display2();
        }
    }
}
