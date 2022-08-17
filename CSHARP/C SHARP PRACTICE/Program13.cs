using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_method_overriding_method
{
    public class animal
    {
        public virtual void eat()
        {
            Console.WriteLine("eating");
        }
    }
    public class dog : animal
    {
        public override void eat()
        {
            Console.WriteLine("eating bread");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            animal ani = new dog();
            ani.eat();
        }
    }
}
