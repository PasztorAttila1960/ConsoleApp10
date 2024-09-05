using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Class1
    {
        static void Main(string[] args)
        {
            int aoldal, boldal;
            Console.WriteLine("Adja meg a téglalap egyik oldalát!");
            aoldal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adja meg a téglalap másik oldalát!");
            boldal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A/Az {0} {1} oldalú téglalap kerülete: {2}, területe: {3}",aoldal,boldal,2*(aoldal+boldal),(aoldal*boldal));
               
        }
    }
}
