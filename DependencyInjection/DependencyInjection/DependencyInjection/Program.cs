using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Bonjour";

            MyPrinter mp = new MyPrinter(a);

            mp.PrintUpper();
            mp.PrintLower();
            mp.PrintReverse();

            Console.ReadKey();
        }
    }
}
