using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Class1
    {
        static void Main(string[] args)
        {
            int aoldal, boldal, coldal;
            Console.WriteLine("Adja meg a háromszög egyik oldalát!");
            aoldal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adja meg a háromszög másik oldalát!");
            boldal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adja meg a háromszög harmadik oldalát!");
            coldal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A/Az {0} {1} {2} oldalú háromszög kerülete: {3} ",aoldal, boldal, coldal, aoldal + boldal + coldal);
        }
    }
}

