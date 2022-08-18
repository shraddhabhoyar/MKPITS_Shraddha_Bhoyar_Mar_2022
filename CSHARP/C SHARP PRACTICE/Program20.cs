using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_sealed_class_example
{
    abstract class person
    {
        public string name;
    }
    class student:person
    {
        public int rno;
    }
    sealed class parttimestudent:student
    {
        public int hours;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            parttimestudent p = new parttimestudent();
            p.rno = 34;
            p.name = "ankit";
            p.hours = 4;

            Console.WriteLine("rno:"+p.rno);
            Console.WriteLine("name:" + p.name);
            Console.WriteLine("hours:" + p.hours);


        }
    }
}
