using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_sealed_method
{
    class person
    {
        public virtual void display()
        {
            Console.WriteLine("hello from class");
        }
    }
    class student : person
    {
        public string name;
        public sealed override void display()
        {
            Console.WriteLine("hello from department");
        }
    }
    class parttime : student
    {
       
    }


    class Program
    {
        static void Main(string[] args)
        {
            parttime p = new parttime();
            p.display();
        }
    }
}

