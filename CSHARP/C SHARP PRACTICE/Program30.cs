using System;
using first;
using second;
namespace first
{
    public class hello
    {
        public void sayhello() 
        { 
            Console.WriteLine("hello namespace");
        }
    }
}
namespace second
{
    public class welcome
    {
        public void saywelcome() 
        { 
            Console.WriteLine("welcome namespace"); 
        }
    }
}
public class TestNamespace
{
    public static void Main()
    {
        hello h1 = new hello();
        welcome w1 = new welcome();
        h1.sayhello();
        w1.saywelcome();
    }
}
