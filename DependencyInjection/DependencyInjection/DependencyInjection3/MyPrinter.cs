using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection3
{
    class MyPrinter
    {
        private string s;

        public MyPrinter(IMyPrintable p)  // injection de dépendance -- interface
        {
            this.s = p.ToPrint();
        }

        public void PrintUpper()
        {
            Console.WriteLine(s.ToUpper()); 
        }

        public void PrintLower()
        {
            Console.WriteLine(s.ToLower());
        }

        public void PrintReverse()
        {
            char[] temp = s.ToCharArray();
            Array.Reverse(temp);
            Console.WriteLine(new string(temp));
        }
    }
}
