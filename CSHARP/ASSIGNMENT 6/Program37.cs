using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_product_constructor_assignment
{
    class product
    {
        int productid;
        string productname;
        int price;
        int quantity;

        public product()
        {
            productid = 123;
            productname = "pen";
            price = 12;
            quantity = 10;

        }
        public void display()
        {
            Console.WriteLine("productid="+productid);
            Console.WriteLine("productname="+productname);
            Console.WriteLine("price="+price);
            Console.WriteLine("quantity="+quantity);
         }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            product p1=new product();
            p1.display();

            Console.ReadLine();
        }
    }
}
