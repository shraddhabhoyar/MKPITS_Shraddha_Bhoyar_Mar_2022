using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_overloading_2_3_4_parameter_assignement
{
    class student
    {
        int rno;
        string stuname;
        string courses;
        int fees;

        public void getdata()
        {
            rno = 123;
            stuname = "krishna";
            courses = "java";
            fees = 2500;
        }

       public void getdata(int rno,string stuname)
        {
            this.rno = rno;
            this.stuname = stuname;
        }
        public void getdata(int rno, string stuname, string courses)
        {
            this.rno = rno;
            this.stuname = stuname;
            this.courses = courses;
        }
        public void getdata(int rno, string stuname, string courses, int fees)
        {
            this.rno = rno;
            this.stuname = stuname;
            this.courses = courses;
            this.fees = fees;
        }
        public void display()
        {
            Console.WriteLine("bookid=" + rno);
            Console.WriteLine("bookname=" + stuname);
            Console.WriteLine("author=" + courses);
            Console.WriteLine("price=" + fees);

        }




    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student b = new student();
            b.getdata();
            b.display();
            Console.WriteLine("this is student details");

            student b1 = new student();
            b1.getdata(124, "shraddha");
            b1.display();
            Console.WriteLine("this is student1 details");

            student b2 = new student();
            b2.getdata(124, "akshay", "python");
            b2.display();
            Console.WriteLine("this is student2 details");

            student b3 = new student();
            b3.getdata(124, "aniket", "c#", 1200);
            b3.display();
            Console.WriteLine("this is book4 details");

            Console.ReadLine();





        }
    }
}
