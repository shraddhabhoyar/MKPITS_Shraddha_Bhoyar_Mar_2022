using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_example_2
{
    interface bank

    {
        string deposite(int actno, int amt);
    }
         
    class saving : bank

    {
        int actno;
        int bal = 1000;
        public string deposite(int actno,int amt)
        {
            this.actno= actno;
            bal = bal + amt;
            return "deposited successfully ,bal is " + bal;
        }
    }
   
    internal class Program
    {
        static void Main(string[] args)
        {
            bank b = new saving();
            string str = b.deposite(123, 2000);
            Console.WriteLine(str);

        }
    }
}
