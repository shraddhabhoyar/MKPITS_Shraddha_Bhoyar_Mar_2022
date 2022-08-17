using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_example_id_name_email
{
    class student
    {
        public int id { get; set; }
        public string name { get; set; }
        public string mailid { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s = new student();
            s.id = 1243;
            s.name = "ankita";
            s.mailid = "abc@gmail.com";

            Console.WriteLine("id:" + s.id);
            Console.WriteLine("name:" + s.name);
            Console.WriteLine("mailid:" + s.mailid);


        }
    }
}
