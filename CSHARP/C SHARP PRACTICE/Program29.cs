using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_namespace_example_by_fully_qualified_name
{
    namespace first
    {
        public class hello
        {
            public void sayhello()
            {  
                Console.WriteLine("hello first namespace");
            }
        }
    }
    namespace second
    {
        public class hello
        {
            public void sayhello() 
            { 
                Console.WriteLine("hello second namespace"); 
            }
        }
    }
    public class TestNamespace
    {
        public static void Main()
        {
            first.hello h1 = new first.hello();
            second.hello h2 = new second.hello();
            h1.sayhello();
            h2.sayhello();

        }
    }
}


