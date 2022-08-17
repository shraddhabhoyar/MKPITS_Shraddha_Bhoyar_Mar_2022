using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_example_3
{
    interface bank
    {
        string deposite(int actno, int amt);

    }
    class account
    {
        public int actno;
        public int bal = 1000;
    }
    class saving:account,bank
    {
        public string deposite(int actno, int amt)
        {
            this.actno = actno;
           bal=bal+amt;
            return "deposited successfully successfully ,bal is " + bal;
        }
 }
    internal class Program
    {
        static void Main(string[] args)
        {
            bank b=new saving();
            string str = b.deposite(123, 5000);
            Console.WriteLine(str);
        }
    }
}
