using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creating_using_classes_wf_runtime_polymorphism
{
    abstract class account
    {
        public int accno;
        public int bal = 1000;
        public abstract string deposite(int amt);

        public string withdrawl(int amt)
        {
            string res = null;

            if (amt > bal)
            {
                res = "insufficient balance";
            }
            else
            {
                bal = bal - amt;
                res = "withdrawl successfully " + bal.ToString();
            }
            return res;
        }
        public string showbalance()
        {
            return "balance amount is " + bal.ToString();
        }

    }
    class saving :account
    {
        public override string deposite(int amt)
        {
            int interest = 500;
            bal = bal + amt + interest;
            return "amount deposited successfully with interest , bal is " + bal.ToString();

        }
    }
    class current : account
    {
        public override string deposite(int amt)
        {

            bal = bal + amt;
            return "amount deposited successfully without interest , bal is " + bal.ToString();

        }
    }
}

    



        

