using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product_getdata_displayorder
{
    class product
    {
        int prodid;
        string prodname;
        float prodrate;
        int quantity;


        public void productdata()
        {
            Console.WriteLine("enter product id");
            prodid=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter product name");
            prodname=Console.ReadLine();
            Console.WriteLine("enter product rate");
            prodrate=Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("enter quantity");
            quantity=Convert.ToInt32(Console.ReadLine());
        }
         public void displayorder()
        {
            Console.WriteLine("prodid" + prodid);
            Console.WriteLine("prodname" + prodname);
            Console.WriteLine("prodrate" + prodrate);
            Console.WriteLine("quantity" + quantity);

        }





    }
    internal class Program
    {
        static void Main(string[] args)
        {
            product prod=new product();
            prod.productdata();
            prod.displayorder();

            Console.ReadLine();


        }
    }
}
