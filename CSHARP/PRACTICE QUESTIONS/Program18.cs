﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAP_read_any_digit_display_in_word
{
    internal class Program
    {
        static void Main(string[] args)
        {
			int digit;
            Console.Write("Input Digit: ");
			digit = Convert.ToInt32(Console.ReadLine());

			switch (digit)
			{
				case 0:
					Console.Write("Zero\n");
					break;

				case 1:
					Console.Write("one\n");
					break;
				case 2:
					Console.Write("Two\n");
					break;
				case 3:
					Console.Write("Three\n");
					break;
				case 4:
					Console.Write("Four\n");
					break;
				case 5:
					Console.Write("Five\n");
					break;
				case 6:
					Console.Write("Six\n");
					break;
				case 7:
					Console.Write("Seven\n");
					break;
				case 8:
					Console.Write("Eight\n");
					break;
				case 9:
					Console.Write("Nine\n");
					break;
				default:
					Console.Write("invalid digit");
					break;
			}
		}
	}
}
    

