using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAP_to_read_age_and_display_it_is_eligible_for_vote_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1;
            Console.WriteLine("enter age of candidate");
            n1=Convert.ToInt32(Console.ReadLine()); 
            if(n1<18)
            {
                Console.WriteLine("you are not eligible for vote");
            }
            else
            {
                Console.WriteLine("Congratulations!You are eligible for casting your vote");
            }
        }
    }
}
