using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_static_class_example
{
    public static class school
    {
        public static float pi = 3.14f;
        public static int cube(int n)
        {
            return n * n *n; 
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("value of pi:" + school.pi);
            Console.WriteLine("cube of 3:" + school.cube(5));

        }
    }
}
