using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customer_data_assignment
{
    class customer
    {
        public int custno;
        public string custname;
        public string custaddress;
        public long custtelno;

    }
    internal class Program
    {
        static void Main()
        {
            customer cust=new customer();
            cust.custno = 123;
            cust.custname = "shraddha";
            cust.custaddress = "nagpur maharashtra";
            cust.custtelno = 9876543210;


            Console.WriteLine("custno" + cust.custno);
            Console.WriteLine("custname" + cust.custname);
            Console.WriteLine("custaddress" + cust.custaddress);
            Console.WriteLine("custtelno" + cust.custtelno);
            Console.ReadLine();
        }
    }
}
