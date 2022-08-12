using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_product_no_para_4constructor_assignment
{
    class product
    {
        int prodid;
        string prodname;
        int price;
        int quantity;
        //creating  a constructor with no parameters
        public product()
        {
            Console.WriteLine("constructor with no parameters called");
            prodid = 123;
            prodname = "pen";
            price = 15;
            quantity = 10;
        }
        //creating a  parameterized constructor with 4 parameters
        public product(int prodid, string prodname, int price, int quantity)
        {
            Console.WriteLine("constructor with  parameters called");
            this.prodid = prodid;
            this.prodname = prodname;
            this.price = price;
            this.quantity = quantity;

        }
        public void display()
        {
            Console.WriteLine("prodid : " + prodid);
            Console.WriteLine("prodname : " + prodname);
            Console.WriteLine("price: " + price);
            Console.WriteLine("quantity : " + quantity);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            product p1 = new product(); //this will call constructor with no parameter automatically
            p1.display();


            product p2 = new product(200, "pencil", 10, 100); //this will call parameterized constructor
            p2.display();
        }
    }
}
