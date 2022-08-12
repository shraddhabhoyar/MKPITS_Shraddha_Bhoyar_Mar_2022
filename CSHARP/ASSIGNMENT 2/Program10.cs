using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vowels_if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("enter any char");
            ch=Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch=='u')
            {
                Console.WriteLine("character is vowel");  
            }
            else
            {
                Console.WriteLine("character is not a vowel");
            }
            Console.ReadLine();

        }
    }
}
