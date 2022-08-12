using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cust_getdata_showdata_assignment
{
    class customer
    {
        int custno;
        string custname;
        string custaddress;
        int custtelno;
        public void getcustomerdata()
        {
            Console.WriteLine("enter customer number");
            custno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter customer name");
            custname = Console.ReadLine();
            Console.WriteLine("enter customer address");
            custaddress =Console.ReadLine();
            Console.WriteLine("enter customer telephone number");
            custtelno = Convert.ToInt32(Console.ReadLine());

        }
        public void displaycustomerdata()
        {
            Console.WriteLine("custno=" + custno);
            Console.WriteLine("custname=" + custname);
            Console.WriteLine("custaddress=" + custaddress);
            Console.WriteLine("custtelno=" + custtelno);


        }
    }


    internal class Program
    {
        static void Main()
        {
            customer cust = new customer();
            cust.getcustomerdata();
            cust.displaycustomerdata();

            Console.ReadLine();
        }
    }
}


