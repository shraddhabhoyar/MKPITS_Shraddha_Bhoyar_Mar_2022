using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_field_example_counting_objects
{
    public class account
    {
        public int accno;
        public string name;
        public static int count = 0;

        public account(int accno, string name)
        {
            this.accno = accno;
            this.name = name;
            count = count + 1;
        }
        public void display()
        {
            Console.WriteLine(accno + "" + name );
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        
            account a = new account(123, "ankita");
            a.display();
            account a1 = new account(124, "suraj");
            a1.display();
            Console.WriteLine("total objects are:"+account.count);
        }
    }
}
