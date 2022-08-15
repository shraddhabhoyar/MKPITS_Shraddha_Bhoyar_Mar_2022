using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAP_read_day_number_display_dayname_in_word
{
    internal class Program
    {
        static void Main(string[] args)
        {
			int dayno;
			Console.Write("Input Day No : ");
			dayno = Convert.ToInt32(Console.ReadLine());

			switch (dayno)
			{
				case 1:
					Console.Write("Monday \n");
					break;
				case 2:
					Console.Write("Tuesday \n");
					break;
				case 3:
					Console.Write("Wednesday \n");
					break;
				case 4:
					Console.Write("Thursday \n");
					break;
				case 5:
					Console.Write("Friday \n");
					break;
				case 6:
					Console.Write("Saturday \n");
					break;
				case 7:
					Console.Write("Sunday  \n");
					break;
				default:
					Console.Write("Invalid day number\n");
					break;
			}
		}
	}
}
  

