using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection2a
{
    class MyPrinter
    {
        private string s;

        public MyPrinter() { }

        public void SetS(string s)   // injection de dépendance -- mutateur
        {
            this.s = s;
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
