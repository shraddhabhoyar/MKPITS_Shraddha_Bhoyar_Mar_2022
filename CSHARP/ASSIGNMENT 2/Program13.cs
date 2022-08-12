using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product_discount_programme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int product_rate,product_quantity,total_amount,discount,total_tobe_paid;
            string product_name;
            Console.WriteLine("enter product_name");
            product_name = Console.ReadLine();
            Console.WriteLine("enter product_rate");
            product_rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter product_quantity");
            product_quantity = Convert.ToInt32(Console.ReadLine());
            total_amount = product_rate* product_quantity;
            Console.WriteLine("total_amount=" + total_amount);
            if(total_amount>2000)
                    {
                discount=(total_amount*50)/ 100;
                total_tobe_paid=total_amount - discount;
            }
            else
            {
                discount = (total_amount * 10)/ 100;
                total_tobe_paid=total_amount - discount;

            }
            Console.WriteLine("total_tobe_paid=" + total_tobe_paid);
            Console.ReadLine();
        }
    }
}
