using System;
using first;
using first.second;
namespace first
{
    public class hello
    {
        public void sayhello() 
        { 
            Console.WriteLine("hello first namespace");
        }
    }
    
    namespace second
    {
        public class welcome
        {
            public void sayhello()
            {
                Console.WriteLine("hello second namespace");
            }
        }
    }
}
 internal class Program
    {

        static void Main(string[] args)
        {
            hello h1 = new hello();
            h1.sayhello();
            welcome w = new welcome();
            w.sayhello();
        }
    }

