using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection3
{
    class MyMsg : IMyPrintable
    {
        private string msg; 

        public MyMsg(string s)
        {
            msg = s;
        }       
        public string ToPrint()
        {
            return "["+ msg + "]";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyMsg m = new MyMsg("Bonjour");

            MyPrinter mp = new MyPrinter(m);

            mp.PrintUpper();
            mp.PrintLower();
            mp.PrintReverse();

            Console.ReadKey();
        }
    }
}
