using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAP_eligible_admission_professional_course_based_criteria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int phy, che, ma;
            Console.WriteLine("enter physics marks");
            phy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter chemistry marks");
            che = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter maths marks");
            ma = Convert.ToInt32(Console.ReadLine());
            Console.Write("total marks in maths,physics,chemistry:{0}",ma+phy+che);
            Console.Write("total marks in maths and physics:{0}", ma + phy);

            if (ma >= 65)
                if (phy >= 55)
                    if (che >= 50)
                        if ((ma + phy + che) >= 180 || (ma + phy) >= 140)
                            Console.WriteLine("candidate is eligible for admission");
                        else
                            Console.WriteLine("candidate is not eligible");
                    else
                        Console.WriteLine("candidate is not eligible");

                else
                    Console.WriteLine("candidate is not eligible");

            else
                Console.WriteLine("candidate is not eligible");


        }
    }
}
