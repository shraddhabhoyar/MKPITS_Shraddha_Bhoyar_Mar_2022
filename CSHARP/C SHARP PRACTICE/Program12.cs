using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class_having_abstract_method_with_derived_classes
{
    abstract class account
    {
        public int acctno;
        public int bal = 1000;

        public abstract string deposite(int acctno,int bal);

        public string showbalance()
        {
            return "balance amount" + bal;
        }

    }
    class Current : account
    {
        
        public override string deposite(int actno, int amount)
        {
            this.acctno = actno;
            bal = bal + amount;
            return "amount deposited successfully without interest in current class";
        }
    }

    class saving : account
    {
       
        public override string deposite(int actno, int amount)
        {
            this.acctno = actno;
            int interest = 500;
            bal = bal + amount + interest;
            return "amount deposited successfully with interest in saving class";
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter account number");
            int acctno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter amount to be deposited ");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter account type (saving or currrent)");
            String acttype = Console.ReadLine();
            account act = null;
            if(acttype=="saving")
            {
                act = new saving();
            }
            else if(acttype=="current")
            {
                act = new Current();
            }
            String res = act.deposite(acctno, amount);
            Console.WriteLine("account no is " + act.acctno);
            Console.WriteLine(res);
            res = act.showbalance();
            Console.WriteLine(res);
         }
    }
}
