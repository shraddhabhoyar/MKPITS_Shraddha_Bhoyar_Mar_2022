using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_method_example
{
    abstract class account
    {
        public abstract void deposite();
    }
    class saving : account
    {
        public override void deposite()
        {
            Console.WriteLine("hello from saving account");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            account act=new saving();
            act.deposite();
        }
    }
}
