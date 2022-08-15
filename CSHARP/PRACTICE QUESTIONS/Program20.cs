using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAP_read_month_number_display_number_days_for_this_month
{
    internal class Program
    {
        static void Main(string[] args)
        {
			int monthno;
			Console.Write("Input Month No : ");
			monthno = Convert.ToInt32(Console.ReadLine());
			switch (monthno)
			{
				case 1:
				case 3:
				case 5:
				case 7:
				case 8:
				case 10:
				case 12:
					Console.Write("Month  have 31 days \n");
					break;
				case 2:
					Console.Write(" February have 28 days \n");
		            break;
				case 4:
				case 6:
				case 9:
				case 11:
					Console.Write("Month have 30 days. \n");
					break;
				default:
					Console.Write("invalid Month number");
					break;
			}
		}
	}
}
    

