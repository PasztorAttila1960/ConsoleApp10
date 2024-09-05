using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class1
    {
        static void Main(string[] args)
        {
            int szülév;
            int dátum;
            string segéd;
            Console.WriteLine("Adja meg a születési évét!");
            segéd = Console.ReadLine();
            szülév = int.Parse(segéd);
            Console.WriteLine("Adja meg az aktuális évszámot!");
            segéd = Console.ReadLine();
            dátum = int.Parse(segéd);
            Console.WriteLine("Aki {0}-ban/ben született. Most {1} éves.", szülév, dátum-szülév);
        }
    }
}
