using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base_keyword_which_calls_method_base_class_animal_example
{
    public class animal

    {
        public void eat()
        {
            Console.WriteLine("eating");
        }
    }

    public class dog : animal
    {
        public void eat()
        {
            base.eat();
            Console.WriteLine("eating bread");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            dog g=new dog();
            g.eat();
        }
    }
}
