﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bonus_manager_peon_clerk_using_switch
{
    class kuchbhi
    {
        static void Main()
        {
            string empname, designation;
            int bonus = 0;
            Console.WriteLine( "enter empname");
            empname = Console.ReadLine();
            Console.WriteLine( "enter designation" );
            designation = Console.ReadLine();
            switch (designation)

            {
                case "manager":
bonus = 10000;
                    break;
                case "clerk":
bonus = 5000;
                    break;
                case "peon":
bonus = 2000;
                    break;
                default:
                    Console.WriteLine( "invalid designation");
                    break;
            }
            Console.WriteLine("empname ={ 0} , bonus = { 1}", empname, bonus);
        }
    }
}

