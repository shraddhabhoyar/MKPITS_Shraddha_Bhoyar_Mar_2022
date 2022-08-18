using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_static_field_changing_static_field
{
    public class account
    {
        public int accno;
        public string name;
        public static float rateofinterest = 8.8f;

        public account(int accno, string name)
        {
            this.accno = accno;
            this.name = name;
        }
        public void display()
        {
            Console.WriteLine(accno + "" + name + "" + rateofinterest);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            account.rateofinterest = 10.5f;
            account a = new account(123, "ankita");
            a.display();
            account a1 = new account(124, "suraj");
            a1.display();
        }
    }
}
