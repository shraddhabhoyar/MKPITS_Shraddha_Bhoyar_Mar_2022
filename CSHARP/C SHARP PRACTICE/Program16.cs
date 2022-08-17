using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_example
{
    interface shape
    {
        void draw();
       
    }
    class rectangle : shape
    {
        public void draw()
        {
            Console.WriteLine("rectangle class");
        }
    }
    class circle : shape
    {
        public void draw()
        {
            Console.WriteLine("circle class");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            shape s=new rectangle();
            s.draw();
            s=new circle();
            s.draw();
        }
    }
}
