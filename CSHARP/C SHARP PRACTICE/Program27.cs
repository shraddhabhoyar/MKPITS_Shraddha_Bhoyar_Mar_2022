using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_static_constructor_example
{
    public class account
    {
        public string name;
        public int id;
        public static float rateofinterest;

        public account(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        static account()
        {
            Console.WriteLine("static constructor");
            rateofinterest = 9.5f;
        }
        public void display()
        {
            Console.WriteLine(id+""+name+""+rateofinterest);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
          
            account a1 = new account(111, "ankit");
            account a2 = new account(112, "suraj");
            a1.display();
            a2.display();
        }
    }
}
