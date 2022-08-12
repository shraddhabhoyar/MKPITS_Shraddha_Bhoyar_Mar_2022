using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_5_Q_7_marks_calculate
{
    class Student
    {
        public string stuname;
        public int rno;
        public int m1;
        public int ch1;
        public int ph1;
        float total = 0;
        public float per;

        public void totaldata()
        {
            total = ch1 + m1 + ph1;
            Console.WriteLine("Total " + total);
            per = total * 0.3f;
            Console.WriteLine("percentage " + total);


        }
    }
    internal class Program
    {
        static void Main()
        {
            Student stu = new Student();

            Console.WriteLine("Enter student name");
            stu.stuname = Console.ReadLine();
            Console.WriteLine("Enter student roll number");
            stu.rno = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter student math mark");
            stu.m1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter student chemistry mark");
            stu.ch1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter student physic mark");
            stu.ph1 = Convert.ToInt16(Console.ReadLine());

            Console.ReadLine();

        }
    }
}