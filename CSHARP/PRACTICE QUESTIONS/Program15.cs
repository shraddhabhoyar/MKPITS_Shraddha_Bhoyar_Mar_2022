using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAP_to_calculate_profit_loss_on_a_transaction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cp, sp,c;

            Console.Write("Input Cost Price: ");
            cp = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Selling Price: ");
            sp = Convert.ToInt32(Console.ReadLine());

            if (sp > cp)
            {
                c = sp - cp;
                Console.Write(" booked your profit amount : {0}", c);
            }
            else if (cp > sp)
            {
                c = cp - sp;
                Console.Write(" got a loss of amount : {0}", c);
            }
            else
            {
                Console.Write("running in no profit no loss condition");
            }
        }
    }

}
    

