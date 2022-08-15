using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAP_read_temp_display_suitable_message_acc_temp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temp;
            Console.WriteLine("enter temp");
            temp = Convert.ToInt32(Console.ReadLine());
            if (temp < 0)
                Console.WriteLine("Freezing whether");
            else if (temp < 10)
                Console.Write("Very cold weather");
            else if (temp < 20)
                Console.Write("Cold weather");
            else if (temp < 30)
                Console.Write("Normal in temp");
            else if (temp < 40)
                Console.Write("Its Hot");
            else
                Console.Write("Its very hot");
        }
    }
}
