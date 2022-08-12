using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vovwels_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("enter char ");
            ch = Convert.ToChar(Console.ReadLine());
            switch (ch)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("it is a vowel");
                    break;
                
                default:
                    Console.WriteLine("it is not a vowel");
                    break;

                    
            }
            Console.ReadLine();


        }

    }
    }

