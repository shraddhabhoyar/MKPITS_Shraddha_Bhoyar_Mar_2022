using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creating_and_using_classes_wf_bank_example
{
    internal class bank
    {
        public int accno;
        public int bal = 1000;

        public string deposit (int amount)
        {
            bal = bal + amount;
            return "amount deposited successfully,bal is" + bal.ToString();
        }
        public string withdrawl (int amount)
        {
            string res = null;
            if(amount>bal)
            {
                res = "insufficient balance";
            }
            else
            {
                bal = bal - amount;
                res = "amount withdrawl successfully,bal is" + bal.ToString();
            }
            return res;
        }
        public string showbalance()
        {
            return "balance amount is" + bal.ToString();
        }
    }
}
