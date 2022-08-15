using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAP_check_alphabate_vowel_consoant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;

            Console.WriteLine("Enter any character");
            ch = Convert.ToChar(Console.ReadLine());


            
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {

                Console.WriteLine("this is vowel");

            }
            else 
            {
                Console.WriteLine("this is Consonant");
            }

            Console.ReadLine();
        }
    }
}
    
