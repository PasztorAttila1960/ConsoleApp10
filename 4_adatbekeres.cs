using System;
using System.Collections.Generic;
using System.Text;
namespace ConsoleApp1
{
    class _4_program
    {
        static void Main(string[] args)
        {
            int r;
            string sugar;
            Console.WriteLine("Adja meg a kör sugarat ");
            sugar = Console.ReadLine();
            r = int.Parse(sugar);
            Console.WriteLine("A/Az {0} sugarú kör kerülete: {1}", r, 2 * r * 3.14);
            Console.WriteLine("A/Az {0} sugarú kör területe : {1}", r, r * r * 3.14);           
        }
    }
}
