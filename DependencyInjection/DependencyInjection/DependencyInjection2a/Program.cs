using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection2a
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Bonjour";

            MyPrinter mp = new MyPrinter();
            mp.SetS(a);

            mp.PrintUpper();
            mp.PrintLower();
            mp.PrintReverse();

            Console.ReadKey();
        }
    }
}
